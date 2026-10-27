using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.HotPatchPushSdk;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DE2 RID: 3554
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroPushController : ControllerBase
{
	// Token: 0x0600557B RID: 21883 RVA: 0x000F6486 File Offset: 0x000F4686
	public bool IfCanUsePush()
	{
		return false;
	}

	// Token: 0x0600557C RID: 21884 RVA: 0x000F648C File Offset: 0x000F468C
	protected override bool OnInit()
	{
		if (UKuroLauncherLibrary.IsFirstIntoLauncher())
		{
			this.FirstLaunchInitPush();
		}
		this.RefreshSettingByPushMode();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Push;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "current push clientId";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("clientId", this.GetClientId());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x000F64E0 File Offset: 0x000F46E0
	private UniTask FirstLaunchInitPush()
	{
		KuroPushController.<FirstLaunchInitPush>d__5 <FirstLaunchInitPush>d__;
		<FirstLaunchInitPush>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FirstLaunchInitPush>d__.<>4__this = this;
		<FirstLaunchInitPush>d__.<>1__state = -1;
		<FirstLaunchInitPush>d__.<>t__builder.Start<KuroPushController.<FirstLaunchInitPush>d__5>(ref <FirstLaunchInitPush>d__);
		return <FirstLaunchInitPush>d__.<>t__builder.Task;
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x000F6524 File Offset: 0x000F4724
	private UniTask TryGetAndroidPushPermission()
	{
		KuroPushController.<TryGetAndroidPushPermission>d__6 <TryGetAndroidPushPermission>d__;
		<TryGetAndroidPushPermission>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryGetAndroidPushPermission>d__.<>4__this = this;
		<TryGetAndroidPushPermission>d__.<>1__state = -1;
		<TryGetAndroidPushPermission>d__.<>t__builder.Start<KuroPushController.<TryGetAndroidPushPermission>d__6>(ref <TryGetAndroidPushPermission>d__);
		return <TryGetAndroidPushPermission>d__.<>t__builder.Task;
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x000F6568 File Offset: 0x000F4768
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private UniTask<List<string>> RequestAndroidPermissions(TArray<string> permissions)
	{
		KuroPushController.<RequestAndroidPermissions>d__7 <RequestAndroidPermissions>d__;
		<RequestAndroidPermissions>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<string>>.Create();
		<RequestAndroidPermissions>d__.permissions = permissions;
		<RequestAndroidPermissions>d__.<>1__state = -1;
		<RequestAndroidPermissions>d__.<>t__builder.Start<KuroPushController.<RequestAndroidPermissions>d__7>(ref <RequestAndroidPermissions>d__);
		return <RequestAndroidPermissions>d__.<>t__builder.Task;
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x000F65AC File Offset: 0x000F47AC
	[Conditional("KURO_PUSH_SDK")]
	public void BindCurrentLanguageTag()
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Push;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "current push Language Tag";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", packageLanguage);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKuroPushSdkStaticLibrary.SetTag(packageLanguage, "push");
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x000F65FC File Offset: 0x000F47FC
	private void RefreshSettingByPushMode()
	{
		int num = (this.GetPushState() > false) ? 1 : 0;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "刷新推送状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.PushMode);
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x000F6654 File Offset: 0x000F4854
	private UniTask InitPushByNotiPermissionState()
	{
		KuroPushController.<InitPushByNotiPermissionState>d__10 <InitPushByNotiPermissionState>d__;
		<InitPushByNotiPermissionState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPushByNotiPermissionState>d__.<>4__this = this;
		<InitPushByNotiPermissionState>d__.<>1__state = -1;
		<InitPushByNotiPermissionState>d__.<>t__builder.Start<KuroPushController.<InitPushByNotiPermissionState>d__10>(ref <InitPushByNotiPermissionState>d__);
		return <InitPushByNotiPermissionState>d__.<>t__builder.Task;
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x000F6697 File Offset: 0x000F4897
	[Conditional("KURO_PUSH_SDK")]
	private void InitListener()
	{
		if (!this.ListenerState)
		{
			UKuroPushObject pushObject = UKuroPushSdkStaticLibrary.GetPushObject();
			if (pushObject != null)
			{
				pushObject.PushSdkMessageBluePrintDelegate.Add(new Action<string, string>(this.PushCallBack));
			}
		}
		this.ListenerState = true;
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x000F66CC File Offset: 0x000F48CC
	[Conditional("KURO_PUSH_SDK")]
	public void RemovePushDelegate()
	{
		if (this.ListenerState)
		{
			UKuroPushObject pushObject = UKuroPushSdkStaticLibrary.GetPushObject();
			if (pushObject != null && pushObject.IsValid())
			{
				pushObject.PushSdkMessageBluePrintDelegate.Remove(new Action<string, string>(this.PushCallBack));
			}
			this.ListenerState = false;
		}
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x000F6710 File Offset: 0x000F4910
	public void SetPushNotifyCall(Action<string, string> callBack)
	{
		this.OnPushNotifyCall = callBack;
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x000F6719 File Offset: 0x000F4919
	private void PushCallBack(string functionName, string result)
	{
		Action<string, string> onPushNotifyCall = this.OnPushNotifyCall;
		if (onPushNotifyCall == null)
		{
			return;
		}
		onPushNotifyCall(functionName, result);
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x000F672D File Offset: 0x000F492D
	public void SendLocalPush(string title, string desc, string exData)
	{
		HotPatchPushSdk.SendLocalPush(title, desc, exData);
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x000F6737 File Offset: 0x000F4937
	public void OpenNotification()
	{
		this.IfCanUsePush();
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x000F6740 File Offset: 0x000F4940
	[NullableContext(0)]
	public UniTask<bool> GetPushNotiPermissionEnableState()
	{
		KuroPushController.<GetPushNotiPermissionEnableState>d__17 <GetPushNotiPermissionEnableState>d__;
		<GetPushNotiPermissionEnableState>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<GetPushNotiPermissionEnableState>d__.<>4__this = this;
		<GetPushNotiPermissionEnableState>d__.<>1__state = -1;
		<GetPushNotiPermissionEnableState>d__.<>t__builder.Start<KuroPushController.<GetPushNotiPermissionEnableState>d__17>(ref <GetPushNotiPermissionEnableState>d__);
		return <GetPushNotiPermissionEnableState>d__.<>t__builder.Task;
	}

	// Token: 0x0600558A RID: 21898 RVA: 0x000F6783 File Offset: 0x000F4983
	public string GetClientId()
	{
		this.IfCanUsePush();
		return "";
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x000F6794 File Offset: 0x000F4994
	public UniTask TurnOnPush(bool checkPermissionState = true)
	{
		KuroPushController.<TurnOnPush>d__19 <TurnOnPush>d__;
		<TurnOnPush>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TurnOnPush>d__.<>4__this = this;
		<TurnOnPush>d__.checkPermissionState = checkPermissionState;
		<TurnOnPush>d__.<>1__state = -1;
		<TurnOnPush>d__.<>t__builder.Start<KuroPushController.<TurnOnPush>d__19>(ref <TurnOnPush>d__);
		return <TurnOnPush>d__.<>t__builder.Task;
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x000F67DF File Offset: 0x000F49DF
	public void TurnOffPush()
	{
		this.RefreshSettingByPushMode();
	}

	// Token: 0x0600558D RID: 21901 RVA: 0x000F67E7 File Offset: 0x000F49E7
	public bool GetPushState()
	{
		return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.CachePushOpenState, false);
	}

	// Token: 0x0600558E RID: 21902 RVA: 0x000F67F5 File Offset: 0x000F49F5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x0600558F RID: 21903 RVA: 0x000F67F8 File Offset: 0x000F49F8
	public static KuroPushController Instance
	{
		get
		{
			return KuroPushController._Instance;
		}
	}

	// Token: 0x06005590 RID: 21904 RVA: 0x000F67FF File Offset: 0x000F49FF
	public static KuroPushController GetOrCreateInstance()
	{
		if (KuroPushController._Instance == null)
		{
			KuroPushController.CreateInstance();
		}
		return KuroPushController._Instance;
	}

	// Token: 0x06005591 RID: 21905 RVA: 0x000F6813 File Offset: 0x000F4A13
	public static bool CreateInstance()
	{
		if (KuroPushController._Instance != null)
		{
			return true;
		}
		KuroPushController._Instance = new KuroPushController();
		return true;
	}

	// Token: 0x06005592 RID: 21906 RVA: 0x000F6829 File Offset: 0x000F4A29
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005593 RID: 21907 RVA: 0x000F682B File Offset: 0x000F4A2B
	public static void ResetStaticDefaultValue()
	{
		KuroPushController._Instance = null;
	}

	// Token: 0x06005594 RID: 21908 RVA: 0x000F6833 File Offset: 0x000F4A33
	static KuroPushController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroPushController.CreateStaticDefaultValue), new Action(KuroPushController.ResetStaticDefaultValue));
	}

	// Token: 0x040026C5 RID: 9925
	private const string SELFDEFINESN = "push";

	// Token: 0x040026C6 RID: 9926
	private bool ListenerState;

	// Token: 0x040026C7 RID: 9927
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, string> OnPushNotifyCall;

	// Token: 0x040026C8 RID: 9928
	[Nullable(2)]
	private static KuroPushController _Instance;
}
