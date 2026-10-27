using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050D RID: 1293
	public class ConfigMapBlockInfoByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x00104AF8 File Offset: 0x00102CF8
		static ConfigMapBlockInfoByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBlockInfoByMapId.CreateStaticDefaultValue), new Action(ConfigMapBlockInfoByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00104B18 File Offset: 0x00102D18
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x00104B97 File Offset: 0x00102D97
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBlockInfoByMapId.LogPair = null;
			ConfigMapBlockInfoByMapId.HandleId = 0;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00104BA5 File Offset: 0x00102DA5
		public static void Init()
		{
			ConfigMapBlockInfoByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBlockInfoByMapId.HandleId, "db_download.db", "select BinData from `MapBlockInfo` where MapId=?");
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00104BC0 File Offset: 0x00102DC0
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

		// Token: 0x0400233F RID: 9023
		private const string DB = "db_download.db";

		// Token: 0x04002340 RID: 9024
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04002341 RID: 9025
		private const string TABLE = "MapBlockInfo";

		// Token: 0x04002342 RID: 9026
		private const string COMMAND = "select BinData from `MapBlockInfo` where MapId=?";

		// Token: 0x04002343 RID: 9027
		private const string KEY_PREFIX = "MapBlockInfoByMapId";

		// Token: 0x04002344 RID: 9028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002345 RID: 9029
		private static int HandleId;
	}
}
