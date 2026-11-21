using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020006D4 RID: 1748
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDangoMonopolyController : ActivityControllerBase
{
	// Token: 0x06005077 RID: 20599 RVA: 0x001AF3E9 File Offset: 0x001AD5E9
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityDangoMonopolyData();
		return this.Data;
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x001AF3FC File Offset: 0x001AD5FC
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x001AF3FF File Offset: 0x001AD5FF
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x001AF401 File Offset: 0x001AD601
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMonopoly";
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x001AF408 File Offset: 0x001AD608
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDangoMonopoly();
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x001AF410 File Offset: 0x001AD610
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.DangoMonopolyTaskUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolyTaskUpdateNotify dangoMonopolyTaskUpdateNotify = (DangoMonopolyTaskUpdateNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoTaskUpdateNotify(new List<Aki.Protocol.DangoMonopolyTaskData>(dangoMonopolyTaskUpdateNotify.TaskDatas));
		});
		Net.Instance.Register(ENotifyMessageId.DangoMonopolySceneGridInfoNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolySceneGridInfoNotify info = (DangoMonopolySceneGridInfoNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoSceneGridInfoNotify(info);
		});
		Net.Instance.Register(ENotifyMessageId.DangoMonopolyTaskAddNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolyTaskAddNotify dangoMonopolyTaskAddNotify = (DangoMonopolyTaskAddNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoTaskAddNotify(dangoMonopolyTaskAddNotify.TaskDatas);
		});
		Net.Instance.Register(ENotifyMessageId.DangoMonopolyTaskRemoveNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolyTaskRemoveNotify dangoMonopolyTaskRemoveNotify = (DangoMonopolyTaskRemoveNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoTaskRemoveNotify(dangoMonopolyTaskRemoveNotify.TaskIds);
		});
		Net.Instance.Register(ENotifyMessageId.DangoMonopolyRewardNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolyRewardNotify response = (DangoMonopolyRewardNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoRewardNotify(response);
		});
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x001AF4AC File Offset: 0x001AD6AC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolySceneGridInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyRewardNotify);
	}

	// Token: 0x0600507E RID: 20606 RVA: 0x001AF509 File Offset: 0x001AD709
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.EventWorldDone));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.EventCommonItemCountAnyChange));
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x001AF543 File Offset: 0x001AD743
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.EventWorldDone));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.EventCommonItemCountAnyChange));
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x001AF57D File Offset: 0x001AD77D
	[NullableContext(2)]
	private static ActivityDangoMonopolyController GetController()
	{
		return ActivityManager.GetActivityController(ActivityType.DangoMonopoly) as ActivityDangoMonopolyController;
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x001AF58B File Offset: 0x001AD78B
	[NullableContext(2)]
	public ActivityDangoMonopolyData GetData()
	{
		ActivityDangoMonopolyController controller = ActivityDangoMonopolyController.GetController();
		if (controller == null)
		{
			return null;
		}
		return controller.Data;
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x001AF5A0 File Offset: 0x001AD7A0
	public void RefreshActivityRedDot()
	{
		ActivityDangoMonopolyData data = this.Data;
		int? num = (data != null) ? new int?(data.Id) : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num.Value);
		}
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x001AF5F0 File Offset: 0x001AD7F0
	public UniTask RequestReceiveTaskReward(List<int> taskIdList)
	{
		ActivityDangoMonopolyController.<RequestReceiveTaskReward>d__13 <RequestReceiveTaskReward>d__;
		<RequestReceiveTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestReceiveTaskReward>d__.<>4__this = this;
		<RequestReceiveTaskReward>d__.taskIdList = taskIdList;
		<RequestReceiveTaskReward>d__.<>1__state = -1;
		<RequestReceiveTaskReward>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestReceiveTaskReward>d__13>(ref <RequestReceiveTaskReward>d__);
		return <RequestReceiveTaskReward>d__.<>t__builder.Task;
	}

	// Token: 0x06005084 RID: 20612 RVA: 0x001AF63C File Offset: 0x001AD83C
	public UniTask RequestReceiveBoardReward(List<int> boardIdList)
	{
		ActivityDangoMonopolyController.<RequestReceiveBoardReward>d__14 <RequestReceiveBoardReward>d__;
		<RequestReceiveBoardReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestReceiveBoardReward>d__.<>4__this = this;
		<RequestReceiveBoardReward>d__.boardIdList = boardIdList;
		<RequestReceiveBoardReward>d__.<>1__state = -1;
		<RequestReceiveBoardReward>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestReceiveBoardReward>d__14>(ref <RequestReceiveBoardReward>d__);
		return <RequestReceiveBoardReward>d__.<>t__builder.Task;
	}

	// Token: 0x06005085 RID: 20613 RVA: 0x001AF688 File Offset: 0x001AD888
	public UniTask RequestReceiveGridReward()
	{
		ActivityDangoMonopolyController.<RequestReceiveGridReward>d__15 <RequestReceiveGridReward>d__;
		<RequestReceiveGridReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestReceiveGridReward>d__.<>4__this = this;
		<RequestReceiveGridReward>d__.<>1__state = -1;
		<RequestReceiveGridReward>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestReceiveGridReward>d__15>(ref <RequestReceiveGridReward>d__);
		return <RequestReceiveGridReward>d__.<>t__builder.Task;
	}

	// Token: 0x06005086 RID: 20614 RVA: 0x001AF6CC File Offset: 0x001AD8CC
	public UniTask RequestDice()
	{
		ActivityDangoMonopolyController.<RequestDice>d__16 <RequestDice>d__;
		<RequestDice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestDice>d__.<>4__this = this;
		<RequestDice>d__.<>1__state = -1;
		<RequestDice>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestDice>d__16>(ref <RequestDice>d__);
		return <RequestDice>d__.<>t__builder.Task;
	}

	// Token: 0x06005087 RID: 20615 RVA: 0x001AF710 File Offset: 0x001AD910
	public UniTask RequestEnterNextBoard()
	{
		ActivityDangoMonopolyController.<RequestEnterNextBoard>d__17 <RequestEnterNextBoard>d__;
		<RequestEnterNextBoard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestEnterNextBoard>d__.<>4__this = this;
		<RequestEnterNextBoard>d__.<>1__state = -1;
		<RequestEnterNextBoard>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestEnterNextBoard>d__17>(ref <RequestEnterNextBoard>d__);
		return <RequestEnterNextBoard>d__.<>t__builder.Task;
	}

	// Token: 0x06005088 RID: 20616 RVA: 0x001AF753 File Offset: 0x001AD953
	private void EventWorldDone()
	{
		ActivityDangoMonopolyData data = this.Data;
		if (data != null)
		{
			data.DelayUpdateCameraMove().Forget();
		}
		ActivityDangoMonopolyData data2 = this.Data;
		if (data2 != null && data2.IsInTheDungeon())
		{
			this.Data.RecordKismetSetting();
		}
	}

	// Token: 0x06005089 RID: 20617 RVA: 0x001AF78C File Offset: 0x001AD98C
	private void EventCommonItemCountAnyChange(int id, int _)
	{
		ActivityDangoMonopolyData data = this.Data;
		int? num = (data != null) ? new int?(data.DiceItemId) : null;
		if (!(id == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.RedDotUpdateDangoMonopolyNum);
		this.RefreshActivityRedDot();
	}

	// Token: 0x17000AB4 RID: 2740
	// (get) Token: 0x0600508A RID: 20618 RVA: 0x001AF7E4 File Offset: 0x001AD9E4
	public static ActivityDangoMonopolyController Instance
	{
		get
		{
			return ActivityDangoMonopolyController._Instance;
		}
	}

	// Token: 0x0600508B RID: 20619 RVA: 0x001AF7EB File Offset: 0x001AD9EB
	public static ActivityDangoMonopolyController GetOrCreateInstance()
	{
		if (ActivityDangoMonopolyController._Instance == null)
		{
			ActivityDangoMonopolyController.CreateInstance();
		}
		return ActivityDangoMonopolyController._Instance;
	}

	// Token: 0x0600508C RID: 20620 RVA: 0x001AF7FF File Offset: 0x001AD9FF
	public static bool CreateInstance()
	{
		if (ActivityDangoMonopolyController._Instance != null)
		{
			return true;
		}
		ActivityDangoMonopolyController._Instance = new ActivityDangoMonopolyController();
		return true;
	}

	// Token: 0x0600508D RID: 20621 RVA: 0x001AF815 File Offset: 0x001ADA15
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600508E RID: 20622 RVA: 0x001AF817 File Offset: 0x001ADA17
	public static void ResetStaticDefaultValue()
	{
		ActivityDangoMonopolyController._Instance = null;
	}

	// Token: 0x0600508F RID: 20623 RVA: 0x001AF81F File Offset: 0x001ADA1F
	static ActivityDangoMonopolyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoMonopolyController.CreateStaticDefaultValue), new Action(ActivityDangoMonopolyController.ResetStaticDefaultValue));
	}

	// Token: 0x0400398E RID: 14734
	[Nullable(2)]
	public ActivityDangoMonopolyData Data;

	// Token: 0x0400398F RID: 14735
	[Nullable(2)]
	private static ActivityDangoMonopolyController _Instance;
}
