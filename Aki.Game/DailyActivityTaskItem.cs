using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EB0 RID: 3760
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityTaskItem : GridProxyAbstract<DailyActiveTaskData>
{
	// Token: 0x06009668 RID: 38504 RVA: 0x002C8C20 File Offset: 0x002C6E20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickItem)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickJumpToBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickTakeRewardBtn))
		};
	}

	// Token: 0x06009669 RID: 38505 RVA: 0x002C8D96 File Offset: 0x002C6F96
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600966A RID: 38506 RVA: 0x002C8DA9 File Offset: 0x002C6FA9
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x002C8DAB File Offset: 0x002C6FAB
	private void OnClickTakeRewardBtn()
	{
		if (this.TaskId == 0)
		{
			return;
		}
		Action clickReceiveCb = this.ClickReceiveCb;
		if (clickReceiveCb == null)
		{
			return;
		}
		clickReceiveCb();
	}

	// Token: 0x0600966C RID: 38508 RVA: 0x002C8DC6 File Offset: 0x002C6FC6
	private void OnClickJumpToBtn()
	{
		if (this.TaskId == 0)
		{
			return;
		}
		if (!this.IsFunctionUnlock)
		{
			GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x0600966D RID: 38509 RVA: 0x002C8DFA File Offset: 0x002C6FFA
	private void OnClickItem()
	{
		if (this.TaskId == 0 || this.RewardItemId == 0)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.RewardItemId, true, null, false);
	}

	// Token: 0x0600966E RID: 38510 RVA: 0x002C8E20 File Offset: 0x002C7020
	public override void Refresh(DailyActiveTaskData data, bool isSelected, int gridIndex)
	{
		this.TaskId = data.TaskId.Value;
		this.IsFunctionUnlock = data.IsFunctionUnlock;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DailyTask_ProgressText", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.CurrentProgress.ToString(),
			data.TargetProgress.ToString()
		}));
		LivenessTask value = DailyActivityConfig.Instance.GetActivityTaskConfigById(this.TaskId).Value;
		string taskName = value.TaskName;
		int updateType = value.UpdateType;
		List<string> list = new List<string>();
		if (updateType == 2)
		{
			int areaId = DailyActivityModel.Instance.AreaId;
			if (areaId > 0)
			{
				Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
				if (areaInfo != null)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(areaInfo.Value.Title, null);
					if (localTextNew != null)
					{
						list.Add(localTextNew);
					}
				}
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), taskName, list.ToArray());
		this.JumpId = value.AccessId;
		TItem titem = data.RewardItemList[0];
		this.RewardItemId = titem.ItemData.ItemId;
		base.GetText(8).SetText("+" + titem.Count.ToString(), true);
		switch (data.TaskState)
		{
		case EDailyActiveState.FinishedAndNotTaken:
			base.GetText(2).SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			break;
		case EDailyActiveState.Unfinished:
		{
			bool flag = this.JumpId != 0;
			base.GetText(2).SetUIActive(!flag);
			base.GetButton(5).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			break;
		}
		case EDailyActiveState.FinishedAndTaken:
			base.GetText(2).SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
			break;
		}
		bool flag2 = data.TaskState == EDailyActiveState.FinishedAndTaken;
		base.GetItem(9).SetUIActive(!flag2);
		base.GetItem(10).SetUIActive(flag2);
		base.GetItem(11).SetAlpha(flag2 ? 0.5f : 1f);
	}

	// Token: 0x0600966F RID: 38511 RVA: 0x002C9110 File Offset: 0x002C7310
	public void SetClickReceiveCb(Action cb)
	{
		this.ClickReceiveCb = cb;
	}

	// Token: 0x06009670 RID: 38512 RVA: 0x002C911C File Offset: 0x002C731C
	public UniTask PlayRewardAnimAsync()
	{
		DailyActivityTaskItem.<PlayRewardAnimAsync>d__15 <PlayRewardAnimAsync>d__;
		<PlayRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimAsync>d__.<>4__this = this;
		<PlayRewardAnimAsync>d__.<>1__state = -1;
		<PlayRewardAnimAsync>d__.<>t__builder.Start<DailyActivityTaskItem.<PlayRewardAnimAsync>d__15>(ref <PlayRewardAnimAsync>d__);
		return <PlayRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04005A4A RID: 23114
	private int TaskId;

	// Token: 0x04005A4B RID: 23115
	private bool IsFunctionUnlock;

	// Token: 0x04005A4C RID: 23116
	private int RewardItemId;

	// Token: 0x04005A4D RID: 23117
	private int JumpId;

	// Token: 0x04005A4E RID: 23118
	[Nullable(2)]
	private Action ClickReceiveCb;

	// Token: 0x04005A4F RID: 23119
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020070B7 RID: 28855
	[NullableContext(0)]
	private enum EActiveTaskComponent
	{
		// Token: 0x04024BAF RID: 150447
		TxtDescription,
		// Token: 0x04024BB0 RID: 150448
		TxtProcess,
		// Token: 0x04024BB1 RID: 150449
		TxtStatus,
		// Token: 0x04024BB2 RID: 150450
		PanelFinished,
		// Token: 0x04024BB3 RID: 150451
		RewardItem,
		// Token: 0x04024BB4 RID: 150452
		JumpButton,
		// Token: 0x04024BB5 RID: 150453
		RewardButton,
		// Token: 0x04024BB6 RID: 150454
		PanelMask,
		// Token: 0x04024BB7 RID: 150455
		TxtValue,
		// Token: 0x04024BB8 RID: 150456
		TextureActiveBg,
		// Token: 0x04024BB9 RID: 150457
		TextureDoneBg,
		// Token: 0x04024BBA RID: 150458
		ContentItem
	}
}
