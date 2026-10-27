using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C4 RID: 17860
	public class ITrapDefenseSpawnMonsterConditionBase_UnionUnion
	{
		// Token: 0x17007EF2 RID: 32498
		// (get) Token: 0x0601B031 RID: 110641 RVA: 0x003D9CA5 File Offset: 0x003D7EA5
		// (set) Token: 0x0601B032 RID: 110642 RVA: 0x003D9CAD File Offset: 0x003D7EAD
		public ITrapDefenseSpawnMonsterConditionBase_Union Type { get; set; }

		// Token: 0x17007EF3 RID: 32499
		// (get) Token: 0x0601B033 RID: 110643 RVA: 0x003D9CB6 File Offset: 0x003D7EB6
		// (set) Token: 0x0601B034 RID: 110644 RVA: 0x003D9CBE File Offset: 0x003D7EBE
		public object Value { get; set; }

		// Token: 0x0601B035 RID: 110645 RVA: 0x003D9CC7 File Offset: 0x003D7EC7
		public ITrapDefenseSpawnMonsterConditionBase_UnionUnion()
		{
			this.Type = ITrapDefenseSpawnMonsterConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B036 RID: 110646 RVA: 0x003D9CDD File Offset: 0x003D7EDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B037 RID: 110647 RVA: 0x003D9CEF File Offset: 0x003D7EEF
		public ITrapDefenseSpawnMonsterConditionBaseT AsITrapDefenseSpawnMonsterConditionBase()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionBaseT>();
		}

		// Token: 0x0601B038 RID: 110648 RVA: 0x003D9CF7 File Offset: 0x003D7EF7
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionBase(ITrapDefenseSpawnMonsterConditionBaseT _itrapdefensespawnmonsterconditionbase)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionBase,
				Value = _itrapdefensespawnmonsterconditionbase
			};
		}

		// Token: 0x0601B039 RID: 110649 RVA: 0x003D9D0C File Offset: 0x003D7F0C
		public ITrapDefenseSpawnMonsterConditionCompletedT AsITrapDefenseSpawnMonsterConditionCompleted()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionCompletedT>();
		}

		// Token: 0x0601B03A RID: 110650 RVA: 0x003D9D14 File Offset: 0x003D7F14
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionCompleted(ITrapDefenseSpawnMonsterConditionCompletedT _itrapdefensespawnmonsterconditioncompleted)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionCompleted,
				Value = _itrapdefensespawnmonsterconditioncompleted
			};
		}

		// Token: 0x0601B03B RID: 110651 RVA: 0x003D9D29 File Offset: 0x003D7F29
		public ITrapDefenseSpawnMonsterConditionOpenT AsITrapDefenseSpawnMonsterConditionOpen()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionOpenT>();
		}

		// Token: 0x0601B03C RID: 110652 RVA: 0x003D9D31 File Offset: 0x003D7F31
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionOpen(ITrapDefenseSpawnMonsterConditionOpenT _itrapdefensespawnmonsterconditionopen)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionOpen,
				Value = _itrapdefensespawnmonsterconditionopen
			};
		}

		// Token: 0x0601B03D RID: 110653 RVA: 0x003D9D46 File Offset: 0x003D7F46
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT>();
		}

		// Token: 0x0601B03E RID: 110654 RVA: 0x003D9D4E File Offset: 0x003D7F4E
		public static ITrapDefenseSpawnMonsterConditionBase_UnionUnion FromITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _itrapdefensespawnmonsterconditionallopenediscompletion)
		{
			return new ITrapDefenseSpawnMonsterConditionBase_UnionUnion
			{
				Type = ITrapDefenseSpawnMonsterConditionBase_Union.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion,
				Value = _itrapdefensespawnmonsterconditionallopenediscompletion
			};
		}

		// Token: 0x0601B03F RID: 110655 RVA: 0x003D9D64 File Offset: 0x003D7F64
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
