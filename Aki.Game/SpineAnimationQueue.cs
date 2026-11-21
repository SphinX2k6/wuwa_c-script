using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E69 RID: 3689
[NullableContext(1)]
[Nullable(0)]
public class SpineAnimationQueue
{
	// Token: 0x060093B0 RID: 37808 RVA: 0x002BF147 File Offset: 0x002BD347
	public SpineAnimationQueue(USpineSkeletonAnimationComponent spine)
	{
		this.Spine = spine;
	}

	// Token: 0x060093B1 RID: 37809 RVA: 0x002BF158 File Offset: 0x002BD358
	public void PushAnimation(int layerIndex, string animationName, bool loop)
	{
		if (this.Spine == null)
		{
			return;
		}
		if (this.TrackEntry != null)
		{
			if (this.AnimationQueue == null)
			{
				this.AnimationQueue = new List<ISpineAnimationQueueParam>();
			}
			this.AnimationQueue.Add(new SpineAnimationQueueParam
			{
				LayerIndex = layerIndex,
				AnimationName = animationName,
				Loop = loop
			});
			return;
		}
		this.TrackEntry = this.Spine.SetAnimation(layerIndex, animationName, loop);
		UTrackEntry trackEntry = this.TrackEntry;
		if (trackEntry == null)
		{
			return;
		}
		trackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnAnimationCompleted));
	}

	// Token: 0x060093B2 RID: 37810 RVA: 0x002BF1E4 File Offset: 0x002BD3E4
	private void OnAnimationCompleted(UTrackEntry _)
	{
		this.TrackEntry = null;
		if (this.AnimationQueue != null && this.AnimationQueue.Count > 0)
		{
			ISpineAnimationQueueParam spineAnimationQueueParam = this.AnimationQueue[0];
			this.AnimationQueue.RemoveAt(0);
			USpineSkeletonAnimationComponent spine = this.Spine;
			this.TrackEntry = ((spine != null) ? spine.SetAnimation(spineAnimationQueueParam.LayerIndex, spineAnimationQueueParam.AnimationName, spineAnimationQueueParam.Loop) : null);
			UTrackEntry trackEntry = this.TrackEntry;
			if (trackEntry == null)
			{
				return;
			}
			trackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnAnimationCompleted));
		}
	}

	// Token: 0x040056E4 RID: 22244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISpineAnimationQueueParam> AnimationQueue;

	// Token: 0x040056E5 RID: 22245
	[Nullable(2)]
	private UTrackEntry TrackEntry;

	// Token: 0x040056E6 RID: 22246
	private readonly USpineSkeletonAnimationComponent Spine;
}
