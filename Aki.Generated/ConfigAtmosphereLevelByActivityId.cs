using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BE RID: 190
	public class ConfigAtmosphereLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x00076677 File Offset: 0x00074877
		static ConfigAtmosphereLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAtmosphereLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigAtmosphereLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00076698 File Offset: 0x00074898
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

		// Token: 0x06000477 RID: 1143 RVA: 0x00076717 File Offset: 0x00074917
		public static void ResetStaticDefaultValue()
		{
			ConfigAtmosphereLevelByActivityId.LogPair = null;
			ConfigAtmosphereLevelByActivityId.HandleId = 0;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00076725 File Offset: 0x00074925
		public static void Init()
		{
			ConfigAtmosphereLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAtmosphereLevelByActivityId.HandleId, "db_spring26.db", "select BinData from `AtmosphereLevel` where ActivityId=?");
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00076740 File Offset: 0x00074940
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

		// Token: 0x04000516 RID: 1302
		private const string DB = "db_spring26.db";

		// Token: 0x04000517 RID: 1303
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04000518 RID: 1304
		private const string TABLE = "AtmosphereLevel";

		// Token: 0x04000519 RID: 1305
		private const string COMMAND = "select BinData from `AtmosphereLevel` where ActivityId=?";

		// Token: 0x0400051A RID: 1306
		private const string KEY_PREFIX = "AtmosphereLevelByActivityId";

		// Token: 0x0400051B RID: 1307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400051C RID: 1308
		private static int HandleId;
	}
}
