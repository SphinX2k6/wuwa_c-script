using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011B3 RID: 4531
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BlackCoastStageItem : GridProxyAbstract<BlackCoastStageInfo>
{
	// Token: 0x06007840 RID: 30784 RVA: 0x0019307C File Offset: 0x0019127C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITextureTransitionComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007841 RID: 30785 RVA: 0x00193294 File Offset: 0x00191494
	[NullableContext(1)]
	public override void Refresh(BlackCoastStageInfo stageInfo, bool isSelected, int gridIndex)
	{
		this.Data = stageInfo;
		BlackCoastThemeStageRe value = ActivityBlackCoastConfig.Instance.GetStageConfig(this.Data.StageId).Value;
		this.RefreshState(stageInfo.StageState, value);
		this.RefreshText(stageInfo.StageState, value);
		this.RefreshRedDot();
	}

	// Token: 0x06007842 RID: 30786 RVA: 0x001932E8 File Offset: 0x001914E8
	private void RefreshState(EStageState state, BlackCoastThemeStageRe config)
	{
		bool flag = state == EStageState.Lock;
		bool flag2 = state == EStageState.Active;
		bool flag3 = state == EStageState.Finished;
		base.GetItem(1).SetUIActive(flag2 || flag3);
		base.GetItem(4).SetUIActive(flag);
		base.GetItem(3).SetUIActive(flag3);
		base.GetText(2).SetUIActive(flag2);
		if (flag)
		{
			UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(12);
			base.SetTextureTransitionByPath(config.TextureNormal, uiTextureTransitionComponent, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			return;
		}
		UUIItem[] array = new UUIItem[]
		{
			base.GetItem(9),
			base.GetItem(10),
			base.GetItem(11)
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetUIActive(this.Data.Index == i);
		}
	}

	// Token: 0x06007843 RID: 30787 RVA: 0x001933AC File Offset: 0x001915AC
	private void RefreshText(EStageState state, BlackCoastThemeStageRe config)
	{
		if (state == EStageState.Active)
		{
			int taskProgress = this.Data.GetTaskProgress();
			base.GetText(2).SetText(taskProgress.ToString() + "%", true);
		}
		if (state == EStageState.Lock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), this.Data.GetLockConditionText(), Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), config.Title, Array.Empty<object>());
	}

	// Token: 0x06007844 RID: 30788 RVA: 0x00193428 File Offset: 0x00191628
	private void RefreshRedDot()
	{
		Func<int, bool> newFlagRedDot = this.NewFlagRedDot;
		bool flag = newFlagRedDot != null && newFlagRedDot(this.Data.StageId);
		base.GetItem(8).SetUIActive(this.Data.GetRewardState() || flag);
	}

	// Token: 0x06007845 RID: 30789 RVA: 0x0019346C File Offset: 0x0019166C
	private void OnClick()
	{
		if (this.Data == null)
		{
			return;
		}
		if (!this.Data.IsUnlock)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId(this.Data.GetLockConditionText(), Array.Empty<object>());
			return;
		}
		Action<int> openTaskView = this.OpenTaskView;
		if (openTaskView == null)
		{
			return;
		}
		openTaskView(this.Data.StageId);
	}

	// Token: 0x0400375D RID: 14173
	private BlackCoastStageInfo Data;

	// Token: 0x0400375E RID: 14174
	public Func<int, bool> NewFlagRedDot;

	// Token: 0x0400375F RID: 14175
	public Action<int> OpenTaskView;

	// Token: 0x0200779A RID: 30618
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027705 RID: 161541
		public const int Button = 0;

		// Token: 0x04027706 RID: 161542
		public const int PanelNormal = 1;

		// Token: 0x04027707 RID: 161543
		public const int TextProgress = 2;

		// Token: 0x04027708 RID: 161544
		public const int FinishedTick = 3;

		// Token: 0x04027709 RID: 161545
		public const int PanelLock = 4;

		// Token: 0x0402770A RID: 161546
		public const int TextLockProgress = 5;

		// Token: 0x0402770B RID: 161547
		public const int TextLock = 6;

		// Token: 0x0402770C RID: 161548
		public const int Name = 7;

		// Token: 0x0402770D RID: 161549
		public const int RedDot = 8;

		// Token: 0x0402770E RID: 161550
		public const int UnlockStage1 = 9;

		// Token: 0x0402770F RID: 161551
		public const int UnlockStage2 = 10;

		// Token: 0x04027710 RID: 161552
		public const int UnlockStage3 = 11;

		// Token: 0x04027711 RID: 161553
		public const int TextureLock = 12;
	}
}
