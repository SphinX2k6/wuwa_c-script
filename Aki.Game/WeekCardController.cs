using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200239E RID: 9118
[Controller(0)]
public class WeekCardController : UiControllerBase
{
	// Token: 0x060123C9 RID: 74697 RVA: 0x0047E27E File Offset: 0x0047C47E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060123CA RID: 74698 RVA: 0x0047E281 File Offset: 0x0047C481
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.EffectiveWeekCardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWeekCardInfoResponse));
	}

	// Token: 0x060123CB RID: 74699 RVA: 0x0047E29F File Offset: 0x0047C49F
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EffectiveWeekCardInfoNotify);
	}

	// Token: 0x060123CC RID: 74700 RVA: 0x0047E2B4 File Offset: 0x0047C4B4
	[NullableContext(2)]
	private void OnWeekCardInfoResponse(IMessage msg, Net.CallbackStatus status)
	{
		EffectiveWeekCardInfoNotify effectiveWeekCardInfoNotify = (EffectiveWeekCardInfoNotify)msg;
		List<WeekCardInfo> weekCardInfos = (((effectiveWeekCardInfoNotify != null) ? effectiveWeekCardInfoNotify.WeekCardInfos : null) != null) ? new List<WeekCardInfo>(effectiveWeekCardInfoNotify.WeekCardInfos) : new List<WeekCardInfo>();
		WeekCardModel.Instance.SetWeekCardInfos(weekCardInfos);
	}

	// Token: 0x060123CD RID: 74701 RVA: 0x0047E2F4 File Offset: 0x0047C4F4
	public UniTask<bool> RequestWeekCardInfo(int weekCardId)
	{
		WeekCardController.<RequestWeekCardInfo>d__4 <RequestWeekCardInfo>d__;
		<RequestWeekCardInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeekCardInfo>d__.weekCardId = weekCardId;
		<RequestWeekCardInfo>d__.<>1__state = -1;
		<RequestWeekCardInfo>d__.<>t__builder.Start<WeekCardController.<RequestWeekCardInfo>d__4>(ref <RequestWeekCardInfo>d__);
		return <RequestWeekCardInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060123CE RID: 74702 RVA: 0x0047E338 File Offset: 0x0047C538
	public UniTask<bool> RequestWeekCardReward(int contentId)
	{
		WeekCardController.<RequestWeekCardReward>d__5 <RequestWeekCardReward>d__;
		<RequestWeekCardReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeekCardReward>d__.contentId = contentId;
		<RequestWeekCardReward>d__.<>1__state = -1;
		<RequestWeekCardReward>d__.<>t__builder.Start<WeekCardController.<RequestWeekCardReward>d__5>(ref <RequestWeekCardReward>d__);
		return <RequestWeekCardReward>d__.<>t__builder.Task;
	}

	// Token: 0x170017A4 RID: 6052
	// (get) Token: 0x060123CF RID: 74703 RVA: 0x0047E37B File Offset: 0x0047C57B
	[Nullable(1)]
	public static WeekCardController Instance
	{
		[NullableContext(1)]
		get
		{
			return WeekCardController._Instance;
		}
	}

	// Token: 0x060123D0 RID: 74704 RVA: 0x0047E382 File Offset: 0x0047C582
	[NullableContext(1)]
	public static WeekCardController GetOrCreateInstance()
	{
		if (WeekCardController._Instance == null)
		{
			WeekCardController.CreateInstance();
		}
		return WeekCardController._Instance;
	}

	// Token: 0x060123D1 RID: 74705 RVA: 0x0047E396 File Offset: 0x0047C596
	public static bool CreateInstance()
	{
		if (WeekCardController._Instance != null)
		{
			return true;
		}
		WeekCardController._Instance = new WeekCardController();
		return true;
	}

	// Token: 0x060123D2 RID: 74706 RVA: 0x0047E3AC File Offset: 0x0047C5AC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060123D3 RID: 74707 RVA: 0x0047E3AE File Offset: 0x0047C5AE
	public static void ResetStaticDefaultValue()
	{
		WeekCardController._Instance = null;
	}

	// Token: 0x060123D4 RID: 74708 RVA: 0x0047E3B6 File Offset: 0x0047C5B6
	static WeekCardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardController.CreateStaticDefaultValue), new Action(WeekCardController.ResetStaticDefaultValue));
	}

	// Token: 0x040089C3 RID: 35267
	[Nullable(2)]
	private static WeekCardController _Instance;
}
