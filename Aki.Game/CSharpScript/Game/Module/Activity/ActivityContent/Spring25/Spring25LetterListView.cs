using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x020060A2 RID: 24738
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25LetterListView : UiViewBase
	{
		// Token: 0x0603E886 RID: 256134 RVA: 0x00F1D313 File Offset: 0x00F1B513
		public Spring25LetterListView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17009099 RID: 37017
		// (get) Token: 0x0603E887 RID: 256135 RVA: 0x00F1D31C File Offset: 0x00F1B51C
		// (set) Token: 0x0603E888 RID: 256136 RVA: 0x00F1D324 File Offset: 0x00F1B524
		private UiSequencePlayer Player { get; set; }

		// Token: 0x1700909A RID: 37018
		// (get) Token: 0x0603E889 RID: 256137 RVA: 0x00F1D32D File Offset: 0x00F1B52D
		// (set) Token: 0x0603E88A RID: 256138 RVA: 0x00F1D335 File Offset: 0x00F1B535
		private GenericLayout<TabItem, Spring25LetterListTabData> TabList { get; set; }

		// Token: 0x0603E88B RID: 256139 RVA: 0x00F1D340 File Offset: 0x00F1B540
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.HandleBackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603E88C RID: 256140 RVA: 0x00F1D46C File Offset: 0x00F1B66C
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25LetterListView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25LetterListView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E88D RID: 256141 RVA: 0x00F1D4AF File Offset: 0x00F1B6AF
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x0603E88E RID: 256142 RVA: 0x00F1D4B7 File Offset: 0x00F1B6B7
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit(EEventName.Spring25CloseLetterList);
		}

		// Token: 0x0603E88F RID: 256143 RVA: 0x00F1D4C9 File Offset: 0x00F1B6C9
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.Spring25SelectLetter, new Action<int>(this.HandleSpring25SelectLetter));
		}

		// Token: 0x0603E890 RID: 256144 RVA: 0x00F1D4E7 File Offset: 0x00F1B6E7
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25SelectLetter, new Action<int>(this.HandleSpring25SelectLetter));
		}

		// Token: 0x0603E891 RID: 256145 RVA: 0x00F1D508 File Offset: 0x00F1B708
		private void RefreshByOpenParam()
		{
			Spring25LetterListViewData spring25LetterListViewData = this.OpenParam as Spring25LetterListViewData;
			if (spring25LetterListViewData == null)
			{
				return;
			}
			this.TabList.RefreshByData(spring25LetterListViewData.TabDataList, null, false);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), spring25LetterListViewData.InfoTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), spring25LetterListViewData.TitleTextId, Array.Empty<object>());
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar != null)
			{
				FVector relativeLocation = scrollViewWithScrollbar.ContentUIItem.Get().RelativeLocation;
				FVector2D fvector2D = new FVector2D(ref relativeLocation);
				scrollViewWithScrollbar.ScrollToTop(ref fvector2D, base.GetText(1), false);
			}
		}

		// Token: 0x0603E892 RID: 256146 RVA: 0x00F1D5A8 File Offset: 0x00F1B7A8
		private void HandleBackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E893 RID: 256147 RVA: 0x00F1D5B1 File Offset: 0x00F1B7B1
		private void HandleSpring25SelectLetter(int i)
		{
			this.OpenParam = Spring25Model.Instance.BuildLetterListViewData();
			this.RefreshByOpenParam();
			this.Player.LiteReplayAsync("Switch", false, false);
		}

		// Token: 0x0603E894 RID: 256148 RVA: 0x00F1D5DC File Offset: 0x00F1B7DC
		private TabItem BuildItem()
		{
			return new TabItem();
		}

		// Token: 0x0200C2FF RID: 49919
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AE18 RID: 241176
			public const int BackButton = 0;

			// Token: 0x0403AE19 RID: 241177
			public const int InfoText = 1;

			// Token: 0x0403AE1A RID: 241178
			public const int ContentLayout = 2;

			// Token: 0x0403AE1B RID: 241179
			public const int ListTemplateItem = 3;

			// Token: 0x0403AE1C RID: 241180
			public const int TitleText = 4;

			// Token: 0x0403AE1D RID: 241181
			public const int LetterScroll = 5;
		}
	}
}
