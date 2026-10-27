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
	// Token: 0x02004AE7 RID: 19175
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainView : UiTickViewBase
	{
		// Token: 0x06031AC6 RID: 203462 RVA: 0x00B87EEA File Offset: 0x00B860EA
		public TrapDefenseMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031AC7 RID: 203463 RVA: 0x00B87EF4 File Offset: 0x00B860F4
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

		// Token: 0x06031AC8 RID: 203464 RVA: 0x00B880A4 File Offset: 0x00B862A4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031AC9 RID: 203465 RVA: 0x00B880E7 File Offset: 0x00B862E7
		protected override void OnBeforeShow()
		{
			SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
			this.RefreshView();
		}

		// Token: 0x06031ACA RID: 203466 RVA: 0x00B880FC File Offset: 0x00B862FC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseLevelDataListUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06031ACB RID: 203467 RVA: 0x00B88160 File Offset: 0x00B86360
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseLevelDataListUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.TrapDefenseActivityDataUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06031ACC RID: 203468 RVA: 0x00B881C4 File Offset: 0x00B863C4
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

		// Token: 0x06031ACD RID: 203469 RVA: 0x00B88214 File Offset: 0x00B86414
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

		// Token: 0x06031ACE RID: 203470 RVA: 0x00B88278 File Offset: 0x00B86478
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

		// Token: 0x06031ACF RID: 203471 RVA: 0x00B8835B File Offset: 0x00B8655B
		private void OnKeySettingClick()
		{
			TrapDefenseModel.Instance.OpenViewKeySetting();
		}

		// Token: 0x06031AD0 RID: 203472 RVA: 0x00B88367 File Offset: 0x00B86567
		private void OnLimitRewardClick()
		{
			TrapDefenseModel.Instance.OpenViewLimitReward();
		}

		// Token: 0x06031AD1 RID: 203473 RVA: 0x00B88373 File Offset: 0x00B86573
		private void OnFixedRewardClick()
		{
			TrapDefenseModel.Instance.OpenViewFixedReward();
		}

		// Token: 0x06031AD2 RID: 203474 RVA: 0x00B8837F File Offset: 0x00B8657F
		private void OnTalentTreeClick()
		{
			TrapDefenseModel.Instance.OpenViewTalentTree(null);
		}

		// Token: 0x06031AD3 RID: 203475 RVA: 0x00B8838C File Offset: 0x00B8658C
		private void OnWorkshopClick()
		{
			TrapDefenseController.Instance.OpenOrganDevelop(false, this, 0, null);
		}

		// Token: 0x06031AD4 RID: 203476 RVA: 0x00B8839C File Offset: 0x00B8659C
		private void OnDataUpdate()
		{
			this.RefreshView();
		}

		// Token: 0x0401A86C RID: 108652
		private PopupCaptionItem Caption;

		// Token: 0x0401A86D RID: 108653
		private TrapDefenseEntryBtnItem BtnMainMode;

		// Token: 0x0401A86E RID: 108654
		private TrapDefenseEntryBtnItem BtnRogueMode;

		// Token: 0x0401A86F RID: 108655
		private TrapDefenseEntrySideBtnItem BtnLimitReward;

		// Token: 0x0401A870 RID: 108656
		private TrapDefenseEntrySideBtnItem BtnFixedReward;

		// Token: 0x0401A871 RID: 108657
		private TrapDefenseEntrySideBtnItem BtnTalentTree;

		// Token: 0x0401A872 RID: 108658
		private TrapDefenseEntrySideBtnItem BtnWorkshop;

		// Token: 0x0200AC7A RID: 44154
		[NullableContext(0)]
		internal class EChildType
		{
			// Token: 0x040346A8 RID: 214696
			public const int ItemCaption = 0;

			// Token: 0x040346A9 RID: 214697
			public const int BtnKeySetting = 1;

			// Token: 0x040346AA RID: 214698
			public const int ItemBtnModeLeft = 2;

			// Token: 0x040346AB RID: 214699
			public const int ItemBtnModeRight = 3;

			// Token: 0x040346AC RID: 214700
			public const int TextTime = 4;

			// Token: 0x040346AD RID: 214701
			public const int ItemBtnLimitReward = 5;

			// Token: 0x040346AE RID: 214702
			public const int ItemBtnFixedReward = 6;

			// Token: 0x040346AF RID: 214703
			public const int ItemBtnTalentTree = 7;

			// Token: 0x040346B0 RID: 214704
			public const int ItemBtnWorkshop = 8;

			// Token: 0x040346B1 RID: 214705
			public const int ItemCountDown = 9;
		}
	}
}
