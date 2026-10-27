using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004227 RID: 16935
	public class ITrapDefenseConditionStepBase_UnionUnion
	{
		// Token: 0x1700784A RID: 30794
		// (get) Token: 0x06019090 RID: 102544 RVA: 0x0039A341 File Offset: 0x00398541
		// (set) Token: 0x06019091 RID: 102545 RVA: 0x0039A349 File Offset: 0x00398549
		public ITrapDefenseConditionStepBase_Union Type { get; set; }

		// Token: 0x1700784B RID: 30795
		// (get) Token: 0x06019092 RID: 102546 RVA: 0x0039A352 File Offset: 0x00398552
		// (set) Token: 0x06019093 RID: 102547 RVA: 0x0039A35A File Offset: 0x0039855A
		public object Value { get; set; }

		// Token: 0x06019094 RID: 102548 RVA: 0x0039A363 File Offset: 0x00398563
		public ITrapDefenseConditionStepBase_UnionUnion()
		{
			this.Type = ITrapDefenseConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019095 RID: 102549 RVA: 0x0039A379 File Offset: 0x00398579
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019096 RID: 102550 RVA: 0x0039A38B File Offset: 0x0039858B
		public ITrapDefenseConditionStepBaseT AsITrapDefenseConditionStepBase()
		{
			return this.As<ITrapDefenseConditionStepBaseT>();
		}

		// Token: 0x06019097 RID: 102551 RVA: 0x0039A393 File Offset: 0x00398593
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepBase(ITrapDefenseConditionStepBaseT _itrapdefenseconditionstepbase)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepBase,
				Value = _itrapdefenseconditionstepbase
			};
		}

		// Token: 0x06019098 RID: 102552 RVA: 0x0039A3A8 File Offset: 0x003985A8
		public ITrapDefenseConditionStepRewardT AsITrapDefenseConditionStepReward()
		{
			return this.As<ITrapDefenseConditionStepRewardT>();
		}

		// Token: 0x06019099 RID: 102553 RVA: 0x0039A3B0 File Offset: 0x003985B0
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepReward(ITrapDefenseConditionStepRewardT _itrapdefenseconditionstepreward)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepReward,
				Value = _itrapdefenseconditionstepreward
			};
		}

		// Token: 0x0601909A RID: 102554 RVA: 0x0039A3C5 File Offset: 0x003985C5
		public ITrapDefenseConditionStepMapChangeT AsITrapDefenseConditionStepMapChange()
		{
			return this.As<ITrapDefenseConditionStepMapChangeT>();
		}

		// Token: 0x0601909B RID: 102555 RVA: 0x0039A3CD File Offset: 0x003985CD
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepMapChange(ITrapDefenseConditionStepMapChangeT _itrapdefenseconditionstepmapchange)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepMapChange,
				Value = _itrapdefenseconditionstepmapchange
			};
		}

		// Token: 0x0601909C RID: 102556 RVA: 0x0039A3E2 File Offset: 0x003985E2
		public ITrapDefenseConditionStepPreviewT AsITrapDefenseConditionStepPreview()
		{
			return this.As<ITrapDefenseConditionStepPreviewT>();
		}

		// Token: 0x0601909D RID: 102557 RVA: 0x0039A3EA File Offset: 0x003985EA
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepPreview(ITrapDefenseConditionStepPreviewT _itrapdefenseconditionsteppreview)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepPreview,
				Value = _itrapdefenseconditionsteppreview
			};
		}

		// Token: 0x0601909E RID: 102558 RVA: 0x0039A3FF File Offset: 0x003985FF
		public ITrapDefenseConditionStepSpawnMonsterT AsITrapDefenseConditionStepSpawnMonster()
		{
			return this.As<ITrapDefenseConditionStepSpawnMonsterT>();
		}

		// Token: 0x0601909F RID: 102559 RVA: 0x0039A407 File Offset: 0x00398607
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepSpawnMonster(ITrapDefenseConditionStepSpawnMonsterT _itrapdefenseconditionstepspawnmonster)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepSpawnMonster,
				Value = _itrapdefenseconditionstepspawnmonster
			};
		}

		// Token: 0x060190A0 RID: 102560 RVA: 0x0039A41C File Offset: 0x0039861C
		public ITrapDefenseConditionStepLoadAndRestoreMapT AsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.As<ITrapDefenseConditionStepLoadAndRestoreMapT>();
		}

		// Token: 0x060190A1 RID: 102561 RVA: 0x0039A424 File Offset: 0x00398624
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepLoadAndRestoreMap(ITrapDefenseConditionStepLoadAndRestoreMapT _itrapdefenseconditionsteploadandrestoremap)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepLoadAndRestoreMap,
				Value = _itrapdefenseconditionsteploadandrestoremap
			};
		}

		// Token: 0x060190A2 RID: 102562 RVA: 0x0039A43C File Offset: 0x0039863C
		public static int Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepBase:
				return ITrapDefenseConditionStepBase.Pack(builder, _o.AsITrapDefenseConditionStepBase()).Value;
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepReward:
				return ITrapDefenseConditionStepReward.Pack(builder, _o.AsITrapDefenseConditionStepReward()).Value;
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepMapChange:
				return ITrapDefenseConditionStepMapChange.Pack(builder, _o.AsITrapDefenseConditionStepMapChange()).Value;
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepPreview:
				return ITrapDefenseConditionStepPreview.Pack(builder, _o.AsITrapDefenseConditionStepPreview()).Value;
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepSpawnMonster:
				return ITrapDefenseConditionStepSpawnMonster.Pack(builder, _o.AsITrapDefenseConditionStepSpawnMonster()).Value;
			case ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepLoadAndRestoreMap:
				return ITrapDefenseConditionStepLoadAndRestoreMap.Pack(builder, _o.AsITrapDefenseConditionStepLoadAndRestoreMap()).Value;
			default:
				return 0;
			}
		}
	}
}
