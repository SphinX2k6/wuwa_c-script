using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075A RID: 1882
	public class ConfigPlayerHeadReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x00156C47 File Offset: 0x00154E47
		static ConfigPlayerHeadReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerHeadReAll.CreateStaticDefaultValue), new Action(ConfigPlayerHeadReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00156C68 File Offset: 0x00154E68
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerHeadReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerHeadReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_playerhead.db"),
				new ValueTuple<string, object>("文件", "w.玩家头像.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerHeadRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerHeadRe`")
			});
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00156CE7 File Offset: 0x00154EE7
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerHeadReAll.LogPair = null;
			ConfigPlayerHeadReAll.HandleId = 0;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00156CF5 File Offset: 0x00154EF5
		public static void Init()
		{
			ConfigPlayerHeadReAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerHeadReAll.HandleId, "db_playerhead.db", "select BinData from `PlayerHeadRe`");
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00156D10 File Offset: 0x00154F10
		[NullableContext(2)]
		public static IReadOnlyList<PlayerHeadRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayerHeadRe> readOnlyList = (IReadOnlyList<PlayerHeadRe>)ConfigCommon.GetConfig("PlayerHeadReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayerHeadRe> list = new List<PlayerHeadRe>();
			while (ConfigCommon.Step(ConfigPlayerHeadReAll.HandleId, false, ConfigPlayerHeadReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerHeadReAll.HandleId, 0, ConfigPlayerHeadReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair);
					return null;
				}
				PlayerHeadRe rootAsPlayerHeadRe = PlayerHeadRe.GetRootAsPlayerHeadRe(new ByteBuffer(item2));
				list.Add(rootAsPlayerHeadRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayerHeadReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair);
			return list;
		}

		// Token: 0x0400335C RID: 13148
		private const string DB = "db_playerhead.db";

		// Token: 0x0400335D RID: 13149
		private const string FILE = "w.玩家头像.xlsx";

		// Token: 0x0400335E RID: 13150
		private const string TABLE = "PlayerHeadRe";

		// Token: 0x0400335F RID: 13151
		private const string COMMAND = "select BinData from `PlayerHeadRe`";

		// Token: 0x04003360 RID: 13152
		private const string KEY_PREFIX = "PlayerHeadReAll";

		// Token: 0x04003361 RID: 13153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003362 RID: 13154
		private static int HandleId;
	}
}
