using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004609 RID: 17929
	public class TLevelPlayInfoMappingConfigUnion
	{
		// Token: 0x17007F65 RID: 32613
		// (get) Token: 0x0601B291 RID: 111249 RVA: 0x003DE99C File Offset: 0x003DCB9C
		// (set) Token: 0x0601B292 RID: 111250 RVA: 0x003DE9A4 File Offset: 0x003DCBA4
		public TLevelPlayInfoMappingConfig Type { get; set; }

		// Token: 0x17007F66 RID: 32614
		// (get) Token: 0x0601B293 RID: 111251 RVA: 0x003DE9AD File Offset: 0x003DCBAD
		// (set) Token: 0x0601B294 RID: 111252 RVA: 0x003DE9B5 File Offset: 0x003DCBB5
		public object Value { get; set; }

		// Token: 0x0601B295 RID: 111253 RVA: 0x003DE9BE File Offset: 0x003DCBBE
		public TLevelPlayInfoMappingConfigUnion()
		{
			this.Type = TLevelPlayInfoMappingConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601B296 RID: 111254 RVA: 0x003DE9D4 File Offset: 0x003DCBD4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B297 RID: 111255 RVA: 0x003DE9E6 File Offset: 0x003DCBE6
		public ILevelPlayInfoMappingNightmareSpawnPointT AsILevelPlayInfoMappingNightmareSpawnPoint()
		{
			return this.As<ILevelPlayInfoMappingNightmareSpawnPointT>();
		}

		// Token: 0x0601B298 RID: 111256 RVA: 0x003DE9EE File Offset: 0x003DCBEE
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingNightmareSpawnPoint(ILevelPlayInfoMappingNightmareSpawnPointT _ilevelplayinfomappingnightmarespawnpoint)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingNightmareSpawnPoint,
				Value = _ilevelplayinfomappingnightmarespawnpoint
			};
		}

		// Token: 0x0601B299 RID: 111257 RVA: 0x003DEA03 File Offset: 0x003DCC03
		public ILevelPlayInfoMappingPunishReportT AsILevelPlayInfoMappingPunishReport()
		{
			return this.As<ILevelPlayInfoMappingPunishReportT>();
		}

		// Token: 0x0601B29A RID: 111258 RVA: 0x003DEA0B File Offset: 0x003DCC0B
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingPunishReport(ILevelPlayInfoMappingPunishReportT _ilevelplayinfomappingpunishreport)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingPunishReport,
				Value = _ilevelplayinfomappingpunishreport
			};
		}

		// Token: 0x0601B29B RID: 111259 RVA: 0x003DEA20 File Offset: 0x003DCC20
		public ILevelPlayInfoMappingSoaringChallengeT AsILevelPlayInfoMappingSoaringChallenge()
		{
			return this.As<ILevelPlayInfoMappingSoaringChallengeT>();
		}

		// Token: 0x0601B29C RID: 111260 RVA: 0x003DEA28 File Offset: 0x003DCC28
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingSoaringChallenge(ILevelPlayInfoMappingSoaringChallengeT _ilevelplayinfomappingsoaringchallenge)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingSoaringChallenge,
				Value = _ilevelplayinfomappingsoaringchallenge
			};
		}

		// Token: 0x0601B29D RID: 111261 RVA: 0x003DEA40 File Offset: 0x003DCC40
		public static int Pack(FlatBufferBuilder builder, TLevelPlayInfoMappingConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingNightmareSpawnPoint:
				return ILevelPlayInfoMappingNightmareSpawnPoint.Pack(builder, _o.AsILevelPlayInfoMappingNightmareSpawnPoint()).Value;
			case TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingPunishReport:
				return ILevelPlayInfoMappingPunishReport.Pack(builder, _o.AsILevelPlayInfoMappingPunishReport()).Value;
			case TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingSoaringChallenge:
				return ILevelPlayInfoMappingSoaringChallenge.Pack(builder, _o.AsILevelPlayInfoMappingSoaringChallenge()).Value;
			default:
				return 0;
			}
		}
	}
}
