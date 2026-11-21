using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FEC RID: 16364
	[NullableContext(2)]
	public interface ISequenceCommonQteHandle
	{
		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x06029687 RID: 169607
		// (set) Token: 0x06029688 RID: 169608
		int SubtitleId { get; set; }

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x06029689 RID: 169609
		// (set) Token: 0x0602968A RID: 169610
		int OptionIndex { get; set; }

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x0602968B RID: 169611
		// (set) Token: 0x0602968C RID: 169612
		bool IsProgressQte { get; set; }

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x0602968D RID: 169613
		// (set) Token: 0x0602968E RID: 169614
		bool IsUpdateWithProgress { get; set; }

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x0602968F RID: 169615
		// (set) Token: 0x06029690 RID: 169616
		FFrameTime SequenceQteStartRange { get; set; }

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x06029691 RID: 169617
		// (set) Token: 0x06029692 RID: 169618
		FFrameTime SequenceQteEndRange { get; set; }

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x06029693 RID: 169619
		// (set) Token: 0x06029694 RID: 169620
		QteSpineInfoProxy SpineInfo { get; set; }

		// Token: 0x06029695 RID: 169621
		[NullableContext(1)]
		void SetEventSpineComponents(List<USpineSkeletonAnimationComponent> components);

		// Token: 0x06029696 RID: 169622
		void OnBegin();

		// Token: 0x06029697 RID: 169623
		void OnFinish();

		// Token: 0x06029698 RID: 169624
		void OnSequenceAnimFinished();

		// Token: 0x06029699 RID: 169625
		void OnTick(float delta);

		// Token: 0x0602969A RID: 169626
		void ForceStopSequenceQte();
	}
}
