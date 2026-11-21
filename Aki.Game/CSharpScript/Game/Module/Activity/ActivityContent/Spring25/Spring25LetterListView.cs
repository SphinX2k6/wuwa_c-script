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
	// Token: 0x02005020 RID: 20512
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25LetterListView : UiViewBase
	{
		// Token: 0x0603354A RID: 210250 RVA: 0x00E640D7 File Offset: 0x00E622D7
		public Spring25LetterListView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170063FB RID: 25595
		// (get) Token: 0x0603354B RID: 210251 RVA: 0x00E640E0 File Offset: 0x00E622E0
		// (set) Token: 0x0603354C RID: 210252 RVA: 0x00E640E8 File Offset: 0x00E622E8
		private UiSequencePlayer Player { get; set; }

		// Token: 0x170063FC RID: 25596
		// (get) Token: 0x0603354D RID: 210253 RVA: 0x00E640F1 File Offset: 0x00E622F1
		// (set) Token: 0x0603354E RID: 210254 RVA: 0x00E640F9 File Offset: 0x00E622F9
		private GenericLayout<TabItem, Spring25LetterListTabData> TabList { get; set; }

		// Token: 0x0603354F RID: 210255 RVA: 0x00E64104 File Offset: 0x00E62304
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

		// Token: 0x06033550 RID: 210256 RVA: 0x00E64230 File Offset: 0x00E62430
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25LetterListView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25LetterListView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033551 RID: 210257 RVA: 0x00E64273 File Offset: 0x00E62473
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x06033552 RID: 210258 RVA: 0x00E6427B File Offset: 0x00E6247B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit(EEventName.Spring25CloseLetterList);
		}

		// Token: 0x06033553 RID: 210259 RVA: 0x00E6428D File Offset: 0x00E6248D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.Spring25SelectLetter, new Action<int>(this.HandleSpring25SelectLetter));
		}

		// Token: 0x06033554 RID: 210260 RVA: 0x00E642AB File Offset: 0x00E624AB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25SelectLetter, new Action<int>(this.HandleSpring25SelectLetter));
		}

		// Token: 0x06033555 RID: 210261 RVA: 0x00E642CC File Offset: 0x00E624CC
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

		// Token: 0x06033556 RID: 210262 RVA: 0x00E6436C File Offset: 0x00E6256C
		private void HandleBackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033557 RID: 210263 RVA: 0x00E64375 File Offset: 0x00E62575
		private void HandleSpring25SelectLetter(int i)
		{
			this.OpenParam = Spring25Model.Instance.BuildLetterListViewData();
			this.RefreshByOpenParam();
			this.Player.LiteReplayAsync("Switch", false, false);
		}

		// Token: 0x06033558 RID: 210264 RVA: 0x00E643A0 File Offset: 0x00E625A0
		private TabItem BuildItem()
		{
			return new TabItem();
		}

		// Token: 0x0200ACEA RID: 44266
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035780 RID: 219008
			public const int BackButton = 0;

			// Token: 0x04035781 RID: 219009
			public const int InfoText = 1;

			// Token: 0x04035782 RID: 219010
			public const int ContentLayout = 2;

			// Token: 0x04035783 RID: 219011
			public const int ListTemplateItem = 3;

			// Token: 0x04035784 RID: 219012
			public const int TitleText = 4;

			// Token: 0x04035785 RID: 219013
			public const int LetterScroll = 5;
		}
	}
}
