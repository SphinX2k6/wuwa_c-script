using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02006DF1 RID: 28145
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceUnlockPointManager : ItemInspectPointManager
	{
		// Token: 0x06044AAB RID: 281259 RVA: 0x010F3164 File Offset: 0x010F1364
		public override void Init(ISequenceUnlockPoints config)
		{
			foreach (ISequenceInteractStage sequenceInteractStage in config.Stages)
			{
				List<ItemInspectPoint> list = new List<ItemInspectPoint>();
				foreach (IInteractPoint config2 in sequenceInteractStage.InteractPoints)
				{
					list.Add(base.CreatePoint(config2));
				}
				this.PointGroups.Add(list);
				this.StageConfigs.Add(sequenceInteractStage);
			}
		}

		// Token: 0x06044AAC RID: 281260 RVA: 0x010F3218 File Offset: 0x010F1418
		protected override bool IsCurrentStageComplete()
		{
			if (this.CurrentStageIndex >= this.PointGroups.Count)
			{
				return false;
			}
			using (List<ItemInspectPoint>.Enumerator enumerator = this.PointGroups[this.CurrentStageIndex].GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsChecked)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06044AAD RID: 281261 RVA: 0x010F3294 File Offset: 0x010F1494
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IInteractEffect> GetCurrentStageEnterEffects()
		{
			ISequenceInteractStage sequenceInteractStage = this.StageConfigs.ElementAtOrDefault(this.CurrentStageIndex);
			if (sequenceInteractStage == null)
			{
				return null;
			}
			return sequenceInteractStage.EnterStageEffects;
		}

		// Token: 0x06044AAE RID: 281262 RVA: 0x010F32B4 File Offset: 0x010F14B4
		public override bool ShouldResetAfterCurrentStageEnd()
		{
			ISequenceInteractStage sequenceInteractStage = this.StageConfigs.ElementAtOrDefault(this.CurrentStageIndex);
			return sequenceInteractStage != null && sequenceInteractStage.IsResetAfterStageEnd.GetValueOrDefault();
		}

		// Token: 0x06044AAF RID: 281263 RVA: 0x010F32E5 File Offset: 0x010F14E5
		public override bool HasNextStage()
		{
			return this.CurrentStageIndex + 1 < this.PointGroups.Count;
		}

		// Token: 0x06044AB0 RID: 281264 RVA: 0x010F32FC File Offset: 0x010F14FC
		public override bool AdvanceToNextStage()
		{
			if (!this.HasNextStage())
			{
				return false;
			}
			this.CurrentStageIndex++;
			return true;
		}

		// Token: 0x06044AB1 RID: 281265 RVA: 0x010F3318 File Offset: 0x010F1518
		public override void ActivateCurrentStage()
		{
			List<ItemInspectPoint> list = this.PointGroups.ElementAtOrDefault(this.CurrentStageIndex);
			if (list == null)
			{
				return;
			}
			foreach (ItemInspectPoint itemInspectPoint in list)
			{
				itemInspectPoint.IsActive = true;
			}
		}

		// Token: 0x06044AB2 RID: 281266 RVA: 0x010F337C File Offset: 0x010F157C
		public override EInteractPointInteractionType? GetCurrentStageInteractionType()
		{
			List<ItemInspectPoint> list = this.PointGroups.ElementAtOrDefault(this.CurrentStageIndex);
			if (list == null)
			{
				return null;
			}
			ItemInspectPoint itemInspectPoint = list.ElementAtOrDefault(0);
			if (itemInspectPoint == null)
			{
				return null;
			}
			IInteractPointInteraction interactionConfig = itemInspectPoint.InteractionConfig;
			if (interactionConfig == null)
			{
				return null;
			}
			return new EInteractPointInteractionType?(interactionConfig.Type);
		}

		// Token: 0x06044AB3 RID: 281267 RVA: 0x010F33DC File Offset: 0x010F15DC
		[NullableContext(2)]
		public override ItemInspectPoint GetCurrentStageDragPoint()
		{
			List<ItemInspectPoint> list = this.PointGroups.ElementAtOrDefault(this.CurrentStageIndex);
			if (list == null)
			{
				return null;
			}
			ItemInspectPoint itemInspectPoint = null;
			foreach (ItemInspectPoint itemInspectPoint2 in list)
			{
				IInteractPointInteraction interactionConfig = itemInspectPoint2.InteractionConfig;
				if (interactionConfig != null && interactionConfig.Type <= EInteractPointInteractionType.Drag)
				{
					if (itemInspectPoint != null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.LevelPlay;
						ELogAuthor author = ELogAuthor.FZX;
						string message = "物品检视，同一阶段配置了多个拖拽交互点，取第一个";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("阶段", this.CurrentStageIndex);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						break;
					}
					itemInspectPoint = itemInspectPoint2;
				}
			}
			return itemInspectPoint;
		}

		// Token: 0x04023B99 RID: 146329
		private int CurrentStageIndex;

		// Token: 0x04023B9A RID: 146330
		private readonly List<List<ItemInspectPoint>> PointGroups = new List<List<ItemInspectPoint>>();

		// Token: 0x04023B9B RID: 146331
		private readonly List<ISequenceInteractStage> StageConfigs = new List<ISequenceInteractStage>();
	}
}
