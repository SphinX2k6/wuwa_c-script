using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Utils;

// Token: 0x02002C5E RID: 11358
[NullableContext(1)]
[Nullable(0)]
public class UiRoleUtils
{
	// Token: 0x06017B6A RID: 97130 RVA: 0x00607608 File Offset: 0x00605808
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

	// Token: 0x06017B6B RID: 97131 RVA: 0x00607680 File Offset: 0x00605880
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

	// Token: 0x06017B6C RID: 97132 RVA: 0x006076D8 File Offset: 0x006058D8
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
