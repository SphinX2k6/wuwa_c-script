using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000199 RID: 409
	public class ConfigConsumptiveTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x0008FC1C File Offset: 0x0008DE1C
		static ConfigConsumptiveTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveTaskTabById.CreateStaticDefaultValue), new Action(ConfigConsumptiveTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0008FC3C File Offset: 0x0008DE3C
		public static void CreateStaticDefaultValue()
		{
			ConfigConsumptiveTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConsumptiveTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_consumptiveactivity.db"),
				new ValueTuple<string, object>("文件", "l.累消活动.xlsx"),
				new ValueTuple<string, object>("表名", "ConsumptiveTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `ConsumptiveTaskTab` where Id=?")
			});
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0008FCBB File Offset: 0x0008DEBB
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveTaskTabById.LogPair = null;
			ConfigConsumptiveTaskTabById.HandleId = 0;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0008FCC9 File Offset: 0x0008DEC9
		public static void Init()
		{
			ConfigConsumptiveTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveTaskTabById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveTaskTab` where Id=?");
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0008FCE4 File Offset: 0x0008DEE4
		public static ConsumptiveTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConsumptiveTaskTabById.HandleId, ConfigConsumptiveTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ConsumptiveTaskTab?(ConsumptiveTaskTab.GetRootAsConsumptiveTaskTab(configBuffer));
				}
			}
			ConfigConsumptiveTaskTabById.LogPair.Clear();
			ConfigConsumptiveTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConsumptiveTaskTabById.HandleId, 1, p0Id, ConfigConsumptiveTaskTabById.LogPair) || ConfigCommon.Step(ConfigConsumptiveTaskTabById.HandleId, true, ConfigConsumptiveTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConsumptiveTaskTabById.HandleId, ConfigConsumptiveTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConsumptiveTaskTabById.HandleId, 0, ConfigConsumptiveTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConsumptiveTaskTabById.HandleId, ConfigConsumptiveTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ConsumptiveTaskTab rootAsConsumptiveTaskTab = ConsumptiveTaskTab.GetRootAsConsumptiveTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConsumptiveTaskTabById.HandleId, ConfigConsumptiveTaskTabById.LogPair);
			return new ConsumptiveTaskTab?(rootAsConsumptiveTaskTab);
		}

		// Token: 0x04000B13 RID: 2835
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B14 RID: 2836
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B15 RID: 2837
		private const string TABLE = "ConsumptiveTaskTab";

		// Token: 0x04000B16 RID: 2838
		private const string COMMAND = "select BinData from `ConsumptiveTaskTab` where Id=?";

		// Token: 0x04000B17 RID: 2839
		private const string KEY_PREFIX = "ConsumptiveTaskTabById";

		// Token: 0x04000B18 RID: 2840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B19 RID: 2841
		private static int HandleId;
	}
}
