using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085A RID: 2138
	public class ConfigRogueResCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600322E RID: 12846 RVA: 0x001789AC File Offset: 0x00176BAC
		static ConfigRogueResCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCurrencyById.CreateStaticDefaultValue), new Action(ConfigRogueResCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x001789CC File Offset: 0x00176BCC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCurrency` where Id=?")
			});
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x00178A4B File Offset: 0x00176C4B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCurrencyById.LogPair = null;
			ConfigRogueResCurrencyById.HandleId = 0;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00178A59 File Offset: 0x00176C59
		public static void Init()
		{
			ConfigRogueResCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCurrencyById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCurrency` where Id=?");
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00178A74 File Offset: 0x00176C74
		public static RogueResCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCurrency?(RogueResCurrency.GetRootAsRogueResCurrency(configBuffer));
				}
			}
			ConfigRogueResCurrencyById.LogPair.Clear();
			ConfigRogueResCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCurrencyById.HandleId, 1, p0Id, ConfigRogueResCurrencyById.LogPair) || ConfigCommon.Step(ConfigRogueResCurrencyById.HandleId, true, ConfigRogueResCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCurrencyById.HandleId, 0, ConfigRogueResCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCurrency rootAsRogueResCurrency = RogueResCurrency.GetRootAsRogueResCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCurrencyById.HandleId, ConfigRogueResCurrencyById.LogPair);
			return new RogueResCurrency?(rootAsRogueResCurrency);
		}

		// Token: 0x04003A5C RID: 14940
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A5D RID: 14941
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A5E RID: 14942
		private const string TABLE = "RogueResCurrency";

		// Token: 0x04003A5F RID: 14943
		private const string COMMAND = "select BinData from `RogueResCurrency` where Id=?";

		// Token: 0x04003A60 RID: 14944
		private const string KEY_PREFIX = "RogueResCurrencyById";

		// Token: 0x04003A61 RID: 14945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A62 RID: 14946
		private static int HandleId;
	}
}
