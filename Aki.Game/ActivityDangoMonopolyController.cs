using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001220 RID: 4640
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDangoMonopolyController : ActivityControllerBase
{
	// Token: 0x06007CE1 RID: 31969 RVA: 0x001A6735 File Offset: 0x001A4935
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityDangoMonopolyData();
		return this.Data;
	}

	// Token: 0x06007CE2 RID: 31970 RVA: 0x001A6748 File Offset: 0x001A4948
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007CE3 RID: 31971 RVA: 0x001A674B File Offset: 0x001A494B
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007CE4 RID: 31972 RVA: 0x001A674D File Offset: 0x001A494D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMonopoly";
	}

	// Token: 0x06007CE5 RID: 31973 RVA: 0x001A6754 File Offset: 0x001A4954
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDangoMonopoly();
	}

	// Token: 0x06007CE6 RID: 31974 RVA: 0x001A675C File Offset: 0x001A495C
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
			data.ProtoTaskUpdateNotify(dangoMonopolyTaskUpdateNotify.TaskDatas.ToList<Aki.Protocol.DangoMonopolyTaskData>());
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
			data.ProtoTaskAddNotify(dangoMonopolyTaskAddNotify.TaskDatas.ToList<Aki.Protocol.DangoMonopolyTaskData>());
		});
		Net.Instance.Register(ENotifyMessageId.DangoMonopolyTaskRemoveNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			DangoMonopolyTaskRemoveNotify dangoMonopolyTaskRemoveNotify = (DangoMonopolyTaskRemoveNotify)msg;
			ActivityDangoMonopolyData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ProtoTaskRemoveNotify(dangoMonopolyTaskRemoveNotify.TaskIds.ToList<int>());
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

	// Token: 0x06007CE7 RID: 31975 RVA: 0x001A67F8 File Offset: 0x001A49F8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolySceneGridInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyTaskRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DangoMonopolyRewardNotify);
	}

	// Token: 0x06007CE8 RID: 31976 RVA: 0x001A6855 File Offset: 0x001A4A55
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.EventWorldDone));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.EventCommonItemCountAnyChange));
	}

	// Token: 0x06007CE9 RID: 31977 RVA: 0x001A688F File Offset: 0x001A4A8F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.EventWorldDone));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.EventCommonItemCountAnyChange));
	}

	// Token: 0x06007CEA RID: 31978 RVA: 0x001A68C9 File Offset: 0x001A4AC9
	[NullableContext(2)]
	private static ActivityDangoMonopolyController GetController()
	{
		return ActivityManager.GetActivityController(ActivityType.DangoMonopoly) as ActivityDangoMonopolyController;
	}

	// Token: 0x06007CEB RID: 31979 RVA: 0x001A68D7 File Offset: 0x001A4AD7
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

	// Token: 0x06007CEC RID: 31980 RVA: 0x001A68EC File Offset: 0x001A4AEC
	public void RefreshActivityRedDot()
	{
		ActivityDangoMonopolyData data = this.Data;
		int? num = (data != null) ? new int?(data.Id) : null;
		if (num != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, num.Value);
		}
	}

	// Token: 0x06007CED RID: 31981 RVA: 0x001A693C File Offset: 0x001A4B3C
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

	// Token: 0x06007CEE RID: 31982 RVA: 0x001A6988 File Offset: 0x001A4B88
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

	// Token: 0x06007CEF RID: 31983 RVA: 0x001A69D4 File Offset: 0x001A4BD4
	public UniTask RequestReceiveGridReward()
	{
		ActivityDangoMonopolyController.<RequestReceiveGridReward>d__15 <RequestReceiveGridReward>d__;
		<RequestReceiveGridReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestReceiveGridReward>d__.<>4__this = this;
		<RequestReceiveGridReward>d__.<>1__state = -1;
		<RequestReceiveGridReward>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestReceiveGridReward>d__15>(ref <RequestReceiveGridReward>d__);
		return <RequestReceiveGridReward>d__.<>t__builder.Task;
	}

	// Token: 0x06007CF0 RID: 31984 RVA: 0x001A6A18 File Offset: 0x001A4C18
	public UniTask RequestDice()
	{
		ActivityDangoMonopolyController.<RequestDice>d__16 <RequestDice>d__;
		<RequestDice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestDice>d__.<>4__this = this;
		<RequestDice>d__.<>1__state = -1;
		<RequestDice>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestDice>d__16>(ref <RequestDice>d__);
		return <RequestDice>d__.<>t__builder.Task;
	}

	// Token: 0x06007CF1 RID: 31985 RVA: 0x001A6A5C File Offset: 0x001A4C5C
	public UniTask RequestEnterNextBoard()
	{
		ActivityDangoMonopolyController.<RequestEnterNextBoard>d__17 <RequestEnterNextBoard>d__;
		<RequestEnterNextBoard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestEnterNextBoard>d__.<>4__this = this;
		<RequestEnterNextBoard>d__.<>1__state = -1;
		<RequestEnterNextBoard>d__.<>t__builder.Start<ActivityDangoMonopolyController.<RequestEnterNextBoard>d__17>(ref <RequestEnterNextBoard>d__);
		return <RequestEnterNextBoard>d__.<>t__builder.Task;
	}

	// Token: 0x06007CF2 RID: 31986 RVA: 0x001A6A9F File Offset: 0x001A4C9F
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

	// Token: 0x06007CF3 RID: 31987 RVA: 0x001A6AD8 File Offset: 0x001A4CD8
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

	// Token: 0x17000A94 RID: 2708
	// (get) Token: 0x06007CF4 RID: 31988 RVA: 0x001A6B30 File Offset: 0x001A4D30
	public static ActivityDangoMonopolyController Instance
	{
		get
		{
			return ActivityDangoMonopolyController._Instance;
		}
	}

	// Token: 0x06007CF5 RID: 31989 RVA: 0x001A6B37 File Offset: 0x001A4D37
	public static ActivityDangoMonopolyController GetOrCreateInstance()
	{
		if (ActivityDangoMonopolyController._Instance == null)
		{
			ActivityDangoMonopolyController.CreateInstance();
		}
		return ActivityDangoMonopolyController._Instance;
	}

	// Token: 0x06007CF6 RID: 31990 RVA: 0x001A6B4B File Offset: 0x001A4D4B
	public static bool CreateInstance()
	{
		if (ActivityDangoMonopolyController._Instance != null)
		{
			return true;
		}
		ActivityDangoMonopolyController._Instance = new ActivityDangoMonopolyController();
		return true;
	}

	// Token: 0x06007CF7 RID: 31991 RVA: 0x001A6B61 File Offset: 0x001A4D61
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CF8 RID: 31992 RVA: 0x001A6B63 File Offset: 0x001A4D63
	public static void ResetStaticDefaultValue()
	{
		ActivityDangoMonopolyController._Instance = null;
	}

	// Token: 0x06007CF9 RID: 31993 RVA: 0x001A6B6B File Offset: 0x001A4D6B
	static ActivityDangoMonopolyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoMonopolyController.CreateStaticDefaultValue), new Action(ActivityDangoMonopolyController.ResetStaticDefaultValue));
	}

	// Token: 0x040038F5 RID: 14581
	[Nullable(2)]
	public ActivityDangoMonopolyData Data;

	// Token: 0x040038F6 RID: 14582
	[Nullable(2)]
	private static ActivityDangoMonopolyController _Instance;
}
