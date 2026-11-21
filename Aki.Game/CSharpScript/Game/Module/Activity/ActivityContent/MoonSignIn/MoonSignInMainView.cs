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
	// Token: 0x020053E4 RID: 21476
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInMainView : UiViewBase
	{
		// Token: 0x06035630 RID: 218672 RVA: 0x00EE930B File Offset: 0x00EE750B
		public MoonSignInMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035631 RID: 218673 RVA: 0x00EE9314 File Offset: 0x00EE7514
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

		// Token: 0x06035632 RID: 218674 RVA: 0x00EE9574 File Offset: 0x00EE7774
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035633 RID: 218675 RVA: 0x00EE95B8 File Offset: 0x00EE77B8
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

		// Token: 0x06035634 RID: 218676 RVA: 0x00EE963F File Offset: 0x00EE783F
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.RefreshRedDot();
		}

		// Token: 0x06035635 RID: 218677 RVA: 0x00EE9650 File Offset: 0x00EE7850
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

		// Token: 0x06035636 RID: 218678 RVA: 0x00EE9723 File Offset: 0x00EE7923
		private void RefreshRedDot()
		{
			UUIItem item = base.GetItem(10);
			MoonSignInData data = MoonSignInController.Instance.GetData();
			item.SetUIActive(((data != null) ? data.GetCurrentItemCount() : 0) >= 1);
		}

		// Token: 0x06035637 RID: 218679 RVA: 0x00EE9750 File Offset: 0x00EE7950
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

		// Token: 0x06035638 RID: 218680 RVA: 0x00EE97B8 File Offset: 0x00EE79B8
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

		// Token: 0x06035639 RID: 218681 RVA: 0x00EE9829 File Offset: 0x00EE7A29
		private void OnClickIllustratedBtn()
		{
			this.OpenIllustratedView();
		}

		// Token: 0x0603563A RID: 218682 RVA: 0x00EE9834 File Offset: 0x00EE7A34
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

		// Token: 0x0603563B RID: 218683 RVA: 0x00EE9880 File Offset: 0x00EE7A80
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

		// Token: 0x0603563C RID: 218684 RVA: 0x00EE98BC File Offset: 0x00EE7ABC
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

		// Token: 0x0603563D RID: 218685 RVA: 0x00EE98F6 File Offset: 0x00EE7AF6
		private void OnClickIllustratedViewSwitchBtn()
		{
			this.OpenWishView(true);
		}

		// Token: 0x0603563E RID: 218686 RVA: 0x00EE98FF File Offset: 0x00EE7AFF
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0401C281 RID: 115329
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C282 RID: 115330
		private MoonSignInIllustrated IllustratedView;

		// Token: 0x0401C283 RID: 115331
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B076 RID: 45174
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036871 RID: 223345
			public const int CaptionItem = 0;

			// Token: 0x04036872 RID: 223346
			public const int CurrentMoonNameText = 1;

			// Token: 0x04036873 RID: 223347
			public const int CurrentMoonDesBtn = 2;

			// Token: 0x04036874 RID: 223348
			public const int IllustratedBtn = 3;

			// Token: 0x04036875 RID: 223349
			public const int WishBtn = 4;

			// Token: 0x04036876 RID: 223350
			public const int IllustratedItem = 5;

			// Token: 0x04036877 RID: 223351
			public const int WishItem = 6;

			// Token: 0x04036878 RID: 223352
			public const int CurrentMoonTipsItem = 7;

			// Token: 0x04036879 RID: 223353
			public const int CurrentMoonTipsText = 8;

			// Token: 0x0403687A RID: 223354
			public const int CurrentMoonNameItem = 9;

			// Token: 0x0403687B RID: 223355
			public const int WishBtnRedDotItem = 10;

			// Token: 0x0403687C RID: 223356
			public const int CurrentMoonTipsCloseBtn = 13;
		}
	}
}
