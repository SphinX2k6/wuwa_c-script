using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000513 RID: 1299
	public class ConfigMapLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E7D RID: 7805 RVA: 0x00105828 File Offset: 0x00103A28
		static ConfigMapLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigMapLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00105848 File Offset: 0x00103A48
		public static void CreateStaticDefaultValue()
		{
			ConfigMapLevelExpByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapLevelExpByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "MapLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `MapLevelExp` where ActivityId=?")
			});
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x001058C7 File Offset: 0x00103AC7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapLevelExpByActivityId.LogPair = null;
			ConfigMapLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x001058D5 File Offset: 0x00103AD5
		public static void Init()
		{
			ConfigMapLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMapLevelExpByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `MapLevelExp` where ActivityId=?");
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x001058F0 File Offset: 0x00103AF0
		[NullableContext(2)]
		public static IReadOnlyList<MapLevelExp> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapLevelExpByActivityId.HandleId, ConfigMapLevelExpByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MapLevelExp> readOnlyList = (IReadOnlyList<MapLevelExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapLevelExpByActivityId.LogPair.Clear();
			ConfigMapLevelExpByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMapLevelExpByActivityId.HandleId, 1, p0ActivityId, ConfigMapLevelExpByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapLevelExpByActivityId.HandleId, ConfigMapLevelExpByActivityId.LogPair);
				return null;
			}
			List<MapLevelExp> list = new List<MapLevelExp>();
			while (ConfigCommon.Step(ConfigMapLevelExpByActivityId.HandleId, false, ConfigMapLevelExpByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapLevelExpByActivityId.HandleId, 0, ConfigMapLevelExpByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapLevelExpByActivityId.HandleId, ConfigMapLevelExpByActivityId.LogPair);
					return null;
				}
				MapLevelExp rootAsMapLevelExp = MapLevelExp.GetRootAsMapLevelExp(new ByteBuffer(item2));
				list.Add(rootAsMapLevelExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapLevelExpByActivityId.HandleId, ConfigMapLevelExpByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002369 RID: 9065
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x0400236A RID: 9066
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400236B RID: 9067
		private const string TABLE = "MapLevelExp";

		// Token: 0x0400236C RID: 9068
		private const string COMMAND = "select BinData from `MapLevelExp` where ActivityId=?";

		// Token: 0x0400236D RID: 9069
		private const string KEY_PREFIX = "MapLevelExpByActivityId";

		// Token: 0x0400236E RID: 9070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400236F RID: 9071
		private static int HandleId;
	}
}
