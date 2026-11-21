using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E54 RID: 20052
	public class AutoPilotMobileView : AutoPilotView
	{
		// Token: 0x0603272D RID: 206637 RVA: 0x00E27628 File Offset: 0x00E25828
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

		// Token: 0x0603272E RID: 206638 RVA: 0x00E27779 File Offset: 0x00E25979
		protected override int GetSkipBtnCompId()
		{
			return 0;
		}

		// Token: 0x0603272F RID: 206639 RVA: 0x00E2777C File Offset: 0x00E2597C
		protected override int GetRideShareBtnCompId()
		{
			return 6;
		}

		// Token: 0x06032730 RID: 206640 RVA: 0x00E2777F File Offset: 0x00E2597F
		protected override int GetExitBtnCompId()
		{
			return 1;
		}

		// Token: 0x06032731 RID: 206641 RVA: 0x00E27782 File Offset: 0x00E25982
		protected override int GetPhotoBtnCompId()
		{
			return 4;
		}

		// Token: 0x06032732 RID: 206642 RVA: 0x00E27785 File Offset: 0x00E25985
		protected override int GetMovieBtnCompId()
		{
			return 2;
		}

		// Token: 0x06032733 RID: 206643 RVA: 0x00E27788 File Offset: 0x00E25988
		protected override int GetMovieBtnProgressCompId()
		{
			return 3;
		}

		// Token: 0x06032734 RID: 206644 RVA: 0x00E2778B File Offset: 0x00E2598B
		protected override void InitUi()
		{
			base.InitUi();
			this.InitRideShareProgress();
		}

		// Token: 0x06032735 RID: 206645 RVA: 0x00E2779C File Offset: 0x00E2599C
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

		// Token: 0x06032736 RID: 206646 RVA: 0x00E2781D File Offset: 0x00E25A1D
		private void OnToggle(bool isSelectOn)
		{
			this.IsSkipConfirmBoxShow = !isSelectOn;
		}

		// Token: 0x06032737 RID: 206647 RVA: 0x00E27829 File Offset: 0x00E25A29
		private void InitRideShareProgress()
		{
			this.RideShareProgress = base.GetTexture(8);
		}

		// Token: 0x06032738 RID: 206648 RVA: 0x00E27838 File Offset: 0x00E25A38
		protected override void UpdateRideShareProgress(float progress)
		{
			UUITexture rideShareProgress = this.RideShareProgress;
			if (rideShareProgress == null)
			{
				return;
			}
			rideShareProgress.SetFillAmount(progress);
		}

		// Token: 0x0401AC1F RID: 109599
		[Nullable(2)]
		private UUITexture RideShareProgress;

		// Token: 0x0401AC20 RID: 109600
		private bool IsSkipConfirmBoxShow = true;

		// Token: 0x0200AC01 RID: 44033
		private enum EAutoPilotMobileComponents
		{
			// Token: 0x040353C4 RID: 218052
			SkipBtn,
			// Token: 0x040353C5 RID: 218053
			ExitBtn,
			// Token: 0x040353C6 RID: 218054
			MovieBtn,
			// Token: 0x040353C7 RID: 218055
			MovieBtnProgress,
			// Token: 0x040353C8 RID: 218056
			PhotoBtn,
			// Token: 0x040353C9 RID: 218057
			MovieBtnIcon,
			// Token: 0x040353CA RID: 218058
			RideShareBtn,
			// Token: 0x040353CB RID: 218059
			RightDownBtnRoot,
			// Token: 0x040353CC RID: 218060
			RideShareProgress
		}
	}
}
