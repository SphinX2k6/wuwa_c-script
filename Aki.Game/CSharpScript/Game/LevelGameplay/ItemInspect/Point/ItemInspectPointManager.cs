using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02005F6E RID: 24430
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectPointManager
	{
		// Token: 0x0603ABFF RID: 240639
		public abstract void Init(ISequenceUnlockPoints config);

		// Token: 0x0603AC00 RID: 240640 RVA: 0x0109D240 File Offset: 0x0109B440
		protected ItemInspectPoint CreatePoint(IInteractPoint config)
		{
			ItemInspectPoint itemInspectPoint = new ItemInspectPoint();
			itemInspectPoint.EffectConfigs = config.InteractEffects;
			int tag = config.Tag;
			itemInspectPoint.TagId = tag;
			itemInspectPoint.CancelTrace = config.CancelRaycast.GetValueOrDefault();
			itemInspectPoint.ProtectTime = config.ProtectTime.GetValueOrDefault();
			itemInspectPoint.InteractionConfig = config.InteractionConfig;
			this.TagIdToPointMap[tag] = itemInspectPoint;
			bool isValidPoint = config.IsValidPoint;
			itemInspectPoint.IsValid = isValidPoint;
			if (isValidPoint)
			{
				this.MaxValidCount++;
			}
			return itemInspectPoint;
		}

		// Token: 0x0603AC01 RID: 240641 RVA: 0x0109D2CF File Offset: 0x0109B4CF
		protected virtual bool IsCurrentStageComplete()
		{
			return false;
		}

		// Token: 0x0603AC02 RID: 240642 RVA: 0x0109D2D2 File Offset: 0x0109B4D2
		public int GetMaxValidCount()
		{
			return this.MaxValidCount;
		}

		// Token: 0x0603AC03 RID: 240643 RVA: 0x0109D2DA File Offset: 0x0109B4DA
		public int GetCheckedValidCount()
		{
			return this.CheckedValidCount;
		}

		// Token: 0x0603AC04 RID: 240644 RVA: 0x0109D2E4 File Offset: 0x0109B4E4
		[NullableContext(2)]
		public ItemInspectPoint GetPoint(int tagId)
		{
			ItemInspectPoint result;
			if (this.TagIdToPointMap.TryGetValue(tagId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603AC05 RID: 240645 RVA: 0x0109D304 File Offset: 0x0109B504
		public bool CheckPoint(int tagId)
		{
			ItemInspectPoint itemInspectPoint;
			if (!this.TagIdToPointMap.TryGetValue(tagId, out itemInspectPoint))
			{
				return false;
			}
			if (itemInspectPoint.IsChecked)
			{
				return false;
			}
			itemInspectPoint.IsChecked = true;
			this.CheckedValidCount++;
			return this.IsCurrentStageComplete();
		}

		// Token: 0x0603AC06 RID: 240646 RVA: 0x0109D348 File Offset: 0x0109B548
		public virtual EInteractPointInteractionType? GetCurrentStageInteractionType()
		{
			return null;
		}

		// Token: 0x0603AC07 RID: 240647 RVA: 0x0109D35E File Offset: 0x0109B55E
		[NullableContext(2)]
		public virtual ItemInspectPoint GetCurrentStageDragPoint()
		{
			return null;
		}

		// Token: 0x0603AC08 RID: 240648 RVA: 0x0109D361 File Offset: 0x0109B561
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInteractEffect> GetCurrentStageEnterEffects()
		{
			return null;
		}

		// Token: 0x0603AC09 RID: 240649 RVA: 0x0109D364 File Offset: 0x0109B564
		public virtual bool ShouldResetAfterCurrentStageEnd()
		{
			return false;
		}

		// Token: 0x0603AC0A RID: 240650 RVA: 0x0109D367 File Offset: 0x0109B567
		public virtual bool HasNextStage()
		{
			return false;
		}

		// Token: 0x0603AC0B RID: 240651 RVA: 0x0109D36A File Offset: 0x0109B56A
		public virtual bool AdvanceToNextStage()
		{
			return false;
		}

		// Token: 0x0603AC0C RID: 240652 RVA: 0x0109D36D File Offset: 0x0109B56D
		public virtual void ActivateCurrentStage()
		{
		}

		// Token: 0x0401EE38 RID: 126520
		private readonly Dictionary<int, ItemInspectPoint> TagIdToPointMap = new Dictionary<int, ItemInspectPoint>();

		// Token: 0x0401EE39 RID: 126521
		private int MaxValidCount;

		// Token: 0x0401EE3A RID: 126522
		private int CheckedValidCount;
	}
}
