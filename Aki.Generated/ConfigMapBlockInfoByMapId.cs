using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000523 RID: 1315
	public class ConfigMapBlockInfoByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x0010B24C File Offset: 0x0010944C
		static ConfigMapBlockInfoByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoByMapId.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0010B26C File Offset: 0x0010946C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBlockInfoByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBlockInfoByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "MapBlockInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBlockInfo` where MapId=?")
			});
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0010B2EB File Offset: 0x001094EB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoByMapId.LogPair = null;
			ConfigMapBlockInfoByMapId.HandleId = 0;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0010B2F9 File Offset: 0x001094F9
		public static void Init()
		{
			ConfigMapBlockInfoByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoByMapId.HandleId, "db_download.db", "select BinData from `MapBlockInfo` where MapId=?");
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0010B314 File Offset: 0x00109514
		[NullableContext(2)]
		public static IReadOnlyList<MapBlockInfo> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBlockInfoByMapId.HandleId, ConfigMapBlockInfoByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBlockInfoByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<MapBlockInfo> readOnlyList = (IReadOnlyList<MapBlockInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapBlockInfoByMapId.LogPair.Clear();
			ConfigMapBlockInfoByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigMapBlockInfoByMapId.HandleId, 1, p0MapId, ConfigMapBlockInfoByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapBlockInfoByMapId.HandleId, ConfigMapBlockInfoByMapId.LogPair);
				return null;
			}
			List<MapBlockInfo> list = new List<MapBlockInfo>();
			while (ConfigCommon.Step(ConfigMapBlockInfoByMapId.HandleId, false, ConfigMapBlockInfoByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBlockInfoByMapId.HandleId, 0, ConfigMapBlockInfoByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapBlockInfoByMapId.HandleId, ConfigMapBlockInfoByMapId.LogPair);
					return null;
				}
				MapBlockInfo rootAsMapBlockInfo = MapBlockInfo.GetRootAsMapBlockInfo(new ByteBuffer(item2));
				list.Add(rootAsMapBlockInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBlockInfoByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapBlockInfoByMapId.HandleId, ConfigMapBlockInfoByMapId.LogPair);
			return list;
		}

		// Token: 0x040023D9 RID: 9177
		private const string DB = "db_download.db";

		// Token: 0x040023DA RID: 9178
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040023DB RID: 9179
		private const string TABLE = "MapBlockInfo";

		// Token: 0x040023DC RID: 9180
		private const string COMMAND = "select BinData from `MapBlockInfo` where MapId=?";

		// Token: 0x040023DD RID: 9181
		private const string KEY_PREFIX = "MapBlockInfoByMapId";

		// Token: 0x040023DE RID: 9182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023DF RID: 9183
		private static int HandleId;
	}
}
