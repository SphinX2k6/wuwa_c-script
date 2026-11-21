using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CF RID: 1487
	public class ConfigMotorParkourByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x00122664 File Offset: 0x00120864
		static ConfigMotorParkourByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourByInstId.CreateStaticDefaultValue), new Action(ConfigMotorParkourByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00122684 File Offset: 0x00120884
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

		// Token: 0x060022E9 RID: 8937 RVA: 0x00122703 File Offset: 0x00120903
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourByInstId.LogPair = null;
			ConfigMotorParkourByInstId.HandleId = 0;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00122711 File Offset: 0x00120911
		public static void Init()
		{
			ConfigMotorParkourByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourByInstId.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour` where InstId=?");
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0012272C File Offset: 0x0012092C
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

		// Token: 0x0400288D RID: 10381
		private const string DB = "db_motorparkour.db";

		// Token: 0x0400288E RID: 10382
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x0400288F RID: 10383
		private const string TABLE = "MotorParkour";

		// Token: 0x04002890 RID: 10384
		private const string COMMAND = "select BinData from `MotorParkour` where InstId=?";

		// Token: 0x04002891 RID: 10385
		private const string KEY_PREFIX = "MotorParkourByInstId";

		// Token: 0x04002892 RID: 10386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002893 RID: 10387
		private static int HandleId;
	}
}
