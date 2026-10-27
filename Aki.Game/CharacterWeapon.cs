using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020031AF RID: 12719
[NullableContext(1)]
[Nullable(0)]
public class CharacterWeapon
{
	// Token: 0x0601B6BF RID: 112319 RVA: 0x007804D6 File Offset: 0x0077E6D6
	public CharacterWeapon(int index, UMeshComponent mesh, [Nullable(2)] UEffectModelBase hideEffectMode, int? entityId = null)
	{
		this.Index = index;
		this.Mesh = mesh;
		this.HideEffectMode = hideEffectMode;
		this.EntityId = entityId;
		this.VisibleHelper = new WeaponMeshVisibleHelper(this);
	}

	// Token: 0x0601B6C0 RID: 112320 RVA: 0x00780512 File Offset: 0x0077E712
	public void Destroy()
	{
		this.ReleaseHideEffect();
		if (this.SceneInteractId != 0)
		{
			SceneBattleInteractModel.Instance.DestroySceneBattleInteract(this.SceneInteractId);
		}
	}

	// Token: 0x0601B6C1 RID: 112321 RVA: 0x00780534 File Offset: 0x0077E734
	public void ReleaseHideEffect()
	{
		if (EffectSystem.Instance.IsValid(this.WeaponHideEffect))
		{
			EffectSystem.Instance.StopEffectById(this.WeaponHideEffect, "[CharacterWeapon.Destroy]", true, null);
			this.WeaponHideEffect = 0;
		}
	}

	// Token: 0x0601B6C2 RID: 112322 RVA: 0x0078057C File Offset: 0x0077E77C
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

	// Token: 0x0601B6C3 RID: 112323 RVA: 0x00780668 File Offset: 0x0077E868
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

	// Token: 0x0601B6C4 RID: 112324 RVA: 0x0078074C File Offset: 0x0077E94C
	public void AddBuffEffect(int effectId)
	{
		this.WeaponBuffEffects.Add(effectId);
		if (this.WeaponHidden && EffectSystem.Instance.GetEffectActor(effectId).IsValid())
		{
			EffectSystem.Instance.SetEffectHidden(effectId, true, null, false);
		}
	}

	// Token: 0x0601B6C5 RID: 112325 RVA: 0x00780783 File Offset: 0x0077E983
	public void RemoveBuffEffect(int effectId)
	{
		this.WeaponBuffEffects.Remove(effectId);
	}

	// Token: 0x0601B6C6 RID: 112326 RVA: 0x00780792 File Offset: 0x0077E992
	public void InitWeaponSceneInteract(int weaponType)
	{
		this.SceneInteractWeaponType = weaponType;
	}

	// Token: 0x0601B6C7 RID: 112327 RVA: 0x0078079C File Offset: 0x0077E99C
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

	// Token: 0x0601B6C8 RID: 112328 RVA: 0x00780866 File Offset: 0x0077EA66
	public void UpdateSelfCenteredState()
	{
		this.UpdateHideEffectStateInSelfCentered();
	}

	// Token: 0x0601B6C9 RID: 112329 RVA: 0x00780870 File Offset: 0x0077EA70
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

	// Token: 0x0400D6DB RID: 55003
	public FName? NormalSocket;

	// Token: 0x0400D6DC RID: 55004
	public FName? BattleSocket;

	// Token: 0x0400D6DD RID: 55005
	public int? BattleEffectId;

	// Token: 0x0400D6DE RID: 55006
	public FTransformDouble LerpStartTransform;

	// Token: 0x0400D6DF RID: 55007
	public FTransformDouble LerpEndTransform;

	// Token: 0x0400D6E0 RID: 55008
	public bool WeaponHidden;

	// Token: 0x0400D6E1 RID: 55009
	public int WeaponHideEffect;

	// Token: 0x0400D6E2 RID: 55010
	public HashSet<int> WeaponBuffEffects = new HashSet<int>();

	// Token: 0x0400D6E3 RID: 55011
	public int SceneInteractId;

	// Token: 0x0400D6E4 RID: 55012
	public int SceneInteractWeaponType;

	// Token: 0x0400D6E5 RID: 55013
	public WeaponMeshVisibleHelper VisibleHelper;

	// Token: 0x0400D6E6 RID: 55014
	public int Index;

	// Token: 0x0400D6E7 RID: 55015
	public UMeshComponent Mesh;

	// Token: 0x0400D6E8 RID: 55016
	[Nullable(2)]
	public UEffectModelBase HideEffectMode;

	// Token: 0x0400D6E9 RID: 55017
	public int? EntityId;
}
