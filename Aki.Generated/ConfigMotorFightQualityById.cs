using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000595 RID: 1429
	public class ConfigMotorFightQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x001172F0 File Offset: 0x001154F0
		static ConfigMotorFightQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightQualityById.CreateStaticDefaultValue), new Action(ConfigMotorFightQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00117310 File Offset: 0x00115510
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightQuality` where Id=?")
			});
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0011738F File Offset: 0x0011558F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightQualityById.LogPair = null;
			ConfigMotorFightQualityById.HandleId = 0;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0011739D File Offset: 0x0011559D
		public static void Init()
		{
			ConfigMotorFightQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightQualityById.HandleId, "db_motorfight.db", "select BinData from `MotorFightQuality` where Id=?");
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x001173B8 File Offset: 0x001155B8
		public static MotorFightQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightQuality?(MotorFightQuality.GetRootAsMotorFightQuality(configBuffer));
				}
			}
			ConfigMotorFightQualityById.LogPair.Clear();
			ConfigMotorFightQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightQualityById.HandleId, 1, p0Id, ConfigMotorFightQualityById.LogPair) || ConfigCommon.Step(ConfigMotorFightQualityById.HandleId, true, ConfigMotorFightQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightQualityById.HandleId, 0, ConfigMotorFightQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightQuality rootAsMotorFightQuality = MotorFightQuality.GetRootAsMotorFightQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
			return new MotorFightQuality?(rootAsMotorFightQuality);
		}

		// Token: 0x040026F7 RID: 9975
		private const string DB = "db_motorfight.db";

		// Token: 0x040026F8 RID: 9976
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026F9 RID: 9977
		private const string TABLE = "MotorFightQuality";

		// Token: 0x040026FA RID: 9978
		private const string COMMAND = "select BinData from `MotorFightQuality` where Id=?";

		// Token: 0x040026FB RID: 9979
		private const string KEY_PREFIX = "MotorFightQualityById";

		// Token: 0x040026FC RID: 9980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026FD RID: 9981
		private static int HandleId;
	}
}
