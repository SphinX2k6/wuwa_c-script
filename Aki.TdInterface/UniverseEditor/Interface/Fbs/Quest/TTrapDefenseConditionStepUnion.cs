using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432D RID: 17197
	public class TTrapDefenseConditionStepUnion
	{
		// Token: 0x17007980 RID: 31104
		// (get) Token: 0x060197FD RID: 104445 RVA: 0x003A712C File Offset: 0x003A532C
		// (set) Token: 0x060197FE RID: 104446 RVA: 0x003A7134 File Offset: 0x003A5334
		public TTrapDefenseConditionStep Type { get; set; }

		// Token: 0x17007981 RID: 31105
		// (get) Token: 0x060197FF RID: 104447 RVA: 0x003A713D File Offset: 0x003A533D
		// (set) Token: 0x06019800 RID: 104448 RVA: 0x003A7145 File Offset: 0x003A5345
		public object Value { get; set; }

		// Token: 0x06019801 RID: 104449 RVA: 0x003A714E File Offset: 0x003A534E
		public TTrapDefenseConditionStepUnion()
		{
			this.Type = TTrapDefenseConditionStep.NONE;
			this.Value = null;
		}

		// Token: 0x06019802 RID: 104450 RVA: 0x003A7164 File Offset: 0x003A5364
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019803 RID: 104451 RVA: 0x003A7176 File Offset: 0x003A5376
		public ITrapDefenseConditionStepLoadAndRestoreMapT AsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.As<ITrapDefenseConditionStepLoadAndRestoreMapT>();
		}

		// Token: 0x06019804 RID: 104452 RVA: 0x003A717E File Offset: 0x003A537E
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepLoadAndRestoreMap(ITrapDefenseConditionStepLoadAndRestoreMapT _itrapdefenseconditionsteploadandrestoremap)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepLoadAndRestoreMap,
				Value = _itrapdefenseconditionsteploadandrestoremap
			};
		}

		// Token: 0x06019805 RID: 104453 RVA: 0x003A7193 File Offset: 0x003A5393
		public ITrapDefenseConditionStepMapChangeT AsITrapDefenseConditionStepMapChange()
		{
			return this.As<ITrapDefenseConditionStepMapChangeT>();
		}

		// Token: 0x06019806 RID: 104454 RVA: 0x003A719B File Offset: 0x003A539B
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepMapChange(ITrapDefenseConditionStepMapChangeT _itrapdefenseconditionstepmapchange)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepMapChange,
				Value = _itrapdefenseconditionstepmapchange
			};
		}

		// Token: 0x06019807 RID: 104455 RVA: 0x003A71B0 File Offset: 0x003A53B0
		public ITrapDefenseConditionStepPreviewT AsITrapDefenseConditionStepPreview()
		{
			return this.As<ITrapDefenseConditionStepPreviewT>();
		}

		// Token: 0x06019808 RID: 104456 RVA: 0x003A71B8 File Offset: 0x003A53B8
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepPreview(ITrapDefenseConditionStepPreviewT _itrapdefenseconditionsteppreview)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepPreview,
				Value = _itrapdefenseconditionsteppreview
			};
		}

		// Token: 0x06019809 RID: 104457 RVA: 0x003A71CD File Offset: 0x003A53CD
		public ITrapDefenseConditionStepRewardT AsITrapDefenseConditionStepReward()
		{
			return this.As<ITrapDefenseConditionStepRewardT>();
		}

		// Token: 0x0601980A RID: 104458 RVA: 0x003A71D5 File Offset: 0x003A53D5
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepReward(ITrapDefenseConditionStepRewardT _itrapdefenseconditionstepreward)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepReward,
				Value = _itrapdefenseconditionstepreward
			};
		}

		// Token: 0x0601980B RID: 104459 RVA: 0x003A71EA File Offset: 0x003A53EA
		public ITrapDefenseConditionStepSpawnMonsterT AsITrapDefenseConditionStepSpawnMonster()
		{
			return this.As<ITrapDefenseConditionStepSpawnMonsterT>();
		}

		// Token: 0x0601980C RID: 104460 RVA: 0x003A71F2 File Offset: 0x003A53F2
		public static TTrapDefenseConditionStepUnion FromITrapDefenseConditionStepSpawnMonster(ITrapDefenseConditionStepSpawnMonsterT _itrapdefenseconditionstepspawnmonster)
		{
			return new TTrapDefenseConditionStepUnion
			{
				Type = TTrapDefenseConditionStep.ITrapDefenseConditionStepSpawnMonster,
				Value = _itrapdefenseconditionstepspawnmonster
			};
		}

		// Token: 0x0601980D RID: 104461 RVA: 0x003A7208 File Offset: 0x003A5408
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
