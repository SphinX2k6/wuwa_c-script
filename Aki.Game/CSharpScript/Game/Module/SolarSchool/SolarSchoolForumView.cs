using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005912 RID: 22802
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolForumView : SolarSchoolHideHudViewBase
	{
		// Token: 0x0603836D RID: 230253 RVA: 0x00FB764E File Offset: 0x00FB584E
		public SolarSchoolForumView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603836E RID: 230254 RVA: 0x00FB7658 File Offset: 0x00FB5858
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnBackClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnTogLikeStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603836F RID: 230255 RVA: 0x00FB7784 File Offset: 0x00FB5984
		public void ShowForum(string titleId, IReadOnlyList<int> postIds)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), titleId, Array.Empty<object>());
			this.PostScroll.RefreshByData(postIds, null, true);
			this.LikeSelected = false;
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038370 RID: 230256 RVA: 0x00FB77D3 File Offset: 0x00FB59D3
		private void OnBtnBackClick()
		{
			ISolarSchoolForumViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnContinueClicked();
		}

		// Token: 0x06038371 RID: 230257 RVA: 0x00FB77E5 File Offset: 0x00FB59E5
		private bool OnCanLikeChange()
		{
			return !this.LikeSelected;
		}

		// Token: 0x06038372 RID: 230258 RVA: 0x00FB77F0 File Offset: 0x00FB59F0
		private void OnTogLikeStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.LikeSelected)
			{
				return;
			}
			this.LikeSelected = true;
			ISolarSchoolForumViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnLikeSelected();
		}

		// Token: 0x06038373 RID: 230259 RVA: 0x00FB7816 File Offset: 0x00FB5A16
		private SolarSchoolForumPostItem CreateForumPostItem()
		{
			return new SolarSchoolForumPostItem();
		}

		// Token: 0x06038374 RID: 230260 RVA: 0x00FB7820 File Offset: 0x00FB5A20
		protected override void OnStart()
		{
			this.PostScroll = new GenericScrollViewNew<SolarSchoolForumPostItem, int>(base.GetScrollViewWithScrollbar(2), new Func<SolarSchoolForumPostItem>(this.CreateForumPostItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, null);
			base.GetExtendToggle(4).CanExecuteChange.Bind(new Func<bool>(this.OnCanLikeChange));
			ISolarSchoolForumViewHandler solarSchoolForumViewHandler = this.OpenParam as ISolarSchoolForumViewHandler;
			if (solarSchoolForumViewHandler == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.YYZ, "[SolarSchool][Forum] 论坛界面打开参数缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Handler = solarSchoolForumViewHandler;
			this.Handler.OnViewReady(this);
		}

		// Token: 0x06038375 RID: 230261 RVA: 0x00FB78BD File Offset: 0x00FB5ABD
		protected override void OnBeforeDestroy()
		{
			this.PostScroll = null;
			ISolarSchoolForumViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x0401D97B RID: 121211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SolarSchoolForumPostItem, int> PostScroll;

		// Token: 0x0401D97C RID: 121212
		[Nullable(2)]
		private ISolarSchoolForumViewHandler Handler;

		// Token: 0x0401D97D RID: 121213
		private bool LikeSelected;

		// Token: 0x0200B4D6 RID: 46294
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E9D RID: 229021
			public const int BtnBack = 0;

			// Token: 0x04037E9E RID: 229022
			public const int TxtTitle = 1;

			// Token: 0x04037E9F RID: 229023
			public const int SvInfo = 2;

			// Token: 0x04037EA0 RID: 229024
			public const int PnlItem = 3;

			// Token: 0x04037EA1 RID: 229025
			public const int TogLike = 4;
		}
	}
}
