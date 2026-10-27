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
	// Token: 0x0200538E RID: 21390
	[NullableContext(2)]
	[Nullable(0)]
	public class MovieModeUiView : UiPanelBase
	{
		// Token: 0x06036A44 RID: 223812 RVA: 0x00CEE9E8 File Offset: 0x00CECBE8
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

		// Token: 0x06036A45 RID: 223813 RVA: 0x00CEEAB4 File Offset: 0x00CECCB4
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

		// Token: 0x06036A46 RID: 223814 RVA: 0x00CEEAE8 File Offset: 0x00CECCE8
		private void InitParameter()
		{
			IEnterMovieModeParams enterMovieModeParams = this.OpenParam as IEnterMovieModeParams;
			this.DelayShowUiDuration = ((enterMovieModeParams != null) ? enterMovieModeParams.DelayDuration : null).GetValueOrDefault();
			this.DelayShowUiDuration *= 1000f;
			this.IsCanShowUi = (this.DelayShowUiDuration == 0f);
		}

		// Token: 0x06036A47 RID: 223815 RVA: 0x00CEEB48 File Offset: 0x00CECD48
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

		// Token: 0x06036A48 RID: 223816 RVA: 0x00CEEB78 File Offset: 0x00CECD78
		private void OnClickMaskBtn()
		{
			MovieModeController.Instance.ResetMovieModeHideUi(false);
		}

		// Token: 0x06036A49 RID: 223817 RVA: 0x00CEEB85 File Offset: 0x00CECD85
		private void OnMovieModeHideUiChange(bool isHide)
		{
			this.HandleMovieModeHideUiChange(isHide);
		}

		// Token: 0x06036A4A RID: 223818 RVA: 0x00CEEB8E File Offset: 0x00CECD8E
		private void HandleMovieModeHideUiChange(bool isHide)
		{
			if (this.IsMovieModeHideUi == isHide)
			{
				return;
			}
			this.IsMovieModeHideUi = isHide;
			this.RefreshUiVisible();
		}

		// Token: 0x06036A4B RID: 223819 RVA: 0x00CEEBA7 File Offset: 0x00CECDA7
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

		// Token: 0x06036A4C RID: 223820 RVA: 0x00CEEBD8 File Offset: 0x00CECDD8
		private void OnClickExitBtn()
		{
			ExitMovieModeParams param = new ExitMovieModeParams
			{
				BlendTime = (float)ConfigCommonParamById.GetIntConfig("ExitMovieModeTimeThreshold").GetValueOrDefault(1)
			};
			MovieModeController.Instance.ExitMovieMode(param, null);
		}

		// Token: 0x06036A4D RID: 223821 RVA: 0x00CEEC12 File Offset: 0x00CECE12
		private void InitRightDownButtons()
		{
			this.InitPhotoBtn();
		}

		// Token: 0x06036A4E RID: 223822 RVA: 0x00CEEC1A File Offset: 0x00CECE1A
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

		// Token: 0x06036A4F RID: 223823 RVA: 0x00CEEC4C File Offset: 0x00CECE4C
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

		// Token: 0x06036A50 RID: 223824 RVA: 0x00CEECA0 File Offset: 0x00CECEA0
		public void OnTick(float deltaTime)
		{
			this.OnTickCanShowUi(deltaTime);
		}

		// Token: 0x06036A51 RID: 223825 RVA: 0x00CEECA9 File Offset: 0x00CECEA9
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

		// Token: 0x06036A52 RID: 223826 RVA: 0x00CEECE1 File Offset: 0x00CECEE1
		private void AddTick()
		{
			this.TickHandle = MovieModeController.Instance.AddTick(new Action<float>(this.OnTick));
		}

		// Token: 0x06036A53 RID: 223827 RVA: 0x00CEECFF File Offset: 0x00CECEFF
		private void RemoveTick()
		{
			MovieModeController.Instance.RemoveTick(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x06036A54 RID: 223828 RVA: 0x00CEED18 File Offset: 0x00CECF18
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

		// Token: 0x06036A55 RID: 223829 RVA: 0x00CEEE1A File Offset: 0x00CED01A
		private void RefreshUiVisible()
		{
			this.RefreshExitBtnVisible();
			this.RefreshPhotoBtnVisible();
			this.RefreshMaskBtnVisible();
		}

		// Token: 0x06036A56 RID: 223830 RVA: 0x00CEEE30 File Offset: 0x00CED030
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

		// Token: 0x06036A57 RID: 223831 RVA: 0x00CEEEA0 File Offset: 0x00CED0A0
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

		// Token: 0x06036A58 RID: 223832 RVA: 0x00CEEF10 File Offset: 0x00CED110
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

		// Token: 0x06036A59 RID: 223833 RVA: 0x00CEEF45 File Offset: 0x00CED145
		private void TryActivateTimer()
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				MovieModeController.Instance.ResetMovieModeHideUi(true);
				this.DeactivateTimer();
			}, (float)MovieModeModel.Instance.MovieModeHideUiTimeThreshold, null, null, true, 1f);
		}

		// Token: 0x06036A5A RID: 223834 RVA: 0x00CEEF76 File Offset: 0x00CED176
		private void DeactivateTimer()
		{
			if (this.TimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06036A5B RID: 223835 RVA: 0x00CEEFAA File Offset: 0x00CED1AA
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Add(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
		}

		// Token: 0x06036A5C RID: 223836 RVA: 0x00CEEFE4 File Offset: 0x00CED1E4
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

		// Token: 0x06036A5D RID: 223837 RVA: 0x00CEF017 File Offset: 0x00CED217
		public void ActivateTimer()
		{
			this.DeactivateTimer();
			this.TryActivateTimer();
		}

		// Token: 0x06036A5E RID: 223838 RVA: 0x00CEF025 File Offset: 0x00CED225
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Remove(EEventName.MovieModeHideUiChange, new Action<bool>(this.OnMovieModeHideUiChange));
		}

		// Token: 0x06036A5F RID: 223839 RVA: 0x00CEF05F File Offset: 0x00CED25F
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
			this.RemoveEvents();
			this.DeactivateTimer();
		}

		// Token: 0x0401CDF8 RID: 118264
		private UUIButtonComponent ExitBtn;

		// Token: 0x0401CDF9 RID: 118265
		private UUIButtonComponent PhotoBtn;

		// Token: 0x0401CDFA RID: 118266
		private UUIButtonComponent MaskBtn;

		// Token: 0x0401CDFB RID: 118267
		private int TickHandle = -1;

		// Token: 0x0401CDFC RID: 118268
		private float DelayShowUiDuration;

		// Token: 0x0401CDFD RID: 118269
		private bool IsCanShowUi;

		// Token: 0x0401CDFE RID: 118270
		private bool IsMovieModeHideUi;

		// Token: 0x0401CDFF RID: 118271
		private TimerHandle TimerHandle;

		// Token: 0x0401CE00 RID: 118272
		private bool IsAnyKeyPressed;

		// Token: 0x0200B5FD RID: 46589
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040371F6 RID: 225782
			BtnMask,
			// Token: 0x040371F7 RID: 225783
			BtnExit,
			// Token: 0x040371F8 RID: 225784
			BtnPhoto,
			// Token: 0x040371F9 RID: 225785
			SpriteBtnPhotoIcon,
			// Token: 0x040371FA RID: 225786
			RightDownBtnRoot
		}
	}
}
