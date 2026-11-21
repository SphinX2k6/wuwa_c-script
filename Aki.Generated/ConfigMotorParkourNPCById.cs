using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D0 RID: 1488
	public class ConfigMotorParkourNPCById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022ED RID: 8941 RVA: 0x001228AC File Offset: 0x00120AAC
		static ConfigMotorParkourNPCById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourNPCById.CreateStaticDefaultValue), new Action(ConfigMotorParkourNPCById.ResetStaticDefaultValue));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x001228CC File Offset: 0x00120ACC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourNPCById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourNPCById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkourNPC"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkourNPC` where Id=?")
			});
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0012294B File Offset: 0x00120B4B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourNPCById.LogPair = null;
			ConfigMotorParkourNPCById.HandleId = 0;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00122959 File Offset: 0x00120B59
		public static void Init()
		{
			ConfigMotorParkourNPCById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourNPCById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourNPC` where Id=?");
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00122974 File Offset: 0x00120B74
		public static MotorParkourNPC? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourNPCById.HandleId, ConfigMotorParkourNPCById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourNPCById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkourNPC?(MotorParkourNPC.GetRootAsMotorParkourNPC(configBuffer));
				}
			}
			ConfigMotorParkourNPCById.LogPair.Clear();
			ConfigMotorParkourNPCById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorParkourNPCById.HandleId, 1, p0Id, ConfigMotorParkourNPCById.LogPair) || ConfigCommon.Step(ConfigMotorParkourNPCById.HandleId, true, ConfigMotorParkourNPCById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourNPCById.HandleId, ConfigMotorParkourNPCById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourNPCById.HandleId, 0, ConfigMotorParkourNPCById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourNPCById.HandleId, ConfigMotorParkourNPCById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkourNPC rootAsMotorParkourNPC = MotorParkourNPC.GetRootAsMotorParkourNPC(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourNPCById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourNPCById.HandleId, ConfigMotorParkourNPCById.LogPair);
			return new MotorParkourNPC?(rootAsMotorParkourNPC);
		}

		// Token: 0x04002894 RID: 10388
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002895 RID: 10389
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x04002896 RID: 10390
		private const string TABLE = "MotorParkourNPC";

		// Token: 0x04002897 RID: 10391
		private const string COMMAND = "select BinData from `MotorParkourNPC` where Id=?";

		// Token: 0x04002898 RID: 10392
		private const string KEY_PREFIX = "MotorParkourNPCById";

		// Token: 0x04002899 RID: 10393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400289A RID: 10394
		private static int HandleId;
	}
}
