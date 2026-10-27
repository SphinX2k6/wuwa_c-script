using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02005022 RID: 20514
	[NullableContext(2)]
	public interface ISequenceCommonQteHandle
	{
		// Token: 0x17008011 RID: 32785
		// (get) Token: 0x060347E4 RID: 215012
		// (set) Token: 0x060347E5 RID: 215013
		int SubtitleId { get; set; }

		// Token: 0x17008012 RID: 32786
		// (get) Token: 0x060347E6 RID: 215014
		// (set) Token: 0x060347E7 RID: 215015
		int OptionIndex { get; set; }

		// Token: 0x17008013 RID: 32787
		// (get) Token: 0x060347E8 RID: 215016
		// (set) Token: 0x060347E9 RID: 215017
		bool IsProgressQte { get; set; }

		// Token: 0x17008014 RID: 32788
		// (get) Token: 0x060347EA RID: 215018
		// (set) Token: 0x060347EB RID: 215019
		bool IsUpdateWithProgress { get; set; }

		// Token: 0x17008015 RID: 32789
		// (get) Token: 0x060347EC RID: 215020
		// (set) Token: 0x060347ED RID: 215021
		FFrameTime SequenceQteStartRange { get; set; }

		// Token: 0x17008016 RID: 32790
		// (get) Token: 0x060347EE RID: 215022
		// (set) Token: 0x060347EF RID: 215023
		FFrameTime SequenceQteEndRange { get; set; }

		// Token: 0x17008017 RID: 32791
		// (get) Token: 0x060347F0 RID: 215024
		// (set) Token: 0x060347F1 RID: 215025
		QteSpineInfoProxy SpineInfo { get; set; }

		// Token: 0x060347F2 RID: 215026
		[NullableContext(1)]
		void SetEventSpineComponents(List<USpineSkeletonAnimationComponent> components);

		// Token: 0x060347F3 RID: 215027
		void OnBegin();

		// Token: 0x060347F4 RID: 215028
		void OnFinish();

		// Token: 0x060347F5 RID: 215029
		void OnSequenceAnimFinished();

		// Token: 0x060347F6 RID: 215030
		void OnTick(float delta);

		// Token: 0x060347F7 RID: 215031
		void ForceStopSequenceQte();
	}
}
