using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C0 RID: 192
	public class ConfigAtmosphereLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00076B4D File Offset: 0x00074D4D
		static ConfigAtmosphereLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelById.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00076B6C File Offset: 0x00074D6C
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

		// Token: 0x06000483 RID: 1155 RVA: 0x00076BEB File Offset: 0x00074DEB
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelById.LogPair = null;
			ConfigAtmosphereLevelById.HandleId = 0;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00076BF9 File Offset: 0x00074DF9
		public static void Init()
		{
			ConfigAtmosphereLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelById.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel` where Id=?");
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00076C14 File Offset: 0x00074E14
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

		// Token: 0x04000524 RID: 1316
		private const string DB = "db_spring26.db";

		// Token: 0x04000525 RID: 1317
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04000526 RID: 1318
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x04000527 RID: 1319
		private const string COMMAND = "select BinData from `AtmosphereLevel` where Id=?";

		// Token: 0x04000528 RID: 1320
		private const string KEY_PREFIX = "AtmosphereLevelById";

		// Token: 0x04000529 RID: 1321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400052A RID: 1322
		private static int HandleId;
	}
}
