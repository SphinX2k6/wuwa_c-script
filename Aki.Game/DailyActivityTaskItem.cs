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

// Token: 0x020019F1 RID: 6641
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityTaskItem : GridProxyAbstract<DailyActiveTaskData>
{
	// Token: 0x0600C25B RID: 49755 RVA: 0x002BDC48 File Offset: 0x002BBE48
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

	// Token: 0x0600C25C RID: 49756 RVA: 0x002BDDBE File Offset: 0x002BBFBE
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C25D RID: 49757 RVA: 0x002BDDD1 File Offset: 0x002BBFD1
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600C25E RID: 49758 RVA: 0x002BDDD3 File Offset: 0x002BBFD3
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

	// Token: 0x0600C25F RID: 49759 RVA: 0x002BDDEE File Offset: 0x002BBFEE
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

	// Token: 0x0600C260 RID: 49760 RVA: 0x002BDE22 File Offset: 0x002BC022
	private void OnClickItem()
	{
		if (this.TaskId == 0 || this.RewardItemId == 0)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.RewardItemId, true, null);
	}

	// Token: 0x0600C261 RID: 49761 RVA: 0x002BDE48 File Offset: 0x002BC048
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

	// Token: 0x0600C262 RID: 49762 RVA: 0x002BE138 File Offset: 0x002BC338
	public void SetClickReceiveCb(Action cb)
	{
		this.ClickReceiveCb = cb;
	}

	// Token: 0x0600C263 RID: 49763 RVA: 0x002BE144 File Offset: 0x002BC344
	public UniTask PlayRewardAnimAsync()
	{
		DailyActivityTaskItem.<PlayRewardAnimAsync>d__15 <PlayRewardAnimAsync>d__;
		<PlayRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimAsync>d__.<>4__this = this;
		<PlayRewardAnimAsync>d__.<>1__state = -1;
		<PlayRewardAnimAsync>d__.<>t__builder.Start<DailyActivityTaskItem.<PlayRewardAnimAsync>d__15>(ref <PlayRewardAnimAsync>d__);
		return <PlayRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400597B RID: 22907
	private int TaskId;

	// Token: 0x0400597C RID: 22908
	private bool IsFunctionUnlock;

	// Token: 0x0400597D RID: 22909
	private int RewardItemId;

	// Token: 0x0400597E RID: 22910
	private int JumpId;

	// Token: 0x0400597F RID: 22911
	[Nullable(2)]
	private Action ClickReceiveCb;

	// Token: 0x04005980 RID: 22912
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007F28 RID: 32552
	[NullableContext(0)]
	private enum EActiveTaskComponent
	{
		// Token: 0x04029872 RID: 170098
		TxtDescription,
		// Token: 0x04029873 RID: 170099
		TxtProcess,
		// Token: 0x04029874 RID: 170100
		TxtStatus,
		// Token: 0x04029875 RID: 170101
		PanelFinished,
		// Token: 0x04029876 RID: 170102
		RewardItem,
		// Token: 0x04029877 RID: 170103
		JumpButton,
		// Token: 0x04029878 RID: 170104
		RewardButton,
		// Token: 0x04029879 RID: 170105
		PanelMask,
		// Token: 0x0402987A RID: 170106
		TxtValue,
		// Token: 0x0402987B RID: 170107
		TextureActiveBg,
		// Token: 0x0402987C RID: 170108
		TextureDoneBg,
		// Token: 0x0402987D RID: 170109
		ContentItem
	}
}
