using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A86 RID: 19078
	public class TTrapDefenseSpawnMonsterConditionUnion
	{
		// Token: 0x170085B4 RID: 34228
		// (get) Token: 0x0601CADC RID: 117468 RVA: 0x0040B7C8 File Offset: 0x004099C8
		// (set) Token: 0x0601CADD RID: 117469 RVA: 0x0040B7D0 File Offset: 0x004099D0
		public TTrapDefenseSpawnMonsterCondition Type { get; set; }

		// Token: 0x170085B5 RID: 34229
		// (get) Token: 0x0601CADE RID: 117470 RVA: 0x0040B7D9 File Offset: 0x004099D9
		// (set) Token: 0x0601CADF RID: 117471 RVA: 0x0040B7E1 File Offset: 0x004099E1
		public object Value { get; set; }

		// Token: 0x0601CAE0 RID: 117472 RVA: 0x0040B7EA File Offset: 0x004099EA
		public TTrapDefenseSpawnMonsterConditionUnion()
		{
			this.Type = TTrapDefenseSpawnMonsterCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601CAE1 RID: 117473 RVA: 0x0040B800 File Offset: 0x00409A00
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAE2 RID: 117474 RVA: 0x0040B812 File Offset: 0x00409A12
		public ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT AsITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT>();
		}

		// Token: 0x0601CAE3 RID: 117475 RVA: 0x0040B81A File Offset: 0x00409A1A
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion(ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionT _itrapdefensespawnmonsterconditionallopenediscompletion)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletion,
				Value = _itrapdefensespawnmonsterconditionallopenediscompletion
			};
		}

		// Token: 0x0601CAE4 RID: 117476 RVA: 0x0040B82F File Offset: 0x00409A2F
		public ITrapDefenseSpawnMonsterConditionCompletedT AsITrapDefenseSpawnMonsterConditionCompleted()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionCompletedT>();
		}

		// Token: 0x0601CAE5 RID: 117477 RVA: 0x0040B837 File Offset: 0x00409A37
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionCompleted(ITrapDefenseSpawnMonsterConditionCompletedT _itrapdefensespawnmonsterconditioncompleted)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionCompleted,
				Value = _itrapdefensespawnmonsterconditioncompleted
			};
		}

		// Token: 0x0601CAE6 RID: 117478 RVA: 0x0040B84C File Offset: 0x00409A4C
		public ITrapDefenseSpawnMonsterConditionOpenT AsITrapDefenseSpawnMonsterConditionOpen()
		{
			return this.As<ITrapDefenseSpawnMonsterConditionOpenT>();
		}

		// Token: 0x0601CAE7 RID: 117479 RVA: 0x0040B854 File Offset: 0x00409A54
		public static TTrapDefenseSpawnMonsterConditionUnion FromITrapDefenseSpawnMonsterConditionOpen(ITrapDefenseSpawnMonsterConditionOpenT _itrapdefensespawnmonsterconditionopen)
		{
			return new TTrapDefenseSpawnMonsterConditionUnion
			{
				Type = TTrapDefenseSpawnMonsterCondition.ITrapDefenseSpawnMonsterConditionOpen,
				Value = _itrapdefensespawnmonsterconditionopen
			};
		}

		// Token: 0x0601CAE8 RID: 117480 RVA: 0x0040B86C File Offset: 0x00409A6C
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
