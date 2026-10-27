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

// Token: 0x0200280F RID: 10255
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleDevController : UiControllerBase
{
	// Token: 0x060150CD RID: 86221 RVA: 0x00554955 File Offset: 0x00552B55
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x060150CE RID: 86222 RVA: 0x00554957 File Offset: 0x00552B57
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x060150CF RID: 86223 RVA: 0x00554959 File Offset: 0x00552B59
	protected override void OnAddEvents()
	{
	}

	// Token: 0x060150D0 RID: 86224 RVA: 0x0055495B File Offset: 0x00552B5B
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x060150D1 RID: 86225 RVA: 0x0055495D File Offset: 0x00552B5D
	private void OnLoadingNetDataDone()
	{
		this.RequestRoleDevelopConfig(null);
	}

	// Token: 0x060150D2 RID: 86226 RVA: 0x00554968 File Offset: 0x00552B68
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

	// Token: 0x060150D3 RID: 86227 RVA: 0x005549B3 File Offset: 0x00552BB3
	public void OpenRoleDevelopView(int roleId)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleDevRootView, roleId, null);
	}

	// Token: 0x060150D4 RID: 86228 RVA: 0x005549CC File Offset: 0x00552BCC
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

	// Token: 0x060150D5 RID: 86229 RVA: 0x00554A1C File Offset: 0x00552C1C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleUpdateDevelopTargetResponse.ErrorCode, 29361, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060150D6 RID: 86230 RVA: 0x00554A70 File Offset: 0x00552C70
	private void HandleRoleUpdateDevelopTargetNotify(RoleUpdateDevelopTargetNotify notify, [Nullable(2)] Net.CallbackStatus _)
	{
		int roleId = notify.RoleId;
		if (RoleDevModel.Instance != null)
		{
			RoleDevModel.Instance.UpdateDevTargetRoleId(roleId);
		}
		EventSystem.Instance.Emit(EEventName.RoleDevTargetRoleIdChange);
	}

	// Token: 0x060150D7 RID: 86231 RVA: 0x00554AA8 File Offset: 0x00552CA8
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

	// Token: 0x060150D8 RID: 86232 RVA: 0x00554AEC File Offset: 0x00552CEC
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

	// Token: 0x060150D9 RID: 86233 RVA: 0x00554BBC File Offset: 0x00552DBC
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

	// Token: 0x060150DA RID: 86234 RVA: 0x00554C58 File Offset: 0x00552E58
	public void LogRoleDevPageClick(int roleId, ERoleDevMainPage mainPage)
	{
		RoleDevLogEvent roleDevLogEvent = this.BuildRoleDevLogEvent(roleId, mainPage, ERoleDevSubPageButton.None);
		if (roleDevLogEvent != null)
		{
			LogReportController.Instance.LogReport(roleDevLogEvent);
		}
	}

	// Token: 0x060150DB RID: 86235 RVA: 0x00554C80 File Offset: 0x00552E80
	public void LogRoleDevSubPageClick(int roleId, ERoleDevMainPage mainPage, ERoleDevSubPageButton subPage)
	{
		RoleDevLogEvent roleDevLogEvent = this.BuildRoleDevLogEvent(roleId, mainPage, subPage);
		if (roleDevLogEvent != null)
		{
			LogReportController.Instance.LogReport(roleDevLogEvent);
		}
	}

	// Token: 0x17001BCF RID: 7119
	// (get) Token: 0x060150DC RID: 86236 RVA: 0x00554CA5 File Offset: 0x00552EA5
	public static RoleDevController Instance
	{
		get
		{
			return RoleDevController._Instance;
		}
	}

	// Token: 0x060150DD RID: 86237 RVA: 0x00554CAC File Offset: 0x00552EAC
	public static RoleDevController GetOrCreateInstance()
	{
		if (RoleDevController._Instance == null)
		{
			RoleDevController.CreateInstance();
		}
		return RoleDevController._Instance;
	}

	// Token: 0x060150DE RID: 86238 RVA: 0x00554CC0 File Offset: 0x00552EC0
	public static bool CreateInstance()
	{
		if (RoleDevController._Instance != null)
		{
			return true;
		}
		RoleDevController._Instance = new RoleDevController();
		return true;
	}

	// Token: 0x060150DF RID: 86239 RVA: 0x00554CD6 File Offset: 0x00552ED6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060150E0 RID: 86240 RVA: 0x00554CD8 File Offset: 0x00552ED8
	public static void ResetStaticDefaultValue()
	{
		RoleDevController._Instance = null;
	}

	// Token: 0x060150E1 RID: 86241 RVA: 0x00554CE0 File Offset: 0x00552EE0
	static RoleDevController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDevController.CreateStaticDefaultValue), new Action(RoleDevController.ResetStaticDefaultValue));
	}

	// Token: 0x04009E2E RID: 40494
	[Nullable(2)]
	private static RoleDevController _Instance;
}
