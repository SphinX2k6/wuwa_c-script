using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087E RID: 2174
	public class ConfigRogueWeekQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003306 RID: 13062 RVA: 0x00179CF3 File Offset: 0x00177EF3
		static ConfigRogueWeekQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueWeekQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00179D14 File Offset: 0x00177F14
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeekQualityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeekQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeekQualityConfig` where Id=?")
			});
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00179D93 File Offset: 0x00177F93
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigById.LogPair = null;
			ConfigRogueWeekQualityConfigById.HandleId = 0;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00179DA1 File Offset: 0x00177FA1
		public static void Init()
		{
			ConfigRogueWeekQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekQualityConfigById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekQualityConfig` where Id=?");
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00179DBC File Offset: 0x00177FBC
		public static RogueWeekQualityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeekQualityConfig?(RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(configBuffer));
				}
			}
			ConfigRogueWeekQualityConfigById.LogPair.Clear();
			ConfigRogueWeekQualityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeekQualityConfigById.HandleId, 1, p0Id, ConfigRogueWeekQualityConfigById.LogPair) || ConfigCommon.Step(ConfigRogueWeekQualityConfigById.HandleId, true, ConfigRogueWeekQualityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeekQualityConfigById.HandleId, 0, ConfigRogueWeekQualityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeekQualityConfig rootAsRogueWeekQualityConfig = RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeekQualityConfigById.HandleId, ConfigRogueWeekQualityConfigById.LogPair);
			return new RogueWeekQualityConfig?(rootAsRogueWeekQualityConfig);
		}

		// Token: 0x04003B58 RID: 15192
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B59 RID: 15193
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B5A RID: 15194
		private const string TABLE = "RogueWeekQualityConfig";

		// Token: 0x04003B5B RID: 15195
		private const string COMMAND = "select BinData from `RogueWeekQualityConfig` where Id=?";

		// Token: 0x04003B5C RID: 15196
		private const string KEY_PREFIX = "RogueWeekQualityConfigById";

		// Token: 0x04003B5D RID: 15197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B5E RID: 15198
		private static int HandleId;
	}
}
