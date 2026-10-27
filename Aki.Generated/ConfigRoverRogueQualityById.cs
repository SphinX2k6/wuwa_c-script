using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008ED RID: 2285
	public class ConfigRoverRogueQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035A1 RID: 13729 RVA: 0x0018872F File Offset: 0x0018692F
		static ConfigRoverRogueQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueQualityById.CreateStaticDefaultValue), new Action(ConfigRoverRogueQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00188750 File Offset: 0x00186950
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

		// Token: 0x060035A3 RID: 13731 RVA: 0x001887CF File Offset: 0x001869CF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueQualityById.LogPair = null;
			ConfigRoverRogueQualityById.HandleId = 0;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x001887DD File Offset: 0x001869DD
		public static void Init()
		{
			ConfigRoverRogueQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueQualityById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueQuality` where Id=?");
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x001887F8 File Offset: 0x001869F8
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

		// Token: 0x04003E61 RID: 15969
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E62 RID: 15970
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E63 RID: 15971
		private const string TABLE = "RoverRogueQuality";

		// Token: 0x04003E64 RID: 15972
		private const string COMMAND = "select BinData from `RoverRogueQuality` where Id=?";

		// Token: 0x04003E65 RID: 15973
		private const string KEY_PREFIX = "RoverRogueQualityById";

		// Token: 0x04003E66 RID: 15974
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E67 RID: 15975
		private static int HandleId;
	}
}
