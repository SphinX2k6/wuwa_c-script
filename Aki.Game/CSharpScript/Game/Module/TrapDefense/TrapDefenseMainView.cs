using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A8F RID: 14991
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainView : UiTickViewBase
	{
		// Token: 0x06026856 RID: 157782 RVA: 0x00ACBE9E File Offset: 0x00ACA09E
		public TrapDefenseMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026857 RID: 157783 RVA: 0x00ACBEA8 File Offset: 0x00ACA0A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnKeySettingClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026858 RID: 157784 RVA: 0x00ACC058 File Offset: 0x00ACA258
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026859 RID: 157785 RVA: 0x00ACC09B File Offset: 0x00ACA29B
		protected override void OnBeforeShow()
		{
			SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
			this.RefreshView();
		}

		// Token: 0x0602685A RID: 157786 RVA: 0x00ACC0B0 File Offset: 0x00ACA2B0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseLevelDataListUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0602685B RID: 157787 RVA: 0x00ACC114 File Offset: 0x00ACA314
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseLevelDataListUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0602685C RID: 157788 RVA: 0x00ACC178 File Offset: 0x00ACA378
		protected override void OnBeforeDestroy()
		{
			TrapDefenseEntrySideBtnItem btnFixedReward = this.BtnFixedReward;
			if (btnFixedReward != null)
			{
				btnFixedReward.UnBindRedDot();
			}
			TrapDefenseEntrySideBtnItem btnLimitReward = this.BtnLimitReward;
			if (btnLimitReward != null)
			{
				btnLimitReward.UnBindRedDot();
			}
			TrapDefenseEntrySideBtnItem btnTalentTree = this.BtnTalentTree;
			if (btnTalentTree != null)
			{
				btnTalentTree.UnBindRedDot();
			}
			TrapDefenseEntrySideBtnItem btnWorkshop = this.BtnWorkshop;
			if (btnWorkshop == null)
			{
				return;
			}
			btnWorkshop.UnBindRedDot();
		}

		// Token: 0x0602685D RID: 157789 RVA: 0x00ACC1C8 File Offset: 0x00ACA3C8
		protected override void OnTick(float deltaTime)
		{
			TrapDefenseEntryBtnItem btnRogueMode = this.BtnRogueMode;
			if (btnRogueMode != null)
			{
				btnRogueMode.RefreshUnlockTimer();
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(TrapDefenseModel.Instance.RewardData.GetLimitRewardRemainTimeStr(), true);
			}
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(TrapDefenseModel.Instance.RewardData.IsOpenLimitReward());
		}

		// Token: 0x0602685E RID: 157790 RVA: 0x00ACC22C File Offset: 0x00ACA42C
		private void RefreshView()
		{
			ValueTuple<int, int> limitRewardTotalProgress = TrapDefenseModel.Instance.RewardData.GetLimitRewardTotalProgress();
			int item = limitRewardTotalProgress.Item1;
			int item2 = limitRewardTotalProgress.Item2;
			TrapDefenseEntrySideBtnItem btnLimitReward = this.BtnLimitReward;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			btnLimitReward.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
			this.BtnLimitReward.SetUiActive(TrapDefenseModel.Instance.RewardData.IsOpenLimitReward());
			ValueTuple<int, int> fixedRewardTotalProgress = TrapDefenseModel.Instance.RewardData.GetFixedRewardTotalProgress();
			int item3 = fixedRewardTotalProgress.Item1;
			int item4 = fixedRewardTotalProgress.Item2;
			TrapDefenseEntrySideBtnItem btnFixedReward = this.BtnFixedReward;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item3);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item4);
			btnFixedReward.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
			this.BtnMainMode.RefreshByMode();
			this.BtnRogueMode.RefreshByMode();
		}

		// Token: 0x0602685F RID: 157791 RVA: 0x00ACC30F File Offset: 0x00ACA50F
		private void OnKeySettingClick()
		{
			TrapDefenseModel.Instance.OpenViewKeySetting();
		}

		// Token: 0x06026860 RID: 157792 RVA: 0x00ACC31B File Offset: 0x00ACA51B
		private void OnLimitRewardClick()
		{
			TrapDefenseModel.Instance.OpenViewLimitReward();
		}

		// Token: 0x06026861 RID: 157793 RVA: 0x00ACC327 File Offset: 0x00ACA527
		private void OnFixedRewardClick()
		{
			TrapDefenseModel.Instance.OpenViewFixedReward();
		}

		// Token: 0x06026862 RID: 157794 RVA: 0x00ACC333 File Offset: 0x00ACA533
		private void OnTalentTreeClick()
		{
			TrapDefenseModel.Instance.OpenViewTalentTree(null);
		}

		// Token: 0x06026863 RID: 157795 RVA: 0x00ACC340 File Offset: 0x00ACA540
		private void OnWorkshopClick()
		{
			TrapDefenseController.Instance.OpenOrganDevelop(false, this, 0, null);
		}

		// Token: 0x06026864 RID: 157796 RVA: 0x00ACC350 File Offset: 0x00ACA550
		private void OnDataUpdate()
		{
			this.RefreshView();
		}

		// Token: 0x040151BE RID: 86462
		private PopupCaptionItem Caption;

		// Token: 0x040151BF RID: 86463
		private TrapDefenseEntryBtnItem BtnMainMode;

		// Token: 0x040151C0 RID: 86464
		private TrapDefenseEntryBtnItem BtnRogueMode;

		// Token: 0x040151C1 RID: 86465
		private TrapDefenseEntrySideBtnItem BtnLimitReward;

		// Token: 0x040151C2 RID: 86466
		private TrapDefenseEntrySideBtnItem BtnFixedReward;

		// Token: 0x040151C3 RID: 86467
		private TrapDefenseEntrySideBtnItem BtnTalentTree;

		// Token: 0x040151C4 RID: 86468
		private TrapDefenseEntrySideBtnItem BtnWorkshop;

		// Token: 0x0200969A RID: 38554
		[NullableContext(0)]
		internal class EChildType
		{
			// Token: 0x0402F059 RID: 192601
			public const int ItemCaption = 0;

			// Token: 0x0402F05A RID: 192602
			public const int BtnKeySetting = 1;

			// Token: 0x0402F05B RID: 192603
			public const int ItemBtnModeLeft = 2;

			// Token: 0x0402F05C RID: 192604
			public const int ItemBtnModeRight = 3;

			// Token: 0x0402F05D RID: 192605
			public const int TextTime = 4;

			// Token: 0x0402F05E RID: 192606
			public const int ItemBtnLimitReward = 5;

			// Token: 0x0402F05F RID: 192607
			public const int ItemBtnFixedReward = 6;

			// Token: 0x0402F060 RID: 192608
			public const int ItemBtnTalentTree = 7;

			// Token: 0x0402F061 RID: 192609
			public const int ItemBtnWorkshop = 8;

			// Token: 0x0402F062 RID: 192610
			public const int ItemCountDown = 9;
		}
	}
}
