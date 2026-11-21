using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A2C RID: 18988
	public class ITrapDefenseSpawnMonsterConditionBase_UnionUnion
	{
		// Token: 0x17008533 RID: 34099
		// (get) Token: 0x0601C806 RID: 116742 RVA: 0x00405F41 File Offset: 0x00404141
		// (set) Token: 0x0601C807 RID: 116743 RVA: 0x00405F49 File Offset: 0x00404149
		public ITrapDefenseSpawnMonsterConditionBase_Union Type { get; set; }

		// Token: 0x17008534 RID: 34100
		// (get) Token: 0x0601C808 RID: 116744 RVA: 0x00405F52 File Offset: 0x00404152
		// (set) Token: 0x0601C809 RID: 116745 RVA: 0x00405F5A File Offset: 0x0040415A
		public object Value { get; set; }

		// Token: 0x0601C80A RID: 116746 RVA: 0x00405F63 File Offset: 0x00404163
		public ITrapDefenseSpawnMonsterConditionBase_UnionUnion()
		{
			this.Type = ITrapDefenseSpawnMonsterConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C80B RID: 116747 RVA: 0x00405F79 File Offset: 0x00404179
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C80C RID: 116748 RVA: 0x00405F8B File Offset: 0x0040418B
		public ITrapDefenseSpawnMonsterConditionBaseT AsITrapDefenseSpawnMonsterConditionBase()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionBaseT>();
		}

		// Token: 0x0601C80D RID: 116749 RVA: 0x00405F93 File Offset: 0x00404193
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionBase(ITrapDefenseSpawnMonsterConditionBaseT _itrapdefensespawnmonsterconditionbase)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionBase,
				Value = _itrapdefensespawnmonsterconditionbase
			};
		}

		// Token: 0x0601C80E RID: 116750 RVA: 0x00405FA8 File Offset: 0x004041A8
		public ITrapDefenseSpawnMonsterConditionCompletedT AsITrapDefenseSpawnMonsterConditionCompleted()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionCompletedT>();
		}

		// Token: 0x0601C80F RID: 116751 RVA: 0x00405FB0 File Offset: 0x004041B0
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionCompleted(ITrapDefenseSpawnMonsterConditionCompletedT _itrapdefensespawnmonsterconditioncompleted)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionCompleted,
				Value = _itrapdefensespawnmonsterconditioncompleted
			};
		}

		// Token: 0x0601C810 RID: 116752 RVA: 0x00405FC5 File Offset: 0x004041C5
		public ITrapDefenseSpawnMonsterConditionOpenT AsITrapDefenseSpawnMonsterConditionOpen()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionOpenT>();
		}

		// Token: 0x0601C811 RID: 116753 RVA: 0x00405FCD File Offset: 0x004041CD
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionOpen(ITrapDefenseSpawnMonsterConditionOpenT _itrapdefensespawnmonsterconditionopen)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionOpen,
				Value = _itrapdefensespawnmonsterconditionopen
			};
		}

		// Token: 0x0601C812 RID: 116754 RVA: 0x00405FE2 File Offset: 0x004041E2
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT>();
		}

		// Token: 0x0601C813 RID: 116755 RVA: 0x00405FEA File Offset: 0x004041EA
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _itrapdefensespawnmonsterconditionallopenediscompletion)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion,
				Value = _itrapdefensespawnmonsterconditionallopenediscompletion
			};
		}

		// Token: 0x0601C814 RID: 116756 RVA: 0x00406000 File Offset: 0x00404200
		public static int Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionBase:
				return ITrapDefenseSpawnMonsterConditionBase.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionBase()).Value;
			case ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionCompleted:
				return ITrapDefenseSpawnMonsterConditionCompleted.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionCompleted()).Value;
			case ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionOpen:
				return ITrapDefenseSpawnMonsterConditionOpen.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionOpen()).Value;
			case ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion:
				return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()).Value;
			default:
				return 0;
			}
		}
	}
}
