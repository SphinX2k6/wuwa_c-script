using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AE RID: 1454
	public class ConfigMotorFightRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002221 RID: 8737 RVA: 0x0011DFB3 File Offset: 0x0011C1B3
		static ConfigMotorFightRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRankById.CreateStaticDefaultValue), new Action(ConfigMotorFightRankById.ResetStaticDefaultValue));
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0011DFD4 File Offset: 0x0011C1D4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightRankById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightRankById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightRank"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightRank` where Id=?")
			});
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0011E053 File Offset: 0x0011C253
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRankById.LogPair = null;
			ConfigMotorFightRankById.HandleId = 0;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0011E061 File Offset: 0x0011C261
		public static void Init()
		{
			ConfigMotorFightRankById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRankById.HandleId, "db_motorfight.db", "select BinData from `MotorFightRank` where Id=?");
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0011E07C File Offset: 0x0011C27C
		public static MotorFightRank? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightRankById.HandleId, ConfigMotorFightRankById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightRank?(MotorFightRank.GetRootAsMotorFightRank(configBuffer));
				}
			}
			ConfigMotorFightRankById.LogPair.Clear();
			ConfigMotorFightRankById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightRankById.HandleId, 1, p0Id, ConfigMotorFightRankById.LogPair) || ConfigCommon.Step(ConfigMotorFightRankById.HandleId, true, ConfigMotorFightRankById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightRankById.HandleId, ConfigMotorFightRankById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightRankById.HandleId, 0, ConfigMotorFightRankById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightRankById.HandleId, ConfigMotorFightRankById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightRank rootAsMotorFightRank = MotorFightRank.GetRootAsMotorFightRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightRankById.HandleId, ConfigMotorFightRankById.LogPair);
			return new MotorFightRank?(rootAsMotorFightRank);
		}

		// Token: 0x040027A6 RID: 10150
		private const string DB = "db_motorfight.db";

		// Token: 0x040027A7 RID: 10151
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027A8 RID: 10152
		private const string TABLE = "MotorFightRank";

		// Token: 0x040027A9 RID: 10153
		private const string COMMAND = "select BinData from `MotorFightRank` where Id=?";

		// Token: 0x040027AA RID: 10154
		private const string KEY_PREFIX = "MotorFightRankById";

		// Token: 0x040027AB RID: 10155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027AC RID: 10156
		private static int HandleId;
	}
}
