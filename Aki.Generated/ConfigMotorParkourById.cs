using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B7 RID: 1463
	public class ConfigMotorParkourById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002257 RID: 8791 RVA: 0x0011BB33 File Offset: 0x00119D33
		static ConfigMotorParkourById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourById.CreateStaticDefaultValue), new Action(ConfigMotorParkourById.ResetStaticDefaultValue));
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0011BB54 File Offset: 0x00119D54
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

		// Token: 0x06002259 RID: 8793 RVA: 0x0011BBD3 File Offset: 0x00119DD3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourById.LogPair = null;
			ConfigMotorParkourById.HandleId = 0;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0011BBE1 File Offset: 0x00119DE1
		public static void Init()
		{
			ConfigMotorParkourById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour` where Id=?");
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0011BBFC File Offset: 0x00119DFC
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

		// Token: 0x040027E5 RID: 10213
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027E6 RID: 10214
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027E7 RID: 10215
		private const string TABLE = "MotorParkour";

		// Token: 0x040027E8 RID: 10216
		private const string COMMAND = "select BinData from `MotorParkour` where Id=?";

		// Token: 0x040027E9 RID: 10217
		private const string KEY_PREFIX = "MotorParkourById";

		// Token: 0x040027EA RID: 10218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027EB RID: 10219
		private static int HandleId;
	}
}
