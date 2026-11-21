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
	// Token: 0x0200585D RID: 22621
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushSelectView : UiTabViewBase
	{
		// Token: 0x06037C44 RID: 228420 RVA: 0x00F97FD8 File Offset: 0x00F961D8
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

		// Token: 0x06037C45 RID: 228421 RVA: 0x00F980E4 File Offset: 0x00F962E4
		protected override void OnStart()
		{
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(BossRushModel.Instance.CurrentSelectActivityId) as BossRushData;
			this.BossRushData = bossRushData;
			this.LoopScrollView = new LoopScrollView<BossRushMainViewScrollItem, BossRushLevelDetailInfo>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, new Func<BossRushMainViewScrollItem>(this.CreateLoopItem), false);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TryShowNewUnlockTips();
		}

		// Token: 0x06037C46 RID: 228422 RVA: 0x00F9815C File Offset: 0x00F9635C
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

		// Token: 0x06037C47 RID: 228423 RVA: 0x00F98194 File Offset: 0x00F96394
		private void UnBindRedDot()
		{
			UUIItem item = base.GetItem(4);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BossRushReward, item, 0);
		}

		// Token: 0x06037C48 RID: 228424 RVA: 0x00F981BA File Offset: 0x00F963BA
		private BossRushMainViewScrollItem CreateLoopItem()
		{
			return new BossRushMainViewScrollItem();
		}

		// Token: 0x06037C49 RID: 228425 RVA: 0x00F981C1 File Offset: 0x00F963C1
		private void OnClickRewardButton()
		{
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.RequestChangeBossRushView, EUiTabViewName.BossRushRewardView);
		}

		// Token: 0x06037C4A RID: 228426 RVA: 0x00F981D8 File Offset: 0x00F963D8
		private void RefreshScrollView()
		{
			if (this.LoopScrollView != null)
			{
				this.LoopScrollView.RefreshByData(this.BossRushData.GetBossRushLevelDetailInfo(), false, null, false);
			}
		}

		// Token: 0x06037C4B RID: 228427 RVA: 0x00F981FB File Offset: 0x00F963FB
		protected override void OnBeforeShow()
		{
			this.TryShowAnimation();
			this.RefreshScrollView();
			this.RefreshPoint();
			this.BindRedDot();
		}

		// Token: 0x06037C4C RID: 228428 RVA: 0x00F98218 File Offset: 0x00F96418
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

		// Token: 0x06037C4D RID: 228429 RVA: 0x00F98267 File Offset: 0x00F96467
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06037C4E RID: 228430 RVA: 0x00F98270 File Offset: 0x00F96470
		private void RefreshPoint()
		{
			base.GetText(1).SetText(this.BossRushData.GetFullScore().ToString(), true);
		}

		// Token: 0x06037C4F RID: 228431 RVA: 0x00F982A0 File Offset: 0x00F964A0
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

		// Token: 0x06037C50 RID: 228432 RVA: 0x00F982E8 File Offset: 0x00F964E8
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

		// Token: 0x0401D6E4 RID: 120548
		private BossRushData BossRushData;

		// Token: 0x0401D6E5 RID: 120549
		private LoopScrollView<BossRushMainViewScrollItem, BossRushLevelDetailInfo> LoopScrollView;

		// Token: 0x0401D6E6 RID: 120550
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B484 RID: 46212
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04037D32 RID: 228658
			public const int RewardButton = 0;

			// Token: 0x04037D33 RID: 228659
			public const int RewardText = 1;

			// Token: 0x04037D34 RID: 228660
			public const int LoopScrollView = 2;

			// Token: 0x04037D35 RID: 228661
			public const int LoopItem = 3;

			// Token: 0x04037D36 RID: 228662
			public const int RedDot = 4;
		}
	}
}
