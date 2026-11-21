using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;

// Token: 0x02000F46 RID: 3910
[NullableContext(1)]
[Nullable(0)]
public class DynamicTabCamera : IStaticVariableResetter
{
	// Token: 0x06009C6B RID: 40043 RVA: 0x002E68D0 File Offset: 0x002E4AD0
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

	// Token: 0x06009C6C RID: 40044 RVA: 0x002E6936 File Offset: 0x002E4B36
	public static void CreateStaticDefaultValue()
	{
		DynamicTabCamera.CameraFinishedCallbackMap = new Dictionary<string, Action>();
	}

	// Token: 0x06009C6D RID: 40045 RVA: 0x002E6942 File Offset: 0x002E4B42
	public static void ResetStaticDefaultValue()
	{
		DynamicTabCamera.CameraHandleData = null;
		DynamicTabCamera.CameraFinishedCallbackMap = null;
	}

	// Token: 0x06009C6E RID: 40046 RVA: 0x002E6950 File Offset: 0x002E4B50
	private static string GetRoleUiCamera(string uiCameraSettingsName)
	{
		return uiCameraSettingsName + "_" + RoleModel.Instance.GetCurSelectMainRoleInstance().GetRoleConfig().RoleBody;
	}

	// Token: 0x06009C6F RID: 40047 RVA: 0x002E697F File Offset: 0x002E4B7F
	public static UiCameraHandleData GetCameraHandleData()
	{
		return DynamicTabCamera.CameraHandleData;
	}

	// Token: 0x06009C70 RID: 40048 RVA: 0x002E6986 File Offset: 0x002E4B86
	[NullableContext(2)]
	public static void PlayTabUiCamera(EUiTabViewName tabViewName, string uiCameraBlendName = null)
	{
	}

	// Token: 0x06009C71 RID: 40049 RVA: 0x002E6988 File Offset: 0x002E4B88
	public static void OnPlayCameraAnimationFinished(UiCameraDefine.IFinishData finishData)
	{
		string handleName = finishData.ToHandleData.GetHandleName();
		Action action;
		if (DynamicTabCamera.CameraFinishedCallbackMap.TryGetValue(handleName, out action) && action != null)
		{
			action();
		}
	}

	// Token: 0x06009C72 RID: 40050 RVA: 0x002E69BC File Offset: 0x002E4BBC
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

	// Token: 0x04005D36 RID: 23862
	[Nullable(2)]
	private static UiCameraHandleData CameraHandleData;

	// Token: 0x04005D37 RID: 23863
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, Action> CameraFinishedCallbackMap;

	// Token: 0x04005D38 RID: 23864
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EUiViewName, Func<string, string>> TabCameraNameMap;
}
