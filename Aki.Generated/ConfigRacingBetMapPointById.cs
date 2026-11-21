using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B5 RID: 1973
	public class ConfigRacingBetMapPointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E50 RID: 11856 RVA: 0x001626EF File Offset: 0x001608EF
		static ConfigRacingBetMapPointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetMapPointById.CreateStaticDefaultValue), new Action(ConfigRacingBetMapPointById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x00162710 File Offset: 0x00160910
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetMapPointById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetMapPointById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetMapPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetMapPoint` where Id=?")
			});
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x0016278F File Offset: 0x0016098F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetMapPointById.LogPair = null;
			ConfigRacingBetMapPointById.HandleId = 0;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x0016279D File Offset: 0x0016099D
		public static void Init()
		{
			ConfigRacingBetMapPointById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetMapPointById.HandleId, "db_racingbets.db", "select BinData from `RacingBetMapPoint` where Id=?");
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x001627B8 File Offset: 0x001609B8
		public static RacingBetMapPoint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetMapPoint?(RacingBetMapPoint.GetRootAsRacingBetMapPoint(configBuffer));
				}
			}
			ConfigRacingBetMapPointById.LogPair.Clear();
			ConfigRacingBetMapPointById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetMapPointById.HandleId, 1, p0Id, ConfigRacingBetMapPointById.LogPair) || ConfigCommon.Step(ConfigRacingBetMapPointById.HandleId, true, ConfigRacingBetMapPointById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetMapPointById.HandleId, 0, ConfigRacingBetMapPointById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetMapPoint rootAsRacingBetMapPoint = RacingBetMapPoint.GetRootAsRacingBetMapPoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
			return new RacingBetMapPoint?(rootAsRacingBetMapPoint);
		}

		// Token: 0x040035D9 RID: 13785
		private const string DB = "db_racingbets.db";

		// Token: 0x040035DA RID: 13786
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035DB RID: 13787
		private const string TABLE = "RacingBetMapPoint";

		// Token: 0x040035DC RID: 13788
		private const string COMMAND = "select BinData from `RacingBetMapPoint` where Id=?";

		// Token: 0x040035DD RID: 13789
		private const string KEY_PREFIX = "RacingBetMapPointById";

		// Token: 0x040035DE RID: 13790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035DF RID: 13791
		private static int HandleId;
	}
}
