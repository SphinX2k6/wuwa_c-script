using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E74 RID: 24180
	public class AutoPilotPcView : AutoPilotView
	{
		// Token: 0x0603D7F1 RID: 251889 RVA: 0x00ED74FC File Offset: 0x00ED56FC
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

		// Token: 0x0603D7F2 RID: 251890 RVA: 0x00ED764D File Offset: 0x00ED584D
		protected override int GetSkipBtnCompId()
		{
			return 4;
		}

		// Token: 0x0603D7F3 RID: 251891 RVA: 0x00ED7650 File Offset: 0x00ED5850
		protected override int GetRideShareBtnCompId()
		{
			return 6;
		}

		// Token: 0x0603D7F4 RID: 251892 RVA: 0x00ED7653 File Offset: 0x00ED5853
		protected override int GetExitBtnCompId()
		{
			return 7;
		}

		// Token: 0x0603D7F5 RID: 251893 RVA: 0x00ED7656 File Offset: 0x00ED5856
		protected override int GetPhotoBtnCompId()
		{
			return 0;
		}

		// Token: 0x0603D7F6 RID: 251894 RVA: 0x00ED7659 File Offset: 0x00ED5859
		protected override int GetMovieBtnCompId()
		{
			return 1;
		}

		// Token: 0x0603D7F7 RID: 251895 RVA: 0x00ED765C File Offset: 0x00ED585C
		protected override int GetMovieBtnProgressCompId()
		{
			return 2;
		}

		// Token: 0x0603D7F8 RID: 251896 RVA: 0x00ED765F File Offset: 0x00ED585F
		protected override void InitUi()
		{
			base.InitUi();
			this.InitMovieModePhotoBtn();
		}

		// Token: 0x0603D7F9 RID: 251897 RVA: 0x00ED766D File Offset: 0x00ED586D
		protected override void HandleClickSkipBtn()
		{
			AutoPilotController.Instance.SkipToTarget();
		}

		// Token: 0x0603D7FA RID: 251898 RVA: 0x00ED7679 File Offset: 0x00ED5879
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

		// Token: 0x0603D7FB RID: 251899 RVA: 0x00ED76A9 File Offset: 0x00ED58A9
		protected override void RefreshUiVisible()
		{
			base.RefreshUiVisible();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603D7FC RID: 251900 RVA: 0x00ED76B7 File Offset: 0x00ED58B7
		protected override void RefreshUiByIsMovieModeHideUi()
		{
			base.RefreshUiByIsMovieModeHideUi();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603D7FD RID: 251901 RVA: 0x00ED76C5 File Offset: 0x00ED58C5
		protected override void RefreshUiByIsInMovieMode()
		{
			base.RefreshUiByIsInMovieMode();
			this.RefreshPhotoBtnVisible();
			this.RefreshMovieModePhotoBtnVisible();
		}

		// Token: 0x0603D7FE RID: 251902 RVA: 0x00ED76DC File Offset: 0x00ED58DC
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

		// Token: 0x0603D7FF RID: 251903 RVA: 0x00ED7728 File Offset: 0x00ED5928
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

		// Token: 0x0402018A RID: 131466
		[Nullable(2)]
		private UUIButtonComponent MovieModePhotoBtn;

		// Token: 0x0200C1F6 RID: 49654
		private enum EAutoPilotPcComponents
		{
			// Token: 0x0403A9E1 RID: 240097
			PhotoBtn,
			// Token: 0x0403A9E2 RID: 240098
			MovieBtn,
			// Token: 0x0403A9E3 RID: 240099
			MovieBtnProgress,
			// Token: 0x0403A9E4 RID: 240100
			MovieBtnIcon,
			// Token: 0x0403A9E5 RID: 240101
			SkipBtn,
			// Token: 0x0403A9E6 RID: 240102
			MovieModePhotoBtn,
			// Token: 0x0403A9E7 RID: 240103
			RideShareBtn,
			// Token: 0x0403A9E8 RID: 240104
			ExitBtn,
			// Token: 0x0403A9E9 RID: 240105
			RightDownBtnRoot
		}
	}
}
