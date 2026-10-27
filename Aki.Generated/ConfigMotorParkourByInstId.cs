using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B8 RID: 1464
	public class ConfigMotorParkourByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x0011BD7C File Offset: 0x00119F7C
		static ConfigMotorParkourByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourByInstId.CreateStaticDefaultValue), new Action(ConfigMotorParkourByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0011BD9C File Offset: 0x00119F9C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkour"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkour` where InstId=?")
			});
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0011BE1B File Offset: 0x0011A01B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourByInstId.LogPair = null;
			ConfigMotorParkourByInstId.HandleId = 0;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0011BE29 File Offset: 0x0011A029
		public static void Init()
		{
			ConfigMotorParkourByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourByInstId.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour` where InstId=?");
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0011BE44 File Offset: 0x0011A044
		public static MotorParkour? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourByInstId.HandleId, ConfigMotorParkourByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkour?(MotorParkour.GetRootAsMotorParkour(configBuffer));
				}
			}
			ConfigMotorParkourByInstId.LogPair.Clear();
			ConfigMotorParkourByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigMotorParkourByInstId.HandleId, 1, p0InstId, ConfigMotorParkourByInstId.LogPair) || ConfigCommon.Step(ConfigMotorParkourByInstId.HandleId, true, ConfigMotorParkourByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourByInstId.HandleId, ConfigMotorParkourByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourByInstId.HandleId, 0, ConfigMotorParkourByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourByInstId.HandleId, ConfigMotorParkourByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkour rootAsMotorParkour = MotorParkour.GetRootAsMotorParkour(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourByInstId.HandleId, ConfigMotorParkourByInstId.LogPair);
			return new MotorParkour?(rootAsMotorParkour);
		}

		// Token: 0x040027EC RID: 10220
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027ED RID: 10221
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027EE RID: 10222
		private const string TABLE = "MotorParkour";

		// Token: 0x040027EF RID: 10223
		private const string COMMAND = "select BinData from `MotorParkour` where InstId=?";

		// Token: 0x040027F0 RID: 10224
		private const string KEY_PREFIX = "MotorParkourByInstId";

		// Token: 0x040027F1 RID: 10225
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027F2 RID: 10226
		private static int HandleId;
	}
}
