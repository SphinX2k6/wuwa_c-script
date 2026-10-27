using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B8 RID: 184
	public class ConfigAtmosphereLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00072299 File Offset: 0x00070499
		static ConfigAtmosphereLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelById.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000722B8 File Offset: 0x000704B8
		public static void CreateStaticDefaultValue()
		{
			ConfigAtmosphereLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAtmosphereLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "AtmosphereLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AtmosphereLevel` where Id=?")
			});
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00072337 File Offset: 0x00070537
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelById.LogPair = null;
			ConfigAtmosphereLevelById.HandleId = 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00072345 File Offset: 0x00070545
		public static void Init()
		{
			ConfigAtmosphereLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelById.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel` where Id=?");
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00072360 File Offset: 0x00070560
		public static AtmosphereLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAtmosphereLevelById.HandleId, ConfigAtmosphereLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AtmosphereLevel?(AtmosphereLevel.GetRootAsAtmosphereLevel(configBuffer));
				}
			}
			ConfigAtmosphereLevelById.LogPair.Clear();
			ConfigAtmosphereLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAtmosphereLevelById.HandleId, 1, p0Id, ConfigAtmosphereLevelById.LogPair) || ConfigCommon.Step(ConfigAtmosphereLevelById.HandleId, true, ConfigAtmosphereLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAtmosphereLevelById.HandleId, ConfigAtmosphereLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAtmosphereLevelById.HandleId, 0, ConfigAtmosphereLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAtmosphereLevelById.HandleId, ConfigAtmosphereLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AtmosphereLevel rootAsAtmosphereLevel = AtmosphereLevel.GetRootAsAtmosphereLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAtmosphereLevelById.HandleId, ConfigAtmosphereLevelById.LogPair);
			return new AtmosphereLevel?(rootAsAtmosphereLevel);
		}

		// Token: 0x040004EC RID: 1260
		private const string DB = "db_spring26.db";

		// Token: 0x040004ED RID: 1261
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040004EE RID: 1262
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x040004EF RID: 1263
		private const string COMMAND = "select BinData from `AtmosphereLevel` where Id=?";

		// Token: 0x040004F0 RID: 1264
		private const string KEY_PREFIX = "AtmosphereLevelById";

		// Token: 0x040004F1 RID: 1265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004F2 RID: 1266
		private static int HandleId;
	}
}
