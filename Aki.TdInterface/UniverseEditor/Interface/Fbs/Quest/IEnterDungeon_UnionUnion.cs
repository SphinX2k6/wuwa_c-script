using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423F RID: 16959
	public class IEnterDungeon_UnionUnion
	{
		// Token: 0x1700739B RID: 29595
		// (get) Token: 0x0601797A RID: 96634 RVA: 0x0035D9F6 File Offset: 0x0035BBF6
		// (set) Token: 0x0601797B RID: 96635 RVA: 0x0035D9FE File Offset: 0x0035BBFE
		public IEnterDungeon_Union Type { get; set; }

		// Token: 0x1700739C RID: 29596
		// (get) Token: 0x0601797C RID: 96636 RVA: 0x0035DA07 File Offset: 0x0035BC07
		// (set) Token: 0x0601797D RID: 96637 RVA: 0x0035DA0F File Offset: 0x0035BC0F
		public object Value { get; set; }

		// Token: 0x0601797E RID: 96638 RVA: 0x0035DA18 File Offset: 0x0035BC18
		public IEnterDungeon_UnionUnion()
		{
			this.Type = IEnterDungeon_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601797F RID: 96639 RVA: 0x0035DA2E File Offset: 0x0035BC2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017980 RID: 96640 RVA: 0x0035DA40 File Offset: 0x0035BC40
		public IEnterDungeonT AsIEnterDungeon()
		{
			return this.As<IEnterDungeonT>();
		}

		// Token: 0x06017981 RID: 96641 RVA: 0x0035DA48 File Offset: 0x0035BC48
		public static IEnterDungeon_UnionUnion FromIEnterDungeon(IEnterDungeonT _ienterdungeon)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeon,
				Value = _ienterdungeon
			};
		}

		// Token: 0x06017982 RID: 96642 RVA: 0x0035DA5D File Offset: 0x0035BC5D
		public IEnterDungeonIdConditionT AsIEnterDungeonIdCondition()
		{
			return this.As<IEnterDungeonIdConditionT>();
		}

		// Token: 0x06017983 RID: 96643 RVA: 0x0035DA65 File Offset: 0x0035BC65
		public static IEnterDungeon_UnionUnion FromIEnterDungeonIdCondition(IEnterDungeonIdConditionT _ienterdungeonidcondition)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeonIdCondition,
				Value = _ienterdungeonidcondition
			};
		}

		// Token: 0x06017984 RID: 96644 RVA: 0x0035DA7A File Offset: 0x0035BC7A
		public IEnterDungeonSubTypeConditionT AsIEnterDungeonSubTypeCondition()
		{
			return this.As<IEnterDungeonSubTypeConditionT>();
		}

		// Token: 0x06017985 RID: 96645 RVA: 0x0035DA82 File Offset: 0x0035BC82
		public static IEnterDungeon_UnionUnion FromIEnterDungeonSubTypeCondition(IEnterDungeonSubTypeConditionT _ienterdungeonsubtypecondition)
		{
			return new IEnterDungeon_UnionUnion
			{
				Type = IEnterDungeon_Union.IEnterDungeonSubTypeCondition,
				Value = _ienterdungeonsubtypecondition
			};
		}

		// Token: 0x06017986 RID: 96646 RVA: 0x0035DA98 File Offset: 0x0035BC98
		public static int Pack(FlatBufferBuilder builder, IEnterDungeon_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnterDungeon_Union.IEnterDungeon:
				return IEnterDungeon.Pack(builder, _o.AsIEnterDungeon()).Value;
			case IEnterDungeon_Union.IEnterDungeonIdCondition:
				return IEnterDungeonIdCondition.Pack(builder, _o.AsIEnterDungeonIdCondition()).Value;
			case IEnterDungeon_Union.IEnterDungeonSubTypeCondition:
				return IEnterDungeonSubTypeCondition.Pack(builder, _o.AsIEnterDungeonSubTypeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
