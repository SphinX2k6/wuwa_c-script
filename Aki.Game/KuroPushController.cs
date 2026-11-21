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

// Token: 0x02000294 RID: 660
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class KuroPushController : ControllerBase
{
	// Token: 0x06002905 RID: 10501 RVA: 0x000FD97E File Offset: 0x000FBB7E
	public bool IfCanUsePush()
	{
		return false;
	}

	// Token: 0x06002906 RID: 10502 RVA: 0x000FD984 File Offset: 0x000FBB84
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

	// Token: 0x06002907 RID: 10503 RVA: 0x000FD9D8 File Offset: 0x000FBBD8
	private UniTask FirstLaunchInitPush()
	{
		KuroPushController.<FirstLaunchInitPush>d__5 <FirstLaunchInitPush>d__;
		<FirstLaunchInitPush>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FirstLaunchInitPush>d__.<>4__this = this;
		<FirstLaunchInitPush>d__.<>1__state = -1;
		<FirstLaunchInitPush>d__.<>t__builder.Start<KuroPushController.<FirstLaunchInitPush>d__5>(ref <FirstLaunchInitPush>d__);
		return <FirstLaunchInitPush>d__.<>t__builder.Task;
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x000FDA1C File Offset: 0x000FBC1C
	private UniTask TryGetAndroidPushPermission()
	{
		KuroPushController.<TryGetAndroidPushPermission>d__6 <TryGetAndroidPushPermission>d__;
		<TryGetAndroidPushPermission>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryGetAndroidPushPermission>d__.<>4__this = this;
		<TryGetAndroidPushPermission>d__.<>1__state = -1;
		<TryGetAndroidPushPermission>d__.<>t__builder.Start<KuroPushController.<TryGetAndroidPushPermission>d__6>(ref <TryGetAndroidPushPermission>d__);
		return <TryGetAndroidPushPermission>d__.<>t__builder.Task;
	}

	// Token: 0x06002909 RID: 10505 RVA: 0x000FDA60 File Offset: 0x000FBC60
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

	// Token: 0x0600290A RID: 10506 RVA: 0x000FDAA4 File Offset: 0x000FBCA4
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

	// Token: 0x0600290B RID: 10507 RVA: 0x000FDAF4 File Offset: 0x000FBCF4
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

	// Token: 0x0600290C RID: 10508 RVA: 0x000FDB4C File Offset: 0x000FBD4C
	private UniTask InitPushByNotiPermissionState()
	{
		KuroPushController.<InitPushByNotiPermissionState>d__10 <InitPushByNotiPermissionState>d__;
		<InitPushByNotiPermissionState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPushByNotiPermissionState>d__.<>4__this = this;
		<InitPushByNotiPermissionState>d__.<>1__state = -1;
		<InitPushByNotiPermissionState>d__.<>t__builder.Start<KuroPushController.<InitPushByNotiPermissionState>d__10>(ref <InitPushByNotiPermissionState>d__);
		return <InitPushByNotiPermissionState>d__.<>t__builder.Task;
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x000FDB8F File Offset: 0x000FBD8F
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

	// Token: 0x0600290E RID: 10510 RVA: 0x000FDBC4 File Offset: 0x000FBDC4
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

	// Token: 0x0600290F RID: 10511 RVA: 0x000FDC08 File Offset: 0x000FBE08
	public void SetPushNotifyCall(Action<string, string> callBack)
	{
		this.OnPushNotifyCall = callBack;
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x000FDC11 File Offset: 0x000FBE11
	private void PushCallBack(string functionName, string result)
	{
		Action<string, string> onPushNotifyCall = this.OnPushNotifyCall;
		if (onPushNotifyCall == null)
		{
			return;
		}
		onPushNotifyCall(functionName, result);
	}

	// Token: 0x06002911 RID: 10513 RVA: 0x000FDC25 File Offset: 0x000FBE25
	public void SendLocalPush(string title, string desc, string exData)
	{
		HotPatchPushSdk.SendLocalPush(title, desc, exData);
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x000FDC2F File Offset: 0x000FBE2F
	public void OpenNotification()
	{
		this.IfCanUsePush();
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x000FDC38 File Offset: 0x000FBE38
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

	// Token: 0x06002914 RID: 10516 RVA: 0x000FDC7B File Offset: 0x000FBE7B
	public string GetClientId()
	{
		this.IfCanUsePush();
		return "";
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x000FDC8C File Offset: 0x000FBE8C
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

	// Token: 0x06002916 RID: 10518 RVA: 0x000FDCD7 File Offset: 0x000FBED7
	public void TurnOffPush()
	{
		this.RefreshSettingByPushMode();
	}

	// Token: 0x06002917 RID: 10519 RVA: 0x000FDCDF File Offset: 0x000FBEDF
	public bool GetPushState()
	{
		return LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.CachePushOpenState, false);
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x000FDCED File Offset: 0x000FBEED
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x06002919 RID: 10521 RVA: 0x000FDCF0 File Offset: 0x000FBEF0
	public static KuroPushController Instance
	{
		get
		{
			return KuroPushController._Instance;
		}
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x000FDCF7 File Offset: 0x000FBEF7
	public static KuroPushController GetOrCreateInstance()
	{
		if (KuroPushController._Instance == null)
		{
			KuroPushController.CreateInstance();
		}
		return KuroPushController._Instance;
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x000FDD0B File Offset: 0x000FBF0B
	public static bool CreateInstance()
	{
		if (KuroPushController._Instance != null)
		{
			return true;
		}
		KuroPushController._Instance = new KuroPushController();
		return true;
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x000FDD21 File Offset: 0x000FBF21
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x000FDD23 File Offset: 0x000FBF23
	public static void ResetStaticDefaultValue()
	{
		KuroPushController._Instance = null;
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x000FDD2B File Offset: 0x000FBF2B
	static KuroPushController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroPushController.CreateStaticDefaultValue), new Action(KuroPushController.ResetStaticDefaultValue));
	}

	// Token: 0x0400274D RID: 10061
	private const string SELFDEFINESN = "push";

	// Token: 0x0400274E RID: 10062
	private bool ListenerState;

	// Token: 0x0400274F RID: 10063
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, string> OnPushNotifyCall;

	// Token: 0x04002750 RID: 10064
	[Nullable(2)]
	private static KuroPushController _Instance;
}
