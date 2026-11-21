using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CE RID: 1486
	public class ConfigMotorParkourById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022E1 RID: 8929 RVA: 0x0012241B File Offset: 0x0012061B
		static ConfigMotorParkourById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourById.CreateStaticDefaultValue), new Action(ConfigMotorParkourById.ResetStaticDefaultValue));
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0012243C File Offset: 0x0012063C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkour"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkour` where Id=?")
			});
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x001224BB File Offset: 0x001206BB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourById.LogPair = null;
			ConfigMotorParkourById.HandleId = 0;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x001224C9 File Offset: 0x001206C9
		public static void Init()
		{
			ConfigMotorParkourById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour` where Id=?");
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x001224E4 File Offset: 0x001206E4
		public static MotorParkour? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourById.HandleId, ConfigMotorParkourById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkour?(MotorParkour.GetRootAsMotorParkour(configBuffer));
				}
			}
			ConfigMotorParkourById.LogPair.Clear();
			ConfigMotorParkourById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorParkourById.HandleId, 1, p0Id, ConfigMotorParkourById.LogPair) || ConfigCommon.Step(ConfigMotorParkourById.HandleId, true, ConfigMotorParkourById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourById.HandleId, ConfigMotorParkourById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourById.HandleId, 0, ConfigMotorParkourById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourById.HandleId, ConfigMotorParkourById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkour rootAsMotorParkour = MotorParkour.GetRootAsMotorParkour(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourById.HandleId, ConfigMotorParkourById.LogPair);
			return new MotorParkour?(rootAsMotorParkour);
		}

		// Token: 0x04002886 RID: 10374
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002887 RID: 10375
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x04002888 RID: 10376
		private const string TABLE = "MotorParkour";

		// Token: 0x04002889 RID: 10377
		private const string COMMAND = "select BinData from `MotorParkour` where Id=?";

		// Token: 0x0400288A RID: 10378
		private const string KEY_PREFIX = "MotorParkourById";

		// Token: 0x0400288B RID: 10379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400288C RID: 10380
		private static int HandleId;
	}
}
