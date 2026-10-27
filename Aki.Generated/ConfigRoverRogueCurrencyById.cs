using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E3 RID: 2275
	public class ConfigRoverRogueCurrencyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003565 RID: 13669 RVA: 0x0018728B File Offset: 0x0018548B
		static ConfigRoverRogueCurrencyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueCurrencyById.CreateStaticDefaultValue), new Action(ConfigRoverRogueCurrencyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x001872AC File Offset: 0x001854AC
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

		// Token: 0x06003567 RID: 13671 RVA: 0x0018732B File Offset: 0x0018552B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueCurrencyById.LogPair = null;
			ConfigRoverRogueCurrencyById.HandleId = 0;
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00187339 File Offset: 0x00185539
		public static void Init()
		{
			ConfigRoverRogueCurrencyById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueCurrencyById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueCurrency` where Id=?");
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00187354 File Offset: 0x00185554
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

		// Token: 0x04003E1B RID: 15899
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E1C RID: 15900
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E1D RID: 15901
		private const string TABLE = "RoverRogueCurrency";

		// Token: 0x04003E1E RID: 15902
		private const string COMMAND = "select BinData from `RoverRogueCurrency` where Id=?";

		// Token: 0x04003E1F RID: 15903
		private const string KEY_PREFIX = "RoverRogueCurrencyById";

		// Token: 0x04003E20 RID: 15904
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E21 RID: 15905
		private static int HandleId;
	}
}
