using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200461E RID: 17950
	public class TTrapDefenseSpawnMonsterConditionUnion
	{
		// Token: 0x17007F73 RID: 32627
		// (get) Token: 0x0601B307 RID: 111367 RVA: 0x003DF52C File Offset: 0x003DD72C
		// (set) Token: 0x0601B308 RID: 111368 RVA: 0x003DF534 File Offset: 0x003DD734
		public TTrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x17007F74 RID: 32628
		// (get) Token: 0x0601B309 RID: 111369 RVA: 0x003DF53D File Offset: 0x003DD73D
		// (set) Token: 0x0601B30A RID: 111370 RVA: 0x003DF545 File Offset: 0x003DD745
		public object Value { get; set; }

		// Token: 0x0601B30B RID: 111371 RVA: 0x003DF54E File Offset: 0x003DD74E
		public TTrapDefenseSpawnMonsterConditionUnion()
		{
			this.Type = TTrapDefenseSpawnMonsterCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601B30C RID: 111372 RVA: 0x003DF564 File Offset: 0x003DD764
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B30D RID: 111373 RVA: 0x003DF576 File Offset: 0x003DD776
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT>();
		}

		// Token: 0x0601B30E RID: 111374 RVA: 0x003DF57E File Offset: 0x003DD77E
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _itrapdefensespawnmonsterconditionallopenediscompletion)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion,
				Value = _itrapdefensespawnmonsterconditionallopenediscompletion
			};
		}

		// Token: 0x0601B30F RID: 111375 RVA: 0x003DF593 File Offset: 0x003DD793
		public ITrapDefenseSpawnMonsterConditionCompletedT AsITrapDefenseSpawnMonsterConditionCompleted()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionCompletedT>();
		}

		// Token: 0x0601B310 RID: 111376 RVA: 0x003DF59B File Offset: 0x003DD79B
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionCompleted(ITrapDefenseSpawnMonsterConditionCompletedT _itrapdefensespawnmonsterconditioncompleted)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionCompleted,
				Value = _itrapdefensespawnmonsterconditioncompleted
			};
		}

		// Token: 0x0601B311 RID: 111377 RVA: 0x003DF5B0 File Offset: 0x003DD7B0
		public ITrapDefenseSpawnMonsterConditionOpenT AsITrapDefenseSpawnMonsterConditionOpen()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionOpenT>();
		}

		// Token: 0x0601B312 RID: 111378 RVA: 0x003DF5B8 File Offset: 0x003DD7B8
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionOpen(ITrapDefenseSpawnMonsterConditionOpenT _itrapdefensespawnmonsterconditionopen)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionOpen,
				Value = _itrapdefensespawnmonsterconditionopen
			};
		}

		// Token: 0x0601B313 RID: 111379 RVA: 0x003DF5D0 File Offset: 0x003DD7D0
		public static int Pack(FlatBufferBuilder builder, TTrapDefenseSpawnMonsterConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion:
				return ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()).Value;
			case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionCompleted:
				return ITrapDefenseSpawnMonsterConditionCompleted.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionCompleted()).Value;
			case TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionOpen:
				return ITrapDefenseSpawnMonsterConditionOpen.Pack(builder, _o.AsITrapDefenseSpawnMonsterConditionOpen()).Value;
			default:
				return 0;
			}
		}
	}
}
