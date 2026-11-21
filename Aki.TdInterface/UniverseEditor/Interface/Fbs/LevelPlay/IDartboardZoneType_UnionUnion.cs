using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D0 RID: 18640
	public class IDartboardZoneType_UnionUnion
	{
		// Token: 0x170081D2 RID: 33234
		// (get) Token: 0x0601B955 RID: 112981 RVA: 0x003E6981 File Offset: 0x003E4B81
		// (set) Token: 0x0601B956 RID: 112982 RVA: 0x003E6989 File Offset: 0x003E4B89
		public IDartboardZoneType_Union Type { get; set; }

		// Token: 0x170081D3 RID: 33235
		// (get) Token: 0x0601B957 RID: 112983 RVA: 0x003E6992 File Offset: 0x003E4B92
		// (set) Token: 0x0601B958 RID: 112984 RVA: 0x003E699A File Offset: 0x003E4B9A
		public object Value { get; set; }

		// Token: 0x0601B959 RID: 112985 RVA: 0x003E69A3 File Offset: 0x003E4BA3
		public IDartboardZoneType_UnionUnion()
		{
			this.Type = IDartboardZoneType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x003E69B9 File Offset: 0x003E4BB9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x003E69CB File Offset: 0x003E4BCB
		public IDartboardZoneTypeT AsIDartboardZoneType()
		{
			return this.As<IDartboardZoneTypeT>();
		}

		// Token: 0x0601B95C RID: 112988 RVA: 0x003E69D3 File Offset: 0x003E4BD3
		public static IDartboardZoneType_UnionUnion FromIDartboardZoneType(IDartboardZoneTypeT _idartboardzonetype)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IDartboardZoneType,
				Value = _idartboardzonetype
			};
		}

		// Token: 0x0601B95D RID: 112989 RVA: 0x003E69E8 File Offset: 0x003E4BE8
		public ICenterBullZoneT AsICenterBullZone()
		{
			return this.As<ICenterBullZoneT>();
		}

		// Token: 0x0601B95E RID: 112990 RVA: 0x003E69F0 File Offset: 0x003E4BF0
		public static IDartboardZoneType_UnionUnion FromICenterBullZone(ICenterBullZoneT _icenterbullzone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ICenterBullZone,
				Value = _icenterbullzone
			};
		}

		// Token: 0x0601B95F RID: 112991 RVA: 0x003E6A05 File Offset: 0x003E4C05
		public IOuterBullZoneT AsIOuterBullZone()
		{
			return this.As<IOuterBullZoneT>();
		}

		// Token: 0x0601B960 RID: 112992 RVA: 0x003E6A0D File Offset: 0x003E4C0D
		public static IDartboardZoneType_UnionUnion FromIOuterBullZone(IOuterBullZoneT _iouterbullzone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IOuterBullZone,
				Value = _iouterbullzone
			};
		}

		// Token: 0x0601B961 RID: 112993 RVA: 0x003E6A22 File Offset: 0x003E4C22
		public ISingleScoreZoneT AsISingleScoreZone()
		{
			return this.As<ISingleScoreZoneT>();
		}

		// Token: 0x0601B962 RID: 112994 RVA: 0x003E6A2A File Offset: 0x003E4C2A
		public static IDartboardZoneType_UnionUnion FromISingleScoreZone(ISingleScoreZoneT _isinglescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ISingleScoreZone,
				Value = _isinglescorezone
			};
		}

		// Token: 0x0601B963 RID: 112995 RVA: 0x003E6A3F File Offset: 0x003E4C3F
		public IDoubleScoreZoneT AsIDoubleScoreZone()
		{
			return this.As<IDoubleScoreZoneT>();
		}

		// Token: 0x0601B964 RID: 112996 RVA: 0x003E6A47 File Offset: 0x003E4C47
		public static IDartboardZoneType_UnionUnion FromIDoubleScoreZone(IDoubleScoreZoneT _idoublescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IDoubleScoreZone,
				Value = _idoublescorezone
			};
		}

		// Token: 0x0601B965 RID: 112997 RVA: 0x003E6A5C File Offset: 0x003E4C5C
		public ITripleScoreZoneT AsITripleScoreZone()
		{
			return this.As<ITripleScoreZoneT>();
		}

		// Token: 0x0601B966 RID: 112998 RVA: 0x003E6A64 File Offset: 0x003E4C64
		public static IDartboardZoneType_UnionUnion FromITripleScoreZone(ITripleScoreZoneT _itriplescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ITripleScoreZone,
				Value = _itriplescorezone
			};
		}

		// Token: 0x0601B967 RID: 112999 RVA: 0x003E6A7C File Offset: 0x003E4C7C
		public static int Pack(FlatBufferBuilder builder, IDartboardZoneType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDartboardZoneType_Union.IDartboardZoneType:
				return IDartboardZoneType.Pack(builder, _o.AsIDartboardZoneType()).Value;
			case IDartboardZoneType_Union.ICenterBullZone:
				return ICenterBullZone.Pack(builder, _o.AsICenterBullZone()).Value;
			case IDartboardZoneType_Union.IOuterBullZone:
				return IOuterBullZone.Pack(builder, _o.AsIOuterBullZone()).Value;
			case IDartboardZoneType_Union.ISingleScoreZone:
				return ISingleScoreZone.Pack(builder, _o.AsISingleScoreZone()).Value;
			case IDartboardZoneType_Union.IDoubleScoreZone:
				return IDoubleScoreZone.Pack(builder, _o.AsIDoubleScoreZone()).Value;
			case IDartboardZoneType_Union.ITripleScoreZone:
				return ITripleScoreZone.Pack(builder, _o.AsITripleScoreZone()).Value;
			default:
				return 0;
			}
		}
	}
}
