using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A9 RID: 425
	public class ConfigConsumptiveActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x000956C3 File Offset: 0x000938C3
		static ConfigConsumptiveActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveActivityById.CreateStaticDefaultValue), new Action(ConfigConsumptiveActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000956E4 File Offset: 0x000938E4
		public static void CreateStaticDefaultValue()
		{
			ConfigConsumptiveActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConsumptiveActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_consumptiveactivity.db"),
				new ValueTuple<string, object>("文件", "l.累消活动.xlsx"),
				new ValueTuple<string, object>("表名", "ConsumptiveActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `ConsumptiveActivity` where Id=?")
			});
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00095763 File Offset: 0x00093963
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveActivityById.LogPair = null;
			ConfigConsumptiveActivityById.HandleId = 0;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00095771 File Offset: 0x00093971
		public static void Init()
		{
			ConfigConsumptiveActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveActivityById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveActivity` where Id=?");
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0009578C File Offset: 0x0009398C
		public static ConsumptiveActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConsumptiveActivityById.HandleId, ConfigConsumptiveActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ConsumptiveActivity?(ConsumptiveActivity.GetRootAsConsumptiveActivity(configBuffer));
				}
			}
			ConfigConsumptiveActivityById.LogPair.Clear();
			ConfigConsumptiveActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConsumptiveActivityById.HandleId, 1, p0Id, ConfigConsumptiveActivityById.LogPair) || ConfigCommon.Step(ConfigConsumptiveActivityById.HandleId, true, ConfigConsumptiveActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConsumptiveActivityById.HandleId, ConfigConsumptiveActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConsumptiveActivityById.HandleId, 0, ConfigConsumptiveActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConsumptiveActivityById.HandleId, ConfigConsumptiveActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ConsumptiveActivity rootAsConsumptiveActivity = ConsumptiveActivity.GetRootAsConsumptiveActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConsumptiveActivityById.HandleId, ConfigConsumptiveActivityById.LogPair);
			return new ConsumptiveActivity?(rootAsConsumptiveActivity);
		}

		// Token: 0x04000B83 RID: 2947
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B84 RID: 2948
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B85 RID: 2949
		private const string TABLE = "ConsumptiveActivity";

		// Token: 0x04000B86 RID: 2950
		private const string COMMAND = "select BinData from `ConsumptiveActivity` where Id=?";

		// Token: 0x04000B87 RID: 2951
		private const string KEY_PREFIX = "ConsumptiveActivityById";

		// Token: 0x04000B88 RID: 2952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B89 RID: 2953
		private static int HandleId;
	}
}
