using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000198 RID: 408
	public class ConfigConsumptiveTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		static ConfigConsumptiveTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveTaskById.CreateStaticDefaultValue), new Action(ConfigConsumptiveTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0008F9F4 File Offset: 0x0008DBF4
		public static void CreateStaticDefaultValue()
		{
			ConfigConsumptiveTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConsumptiveTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_consumptiveactivity.db"),
				new ValueTuple<string, object>("文件", "l.累消活动.xlsx"),
				new ValueTuple<string, object>("表名", "ConsumptiveTask"),
				new ValueTuple<string, object>("语句", "select BinData from `ConsumptiveTask` where Id=?")
			});
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0008FA73 File Offset: 0x0008DC73
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveTaskById.LogPair = null;
			ConfigConsumptiveTaskById.HandleId = 0;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0008FA81 File Offset: 0x0008DC81
		public static void Init()
		{
			ConfigConsumptiveTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveTaskById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveTask` where Id=?");
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0008FA9C File Offset: 0x0008DC9C
		public static ConsumptiveTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConsumptiveTaskById.HandleId, ConfigConsumptiveTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ConsumptiveTask?(ConsumptiveTask.GetRootAsConsumptiveTask(configBuffer));
				}
			}
			ConfigConsumptiveTaskById.LogPair.Clear();
			ConfigConsumptiveTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConsumptiveTaskById.HandleId, 1, p0Id, ConfigConsumptiveTaskById.LogPair) || ConfigCommon.Step(ConfigConsumptiveTaskById.HandleId, true, ConfigConsumptiveTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConsumptiveTaskById.HandleId, ConfigConsumptiveTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConsumptiveTaskById.HandleId, 0, ConfigConsumptiveTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConsumptiveTaskById.HandleId, ConfigConsumptiveTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ConsumptiveTask rootAsConsumptiveTask = ConsumptiveTask.GetRootAsConsumptiveTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConsumptiveTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConsumptiveTaskById.HandleId, ConfigConsumptiveTaskById.LogPair);
			return new ConsumptiveTask?(rootAsConsumptiveTask);
		}

		// Token: 0x04000B0C RID: 2828
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B0D RID: 2829
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B0E RID: 2830
		private const string TABLE = "ConsumptiveTask";

		// Token: 0x04000B0F RID: 2831
		private const string COMMAND = "select BinData from `ConsumptiveTask` where Id=?";

		// Token: 0x04000B10 RID: 2832
		private const string KEY_PREFIX = "ConsumptiveTaskById";

		// Token: 0x04000B11 RID: 2833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B12 RID: 2834
		private static int HandleId;
	}
}
