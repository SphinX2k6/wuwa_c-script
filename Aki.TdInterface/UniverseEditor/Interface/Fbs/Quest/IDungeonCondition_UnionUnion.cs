using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004221 RID: 16929
	public class IDungeonCondition_UnionUnion
	{
		// Token: 0x17007351 RID: 29521
		// (get) Token: 0x06017854 RID: 96340 RVA: 0x0035B96C File Offset: 0x00359B6C
		// (set) Token: 0x06017855 RID: 96341 RVA: 0x0035B974 File Offset: 0x00359B74
		public IDungeonCondition_Union Type { get; set; }

		// Token: 0x17007352 RID: 29522
		// (get) Token: 0x06017856 RID: 96342 RVA: 0x0035B97D File Offset: 0x00359B7D
		// (set) Token: 0x06017857 RID: 96343 RVA: 0x0035B985 File Offset: 0x00359B85
		public object Value { get; set; }

		// Token: 0x06017858 RID: 96344 RVA: 0x0035B98E File Offset: 0x00359B8E
		public IDungeonCondition_UnionUnion()
		{
			this.Type = IDungeonCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017859 RID: 96345 RVA: 0x0035B9A4 File Offset: 0x00359BA4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601785A RID: 96346 RVA: 0x0035B9B6 File Offset: 0x00359BB6
		public IDungeonConditionT AsIDungeonCondition()
		{
			return this.As<IDungeonConditionT>();
		}

		// Token: 0x0601785B RID: 96347 RVA: 0x0035B9BE File Offset: 0x00359BBE
		public static IDungeonCondition_UnionUnion FromIDungeonCondition(IDungeonConditionT _idungeoncondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonCondition,
				Value = _idungeoncondition
			};
		}

		// Token: 0x0601785C RID: 96348 RVA: 0x0035B9D3 File Offset: 0x00359BD3
		public IDungeonIdConditionT AsIDungeonIdCondition()
		{
			return this.As<IDungeonIdConditionT>();
		}

		// Token: 0x0601785D RID: 96349 RVA: 0x0035B9DB File Offset: 0x00359BDB
		public static IDungeonCondition_UnionUnion FromIDungeonIdCondition(IDungeonIdConditionT _idungeonidcondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonIdCondition,
				Value = _idungeonidcondition
			};
		}

		// Token: 0x0601785E RID: 96350 RVA: 0x0035B9F0 File Offset: 0x00359BF0
		public IDungeonSubTypeConditionT AsIDungeonSubTypeCondition()
		{
			return this.As<IDungeonSubTypeConditionT>();
		}

		// Token: 0x0601785F RID: 96351 RVA: 0x0035B9F8 File Offset: 0x00359BF8
		public static IDungeonCondition_UnionUnion FromIDungeonSubTypeCondition(IDungeonSubTypeConditionT _idungeonsubtypecondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonSubTypeCondition,
				Value = _idungeonsubtypecondition
			};
		}

		// Token: 0x06017860 RID: 96352 RVA: 0x0035BA10 File Offset: 0x00359C10
		public static int Pack(FlatBufferBuilder builder, IDungeonCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDungeonCondition_Union.IDungeonCondition:
				return IDungeonCondition.Pack(builder, _o.AsIDungeonCondition()).Value;
			case IDungeonCondition_Union.IDungeonIdCondition:
				return IDungeonIdCondition.Pack(builder, _o.AsIDungeonIdCondition()).Value;
			case IDungeonCondition_Union.IDungeonSubTypeCondition:
				return IDungeonSubTypeCondition.Pack(builder, _o.AsIDungeonSubTypeCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
