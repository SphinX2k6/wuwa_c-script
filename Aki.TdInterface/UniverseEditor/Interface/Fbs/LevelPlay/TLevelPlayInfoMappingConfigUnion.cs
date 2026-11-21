using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A71 RID: 19057
	public class TLevelPlayInfoMappingConfigUnion
	{
		// Token: 0x170085A6 RID: 34214
		// (get) Token: 0x0601CA66 RID: 117350 RVA: 0x0040AC38 File Offset: 0x00408E38
		// (set) Token: 0x0601CA67 RID: 117351 RVA: 0x0040AC40 File Offset: 0x00408E40
		public TLevelPlayInfoMappingConfig Type { get; set; }

		// Token: 0x170085A7 RID: 34215
		// (get) Token: 0x0601CA68 RID: 117352 RVA: 0x0040AC49 File Offset: 0x00408E49
		// (set) Token: 0x0601CA69 RID: 117353 RVA: 0x0040AC51 File Offset: 0x00408E51
		public object Value { get; set; }

		// Token: 0x0601CA6A RID: 117354 RVA: 0x0040AC5A File Offset: 0x00408E5A
		public TLevelPlayInfoMappingConfigUnion()
		{
			this.Type = TLevelPlayInfoMappingConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA6B RID: 117355 RVA: 0x0040AC70 File Offset: 0x00408E70
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA6C RID: 117356 RVA: 0x0040AC82 File Offset: 0x00408E82
		public ILevelPlayInfoMappingNightmareSpawnPointT AsILevelPlayInfoMappingNightmareSpawnPoint()
		{
			return this.As<ILevelPlayInfoMappingNightmareSpawnPointT>();
		}

		// Token: 0x0601CA6D RID: 117357 RVA: 0x0040AC8A File Offset: 0x00408E8A
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingNightmareSpawnPoint(ILevelPlayInfoMappingNightmareSpawnPointT _ilevelplayinfomappingnightmarespawnpoint)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingNightmareSpawnPoint,
				Value = _ilevelplayinfomappingnightmarespawnpoint
			};
		}

		// Token: 0x0601CA6E RID: 117358 RVA: 0x0040AC9F File Offset: 0x00408E9F
		public ILevelPlayInfoMappingPunishReportT AsILevelPlayInfoMappingPunishReport()
		{
			return this.As<ILevelPlayInfoMappingPunishReportT>();
		}

		// Token: 0x0601CA6F RID: 117359 RVA: 0x0040ACA7 File Offset: 0x00408EA7
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingPunishReport(ILevelPlayInfoMappingPunishReportT _ilevelplayinfomappingpunishreport)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingPunishReport,
				Value = _ilevelplayinfomappingpunishreport
			};
		}

		// Token: 0x0601CA70 RID: 117360 RVA: 0x0040ACBC File Offset: 0x00408EBC
		public ILevelPlayInfoMappingSoaringChallengeT AsILevelPlayInfoMappingSoaringChallenge()
		{
			return this.As<ILevelPlayInfoMappingSoaringChallengeT>();
		}

		// Token: 0x0601CA71 RID: 117361 RVA: 0x0040ACC4 File Offset: 0x00408EC4
		public static TLevelPlayInfoMappingConfigUnion FromILevelPlayInfoMappingSoaringChallenge(ILevelPlayInfoMappingSoaringChallengeT _ilevelplayinfomappingsoaringchallenge)
		{
			return new TLevelPlayInfoMappingConfigUnion
			{
				Type = TLevelPlayInfoMappingConfig.ILevelPlayInfoMappingSoaringChallenge,
				Value = _ilevelplayinfomappingsoaringchallenge
			};
		}

		// Token: 0x0601CA72 RID: 117362 RVA: 0x0040ACDC File Offset: 0x00408EDC
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
