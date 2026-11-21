using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092E RID: 2350
	public class ConfigRoverRogueCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003727 RID: 14119 RVA: 0x001944AB File Offset: 0x001926AB
		static ConfigRoverRogueCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueCurrencyById.CreateStaticDefaultValue), new Action(ConfigRoverRogueCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x001944CC File Offset: 0x001926CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueCurrencyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueCurrencyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueCurrency` where Id=?")
			});
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0019454B File Offset: 0x0019274B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueCurrencyById.LogPair = null;
			ConfigRoverRogueCurrencyById.HandleId = 0;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00194559 File Offset: 0x00192759
		public static void Init()
		{
			ConfigRoverRogueCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueCurrencyById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueCurrency` where Id=?");
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00194574 File Offset: 0x00192774
		public static RoverRogueCurrency? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueCurrencyById.HandleId, ConfigRoverRogueCurrencyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueCurrency?(RoverRogueCurrency.GetRootAsRoverRogueCurrency(configBuffer));
				}
			}
			ConfigRoverRogueCurrencyById.LogPair.Clear();
			ConfigRoverRogueCurrencyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueCurrencyById.HandleId, 1, p0Id, ConfigRoverRogueCurrencyById.LogPair) || ConfigCommon.Step(ConfigRoverRogueCurrencyById.HandleId, true, ConfigRoverRogueCurrencyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueCurrencyById.HandleId, ConfigRoverRogueCurrencyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueCurrencyById.HandleId, 0, ConfigRoverRogueCurrencyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueCurrencyById.HandleId, ConfigRoverRogueCurrencyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueCurrency rootAsRoverRogueCurrency = RoverRogueCurrency.GetRootAsRoverRogueCurrency(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueCurrencyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueCurrencyById.HandleId, ConfigRoverRogueCurrencyById.LogPair);
			return new RoverRogueCurrency?(rootAsRoverRogueCurrency);
		}

		// Token: 0x04004028 RID: 16424
		private const string DB = "db_roverlike.db";

		// Token: 0x04004029 RID: 16425
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x0400402A RID: 16426
		private const string TABLE = "RoverRogueCurrency";

		// Token: 0x0400402B RID: 16427
		private const string COMMAND = "select BinData from `RoverRogueCurrency` where Id=?";

		// Token: 0x0400402C RID: 16428
		private const string KEY_PREFIX = "RoverRogueCurrencyById";

		// Token: 0x0400402D RID: 16429
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400402E RID: 16430
		private static int HandleId;
	}
}
