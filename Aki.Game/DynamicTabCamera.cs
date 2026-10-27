using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;

// Token: 0x02001A87 RID: 6791
[NullableContext(1)]
[Nullable(0)]
public class DynamicTabCamera : IStaticVariableResetter
{
	// Token: 0x0600C85A RID: 51290 RVA: 0x002DB728 File Offset: 0x002D9928
	static DynamicTabCamera()
	{
		Dictionary<EUiViewName, Func<string, string>> dictionary = new Dictionary<EUiViewName, Func<string, string>>();
		EUiViewName roleRootView = EUiViewName.RoleRootView;
		dictionary[roleRootView] = new Func<string, string>(DynamicTabCamera.GetRoleUiCamera);
		EUiViewName roleHandBookRootView = EUiViewName.RoleHandBookRootView;
		dictionary[roleHandBookRootView] = new Func<string, string>(DynamicTabCamera.GetRoleUiCamera);
		DynamicTabCamera.TabCameraNameMap = dictionary;
		StaticVariableRegister.RegisterAndExecute(new Action(DynamicTabCamera.CreateStaticDefaultValue), new Action(DynamicTabCamera.ResetStaticDefaultValue));
	}

	// Token: 0x0600C85B RID: 51291 RVA: 0x002DB78E File Offset: 0x002D998E
	public static void CreateStaticDefaultValue()
	{
		DynamicTabCamera.CameraFinishedCallbackMap = new Dictionary<string, Action>();
	}

	// Token: 0x0600C85C RID: 51292 RVA: 0x002DB79A File Offset: 0x002D999A
	public static void ResetStaticDefaultValue()
	{
		DynamicTabCamera.CameraHandleData = null;
		DynamicTabCamera.CameraFinishedCallbackMap = null;
	}

	// Token: 0x0600C85D RID: 51293 RVA: 0x002DB7A8 File Offset: 0x002D99A8
	private static string GetRoleUiCamera(string uiCameraSettingsName)
	{
		return uiCameraSettingsName + "_" + RoleModel.Instance.GetCurSelectMainRoleInstance().GetRoleConfig().RoleBody;
	}

	// Token: 0x0600C85E RID: 51294 RVA: 0x002DB7D7 File Offset: 0x002D99D7
	public static UiCameraHandleData GetCameraHandleData()
	{
		return DynamicTabCamera.CameraHandleData;
	}

	// Token: 0x0600C85F RID: 51295 RVA: 0x002DB7DE File Offset: 0x002D99DE
	[NullableContext(2)]
	public static void PlayTabUiCamera(EUiTabViewName tabViewName, string uiCameraBlendName = null)
	{
	}

	// Token: 0x0600C860 RID: 51296 RVA: 0x002DB7E0 File Offset: 0x002D99E0
	public static void OnPlayCameraAnimationFinished(UiCameraAnimationDefine.IFinishData finishData)
	{
		string handleName = finishData.ToHandleData.HandleName;
		Action action;
		if (DynamicTabCamera.CameraFinishedCallbackMap.TryGetValue(handleName, out action) && action != null)
		{
			action();
		}
	}

	// Token: 0x0600C861 RID: 51297 RVA: 0x002DB814 File Offset: 0x002D9A14
	public static string GetUiCameraHandleName(EUiTabViewName tabViewName)
	{
		UiDynamicTab viewTab = DynamicTabConfig.Instance.GetViewTab(tabViewName);
		EUiViewName key = (EUiViewName)viewTab.ParentViewName;
		Func<string, string> func;
		if (DynamicTabCamera.TabCameraNameMap.TryGetValue(key, out func))
		{
			return func(viewTab.UiCameraSettingsName);
		}
		return viewTab.UiCameraSettingsName;
	}

	// Token: 0x04005C67 RID: 23655
	[Nullable(2)]
	private static UiCameraHandleData CameraHandleData;

	// Token: 0x04005C68 RID: 23656
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, Action> CameraFinishedCallbackMap;

	// Token: 0x04005C69 RID: 23657
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EUiViewName, Func<string, string>> TabCameraNameMap;
}
