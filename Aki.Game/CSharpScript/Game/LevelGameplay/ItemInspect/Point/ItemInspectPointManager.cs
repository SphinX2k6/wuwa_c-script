using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02006DEF RID: 28143
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectPointManager
	{
		// Token: 0x06044A9B RID: 281243
		public abstract void Init(ISequenceUnlockPoints config);

		// Token: 0x06044A9C RID: 281244 RVA: 0x010F2FF4 File Offset: 0x010F11F4
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

		// Token: 0x06044A9D RID: 281245 RVA: 0x010F3083 File Offset: 0x010F1283
		protected virtual bool IsCurrentStageComplete()
		{
			return false;
		}

		// Token: 0x06044A9E RID: 281246 RVA: 0x010F3086 File Offset: 0x010F1286
		public int GetMaxValidCount()
		{
			return this.MaxValidCount;
		}

		// Token: 0x06044A9F RID: 281247 RVA: 0x010F308E File Offset: 0x010F128E
		public int GetCheckedValidCount()
		{
			return this.CheckedValidCount;
		}

		// Token: 0x06044AA0 RID: 281248 RVA: 0x010F3098 File Offset: 0x010F1298
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

		// Token: 0x06044AA1 RID: 281249 RVA: 0x010F30B8 File Offset: 0x010F12B8
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

		// Token: 0x06044AA2 RID: 281250 RVA: 0x010F30FC File Offset: 0x010F12FC
		public virtual EInteractPointInteractionType? GetCurrentStageInteractionType()
		{
			return null;
		}

		// Token: 0x06044AA3 RID: 281251 RVA: 0x010F3112 File Offset: 0x010F1312
		[NullableContext(2)]
		public virtual ItemInspectPoint GetCurrentStageDragPoint()
		{
			return null;
		}

		// Token: 0x06044AA4 RID: 281252 RVA: 0x010F3115 File Offset: 0x010F1315
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInteractEffect> GetCurrentStageEnterEffects()
		{
			return null;
		}

		// Token: 0x06044AA5 RID: 281253 RVA: 0x010F3118 File Offset: 0x010F1318
		public virtual bool ShouldResetAfterCurrentStageEnd()
		{
			return false;
		}

		// Token: 0x06044AA6 RID: 281254 RVA: 0x010F311B File Offset: 0x010F131B
		public virtual bool HasNextStage()
		{
			return false;
		}

		// Token: 0x06044AA7 RID: 281255 RVA: 0x010F311E File Offset: 0x010F131E
		public virtual bool AdvanceToNextStage()
		{
			return false;
		}

		// Token: 0x06044AA8 RID: 281256 RVA: 0x010F3121 File Offset: 0x010F1321
		public virtual void ActivateCurrentStage()
		{
		}

		// Token: 0x04023B96 RID: 146326
		private readonly Dictionary<int, ItemInspectPoint> TagIdToPointMap = new Dictionary<int, ItemInspectPoint>();

		// Token: 0x04023B97 RID: 146327
		private int MaxValidCount;

		// Token: 0x04023B98 RID: 146328
		private int CheckedValidCount;
	}
}
