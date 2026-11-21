using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025B RID: 603
	public class ConfigDynamicMapMarkByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x000ACFD3 File Offset: 0x000AB1D3
		static ConfigDynamicMapMarkByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkByMapId.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000ACFF4 File Offset: 0x000AB1F4
		public static void CreateStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDynamicMapMarkByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "DynamicMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `DynamicMapMark` where MapId=?")
			});
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000AD073 File Offset: 0x000AB273
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMapId.LogPair = null;
			ConfigDynamicMapMarkByMapId.HandleId = 0;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000AD081 File Offset: 0x000AB281
		public static void Init()
		{
			ConfigDynamicMapMarkByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkByMapId.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark` where MapId=?");
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000AD09C File Offset: 0x000AB29C
		[NullableContext(2)]
		public static IReadOnlyList<DynamicMapMark> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDynamicMapMarkByMapId.HandleId, ConfigDynamicMapMarkByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<DynamicMapMark> readOnlyList = (IReadOnlyList<DynamicMapMark>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDynamicMapMarkByMapId.LogPair.Clear();
			ConfigDynamicMapMarkByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigDynamicMapMarkByMapId.HandleId, 1, p0MapId, ConfigDynamicMapMarkByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigDynamicMapMarkByMapId.HandleId, ConfigDynamicMapMarkByMapId.LogPair);
				return null;
			}
			List<DynamicMapMark> list = new List<DynamicMapMark>();
			while (ConfigCommon.Step(ConfigDynamicMapMarkByMapId.HandleId, false, ConfigDynamicMapMarkByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDynamicMapMarkByMapId.HandleId, 0, ConfigDynamicMapMarkByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDynamicMapMarkByMapId.HandleId, ConfigDynamicMapMarkByMapId.LogPair);
					return null;
				}
				DynamicMapMark rootAsDynamicMapMark = DynamicMapMark.GetRootAsDynamicMapMark(new ByteBuffer(item2));
				list.Add(rootAsDynamicMapMark);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDynamicMapMarkByMapId.HandleId, ConfigDynamicMapMarkByMapId.LogPair);
			return list;
		}

		// Token: 0x04001061 RID: 4193
		private const string DB = "db_map_mark.db";

		// Token: 0x04001062 RID: 4194
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04001063 RID: 4195
		private const string TABLE = "DynamicMapMark";

		// Token: 0x04001064 RID: 4196
		private const string COMMAND = "select BinData from `DynamicMapMark` where MapId=?";

		// Token: 0x04001065 RID: 4197
		private const string KEY_PREFIX = "DynamicMapMarkByMapId";

		// Token: 0x04001066 RID: 4198
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001067 RID: 4199
		private static int HandleId;
	}
}
