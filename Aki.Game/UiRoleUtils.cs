using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Utils;

// Token: 0x020021B7 RID: 8631
[NullableContext(1)]
[Nullable(0)]
public class UiRoleUtils
{
	// Token: 0x060153DE RID: 87006 RVA: 0x0062D0CC File Offset: 0x0062B2CC
	public static void PlayRoleChangeEffect(TsUiSceneRoleActor roleActor)
	{
		if (roleActor == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.TL, "PlayRoleChangeEffect roleActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelBase model = roleActor.Model;
		if (model == null)
		{
			return;
		}
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = model.CheckGetComponent<UiModelRenderingMaterialComponent>();
		string effectPath = EffectUtil.GetEffectPath("ChangeRoleMaterialController");
		PD_CharacterControllerData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<PD_CharacterControllerData_C>(effectPath);
		if (loadedAsset != null && uiModelRenderingMaterialComponent != null)
		{
			uiModelRenderingMaterialComponent.AddRenderingMaterialByData(loadedAsset);
		}
		UiModelUtil.Instance.PlayEffectOnRoot(model, "ChangeRoleEffect");
	}

	// Token: 0x060153DF RID: 87007 RVA: 0x0062D144 File Offset: 0x0062B344
	public static void PlayRoleLevelUpEffect(TsUiSceneRoleActor roleActor)
	{
		if (roleActor == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.TL, "PlayRoleLevelUpEffect roleActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelBase model = roleActor.Model;
		UiModelUtil.Instance.SetRenderingMaterial(model, "RoleLevelUpMaterialController");
		UiModelUtil.Instance.PlayEffectOnRoot(model, "RoleLevelUpEffect");
	}

	// Token: 0x060153E0 RID: 87008 RVA: 0x0062D19C File Offset: 0x0062B39C
	public static void PlayRoleBreachFinishEffect(TsUiSceneRoleActor roleActor)
	{
		if (roleActor == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.TL, "PlayRoleBreachFinishEffect roleActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelBase model = roleActor.Model;
		UiModelUtil.Instance.SetRenderingMaterial(model, "RoleBreachFinishMaterialController");
		UiModelUtil.Instance.PlayEffectOnRoot(model, "RoleBreachFinishEffect");
	}
}
