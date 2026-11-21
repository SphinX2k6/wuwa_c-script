using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086E RID: 2158
	public class ConfigRogueResQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x0017B594 File Offset: 0x00179794
		static ConfigRogueResQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueResQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0017B5B4 File Offset: 0x001797B4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResQualityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResQualityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResQualityConfig` where Id=?")
			});
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0017B633 File Offset: 0x00179833
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResQualityConfigById.LogPair = null;
			ConfigRogueResQualityConfigById.HandleId = 0;
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0017B641 File Offset: 0x00179841
		public static void Init()
		{
			ConfigRogueResQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResQualityConfigById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResQualityConfig` where Id=?");
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x0017B65C File Offset: 0x0017985C
		public static RogueResQualityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResQualityConfigById.HandleId, ConfigRogueResQualityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResQualityConfig?(RogueResQualityConfig.GetRootAsRogueResQualityConfig(configBuffer));
				}
			}
			ConfigRogueResQualityConfigById.LogPair.Clear();
			ConfigRogueResQualityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResQualityConfigById.HandleId, 1, p0Id, ConfigRogueResQualityConfigById.LogPair) || ConfigCommon.Step(ConfigRogueResQualityConfigById.HandleId, true, ConfigRogueResQualityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResQualityConfigById.HandleId, ConfigRogueResQualityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResQualityConfigById.HandleId, 0, ConfigRogueResQualityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResQualityConfigById.HandleId, ConfigRogueResQualityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResQualityConfig rootAsRogueResQualityConfig = RogueResQualityConfig.GetRootAsRogueResQualityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResQualityConfigById.HandleId, ConfigRogueResQualityConfigById.LogPair);
			return new RogueResQualityConfig?(rootAsRogueResQualityConfig);
		}

		// Token: 0x04003AE8 RID: 15080
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AE9 RID: 15081
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AEA RID: 15082
		private const string TABLE = "RogueResQualityConfig";

		// Token: 0x04003AEB RID: 15083
		private const string COMMAND = "select BinData from `RogueResQualityConfig` where Id=?";

		// Token: 0x04003AEC RID: 15084
		private const string KEY_PREFIX = "RogueResQualityConfigById";

		// Token: 0x04003AED RID: 15085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AEE RID: 15086
		private static int HandleId;
	}
}
