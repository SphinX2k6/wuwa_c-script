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
	// Token: 0x020053A8 RID: 21416
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightMainView : UiViewBase
	{
		// Token: 0x0603544F RID: 218191 RVA: 0x00EE12F1 File Offset: 0x00EDF4F1
		[NullableContext(1)]
		public MotorFightMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035450 RID: 218192 RVA: 0x00EE12FC File Offset: 0x00EDF4FC
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

		// Token: 0x06035451 RID: 218193 RVA: 0x00EE1470 File Offset: 0x00EDF670
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035452 RID: 218194 RVA: 0x00EE14B4 File Offset: 0x00EDF6B4
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

		// Token: 0x06035453 RID: 218195 RVA: 0x00EE160C File Offset: 0x00EDF80C
		[NullableContext(1)]
		private MotorFightLevelListPanel CreateLevelListPanel()
		{
			return new MotorFightLevelListPanel();
		}

		// Token: 0x06035454 RID: 218196 RVA: 0x00EE1613 File Offset: 0x00EDF813
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035455 RID: 218197 RVA: 0x00EE161C File Offset: 0x00EDF81C
		private void OnHandBookBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightHandBookView, this.MotorFightActivityData, null);
		}

		// Token: 0x06035456 RID: 218198 RVA: 0x00EE1634 File Offset: 0x00EDF834
		private void OnTalentBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightTalentTreeView, this.MotorFightActivityData, null);
		}

		// Token: 0x06035457 RID: 218199 RVA: 0x00EE164C File Offset: 0x00EDF84C
		private void OnRankBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRankView, this.MotorFightActivityData, null);
		}

		// Token: 0x06035458 RID: 218200 RVA: 0x00EE1664 File Offset: 0x00EDF864
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRewardView, this.MotorFightActivityData, null);
		}

		// Token: 0x06035459 RID: 218201 RVA: 0x00EE167C File Offset: 0x00EDF87C
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

		// Token: 0x0401C177 RID: 115063
		private MotorFightActivityData MotorFightActivityData;

		// Token: 0x0401C178 RID: 115064
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public GenericScrollViewNew<MotorFightLevelListPanel, List<MotorFightLevelData>> ScrollView;

		// Token: 0x0401C179 RID: 115065
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C17A RID: 115066
		private ButtonItem HandBookBtn;

		// Token: 0x0401C17B RID: 115067
		private ButtonItem TalentTreeBtn;

		// Token: 0x0401C17C RID: 115068
		private ButtonItem RankBtn;

		// Token: 0x0401C17D RID: 115069
		private ButtonItem RewardBtn;

		// Token: 0x0200B047 RID: 45127
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036798 RID: 223128
			public const int ItemCaption = 0;

			// Token: 0x04036799 RID: 223129
			public const int LevelScroll = 1;

			// Token: 0x0403679A RID: 223130
			public const int ItemLevelList = 2;

			// Token: 0x0403679B RID: 223131
			public const int ItemHandBookBtn = 3;

			// Token: 0x0403679C RID: 223132
			public const int ItemTalentTreeBtn = 4;

			// Token: 0x0403679D RID: 223133
			public const int ItemRewardBtn = 5;

			// Token: 0x0403679E RID: 223134
			public const int ItemRankBtn = 6;

			// Token: 0x0403679F RID: 223135
			public const int BtnArchive = 7;

			// Token: 0x040367A0 RID: 223136
			public const int ItemArchive = 8;

			// Token: 0x040367A1 RID: 223137
			public const int ItemArchived = 9;
		}
	}
}
