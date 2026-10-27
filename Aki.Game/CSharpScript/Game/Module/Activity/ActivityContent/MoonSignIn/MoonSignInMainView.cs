using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006466 RID: 25702
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInMainView : UiViewBase
	{
		// Token: 0x0604096F RID: 264559 RVA: 0x00FA238F File Offset: 0x00FA058F
		public MoonSignInMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040970 RID: 264560 RVA: 0x00FA2398 File Offset: 0x00FA0598
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickIllustratedBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickWishBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCurrentMoonDesBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickCurrentMoonTipsCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040971 RID: 264561 RVA: 0x00FA25F8 File Offset: 0x00FA07F8
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040972 RID: 264562 RVA: 0x00FA263C File Offset: 0x00FA083C
		protected override void OnStart()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.BindSequenceCloseEvent(delegate(string name)
				{
					if (name == "TjStart")
					{
						base.GetItem(6).SetUIActive(false);
					}
					if (name == "TjHideView")
					{
						MoonSignInIllustrated illustratedView = this.IllustratedView;
						if (illustratedView == null)
						{
							return;
						}
						illustratedView.SetUiActive(false);
					}
				}, false);
			}
			base.GetButton(13).RootUIComp.Get().SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (((data != null) ? data.GetCurrentItemCount() : 0) > 0)
			{
				this.OpenWishView(false);
				return;
			}
			this.OpenIllustratedView();
		}

		// Token: 0x06040973 RID: 264563 RVA: 0x00FA26C3 File Offset: 0x00FA08C3
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.RefreshRedDot();
		}

		// Token: 0x06040974 RID: 264564 RVA: 0x00FA26D4 File Offset: 0x00FA08D4
		private void RefreshTitle()
		{
			base.GetItem(7).SetUIActive(false);
			MoonSignInData data = MoonSignInController.Instance.GetData();
			int? num = (data != null) ? new int?(data.CurrentMoonId) : null;
			if (num == null || num.Value == 0)
			{
				base.GetItem(9).SetUIActive(false);
				return;
			}
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(num.Value);
			if (phaseOfMoonById == null)
			{
				return;
			}
			base.GetItem(9).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phaseOfMoonById.Value.MoonName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), phaseOfMoonById.Value.BuffDes, Array.Empty<object>());
		}

		// Token: 0x06040975 RID: 264565 RVA: 0x00FA27A7 File Offset: 0x00FA09A7
		private void RefreshRedDot()
		{
			UUIItem item = base.GetItem(10);
			MoonSignInData data = MoonSignInController.Instance.GetData();
			item.SetUIActive(((data != null) ? data.GetCurrentItemCount() : 0) >= 1);
		}

		// Token: 0x06040976 RID: 264566 RVA: 0x00FA27D4 File Offset: 0x00FA09D4
		private void OpenWishView(bool playWishShow = false)
		{
			base.GetItem(6).SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("TjHideView", false, null, false);
			}
			if (playWishShow)
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("WishShowView", true, null, false);
				}
			}
			this.RefreshRedDot();
		}

		// Token: 0x06040977 RID: 264567 RVA: 0x00FA283C File Offset: 0x00FA0A3C
		private void OpenIllustratedView()
		{
			MoonSignInIllustrated illustratedView = this.IllustratedView;
			if (illustratedView != null)
			{
				illustratedView.SetUiActive(true);
			}
			MoonSignInIllustrated illustratedView2 = this.IllustratedView;
			if (illustratedView2 != null)
			{
				illustratedView2.RefreshPhaseView();
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("TjStart", true, null, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("WishHideView", false, null, false);
		}

		// Token: 0x06040978 RID: 264568 RVA: 0x00FA28AD File Offset: 0x00FA0AAD
		private void OnClickIllustratedBtn()
		{
			this.OpenIllustratedView();
		}

		// Token: 0x06040979 RID: 264569 RVA: 0x00FA28B8 File Offset: 0x00FA0AB8
		private void OnClickWishBtn()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			if (data.GetCurrentItemCount() > 0)
			{
				MoonSignInController.Instance.MoonPhaseRandomRequest(data.Id);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("MoonSignInItemCountNotEnough", Array.Empty<object>());
		}

		// Token: 0x0604097A RID: 264570 RVA: 0x00FA2904 File Offset: 0x00FA0B04
		private void OnClickCurrentMoonDesBtn()
		{
			base.GetItem(7).SetUIActive(true);
			UUIButtonComponent button = base.GetButton(13);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0604097B RID: 264571 RVA: 0x00FA2940 File Offset: 0x00FA0B40
		private void OnClickCurrentMoonTipsCloseBtn()
		{
			base.GetItem(7).SetUIActive(false);
			UUIButtonComponent button = base.GetButton(13);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0604097C RID: 264572 RVA: 0x00FA297A File Offset: 0x00FA0B7A
		private void OnClickIllustratedViewSwitchBtn()
		{
			this.OpenWishView(true);
		}

		// Token: 0x0604097D RID: 264573 RVA: 0x00FA2983 File Offset: 0x00FA0B83
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x04021952 RID: 137554
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021953 RID: 137555
		private MoonSignInIllustrated IllustratedView;

		// Token: 0x04021954 RID: 137556
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C690 RID: 50832
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403BF16 RID: 245526
			public const int CaptionItem = 0;

			// Token: 0x0403BF17 RID: 245527
			public const int CurrentMoonNameText = 1;

			// Token: 0x0403BF18 RID: 245528
			public const int CurrentMoonDesBtn = 2;

			// Token: 0x0403BF19 RID: 245529
			public const int IllustratedBtn = 3;

			// Token: 0x0403BF1A RID: 245530
			public const int WishBtn = 4;

			// Token: 0x0403BF1B RID: 245531
			public const int IllustratedItem = 5;

			// Token: 0x0403BF1C RID: 245532
			public const int WishItem = 6;

			// Token: 0x0403BF1D RID: 245533
			public const int CurrentMoonTipsItem = 7;

			// Token: 0x0403BF1E RID: 245534
			public const int CurrentMoonTipsText = 8;

			// Token: 0x0403BF1F RID: 245535
			public const int CurrentMoonNameItem = 9;

			// Token: 0x0403BF20 RID: 245536
			public const int WishBtnRedDotItem = 10;

			// Token: 0x0403BF21 RID: 245537
			public const int CurrentMoonTipsCloseBtn = 13;
		}
	}
}
