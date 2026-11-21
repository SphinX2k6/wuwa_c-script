using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200478F RID: 18319
	public class TTrapDefenseConditionStepUnion
	{
		// Token: 0x17007FB5 RID: 32693
		// (get) Token: 0x0601AF8B RID: 110475 RVA: 0x003D2B54 File Offset: 0x003D0D54
		// (set) Token: 0x0601AF8C RID: 110476 RVA: 0x003D2B5C File Offset: 0x003D0D5C
		public TTrapDefenseConditionStep Type { get; set; }

		// Token: 0x17007FB6 RID: 32694
		// (get) Token: 0x0601AF8D RID: 110477 RVA: 0x003D2B65 File Offset: 0x003D0D65
		// (set) Token: 0x0601AF8E RID: 110478 RVA: 0x003D2B6D File Offset: 0x003D0D6D
		public object Value { get; set; }

		// Token: 0x0601AF8F RID: 110479 RVA: 0x003D2B76 File Offset: 0x003D0D76
		public TTrapDefenseConditionStepUnion()
		{
			this.Type = TTrapDefenseConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF90 RID: 110480 RVA: 0x003D2B8C File Offset: 0x003D0D8C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF91 RID: 110481 RVA: 0x003D2B9E File Offset: 0x003D0D9E
		public ITrapDefenseConditionStepLoadAndRestoreMapT AsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.As<ITrapDefenseConditionStepLoadAndRestoreMapT>();
		}

		// Token: 0x0601AF92 RID: 110482 RVA: 0x003D2BA6 File Offset: 0x003D0DA6
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepLoadAndRestoreMap(ITrapDefenseConditionStepLoadAndRestoreMapT _itrapdefenseconditionsteploadandrestoremap)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepLoadAndRestoreMap,
				Value = _itrapdefenseconditionsteploadandrestoremap
			};
		}

		// Token: 0x0601AF93 RID: 110483 RVA: 0x003D2BBB File Offset: 0x003D0DBB
		public ITrapDefenseConditionStepMapChangeT AsITrapDefenseConditionStepMapChange()
		{
			return this.As<ITrapDefenseConditionStepMapChangeT>();
		}

		// Token: 0x0601AF94 RID: 110484 RVA: 0x003D2BC3 File Offset: 0x003D0DC3
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepMapChange(ITrapDefenseConditionStepMapChangeT _itrapdefenseconditionstepmapchange)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepMapChange,
				Value = _itrapdefenseconditionstepmapchange
			};
		}

		// Token: 0x0601AF95 RID: 110485 RVA: 0x003D2BD8 File Offset: 0x003D0DD8
		public ITrapDefenseConditionStepPreviewT AsITrapDefenseConditionStepPreview()
		{
			return this.As<ITrapDefenseConditionStepPreviewT>();
		}

		// Token: 0x0601AF96 RID: 110486 RVA: 0x003D2BE0 File Offset: 0x003D0DE0
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepPreview(ITrapDefenseConditionStepPreviewT _itrapdefenseconditionsteppreview)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepPreview,
				Value = _itrapdefenseconditionsteppreview
			};
		}

		// Token: 0x0601AF97 RID: 110487 RVA: 0x003D2BF5 File Offset: 0x003D0DF5
		public ITrapDefenseConditionStepRewardT AsITrapDefenseConditionStepReward()
		{
			return this.As<ITrapDefenseConditionStepRewardT>();
		}

		// Token: 0x0601AF98 RID: 110488 RVA: 0x003D2BFD File Offset: 0x003D0DFD
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepReward(ITrapDefenseConditionStepRewardT _itrapdefenseconditionstepreward)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepReward,
				Value = _itrapdefenseconditionstepreward
			};
		}

		// Token: 0x0601AF99 RID: 110489 RVA: 0x003D2C12 File Offset: 0x003D0E12
		public ITrapDefenseConditionStepSpawnMonsterT AsITrapDefenseConditionStepSpawnMonster()
		{
			return this.As<ITrapDefenseConditionStepSpawnMonsterT>();
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x003D2C1A File Offset: 0x003D0E1A
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepSpawnMonster(ITrapDefenseConditionStepSpawnMonsterT _itrapdefenseconditionstepspawnmonster)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepSpawnMonster,
				Value = _itrapdefenseconditionstepspawnmonster
			};
		}

		// Token: 0x0601AF9B RID: 110491 RVA: 0x003D2C30 File Offset: 0x003D0E30
		public static int Pack(FlatBufferBuilder builder, TTrapDefenseConditionStepUnion _o)
		{
			switch (_o.Type)
			{
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepLoadAndRestoreMap:
				return ITrapDefenseConditionStepLoadAndRestoreMap.Pack(builder, _o.AsITrapDefenseConditionStepLoadAndRestoreMap()).Value;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepMapChange:
				return ITrapDefenseConditionStepMapChange.Pack(builder, _o.AsITrapDefenseConditionStepMapChange()).Value;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepPreview:
				return ITrapDefenseConditionStepPreview.Pack(builder, _o.AsITrapDefenseConditionStepPreview()).Value;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepReward:
				return ITrapDefenseConditionStepReward.Pack(builder, _o.AsITrapDefenseConditionStepReward()).Value;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepSpawnMonster:
				return ITrapDefenseConditionStepSpawnMonster.Pack(builder, _o.AsITrapDefenseConditionStepSpawnMonster()).Value;
			default:
				return 0;
			}
		}
	}
}
