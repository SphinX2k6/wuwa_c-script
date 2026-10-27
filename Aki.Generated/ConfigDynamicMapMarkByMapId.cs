using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000247 RID: 583
	public class ConfigDynamicMapMarkByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x000A6D0F File Offset: 0x000A4F0F
		static ConfigDynamicMapMarkByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkByMapId.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000A6D30 File Offset: 0x000A4F30
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

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000A6DAF File Offset: 0x000A4FAF
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMapId.LogPair = null;
			ConfigDynamicMapMarkByMapId.HandleId = 0;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000A6DBD File Offset: 0x000A4FBD
		public static void Init()
		{
			ConfigDynamicMapMarkByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkByMapId.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark` where MapId=?");
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000A6DD8 File Offset: 0x000A4FD8
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

		// Token: 0x04000FD5 RID: 4053
		private const string DB = "db_map_mark.db";

		// Token: 0x04000FD6 RID: 4054
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04000FD7 RID: 4055
		private const string TABLE = "DynamicMapMark";

		// Token: 0x04000FD8 RID: 4056
		private const string COMMAND = "select BinData from `DynamicMapMark` where MapId=?";

		// Token: 0x04000FD9 RID: 4057
		private const string KEY_PREFIX = "DynamicMapMarkByMapId";

		// Token: 0x04000FDA RID: 4058
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FDB RID: 4059
		private static int HandleId;
	}
}
