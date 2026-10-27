using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002680 RID: 9856
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestReviewNodeItem : GridProxyAbstract<QuestReviewNodeParam>
{
	// Token: 0x170019F5 RID: 6645
	// (get) Token: 0x06014325 RID: 82725 RVA: 0x005199CF File Offset: 0x00517BCF
	// (set) Token: 0x06014326 RID: 82726 RVA: 0x005199D7 File Offset: 0x00517BD7
	private TimerHandle Timer
	{
		get
		{
			return this.TimerInternal;
		}
		set
		{
			if (this.TimerInternal != null && TimerSystem.Instance.Has(this.TimerInternal))
			{
				TimerSystem.Instance.Remove(this.TimerInternal);
			}
			this.TimerInternal = value;
		}
	}

	// Token: 0x06014327 RID: 82727 RVA: 0x00519A0C File Offset: 0x00517C0C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014328 RID: 82728 RVA: 0x00519AFC File Offset: 0x00517CFC
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewNodeItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewNodeItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014329 RID: 82729 RVA: 0x00519B3F File Offset: 0x00517D3F
	protected override void OnStart()
	{
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		EventSystem.Instance.Add(EEventName.OnQuestReviewMainViewBeforeHide, new Action(this.OnMainViewBeforeHide));
	}

	// Token: 0x0601432A RID: 82730 RVA: 0x00519B75 File Offset: 0x00517D75
	protected override void OnBeforeDestroy()
	{
		this.Timer = null;
		EventSystem.Instance.Remove(EEventName.OnQuestReviewMainViewBeforeHide, new Action(this.OnMainViewBeforeHide));
	}

	// Token: 0x0601432B RID: 82731 RVA: 0x00519B9C File Offset: 0x00517D9C
	public override void Refresh(QuestReviewNodeParam param, bool isSelected, int gridIndex)
	{
		this.Param = param;
		if (param == null)
		{
			this.ItemNormal.SetUiActive(false);
			this.ItemDestroy.SetUiActive(false);
			this.ItemStar.SetUiActive(false);
			this.ItemStarDestroy.SetUiActive(false);
			base.GetRootItem().SetAlpha(0f);
			return;
		}
		this.ItemNormal.SetUiActive(this.ShouldShowNormal(param));
		this.ItemDestroy.SetUiActive(this.ShouldShowDestroy(param));
		this.ItemStar.SetUiActive(this.ShouldShowStar(param));
		this.ItemStarDestroy.SetUiActive(this.ShouldShowStarDestroy(param));
		if (param.ShouldHide)
		{
			base.GetRootItem().SetAlpha(0f);
			return;
		}
		base.GetRootItem().SetAlpha(1f);
		if (this.ShouldShowNormal(param))
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Flame", false, null, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.StopCurrentSequence(false, false);
			}
			this.ItemNormal.Refresh(param);
		}
		if (this.ShouldShowDestroy(param))
		{
			this.ItemDestroy.Refresh(param);
		}
		if (this.ShouldShowStar(param))
		{
			this.ItemStar.Refresh(param);
		}
		if (this.ShouldShowStarDestroy(param))
		{
			this.ItemStarDestroy.Refresh(param);
		}
		this.HandleAnim(param);
	}

	// Token: 0x0601432C RID: 82732 RVA: 0x00519CF4 File Offset: 0x00517EF4
	private void HandleAnim(IQuestReviewNodeParam param)
	{
		QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(param.LineId);
		if (questReviewLineDataById != null && questReviewLineDataById.SkipAnim)
		{
			return;
		}
		if (!this.ShouldShowNormal(param))
		{
			if (this.ShouldShowDestroy(param))
			{
				if (questReviewLineDataById == null || !questReviewLineDataById.IsDestroy || questReviewLineDataById == null || !questReviewLineDataById.IsFirstTimeDestroy)
				{
					this.SeqPlayer.PlayLevelSequenceByName("ActivateStartC", false, null, false);
					return;
				}
				this.PlayFirstLineDestroyAnim(param);
				QuestReviewNodeData data = param.Data;
				if (data != null && data.IsFirstTimeShow)
				{
					param.Data.IsFirstTimeShow = false;
					return;
				}
			}
			else if (this.ShouldShowStar(param))
			{
				bool flag = param.LineId == 3200;
				bool flag2 = QuestReviewModel.Instance.HasQuestLineFused();
				if (flag && !flag2)
				{
					QuestReviewNodeStarItem itemStar = this.ItemStar;
					if (itemStar != null)
					{
						itemStar.SetUiActive(false);
					}
					this.Timer = TimerSystem.Instance.Delay(delegate(float _)
					{
						QuestReviewNodeStarItem itemStar2 = this.ItemStar;
						if (itemStar2 != null)
						{
							itemStar2.SetUiActive(true);
						}
						this.SeqPlayer.PlayLevelSequenceByName("UnTrigger", false, null, false);
					}, 20f, null, null, true, 1f);
					return;
				}
				this.SeqPlayer.PlayLevelSequenceByName("NotStart", false, null, false);
				return;
			}
			else if (this.ShouldShowStarDestroy(param))
			{
				if (questReviewLineDataById != null && questReviewLineDataById.IsDestroy && questReviewLineDataById != null && questReviewLineDataById.IsFirstTimeDestroy)
				{
					this.PlayFirstLineStarAnim(param);
					QuestReviewNodeData data2 = param.Data;
					if (data2 != null && data2.IsFirstTimeShow)
					{
						param.Data.IsFirstTimeShow = false;
						return;
					}
				}
				else
				{
					this.SeqPlayer.PlayLevelSequenceByName("NotStartB", false, null, false);
				}
			}
			return;
		}
		if (QuestReviewModel.Instance.IsFirstEntry())
		{
			this.PlayFirstEntryNodeAnim(param);
			QuestReviewNodeData data3 = param.Data;
			if (data3 != null && data3.IsFirstTimeShow)
			{
				param.Data.IsFirstTimeShow = false;
			}
			if (questReviewLineDataById != null && questReviewLineDataById.IsFirstTimeShow)
			{
				questReviewLineDataById.IsFirstTimeShow = false;
			}
			return;
		}
		if (questReviewLineDataById != null && questReviewLineDataById.IsShow && questReviewLineDataById != null && questReviewLineDataById.IsFirstTimeShow)
		{
			this.PlayFirstShowAnim(param);
			QuestReviewNodeData data4 = param.Data;
			if (data4 != null && data4.IsFirstTimeShow)
			{
				param.Data.IsFirstTimeShow = false;
			}
		}
		QuestReviewNodeData data5 = param.Data;
		if (data5 != null && data5.IsFirstTimeShow)
		{
			this.PlayFirstShowAnim(param);
			param.Data.IsFirstTimeShow = false;
			return;
		}
		this.SeqPlayer.PlayLevelSequenceByName("ActivateStart", false, null, false);
	}

	// Token: 0x0601432D RID: 82733 RVA: 0x00519F3C File Offset: 0x0051813C
	private bool ShouldShowNormal(IQuestReviewNodeParam param)
	{
		if (param == null)
		{
			return false;
		}
		QuestReviewModel instance = QuestReviewModel.Instance;
		QuestReviewNodeData data = param.Data;
		QuestReviewNodeData predecessorNodeByNodeId = instance.GetPredecessorNodeByNodeId((data != null) ? data.Id : 0);
		return param.Data != null && param.Data.State != EQuestReviewNodeState.Locked && !param.IsDestroy && (param.Data.ShowOnceUnlock || predecessorNodeByNodeId == null || (predecessorNodeByNodeId != null && predecessorNodeByNodeId.State == EQuestReviewNodeState.Finished));
	}

	// Token: 0x0601432E RID: 82734 RVA: 0x00519FAA File Offset: 0x005181AA
	private bool ShouldShowDestroy(IQuestReviewNodeParam param)
	{
		return param != null && param.Data != null && param.IsDestroy;
	}

	// Token: 0x0601432F RID: 82735 RVA: 0x00519FC4 File Offset: 0x005181C4
	private bool ShouldShowStar(IQuestReviewNodeParam param)
	{
		if (param == null)
		{
			return false;
		}
		QuestReviewModel instance = QuestReviewModel.Instance;
		QuestReviewNodeData data = param.Data;
		QuestReviewNodeData predecessorNodeByNodeId = instance.GetPredecessorNodeByNodeId((data != null) ? data.Id : 0);
		return (param.Data == null || param.Data.State == EQuestReviewNodeState.Locked || (!param.Data.ShowOnceUnlock && predecessorNodeByNodeId != null && predecessorNodeByNodeId.State < EQuestReviewNodeState.Finished)) && !param.IsDestroy;
	}

	// Token: 0x06014330 RID: 82736 RVA: 0x0051A02C File Offset: 0x0051822C
	private bool ShouldShowStarDestroy(IQuestReviewNodeParam param)
	{
		if (param == null)
		{
			return false;
		}
		QuestReviewModel instance = QuestReviewModel.Instance;
		QuestReviewNodeData data = param.Data;
		QuestReviewNodeData predecessorNodeByNodeId = instance.GetPredecessorNodeByNodeId((data != null) ? data.Id : 0);
		return (param.Data == null || param.Data.State == EQuestReviewNodeState.Locked || (!param.Data.ShowOnceUnlock && predecessorNodeByNodeId != null && predecessorNodeByNodeId.State < EQuestReviewNodeState.Finished)) && param.IsDestroy;
	}

	// Token: 0x06014331 RID: 82737 RVA: 0x0051A094 File Offset: 0x00518294
	private void PlayFirstShowAnim(IQuestReviewNodeParam param)
	{
		QuestReviewNodeNormalItem itemNormal = this.ItemNormal;
		if (itemNormal != null)
		{
			itemNormal.SetUiActive(false);
		}
		QuestReviewNodeStarItem itemStar = this.ItemStar;
		if (itemStar != null)
		{
			itemStar.SetUiActive(true);
		}
		QuestReviewNodeStarItem itemStar2 = this.ItemStar;
		if (itemStar2 != null)
		{
			itemStar2.Refresh(param);
		}
		this.SeqPlayer.PlayLevelSequenceByName("NotStart", false, null, false);
		QuestReviewLineData lineData = QuestReviewModel.Instance.GetQuestReviewLineDataById(param.LineId);
		this.Timer = TimerSystem.Instance.Delay(delegate(float _)
		{
			QuestReviewNodeNormalItem itemNormal2 = this.ItemNormal;
			if (itemNormal2 != null)
			{
				itemNormal2.SetUiActive(true);
			}
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName(lineData.ShowSeqName, false, null, false);
		}, 20f, null, null, true, 1f);
	}

	// Token: 0x06014332 RID: 82738 RVA: 0x0051A140 File Offset: 0x00518340
	private void PlayFirstEntryNodeAnim(IQuestReviewNodeParam param)
	{
		QuestReviewNodeNormalItem itemNormal = this.ItemNormal;
		if (itemNormal != null)
		{
			itemNormal.SetUiActive(false);
		}
		QuestReviewNodeStarItem itemStar = this.ItemStar;
		if (itemStar != null)
		{
			itemStar.SetUiActive(true);
		}
		QuestReviewNodeStarItem itemStar2 = this.ItemStar;
		if (itemStar2 != null)
		{
			itemStar2.Refresh(param);
		}
		QuestReviewLineData lineData = QuestReviewModel.Instance.GetQuestReviewLineDataById(param.LineId);
		this.Timer = TimerSystem.Instance.Delay(delegate(float _)
		{
			QuestReviewNodeNormalItem itemNormal2 = this.ItemNormal;
			if (itemNormal2 != null)
			{
				itemNormal2.SetUiActive(true);
			}
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName(lineData.NodeFirstActivateSeqName, false, null, false);
		}, 1800f, null, null, true, 1f);
	}

	// Token: 0x06014333 RID: 82739 RVA: 0x0051A1D0 File Offset: 0x005183D0
	private UniTask PlayFirstLineDestroyAnim(IQuestReviewNodeParam param)
	{
		QuestReviewNodeItem.<PlayFirstLineDestroyAnim>d__22 <PlayFirstLineDestroyAnim>d__;
		<PlayFirstLineDestroyAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFirstLineDestroyAnim>d__.<>4__this = this;
		<PlayFirstLineDestroyAnim>d__.param = param;
		<PlayFirstLineDestroyAnim>d__.<>1__state = -1;
		<PlayFirstLineDestroyAnim>d__.<>t__builder.Start<QuestReviewNodeItem.<PlayFirstLineDestroyAnim>d__22>(ref <PlayFirstLineDestroyAnim>d__);
		return <PlayFirstLineDestroyAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014334 RID: 82740 RVA: 0x0051A21C File Offset: 0x0051841C
	private UniTask PlayFirstLineStarAnim(IQuestReviewNodeParam param)
	{
		QuestReviewNodeItem.<PlayFirstLineStarAnim>d__23 <PlayFirstLineStarAnim>d__;
		<PlayFirstLineStarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFirstLineStarAnim>d__.<>4__this = this;
		<PlayFirstLineStarAnim>d__.param = param;
		<PlayFirstLineStarAnim>d__.<>1__state = -1;
		<PlayFirstLineStarAnim>d__.<>t__builder.Start<QuestReviewNodeItem.<PlayFirstLineStarAnim>d__23>(ref <PlayFirstLineStarAnim>d__);
		return <PlayFirstLineStarAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014335 RID: 82741 RVA: 0x0051A268 File Offset: 0x00518468
	private void OnMainViewBeforeHide()
	{
		string sequenceName = "ActivateClose";
		if (this.ShouldShowNormal(this.Param))
		{
			sequenceName = "ActivateClose";
		}
		else if (this.ShouldShowDestroy(this.Param))
		{
			sequenceName = "ActivateCloseC";
		}
		else if (this.ShouldShowStar(this.Param))
		{
			sequenceName = "NotClose";
		}
		else if (this.ShouldShowStarDestroy(this.Param))
		{
			sequenceName = "NotCloseB";
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06014336 RID: 82742 RVA: 0x0051A2F0 File Offset: 0x005184F0
	private void OnSequenceEndEvent(string seqName)
	{
		if (!base.GetRootActor().IsValid())
		{
			return;
		}
		if (seqName == "Flame")
		{
			QuestReviewNodeNormalItem itemNormal = this.ItemNormal;
			if (itemNormal != null)
			{
				itemNormal.SetUiActive(false);
			}
			QuestReviewNodeNormalItem itemNormal2 = this.ItemNormal;
			if (itemNormal2 != null)
			{
				itemNormal2.SetToggleInteractive(true);
			}
			QuestReviewController.Instance.SetBurnFinish();
		}
		if (seqName == "Change")
		{
			QuestReviewNodeNormalItem itemNormal3 = this.ItemNormal;
			if (itemNormal3 != null)
			{
				itemNormal3.SetUiActive(false);
			}
			QuestReviewNodeNormalItem itemNormal4 = this.ItemNormal;
			if (itemNormal4 != null)
			{
				itemNormal4.SetToggleInteractive(true);
			}
		}
		if (seqName == "Trigger")
		{
			QuestReviewController.Instance.SetNewTabUnlockFinish();
		}
	}

	// Token: 0x04009806 RID: 38918
	private QuestReviewNodeNormalItem ItemNormal;

	// Token: 0x04009807 RID: 38919
	private QuestReviewNodeDestroyItem ItemDestroy;

	// Token: 0x04009808 RID: 38920
	private QuestReviewNodeStarItem ItemStar;

	// Token: 0x04009809 RID: 38921
	private QuestReviewNodeStarDestroyItem ItemStarDestroy;

	// Token: 0x0400980A RID: 38922
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400980B RID: 38923
	private TimerHandle TimerInternal;

	// Token: 0x0400980C RID: 38924
	private QuestReviewNodeParam Param;

	// Token: 0x02008CCB RID: 36043
	[NullableContext(0)]
	private class ENodeComponentDefine
	{
		// Token: 0x0402DB05 RID: 187141
		public const int ItemSelf = 0;

		// Token: 0x0402DB06 RID: 187142
		public const int ItemNormal = 1;

		// Token: 0x0402DB07 RID: 187143
		public const int ItemDestroy = 2;

		// Token: 0x0402DB08 RID: 187144
		public const int ItemStar = 3;

		// Token: 0x0402DB09 RID: 187145
		public const int ItemStarDestroy = 4;

		// Token: 0x0402DB0A RID: 187146
		public const int ItemRedDot = 5;
	}
}
