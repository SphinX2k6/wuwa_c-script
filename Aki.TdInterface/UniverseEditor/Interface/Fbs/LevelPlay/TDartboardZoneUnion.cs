using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A65 RID: 19045
	public class TDartboardZoneUnion
	{
		// Token: 0x1700859E RID: 34206
		// (get) Token: 0x0601CA14 RID: 117268 RVA: 0x0040A3BA File Offset: 0x004085BA
		// (set) Token: 0x0601CA15 RID: 117269 RVA: 0x0040A3C2 File Offset: 0x004085C2
		public TDartboardZone Type { get; set; }

		// Token: 0x1700859F RID: 34207
		// (get) Token: 0x0601CA16 RID: 117270 RVA: 0x0040A3CB File Offset: 0x004085CB
		// (set) Token: 0x0601CA17 RID: 117271 RVA: 0x0040A3D3 File Offset: 0x004085D3
		public object Value { get; set; }

		// Token: 0x0601CA18 RID: 117272 RVA: 0x0040A3DC File Offset: 0x004085DC
		public TDartboardZoneUnion()
		{
			this.Type = TDartboardZone.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA19 RID: 117273 RVA: 0x0040A3F2 File Offset: 0x004085F2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA1A RID: 117274 RVA: 0x0040A404 File Offset: 0x00408604
		public ICenterBullZoneT AsICenterBullZone()
		{
			return this.As<ICenterBullZoneT>();
		}

		// Token: 0x0601CA1B RID: 117275 RVA: 0x0040A40C File Offset: 0x0040860C
		public static TDartboardZoneUnion FromICenterBullZone(ICenterBullZoneT _icenterbullzone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ICenterBullZone,
				Value = _icenterbullzone
			};
		}

		// Token: 0x0601CA1C RID: 117276 RVA: 0x0040A421 File Offset: 0x00408621
		public IDoubleScoreZoneT AsIDoubleScoreZone()
		{
			return this.As<IDoubleScoreZoneT>();
		}

		// Token: 0x0601CA1D RID: 117277 RVA: 0x0040A429 File Offset: 0x00408629
		public static TDartboardZoneUnion FromIDoubleScoreZone(IDoubleScoreZoneT _idoublescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.IDoubleScoreZone,
				Value = _idoublescorezone
			};
		}

		// Token: 0x0601CA1E RID: 117278 RVA: 0x0040A43E File Offset: 0x0040863E
		public IOuterBullZoneT AsIOuterBullZone()
		{
			return this.As<IOuterBullZoneT>();
		}

		// Token: 0x0601CA1F RID: 117279 RVA: 0x0040A446 File Offset: 0x00408646
		public static TDartboardZoneUnion FromIOuterBullZone(IOuterBullZoneT _iouterbullzone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.IOuterBullZone,
				Value = _iouterbullzone
			};
		}

		// Token: 0x0601CA20 RID: 117280 RVA: 0x0040A45B File Offset: 0x0040865B
		public ISingleScoreZoneT AsISingleScoreZone()
		{
			return this.As<ISingleScoreZoneT>();
		}

		// Token: 0x0601CA21 RID: 117281 RVA: 0x0040A463 File Offset: 0x00408663
		public static TDartboardZoneUnion FromISingleScoreZone(ISingleScoreZoneT _isinglescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ISingleScoreZone,
				Value = _isinglescorezone
			};
		}

		// Token: 0x0601CA22 RID: 117282 RVA: 0x0040A478 File Offset: 0x00408678
		public ITripleScoreZoneT AsITripleScoreZone()
		{
			return this.As<ITripleScoreZoneT>();
		}

		// Token: 0x0601CA23 RID: 117283 RVA: 0x0040A480 File Offset: 0x00408680
		public static TDartboardZoneUnion FromITripleScoreZone(ITripleScoreZoneT _itriplescorezone)
		{
			return new TDartboardZoneUnion
			{
				Type = TDartboardZone.ITripleScoreZone,
				Value = _itriplescorezone
			};
		}

		// Token: 0x0601CA24 RID: 117284 RVA: 0x0040A498 File Offset: 0x00408698
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
