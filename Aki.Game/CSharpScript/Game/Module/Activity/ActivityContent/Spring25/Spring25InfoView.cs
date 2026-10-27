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
	// Token: 0x0200609F RID: 24735
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25InfoView : UiViewBase
	{
		// Token: 0x0603E857 RID: 256087 RVA: 0x00F1C987 File Offset: 0x00F1AB87
		public Spring25InfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17009090 RID: 37008
		// (get) Token: 0x0603E858 RID: 256088 RVA: 0x00F1C990 File Offset: 0x00F1AB90
		// (set) Token: 0x0603E859 RID: 256089 RVA: 0x00F1C998 File Offset: 0x00F1AB98
		private PopupCaptionItem CaptionItem { get; set; }

		// Token: 0x17009091 RID: 37009
		// (get) Token: 0x0603E85A RID: 256090 RVA: 0x00F1C9A1 File Offset: 0x00F1ABA1
		// (set) Token: 0x0603E85B RID: 256091 RVA: 0x00F1C9A9 File Offset: 0x00F1ABA9
		private GenericLayout<ContentItem, Spring25InfoContentData> ContentLayout { get; set; }

		// Token: 0x17009092 RID: 37010
		// (get) Token: 0x0603E85C RID: 256092 RVA: 0x00F1C9B2 File Offset: 0x00F1ABB2
		// (set) Token: 0x0603E85D RID: 256093 RVA: 0x00F1C9BA File Offset: 0x00F1ABBA
		private GenericLayout<ProgressItem, Spring25InfoProgressData> ProgressLayout { get; set; }

		// Token: 0x17009093 RID: 37011
		// (get) Token: 0x0603E85E RID: 256094 RVA: 0x00F1C9C3 File Offset: 0x00F1ABC3
		// (set) Token: 0x0603E85F RID: 256095 RVA: 0x00F1C9CB File Offset: 0x00F1ABCB
		private UiSequencePlayer BottomPlayer { get; set; }

		// Token: 0x17009094 RID: 37012
		// (get) Token: 0x0603E860 RID: 256096 RVA: 0x00F1C9D4 File Offset: 0x00F1ABD4
		// (set) Token: 0x0603E861 RID: 256097 RVA: 0x00F1C9DC File Offset: 0x00F1ABDC
		private UUIInturnAnimController ContentPlayer { get; set; }

		// Token: 0x0603E862 RID: 256098 RVA: 0x00F1C9E8 File Offset: 0x00F1ABE8
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

		// Token: 0x0603E863 RID: 256099 RVA: 0x00F1CC24 File Offset: 0x00F1AE24
		protected override UniTask OnBeforeStartAsync()
		{
			Spring25InfoView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<Spring25InfoView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E864 RID: 256100 RVA: 0x00F1CC67 File Offset: 0x00F1AE67
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x0603E865 RID: 256101 RVA: 0x00F1CC6F File Offset: 0x00F1AE6F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(this.HandleSpring25DrawRewardDone));
			EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(this.HandleSpring25SkinRewardDone));
		}

		// Token: 0x0603E866 RID: 256102 RVA: 0x00F1CCA9 File Offset: 0x00F1AEA9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(this.HandleSpring25DrawRewardDone));
			EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(this.HandleSpring25SkinRewardDone));
		}

		// Token: 0x0603E867 RID: 256103 RVA: 0x00F1CCE4 File Offset: 0x00F1AEE4
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

		// Token: 0x0603E868 RID: 256104 RVA: 0x00F1CD78 File Offset: 0x00F1AF78
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

		// Token: 0x0603E869 RID: 256105 RVA: 0x00F1CE18 File Offset: 0x00F1B018
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

		// Token: 0x0603E86A RID: 256106 RVA: 0x00F1CE64 File Offset: 0x00F1B064
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

		// Token: 0x0603E86B RID: 256107 RVA: 0x00F1CEAF File Offset: 0x00F1B0AF
		private ContentItem BuildContentItem()
		{
			return new ContentItem();
		}

		// Token: 0x0603E86C RID: 256108 RVA: 0x00F1CEB6 File Offset: 0x00F1B0B6
		private ProgressItem BuildProgressItem()
		{
			return new ProgressItem();
		}

		// Token: 0x0603E86D RID: 256109 RVA: 0x00F1CEBD File Offset: 0x00F1B0BD
		private void HandleCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E86E RID: 256110 RVA: 0x00F1CEC6 File Offset: 0x00F1B0C6
		private void HandleLookClick()
		{
			ActivitySpring25Controller.Instance.HandleOpenSkinPreview();
		}

		// Token: 0x0603E86F RID: 256111 RVA: 0x00F1CED2 File Offset: 0x00F1B0D2
		private void HandleBonusClick()
		{
			ActivitySpring25Controller.Instance.HandleRequestRewardSkin();
		}

		// Token: 0x0603E870 RID: 256112 RVA: 0x00F1CEE0 File Offset: 0x00F1B0E0
		private void HandleSpring25DrawRewardDone()
		{
			Spring25InfoViewData spring25InfoViewData = Spring25Model.Instance.BuildInfoViewData();
			this.OpenParam = spring25InfoViewData;
			this.RefreshContentAsync(spring25InfoViewData.ContentList);
		}

		// Token: 0x0603E871 RID: 256113 RVA: 0x00F1CF0C File Offset: 0x00F1B10C
		private void HandleSpring25SkinRewardDone()
		{
			Spring25InfoViewData spring25InfoViewData = Spring25Model.Instance.BuildInfoViewData();
			this.OpenParam = spring25InfoViewData;
			this.RefreshBottomByState(spring25InfoViewData.BottomState);
		}

		// Token: 0x0200C2F6 RID: 49910
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403ADE8 RID: 241128
			public const int CaptionItem = 0;

			// Token: 0x0403ADE9 RID: 241129
			public const int ContentLayout = 1;

			// Token: 0x0403ADEA RID: 241130
			public const int ContentTemplateItem = 2;

			// Token: 0x0403ADEB RID: 241131
			public const int LookButton = 3;

			// Token: 0x0403ADEC RID: 241132
			public const int CurrentNumText = 4;

			// Token: 0x0403ADED RID: 241133
			public const int TotalNumText = 5;

			// Token: 0x0403ADEE RID: 241134
			public const int ProgressLayout = 6;

			// Token: 0x0403ADEF RID: 241135
			public const int ProgressTemplateItem = 7;

			// Token: 0x0403ADF0 RID: 241136
			public const int BonusButton = 8;

			// Token: 0x0403ADF1 RID: 241137
			public const int BottomItem = 9;

			// Token: 0x0403ADF2 RID: 241138
			public const int ProgressItem = 10;

			// Token: 0x0403ADF3 RID: 241139
			public const int CountItem = 11;

			// Token: 0x0403ADF4 RID: 241140
			public const int SkinRewardedItem = 12;
		}
	}
}
