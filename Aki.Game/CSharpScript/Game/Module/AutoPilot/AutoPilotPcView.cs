using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E59 RID: 20057
	public class AutoPilotPcView : AutoPilotView
	{
		// Token: 0x06032781 RID: 206721 RVA: 0x00E28A88 File Offset: 0x00E26C88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032782 RID: 206722 RVA: 0x00E28BD9 File Offset: 0x00E26DD9
		protected override int GetSkipBtnCompId()
		{
			return 4;
		}

		// Token: 0x06032783 RID: 206723 RVA: 0x00E28BDC File Offset: 0x00E26DDC
		protected override int GetRideShareBtnCompId()
		{
			return 6;
		}

		// Token: 0x06032784 RID: 206724 RVA: 0x00E28BDF File Offset: 0x00E26DDF
		protected override int GetExitBtnCompId()
		{
			return 7;
		}

		// Token: 0x06032785 RID: 206725 RVA: 0x00E28BE2 File Offset: 0x00E26DE2
		protected override int GetPhotoBtnCompId()
		{
			return 0;
		}

		// Token: 0x06032786 RID: 206726 RVA: 0x00E28BE5 File Offset: 0x00E26DE5
		protected override int GetMovieBtnCompId()
		{
			return 1;
		}

		// Token: 0x06032787 RID: 206727 RVA: 0x00E28BE8 File Offset: 0x00E26DE8
		protected override int GetMovieBtnProgressCompId()
		{
			return 2;
		}

		// Token: 0x06032788 RID: 206728 RVA: 0x00E28BEB File Offset: 0x00E26DEB
		protected override void InitUi()
		{
			base.InitUi();
			this.InitMovieModePhotoBtn();
		}

		// Token: 0x06032789 RID: 206729 RVA: 0x00E28BF9 File Offset: 0x00E26DF9
		protected override void HandleClickSkipBtn()
		{
			AutoPilotController.Instance.SkipToTarget();
		}

		// Token: 0x0603278A RID: 206730 RVA: 0x00E28C05 File Offset: 0x00E26E05
		private void InitMovieModePhotoBtn()
		{
			this.MovieModePhotoBtn = base.GetButton(5);
			UUIButtonComponent movieModePhotoBtn = this.MovieModePhotoBtn;
			if (movieModePhotoBtn == null)
			{
				return;
			}
			movieModePhotoBtn.OnClickCallBack.Bind(new Action(base.OnClickPhotoBtn));
		}

		// Token: 0x0603278B RID: 206731 RVA: 0x00E28C35 File Offset: 0x00E26E35
		protected override void RefreshUiVisible()
		{
			base.RefreshUiVisible();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603278C RID: 206732 RVA: 0x00E28C43 File Offset: 0x00E26E43
		protected override void RefreshUiByIsMovieModeHideUi()
		{
			base.RefreshUiByIsMovieModeHideUi();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603278D RID: 206733 RVA: 0x00E28C51 File Offset: 0x00E26E51
		protected override void RefreshUiByIsInMovieMode()
		{
			base.RefreshUiByIsInMovieMode();
			this.RefreshPhotoBtnVisible();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603278E RID: 206734 RVA: 0x00E28C68 File Offset: 0x00E26E68
		private void RefreshMovieModePhotoBtnVisible()
		{
			bool isInMovieMode = AutoPilotModel.Instance.GetIsInMovieMode();
			UUIButtonComponent movieModePhotoBtn = this.MovieModePhotoBtn;
			if (movieModePhotoBtn == null)
			{
				return;
			}
			UUIItem uuiitem = movieModePhotoBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(isInMovieMode && !this.IsMovieModeHideUi);
		}

		// Token: 0x0603278F RID: 206735 RVA: 0x00E28CB4 File Offset: 0x00E26EB4
		protected override void RefreshPhotoBtnVisible()
		{
			bool isInMovieMode = AutoPilotModel.Instance.GetIsInMovieMode();
			UUIButtonComponent photoBtn = this.PhotoBtn;
			if (photoBtn == null)
			{
				return;
			}
			UUIItem uuiitem = photoBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!isInMovieMode);
		}

		// Token: 0x0401AC51 RID: 109649
		[Nullable(2)]
		private UUIButtonComponent MovieModePhotoBtn;

		// Token: 0x0200AC05 RID: 44037
		private enum EAutoPilotPcComponents
		{
			// Token: 0x040353D3 RID: 218067
			PhotoBtn,
			// Token: 0x040353D4 RID: 218068
			MovieBtn,
			// Token: 0x040353D5 RID: 218069
			MovieBtnProgress,
			// Token: 0x040353D6 RID: 218070
			MovieBtnIcon,
			// Token: 0x040353D7 RID: 218071
			SkipBtn,
			// Token: 0x040353D8 RID: 218072
			MovieModePhotoBtn,
			// Token: 0x040353D9 RID: 218073
			RideShareBtn,
			// Token: 0x040353DA RID: 218074
			ExitBtn,
			// Token: 0x040353DB RID: 218075
			RightDownBtnRoot
		}
	}
}
