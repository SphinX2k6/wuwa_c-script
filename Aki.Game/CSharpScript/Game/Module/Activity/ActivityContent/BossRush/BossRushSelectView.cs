using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200690D RID: 26893
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushSelectView : UiTabViewBase
	{
		// Token: 0x060430EC RID: 274668 RVA: 0x010569AC File Offset: 0x01054BAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060430ED RID: 274669 RVA: 0x01056AB8 File Offset: 0x01054CB8
		protected override void OnStart()
		{
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(BossRushModel.Instance.CurrentSelectActivityId) as BossRushData;
			this.BossRushData = bossRushData;
			this.LoopScrollView = new LoopScrollView<BossRushMainViewScrollItem, BossRushLevelDetailInfo>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, new Func<BossRushMainViewScrollItem>(this.CreateLoopItem), false);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TryShowNewUnlockTips();
		}

		// Token: 0x060430EE RID: 274670 RVA: 0x01056B30 File Offset: 0x01054D30
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(4);
			RedDotController instance = RedDotController.Instance;
			ERedDotName name = ERedDotName.BossRushReward;
			UUIItem uiItem = item;
			Action<bool, int> stateChangeCallback = null;
			BossRushData bossRushData = this.BossRushData;
			instance.BindRedDot(name, uiItem, stateChangeCallback, (bossRushData != null) ? bossRushData.Id : 0);
		}

		// Token: 0x060430EF RID: 274671 RVA: 0x01056B68 File Offset: 0x01054D68
		private void UnBindRedDot()
		{
			UUIItem item = base.GetItem(4);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BossRushReward, item, 0);
		}

		// Token: 0x060430F0 RID: 274672 RVA: 0x01056B8E File Offset: 0x01054D8E
		private BossRushMainViewScrollItem CreateLoopItem()
		{
			return new BossRushMainViewScrollItem();
		}

		// Token: 0x060430F1 RID: 274673 RVA: 0x01056B95 File Offset: 0x01054D95
		private void OnClickRewardButton()
		{
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.RequestChangeBossRushView, EUiTabViewName.BossRushRewardView);
		}

		// Token: 0x060430F2 RID: 274674 RVA: 0x01056BAC File Offset: 0x01054DAC
		private void RefreshScrollView()
		{
			if (this.LoopScrollView != null)
			{
				this.LoopScrollView.RefreshByData(this.BossRushData.GetBossRushLevelDetailInfo(), false, null, false);
			}
		}

		// Token: 0x060430F3 RID: 274675 RVA: 0x01056BCF File Offset: 0x01054DCF
		protected override void OnBeforeShow()
		{
			this.TryShowAnimation();
			this.RefreshScrollView();
			this.RefreshPoint();
			this.BindRedDot();
		}

		// Token: 0x060430F4 RID: 274676 RVA: 0x01056BEC File Offset: 0x01054DEC
		private void TryShowAnimation()
		{
			string sequenceName = "Start";
			if (BossRushModel.Instance.PlayBackAnimation)
			{
				sequenceName = "ShowView";
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
			BossRushModel.Instance.PlayBackAnimation = false;
		}

		// Token: 0x060430F5 RID: 274677 RVA: 0x01056C3B File Offset: 0x01054E3B
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060430F6 RID: 274678 RVA: 0x01056C44 File Offset: 0x01054E44
		private void RefreshPoint()
		{
			base.GetText(1).SetText(this.BossRushData.GetFullScore().ToString(), true);
		}

		// Token: 0x060430F7 RID: 274679 RVA: 0x01056C74 File Offset: 0x01054E74
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int gridIndex;
			if (configParams.Length != 1 || !int.TryParse(configParams[0], out gridIndex))
			{
				return null;
			}
			UUIItem buttonItem = this.LoopScrollView.UnsafeGetGridProxy(gridIndex, false).GetButtonItem();
			if (buttonItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				buttonItem,
				buttonItem
			};
		}

		// Token: 0x060430F8 RID: 274680 RVA: 0x01056CBC File Offset: 0x01054EBC
		private void TryShowNewUnlockTips()
		{
			if (this.BossRushData.GetNewUnlockState())
			{
				this.BossRushData.CacheNewUnlock();
				DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
				difficultUnlockTipsData.Text = "BossRushUnlockTips";
				UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
			}
		}

		// Token: 0x04022E88 RID: 142984
		private BossRushData BossRushData;

		// Token: 0x04022E89 RID: 142985
		private LoopScrollView<BossRushMainViewScrollItem, BossRushLevelDetailInfo> LoopScrollView;

		// Token: 0x04022E8A RID: 142986
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CABC RID: 51900
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x0403D458 RID: 250968
			public const int RewardButton = 0;

			// Token: 0x0403D459 RID: 250969
			public const int RewardText = 1;

			// Token: 0x0403D45A RID: 250970
			public const int LoopScrollView = 2;

			// Token: 0x0403D45B RID: 250971
			public const int LoopItem = 3;

			// Token: 0x0403D45C RID: 250972
			public const int RedDot = 4;
		}
	}
}
