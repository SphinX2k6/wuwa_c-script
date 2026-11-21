using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004371 RID: 17265
	[NullableContext(2)]
	[Nullable(0)]
	public class MovieModeUiView : UiPanelBase
	{
		// Token: 0x0602B98A RID: 178570 RVA: 0x00C3D910 File Offset: 0x00C3BB10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B98B RID: 178571 RVA: 0x00C3D9DC File Offset: 0x00C3BBDC
		protected override void OnStart()
		{
			this.AddEvents();
			this.InitParameter();
			this.InitMaskBtn();
			this.InitExitBtn();
			this.InitRightDownButtons();
			this.ApplyMovieAspectOffset();
			this.AddTick();
			this.RefreshUiVisible();
		}

		// Token: 0x0602B98C RID: 178572 RVA: 0x00C3DA10 File Offset: 0x00C3BC10
		private void InitParameter()
		{
			IEnterMovieModeParams enterMovieModeParams = this.OpenParam as IEnterMovieModeParams;
			this.DelayShowUiDuration = ((enterMovieModeParams != null) ? enterMovieModeParams.DelayDuration : null).GetValueOrDefault();
			this.DelayShowUiDuration *= 1000f;
			this.IsCanShowUi = (this.DelayShowUiDuration == 0f);
		}

		// Token: 0x0602B98D RID: 178573 RVA: 0x00C3DA70 File Offset: 0x00C3BC70
		private void InitMaskBtn()
		{
			this.MaskBtn = base.GetButton(0);
			UUIButtonComponent maskBtn = this.MaskBtn;
			if (maskBtn == null)
			{
				return;
			}
			maskBtn.OnClickCallBack.Bind(new Action(this.OnClickMaskBtn));
		}

		// Token: 0x0602B98E RID: 178574 RVA: 0x00C3DAA0 File Offset: 0x00C3BCA0
		private void OnClickMaskBtn()
		{
			MovieModeController.Instance.ResetMovieModeHideUi(false);
		}

		// Token: 0x0602B98F RID: 178575 RVA: 0x00C3DAAD File Offset: 0x00C3BCAD
		private void OnMovieModeHideUiChange(bool isHide)
		{
			this.HandleMovieModeHideUiChange(isHide);
		}

		// Token: 0x0602B990 RID: 178576 RVA: 0x00C3DAB6 File Offset: 0x00C3BCB6
		private void HandleMovieModeHideUiChange(bool isHide)
		{
			if (this.IsMovieModeHideUi == isHide)
			{
				return;
			}
			this.IsMovieModeHideUi = isHide;
			this.RefreshUiVisible();
		}

		// Token: 0x0602B991 RID: 178577 RVA: 0x00C3DACF File Offset: 0x00C3BCCF
		private void InitExitBtn()
		{
			this.ExitBtn = base.GetButton(1);
			UUIButtonComponent exitBtn = this.ExitBtn;
			if (exitBtn == null)
			{
				return;
			}
			exitBtn.OnClickCallBack.Bind(new Action(this.OnClickExitBtn));
		}

		// Token: 0x0602B992 RID: 178578 RVA: 0x00C3DB00 File Offset: 0x00C3BD00
		private void OnClickExitBtn()
		{
			ExitMovieModeParams param = new ExitMovieModeParams
			{
				BlendTime = (float)ConfigCommonParamById.GetIntConfig("ExitMovieModeTimeThreshold").GetValueOrDefault(1)
			};
			MovieModeController.Instance.ExitMovieMode(param, null);
		}

		// Token: 0x0602B993 RID: 178579 RVA: 0x00C3DB3A File Offset: 0x00C3BD3A
		private void InitRightDownButtons()
		{
			this.InitPhotoBtn();
		}

		// Token: 0x0602B994 RID: 178580 RVA: 0x00C3DB42 File Offset: 0x00C3BD42
		private void InitPhotoBtn()
		{
			this.PhotoBtn = base.GetButton(2);
			UUIButtonComponent photoBtn = this.PhotoBtn;
			if (photoBtn == null)
			{
				return;
			}
			photoBtn.OnClickCallBack.Bind(new Action(this.OnClickPhotoBtn));
		}

		// Token: 0x0602B995 RID: 178581 RVA: 0x00C3DB74 File Offset: 0x00C3BD74
		private void OnClickPhotoBtn()
		{
			PhotographController.Instance.ScreenShot(new PhotoSaveViewParam
			{
				ScreenShot = true,
				PrepareFullScreenShot = false,
				IsHiddenBattleView = true,
				HandBookPhotoData = null,
				GachaData = null,
				FragmentMemory = null,
				RoleSkinData = null,
				ShareId = 1
			});
		}

		// Token: 0x0602B996 RID: 178582 RVA: 0x00C3DBC8 File Offset: 0x00C3BDC8
		public void OnTick(float deltaTime)
		{
			this.OnTickCanShowUi(deltaTime);
		}

		// Token: 0x0602B997 RID: 178583 RVA: 0x00C3DBD1 File Offset: 0x00C3BDD1
		private void OnTickCanShowUi(float deltaTime)
		{
			if (this.IsCanShowUi)
			{
				return;
			}
			this.DelayShowUiDuration -= deltaTime;
			if (this.DelayShowUiDuration <= 0f)
			{
				this.IsCanShowUi = true;
				MovieModeController.Instance.ResetMovieModeHideUi(false);
			}
		}

		// Token: 0x0602B998 RID: 178584 RVA: 0x00C3DC09 File Offset: 0x00C3BE09
		private void AddTick()
		{
			this.TickHandle = MovieModeController.Instance.AddTick(new Action<float>(this.OnTick));
		}

		// Token: 0x0602B999 RID: 178585 RVA: 0x00C3DC27 File Offset: 0x00C3BE27
		private void RemoveTick()
		{
			MovieModeController.Instance.RemoveTick(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x0602B99A RID: 178586 RVA: 0x00C3DC40 File Offset: 0x00C3BE40
		private void ApplyMovieAspectOffset()
		{
			IMovieModeAspectOffset aspectOffset = MovieModeController.Instance.GetAspectOffset();
			if (aspectOffset == null)
			{
				Log.Instance.Error(ELogModule.MovieMode, ELogAuthor.CB, "MovieModeUiView:MovieModeController.GetAspectOffset is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FVector2D anchorOffset = base.GetButton(1).RootUIComp.Get().GetAnchorOffset();
			FVector2D anchorOffset2 = base.GetItem(4).GetAnchorOffset();
			if (aspectOffset.IsWidthBlend)
			{
				UUIButtonComponent button = base.GetButton(1);
				if (button != null)
				{
					button.RootUIComp.Get().SetAnchorOffsetX(anchorOffset.X - aspectOffset.Offset);
				}
				UUIItem item = base.GetItem(4);
				if (item == null)
				{
					return;
				}
				item.SetAnchorOffsetX(anchorOffset2.X - aspectOffset.Offset);
				return;
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(1);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetAnchorOffsetY(anchorOffset.Y - aspectOffset.Offset);
				}
				UUIItem item2 = base.GetItem(4);
				if (item2 == null)
				{
					return;
				}
				item2.SetAnchorOffsetY(anchorOffset2.Y + aspectOffset.Offset);
				return;
			}
		}

		// Token: 0x0602B99B RID: 178587 RVA: 0x00C3DD42 File Offset: 0x00C3BF42
		private void RefreshUiVisible()
		{
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
			this.RefreshMaskBtnVisible();
		}

		// Token: 0x0602B99C RID: 178588 RVA: 0x00C3DD58 File Offset: 0x00C3BF58
		private void RefreshExitBtnVisible()
		{
			IEnterMovieModeParams enterMovieModeParams = this.OpenParam as IEnterMovieModeParams;
			bool valueOrDefault = ((enterMovieModeParams != null) ? enterMovieModeParams.IsEnableEsc : null).GetValueOrDefault();
			UUIButtonComponent exitBtn = this.ExitBtn;
			if (exitBtn == null)
			{
				return;
			}
			UUIItem uuiitem = exitBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!this.IsMovieModeHideUi && valueOrDefault && this.IsCanShowUi);
		}

		// Token: 0x0602B99D RID: 178589 RVA: 0x00C3DDC8 File Offset: 0x00C3BFC8
		private void RefreshPhotoBtnVisible()
		{
			IEnterMovieModeParams enterMovieModeParams = this.OpenParam as IEnterMovieModeParams;
			bool valueOrDefault = ((enterMovieModeParams != null) ? enterMovieModeParams.IsEnablePhoto : null).GetValueOrDefault();
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
			uuiitem.SetUIActive(!this.IsMovieModeHideUi && valueOrDefault && this.IsCanShowUi);
		}

		// Token: 0x0602B99E RID: 178590 RVA: 0x00C3DE38 File Offset: 0x00C3C038
		private void RefreshMaskBtnVisible()
		{
			UUIButtonComponent maskBtn = this.MaskBtn;
			if (maskBtn == null)
			{
				return;
			}
			UUIItem uuiitem = maskBtn.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.IsMovieModeHideUi);
		}

		// Token: 0x0602B99F RID: 178591 RVA: 0x00C3DE6D File Offset: 0x00C3C06D
		private void TryActivateTimer()
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				MovieModeController.Instance.ResetMovieModeHideUi(true);
				this.DeactivateTimer();
			}, (float)MovieModeModel.Instance.MovieModeHideUiTimeThreshold, null, null, true, 1f);
		}

		// Token: 0x0602B9A0 RID: 178592 RVA: 0x00C3DE9E File Offset: 0x00C3C09E
		private void DeactivateTimer()
		{
			if (this.TimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602B9A1 RID: 178593 RVA: 0x00C3DED2 File Offset: 0x00C3C0D2
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Add(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
		}

		// Token: 0x0602B9A2 RID: 178594 RVA: 0x00C3DF0C File Offset: 0x00C3C10C
		[NullableContext(1)]
		private void OnInputAnyKey(bool bPress, FKey key)
		{
			if (bPress)
			{
				this.DeactivateTimer();
				this.IsAnyKeyPressed = true;
				MovieModeController.Instance.ResetMovieModeHideUi(false);
				return;
			}
			if (this.IsAnyKeyPressed)
			{
				this.ActivateTimer();
				this.IsAnyKeyPressed = false;
			}
		}

		// Token: 0x0602B9A3 RID: 178595 RVA: 0x00C3DF3F File Offset: 0x00C3C13F
		public void ActivateTimer()
		{
			this.DeactivateTimer();
			this.TryActivateTimer();
		}

		// Token: 0x0602B9A4 RID: 178596 RVA: 0x00C3DF4D File Offset: 0x00C3C14D
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Remove(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
		}

		// Token: 0x0602B9A5 RID: 178597 RVA: 0x00C3DF87 File Offset: 0x00C3C187
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
			this.RemoveEvents();
			this.DeactivateTimer();
		}

		// Token: 0x04017890 RID: 96400
		private UUIButtonComponent ExitBtn;

		// Token: 0x04017891 RID: 96401
		private UUIButtonComponent PhotoBtn;

		// Token: 0x04017892 RID: 96402
		private UUIButtonComponent MaskBtn;

		// Token: 0x04017893 RID: 96403
		private int TickHandle = -1;

		// Token: 0x04017894 RID: 96404
		private float DelayShowUiDuration;

		// Token: 0x04017895 RID: 96405
		private bool IsCanShowUi;

		// Token: 0x04017896 RID: 96406
		private bool IsMovieModeHideUi;

		// Token: 0x04017897 RID: 96407
		private TimerHandle TimerHandle;

		// Token: 0x04017898 RID: 96408
		private bool IsAnyKeyPressed;

		// Token: 0x0200A035 RID: 41013
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04031C4B RID: 203851
			BtnMask,
			// Token: 0x04031C4C RID: 203852
			BtnExit,
			// Token: 0x04031C4D RID: 203853
			BtnPhoto,
			// Token: 0x04031C4E RID: 203854
			SpriteBtnPhotoIcon,
			// Token: 0x04031C4F RID: 203855
			RightDownBtnRoot
		}
	}
}
