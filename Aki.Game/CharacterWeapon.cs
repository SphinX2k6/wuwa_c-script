using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x0200271E RID: 10014
[NullableContext(1)]
[Nullable(0)]
public class CharacterWeapon
{
	// Token: 0x060191F2 RID: 102898 RVA: 0x007A8856 File Offset: 0x007A6A56
	public CharacterWeapon(int index, UMeshComponent mesh, [Nullable(2)] UEffectModelBase hideEffectMode, int? entityId = null)
	{
		this.Index = index;
		this.Mesh = mesh;
		this.HideEffectMode = hideEffectMode;
		this.EntityId = entityId;
		this.VisibleHelper = new WeaponMeshVisibleHelper(this);
	}

	// Token: 0x060191F3 RID: 102899 RVA: 0x007A8892 File Offset: 0x007A6A92
	public void Destroy()
	{
		this.ReleaseHideEffect();
		if (this.SceneInteractId != 0)
		{
			SceneBattleInteractModel.Instance.DestroySceneBattleInteract(this.SceneInteractId);
		}
	}

	// Token: 0x060191F4 RID: 102900 RVA: 0x007A88B4 File Offset: 0x007A6AB4
	public void ReleaseHideEffect()
	{
		if (EffectSystem.Instance.IsValid(this.WeaponHideEffect))
		{
			EffectSystem.Instance.StopEffectById(this.WeaponHideEffect, "[CharacterWeapon.Destroy]", true, null);
			this.WeaponHideEffect = 0;
		}
	}

	// Token: 0x060191F5 RID: 102901 RVA: 0x007A88FC File Offset: 0x007A6AFC
	[NullableContext(2)]
	public void ShowHideEffect(string effectPath = null)
	{
		FTransformDouble value = this.Mesh.D_GetSocketTransform(FNameUtil.EMPTY, ERelativeTransformSpace.RTS_World);
		if (!EffectSystem.Instance.IsValid(this.WeaponHideEffect))
		{
			SkeletalMeshEffectContext skeletalMeshEffectContext = new SkeletalMeshEffectContext(this.EntityId, null, false);
			skeletalMeshEffectContext.SkeletalMeshComp = (USkeletalMeshComponent)this.Mesh;
			EffectSystem instance = EffectSystem.Instance;
			UObject mesh = this.Mesh;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			this.WeaponHideEffect = instance.SpawnEffect(mesh, ftransformDouble, effectPath ?? "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_WeaponEnd.DA_Fx_Group_WeaponEnd", "[CharacterWeapon.ShowHideEffect]", skeletalMeshEffectContext, EEffectType.Scene, null, null, null, false, false);
		}
		if (!EffectSystem.Instance.IsValid(this.WeaponHideEffect))
		{
			this.WeaponHideEffect = 0;
			return;
		}
		this.UpdateHideEffectStateInSelfCentered();
		if (!string.IsNullOrEmpty(effectPath))
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.WeaponHideEffect);
		effectActor.K2_AttachToComponent(this.Mesh, new FName?(FNameUtil.EMPTY), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
		FHitResult fhitResult = new FHitResult();
		effectActor.D_K2_SetActorTransform(value, false, ref fhitResult, true);
	}

	// Token: 0x060191F6 RID: 102902 RVA: 0x007A89E8 File Offset: 0x007A6BE8
	public void SetBuffEffectsHiddenInGame(bool isHidden)
	{
		List<int> list = null;
		foreach (int num in this.WeaponBuffEffects)
		{
			if (!EffectSystem.Instance.IsValid(num))
			{
				if (list == null)
				{
					list = new List<int>();
				}
				list.Add(num);
			}
			else
			{
				AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(num);
				if (sureEffectActor != null && sureEffectActor.IsValid() && sureEffectActor.bHidden != isHidden)
				{
					EffectSystem.Instance.SetEffectHidden(num, isHidden, null, false);
				}
			}
		}
		if (list != null)
		{
			foreach (int item in list)
			{
				this.WeaponBuffEffects.Remove(item);
			}
		}
	}

	// Token: 0x060191F7 RID: 102903 RVA: 0x007A8ACC File Offset: 0x007A6CCC
	public void AddBuffEffect(int effectId)
	{
		this.WeaponBuffEffects.Add(effectId);
		if (this.WeaponHidden && EffectSystem.Instance.GetEffectActor(effectId).IsValid())
		{
			EffectSystem.Instance.SetEffectHidden(effectId, true, null, false);
		}
	}

	// Token: 0x060191F8 RID: 102904 RVA: 0x007A8B03 File Offset: 0x007A6D03
	public void RemoveBuffEffect(int effectId)
	{
		this.WeaponBuffEffects.Remove(effectId);
	}

	// Token: 0x060191F9 RID: 102905 RVA: 0x007A8B12 File Offset: 0x007A6D12
	public void InitWeaponSceneInteract(int weaponType)
	{
		this.SceneInteractWeaponType = weaponType;
	}

	// Token: 0x060191FA RID: 102906 RVA: 0x007A8B1C File Offset: 0x007A6D1C
	public void UpdateSceneInteractEnable(bool isWeaponOut)
	{
		if (!SceneBattleInteractModel.Instance.Open)
		{
			this.SceneInteractId = 0;
			return;
		}
		bool flag = isWeaponOut && !this.WeaponHidden;
		if (this.SceneInteractId != 0)
		{
			SceneBattleInteractModel.Instance.SetSceneBattleInteractEnable(this.SceneInteractId, flag, 0f);
			return;
		}
		if (!flag)
		{
			return;
		}
		BP_SceneBattleInteract_C weaponInteractConfig = SceneBattleInteractModel.Instance.GetWeaponInteractConfig(this.SceneInteractWeaponType);
		if (weaponInteractConfig != null)
		{
			SceneBattleInteractEffect sceneBattleInteractEffect = SceneBattleInteractModel.Instance.CreateSceneBattleInteract(weaponInteractConfig, 0f, 0f);
			if (sceneBattleInteractEffect != null)
			{
				this.SceneInteractId = sceneBattleInteractEffect.Id;
				sceneBattleInteractEffect.SetIsCommonWeapon(true);
				sceneBattleInteractEffect.SetDispatchWeaponEventEnable(true);
				sceneBattleInteractEffect.BindEntityId(this.EntityId.GetValueOrDefault());
				sceneBattleInteractEffect.SetUpdateLocationSocket(this.Mesh, FNameUtil.EMPTY);
				sceneBattleInteractEffect.SetEnable(true, 0f);
			}
		}
	}

	// Token: 0x060191FB RID: 102907 RVA: 0x007A8BE6 File Offset: 0x007A6DE6
	public void UpdateSelfCenteredState()
	{
		this.UpdateHideEffectStateInSelfCentered();
	}

	// Token: 0x060191FC RID: 102908 RVA: 0x007A8BF0 File Offset: 0x007A6DF0
	public void UpdateHideEffectStateInSelfCentered()
	{
		if (this.EntityId == null || !EffectSystem.Instance.IsValid(this.WeaponHideEffect))
		{
			return;
		}
		PawnTimeScaleComponent component = EntitySystem.Instance.GetComponent<PawnTimeScaleComponent>(this.EntityId.Value);
		if (component == null || !component.Valid)
		{
			return;
		}
		ForeverTimeScale topForeverTimeScaleConfig = component.GetTopForeverTimeScaleConfig(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView));
		if (topForeverTimeScaleConfig == null)
		{
			return;
		}
		EffectSystem.Instance.SetAdditionTimeScale(topForeverTimeScaleConfig.SourceType, this.WeaponHideEffect, topForeverTimeScaleConfig.TimeDilation);
	}

	// Token: 0x0400DB62 RID: 56162
	public FName? NormalSocket;

	// Token: 0x0400DB63 RID: 56163
	public FName? BattleSocket;

	// Token: 0x0400DB64 RID: 56164
	public int? BattleEffectId;

	// Token: 0x0400DB65 RID: 56165
	public FTransformDouble LerpStartTransform;

	// Token: 0x0400DB66 RID: 56166
	public FTransformDouble LerpEndTransform;

	// Token: 0x0400DB67 RID: 56167
	public bool WeaponHidden;

	// Token: 0x0400DB68 RID: 56168
	public int WeaponHideEffect;

	// Token: 0x0400DB69 RID: 56169
	public HashSet<int> WeaponBuffEffects = new HashSet<int>();

	// Token: 0x0400DB6A RID: 56170
	public int SceneInteractId;

	// Token: 0x0400DB6B RID: 56171
	public int SceneInteractWeaponType;

	// Token: 0x0400DB6C RID: 56172
	public WeaponMeshVisibleHelper VisibleHelper;

	// Token: 0x0400DB6D RID: 56173
	public int Index;

	// Token: 0x0400DB6E RID: 56174
	public UMeshComponent Mesh;

	// Token: 0x0400DB6F RID: 56175
	[Nullable(2)]
	public UEffectModelBase HideEffectMode;

	// Token: 0x0400DB70 RID: 56176
	public int? EntityId;
}
