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
	// Token: 0x0200642B RID: 25643
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightPauseView : UiViewBase
	{
		// Token: 0x06040799 RID: 264089 RVA: 0x00F9A73A File Offset: 0x00F9893A
		public MotorFightPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604079A RID: 264090 RVA: 0x00F9A750 File Offset: 0x00F98950
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnLeaveBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnSettleAndLeaveBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnReChallengeBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnContinueBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnDetailBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604079B RID: 264091 RVA: 0x00F9A96C File Offset: 0x00F98B6C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightPauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightPauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604079C RID: 264092 RVA: 0x00F9A9B0 File Offset: 0x00F98BB0
		private int SortItemList(MotorcycleArrowCollectionItemData a, MotorcycleArrowCollectionItemData b)
		{
			if (a.Config.Type != b.Config.Type)
			{
				Dictionary<int, int> dictionary = this.ItemNumMap[a.Config.Type];
				Dictionary<int, int> dictionary2 = this.ItemNumMap[b.Config.Type];
				if (dictionary.Count != dictionary2.Count)
				{
					return dictionary2.Count - dictionary.Count;
				}
				for (int i = 5; i >= 3; i--)
				{
					int num;
					if (!dictionary.TryGetValue(i, out num))
					{
						num = 0;
					}
					int num2;
					if (!dictionary2.TryGetValue(i, out num2))
					{
						num2 = 0;
					}
					if (num != num2)
					{
						return num2 - num;
					}
				}
				return a.Config.Type - b.Config.Type;
			}
			else
			{
				if (a.Config.Quality != b.Config.Quality)
				{
					return b.Config.Quality - a.Config.Quality;
				}
				return a.Id - b.Id;
			}
		}

		// Token: 0x0604079D RID: 264093 RVA: 0x00F9AAA8 File Offset: 0x00F98CA8
		private void OnItemClick(MotorcycleArrowCollectionItemData data)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleArrowCollectionTipsView, data, null);
		}

		// Token: 0x0604079E RID: 264094 RVA: 0x00F9AABB File Offset: 0x00F98CBB
		private CollectionGridItemPanel CreateItem()
		{
			return new CollectionGridItemPanel
			{
				OnClickCallBack = new Action<MotorcycleArrowCollectionItemData>(this.OnItemClick),
				NeedSelectedState = false
			};
		}

		// Token: 0x0604079F RID: 264095 RVA: 0x00F9AADB File Offset: 0x00F98CDB
		private MotorFightSummaryAttrItem CreateAttrItem()
		{
			return new MotorFightSummaryAttrItem();
		}

		// Token: 0x060407A0 RID: 264096 RVA: 0x00F9AAE2 File Offset: 0x00F98CE2
		private void OnLeaveBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x060407A1 RID: 264097 RVA: 0x00F9AAEE File Offset: 0x00F98CEE
		private void OnSettleAndLeaveBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(true, null);
			base.CloseMe(null);
		}

		// Token: 0x060407A2 RID: 264098 RVA: 0x00F9AB03 File Offset: 0x00F98D03
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(false, delegate
			{
				MotorFightController.Instance.ReChallengeMotorFightDungeon();
			});
		}

		// Token: 0x060407A3 RID: 264099 RVA: 0x00F9AB2F File Offset: 0x00F98D2F
		private void OnContinueBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060407A4 RID: 264100 RVA: 0x00F9AB38 File Offset: 0x00F98D38
		private void OnDetailBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightAttrDetailView, null, null);
		}

		// Token: 0x060407A5 RID: 264101 RVA: 0x00F9AB4B File Offset: 0x00F98D4B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402184F RID: 137295
		public Dictionary<int, Dictionary<int, int>> ItemNumMap = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x04021850 RID: 137296
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021851 RID: 137297
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CollectionGridItemPanel, MotorcycleArrowCollectionItemData> ItemScrollLayout;

		// Token: 0x04021852 RID: 137298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorFightSummaryAttrItem, EMotorFightAttrShowType> AttrLayout;

		// Token: 0x0200C664 RID: 50788
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BE4F RID: 245327
			public const int ItemCaption = 0;

			// Token: 0x0403BE50 RID: 245328
			public const int BtnLeave = 1;

			// Token: 0x0403BE51 RID: 245329
			public const int BtnSettleAndLeave = 2;

			// Token: 0x0403BE52 RID: 245330
			public const int BtnReChallenge = 3;

			// Token: 0x0403BE53 RID: 245331
			public const int BtnContinue = 4;

			// Token: 0x0403BE54 RID: 245332
			public const int ItemEmptyPanel = 5;

			// Token: 0x0403BE55 RID: 245333
			public const int ScrollLayoutItem = 6;

			// Token: 0x0403BE56 RID: 245334
			public const int ItemBase = 7;

			// Token: 0x0403BE57 RID: 245335
			public const int LayoutAttribute = 8;

			// Token: 0x0403BE58 RID: 245336
			public const int ItemAttribute = 9;

			// Token: 0x0403BE59 RID: 245337
			public const int BtnDetail = 10;
		}
	}
}
