using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x0200222D RID: 8749
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class MotionController : ControllerBase
{
	// Token: 0x0601110D RID: 69901 RVA: 0x004290F9 File Offset: 0x004272F9
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0601110E RID: 69902 RVA: 0x00429108 File Offset: 0x00427308
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0601110F RID: 69903 RVA: 0x00429117 File Offset: 0x00427317
	protected void OnAddEvents()
	{
	}

	// Token: 0x06011110 RID: 69904 RVA: 0x00429119 File Offset: 0x00427319
	protected void OnRemoveEvents()
	{
	}

	// Token: 0x06011111 RID: 69905 RVA: 0x0042911C File Offset: 0x0042731C
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleMotionNewCanUnLockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionNewCanUnLockNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionActiveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionActiveNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionListNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionFinishConditionNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionFinishConditionNotify));
	}

	// Token: 0x06011112 RID: 69906 RVA: 0x0042919C File Offset: 0x0042739C
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionNewCanUnLockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionActiveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionFinishConditionNotify);
	}

	// Token: 0x06011113 RID: 69907 RVA: 0x004291EC File Offset: 0x004273EC
	public void RequestUnlockMotion(int roleId, int motionId)
	{
		RoleMotionUnLockRequest roleMotionUnLockRequest = RoleMotionUnLockRequest.Create();
		roleMotionUnLockRequest.RoleId = roleId;
		roleMotionUnLockRequest.UnLockId = motionId;
		Net.Instance.Call(ERequestMessageId.RoleMotionUnLockRequest, roleMotionUnLockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleMotionUnLockResponse roleMotionUnLockResponse = (RoleMotionUnLockResponse)msg;
			if (roleMotionUnLockResponse == null)
			{
				return;
			}
			if (roleMotionUnLockResponse.ErrCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleMotionUnLockResponse.ErrCode, 28146, null, true, true);
				return;
			}
			MotionModel.Instance.OnMotionUnlock(roleMotionUnLockResponse.RoleId, roleMotionUnLockResponse.UnLockId);
		}, 0);
	}

	// Token: 0x06011114 RID: 69908 RVA: 0x00429240 File Offset: 0x00427440
	private void OnRoleMotionNewCanUnLockNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionNewCanUnLockNotify roleMotionNewCanUnLockNotify = (RoleMotionNewCanUnLockNotify)msg;
		MotionModel.Instance.OnNewMotionCanUnlock(roleMotionNewCanUnLockNotify.RoleId, roleMotionNewCanUnLockNotify.CanUnLockId);
	}

	// Token: 0x06011115 RID: 69909 RVA: 0x0042926C File Offset: 0x0042746C
	private void OnRoleMotionActiveNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionActiveNotify message = (RoleMotionActiveNotify)msg;
		MotionModel.Instance.OnRoleMotionActive(message);
	}

	// Token: 0x06011116 RID: 69910 RVA: 0x0042928C File Offset: 0x0042748C
	private void OnRoleMotionListNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionListNotify message = (RoleMotionListNotify)msg;
		MotionModel.Instance.OnGetAllRoleMotionInfo(message);
	}

	// Token: 0x06011117 RID: 69911 RVA: 0x004292AC File Offset: 0x004274AC
	private void OnRoleMotionFinishConditionNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionFinishConditionNotify message = (RoleMotionFinishConditionNotify)msg;
		MotionModel.Instance.OnMotionFinishCondition(message);
	}

	// Token: 0x170015AC RID: 5548
	// (get) Token: 0x06011118 RID: 69912 RVA: 0x004292CB File Offset: 0x004274CB
	[Nullable(1)]
	public static MotionController Instance
	{
		[NullableContext(1)]
		get
		{
			return MotionController._Instance;
		}
	}

	// Token: 0x06011119 RID: 69913 RVA: 0x004292D2 File Offset: 0x004274D2
	[NullableContext(1)]
	public static MotionController GetOrCreateInstance()
	{
		if (MotionController._Instance == null)
		{
			MotionController.CreateInstance();
		}
		return MotionController._Instance;
	}

	// Token: 0x0601111A RID: 69914 RVA: 0x004292E6 File Offset: 0x004274E6
	public static bool CreateInstance()
	{
		if (MotionController._Instance != null)
		{
			return true;
		}
		MotionController._Instance = new MotionController();
		return true;
	}

	// Token: 0x0601111B RID: 69915 RVA: 0x004292FC File Offset: 0x004274FC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601111C RID: 69916 RVA: 0x004292FE File Offset: 0x004274FE
	public static void ResetStaticDefaultValue()
	{
		MotionController._Instance = null;
	}

	// Token: 0x0601111D RID: 69917 RVA: 0x00429306 File Offset: 0x00427506
	static MotionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionController.CreateStaticDefaultValue), new Action(MotionController.ResetStaticDefaultValue));
	}

	// Token: 0x04008212 RID: 33298
	private static MotionController _Instance;
}
