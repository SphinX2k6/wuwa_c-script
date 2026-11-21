using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AA RID: 426
	public class ConfigConsumptiveTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x0009590C File Offset: 0x00093B0C
		static ConfigConsumptiveTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConsumptiveTaskById.CreateStaticDefaultValue), new Action(ConfigConsumptiveTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0009592C File Offset: 0x00093B2C
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

		// Token: 0x06000A01 RID: 2561 RVA: 0x000959AB File Offset: 0x00093BAB
		public static void ResetStaticDefaultValue()
		{
			ConfigConsumptiveTaskById.LogPair = null;
			ConfigConsumptiveTaskById.HandleId = 0;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000959B9 File Offset: 0x00093BB9
		public static void Init()
		{
			ConfigConsumptiveTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigConsumptiveTaskById.HandleId, "db_consumptiveactivity.db", "select BinData from `ConsumptiveTask` where Id=?");
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000959D4 File Offset: 0x00093BD4
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

		// Token: 0x04000B8A RID: 2954
		private const string DB = "db_consumptiveactivity.db";

		// Token: 0x04000B8B RID: 2955
		private const string FILE = "l.累消活动.xlsx";

		// Token: 0x04000B8C RID: 2956
		private const string TABLE = "ConsumptiveTask";

		// Token: 0x04000B8D RID: 2957
		private const string COMMAND = "select BinData from `ConsumptiveTask` where Id=?";

		// Token: 0x04000B8E RID: 2958
		private const string KEY_PREFIX = "ConsumptiveTaskById";

		// Token: 0x04000B8F RID: 2959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B90 RID: 2960
		private static int HandleId;
	}
}
