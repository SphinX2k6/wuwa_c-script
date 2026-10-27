using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A32 RID: 10802
public class SkinFadeAnimController : IStaticVariableResetter
{
	// Token: 0x060167E2 RID: 92130 RVA: 0x005B38E3 File Offset: 0x005B1AE3
	static SkinFadeAnimController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkinFadeAnimController.CreateStaticDefaultValue), new Action(SkinFadeAnimController.ResetStaticDefaultValue));
	}

	// Token: 0x060167E3 RID: 92131 RVA: 0x005B3904 File Offset: 0x005B1B04
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EModelStateInSkinView, Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>> dictionary = new Dictionary<EModelStateInSkinView, Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>>();
		EModelStateInSkinView key = EModelStateInSkinView.ShowRole;
		Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>> dictionary2 = new Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>();
		dictionary2[EModelStateInSkinView.ShowWeapon] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeIn, ERoleFadeCurveDefine.WeaponSkinRoleFadeInCurve);
		dictionary2[EModelStateInSkinView.ShowGlider] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeIn, ERoleFadeCurveDefine.FlySkinRoleFadeInCurve);
		dictionary2[EModelStateInSkinView.ShowCalabash] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeIn, ERoleFadeCurveDefine.TerminalSkinRoleFadeInCurve);
		dictionary[key] = dictionary2;
		EModelStateInSkinView key2 = EModelStateInSkinView.ShowWeapon;
		Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>> dictionary3 = new Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>();
		dictionary3[EModelStateInSkinView.ShowRole] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeOut, ERoleFadeCurveDefine.WeaponSkinRoleFadeOutCurve);
		dictionary[key2] = dictionary3;
		EModelStateInSkinView key3 = EModelStateInSkinView.ShowGlider;
		Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>> dictionary4 = new Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>();
		dictionary4[EModelStateInSkinView.ShowRole] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeOut, ERoleFadeCurveDefine.FlySkinRoleFadeOutCurve);
		dictionary[key3] = dictionary4;
		EModelStateInSkinView key4 = EModelStateInSkinView.ShowCalabash;
		Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>> dictionary5 = new Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>();
		dictionary5[EModelStateInSkinView.ShowRole] = new ValueTuple<EModelFadeType, ERoleFadeCurveDefine>(EModelFadeType.FadeOut, ERoleFadeCurveDefine.TerminalSkinRoleFadeOutCurve);
		dictionary[key4] = dictionary5;
		SkinFadeAnimController.fadeCurveMap = dictionary;
	}

	// Token: 0x060167E4 RID: 92132 RVA: 0x005B39B7 File Offset: 0x005B1BB7
	public static void ResetStaticDefaultValue()
	{
		SkinFadeAnimController.fadeCurveMap = null;
	}

	// Token: 0x060167E5 RID: 92133 RVA: 0x005B39C0 File Offset: 0x005B1BC0
	public void ChangeModelState(EModelStateInSkinView? state)
	{
		EModelStateInSkinView? modelState = this.ModelState;
		EModelStateInSkinView? emodelStateInSkinView = state;
		if (modelState.GetValueOrDefault() == emodelStateInSkinView.GetValueOrDefault() & modelState != null == (emodelStateInSkinView != null))
		{
			return;
		}
		EModelStateInSkinView? modelState2 = this.ModelState;
		this.ModelState = state;
		EModelStateInSkinView? emodelStateInSkinView2 = state;
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		UiModelBase uiModelBase = (tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>> dictionary = (modelState2 != null) ? SkinFadeAnimController.fadeCurveMap.GetValueOrDefault(modelState2.Value) : null;
		if (dictionary != null && emodelStateInSkinView2 != null)
		{
			ValueTuple<EModelFadeType, ERoleFadeCurveDefine>? valueOrNull = dictionary.GetValueOrNull(emodelStateInSkinView2.Value);
			ValueTuple<EModelFadeType, ERoleFadeCurveDefine>? valueTuple = valueOrNull;
			if (valueTuple != null)
			{
				if (valueOrNull.Value.Item1 == EModelFadeType.FadeIn)
				{
					UiModelUtil.Instance.ModelFadeIn(uiModelBase, new ERoleFadeCurveDefine?(valueOrNull.Value.Item2), null);
					return;
				}
				UiModelUtil.Instance.ModelFadeOut(uiModelBase, new ERoleFadeCurveDefine?(valueOrNull.Value.Item2), null);
			}
		}
	}

	// Token: 0x0400A6FB RID: 42747
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private static Dictionary<EModelStateInSkinView, Dictionary<EModelStateInSkinView, ValueTuple<EModelFadeType, ERoleFadeCurveDefine>>> fadeCurveMap;

	// Token: 0x0400A6FC RID: 42748
	[Nullable(2)]
	public TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A6FD RID: 42749
	private EModelStateInSkinView? ModelState = new EModelStateInSkinView?(EModelStateInSkinView.ShowRole);
}
