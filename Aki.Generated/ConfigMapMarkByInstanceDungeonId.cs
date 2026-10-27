using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000517 RID: 1303
	public class ConfigMapMarkByInstanceDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E95 RID: 7829 RVA: 0x00106084 File Offset: 0x00104284
		static ConfigMapMarkByInstanceDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByInstanceDungeonId.CreateStaticDefaultValue), new Action(ConfigMapMarkByInstanceDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x001060A4 File Offset: 0x001042A4
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

		// Token: 0x06001E97 RID: 7831 RVA: 0x00106123 File Offset: 0x00104323
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByInstanceDungeonId.LogPair = null;
			ConfigMapMarkByInstanceDungeonId.HandleId = 0;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00106131 File Offset: 0x00104331
		public static void Init()
		{
			ConfigMapMarkByInstanceDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByInstanceDungeonId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where InstanceDungeonId=?");
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0010614C File Offset: 0x0010434C
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

		// Token: 0x04002385 RID: 9093
		private const string DB = "db_map_mark.db";

		// Token: 0x04002386 RID: 9094
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002387 RID: 9095
		private const string TABLE = "MapMark";

		// Token: 0x04002388 RID: 9096
		private const string COMMAND = "select BinData from `MapMark` where InstanceDungeonId=?";

		// Token: 0x04002389 RID: 9097
		private const string KEY_PREFIX = "MapMarkByInstanceDungeonId";

		// Token: 0x0400238A RID: 9098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400238B RID: 9099
		private static int HandleId;
	}
}
