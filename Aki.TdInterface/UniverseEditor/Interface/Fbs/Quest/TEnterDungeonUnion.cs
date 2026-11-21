using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200472F RID: 18223
	public class TEnterDungeonUnion
	{
		// Token: 0x17007F75 RID: 32629
		// (get) Token: 0x0601AD73 RID: 109939 RVA: 0x003CF77D File Offset: 0x003CD97D
		// (set) Token: 0x0601AD74 RID: 109940 RVA: 0x003CF785 File Offset: 0x003CD985
		public TEnterDungeon Type { get; set; }

		// Token: 0x17007F76 RID: 32630
		// (get) Token: 0x0601AD75 RID: 109941 RVA: 0x003CF78E File Offset: 0x003CD98E
		// (set) Token: 0x0601AD76 RID: 109942 RVA: 0x003CF796 File Offset: 0x003CD996
		public object Value { get; set; }

		// Token: 0x0601AD77 RID: 109943 RVA: 0x003CF79F File Offset: 0x003CD99F
		public TEnterDungeonUnion()
		{
			this.Type = TEnterDungeon.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD78 RID: 109944 RVA: 0x003CF7B5 File Offset: 0x003CD9B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD79 RID: 109945 RVA: 0x003CF7C7 File Offset: 0x003CD9C7
		public IEnterDungeonIdConditionT AsIEnterDungeonIdCondition()
		{
			return this.As<IEnterDungeonIdConditionT>();
		}

		// Token: 0x0601AD7A RID: 109946 RVA: 0x003CF7CF File Offset: 0x003CD9CF
		public static TEnterDungeonUnion FromIEnterDungeonIdCondition(IEnterDungeonIdConditionT _ienterdungeonidcondition)
		{
			return new TEnterDungeonUnion
			{
				Type = TEnterDungeon.IEnterDungeonIdCondition,
				Value = _ienterdungeonidcondition
			};
		}

		// Token: 0x0601AD7B RID: 109947 RVA: 0x003CF7E4 File Offset: 0x003CD9E4
		public IEnterDungeonSubTypeConditionT AsIEnterDungeonSubTypeCondition()
		{
			return this.As<IEnterDungeonSubTypeConditionT>();
		}

		// Token: 0x0601AD7C RID: 109948 RVA: 0x003CF7EC File Offset: 0x003CD9EC
		public static TEnterDungeonUnion FromIEnterDungeonSubTypeCondition(IEnterDungeonSubTypeConditionT _ienterdungeonsubtypecondition)
		{
			return new TEnterDungeonUnion
			{
				Type = TEnterDungeon.IEnterDungeonSubTypeCondition,
				Value = _ienterdungeonsubtypecondition
			};
		}

		// Token: 0x0601AD7D RID: 109949 RVA: 0x003CF804 File Offset: 0x003CDA04
		public static int Pack(FlatBufferBuilder builder, TEnterDungeonUnion _o)
		{
			TEnterDungeon type = _o.Type;
			if (type == TEnterDungeon.IEnterDungeonIdCondition)
			{
				return IEnterDungeonIdCondition.Pack(builder, _o.AsIEnterDungeonIdCondition()).Value;
			}
			if (type != TEnterDungeon.IEnterDungeonSubTypeCondition)
			{
				return 0;
			}
			return IEnterDungeonSubTypeCondition.Pack(builder, _o.AsIEnterDungeonSubTypeCondition()).Value;
		}
	}
}
