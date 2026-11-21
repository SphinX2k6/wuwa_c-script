using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000285 RID: 645
	public class ConfigEncircleMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x000B27F0 File Offset: 0x000B09F0
		static ConfigEncircleMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleMapByMapId.CreateStaticDefaultValue), new Action(ConfigEncircleMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000B2810 File Offset: 0x000B0A10
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleMapByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleMapByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleMap"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleMap` where MapId=?")
			});
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000B288F File Offset: 0x000B0A8F
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleMapByMapId.LogPair = null;
			ConfigEncircleMapByMapId.HandleId = 0;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000B289D File Offset: 0x000B0A9D
		public static void Init()
		{
			ConfigEncircleMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleMapByMapId.HandleId, "db_encircle.db", "select BinData from `EncircleMap` where MapId=?");
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000B28B8 File Offset: 0x000B0AB8
		[NullableContext(2)]
		public static IReadOnlyList<EncircleMap> GetConfigList(int p0MapID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleMapByMapId.HandleId, ConfigEncircleMapByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapID);
				IReadOnlyList<EncircleMap> readOnlyList = (IReadOnlyList<EncircleMap>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEncircleMapByMapId.LogPair.Clear();
			ConfigEncircleMapByMapId.LogPair.Add(new ValueTuple<string, object>("MapID", p0MapID));
			if (!ConfigCommon.BindInt(ConfigEncircleMapByMapId.HandleId, 1, p0MapID, ConfigEncircleMapByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigEncircleMapByMapId.HandleId, ConfigEncircleMapByMapId.LogPair);
				return null;
			}
			List<EncircleMap> list = new List<EncircleMap>();
			while (ConfigCommon.Step(ConfigEncircleMapByMapId.HandleId, false, ConfigEncircleMapByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleMapByMapId.HandleId, 0, ConfigEncircleMapByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEncircleMapByMapId.HandleId, ConfigEncircleMapByMapId.LogPair);
					return null;
				}
				EncircleMap rootAsEncircleMap = EncircleMap.GetRootAsEncircleMap(new ByteBuffer(item2));
				list.Add(rootAsEncircleMap);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapID);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEncircleMapByMapId.HandleId, ConfigEncircleMapByMapId.LogPair);
			return list;
		}

		// Token: 0x04001187 RID: 4487
		private const string DB = "db_encircle.db";

		// Token: 0x04001188 RID: 4488
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x04001189 RID: 4489
		private const string TABLE = "EncircleMap";

		// Token: 0x0400118A RID: 4490
		private const string COMMAND = "select BinData from `EncircleMap` where MapId=?";

		// Token: 0x0400118B RID: 4491
		private const string KEY_PREFIX = "EncircleMapByMapId";

		// Token: 0x0400118C RID: 4492
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400118D RID: 4493
		private static int HandleId;
	}
}
