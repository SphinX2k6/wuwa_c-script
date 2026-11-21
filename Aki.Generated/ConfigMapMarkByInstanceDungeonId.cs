using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052D RID: 1325
	public class ConfigMapMarkByInstanceDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x0010C7D8 File Offset: 0x0010A9D8
		static ConfigMapMarkByInstanceDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByInstanceDungeonId.CreateStaticDefaultValue), new Action(ConfigMapMarkByInstanceDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0010C7F8 File Offset: 0x0010A9F8
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByInstanceDungeonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByInstanceDungeonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where InstanceDungeonId=?")
			});
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0010C877 File Offset: 0x0010AA77
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByInstanceDungeonId.LogPair = null;
			ConfigMapMarkByInstanceDungeonId.HandleId = 0;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0010C885 File Offset: 0x0010AA85
		public static void Init()
		{
			ConfigMapMarkByInstanceDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByInstanceDungeonId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where InstanceDungeonId=?");
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0010C8A0 File Offset: 0x0010AAA0
		[NullableContext(2)]
		public static IReadOnlyList<MapMark> GetConfigList(int p0InstanceDungeonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByInstanceDungeonId.HandleId, ConfigMapMarkByInstanceDungeonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByInstanceDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceDungeonId);
				IReadOnlyList<MapMark> readOnlyList = (IReadOnlyList<MapMark>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapMarkByInstanceDungeonId.LogPair.Clear();
			ConfigMapMarkByInstanceDungeonId.LogPair.Add(new ValueTuple<string, object>("InstanceDungeonId", p0InstanceDungeonId));
			if (!ConfigCommon.BindInt(ConfigMapMarkByInstanceDungeonId.HandleId, 1, p0InstanceDungeonId, ConfigMapMarkByInstanceDungeonId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapMarkByInstanceDungeonId.HandleId, ConfigMapMarkByInstanceDungeonId.LogPair);
				return null;
			}
			List<MapMark> list = new List<MapMark>();
			while (ConfigCommon.Step(ConfigMapMarkByInstanceDungeonId.HandleId, false, ConfigMapMarkByInstanceDungeonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByInstanceDungeonId.HandleId, 0, ConfigMapMarkByInstanceDungeonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapMarkByInstanceDungeonId.HandleId, ConfigMapMarkByInstanceDungeonId.LogPair);
					return null;
				}
				MapMark rootAsMapMark = MapMark.GetRootAsMapMark(new ByteBuffer(item2));
				list.Add(rootAsMapMark);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByInstanceDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceDungeonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapMarkByInstanceDungeonId.HandleId, ConfigMapMarkByInstanceDungeonId.LogPair);
			return list;
		}

		// Token: 0x0400241F RID: 9247
		private const string DB = "db_map_mark.db";

		// Token: 0x04002420 RID: 9248
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002421 RID: 9249
		private const string TABLE = "MapMark";

		// Token: 0x04002422 RID: 9250
		private const string COMMAND = "select BinData from `MapMark` where InstanceDungeonId=?";

		// Token: 0x04002423 RID: 9251
		private const string KEY_PREFIX = "MapMarkByInstanceDungeonId";

		// Token: 0x04002424 RID: 9252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002425 RID: 9253
		private static int HandleId;
	}
}
