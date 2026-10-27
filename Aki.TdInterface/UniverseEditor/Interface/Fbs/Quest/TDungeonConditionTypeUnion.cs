using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CA RID: 17098
	public class TDungeonConditionTypeUnion
	{
		// Token: 0x1700793E RID: 31038
		// (get) Token: 0x060195C1 RID: 103873 RVA: 0x003A3934 File Offset: 0x003A1B34
		// (set) Token: 0x060195C2 RID: 103874 RVA: 0x003A393C File Offset: 0x003A1B3C
		public TDungeonConditionType Type { get; set; }

		// Token: 0x1700793F RID: 31039
		// (get) Token: 0x060195C3 RID: 103875 RVA: 0x003A3945 File Offset: 0x003A1B45
		// (set) Token: 0x060195C4 RID: 103876 RVA: 0x003A394D File Offset: 0x003A1B4D
		public object Value { get; set; }

		// Token: 0x060195C5 RID: 103877 RVA: 0x003A3956 File Offset: 0x003A1B56
		public TDungeonConditionTypeUnion()
		{
			this.Type = TDungeonConditionType.NONE;
			this.Value = null;
		}

		// Token: 0x060195C6 RID: 103878 RVA: 0x003A396C File Offset: 0x003A1B6C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060195C7 RID: 103879 RVA: 0x003A397E File Offset: 0x003A1B7E
		public IDungeonIdConditionT AsIDungeonIdCondition()
		{
			return this.As<IDungeonIdConditionT>();
		}

		// Token: 0x060195C8 RID: 103880 RVA: 0x003A3986 File Offset: 0x003A1B86
		public static TDungeonConditionTypeUnion FromIDungeonIdCondition(IDungeonIdConditionT _idungeonidcondition)
		{
			return new TDungeonConditionTypeUnion
			{
				Type = TDungeonConditionType.IDungeonIdCondition,
				Value = _idungeonidcondition
			};
		}

		// Token: 0x060195C9 RID: 103881 RVA: 0x003A399B File Offset: 0x003A1B9B
		public IDungeonSubTypeConditionT AsIDungeonSubTypeCondition()
		{
			return this.As<IDungeonSubTypeConditionT>();
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x003A39A3 File Offset: 0x003A1BA3
		public static TDungeonConditionTypeUnion FromIDungeonSubTypeCondition(IDungeonSubTypeConditionT _idungeonsubtypecondition)
		{
			return new TDungeonConditionTypeUnion
			{
				Type = TDungeonConditionType.IDungeonSubTypeCondition,
				Value = _idungeonsubtypecondition
			};
		}

		// Token: 0x060195CB RID: 103883 RVA: 0x003A39B8 File Offset: 0x003A1BB8
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
