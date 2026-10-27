using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E6F RID: 24175
	public class AutoPilotMobileView : AutoPilotView
	{
		// Token: 0x0603D79D RID: 251805 RVA: 0x00ED60B0 File Offset: 0x00ED42B0
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D79E RID: 251806 RVA: 0x00ED6201 File Offset: 0x00ED4401
		protected override int GetSkipBtnCompId()
		{
			return 0;
		}

		// Token: 0x0603D79F RID: 251807 RVA: 0x00ED6204 File Offset: 0x00ED4404
		protected override int GetRideShareBtnCompId()
		{
			return 6;
		}

		// Token: 0x0603D7A0 RID: 251808 RVA: 0x00ED6207 File Offset: 0x00ED4407
		protected override int GetExitBtnCompId()
		{
			return 1;
		}

		// Token: 0x0603D7A1 RID: 251809 RVA: 0x00ED620A File Offset: 0x00ED440A
		protected override int GetPhotoBtnCompId()
		{
			return 4;
		}

		// Token: 0x0603D7A2 RID: 251810 RVA: 0x00ED620D File Offset: 0x00ED440D
		protected override int GetMovieBtnCompId()
		{
			return 2;
		}

		// Token: 0x0603D7A3 RID: 251811 RVA: 0x00ED6210 File Offset: 0x00ED4410
		protected override int GetMovieBtnProgressCompId()
		{
			return 3;
		}

		// Token: 0x0603D7A4 RID: 251812 RVA: 0x00ED6213 File Offset: 0x00ED4413
		protected override void InitUi()
		{
			base.InitUi();
			this.InitRideShareProgress();
		}

		// Token: 0x0603D7A5 RID: 251813 RVA: 0x00ED6224 File Offset: 0x00ED4424
		protected override void HandleClickSkipBtn()
		{
			if (AutoPilotModel.Instance.IsSkipConfirmBoxShow)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SkipPlot);
				confirmBoxDataNew.HasToggle = true;
				confirmBoxDataNew.ToggleText = TextConfig.Instance.GetTextById("PlotSkipConfirmToggle");
				confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnToggle));
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					AutoPilotModel.Instance.IsSkipConfirmBoxShow = this.IsSkipConfirmBoxShow;
					AutoPilotController.Instance.SkipToTarget();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			AutoPilotController.Instance.SkipToTarget();
		}

		// Token: 0x0603D7A6 RID: 251814 RVA: 0x00ED62A5 File Offset: 0x00ED44A5
		private void OnToggle(bool isSelectOn)
		{
			this.IsSkipConfirmBoxShow = !isSelectOn;
		}

		// Token: 0x0603D7A7 RID: 251815 RVA: 0x00ED62B1 File Offset: 0x00ED44B1
		private void InitRideShareProgress()
		{
			this.RideShareProgress = base.GetTexture(8);
		}

		// Token: 0x0603D7A8 RID: 251816 RVA: 0x00ED62C0 File Offset: 0x00ED44C0
		protected override void UpdateRideShareProgress(float progress)
		{
			UUITexture rideShareProgress = this.RideShareProgress;
			if (rideShareProgress == null)
			{
				return;
			}
			rideShareProgress.SetFillAmount(progress);
		}

		// Token: 0x04020158 RID: 131416
		[Nullable(2)]
		private UUITexture RideShareProgress;

		// Token: 0x04020159 RID: 131417
		private bool IsSkipConfirmBoxShow = true;

		// Token: 0x0200C1F2 RID: 49650
		private enum EAutoPilotMobileComponents
		{
			// Token: 0x0403A9D2 RID: 240082
			SkipBtn,
			// Token: 0x0403A9D3 RID: 240083
			ExitBtn,
			// Token: 0x0403A9D4 RID: 240084
			MovieBtn,
			// Token: 0x0403A9D5 RID: 240085
			MovieBtnProgress,
			// Token: 0x0403A9D6 RID: 240086
			PhotoBtn,
			// Token: 0x0403A9D7 RID: 240087
			MovieBtnIcon,
			// Token: 0x0403A9D8 RID: 240088
			RideShareBtn,
			// Token: 0x0403A9D9 RID: 240089
			RightDownBtnRoot,
			// Token: 0x0403A9DA RID: 240090
			RideShareProgress
		}
	}
}
