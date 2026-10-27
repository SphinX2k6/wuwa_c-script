using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000197 RID: 407
	public class ConfigConsumptiveActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x0008F78B File Offset: 0x0008D98B
		static ConfigConsumptiveActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveActivityById.CreateStaticDefaultValue), new Action(ConfigConsumptiveActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0008F7AC File Offset: 0x0008D9AC
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

		// Token: 0x0600098F RID: 2447 RVA: 0x0008F82B File Offset: 0x0008DA2B
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveActivityById.LogPair = null;
			ConfigConsumptiveActivityById.HandleId = 0;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0008F839 File Offset: 0x0008DA39
		public static void Init()
		{
			ConfigConsumptiveActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveActivityById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveActivity` where Id=?");
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0008F854 File Offset: 0x0008DA54
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

		// Token: 0x04000B05 RID: 2821
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B06 RID: 2822
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B07 RID: 2823
		private const string TABLE = "ConsumptiveActivity";

		// Token: 0x04000B08 RID: 2824
		private const string COMMAND = "select BinData from `ConsumptiveActivity` where Id=?";

		// Token: 0x04000B09 RID: 2825
		private const string KEY_PREFIX = "ConsumptiveActivityById";

		// Token: 0x04000B0A RID: 2826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B0B RID: 2827
		private static int HandleId;
	}
}
