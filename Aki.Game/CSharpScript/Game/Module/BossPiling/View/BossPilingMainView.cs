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
	// Token: 0x02005C11 RID: 23569
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingMainView : UiTickViewBase
	{
		// Token: 0x0603B8ED RID: 243949 RVA: 0x00E338C7 File Offset: 0x00E31AC7
		public BossPilingMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8EE RID: 243950 RVA: 0x00E338D8 File Offset: 0x00E31AD8
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

		// Token: 0x0603B8EF RID: 243951 RVA: 0x00E33A44 File Offset: 0x00E31C44
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B8F0 RID: 243952 RVA: 0x00E33A62 File Offset: 0x00E31C62
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603B8F1 RID: 243953 RVA: 0x00E33A80 File Offset: 0x00E31C80
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

		// Token: 0x0603B8F2 RID: 243954 RVA: 0x00E33BA4 File Offset: 0x00E31DA4
		protected override void OnBeforeShow()
		{
			this.RefreshRewardBtn();
			List<BossPilingLevelInfo> allLevelInfo = this.ActivityData.GetAllLevelInfo();
			this.Layout.RefreshByData(allLevelInfo, null, true);
			this.RefreshPanel();
		}

		// Token: 0x0603B8F3 RID: 243955 RVA: 0x00E33BD7 File Offset: 0x00E31DD7
		protected override void OnBeforeHide()
		{
			this.ActivityData.ClearLevelRedDot();
			this.RewardBtn.UnBindRedDot();
		}

		// Token: 0x0603B8F4 RID: 243956 RVA: 0x00E33BF0 File Offset: 0x00E31DF0
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

		// Token: 0x0603B8F5 RID: 243957 RVA: 0x00E33C6C File Offset: 0x00E31E6C
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

		// Token: 0x0603B8F6 RID: 243958 RVA: 0x00E33CDC File Offset: 0x00E31EDC
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

		// Token: 0x0603B8F7 RID: 243959 RVA: 0x00E33DE9 File Offset: 0x00E31FE9
		private BossPilingBossTabItem CreateBossItem()
		{
			return new BossPilingBossTabItem
			{
				IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
				OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
			};
		}

		// Token: 0x0603B8F8 RID: 243960 RVA: 0x00E33E14 File Offset: 0x00E32014
		private bool GetToggleStateSelected(int level)
		{
			return this.CurSelected == level;
		}

		// Token: 0x0603B8F9 RID: 243961 RVA: 0x00E33E1F File Offset: 0x00E3201F
		private void OnToggleStateChange(int id)
		{
			this.CurSelected = id;
			this.Layout.RefreshWithoutDataSync();
			this.RefreshPanel();
		}

		// Token: 0x0603B8FA RID: 243962 RVA: 0x00E33E39 File Offset: 0x00E32039
		private void OnClickedConfirm()
		{
			UiManager.Instance.OpenView(EUiViewName.BossPilingLevelView, this.CurSelected, null);
		}

		// Token: 0x0603B8FB RID: 243963 RVA: 0x00E33E56 File Offset: 0x00E32056
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			BossPilingModel.Instance.CloseActivityView(closeActivities);
		}

		// Token: 0x0603B8FC RID: 243964 RVA: 0x00E33E63 File Offset: 0x00E32063
		private void OnClickedClose()
		{
			if (WorldMapModel.Instance.IsPlayerInBigWorldInstanceDungeon())
			{
				base.CloseMe(null);
				return;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
		}

		// Token: 0x0401F031 RID: 127025
		private const int BOSS_PILING_HELP_ID = 551;

		// Token: 0x0401F032 RID: 127026
		private BossPilingActivityData ActivityData;

		// Token: 0x0401F033 RID: 127027
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401F034 RID: 127028
		private ButtonItem RewardBtn;

		// Token: 0x0401F035 RID: 127029
		private GenericLayout<BossPilingBossTabItem, BossPilingLevelInfo> Layout;

		// Token: 0x0401F036 RID: 127030
		private int CurSelected;

		// Token: 0x0401F037 RID: 127031
		private bool NeedTick = true;

		// Token: 0x0401F038 RID: 127032
		private LevelSequencePlayer LevelSequence;

		// Token: 0x0200BDF2 RID: 48626
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403945B RID: 234587
			TexBossMain,
			// Token: 0x0403945C RID: 234588
			CaptionItem,
			// Token: 0x0403945D RID: 234589
			SvBossSelect,
			// Token: 0x0403945E RID: 234590
			Content,
			// Token: 0x0403945F RID: 234591
			BossItem,
			// Token: 0x04039460 RID: 234592
			PanelReward,
			// Token: 0x04039461 RID: 234593
			BtnConfirm,
			// Token: 0x04039462 RID: 234594
			TxtDefeatNum
		}
	}
}
