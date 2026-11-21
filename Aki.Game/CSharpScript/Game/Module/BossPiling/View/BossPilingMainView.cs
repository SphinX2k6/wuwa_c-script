using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling.View.Item;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02004BF1 RID: 19441
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingMainView : UiTickViewBase
	{
		// Token: 0x06030838 RID: 198712 RVA: 0x00D83C0F File Offset: 0x00D81E0F
		public BossPilingMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030839 RID: 198713 RVA: 0x00D83C20 File Offset: 0x00D81E20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603083A RID: 198714 RVA: 0x00D83D8C File Offset: 0x00D81F8C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603083B RID: 198715 RVA: 0x00D83DAA File Offset: 0x00D81FAA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603083C RID: 198716 RVA: 0x00D83DC8 File Offset: 0x00D81FC8
		protected override void OnStart()
		{
			this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
			this.ActivityData = BossPilingModel.Instance.GetActivityData();
			this.ActivityData.RefreshUnlockState();
			this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(551);
			});
			bool flag = BossPilingModel.Instance.CheckIsBossPiling();
			this.CaptionItem.SetHomeBtnShowState(!flag);
			this.RewardBtn = new ButtonItem(base.GetItem(5));
			this.RewardBtn.SetFunction(delegate(int _)
			{
				UiManager.Instance.OpenView(EUiViewName.BossPilingTaskView, null, null);
			});
			this.Layout = new GenericLayout<BossPilingBossTabItem, BossPilingLevelInfo>(base.GetVerticalLayout(3), new Func<BossPilingBossTabItem>(this.CreateBossItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			this.CurSelected = this.ActivityData.GetFirstSelectLevel();
		}

		// Token: 0x0603083D RID: 198717 RVA: 0x00D83EEC File Offset: 0x00D820EC
		protected override void OnBeforeShow()
		{
			this.RefreshRewardBtn();
			List<BossPilingLevelInfo> allLevelInfo = this.ActivityData.GetAllLevelInfo();
			this.Layout.RefreshByData(allLevelInfo, null, true);
			this.RefreshPanel();
		}

		// Token: 0x0603083E RID: 198718 RVA: 0x00D83F1F File Offset: 0x00D8211F
		protected override void OnBeforeHide()
		{
			this.ActivityData.ClearLevelRedDot();
			this.RewardBtn.UnBindRedDot();
		}

		// Token: 0x0603083F RID: 198719 RVA: 0x00D83F38 File Offset: 0x00D82138
		protected override void OnTick(float delta)
		{
			if (!this.NeedTick)
			{
				return;
			}
			List<BossPilingBossTabItem> layoutItemList = this.Layout.GetLayoutItemList();
			bool flag = false;
			foreach (BossPilingBossTabItem bossPilingBossTabItem in layoutItemList)
			{
				bool flag2 = bossPilingBossTabItem.OnTick();
				flag = (flag || flag2);
			}
			if (!flag && layoutItemList.Count > 0)
			{
				this.NeedTick = false;
			}
		}

		// Token: 0x06030840 RID: 198720 RVA: 0x00D83FB4 File Offset: 0x00D821B4
		protected void RefreshRewardBtn()
		{
			this.RewardBtn.BindRedDot(ERedDotName.BossPilingReward, 0);
			List<int> taskNumState = this.ActivityData.GetTaskNumState();
			ButtonItem rewardBtn = this.RewardBtn;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskNumState[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskNumState[1]);
			rewardBtn.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06030841 RID: 198721 RVA: 0x00D84024 File Offset: 0x00D82224
		protected void RefreshPanel()
		{
			BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(this.CurSelected);
			if (levelInfo == null)
			{
				return;
			}
			this.LevelSequence.PlayOrReplaySequenceByName("Switch", false, null);
			BossPilingLevelInfo levelInfo2 = this.ActivityData.GetLevelInfo(this.CurSelected);
			FColor changeColor = base.GetText(7).changeColor;
			base.SetTextureByPath(levelInfo.Value.Bg, base.GetTexture(0), null, null);
			if (levelInfo2.BossHp == 0)
			{
				UUIText text = base.GetText(7);
				if (text != null)
				{
					bool bUseChangeColor = true;
					FColor? fcolor = new FColor?(changeColor);
					text.SetChangeColor(bUseChangeColor, fcolor);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "BossPilingActivity_Main05", Array.Empty<object>());
				return;
			}
			UUIText text2 = base.GetText(7);
			if (text2 != null)
			{
				bool bUseChangeColor2 = false;
				FColor? fcolor = new FColor?(changeColor);
				text2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "BossPilingActivity_Main04", new <>z__ReadOnlySingleElementList<object>(levelInfo2.BossHp));
		}

		// Token: 0x06030842 RID: 198722 RVA: 0x00D84131 File Offset: 0x00D82331
		private BossPilingBossTabItem CreateBossItem()
		{
			return new BossPilingBossTabItem
			{
				IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
				OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
			};
		}

		// Token: 0x06030843 RID: 198723 RVA: 0x00D8415C File Offset: 0x00D8235C
		private bool GetToggleStateSelected(int level)
		{
			return this.CurSelected == level;
		}

		// Token: 0x06030844 RID: 198724 RVA: 0x00D84167 File Offset: 0x00D82367
		private void OnToggleStateChange(int id)
		{
			this.CurSelected = id;
			this.Layout.RefreshWithoutDataSync();
			this.RefreshPanel();
		}

		// Token: 0x06030845 RID: 198725 RVA: 0x00D84181 File Offset: 0x00D82381
		private void OnClickedConfirm()
		{
			UiManager.Instance.OpenView(EUiViewName.BossPilingLevelView, this.CurSelected, null);
		}

		// Token: 0x06030846 RID: 198726 RVA: 0x00D8419E File Offset: 0x00D8239E
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x06030847 RID: 198727 RVA: 0x00D841AB File Offset: 0x00D823AB
		private void OnClickedClose()
		{
			if (WorldMapModel.Instance.IsPlayerInBigWorldInstanceDungeon())
			{
				base.CloseMe(null);
				return;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
		}

		// Token: 0x04019AE2 RID: 105186
		private const int BOSS_PILING_HELP_ID = 551;

		// Token: 0x04019AE3 RID: 105187
		private BossPilingActivityData ActivityData;

		// Token: 0x04019AE4 RID: 105188
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019AE5 RID: 105189
		private ButtonItem RewardBtn;

		// Token: 0x04019AE6 RID: 105190
		private GenericLayout<BossPilingBossTabItem, BossPilingLevelInfo> Layout;

		// Token: 0x04019AE7 RID: 105191
		private int CurSelected;

		// Token: 0x04019AE8 RID: 105192
		private bool NeedTick = true;

		// Token: 0x04019AE9 RID: 105193
		private LevelSequencePlayer LevelSequence;

		// Token: 0x0200A7FA RID: 43002
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033E1E RID: 212510
			TexBossMain,
			// Token: 0x04033E1F RID: 212511
			CaptionItem,
			// Token: 0x04033E20 RID: 212512
			SvBossSelect,
			// Token: 0x04033E21 RID: 212513
			Content,
			// Token: 0x04033E22 RID: 212514
			BossItem,
			// Token: 0x04033E23 RID: 212515
			PanelReward,
			// Token: 0x04033E24 RID: 212516
			BtnConfirm,
			// Token: 0x04033E25 RID: 212517
			TxtDefeatNum
		}
	}
}
