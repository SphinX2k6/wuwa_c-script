using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000597 RID: 1431
	public class ConfigMotorFightRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002197 RID: 8599 RVA: 0x001176CB File Offset: 0x001158CB
		static ConfigMotorFightRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRankById.CreateStaticDefaultValue), new Action(ConfigMotorFightRankById.ResetStaticDefaultValue));
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x001176EC File Offset: 0x001158EC
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

		// Token: 0x06002199 RID: 8601 RVA: 0x0011776B File Offset: 0x0011596B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRankById.LogPair = null;
			ConfigMotorFightRankById.HandleId = 0;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00117779 File Offset: 0x00115979
		public static void Init()
		{
			ConfigMotorFightRankById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRankById.HandleId, "db_motorfight.db", "select BinData from `MotorFightRank` where Id=?");
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00117794 File Offset: 0x00115994
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

		// Token: 0x04002705 RID: 9989
		private const string DB = "db_motorfight.db";

		// Token: 0x04002706 RID: 9990
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002707 RID: 9991
		private const string TABLE = "MotorFightRank";

		// Token: 0x04002708 RID: 9992
		private const string COMMAND = "select BinData from `MotorFightRank` where Id=?";

		// Token: 0x04002709 RID: 9993
		private const string KEY_PREFIX = "MotorFightRankById";

		// Token: 0x0400270A RID: 9994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400270B RID: 9995
		private static int HandleId;
	}
}
