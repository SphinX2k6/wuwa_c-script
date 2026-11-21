using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200221A RID: 8730
[NullableContext(2)]
[Nullable(0)]
public class UiWeaponLevelMaterialComponent : UiModelComponentBase
{
	// Token: 0x0601578F RID: 87951 RVA: 0x0063C7A9 File Offset: 0x0063A9A9
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.LoadComponent = base.Owner.CheckGetComponent<UiModelLoadComponent>();
	}

	// Token: 0x06015790 RID: 87952 RVA: 0x0063C7E0 File Offset: 0x0063A9E0
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.TryApply));
		ResourceSystem.Instance.LoadTypeAsync("BP_CharacterRenderingFunctionLibrary_C", delegate
		{
			this.IsTypeLoaded = true;
			this.TryApply();
		}, "Ui.WeaponUi");
	}

	// Token: 0x06015791 RID: 87953 RVA: 0x0063C82F File Offset: 0x0063AA2F
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.TryApply));
	}

	// Token: 0x06015792 RID: 87954 RVA: 0x0063C853 File Offset: 0x0063AA53
	public void SetBreachLevel(int breachLevel)
	{
		this.BreachLevel = breachLevel;
	}

	// Token: 0x06015793 RID: 87955 RVA: 0x0063C85C File Offset: 0x0063AA5C
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

	// Token: 0x0400B5DF RID: 46559
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B5E0 RID: 46560
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B5E1 RID: 46561
	private UiModelLoadComponent LoadComponent;

	// Token: 0x0400B5E2 RID: 46562
	private int BreachLevel;

	// Token: 0x0400B5E3 RID: 46563
	private bool IsTypeLoaded;
}
