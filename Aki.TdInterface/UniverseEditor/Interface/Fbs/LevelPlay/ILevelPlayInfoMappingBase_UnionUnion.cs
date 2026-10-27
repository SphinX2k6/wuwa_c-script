using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F5 RID: 17653
	public class ILevelPlayInfoMappingBase_UnionUnion
	{
		// Token: 0x17007D15 RID: 32021
		// (get) Token: 0x0601A7D7 RID: 108503 RVA: 0x003C8B7D File Offset: 0x003C6D7D
		// (set) Token: 0x0601A7D8 RID: 108504 RVA: 0x003C8B85 File Offset: 0x003C6D85
		public ILevelPlayInfoMappingBase_Union Type { get; set; }

		// Token: 0x17007D16 RID: 32022
		// (get) Token: 0x0601A7D9 RID: 108505 RVA: 0x003C8B8E File Offset: 0x003C6D8E
		// (set) Token: 0x0601A7DA RID: 108506 RVA: 0x003C8B96 File Offset: 0x003C6D96
		public object Value { get; set; }

		// Token: 0x0601A7DB RID: 108507 RVA: 0x003C8B9F File Offset: 0x003C6D9F
		public ILevelPlayInfoMappingBase_UnionUnion()
		{
			this.Type = ILevelPlayInfoMappingBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A7DC RID: 108508 RVA: 0x003C8BB5 File Offset: 0x003C6DB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A7DD RID: 108509 RVA: 0x003C8BC7 File Offset: 0x003C6DC7
		public ILevelPlayInfoMappingBaseT AsILevelPlayInfoMappingBase()
		{
			return this.As<ILevelPlayInfoMappingBaseT>();
		}

		// Token: 0x0601A7DE RID: 108510 RVA: 0x003C8BCF File Offset: 0x003C6DCF
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingBase(ILevelPlayInfoMappingBaseT _ilevelplayinfomappingbase)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingBase,
				Value = _ilevelplayinfomappingbase
			};
		}

		// Token: 0x0601A7DF RID: 108511 RVA: 0x003C8BE4 File Offset: 0x003C6DE4
		public ILevelPlayInfoMappingPunishReportT AsILevelPlayInfoMappingPunishReport()
		{
			return this.As<ILevelPlayInfoMappingPunishReportT>();
		}

		// Token: 0x0601A7E0 RID: 108512 RVA: 0x003C8BEC File Offset: 0x003C6DEC
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingPunishReport(ILevelPlayInfoMappingPunishReportT _ilevelplayinfomappingpunishreport)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingPunishReport,
				Value = _ilevelplayinfomappingpunishreport
			};
		}

		// Token: 0x0601A7E1 RID: 108513 RVA: 0x003C8C01 File Offset: 0x003C6E01
		public ILevelPlayInfoMappingSoaringChallengeT AsILevelPlayInfoMappingSoaringChallenge()
		{
			return this.As<ILevelPlayInfoMappingSoaringChallengeT>();
		}

		// Token: 0x0601A7E2 RID: 108514 RVA: 0x003C8C09 File Offset: 0x003C6E09
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingSoaringChallenge(ILevelPlayInfoMappingSoaringChallengeT _ilevelplayinfomappingsoaringchallenge)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingSoaringChallenge,
				Value = _ilevelplayinfomappingsoaringchallenge
			};
		}

		// Token: 0x0601A7E3 RID: 108515 RVA: 0x003C8C1E File Offset: 0x003C6E1E
		public ILevelPlayInfoMappingNightmareSpawnPointT AsILevelPlayInfoMappingNightmareSpawnPoint()
		{
			return this.As<ILevelPlayInfoMappingNightmareSpawnPointT>();
		}

		// Token: 0x0601A7E4 RID: 108516 RVA: 0x003C8C26 File Offset: 0x003C6E26
		public static ILevelPlayInfoMappingBase_UnionUnion FromILevelPlayInfoMappingNightmareSpawnPoint(ILevelPlayInfoMappingNightmareSpawnPointT _ilevelplayinfomappingnightmarespawnpoint)
		{
			return new ILevelPlayInfoMappingBase_UnionUnion
			{
				Type = ILevelPlayInfoMappingBase_Union.ILevelPlayInfoMappingNightmareSpawnPoint,
				Value = _ilevelplayinfomappingnightmarespawnpoint
			};
		}

		// Token: 0x0601A7E5 RID: 108517 RVA: 0x003C8C3C File Offset: 0x003C6E3C
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
