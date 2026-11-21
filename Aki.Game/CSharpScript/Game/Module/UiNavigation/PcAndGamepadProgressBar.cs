using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003864 RID: 14436
	[NullableContext(1)]
	[Nullable(0)]
	public class PcAndGamepadProgressBar
	{
		// Token: 0x06025848 RID: 153672 RVA: 0x00A90EDC File Offset: 0x00A8F0DC
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

		// Token: 0x06025849 RID: 153673 RVA: 0x00A90F2F File Offset: 0x00A8F12F
		public void SetProgressPercent(float percent)
		{
			this.SetPercent(percent);
			this.RefreshProgressVisible();
		}

		// Token: 0x0602584A RID: 153674 RVA: 0x00A90F3E File Offset: 0x00A8F13E
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

		// Token: 0x0602584B RID: 153675 RVA: 0x00A90F6F File Offset: 0x00A8F16F
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

		// Token: 0x0602584C RID: 153676 RVA: 0x00A90FA0 File Offset: 0x00A8F1A0
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

		// Token: 0x04014BD3 RID: 84947
		private ProgressBar PcProgress;

		// Token: 0x04014BD4 RID: 84948
		private ProgressBar GamepadProgress;
	}
}
