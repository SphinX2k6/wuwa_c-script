using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001883 RID: 6275
[Controller(0)]
public class WeekCardController : UiControllerBase
{
	// Token: 0x0600F87B RID: 63611 RVA: 0x0048B6EA File Offset: 0x004898EA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600F87C RID: 63612 RVA: 0x0048B6ED File Offset: 0x004898ED
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.EffectiveWeekCardInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWeekCardInfoResponse));
	}

	// Token: 0x0600F87D RID: 63613 RVA: 0x0048B70B File Offset: 0x0048990B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EffectiveWeekCardInfoNotify);
	}

	// Token: 0x0600F87E RID: 63614 RVA: 0x0048B720 File Offset: 0x00489920
	[NullableContext(2)]
	private void OnWeekCardInfoResponse(IMessage msg, Net.CallbackStatus status)
	{
		EffectiveWeekCardInfoNotify effectiveWeekCardInfoNotify = (EffectiveWeekCardInfoNotify)msg;
		List<WeekCardInfo> list = (((effectiveWeekCardInfoNotify != null) ? effectiveWeekCardInfoNotify.WeekCardInfos : null) != null) ? new List<WeekCardInfo>(effectiveWeekCardInfoNotify.WeekCardInfos) : new List<WeekCardInfo>();
		int[] array = new int[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i].WeekCardId;
		}
		WeekCardModel.Instance.SetWeekCardInfos(list);
	}

	// Token: 0x0600F87F RID: 63615 RVA: 0x0048B78C File Offset: 0x0048998C
	public UniTask<bool> RequestWeekCardInfo(int weekCardId)
	{
		WeekCardController.<RequestWeekCardInfo>d__4 <RequestWeekCardInfo>d__;
		<RequestWeekCardInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeekCardInfo>d__.weekCardId = weekCardId;
		<RequestWeekCardInfo>d__.<>1__state = -1;
		<RequestWeekCardInfo>d__.<>t__builder.Start<WeekCardController.<RequestWeekCardInfo>d__4>(ref <RequestWeekCardInfo>d__);
		return <RequestWeekCardInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600F880 RID: 63616 RVA: 0x0048B7D0 File Offset: 0x004899D0
	public UniTask<bool> RequestWeekCardReward(int contentId)
	{
		WeekCardController.<RequestWeekCardReward>d__5 <RequestWeekCardReward>d__;
		<RequestWeekCardReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeekCardReward>d__.contentId = contentId;
		<RequestWeekCardReward>d__.<>1__state = -1;
		<RequestWeekCardReward>d__.<>t__builder.Start<WeekCardController.<RequestWeekCardReward>d__5>(ref <RequestWeekCardReward>d__);
		return <RequestWeekCardReward>d__.<>t__builder.Task;
	}

	// Token: 0x170017DE RID: 6110
	// (get) Token: 0x0600F881 RID: 63617 RVA: 0x0048B813 File Offset: 0x00489A13
	[Nullable(1)]
	public static WeekCardController Instance
	{
		[NullableContext(1)]
		get
		{
			return WeekCardController._Instance;
		}
	}

	// Token: 0x0600F882 RID: 63618 RVA: 0x0048B81A File Offset: 0x00489A1A
	[NullableContext(1)]
	public static WeekCardController GetOrCreateInstance()
	{
		if (WeekCardController._Instance == null)
		{
			WeekCardController.CreateInstance();
		}
		return WeekCardController._Instance;
	}

	// Token: 0x0600F883 RID: 63619 RVA: 0x0048B82E File Offset: 0x00489A2E
	public static bool CreateInstance()
	{
		if (WeekCardController._Instance != null)
		{
			return true;
		}
		WeekCardController._Instance = new WeekCardController();
		return true;
	}

	// Token: 0x0600F884 RID: 63620 RVA: 0x0048B844 File Offset: 0x00489A44
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F885 RID: 63621 RVA: 0x0048B846 File Offset: 0x00489A46
	public static void ResetStaticDefaultValue()
	{
		WeekCardController._Instance = null;
	}

	// Token: 0x0600F886 RID: 63622 RVA: 0x0048B84E File Offset: 0x00489A4E
	static WeekCardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardController.CreateStaticDefaultValue), new Action(WeekCardController.ResetStaticDefaultValue));
	}

	// Token: 0x04008B0A RID: 35594
	[Nullable(2)]
	private static WeekCardController _Instance;
}
