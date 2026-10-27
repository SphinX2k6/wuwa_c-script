using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B7 RID: 183
	public class ConfigAtmosphereLevelByActivityIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x00071FFB File Offset: 0x000701FB
		static ConfigAtmosphereLevelByActivityIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelByActivityIdAndLevel.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelByActivityIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0007201C File Offset: 0x0007021C
		public static void CreateStaticDefaultValue()
		{
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "AtmosphereLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AtmosphereLevel` where ActivityId=? AND Level=?")
			});
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0007209B File Offset: 0x0007029B
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair = null;
			ConfigAtmosphereLevelByActivityIdAndLevel.HandleId = 0;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000720A9 File Offset: 0x000702A9
		public static void Init()
		{
			ConfigAtmosphereLevelByActivityIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel` where ActivityId=? AND Level=?");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000720C4 File Offset: 0x000702C4
		public static AtmosphereLevel? GetConfig(int p0ActivityId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AtmosphereLevel?(AtmosphereLevel.GetRootAsAtmosphereLevel(configBuffer));
				}
			}
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair.Clear();
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigAtmosphereLevelByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, 1, p0ActivityId, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, 2, p1Level, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair) || ConfigCommon.Step(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, true, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, 0, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AtmosphereLevel rootAsAtmosphereLevel = AtmosphereLevel.GetRootAsAtmosphereLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAtmosphereLevelByActivityIdAndLevel.HandleId, ConfigAtmosphereLevelByActivityIdAndLevel.LogPair);
			return new AtmosphereLevel?(rootAsAtmosphereLevel);
		}

		// Token: 0x040004E5 RID: 1253
		private const string DB = "db_spring26.db";

		// Token: 0x040004E6 RID: 1254
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040004E7 RID: 1255
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x040004E8 RID: 1256
		private const string COMMAND = "select BinData from `AtmosphereLevel` where ActivityId=? AND Level=?";

		// Token: 0x040004E9 RID: 1257
		private const string KEY_PREFIX = "AtmosphereLevelByActivityIdAndLevel";

		// Token: 0x040004EA RID: 1258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004EB RID: 1259
		private static int HandleId;
	}
}
