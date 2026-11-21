using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02001711 RID: 5905
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class MotionController : ControllerBase
{
	// Token: 0x0600E5A3 RID: 58787 RVA: 0x00435C9D File Offset: 0x00433E9D
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600E5A4 RID: 58788 RVA: 0x00435CAC File Offset: 0x00433EAC
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600E5A5 RID: 58789 RVA: 0x00435CBB File Offset: 0x00433EBB
	protected void OnAddEvents()
	{
	}

	// Token: 0x0600E5A6 RID: 58790 RVA: 0x00435CBD File Offset: 0x00433EBD
	protected void OnRemoveEvents()
	{
	}

	// Token: 0x0600E5A7 RID: 58791 RVA: 0x00435CC0 File Offset: 0x00433EC0
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleMotionNewCanUnLockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionNewCanUnLockNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionActiveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionActiveNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionListNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionListNotify));
		Net.Instance.Register(ENotifyMessageId.RoleMotionFinishConditionNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleMotionFinishConditionNotify));
	}

	// Token: 0x0600E5A8 RID: 58792 RVA: 0x00435D40 File Offset: 0x00433F40
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionNewCanUnLockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionActiveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionListNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleMotionFinishConditionNotify);
	}

	// Token: 0x0600E5A9 RID: 58793 RVA: 0x00435D90 File Offset: 0x00433F90
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleMotionUnLockResponse.ErrCode, 24424, null, true, true);
				return;
			}
			MotionModel.Instance.OnMotionUnlock(roleMotionUnLockResponse.RoleId, roleMotionUnLockResponse.UnLockId);
		}, 0);
	}

	// Token: 0x0600E5AA RID: 58794 RVA: 0x00435DE4 File Offset: 0x00433FE4
	private void OnRoleMotionNewCanUnLockNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionNewCanUnLockNotify roleMotionNewCanUnLockNotify = (RoleMotionNewCanUnLockNotify)msg;
		MotionModel.Instance.OnNewMotionCanUnlock(roleMotionNewCanUnLockNotify.RoleId, roleMotionNewCanUnLockNotify.CanUnLockId);
	}

	// Token: 0x0600E5AB RID: 58795 RVA: 0x00435E10 File Offset: 0x00434010
	private void OnRoleMotionActiveNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionActiveNotify message = (RoleMotionActiveNotify)msg;
		MotionModel.Instance.OnRoleMotionActive(message);
	}

	// Token: 0x0600E5AC RID: 58796 RVA: 0x00435E30 File Offset: 0x00434030
	private void OnRoleMotionListNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionListNotify message = (RoleMotionListNotify)msg;
		MotionModel.Instance.OnGetAllRoleMotionInfo(message);
	}

	// Token: 0x0600E5AD RID: 58797 RVA: 0x00435E50 File Offset: 0x00434050
	private void OnRoleMotionFinishConditionNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleMotionFinishConditionNotify message = (RoleMotionFinishConditionNotify)msg;
		MotionModel.Instance.OnMotionFinishCondition(message);
	}

	// Token: 0x170015E3 RID: 5603
	// (get) Token: 0x0600E5AE RID: 58798 RVA: 0x00435E6F File Offset: 0x0043406F
	[Nullable(1)]
	public static MotionController Instance
	{
		[NullableContext(1)]
		get
		{
			return MotionController._Instance;
		}
	}

	// Token: 0x0600E5AF RID: 58799 RVA: 0x00435E76 File Offset: 0x00434076
	[NullableContext(1)]
	public static MotionController GetOrCreateInstance()
	{
		if (MotionController._Instance == null)
		{
			MotionController.CreateInstance();
		}
		return MotionController._Instance;
	}

	// Token: 0x0600E5B0 RID: 58800 RVA: 0x00435E8A File Offset: 0x0043408A
	public static bool CreateInstance()
	{
		if (MotionController._Instance != null)
		{
			return true;
		}
		MotionController._Instance = new MotionController();
		return true;
	}

	// Token: 0x0600E5B1 RID: 58801 RVA: 0x00435EA0 File Offset: 0x004340A0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E5B2 RID: 58802 RVA: 0x00435EA2 File Offset: 0x004340A2
	public static void ResetStaticDefaultValue()
	{
		MotionController._Instance = null;
	}

	// Token: 0x0600E5B3 RID: 58803 RVA: 0x00435EAA File Offset: 0x004340AA
	static MotionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionController.CreateStaticDefaultValue), new Action(MotionController.ResetStaticDefaultValue));
	}

	// Token: 0x04008350 RID: 33616
	private static MotionController _Instance;
}
