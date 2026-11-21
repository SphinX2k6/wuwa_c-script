using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AB RID: 427
	public class ConfigConsumptiveTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00095B54 File Offset: 0x00093D54
		static ConfigConsumptiveTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveTaskTabById.CreateStaticDefaultValue), new Action(ConfigConsumptiveTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00095B74 File Offset: 0x00093D74
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

		// Token: 0x06000A07 RID: 2567 RVA: 0x00095BF3 File Offset: 0x00093DF3
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveTaskTabById.LogPair = null;
			ConfigConsumptiveTaskTabById.HandleId = 0;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00095C01 File Offset: 0x00093E01
		public static void Init()
		{
			ConfigConsumptiveTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveTaskTabById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveTaskTab` where Id=?");
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00095C1C File Offset: 0x00093E1C
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

		// Token: 0x04000B91 RID: 2961
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B92 RID: 2962
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B93 RID: 2963
		private const string TABLE = "ConsumptiveTaskTab";

		// Token: 0x04000B94 RID: 2964
		private const string COMMAND = "select BinData from `ConsumptiveTaskTab` where Id=?";

		// Token: 0x04000B95 RID: 2965
		private const string KEY_PREFIX = "ConsumptiveTaskTabById";

		// Token: 0x04000B96 RID: 2966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B97 RID: 2967
		private static int HandleId;
	}
}
