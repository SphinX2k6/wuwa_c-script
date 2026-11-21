using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000667 RID: 1639
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BlackCoastStageItem : GridProxyAbstract<BlackCoastStageInfo>
{
	// Token: 0x06004BD7 RID: 19415 RVA: 0x0019BC48 File Offset: 0x00199E48
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

	// Token: 0x06004BD8 RID: 19416 RVA: 0x0019BE60 File Offset: 0x0019A060
	[NullableContext(1)]
	public override void Refresh(BlackCoastStageInfo stageInfo, bool isSelected, int gridIndex)
	{
		this.Data = stageInfo;
		BlackCoastThemeStageRe value = ActivityBlackCoastConfig.Instance.GetStageConfig(this.Data.StageId).Value;
		this.RefreshState(stageInfo.StageState, value);
		this.RefreshText(stageInfo.StageState, value);
		this.RefreshRedDot();
	}

	// Token: 0x06004BD9 RID: 19417 RVA: 0x0019BEB4 File Offset: 0x0019A0B4
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

	// Token: 0x06004BDA RID: 19418 RVA: 0x0019BF78 File Offset: 0x0019A178
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

	// Token: 0x06004BDB RID: 19419 RVA: 0x0019BFF4 File Offset: 0x0019A1F4
	private void RefreshRedDot()
	{
		Func<int, bool> newFlagRedDot = this.NewFlagRedDot;
		bool flag = newFlagRedDot != null && newFlagRedDot(this.Data.StageId);
		base.GetItem(8).SetUIActive(this.Data.GetRewardState() || flag);
	}

	// Token: 0x06004BDC RID: 19420 RVA: 0x0019C038 File Offset: 0x0019A238
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

	// Token: 0x040037F6 RID: 14326
	private BlackCoastStageInfo Data;

	// Token: 0x040037F7 RID: 14327
	public Func<int, bool> NewFlagRedDot;

	// Token: 0x040037F8 RID: 14328
	public Action<int> OpenTaskView;

	// Token: 0x02006926 RID: 26918
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022A3B RID: 141883
		public const int Button = 0;

		// Token: 0x04022A3C RID: 141884
		public const int PanelNormal = 1;

		// Token: 0x04022A3D RID: 141885
		public const int TextProgress = 2;

		// Token: 0x04022A3E RID: 141886
		public const int FinishedTick = 3;

		// Token: 0x04022A3F RID: 141887
		public const int PanelLock = 4;

		// Token: 0x04022A40 RID: 141888
		public const int TextLockProgress = 5;

		// Token: 0x04022A41 RID: 141889
		public const int TextLock = 6;

		// Token: 0x04022A42 RID: 141890
		public const int Name = 7;

		// Token: 0x04022A43 RID: 141891
		public const int RedDot = 8;

		// Token: 0x04022A44 RID: 141892
		public const int UnlockStage1 = 9;

		// Token: 0x04022A45 RID: 141893
		public const int UnlockStage2 = 10;

		// Token: 0x04022A46 RID: 141894
		public const int UnlockStage3 = 11;

		// Token: 0x04022A47 RID: 141895
		public const int TextureLock = 12;
	}
}
