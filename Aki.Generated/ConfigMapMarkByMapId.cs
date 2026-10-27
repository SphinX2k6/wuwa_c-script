using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000518 RID: 1304
	public class ConfigMapMarkByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E9B RID: 7835 RVA: 0x001062BB File Offset: 0x001044BB
		static ConfigMapMarkByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByMapId.CreateStaticDefaultValue), new Action(ConfigMapMarkByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x001062DC File Offset: 0x001044DC
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where MapId=?")
			});
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0010635B File Offset: 0x0010455B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByMapId.LogPair = null;
			ConfigMapMarkByMapId.HandleId = 0;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00106369 File Offset: 0x00104569
		public static void Init()
		{
			ConfigMapMarkByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByMapId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where MapId=?");
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00106384 File Offset: 0x00104584
		[NullableContext(2)]
		public static IReadOnlyList<MapMark> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByMapId.HandleId, ConfigMapMarkByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<MapMark> readOnlyList = (IReadOnlyList<MapMark>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapMarkByMapId.LogPair.Clear();
			ConfigMapMarkByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigMapMarkByMapId.HandleId, 1, p0MapId, ConfigMapMarkByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapMarkByMapId.HandleId, ConfigMapMarkByMapId.LogPair);
				return null;
			}
			List<MapMark> list = new List<MapMark>();
			while (ConfigCommon.Step(ConfigMapMarkByMapId.HandleId, false, ConfigMapMarkByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByMapId.HandleId, 0, ConfigMapMarkByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapMarkByMapId.HandleId, ConfigMapMarkByMapId.LogPair);
					return null;
				}
				MapMark rootAsMapMark = MapMark.GetRootAsMapMark(new ByteBuffer(item2));
				list.Add(rootAsMapMark);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapMarkByMapId.HandleId, ConfigMapMarkByMapId.LogPair);
			return list;
		}

		// Token: 0x0400238C RID: 9100
		private const string DB = "db_map_mark.db";

		// Token: 0x0400238D RID: 9101
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400238E RID: 9102
		private const string TABLE = "MapMark";

		// Token: 0x0400238F RID: 9103
		private const string COMMAND = "select BinData from `MapMark` where MapId=?";

		// Token: 0x04002390 RID: 9104
		private const string KEY_PREFIX = "MapMarkByMapId";

		// Token: 0x04002391 RID: 9105
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002392 RID: 9106
		private static int HandleId;
	}
}
