using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200642A RID: 25642
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightMainView : UiViewBase
	{
		// Token: 0x0604078E RID: 264078 RVA: 0x00F9A351 File Offset: 0x00F98551
		[NullableContext(1)]
		public MotorFightMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604078F RID: 264079 RVA: 0x00F9A35C File Offset: 0x00F9855C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040790 RID: 264080 RVA: 0x00F9A4D0 File Offset: 0x00F986D0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040791 RID: 264081 RVA: 0x00F9A514 File Offset: 0x00F98714
		protected override void OnBeforeShow()
		{
			List<List<MotorFightLevelData>> levelTreeList = this.MotorFightActivityData.GetLevelTreeList();
			GenericScrollViewNew<MotorFightLevelListPanel, List<MotorFightLevelData>> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(levelTreeList, null, false);
			}
			ButtonItem handBookBtn = this.HandBookBtn;
			if (handBookBtn != null)
			{
				handBookBtn.SetRedDotVisible(this.MotorFightActivityData.IsHandBookHasRedDot());
			}
			ButtonItem talentTreeBtn = this.TalentTreeBtn;
			if (talentTreeBtn != null)
			{
				talentTreeBtn.SetRedDotVisible(this.MotorFightActivityData.IsTalentTreeHasRedDot());
			}
			ButtonItem rewardBtn = this.RewardBtn;
			if (rewardBtn != null)
			{
				rewardBtn.SetRedDotVisible(this.MotorFightActivityData.IsTaskHasRedDot());
			}
			ButtonItem rewardBtn2 = this.RewardBtn;
			if (rewardBtn2 != null)
			{
				rewardBtn2.SetLocalTextNew("PrefabTextItem_391372407_Text", new object[]
				{
					this.MotorFightActivityData.GetFinishedTaskNum(),
					this.MotorFightActivityData.GetTotalTaskNum()
				});
			}
			ButtonItem rankBtn = this.RankBtn;
			if (rankBtn != null)
			{
				rankBtn.SetUiActive(this.MotorFightActivityData.IsEndlessLevelUnlock());
			}
			ButtonItem rankBtn2 = this.RankBtn;
			if (rankBtn2 != null)
			{
				rankBtn2.SetRedDotVisible(false);
			}
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.MotorFightActivityData.HasLastSavedLevelData());
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!this.MotorFightActivityData.HasLastSavedLevelData());
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.MotorFightActivityData.HasLastSavedLevelData());
		}

		// Token: 0x06040792 RID: 264082 RVA: 0x00F9A66C File Offset: 0x00F9886C
		[NullableContext(1)]
		private MotorFightLevelListPanel CreateLevelListPanel()
		{
			return new MotorFightLevelListPanel();
		}

		// Token: 0x06040793 RID: 264083 RVA: 0x00F9A673 File Offset: 0x00F98873
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040794 RID: 264084 RVA: 0x00F9A67C File Offset: 0x00F9887C
		private void OnHandBookBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightHandBookView, this.MotorFightActivityData, null);
		}

		// Token: 0x06040795 RID: 264085 RVA: 0x00F9A694 File Offset: 0x00F98894
		private void OnTalentBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightTalentTreeView, this.MotorFightActivityData, null);
		}

		// Token: 0x06040796 RID: 264086 RVA: 0x00F9A6AC File Offset: 0x00F988AC
		private void OnRankBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRankView, this.MotorFightActivityData, null);
		}

		// Token: 0x06040797 RID: 264087 RVA: 0x00F9A6C4 File Offset: 0x00F988C4
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRewardView, this.MotorFightActivityData, null);
		}

		// Token: 0x06040798 RID: 264088 RVA: 0x00F9A6DC File Offset: 0x00F988DC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (!(configParams[0] == "sword_first"))
			{
				return null;
			}
			GenericScrollViewNew<MotorFightLevelListPanel, List<MotorFightLevelData>> scrollView = this.ScrollView;
			object obj;
			if (scrollView == null)
			{
				obj = null;
			}
			else
			{
				GenericLayout<MotorFightLevelListPanel, List<MotorFightLevelData>> genericLayout = scrollView.GetGenericLayout();
				obj = ((genericLayout != null) ? genericLayout.GetLayoutItemByIndex(0) : null);
			}
			object obj2 = obj;
			UUIItem uuiitem = (obj2 != null) ? obj2.GuideGetLevelItem(0) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04021848 RID: 137288
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x04021849 RID: 137289
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public GenericScrollViewNew<MotorFightLevelListPanel, List<MotorFightLevelData>> ScrollView;

		// Token: 0x0402184A RID: 137290
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402184B RID: 137291
		private ButtonItem HandBookBtn;

		// Token: 0x0402184C RID: 137292
		private ButtonItem TalentTreeBtn;

		// Token: 0x0402184D RID: 137293
		private ButtonItem RankBtn;

		// Token: 0x0402184E RID: 137294
		private ButtonItem RewardBtn;

		// Token: 0x0200C660 RID: 50784
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BE3B RID: 245307
			public const int ItemCaption = 0;

			// Token: 0x0403BE3C RID: 245308
			public const int LevelScroll = 1;

			// Token: 0x0403BE3D RID: 245309
			public const int ItemLevelList = 2;

			// Token: 0x0403BE3E RID: 245310
			public const int ItemHandBookBtn = 3;

			// Token: 0x0403BE3F RID: 245311
			public const int ItemTalentTreeBtn = 4;

			// Token: 0x0403BE40 RID: 245312
			public const int ItemRewardBtn = 5;

			// Token: 0x0403BE41 RID: 245313
			public const int ItemRankBtn = 6;

			// Token: 0x0403BE42 RID: 245314
			public const int BtnArchive = 7;

			// Token: 0x0403BE43 RID: 245315
			public const int ItemArchive = 8;

			// Token: 0x0403BE44 RID: 245316
			public const int ItemArchived = 9;
		}
	}
}
