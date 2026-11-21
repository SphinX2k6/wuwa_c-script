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
	// Token: 0x020053A9 RID: 21417
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightPauseView : UiViewBase
	{
		// Token: 0x0603545A RID: 218202 RVA: 0x00EE16DA File Offset: 0x00EDF8DA
		public MotorFightPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603545B RID: 218203 RVA: 0x00EE16F0 File Offset: 0x00EDF8F0
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

		// Token: 0x0603545C RID: 218204 RVA: 0x00EE190C File Offset: 0x00EDFB0C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightPauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightPauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603545D RID: 218205 RVA: 0x00EE1950 File Offset: 0x00EDFB50
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

		// Token: 0x0603545E RID: 218206 RVA: 0x00EE1A48 File Offset: 0x00EDFC48
		private void OnItemClick(MotorcycleArrowCollectionItemData data)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleArrowCollectionTipsView, data, null);
		}

		// Token: 0x0603545F RID: 218207 RVA: 0x00EE1A5B File Offset: 0x00EDFC5B
		private CollectionGridItemPanel CreateItem()
		{
			return new CollectionGridItemPanel
			{
				OnClickCallBack = new Action<MotorcycleArrowCollectionItemData>(this.OnItemClick),
				NeedSelectedState = false
			};
		}

		// Token: 0x06035460 RID: 218208 RVA: 0x00EE1A7B File Offset: 0x00EDFC7B
		private MotorFightSummaryAttrItem CreateAttrItem()
		{
			return new MotorFightSummaryAttrItem();
		}

		// Token: 0x06035461 RID: 218209 RVA: 0x00EE1A82 File Offset: 0x00EDFC82
		private void OnLeaveBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x06035462 RID: 218210 RVA: 0x00EE1A8E File Offset: 0x00EDFC8E
		private void OnSettleAndLeaveBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(true, null);
			base.CloseMe(null);
		}

		// Token: 0x06035463 RID: 218211 RVA: 0x00EE1AA3 File Offset: 0x00EDFCA3
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.RequestSettlement(false, delegate
			{
				MotorFightController.Instance.ReChallengeMotorFightDungeon();
			});
		}

		// Token: 0x06035464 RID: 218212 RVA: 0x00EE1ACF File Offset: 0x00EDFCCF
		private void OnContinueBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035465 RID: 218213 RVA: 0x00EE1AD8 File Offset: 0x00EDFCD8
		private void OnDetailBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightAttrDetailView, null, null);
		}

		// Token: 0x06035466 RID: 218214 RVA: 0x00EE1AEB File Offset: 0x00EDFCEB
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C17E RID: 115070
		public Dictionary<int, Dictionary<int, int>> ItemNumMap = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401C17F RID: 115071
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C180 RID: 115072
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CollectionGridItemPanel, MotorcycleArrowCollectionItemData> ItemScrollLayout;

		// Token: 0x0401C181 RID: 115073
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorFightSummaryAttrItem, EMotorFightAttrShowType> AttrLayout;

		// Token: 0x0200B04B RID: 45131
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040367AC RID: 223148
			public const int ItemCaption = 0;

			// Token: 0x040367AD RID: 223149
			public const int BtnLeave = 1;

			// Token: 0x040367AE RID: 223150
			public const int BtnSettleAndLeave = 2;

			// Token: 0x040367AF RID: 223151
			public const int BtnReChallenge = 3;

			// Token: 0x040367B0 RID: 223152
			public const int BtnContinue = 4;

			// Token: 0x040367B1 RID: 223153
			public const int ItemEmptyPanel = 5;

			// Token: 0x040367B2 RID: 223154
			public const int ScrollLayoutItem = 6;

			// Token: 0x040367B3 RID: 223155
			public const int ItemBase = 7;

			// Token: 0x040367B4 RID: 223156
			public const int LayoutAttribute = 8;

			// Token: 0x040367B5 RID: 223157
			public const int ItemAttribute = 9;

			// Token: 0x040367B6 RID: 223158
			public const int BtnDetail = 10;
		}
	}
}
