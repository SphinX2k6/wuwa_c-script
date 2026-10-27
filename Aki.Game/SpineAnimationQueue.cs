using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020019AB RID: 6571
[NullableContext(1)]
[Nullable(0)]
public class SpineAnimationQueue
{
	// Token: 0x0600BFA6 RID: 49062 RVA: 0x002B41B7 File Offset: 0x002B23B7
	public SpineAnimationQueue(USpineSkeletonAnimationComponent spine)
	{
		this.Spine = spine;
	}

	// Token: 0x0600BFA7 RID: 49063 RVA: 0x002B41C8 File Offset: 0x002B23C8
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

	// Token: 0x0600BFA8 RID: 49064 RVA: 0x002B4254 File Offset: 0x002B2454
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

	// Token: 0x04005632 RID: 22066
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISpineAnimationQueueParam> AnimationQueue;

	// Token: 0x04005633 RID: 22067
	[Nullable(2)]
	private UTrackEntry TrackEntry;

	// Token: 0x04005634 RID: 22068
	private readonly USpineSkeletonAnimationComponent Spine;
}
