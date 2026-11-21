using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000529 RID: 1321
	public class ConfigMapLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F01 RID: 7937 RVA: 0x0010BF7C File Offset: 0x0010A17C
		static ConfigMapLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigMapLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0010BF9C File Offset: 0x0010A19C
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

		// Token: 0x06001F03 RID: 7939 RVA: 0x0010C01B File Offset: 0x0010A21B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapLevelExpByActivityId.LogPair = null;
			ConfigMapLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0010C029 File Offset: 0x0010A229
		public static void Init()
		{
			ConfigMapLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMapLevelExpByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `MapLevelExp` where ActivityId=?");
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0010C044 File Offset: 0x0010A244
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

		// Token: 0x04002403 RID: 9219
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002404 RID: 9220
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002405 RID: 9221
		private const string TABLE = "MapLevelExp";

		// Token: 0x04002406 RID: 9222
		private const string COMMAND = "select BinData from `MapLevelExp` where ActivityId=?";

		// Token: 0x04002407 RID: 9223
		private const string KEY_PREFIX = "MapLevelExpByActivityId";

		// Token: 0x04002408 RID: 9224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002409 RID: 9225
		private static int HandleId;
	}
}
