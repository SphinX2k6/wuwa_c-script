using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range.RangeShape
{
	// Token: 0x02002F81 RID: 12161
	[NullableContext(1)]
	[Nullable(0)]
	public class ActorRefVolumeRangeShape : IRangeShape
	{
		// Token: 0x0601CC88 RID: 117896 RVA: 0x008C97DC File Offset: 0x008C79DC
		public ActorRefVolumeRangeShape(RangeComponent rangeComponentOwner)
		{
			this.SceneItemReferenceComponent = rangeComponentOwner.Entity.GetComponent<SceneItemReferenceComponent>();
		}

		// Token: 0x0601CC89 RID: 117897 RVA: 0x008C97F5 File Offset: 0x008C79F5
		public void InitializeRangeShape(Action<bool> onInitialized)
		{
			if (this.IsCleared || this.IsInitialized)
			{
				return;
			}
			this.IsInitialized = true;
			onInitialized(true);
		}

		// Token: 0x0601CC8A RID: 117898 RVA: 0x008C9816 File Offset: 0x008C7A16
		public void RegisterOverlapCallback([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> onOverlap)
		{
			this.UnregisterOverlapCallback();
			this.OverlapCallback = onOverlap;
			SceneItemReferenceComponent sceneItemReferenceComponent = this.SceneItemReferenceComponent;
			if (sceneItemReferenceComponent == null)
			{
				return;
			}
			sceneItemReferenceComponent.AddOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerOverlap), false);
		}

		// Token: 0x0601CC8B RID: 117899 RVA: 0x008C9842 File Offset: 0x008C7A42
		public void UnregisterOverlapCallback()
		{
			SceneItemReferenceComponent sceneItemReferenceComponent = this.SceneItemReferenceComponent;
			if (sceneItemReferenceComponent != null)
			{
				sceneItemReferenceComponent.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerOverlap));
			}
			this.OverlapCallback = null;
		}

		// Token: 0x0601CC8C RID: 117900 RVA: 0x008C9868 File Offset: 0x008C7A68
		public void RefreshOverlapState()
		{
		}

		// Token: 0x0601CC8D RID: 117901 RVA: 0x008C986C File Offset: 0x008C7A6C
		public IReadOnlyList<AActor> GetCurrentOverlappingActors()
		{
			AActor myRoleTrigger = RoleTriggerController.Instance.GetMyRoleTrigger();
			SceneItemReferenceComponent sceneItemReferenceComponent = this.SceneItemReferenceComponent;
			if (sceneItemReferenceComponent == null || !sceneItemReferenceComponent.IsPlayerOverlappedRefVolume() || myRoleTrigger == null || !myRoleTrigger.IsValid())
			{
				return Array.Empty<AActor>();
			}
			return new <>z__ReadOnlySingleElementList<AActor>(myRoleTrigger);
		}

		// Token: 0x0601CC8E RID: 117902 RVA: 0x008C98B3 File Offset: 0x008C7AB3
		private void OnPlayerOverlap(bool isEnter)
		{
			Action<AActor, bool> overlapCallback = this.OverlapCallback;
			if (overlapCallback == null)
			{
				return;
			}
			overlapCallback(RoleTriggerController.Instance.GetMyRoleTrigger(), isEnter);
		}

		// Token: 0x0601CC8F RID: 117903 RVA: 0x008C98D0 File Offset: 0x008C7AD0
		public void ClearRangeShape()
		{
			if (this.IsCleared)
			{
				return;
			}
			this.IsCleared = true;
			this.UnregisterOverlapCallback();
		}

		// Token: 0x0400F283 RID: 62083
		[Nullable(2)]
		private readonly SceneItemReferenceComponent SceneItemReferenceComponent;

		// Token: 0x0400F284 RID: 62084
		[Nullable(2)]
		private Action<AActor, bool> OverlapCallback;

		// Token: 0x0400F285 RID: 62085
		private bool IsInitialized;

		// Token: 0x0400F286 RID: 62086
		private bool IsCleared;
	}
}
