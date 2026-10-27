using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004468 RID: 17512
	public class IDartboardZoneType_UnionUnion
	{
		// Token: 0x17007B93 RID: 31635
		// (get) Token: 0x0601A184 RID: 106884 RVA: 0x003BA775 File Offset: 0x003B8975
		// (set) Token: 0x0601A185 RID: 106885 RVA: 0x003BA77D File Offset: 0x003B897D
		public IDartboardZoneType_Union Type { get; set; }

		// Token: 0x17007B94 RID: 31636
		// (get) Token: 0x0601A186 RID: 106886 RVA: 0x003BA786 File Offset: 0x003B8986
		// (set) Token: 0x0601A187 RID: 106887 RVA: 0x003BA78E File Offset: 0x003B898E
		public object Value { get; set; }

		// Token: 0x0601A188 RID: 106888 RVA: 0x003BA797 File Offset: 0x003B8997
		public IDartboardZoneType_UnionUnion()
		{
			this.Type = IDartboardZoneType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A189 RID: 106889 RVA: 0x003BA7AD File Offset: 0x003B89AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A18A RID: 106890 RVA: 0x003BA7BF File Offset: 0x003B89BF
		public IDartboardZoneTypeT AsIDartboardZoneType()
		{
			return this.As<IDartboardZoneTypeT>();
		}

		// Token: 0x0601A18B RID: 106891 RVA: 0x003BA7C7 File Offset: 0x003B89C7
		public static IDartboardZoneType_UnionUnion FromIDartboardZoneType(IDartboardZoneTypeT _idartboardzonetype)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IDartboardZoneType,
				Value = _idartboardzonetype
			};
		}

		// Token: 0x0601A18C RID: 106892 RVA: 0x003BA7DC File Offset: 0x003B89DC
		public ICenterBullZoneT AsICenterBullZone()
		{
			return this.As<ICenterBullZoneT>();
		}

		// Token: 0x0601A18D RID: 106893 RVA: 0x003BA7E4 File Offset: 0x003B89E4
		public static IDartboardZoneType_UnionUnion FromICenterBullZone(ICenterBullZoneT _icenterbullzone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ICenterBullZone,
				Value = _icenterbullzone
			};
		}

		// Token: 0x0601A18E RID: 106894 RVA: 0x003BA7F9 File Offset: 0x003B89F9
		public IOuterBullZoneT AsIOuterBullZone()
		{
			return this.As<IOuterBullZoneT>();
		}

		// Token: 0x0601A18F RID: 106895 RVA: 0x003BA801 File Offset: 0x003B8A01
		public static IDartboardZoneType_UnionUnion FromIOuterBullZone(IOuterBullZoneT _iouterbullzone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IOuterBullZone,
				Value = _iouterbullzone
			};
		}

		// Token: 0x0601A190 RID: 106896 RVA: 0x003BA816 File Offset: 0x003B8A16
		public ISingleScoreZoneT AsISingleScoreZone()
		{
			return this.As<ISingleScoreZoneT>();
		}

		// Token: 0x0601A191 RID: 106897 RVA: 0x003BA81E File Offset: 0x003B8A1E
		public static IDartboardZoneType_UnionUnion FromISingleScoreZone(ISingleScoreZoneT _isinglescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ISingleScoreZone,
				Value = _isinglescorezone
			};
		}

		// Token: 0x0601A192 RID: 106898 RVA: 0x003BA833 File Offset: 0x003B8A33
		public IDoubleScoreZoneT AsIDoubleScoreZone()
		{
			return this.As<IDoubleScoreZoneT>();
		}

		// Token: 0x0601A193 RID: 106899 RVA: 0x003BA83B File Offset: 0x003B8A3B
		public static IDartboardZoneType_UnionUnion FromIDoubleScoreZone(IDoubleScoreZoneT _idoublescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.IDoubleScoreZone,
				Value = _idoublescorezone
			};
		}

		// Token: 0x0601A194 RID: 106900 RVA: 0x003BA850 File Offset: 0x003B8A50
		public ITripleScoreZoneT AsITripleScoreZone()
		{
			return this.As<ITripleScoreZoneT>();
		}

		// Token: 0x0601A195 RID: 106901 RVA: 0x003BA858 File Offset: 0x003B8A58
		public static IDartboardZoneType_UnionUnion FromITripleScoreZone(ITripleScoreZoneT _itriplescorezone)
		{
			return new IDartboardZoneType_UnionUnion
			{
				Type = IDartboardZoneType_Union.ITripleScoreZone,
				Value = _itriplescorezone
			};
		}

		// Token: 0x0601A196 RID: 106902 RVA: 0x003BA870 File Offset: 0x003B8A70
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
