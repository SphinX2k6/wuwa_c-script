using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200221E RID: 8734
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MoraleController : UiControllerBase
{
	// Token: 0x0601108F RID: 69775 RVA: 0x00426F9C File Offset: 0x0042519C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemNotify));
		EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.EventOnCommonItemCountRefresh));
		EventSystem.Instance.Add(EEventName.OnResponseCommonItemFinished, new Action(this.EventCommonItemFinished));
		EventSystem.Instance.Add<bool>(EEventName.OnMoraleActiveChanged, new Action<bool>(this.EventOnMoraleActiveChanged));
		EventSystem.Instance.Add<int, int, int, int>(EEventName.OnMoraleSumLevelChanged, new Action<int, int, int, int>(this.EventOnMoraleSumLevelChanged));
		EventSystem.Instance.Add<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.EventOnShowMoraleBuffTips));
		EventSystem.Instance.Add<int>(EEventName.OpenTreasureBox, new Action<int>(this.EventOpenTreasureBox));
	}

	// Token: 0x06011090 RID: 69776 RVA: 0x00427070 File Offset: 0x00425270
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemNotify));
		EventSystem.Instance.Remove<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.EventOnCommonItemCountRefresh));
		EventSystem.Instance.Remove(EEventName.OnResponseCommonItemFinished, new Action(this.EventCommonItemFinished));
		EventSystem.Instance.Remove<bool>(EEventName.OnMoraleActiveChanged, new Action<bool>(this.EventOnMoraleActiveChanged));
		EventSystem.Instance.Remove<int, int, int, int>(EEventName.OnMoraleSumLevelChanged, new Action<int, int, int, int>(this.EventOnMoraleSumLevelChanged));
		EventSystem.Instance.Remove<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddShowMoraleBuffTips, new Action<int, GameplayCue, bool, int>(this.EventOnShowMoraleBuffTips));
		EventSystem.Instance.Remove<int>(EEventName.OpenTreasureBox, new Action<int>(this.EventOpenTreasureBox));
	}

	// Token: 0x06011091 RID: 69777 RVA: 0x00427144 File Offset: 0x00425344
	public UniTask RequestProgressReward(int[] ids)
	{
		MoraleController.<RequestProgressReward>d__3 <RequestProgressReward>d__;
		<RequestProgressReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestProgressReward>d__.ids = ids;
		<RequestProgressReward>d__.<>1__state = -1;
		<RequestProgressReward>d__.<>t__builder.Start<MoraleController.<RequestProgressReward>d__3>(ref <RequestProgressReward>d__);
		return <RequestProgressReward>d__.<>t__builder.Task;
	}

	// Token: 0x06011092 RID: 69778 RVA: 0x00427188 File Offset: 0x00425388
	public UniTask RequestGetPlayerMoraleAreaId()
	{
		MoraleController.<RequestGetPlayerMoraleAreaId>d__4 <RequestGetPlayerMoraleAreaId>d__;
		<RequestGetPlayerMoraleAreaId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGetPlayerMoraleAreaId>d__.<>1__state = -1;
		<RequestGetPlayerMoraleAreaId>d__.<>t__builder.Start<MoraleController.<RequestGetPlayerMoraleAreaId>d__4>(ref <RequestGetPlayerMoraleAreaId>d__);
		return <RequestGetPlayerMoraleAreaId>d__.<>t__builder.Task;
	}

	// Token: 0x06011093 RID: 69779 RVA: 0x004271C4 File Offset: 0x004253C4
	public UniTask RequestGetExplorerBoxTrackList(int areaId)
	{
		MoraleController.<RequestGetExplorerBoxTrackList>d__5 <RequestGetExplorerBoxTrackList>d__;
		<RequestGetExplorerBoxTrackList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGetExplorerBoxTrackList>d__.areaId = areaId;
		<RequestGetExplorerBoxTrackList>d__.<>1__state = -1;
		<RequestGetExplorerBoxTrackList>d__.<>t__builder.Start<MoraleController.<RequestGetExplorerBoxTrackList>d__5>(ref <RequestGetExplorerBoxTrackList>d__);
		return <RequestGetExplorerBoxTrackList>d__.<>t__builder.Task;
	}

	// Token: 0x06011094 RID: 69780 RVA: 0x00427207 File Offset: 0x00425407
	private void EventOnMoraleActiveChanged(bool active)
	{
		if (active)
		{
			MoraleModel instance = MoraleModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.InitData();
		}
	}

	// Token: 0x06011095 RID: 69781 RVA: 0x0042721C File Offset: 0x0042541C
	private void EventOnMoraleSumLevelChanged(int oldLevel, int newLevel, int oldTemp, int newTemp)
	{
		if (oldLevel != newLevel)
		{
			MoraleModel instance = MoraleModel.Instance;
			if (instance != null)
			{
				instance.CheckSumLevelChanged(oldLevel, newLevel);
			}
		}
		if (oldTemp == 0 && newTemp == 0)
		{
			return;
		}
		int num = Math.Max(oldLevel + oldTemp, newLevel);
		int num2 = newLevel + newTemp;
		if (num != num2)
		{
			MoraleModel instance2 = MoraleModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.CheckSumLevelChanged(num, num2);
		}
	}

	// Token: 0x06011096 RID: 69782 RVA: 0x0042726C File Offset: 0x0042546C
	private void EventOnAddCommonItemNotify(IReadOnlyList<IProto_NormalItem> commonItemList)
	{
		IProto_NormalItem proto_NormalItem = null;
		for (int i = 0; i < commonItemList.Count; i++)
		{
			IProto_NormalItem proto_NormalItem2 = commonItemList[i];
			MoraleModel instance = MoraleModel.Instance;
			if (instance != null && instance.IsProgressScoreId(proto_NormalItem2.Id))
			{
				proto_NormalItem = proto_NormalItem2;
				break;
			}
		}
		if (proto_NormalItem != null)
		{
			MoraleModel.Instance.CheckProgressScoreChange(proto_NormalItem.Id, proto_NormalItem.Count, null);
		}
	}

	// Token: 0x06011097 RID: 69783 RVA: 0x004272D3 File Offset: 0x004254D3
	private void EventOnCommonItemCountRefresh(IProto_NormalItem item, int count, int lastCount)
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance != null && instance.IsProgressScoreId(item.Id))
		{
			MoraleModel.Instance.CheckProgressScoreChange(item.Id, count - lastCount, new int?(count));
		}
	}

	// Token: 0x06011098 RID: 69784 RVA: 0x00427307 File Offset: 0x00425507
	private void EventCommonItemFinished()
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance != null && instance.IsInitData)
		{
			MoraleModel.Instance.UpdateProgressScore();
		}
	}

	// Token: 0x06011099 RID: 69785 RVA: 0x00427328 File Offset: 0x00425528
	private void EventOnShowMoraleBuffTips(int entityId, GameplayCue cue, bool isAdd, int handleId)
	{
		if (!isAdd || cue.Parameters(0) != "0")
		{
			return;
		}
		string text = (cue.ParametersLength > 1) ? cue.Parameters(1) : null;
		int num;
		if (!string.IsNullOrEmpty(text) && int.TryParse(text, out num) && num != 0)
		{
			MoraleModel instance = MoraleModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.TryAddAreaBuffActiveState(num);
		}
	}

	// Token: 0x0601109A RID: 69786 RVA: 0x00427388 File Offset: 0x00425588
	private void EventOpenTreasureBox(int entityId)
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.CheckExplorerBoxOpen(entityId);
	}

	// Token: 0x170015A9 RID: 5545
	// (get) Token: 0x0601109B RID: 69787 RVA: 0x0042739A File Offset: 0x0042559A
	public static MoraleController Instance
	{
		get
		{
			return MoraleController._Instance;
		}
	}

	// Token: 0x0601109C RID: 69788 RVA: 0x004273A1 File Offset: 0x004255A1
	public static MoraleController GetOrCreateInstance()
	{
		if (MoraleController._Instance == null)
		{
			MoraleController.CreateInstance();
		}
		return MoraleController._Instance;
	}

	// Token: 0x0601109D RID: 69789 RVA: 0x004273B5 File Offset: 0x004255B5
	public static bool CreateInstance()
	{
		if (MoraleController._Instance != null)
		{
			return true;
		}
		MoraleController._Instance = new MoraleController();
		return true;
	}

	// Token: 0x0601109E RID: 69790 RVA: 0x004273CB File Offset: 0x004255CB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601109F RID: 69791 RVA: 0x004273CD File Offset: 0x004255CD
	public static void ResetStaticDefaultValue()
	{
		MoraleController._Instance = null;
	}

	// Token: 0x060110A0 RID: 69792 RVA: 0x004273D5 File Offset: 0x004255D5
	static MoraleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoraleController.CreateStaticDefaultValue), new Action(MoraleController.ResetStaticDefaultValue));
	}

	// Token: 0x0400819F RID: 33183
	private const string MORALE_CHARACTER_BUFF_TIPS_PARAM = "0";

	// Token: 0x040081A0 RID: 33184
	[Nullable(2)]
	private static MoraleController _Instance;
}
