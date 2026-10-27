using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000271 RID: 625
	public class ConfigEncircleMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EAB RID: 3755 RVA: 0x000AC52C File Offset: 0x000AA72C
		static ConfigEncircleMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleMapByMapId.CreateStaticDefaultValue), new Action(ConfigEncircleMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000AC54C File Offset: 0x000AA74C
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

		// Token: 0x06000EAD RID: 3757 RVA: 0x000AC5CB File Offset: 0x000AA7CB
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleMapByMapId.LogPair = null;
			ConfigEncircleMapByMapId.HandleId = 0;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000AC5D9 File Offset: 0x000AA7D9
		public static void Init()
		{
			ConfigEncircleMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleMapByMapId.HandleId, "db_encircle.db", "select BinData from `EncircleMap` where MapId=?");
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000AC5F4 File Offset: 0x000AA7F4
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

		// Token: 0x040010FB RID: 4347
		private const string DB = "db_encircle.db";

		// Token: 0x040010FC RID: 4348
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x040010FD RID: 4349
		private const string TABLE = "EncircleMap";

		// Token: 0x040010FE RID: 4350
		private const string COMMAND = "select BinData from `EncircleMap` where MapId=?";

		// Token: 0x040010FF RID: 4351
		private const string KEY_PREFIX = "EncircleMapByMapId";

		// Token: 0x04001100 RID: 4352
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001101 RID: 4353
		private static int HandleId;
	}
}
