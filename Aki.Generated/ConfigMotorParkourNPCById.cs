using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B9 RID: 1465
	public class ConfigMotorParkourNPCById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x0011BFC4 File Offset: 0x0011A1C4
		static ConfigMotorParkourNPCById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourNPCById.CreateStaticDefaultValue), new Action(ConfigMotorParkourNPCById.ResetStaticDefaultValue));
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0011BFE4 File Offset: 0x0011A1E4
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

		// Token: 0x06002265 RID: 8805 RVA: 0x0011C063 File Offset: 0x0011A263
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourNPCById.LogPair = null;
			ConfigMotorParkourNPCById.HandleId = 0;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0011C071 File Offset: 0x0011A271
		public static void Init()
		{
			ConfigMotorParkourNPCById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourNPCById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourNPC` where Id=?");
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0011C08C File Offset: 0x0011A28C
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

		// Token: 0x040027F3 RID: 10227
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027F4 RID: 10228
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027F5 RID: 10229
		private const string TABLE = "MotorParkourNPC";

		// Token: 0x040027F6 RID: 10230
		private const string COMMAND = "select BinData from `MotorParkourNPC` where Id=?";

		// Token: 0x040027F7 RID: 10231
		private const string KEY_PREFIX = "MotorParkourNPCById";

		// Token: 0x040027F8 RID: 10232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027F9 RID: 10233
		private static int HandleId;
	}
}
