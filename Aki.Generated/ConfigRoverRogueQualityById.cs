using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000938 RID: 2360
	public class ConfigRoverRogueQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003763 RID: 14179 RVA: 0x0019594F File Offset: 0x00193B4F
		static ConfigRoverRogueQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueQualityById.CreateStaticDefaultValue), new Action(ConfigRoverRogueQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00195970 File Offset: 0x00193B70
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueQuality` where Id=?")
			});
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x001959EF File Offset: 0x00193BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueQualityById.LogPair = null;
			ConfigRoverRogueQualityById.HandleId = 0;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x001959FD File Offset: 0x00193BFD
		public static void Init()
		{
			ConfigRoverRogueQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueQualityById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueQuality` where Id=?");
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00195A18 File Offset: 0x00193C18
		public static RoverRogueQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueQualityById.HandleId, ConfigRoverRogueQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueQuality?(RoverRogueQuality.GetRootAsRoverRogueQuality(configBuffer));
				}
			}
			ConfigRoverRogueQualityById.LogPair.Clear();
			ConfigRoverRogueQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueQualityById.HandleId, 1, p0Id, ConfigRoverRogueQualityById.LogPair) || ConfigCommon.Step(ConfigRoverRogueQualityById.HandleId, true, ConfigRoverRogueQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueQualityById.HandleId, ConfigRoverRogueQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueQualityById.HandleId, 0, ConfigRoverRogueQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueQualityById.HandleId, ConfigRoverRogueQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueQuality rootAsRoverRogueQuality = RoverRogueQuality.GetRootAsRoverRogueQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueQualityById.HandleId, ConfigRoverRogueQualityById.LogPair);
			return new RoverRogueQuality?(rootAsRoverRogueQuality);
		}

		// Token: 0x0400406E RID: 16494
		private const string DB = "db_roverlike.db";

		// Token: 0x0400406F RID: 16495
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04004070 RID: 16496
		private const string TABLE = "RoverRogueQuality";

		// Token: 0x04004071 RID: 16497
		private const string COMMAND = "select BinData from `RoverRogueQuality` where Id=?";

		// Token: 0x04004072 RID: 16498
		private const string KEY_PREFIX = "RoverRogueQualityById";

		// Token: 0x04004073 RID: 16499
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004074 RID: 16500
		private static int HandleId;
	}
}
