using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004729 RID: 18217
	public class TDungeonConditionTypeUnion
	{
		// Token: 0x17007F71 RID: 32625
		// (get) Token: 0x0601AD41 RID: 109889 RVA: 0x003CF21A File Offset: 0x003CD41A
		// (set) Token: 0x0601AD42 RID: 109890 RVA: 0x003CF222 File Offset: 0x003CD422
		public TDungeonConditionType Type { get; set; }

		// Token: 0x17007F72 RID: 32626
		// (get) Token: 0x0601AD43 RID: 109891 RVA: 0x003CF22B File Offset: 0x003CD42B
		// (set) Token: 0x0601AD44 RID: 109892 RVA: 0x003CF233 File Offset: 0x003CD433
		public object Value { get; set; }

		// Token: 0x0601AD45 RID: 109893 RVA: 0x003CF23C File Offset: 0x003CD43C
		public TDungeonConditionTypeUnion()
		{
			this.Type = TDungeonConditionType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD46 RID: 109894 RVA: 0x003CF252 File Offset: 0x003CD452
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD47 RID: 109895 RVA: 0x003CF264 File Offset: 0x003CD464
		public IDungeonIdConditionT AsIDungeonIdCondition()
		{
			return this.As<IDungeonIdConditionT>();
		}

		// Token: 0x0601AD48 RID: 109896 RVA: 0x003CF26C File Offset: 0x003CD46C
		public static TDungeonConditionTypeUnion FromIDungeonIdCondition(IDungeonIdConditionT _idungeonidcondition)
		{
			return new TDungeonConditionTypeUnion
			{
				Type = TDungeonConditionType.IDungeonIdCondition,
				Value = _idungeonidcondition
			};
		}

		// Token: 0x0601AD49 RID: 109897 RVA: 0x003CF281 File Offset: 0x003CD481
		public IDungeonSubTypeConditionT AsIDungeonSubTypeCondition()
		{
			return this.As<IDungeonSubTypeConditionT>();
		}

		// Token: 0x0601AD4A RID: 109898 RVA: 0x003CF289 File Offset: 0x003CD489
		public static TDungeonConditionTypeUnion FromIDungeonSubTypeCondition(IDungeonSubTypeConditionT _idungeonsubtypecondition)
		{
			return new TDungeonConditionTypeUnion
			{
				Type = TDungeonConditionType.IDungeonSubTypeCondition,
				Value = _idungeonsubtypecondition
			};
		}

		// Token: 0x0601AD4B RID: 109899 RVA: 0x003CF2A0 File Offset: 0x003CD4A0
		public static int Pack(FlatBufferBuilder builder, TDungeonConditionTypeUnion _o)
		{
			TDungeonConditionType type = _o.Type;
			if (type == TDungeonConditionType.IDungeonIdCondition)
			{
				return IDungeonIdCondition.Pack(builder, _o.AsIDungeonIdCondition()).Value;
			}
			if (type != TDungeonConditionType.IDungeonSubTypeCondition)
			{
				return 0;
			}
			return IDungeonSubTypeCondition.Pack(builder, _o.AsIDungeonSubTypeCondition()).Value;
		}
	}
}
