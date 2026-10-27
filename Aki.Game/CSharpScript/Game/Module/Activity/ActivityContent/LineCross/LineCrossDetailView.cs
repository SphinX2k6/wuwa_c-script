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
	// Token: 0x02006560 RID: 25952
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossDetailView : UiViewBase
	{
		// Token: 0x06041085 RID: 266373 RVA: 0x00FC2DE5 File Offset: 0x00FC0FE5
		public LineCrossDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041086 RID: 266374 RVA: 0x00FC2DFC File Offset: 0x00FC0FFC
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

		// Token: 0x06041087 RID: 266375 RVA: 0x00FC3014 File Offset: 0x00FC1214
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

		// Token: 0x06041088 RID: 266376 RVA: 0x00FC3078 File Offset: 0x00FC1278
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041089 RID: 266377 RVA: 0x00FC30BB File Offset: 0x00FC12BB
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604108A RID: 266378 RVA: 0x00FC30C4 File Offset: 0x00FC12C4
		public void RefreshRewardLayout(List<TItem> list)
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0604108B RID: 266379 RVA: 0x00FC30D9 File Offset: 0x00FC12D9
		protected override void OnBeforeShow()
		{
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			if (lineCrossDetailViewModel == null)
			{
				return;
			}
			lineCrossDetailViewModel.OnShowView();
		}

		// Token: 0x0604108C RID: 266380 RVA: 0x00FC30EB File Offset: 0x00FC12EB
		public void ShowDescText(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), desc, Array.Empty<object>());
		}

		// Token: 0x0604108D RID: 266381 RVA: 0x00FC3104 File Offset: 0x00FC1304
		public void RefreshTitleText(string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), title, Array.Empty<object>());
		}

		// Token: 0x0604108E RID: 266382 RVA: 0x00FC311D File Offset: 0x00FC131D
		public void RefreshDifficultDescText(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), desc, Array.Empty<object>());
		}

		// Token: 0x0604108F RID: 266383 RVA: 0x00FC3137 File Offset: 0x00FC1337
		public void RefreshNumText(int num)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x06041090 RID: 266384 RVA: 0x00FC3154 File Offset: 0x00FC1354
		public void RefreshDifficultItem(List<int> dataList, int selectData)
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

		// Token: 0x06041091 RID: 266385 RVA: 0x00FC31B8 File Offset: 0x00FC13B8
		public void RefreshDifficultItemSelection(int data)
		{
			foreach (DifficultLineCrossItem difficultLineCrossItem in this.LineCrossItemList)
			{
				difficultLineCrossItem.RefreshToggle(data);
			}
		}

		// Token: 0x06041092 RID: 266386 RVA: 0x00FC320C File Offset: 0x00FC140C
		public void RefreshMiddleByChallengeState(bool ifHiddenGroup, ELineCrossGroupState state)
		{
			LineCrossClawItem lineCrossClawItem = this.LineCrossClawItem;
			if (lineCrossClawItem == null)
			{
				return;
			}
			lineCrossClawItem.Refresh(ifHiddenGroup, state);
		}

		// Token: 0x06041093 RID: 266387 RVA: 0x00FC3220 File Offset: 0x00FC1420
		public void PlaySwitchSequence()
		{
			base.PlaySequence("Switch", null, false);
		}

		// Token: 0x04021E6E RID: 138862
		private readonly List<DifficultLineCrossItem> LineCrossItemList = new List<DifficultLineCrossItem>();

		// Token: 0x04021E6F RID: 138863
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021E70 RID: 138864
		[Nullable(2)]
		private LineCrossDetailViewModel LineCrossDetailViewModel;

		// Token: 0x04021E71 RID: 138865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04021E72 RID: 138866
		[Nullable(2)]
		private LineCrossClawItem LineCrossClawItem;

		// Token: 0x0200C756 RID: 51030
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403C393 RID: 246675
			public const int CaptionItem = 0;

			// Token: 0x0403C394 RID: 246676
			public const int DifficultItem1 = 1;

			// Token: 0x0403C395 RID: 246677
			public const int DifficultItem2 = 2;

			// Token: 0x0403C396 RID: 246678
			public const int DifficultItem3 = 3;

			// Token: 0x0403C397 RID: 246679
			public const int NumText = 4;

			// Token: 0x0403C398 RID: 246680
			public const int TitleText = 5;

			// Token: 0x0403C399 RID: 246681
			public const int DescText = 6;

			// Token: 0x0403C39A RID: 246682
			public const int RewardLayout = 7;

			// Token: 0x0403C39B RID: 246683
			public const int RewardItem = 8;

			// Token: 0x0403C39C RID: 246684
			public const int Btn = 9;

			// Token: 0x0403C39D RID: 246685
			public const int ClawItem = 10;

			// Token: 0x0403C39E RID: 246686
			public const int DifficultDesc = 11;
		}
	}
}
