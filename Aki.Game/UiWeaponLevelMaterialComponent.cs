using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CC1 RID: 11457
[NullableContext(2)]
[Nullable(0)]
public class UiWeaponLevelMaterialComponent : UiModelComponentBase
{
	// Token: 0x06017F16 RID: 98070 RVA: 0x00616AE9 File Offset: 0x00614CE9
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.LoadComponent = base.Owner.CheckGetComponent<UiModelLoadComponent>();
	}

	// Token: 0x06017F17 RID: 98071 RVA: 0x00616B20 File Offset: 0x00614D20
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.TryApply));
		ResourceSystem.Instance.LoadTypeAsync("BP_CharacterRenderingFunctionLibrary_C", delegate
		{
			this.IsTypeLoaded = true;
			this.TryApply();
		}, "Ui.WeaponUi");
	}

	// Token: 0x06017F18 RID: 98072 RVA: 0x00616B6F File Offset: 0x00614D6F
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.TryApply));
	}

	// Token: 0x06017F19 RID: 98073 RVA: 0x00616B93 File Offset: 0x00614D93
	public void SetBreachLevel(int breachLevel)
	{
		this.BreachLevel = breachLevel;
	}

	// Token: 0x06017F1A RID: 98074 RVA: 0x00616B9C File Offset: 0x00614D9C
	public void TryApply()
	{
		if (!this.IsTypeLoaded || this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			return;
		}
		UiModelActorComponent actorComponent = this.ActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComponent != null) ? actorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		WeaponModel.Instance.SetWeaponBreachLevelForMesh(uskeletalMeshComponent, this.BreachLevel);
		SModelConfig modelConfig = ModelUtil.GetModelConfig(this.ModelDataComponent.ModelConfigId);
		string text;
		if (modelConfig == null)
		{
			text = null;
		}
		else
		{
			FSoftObjectPath da = modelConfig.DA;
			text = ((da != null) ? da.GetAssetPathString() : null);
		}
		string text2 = text;
		if (string.IsNullOrEmpty(text2))
		{
			return;
		}
		UiModelLoadComponent loadComponent = this.LoadComponent;
		PD_WeaponLevelMaterialDatas_C pd_WeaponLevelMaterialDatas_C = ((loadComponent != null) ? loadComponent.GetLoadedResource(text2) : null) as PD_WeaponLevelMaterialDatas_C;
		if (pd_WeaponLevelMaterialDatas_C == null)
		{
			return;
		}
		WeaponController.Instance.ApplyWeaponLevelMaterial(uskeletalMeshComponent, pd_WeaponLevelMaterialDatas_C, this.BreachLevel);
	}

	// Token: 0x0400B274 RID: 45684
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B275 RID: 45685
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B276 RID: 45686
	private UiModelLoadComponent LoadComponent;

	// Token: 0x0400B277 RID: 45687
	private int BreachLevel;

	// Token: 0x0400B278 RID: 45688
	private bool IsTypeLoaded;
}
