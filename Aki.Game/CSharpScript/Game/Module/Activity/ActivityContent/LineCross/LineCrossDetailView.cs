using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054DE RID: 21726
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossDetailView : UiViewBase
	{
		// Token: 0x06035D4A RID: 220490 RVA: 0x00F09DCD File Offset: 0x00F07FCD
		public LineCrossDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035D4B RID: 220491 RVA: 0x00F09DE4 File Offset: 0x00F07FE4
		protected unsafe override void OnRegisterComponent()
		{
			this.LineCrossDetailViewModel = (this.OpenParam as LineCrossDetailViewModel);
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			if (lineCrossDetailViewModel != null)
			{
				lineCrossDetailViewModel.RegisterView(this);
			}
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035D4C RID: 220492 RVA: 0x00F09FFC File Offset: 0x00F081FC
		private void OnClickBtn()
		{
			LineCrossActivityController instance = LineCrossActivityController.Instance;
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			int? num;
			if (lineCrossDetailViewModel == null)
			{
				num = null;
			}
			else
			{
				LineCrossActivityData lineCrossActivityData = lineCrossDetailViewModel.LineCrossActivityData;
				num = ((lineCrossActivityData != null) ? new int?(lineCrossActivityData.Id) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			LineCrossDetailViewModel lineCrossDetailViewModel2 = this.LineCrossDetailViewModel;
			instance.RequestStartChallenge(valueOrDefault, (lineCrossDetailViewModel2 != null) ? lineCrossDetailViewModel2.GetCurrentChallengeId() : 0);
		}

		// Token: 0x06035D4D RID: 220493 RVA: 0x00F0A060 File Offset: 0x00F08260
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D4E RID: 220494 RVA: 0x00F0A0A3 File Offset: 0x00F082A3
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035D4F RID: 220495 RVA: 0x00F0A0AC File Offset: 0x00F082AC
		public void RefreshRewardLayout(List<TItem> list)
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06035D50 RID: 220496 RVA: 0x00F0A0C1 File Offset: 0x00F082C1
		protected override void OnBeforeShow()
		{
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			if (lineCrossDetailViewModel == null)
			{
				return;
			}
			lineCrossDetailViewModel.OnShowView();
		}

		// Token: 0x06035D51 RID: 220497 RVA: 0x00F0A0D3 File Offset: 0x00F082D3
		public void ShowDescText(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), desc, Array.Empty<object>());
		}

		// Token: 0x06035D52 RID: 220498 RVA: 0x00F0A0EC File Offset: 0x00F082EC
		public void RefreshTitleText(string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), title, Array.Empty<object>());
		}

		// Token: 0x06035D53 RID: 220499 RVA: 0x00F0A105 File Offset: 0x00F08305
		public void RefreshDifficultDescText(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), desc, Array.Empty<object>());
		}

		// Token: 0x06035D54 RID: 220500 RVA: 0x00F0A11F File Offset: 0x00F0831F
		public void RefreshNumText(int num)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x06035D55 RID: 220501 RVA: 0x00F0A13C File Offset: 0x00F0833C
		public void RefreshDifficultItem(IReadOnlyList<int> dataList, int selectData)
		{
			for (int i = 0; i < this.LineCrossItemList.Count; i++)
			{
				DifficultLineCrossItem difficultLineCrossItem = this.LineCrossItemList[i];
				if (i < dataList.Count)
				{
					difficultLineCrossItem.SetModel(this.LineCrossDetailViewModel);
					difficultLineCrossItem.Refresh(dataList[i], selectData);
					difficultLineCrossItem.Show(null);
				}
				else
				{
					difficultLineCrossItem.Hide(null);
				}
			}
		}

		// Token: 0x06035D56 RID: 220502 RVA: 0x00F0A1A0 File Offset: 0x00F083A0
		public void RefreshDifficultItemSelection(int data)
		{
			foreach (DifficultLineCrossItem difficultLineCrossItem in this.LineCrossItemList)
			{
				difficultLineCrossItem.RefreshToggle(data);
			}
		}

		// Token: 0x06035D57 RID: 220503 RVA: 0x00F0A1F4 File Offset: 0x00F083F4
		public void RefreshMiddleByChallengeState(bool ifHiddenGroup, ELineCrossGroupState state)
		{
			LineCrossClawItem lineCrossClawItem = this.LineCrossClawItem;
			if (lineCrossClawItem == null)
			{
				return;
			}
			lineCrossClawItem.Refresh(ifHiddenGroup, state);
		}

		// Token: 0x06035D58 RID: 220504 RVA: 0x00F0A208 File Offset: 0x00F08408
		public void PlaySwitchSequence()
		{
			base.PlaySequence("Switch", null, false);
		}

		// Token: 0x0401C79F RID: 116639
		private readonly List<DifficultLineCrossItem> LineCrossItemList = new List<DifficultLineCrossItem>();

		// Token: 0x0401C7A0 RID: 116640
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C7A1 RID: 116641
		[Nullable(2)]
		private LineCrossDetailViewModel LineCrossDetailViewModel;

		// Token: 0x0401C7A2 RID: 116642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401C7A3 RID: 116643
		[Nullable(2)]
		private LineCrossClawItem LineCrossClawItem;

		// Token: 0x0200B13B RID: 45371
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036CE5 RID: 224485
			public const int CaptionItem = 0;

			// Token: 0x04036CE6 RID: 224486
			public const int DifficultItem1 = 1;

			// Token: 0x04036CE7 RID: 224487
			public const int DifficultItem2 = 2;

			// Token: 0x04036CE8 RID: 224488
			public const int DifficultItem3 = 3;

			// Token: 0x04036CE9 RID: 224489
			public const int NumText = 4;

			// Token: 0x04036CEA RID: 224490
			public const int TitleText = 5;

			// Token: 0x04036CEB RID: 224491
			public const int DescText = 6;

			// Token: 0x04036CEC RID: 224492
			public const int RewardLayout = 7;

			// Token: 0x04036CED RID: 224493
			public const int RewardItem = 8;

			// Token: 0x04036CEE RID: 224494
			public const int Btn = 9;

			// Token: 0x04036CEF RID: 224495
			public const int ClawItem = 10;

			// Token: 0x04036CF0 RID: 224496
			public const int DifficultDesc = 11;
		}
	}
}
