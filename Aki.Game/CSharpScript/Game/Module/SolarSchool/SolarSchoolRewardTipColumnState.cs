using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F6 RID: 23030
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class SolarSchoolRewardTipColumnState
	{
		// Token: 0x06038B8D RID: 232333 RVA: 0x00FDFF14 File Offset: 0x00FDE114
		public SolarSchoolRewardTipColumnState(UUIVerticalLayout layout, Queue<SolarSchoolRewardTipData> rewardTipQueue)
		{
			this.Layout = layout;
			this.ParentUiItem = layout.RootUIComp.Get();
			this.RewardTipQueue = rewardTipQueue;
			layout.SetEnable(false);
		}

		// Token: 0x06038B8E RID: 232334 RVA: 0x00FDFF50 File Offset: 0x00FDE150
		[NullableContext(2)]
		public SolarSchoolRewardTipData DequeueRewardTip()
		{
			SolarSchoolRewardTipData result;
			if (!this.RewardTipQueue.TryPop(out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038B8F RID: 232335 RVA: 0x00FDFF6F File Offset: 0x00FDE16F
		public void ResetPendingRewardTip()
		{
			this.PendingRewardTipItem = null;
			this.NextRewardTipLoadState = EItemLoadState.None;
			this.NextRewardTipElapsedTime = 0f;
		}

		// Token: 0x0401DDCA RID: 122314
		public readonly UUIVerticalLayout Layout;

		// Token: 0x0401DDCB RID: 122315
		public readonly UUIItem ParentUiItem;

		// Token: 0x0401DDCC RID: 122316
		public float ChildHeight;

		// Token: 0x0401DDCD RID: 122317
		public float SliderHeight;

		// Token: 0x0401DDCE RID: 122318
		public readonly Queue<SolarSchoolRewardTipData> RewardTipQueue;

		// Token: 0x0401DDCF RID: 122319
		[Nullable(2)]
		public SolarSchoolRewardTipItemBase PendingRewardTipItem;

		// Token: 0x0401DDD0 RID: 122320
		public EItemLoadState NextRewardTipLoadState;

		// Token: 0x0401DDD1 RID: 122321
		public float NextRewardTipElapsedTime;
	}
}
