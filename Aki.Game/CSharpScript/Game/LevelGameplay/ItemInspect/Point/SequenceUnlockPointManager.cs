using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Point
{
	// Token: 0x02005F70 RID: 24432
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceUnlockPointManager : ItemInspectPointManager
	{
		// Token: 0x0603AC0F RID: 240655 RVA: 0x0109D3B0 File Offset: 0x0109B5B0
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

		// Token: 0x0603AC10 RID: 240656 RVA: 0x0109D464 File Offset: 0x0109B664
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

		// Token: 0x0603AC11 RID: 240657 RVA: 0x0109D4E0 File Offset: 0x0109B6E0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IInteractEffect> GetCurrentStageEnterEffects()
		{
			if (this.CurrentStageIndex < 0 || this.CurrentStageIndex >= this.StageConfigs.Count)
			{
				return null;
			}
			return this.StageConfigs[this.CurrentStageIndex].EnterStageEffects;
		}

		// Token: 0x0603AC12 RID: 240658 RVA: 0x0109D518 File Offset: 0x0109B718
		public override bool ShouldResetAfterCurrentStageEnd()
		{
			return this.CurrentStageIndex >= 0 && this.CurrentStageIndex < this.StageConfigs.Count && this.StageConfigs[this.CurrentStageIndex].IsResetAfterStageEnd.GetValueOrDefault();
		}

		// Token: 0x0603AC13 RID: 240659 RVA: 0x0109D561 File Offset: 0x0109B761
		public override bool HasNextStage()
		{
			return this.CurrentStageIndex + 1 < this.PointGroups.Count;
		}

		// Token: 0x0603AC14 RID: 240660 RVA: 0x0109D578 File Offset: 0x0109B778
		public override bool AdvanceToNextStage()
		{
			if (!this.HasNextStage())
			{
				return false;
			}
			this.CurrentStageIndex++;
			return true;
		}

		// Token: 0x0603AC15 RID: 240661 RVA: 0x0109D594 File Offset: 0x0109B794
		public override void ActivateCurrentStage()
		{
			if (this.CurrentStageIndex < 0 || this.CurrentStageIndex >= this.PointGroups.Count)
			{
				return;
			}
			foreach (ItemInspectPoint itemInspectPoint in this.PointGroups[this.CurrentStageIndex])
			{
				itemInspectPoint.IsActive = true;
			}
		}

		// Token: 0x0603AC16 RID: 240662 RVA: 0x0109D610 File Offset: 0x0109B810
		public override EInteractPointInteractionType? GetCurrentStageInteractionType()
		{
			if (this.CurrentStageIndex < 0 || this.CurrentStageIndex >= this.PointGroups.Count)
			{
				return null;
			}
			List<ItemInspectPoint> list = this.PointGroups[this.CurrentStageIndex];
			if (list == null || list.Count == 0)
			{
				return null;
			}
			IInteractPointInteraction interactionConfig = list[0].InteractionConfig;
			if (interactionConfig == null)
			{
				return null;
			}
			return new EInteractPointInteractionType?(interactionConfig.Type);
		}

		// Token: 0x0603AC17 RID: 240663 RVA: 0x0109D690 File Offset: 0x0109B890
		[NullableContext(2)]
		public override ItemInspectPoint GetCurrentStageDragPoint()
		{
			if (this.CurrentStageIndex < 0 || this.CurrentStageIndex >= this.PointGroups.Count)
			{
				return null;
			}
			List<ItemInspectPoint> list = this.PointGroups[this.CurrentStageIndex];
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

		// Token: 0x0401EE3B RID: 126523
		private int CurrentStageIndex;

		// Token: 0x0401EE3C RID: 126524
		private readonly List<List<ItemInspectPoint>> PointGroups = new List<List<ItemInspectPoint>>();

		// Token: 0x0401EE3D RID: 126525
		private readonly List<ISequenceInteractStage> StageConfigs = new List<ISequenceInteractStage>();
	}
}
