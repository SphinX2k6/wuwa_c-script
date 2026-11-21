using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004683 RID: 18051
	public class ITrapDefenseConditionStepBase_UnionUnion
	{
		// Token: 0x17007E7B RID: 32379
		// (get) Token: 0x0601A7FC RID: 108540 RVA: 0x003C5A19 File Offset: 0x003C3C19
		// (set) Token: 0x0601A7FD RID: 108541 RVA: 0x003C5A21 File Offset: 0x003C3C21
		public ITrapDefenseConditionStepBase_Union Type { get; set; }

		// Token: 0x17007E7C RID: 32380
		// (get) Token: 0x0601A7FE RID: 108542 RVA: 0x003C5A2A File Offset: 0x003C3C2A
		// (set) Token: 0x0601A7FF RID: 108543 RVA: 0x003C5A32 File Offset: 0x003C3C32
		public object Value { get; set; }

		// Token: 0x0601A800 RID: 108544 RVA: 0x003C5A3B File Offset: 0x003C3C3B
		public ITrapDefenseConditionStepBase_UnionUnion()
		{
			this.Type = ITrapDefenseConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A801 RID: 108545 RVA: 0x003C5A51 File Offset: 0x003C3C51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A802 RID: 108546 RVA: 0x003C5A63 File Offset: 0x003C3C63
		public ITrapDefenseConditionStepBaseT AsITrapDefenseConditionStepBase()
		{
			return this.As<ITrapDefenseConditionStepBaseT>();
		}

		// Token: 0x0601A803 RID: 108547 RVA: 0x003C5A6B File Offset: 0x003C3C6B
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepBase(ITrapDefenseConditionStepBaseT _itrapdefenseconditionstepbase)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepBase,
				Value = _itrapdefenseconditionstepbase
			};
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x003C5A80 File Offset: 0x003C3C80
		public ITrapDefenseConditionStepRewardT AsITrapDefenseConditionStepReward()
		{
			return this.As<ITrapDefenseConditionStepRewardT>();
		}

		// Token: 0x0601A805 RID: 108549 RVA: 0x003C5A88 File Offset: 0x003C3C88
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepReward(ITrapDefenseConditionStepRewardT _itrapdefenseconditionstepreward)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepReward,
				Value = _itrapdefenseconditionstepreward
			};
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x003C5A9D File Offset: 0x003C3C9D
		public ITrapDefenseConditionStepMapChangeT AsITrapDefenseConditionStepMapChange()
		{
			return this.As<ITrapDefenseConditionStepMapChangeT>();
		}

		// Token: 0x0601A807 RID: 108551 RVA: 0x003C5AA5 File Offset: 0x003C3CA5
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepMapChange(ITrapDefenseConditionStepMapChangeT _itrapdefenseconditionstepmapchange)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepMapChange,
				Value = _itrapdefenseconditionstepmapchange
			};
		}

		// Token: 0x0601A808 RID: 108552 RVA: 0x003C5ABA File Offset: 0x003C3CBA
		public ITrapDefenseConditionStepPreviewT AsITrapDefenseConditionStepPreview()
		{
			return this.As<ITrapDefenseConditionStepPreviewT>();
		}

		// Token: 0x0601A809 RID: 108553 RVA: 0x003C5AC2 File Offset: 0x003C3CC2
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepPreview(ITrapDefenseConditionStepPreviewT _itrapdefenseconditionsteppreview)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepPreview,
				Value = _itrapdefenseconditionsteppreview
			};
		}

		// Token: 0x0601A80A RID: 108554 RVA: 0x003C5AD7 File Offset: 0x003C3CD7
		public ITrapDefenseConditionStepSpawnMonsterT AsITrapDefenseConditionStepSpawnMonster()
		{
			return this.As<ITrapDefenseConditionStepSpawnMonsterT>();
		}

		// Token: 0x0601A80B RID: 108555 RVA: 0x003C5ADF File Offset: 0x003C3CDF
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepSpawnMonster(ITrapDefenseConditionStepSpawnMonsterT _itrapdefenseconditionstepspawnmonster)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepSpawnMonster,
				Value = _itrapdefenseconditionstepspawnmonster
			};
		}

		// Token: 0x0601A80C RID: 108556 RVA: 0x003C5AF4 File Offset: 0x003C3CF4
		public ITrapDefenseConditionStepLoadAndRestoreMapT AsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.As<ITrapDefenseConditionStepLoadAndRestoreMapT>();
		}

		// Token: 0x0601A80D RID: 108557 RVA: 0x003C5AFC File Offset: 0x003C3CFC
		public static ITrapDefenseConditionStepBase_UnionUnion FromITrapDefenseConditionStepLoadAndRestoreMap(ITrapDefenseConditionStepLoadAndRestoreMapT _itrapdefenseconditionsteploadandrestoremap)
		{
			return new ITrapDefenseConditionStepBase_UnionUnion
			{
				Type = ITrapDefenseConditionStepBase_Union.ITrapDefenseConditionStepLoadAndRestoreMap,
				Value = _itrapdefenseconditionsteploadandrestoremap
			};
		}

		// Token: 0x0601A80E RID: 108558 RVA: 0x003C5B14 File Offset: 0x003C3D14
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
