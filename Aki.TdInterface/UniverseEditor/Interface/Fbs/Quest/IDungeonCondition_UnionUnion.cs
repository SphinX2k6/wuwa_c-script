using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE6 RID: 15846
	public class IDungeonCondition_UnionUnion
	{
		// Token: 0x17006D71 RID: 28017
		// (get) Token: 0x06016235 RID: 90677 RVA: 0x00332F68 File Offset: 0x00331168
		// (set) Token: 0x06016236 RID: 90678 RVA: 0x00332F70 File Offset: 0x00331170
		public IDungeonCondition_Union Type { get; set; }

		// Token: 0x17006D72 RID: 28018
		// (get) Token: 0x06016237 RID: 90679 RVA: 0x00332F79 File Offset: 0x00331179
		// (set) Token: 0x06016238 RID: 90680 RVA: 0x00332F81 File Offset: 0x00331181
		public object Value { get; set; }

		// Token: 0x06016239 RID: 90681 RVA: 0x00332F8A File Offset: 0x0033118A
		public IDungeonCondition_UnionUnion()
		{
			this.Type = IDungeonCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601623A RID: 90682 RVA: 0x00332FA0 File Offset: 0x003311A0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601623B RID: 90683 RVA: 0x00332FB2 File Offset: 0x003311B2
		public IDungeonConditionT AsIDungeonCondition()
		{
			return this.As<IDungeonConditionT>();
		}

		// Token: 0x0601623C RID: 90684 RVA: 0x00332FBA File Offset: 0x003311BA
		public static IDungeonCondition_UnionUnion FromIDungeonCondition(IDungeonConditionT _idungeoncondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonCondition,
				Value = _idungeoncondition
			};
		}

		// Token: 0x0601623D RID: 90685 RVA: 0x00332FCF File Offset: 0x003311CF
		public IDungeonIdConditionT AsIDungeonIdCondition()
		{
			return this.As<IDungeonIdConditionT>();
		}

		// Token: 0x0601623E RID: 90686 RVA: 0x00332FD7 File Offset: 0x003311D7
		public static IDungeonCondition_UnionUnion FromIDungeonIdCondition(IDungeonIdConditionT _idungeonidcondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonIdCondition,
				Value = _idungeonidcondition
			};
		}

		// Token: 0x0601623F RID: 90687 RVA: 0x00332FEC File Offset: 0x003311EC
		public IDungeonSubTypeConditionT AsIDungeonSubTypeCondition()
		{
			return this.As<IDungeonSubTypeConditionT>();
		}

		// Token: 0x06016240 RID: 90688 RVA: 0x00332FF4 File Offset: 0x003311F4
		public static IDungeonCondition_UnionUnion FromIDungeonSubTypeCondition(IDungeonSubTypeConditionT _idungeonsubtypecondition)
		{
			return new IDungeonCondition_UnionUnion
			{
				Type = IDungeonCondition_Union.IDungeonSubTypeCondition,
				Value = _idungeonsubtypecondition
			};
		}

		// Token: 0x06016241 RID: 90689 RVA: 0x0033300C File Offset: 0x0033120C
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
