using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001702 RID: 5890
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MoraleController : UiControllerBase
{
	// Token: 0x0600E525 RID: 58661 RVA: 0x00433B2C File Offset: 0x00431D2C
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

	// Token: 0x0600E526 RID: 58662 RVA: 0x00433C00 File Offset: 0x00431E00
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

	// Token: 0x0600E527 RID: 58663 RVA: 0x00433CD4 File Offset: 0x00431ED4
	public UniTask RequestProgressReward(int[] ids)
	{
		MoraleController.<RequestProgressReward>d__3 <RequestProgressReward>d__;
		<RequestProgressReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestProgressReward>d__.ids = ids;
		<RequestProgressReward>d__.<>1__state = -1;
		<RequestProgressReward>d__.<>t__builder.Start<MoraleController.<RequestProgressReward>d__3>(ref <RequestProgressReward>d__);
		return <RequestProgressReward>d__.<>t__builder.Task;
	}

	// Token: 0x0600E528 RID: 58664 RVA: 0x00433D18 File Offset: 0x00431F18
	public UniTask RequestGetPlayerMoraleAreaId()
	{
		MoraleController.<RequestGetPlayerMoraleAreaId>d__4 <RequestGetPlayerMoraleAreaId>d__;
		<RequestGetPlayerMoraleAreaId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGetPlayerMoraleAreaId>d__.<>1__state = -1;
		<RequestGetPlayerMoraleAreaId>d__.<>t__builder.Start<MoraleController.<RequestGetPlayerMoraleAreaId>d__4>(ref <RequestGetPlayerMoraleAreaId>d__);
		return <RequestGetPlayerMoraleAreaId>d__.<>t__builder.Task;
	}

	// Token: 0x0600E529 RID: 58665 RVA: 0x00433D54 File Offset: 0x00431F54
	public UniTask RequestGetExplorerBoxTrackList(int areaId)
	{
		MoraleController.<RequestGetExplorerBoxTrackList>d__5 <RequestGetExplorerBoxTrackList>d__;
		<RequestGetExplorerBoxTrackList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGetExplorerBoxTrackList>d__.areaId = areaId;
		<RequestGetExplorerBoxTrackList>d__.<>1__state = -1;
		<RequestGetExplorerBoxTrackList>d__.<>t__builder.Start<MoraleController.<RequestGetExplorerBoxTrackList>d__5>(ref <RequestGetExplorerBoxTrackList>d__);
		return <RequestGetExplorerBoxTrackList>d__.<>t__builder.Task;
	}

	// Token: 0x0600E52A RID: 58666 RVA: 0x00433D97 File Offset: 0x00431F97
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

	// Token: 0x0600E52B RID: 58667 RVA: 0x00433DAC File Offset: 0x00431FAC
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

	// Token: 0x0600E52C RID: 58668 RVA: 0x00433DFC File Offset: 0x00431FFC
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

	// Token: 0x0600E52D RID: 58669 RVA: 0x00433E63 File Offset: 0x00432063
	private void EventOnCommonItemCountRefresh(IProto_NormalItem item, int count, int lastCount)
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance != null && instance.IsProgressScoreId(item.Id))
		{
			MoraleModel.Instance.CheckProgressScoreChange(item.Id, count - lastCount, new int?(count));
		}
	}

	// Token: 0x0600E52E RID: 58670 RVA: 0x00433E97 File Offset: 0x00432097
	private void EventCommonItemFinished()
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance != null && instance.IsInitData)
		{
			MoraleModel.Instance.UpdateProgressScore();
		}
	}

	// Token: 0x0600E52F RID: 58671 RVA: 0x00433EB8 File Offset: 0x004320B8
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

	// Token: 0x0600E530 RID: 58672 RVA: 0x00433F18 File Offset: 0x00432118
	private void EventOpenTreasureBox(int entityId)
	{
		MoraleModel instance = MoraleModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.CheckExplorerBoxOpen(entityId);
	}

	// Token: 0x170015E0 RID: 5600
	// (get) Token: 0x0600E531 RID: 58673 RVA: 0x00433F2A File Offset: 0x0043212A
	public static MoraleController Instance
	{
		get
		{
			return MoraleController._Instance;
		}
	}

	// Token: 0x0600E532 RID: 58674 RVA: 0x00433F31 File Offset: 0x00432131
	public static MoraleController GetOrCreateInstance()
	{
		if (MoraleController._Instance == null)
		{
			MoraleController.CreateInstance();
		}
		return MoraleController._Instance;
	}

	// Token: 0x0600E533 RID: 58675 RVA: 0x00433F45 File Offset: 0x00432145
	public static bool CreateInstance()
	{
		if (MoraleController._Instance != null)
		{
			return true;
		}
		MoraleController._Instance = new MoraleController();
		return true;
	}

	// Token: 0x0600E534 RID: 58676 RVA: 0x00433F5B File Offset: 0x0043215B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E535 RID: 58677 RVA: 0x00433F5D File Offset: 0x0043215D
	public static void ResetStaticDefaultValue()
	{
		MoraleController._Instance = null;
	}

	// Token: 0x0600E536 RID: 58678 RVA: 0x00433F65 File Offset: 0x00432165
	static MoraleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoraleController.CreateStaticDefaultValue), new Action(MoraleController.ResetStaticDefaultValue));
	}

	// Token: 0x040082DD RID: 33501
	private const string MORALE_CHARACTER_BUFF_TIPS_PARAM = "0";

	// Token: 0x040082DE RID: 33502
	[Nullable(2)]
	private static MoraleController _Instance;
}
