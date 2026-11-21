using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052E RID: 1326
	public class ConfigMapMarkByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x0010CA0F File Offset: 0x0010AC0F
		static ConfigMapMarkByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByMapId.CreateStaticDefaultValue), new Action(ConfigMapMarkByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0010CA30 File Offset: 0x0010AC30
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

		// Token: 0x06001F21 RID: 7969 RVA: 0x0010CAAF File Offset: 0x0010ACAF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByMapId.LogPair = null;
			ConfigMapMarkByMapId.HandleId = 0;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0010CABD File Offset: 0x0010ACBD
		public static void Init()
		{
			ConfigMapMarkByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByMapId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where MapId=?");
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0010CAD8 File Offset: 0x0010ACD8
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

		// Token: 0x04002426 RID: 9254
		private const string DB = "db_map_mark.db";

		// Token: 0x04002427 RID: 9255
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002428 RID: 9256
		private const string TABLE = "MapMark";

		// Token: 0x04002429 RID: 9257
		private const string COMMAND = "select BinData from `MapMark` where MapId=?";

		// Token: 0x0400242A RID: 9258
		private const string KEY_PREFIX = "MapMarkByMapId";

		// Token: 0x0400242B RID: 9259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400242C RID: 9260
		private static int HandleId;
	}
}
