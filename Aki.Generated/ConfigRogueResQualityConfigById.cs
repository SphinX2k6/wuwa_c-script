using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000852 RID: 2130
	public class ConfigRogueResQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031FE RID: 12798 RVA: 0x001742AC File Offset: 0x001724AC
		static ConfigRogueResQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResQualityConfigById.CreateStaticDefaultValue), new Action(ConfigRogueResQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x001742CC File Offset: 0x001724CC
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

		// Token: 0x06003200 RID: 12800 RVA: 0x0017434B File Offset: 0x0017254B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResQualityConfigById.LogPair = null;
			ConfigRogueResQualityConfigById.HandleId = 0;
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00174359 File Offset: 0x00172559
		public static void Init()
		{
			ConfigRogueResQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResQualityConfigById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResQualityConfig` where Id=?");
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00174374 File Offset: 0x00172574
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

		// Token: 0x04003A24 RID: 14884
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A25 RID: 14885
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A26 RID: 14886
		private const string TABLE = "RogueResQualityConfig";

		// Token: 0x04003A27 RID: 14887
		private const string COMMAND = "select BinData from `RogueResQualityConfig` where Id=?";

		// Token: 0x04003A28 RID: 14888
		private const string KEY_PREFIX = "RogueResQualityConfigById";

		// Token: 0x04003A29 RID: 14889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A2A RID: 14890
		private static int HandleId;
	}
}
