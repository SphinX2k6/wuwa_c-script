using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045FD RID: 17917
	public class TDartboardZoneUnion
	{
		// Token: 0x17007F5D RID: 32605
		// (get) Token: 0x0601B23F RID: 111167 RVA: 0x003DE11E File Offset: 0x003DC31E
		// (set) Token: 0x0601B240 RID: 111168 RVA: 0x003DE126 File Offset: 0x003DC326
		public TDartboardZone Type { get; set; }

		// Token: 0x17007F5E RID: 32606
		// (get) Token: 0x0601B241 RID: 111169 RVA: 0x003DE12F File Offset: 0x003DC32F
		// (set) Token: 0x0601B242 RID: 111170 RVA: 0x003DE137 File Offset: 0x003DC337
		public object Value { get; set; }

		// Token: 0x0601B243 RID: 111171 RVA: 0x003DE140 File Offset: 0x003DC340
		public TDartboardZoneUnion()
		{
			this.Type = TDartboardZone.NONE;
			this.Value = null;
		}

		// Token: 0x0601B244 RID: 111172 RVA: 0x003DE156 File Offset: 0x003DC356
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B245 RID: 111173 RVA: 0x003DE168 File Offset: 0x003DC368
		public ICenterBullZoneT AsICenterBullZone()
		{
			return this.As<ICenterBullZoneT>();
		}

		// Token: 0x0601B246 RID: 111174 RVA: 0x003DE170 File Offset: 0x003DC370
		public static TDartboardZoneUnion FromICenterBullZone(ICenterBullZoneT _icenterbullzone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ICenterBullZone,
				Value = _icenterbullzone
			};
		}

		// Token: 0x0601B247 RID: 111175 RVA: 0x003DE185 File Offset: 0x003DC385
		public IDoubleScoreZoneT AsIDoubleScoreZone()
		{
			return this.As<IDoubleScoreZoneT>();
		}

		// Token: 0x0601B248 RID: 111176 RVA: 0x003DE18D File Offset: 0x003DC38D
		public static TDartboardZoneUnion FromIDoubleScoreZone(IDoubleScoreZoneT _idoublescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.IDoubleScoreZone,
				Value = _idoublescorezone
			};
		}

		// Token: 0x0601B249 RID: 111177 RVA: 0x003DE1A2 File Offset: 0x003DC3A2
		public IOuterBullZoneT AsIOuterBullZone()
		{
			return this.As<IOuterBullZoneT>();
		}

		// Token: 0x0601B24A RID: 111178 RVA: 0x003DE1AA File Offset: 0x003DC3AA
		public static TDartboardZoneUnion FromIOuterBullZone(IOuterBullZoneT _iouterbullzone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.IOuterBullZone,
				Value = _iouterbullzone
			};
		}

		// Token: 0x0601B24B RID: 111179 RVA: 0x003DE1BF File Offset: 0x003DC3BF
		public ISingleScoreZoneT AsISingleScoreZone()
		{
			return this.As<ISingleScoreZoneT>();
		}

		// Token: 0x0601B24C RID: 111180 RVA: 0x003DE1C7 File Offset: 0x003DC3C7
		public static TDartboardZoneUnion FromISingleScoreZone(ISingleScoreZoneT _isinglescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ISingleScoreZone,
				Value = _isinglescorezone
			};
		}

		// Token: 0x0601B24D RID: 111181 RVA: 0x003DE1DC File Offset: 0x003DC3DC
		public ITripleScoreZoneT AsITripleScoreZone()
		{
			return this.As<ITripleScoreZoneT>();
		}

		// Token: 0x0601B24E RID: 111182 RVA: 0x003DE1E4 File Offset: 0x003DC3E4
		public static TDartboardZoneUnion FromITripleScoreZone(ITripleScoreZoneT _itriplescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ITripleScoreZone,
				Value = _itriplescorezone
			};
		}

		// Token: 0x0601B24F RID: 111183 RVA: 0x003DE1FC File Offset: 0x003DC3FC
		public static int Pack(FlatBufferBuilder builder, TDartboardZoneUnion _o)
		{
			switch (_o.Type)
			{
			case TDartboardZone.ICenterBullZone:
				return ICenterBullZone.Pack(builder, _o.AsICenterBullZone()).Value;
			case TDartboardZone.IDoubleScoreZone:
				return IDoubleScoreZone.Pack(builder, _o.AsIDoubleScoreZone()).Value;
			case TDartboardZone.IOuterBullZone:
				return IOuterBullZone.Pack(builder, _o.AsIOuterBullZone()).Value;
			case TDartboardZone.ISingleScoreZone:
				return ISingleScoreZone.Pack(builder, _o.AsISingleScoreZone()).Value;
			case TDartboardZone.ITripleScoreZone:
				return ITripleScoreZone.Pack(builder, _o.AsITripleScoreZone()).Value;
			default:
				return 0;
			}
		}
	}
}
