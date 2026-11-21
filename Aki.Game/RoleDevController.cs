using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDev.Define;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001D8A RID: 7562
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleDevController : UiControllerBase
{
	// Token: 0x06012ACD RID: 76493 RVA: 0x0057F755 File Offset: 0x0057D955
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06012ACE RID: 76494 RVA: 0x0057F757 File Offset: 0x0057D957
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06012ACF RID: 76495 RVA: 0x0057F759 File Offset: 0x0057D959
	protected override void OnAddEvents()
	{
	}

	// Token: 0x06012AD0 RID: 76496 RVA: 0x0057F75B File Offset: 0x0057D95B
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x06012AD1 RID: 76497 RVA: 0x0057F75D File Offset: 0x0057D95D
	private void OnLoadingNetDataDone()
	{
		this.RequestRoleDevelopConfig(null);
	}

	// Token: 0x06012AD2 RID: 76498 RVA: 0x0057F768 File Offset: 0x0057D968
	public UniTask RequestRoleDevelopConfigAndOpenView(int roleId)
	{
		RoleDevController.<RequestRoleDevelopConfigAndOpenView>d__5 <RequestRoleDevelopConfigAndOpenView>d__;
		<RequestRoleDevelopConfigAndOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleDevelopConfigAndOpenView>d__.<>4__this = this;
		<RequestRoleDevelopConfigAndOpenView>d__.roleId = roleId;
		<RequestRoleDevelopConfigAndOpenView>d__.<>1__state = -1;
		<RequestRoleDevelopConfigAndOpenView>d__.<>t__builder.Start<RoleDevController.<RequestRoleDevelopConfigAndOpenView>d__5>(ref <RequestRoleDevelopConfigAndOpenView>d__);
		return <RequestRoleDevelopConfigAndOpenView>d__.<>t__builder.Task;
	}

	// Token: 0x06012AD3 RID: 76499 RVA: 0x0057F7B3 File Offset: 0x0057D9B3
	public void OpenRoleDevelopView(int roleId)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleDevRootView, roleId, null);
	}

	// Token: 0x06012AD4 RID: 76500 RVA: 0x0057F7CC File Offset: 0x0057D9CC
	[NullableContext(2)]
	public void RequestRoleDevelopConfig(Action callback = null)
	{
		RoleDevelopConfigRequest roleDevelopConfigRequest = RoleDevelopConfigRequest.Create();
		roleDevelopConfigRequest.Version = RoleDevModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.RoleDevelopConfigRequest, roleDevelopConfigRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleDevelopConfigResponse roleDevelopConfigResponse = (RoleDevelopConfigResponse)msg;
			if (roleDevelopConfigResponse == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RoleDev;
				ELogAuthor author = ELogAuthor.WMQ;
				string message = "RoleDevelopConfig请求无响应";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", roleDevelopConfigResponse);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RoleDevelopConfigs configs = roleDevelopConfigResponse.Configs;
			if (configs == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RoleDev;
				ELogAuthor author2 = ELogAuthor.LJS;
				string message2 = "RoleDevelopConfig Configs为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("response", roleDevelopConfigResponse);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			RoleDevModel.Instance.UpdateRoleDevConfig(configs);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06012AD5 RID: 76501 RVA: 0x0057F81C File Offset: 0x0057DA1C
	public void RequestRecordRoleMarkOperation(int roleId)
	{
		RoleUpdateDevelopTargetRequest roleUpdateDevelopTargetRequest = RoleUpdateDevelopTargetRequest.Create();
		roleUpdateDevelopTargetRequest.RoleId = roleId;
		roleUpdateDevelopTargetRequest.Source = 2;
		Net.Instance.Call(ERequestMessageId.RoleUpdateDevelopTargetRequest, roleUpdateDevelopTargetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleUpdateDevelopTargetResponse roleUpdateDevelopTargetResponse = (RoleUpdateDevelopTargetResponse)msg;
			if (roleUpdateDevelopTargetResponse == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RoleDev;
				ELogAuthor author = ELogAuthor.WMQ;
				string message = "RoleUpdateDevelopTarget请求无响应";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", roleUpdateDevelopTargetResponse);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (roleUpdateDevelopTargetResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleUpdateDevelopTargetResponse.ErrorCode, 29614, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06012AD6 RID: 76502 RVA: 0x0057F870 File Offset: 0x0057DA70
	private void HandleRoleUpdateDevelopTargetNotify(RoleUpdateDevelopTargetNotify notify, [Nullable(2)] Net.CallbackStatus _)
	{
		int roleId = notify.RoleId;
		if (RoleDevModel.Instance != null)
		{
			RoleDevModel.Instance.UpdateDevTargetRoleId(roleId);
		}
		EventSystem.Instance.Emit(EEventName.RoleDevTargetRoleIdChange);
	}

	// Token: 0x06012AD7 RID: 76503 RVA: 0x0057F8A8 File Offset: 0x0057DAA8
	private void HandleRoleDevelopConfigUpdateNotify(RoleDevelopConfigUpdateNotify notify, [Nullable(2)] Net.CallbackStatus _)
	{
		RoleDevelopConfigs configs = notify.Configs;
		if (configs == null)
		{
			Log.Instance.Error(ELogModule.RoleDev, ELogAuthor.LJS, "RoleDevelopConfigUpdateNotify Configs为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleDevModel.Instance.UpdateRoleDevConfig(configs);
	}

	// Token: 0x06012AD8 RID: 76504 RVA: 0x0057F8EC File Offset: 0x0057DAEC
	[NullableContext(2)]
	private unsafe RoleDevLogEvent BuildRoleDevLogEvent(int roleId, ERoleDevMainPage mainPage, ERoleDevSubPageButton subPage)
	{
		RoleDevLogEvent result;
		try
		{
			CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType roleType = this.GetRoleType(roleId);
			result = new RoleDevLogEvent
			{
				i_role_id = roleId,
				i_role_type = (int)roleType,
				i_main_page = (int)mainPage,
				i_sub_page = (int)subPage
			};
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "构建角色培养日志数据失败";
			Exception error = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mainPage", mainPage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("subPage", subPage);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			result = null;
		}
		return result;
	}

	// Token: 0x06012AD9 RID: 76505 RVA: 0x0057F9BC File Offset: 0x0057DBBC
	private unsafe CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType GetRoleType(int roleId)
	{
		CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType result;
		try
		{
			if (RoleModel.Instance.GetRoleDataById(roleId, true) != null)
			{
				result = CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType.Owned;
			}
			else
			{
				result = CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType.NotOwned;
			}
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "获取角色类型失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.ToString());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			result = CSharpScript.Game.Module.RoleUi.RoleDev.Define.ERoleType.NotOwned;
		}
		return result;
	}

	// Token: 0x06012ADA RID: 76506 RVA: 0x0057FA58 File Offset: 0x0057DC58
	public void LogRoleDevPageClick(int roleId, ERoleDevMainPage mainPage)
	{
		RoleDevLogEvent roleDevLogEvent = this.BuildRoleDevLogEvent(roleId, mainPage, ERoleDevSubPageButton.None);
		if (roleDevLogEvent != null)
		{
			LogReportController.Instance.LogReport(roleDevLogEvent);
		}
	}

	// Token: 0x06012ADB RID: 76507 RVA: 0x0057FA80 File Offset: 0x0057DC80
	public void LogRoleDevSubPageClick(int roleId, ERoleDevMainPage mainPage, ERoleDevSubPageButton subPage)
	{
		RoleDevLogEvent roleDevLogEvent = this.BuildRoleDevLogEvent(roleId, mainPage, subPage);
		if (roleDevLogEvent != null)
		{
			LogReportController.Instance.LogReport(roleDevLogEvent);
		}
	}

	// Token: 0x17001C27 RID: 7207
	// (get) Token: 0x06012ADC RID: 76508 RVA: 0x0057FAA5 File Offset: 0x0057DCA5
	public static RoleDevController Instance
	{
		get
		{
			return RoleDevController._Instance;
		}
	}

	// Token: 0x06012ADD RID: 76509 RVA: 0x0057FAAC File Offset: 0x0057DCAC
	public static RoleDevController GetOrCreateInstance()
	{
		if (RoleDevController._Instance == null)
		{
			RoleDevController.CreateInstance();
		}
		return RoleDevController._Instance;
	}

	// Token: 0x06012ADE RID: 76510 RVA: 0x0057FAC0 File Offset: 0x0057DCC0
	public static bool CreateInstance()
	{
		if (RoleDevController._Instance != null)
		{
			return true;
		}
		RoleDevController._Instance = new RoleDevController();
		return true;
	}

	// Token: 0x06012ADF RID: 76511 RVA: 0x0057FAD6 File Offset: 0x0057DCD6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012AE0 RID: 76512 RVA: 0x0057FAD8 File Offset: 0x0057DCD8
	public static void ResetStaticDefaultValue()
	{
		RoleDevController._Instance = null;
	}

	// Token: 0x06012AE1 RID: 76513 RVA: 0x0057FAE0 File Offset: 0x0057DCE0
	static RoleDevController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevController.CreateStaticDefaultValue), new Action(RoleDevController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A217 RID: 41495
	[Nullable(2)]
	private static RoleDevController _Instance;
}
