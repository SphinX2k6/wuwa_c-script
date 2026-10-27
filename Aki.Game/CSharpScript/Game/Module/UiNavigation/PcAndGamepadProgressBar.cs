using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048ED RID: 18669
	[NullableContext(1)]
	[Nullable(0)]
	public class PcAndGamepadProgressBar
	{
		// Token: 0x06030D1B RID: 199963 RVA: 0x00B5606C File Offset: 0x00B5426C
		public UniTask Init(UUIItem pcItem, UUIItem gamePadItem)
		{
			PcAndGamepadProgressBar.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.pcItem = pcItem;
			<Init>d__.gamePadItem = gamePadItem;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<PcAndGamepadProgressBar.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06030D1C RID: 199964 RVA: 0x00B560BF File Offset: 0x00B542BF
		public void SetProgressPercent(float percent)
		{
			this.SetPercent(percent);
			this.RefreshProgressVisible();
		}

		// Token: 0x06030D1D RID: 199965 RVA: 0x00B560CE File Offset: 0x00B542CE
		public void SetPercent(float percent)
		{
			if (Info.Instance.IsInGamepad())
			{
				ProgressBar gamepadProgress = this.GamepadProgress;
				if (gamepadProgress == null)
				{
					return;
				}
				gamepadProgress.SetPercent(percent);
				return;
			}
			else
			{
				ProgressBar pcProgress = this.PcProgress;
				if (pcProgress == null)
				{
					return;
				}
				pcProgress.SetPercent(percent);
				return;
			}
		}

		// Token: 0x06030D1E RID: 199966 RVA: 0x00B560FF File Offset: 0x00B542FF
		public void SetProgressVisible(bool bVisible)
		{
			if (bVisible)
			{
				this.RefreshProgressVisible();
				return;
			}
			ProgressBar pcProgress = this.PcProgress;
			if (pcProgress != null)
			{
				pcProgress.SetActive(false);
			}
			ProgressBar gamepadProgress = this.GamepadProgress;
			if (gamepadProgress == null)
			{
				return;
			}
			gamepadProgress.SetActive(false);
		}

		// Token: 0x06030D1F RID: 199967 RVA: 0x00B56130 File Offset: 0x00B54330
		public void RefreshProgressVisible()
		{
			bool flag = Info.Instance.IsInGamepad();
			bool flag2 = !flag;
			bool flag3 = flag;
			ProgressBar pcProgress = this.PcProgress;
			if (pcProgress == null || pcProgress.GetActive() != flag2)
			{
				ProgressBar pcProgress2 = this.PcProgress;
				if (pcProgress2 != null)
				{
					pcProgress2.SetActive(flag2);
				}
			}
			ProgressBar gamepadProgress = this.GamepadProgress;
			if (gamepadProgress == null || gamepadProgress.GetActive() != flag3)
			{
				ProgressBar gamepadProgress2 = this.GamepadProgress;
				if (gamepadProgress2 == null)
				{
					return;
				}
				gamepadProgress2.SetActive(flag3);
			}
		}

		// Token: 0x0401A360 RID: 107360
		private ProgressBar PcProgress;

		// Token: 0x0401A361 RID: 107361
		private ProgressBar GamepadProgress;
	}
}
