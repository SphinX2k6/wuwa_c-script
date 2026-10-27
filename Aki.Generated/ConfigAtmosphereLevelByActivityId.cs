using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B6 RID: 182
	public class ConfigAtmosphereLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x00071DC3 File Offset: 0x0006FFC3
		static ConfigAtmosphereLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00071DE4 File Offset: 0x0006FFE4
		public static void CreateStaticDefaultValue()
		{
			ConfigAtmosphereLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAtmosphereLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "AtmosphereLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AtmosphereLevel` where ActivityId=?")
			});
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00071E63 File Offset: 0x00070063
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelByActivityId.LogPair = null;
			ConfigAtmosphereLevelByActivityId.HandleId = 0;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00071E71 File Offset: 0x00070071
		public static void Init()
		{
			ConfigAtmosphereLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelByActivityId.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel` where ActivityId=?");
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00071E8C File Offset: 0x0007008C
		[NullableContext(2)]
		public static IReadOnlyList<AtmosphereLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAtmosphereLevelByActivityId.HandleId, ConfigAtmosphereLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<AtmosphereLevel> readOnlyList = (IReadOnlyList<AtmosphereLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAtmosphereLevelByActivityId.LogPair.Clear();
			ConfigAtmosphereLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigAtmosphereLevelByActivityId.HandleId, 1, p0ActivityId, ConfigAtmosphereLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigAtmosphereLevelByActivityId.HandleId, ConfigAtmosphereLevelByActivityId.LogPair);
				return null;
			}
			List<AtmosphereLevel> list = new List<AtmosphereLevel>();
			while (ConfigCommon.Step(ConfigAtmosphereLevelByActivityId.HandleId, false, ConfigAtmosphereLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAtmosphereLevelByActivityId.HandleId, 0, ConfigAtmosphereLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAtmosphereLevelByActivityId.HandleId, ConfigAtmosphereLevelByActivityId.LogPair);
					return null;
				}
				AtmosphereLevel rootAsAtmosphereLevel = AtmosphereLevel.GetRootAsAtmosphereLevel(new ByteBuffer(item2));
				list.Add(rootAsAtmosphereLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AtmosphereLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAtmosphereLevelByActivityId.HandleId, ConfigAtmosphereLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x040004DE RID: 1246
		private const string DB = "db_spring26.db";

		// Token: 0x040004DF RID: 1247
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040004E0 RID: 1248
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x040004E1 RID: 1249
		private const string COMMAND = "select BinData from `AtmosphereLevel` where ActivityId=?";

		// Token: 0x040004E2 RID: 1250
		private const string KEY_PREFIX = "AtmosphereLevelByActivityId";

		// Token: 0x040004E3 RID: 1251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004E4 RID: 1252
		private static int HandleId;
	}
}
