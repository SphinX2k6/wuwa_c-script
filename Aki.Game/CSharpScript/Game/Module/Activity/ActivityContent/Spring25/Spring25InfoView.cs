using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200501D RID: 20509
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25InfoView : UiViewBase
	{
		// Token: 0x0603351B RID: 210203 RVA: 0x00E6374B File Offset: 0x00E6194B
		public Spring25InfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170063F2 RID: 25586
		// (get) Token: 0x0603351C RID: 210204 RVA: 0x00E63754 File Offset: 0x00E61954
		// (set) Token: 0x0603351D RID: 210205 RVA: 0x00E6375C File Offset: 0x00E6195C
		private PopupCaptionItem CaptionItem { get; set; }

		// Token: 0x170063F3 RID: 25587
		// (get) Token: 0x0603351E RID: 210206 RVA: 0x00E63765 File Offset: 0x00E61965
		// (set) Token: 0x0603351F RID: 210207 RVA: 0x00E6376D File Offset: 0x00E6196D
		private GenericLayout<ContentItem, Spring25InfoContentData> ContentLayout { get; set; }

		// Token: 0x170063F4 RID: 25588
		// (get) Token: 0x06033520 RID: 210208 RVA: 0x00E63776 File Offset: 0x00E61976
		// (set) Token: 0x06033521 RID: 210209 RVA: 0x00E6377E File Offset: 0x00E6197E
		private GenericLayout<ProgressItem, Spring25InfoProgressData> ProgressLayout { get; set; }

		// Token: 0x170063F5 RID: 25589
		// (get) Token: 0x06033522 RID: 210210 RVA: 0x00E63787 File Offset: 0x00E61987
		// (set) Token: 0x06033523 RID: 210211 RVA: 0x00E6378F File Offset: 0x00E6198F
		private UiSequencePlayer BottomPlayer { get; set; }

		// Token: 0x170063F6 RID: 25590
		// (get) Token: 0x06033524 RID: 210212 RVA: 0x00E63798 File Offset: 0x00E61998
		// (set) Token: 0x06033525 RID: 210213 RVA: 0x00E637A0 File Offset: 0x00E619A0
		private UUIInturnAnimController ContentPlayer { get; set; }

		// Token: 0x06033526 RID: 210214 RVA: 0x00E637AC File Offset: 0x00E619AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.HandleLookClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.HandleBonusClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033527 RID: 210215 RVA: 0x00E639E8 File Offset: 0x00E61BE8
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25InfoView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25InfoView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033528 RID: 210216 RVA: 0x00E63A2B File Offset: 0x00E61C2B
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x06033529 RID: 210217 RVA: 0x00E63A33 File Offset: 0x00E61C33
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(this.HandleSpring25DrawRewardDone));
			EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(this.HandleSpring25SkinRewardDone));
		}

		// Token: 0x0603352A RID: 210218 RVA: 0x00E63A6D File Offset: 0x00E61C6D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(this.HandleSpring25DrawRewardDone));
			EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(this.HandleSpring25SkinRewardDone));
		}

		// Token: 0x0603352B RID: 210219 RVA: 0x00E63AA8 File Offset: 0x00E61CA8
		private void RefreshByOpenParam()
		{
			Spring25InfoViewData spring25InfoViewData = this.OpenParam as Spring25InfoViewData;
			if (spring25InfoViewData == null)
			{
				return;
			}
			this.CaptionItem.SetTitleByTextIdAndArgNew(spring25InfoViewData.TitleTextId, Array.Empty<object>());
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(spring25InfoViewData.CurrentNum, true);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), spring25InfoViewData.TotalNumTextId, new <>z__ReadOnlySingleElementList<object>(spring25InfoViewData.TotalNumTextArg));
			this.RefreshContentAsync(spring25InfoViewData.ContentList);
			this.RefreshProgressAsync(spring25InfoViewData.ProgressList);
			this.RefreshBottomByState(spring25InfoViewData.BottomState);
		}

		// Token: 0x0603352C RID: 210220 RVA: 0x00E63B3C File Offset: 0x00E61D3C
		private void RefreshBottomByState(ESpring25InfoBottomState state)
		{
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(state == ESpring25InfoBottomState.QuestAllDoneFirstTime || state == ESpring25InfoBottomState.QuestAllDoneButNotFirst);
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(state <= ESpring25InfoBottomState.QuestAllDoneFirstTime);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(state <= ESpring25InfoBottomState.QuestAllDoneFirstTime);
			}
			if (state == ESpring25InfoBottomState.QuestAllDoneFirstTime)
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.Spring25FirstTimeTaskAllDone, false);
				this.BottomPlayer.LitePlayAsync("Switch", false, false);
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(state == ESpring25InfoBottomState.SkinRewarded);
		}

		// Token: 0x0603352D RID: 210221 RVA: 0x00E63BDC File Offset: 0x00E61DDC
		private UniTask RefreshContentAsync(List<Spring25InfoContentData> dataList)
		{
			Spring25InfoView.<RefreshContentAsync>d__29 <RefreshContentAsync>d__;
			<RefreshContentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshContentAsync>d__.<>4__this = this;
			<RefreshContentAsync>d__.dataList = dataList;
			<RefreshContentAsync>d__.<>1__state = -1;
			<RefreshContentAsync>d__.<>t__builder.Start<Spring25InfoView.<RefreshContentAsync>d__29>(ref <RefreshContentAsync>d__);
			return <RefreshContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603352E RID: 210222 RVA: 0x00E63C28 File Offset: 0x00E61E28
		private UniTask RefreshProgressAsync(List<Spring25InfoProgressData> dataList)
		{
			Spring25InfoView.<RefreshProgressAsync>d__30 <RefreshProgressAsync>d__;
			<RefreshProgressAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshProgressAsync>d__.<>4__this = this;
			<RefreshProgressAsync>d__.dataList = dataList;
			<RefreshProgressAsync>d__.<>1__state = -1;
			<RefreshProgressAsync>d__.<>t__builder.Start<Spring25InfoView.<RefreshProgressAsync>d__30>(ref <RefreshProgressAsync>d__);
			return <RefreshProgressAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603352F RID: 210223 RVA: 0x00E63C73 File Offset: 0x00E61E73
		private ContentItem BuildContentItem()
		{
			return new ContentItem();
		}

		// Token: 0x06033530 RID: 210224 RVA: 0x00E63C7A File Offset: 0x00E61E7A
		private ProgressItem BuildProgressItem()
		{
			return new ProgressItem();
		}

		// Token: 0x06033531 RID: 210225 RVA: 0x00E63C81 File Offset: 0x00E61E81
		private void HandleCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033532 RID: 210226 RVA: 0x00E63C8A File Offset: 0x00E61E8A
		private void HandleLookClick()
		{
			ActivitySpring25Controller.Instance.HandleOpenSkinPreview();
		}

		// Token: 0x06033533 RID: 210227 RVA: 0x00E63C96 File Offset: 0x00E61E96
		private void HandleBonusClick()
		{
			ActivitySpring25Controller.Instance.HandleRequestRewardSkin();
		}

		// Token: 0x06033534 RID: 210228 RVA: 0x00E63CA4 File Offset: 0x00E61EA4
		private void HandleSpring25DrawRewardDone()
		{
			Spring25InfoViewData spring25InfoViewData = Spring25Model.Instance.BuildInfoViewData();
			this.OpenParam = spring25InfoViewData;
			this.RefreshContentAsync(spring25InfoViewData.ContentList);
		}

		// Token: 0x06033535 RID: 210229 RVA: 0x00E63CD0 File Offset: 0x00E61ED0
		private void HandleSpring25SkinRewardDone()
		{
			Spring25InfoViewData spring25InfoViewData = Spring25Model.Instance.BuildInfoViewData();
			this.OpenParam = spring25InfoViewData;
			this.RefreshBottomByState(spring25InfoViewData.BottomState);
		}

		// Token: 0x0200ACE1 RID: 44257
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035750 RID: 218960
			public const int CaptionItem = 0;

			// Token: 0x04035751 RID: 218961
			public const int ContentLayout = 1;

			// Token: 0x04035752 RID: 218962
			public const int ContentTemplateItem = 2;

			// Token: 0x04035753 RID: 218963
			public const int LookButton = 3;

			// Token: 0x04035754 RID: 218964
			public const int CurrentNumText = 4;

			// Token: 0x04035755 RID: 218965
			public const int TotalNumText = 5;

			// Token: 0x04035756 RID: 218966
			public const int ProgressLayout = 6;

			// Token: 0x04035757 RID: 218967
			public const int ProgressTemplateItem = 7;

			// Token: 0x04035758 RID: 218968
			public const int BonusButton = 8;

			// Token: 0x04035759 RID: 218969
			public const int BottomItem = 9;

			// Token: 0x0403575A RID: 218970
			public const int ProgressItem = 10;

			// Token: 0x0403575B RID: 218971
			public const int CountItem = 11;

			// Token: 0x0403575C RID: 218972
			public const int SkinRewardedItem = 12;
		}
	}
}
