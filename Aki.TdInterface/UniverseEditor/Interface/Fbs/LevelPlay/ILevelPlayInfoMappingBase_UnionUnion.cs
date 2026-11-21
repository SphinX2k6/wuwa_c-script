using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200495D RID: 18781
	public class ILevelPlayInfoMappingBase_UnionUnion
	{
		// Token: 0x17008356 RID: 33622
		// (get) Token: 0x0601BFAC RID: 114604 RVA: 0x003F4E19 File Offset: 0x003F3019
		// (set) Token: 0x0601BFAD RID: 114605 RVA: 0x003F4E21 File Offset: 0x003F3021
		public ILevelPlayInfoMappingBase_Union Type { get; set; }

		// Token: 0x17008357 RID: 33623
		// (get) Token: 0x0601BFAE RID: 114606 RVA: 0x003F4E2A File Offset: 0x003F302A
		// (set) Token: 0x0601BFAF RID: 114607 RVA: 0x003F4E32 File Offset: 0x003F3032
		public object Value { get; set; }

		// Token: 0x0601BFB0 RID: 114608 RVA: 0x003F4E3B File Offset: 0x003F303B
		public ILevelPlayInfoMappingBase_UnionUnion()
		{
			this.Type = ILevelPlayInfoMappingBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601BFB1 RID: 114609 RVA: 0x003F4E51 File Offset: 0x003F3051
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601BFB2 RID: 114610 RVA: 0x003F4E63 File Offset: 0x003F3063
		public ILevelPlayInfoMappingBaseT AsILevelPlayInfoMappingBase()
		{
			return this.As<ILevelPlayInfoMappingBaseT>();
		}

		// Token: 0x0601BFB3 RID: 114611 RVA: 0x003F4E6B File Offset: 0x003F306B
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingBase(ILevelPlayInfoMappingBaseT _ilevelplayinfomappingbase)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingBase,
				Value = _ilevelplayinfomappingbase
			};
		}

		// Token: 0x0601BFB4 RID: 114612 RVA: 0x003F4E80 File Offset: 0x003F3080
		public ILevelPlayInfoMappingPunishReportT AsILevelPlayInfoMappingPunishReport()
		{
			return this.As<ILevelPlayInfoMappingPunishReportT>();
		}

		// Token: 0x0601BFB5 RID: 114613 RVA: 0x003F4E88 File Offset: 0x003F3088
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingPunishReport(ILevelPlayInfoMappingPunishReportT _ilevelplayinfomappingpunishreport)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingPunishReport,
				Value = _ilevelplayinfomappingpunishreport
			};
		}

		// Token: 0x0601BFB6 RID: 114614 RVA: 0x003F4E9D File Offset: 0x003F309D
		public ILevelPlayInfoMappingSoaringChallengeT AsILevelPlayInfoMappingSoaringChallenge()
		{
			return this.As<ILevelPlayInfoMappingSoaringChallengeT>();
		}

		// Token: 0x0601BFB7 RID: 114615 RVA: 0x003F4EA5 File Offset: 0x003F30A5
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingSoaringChallenge(ILevelPlayInfoMappingSoaringChallengeT _ilevelplayinfomappingsoaringchallenge)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingSoaringChallenge,
				Value = _ilevelplayinfomappingsoaringchallenge
			};
		}

		// Token: 0x0601BFB8 RID: 114616 RVA: 0x003F4EBA File Offset: 0x003F30BA
		public ILevelPlayInfoMappingNightmareSpawnPointT AsILevelPlayInfoMappingNightmareSpawnPoint()
		{
			return this.As<ILevelPlayInfoMappingNightmareSpawnPointT>();
		}

		// Token: 0x0601BFB9 RID: 114617 RVA: 0x003F4EC2 File Offset: 0x003F30C2
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingNightmareSpawnPoint(ILevelPlayInfoMappingNightmareSpawnPointT _ilevelplayinfomappingnightmarespawnpoint)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingNightmareSpawnPoint,
				Value = _ilevelplayinfomappingnightmarespawnpoint
			};
		}

		// Token: 0x0601BFBA RID: 114618 RVA: 0x003F4ED8 File Offset: 0x003F30D8
		public static int Pack(FlatBufferBuilder builder, ILevelPlayInfoMappingBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingBase:
				return ILevelPlayInfoMappingBase.Pack(builder, _o.AsILevelPlayInfoMappingBase()).Value;
			case ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingPunishReport:
				return ILevelPlayInfoMappingPunishReport.Pack(builder, _o.AsILevelPlayInfoMappingPunishReport()).Value;
			case ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingSoaringChallenge:
				return ILevelPlayInfoMappingSoaringChallenge.Pack(builder, _o.AsILevelPlayInfoMappingSoaringChallenge()).Value;
			case ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingNightmareSpawnPoint:
				return ILevelPlayInfoMappingNightmareSpawnPoint.Pack(builder, _o.AsILevelPlayInfoMappingNightmareSpawnPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
