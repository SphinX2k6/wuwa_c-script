using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075D RID: 1885
	public class ConfigPlayerTitleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C3F RID: 11327 RVA: 0x0015726C File Offset: 0x0015546C
		static ConfigPlayerTitleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerTitleAll.CreateStaticDefaultValue), new Action(ConfigPlayerTitleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x0015728C File Offset: 0x0015548C
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerTitleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerTitleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personaltitle.db"),
				new ValueTuple<string, object>("文件", "c.称号.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerTitle`")
			});
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x0015730B File Offset: 0x0015550B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerTitleAll.LogPair = null;
			ConfigPlayerTitleAll.HandleId = 0;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00157319 File Offset: 0x00155519
		public static void Init()
		{
			ConfigPlayerTitleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerTitleAll.HandleId, "db_personaltitle.db", "select BinData from `PlayerTitle`");
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00157334 File Offset: 0x00155534
		[NullableContext(2)]
		public static IReadOnlyList<PlayerTitle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerTitleAll.HandleId, ConfigPlayerTitleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayerTitle> readOnlyList = (IReadOnlyList<PlayerTitle>)ConfigCommon.GetConfig("PlayerTitleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayerTitle> list = new List<PlayerTitle>();
			while (ConfigCommon.Step(ConfigPlayerTitleAll.HandleId, false, ConfigPlayerTitleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerTitleAll.HandleId, 0, ConfigPlayerTitleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerTitleAll.HandleId, ConfigPlayerTitleAll.LogPair);
					return null;
				}
				PlayerTitle rootAsPlayerTitle = PlayerTitle.GetRootAsPlayerTitle(new ByteBuffer(item2));
				list.Add(rootAsPlayerTitle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayerTitleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerTitleAll.HandleId, ConfigPlayerTitleAll.LogPair);
			return list;
		}

		// Token: 0x04003371 RID: 13169
		private const string DB = "db_personaltitle.db";

		// Token: 0x04003372 RID: 13170
		private const string FILE = "c.称号.xlsx";

		// Token: 0x04003373 RID: 13171
		private const string TABLE = "PlayerTitle";

		// Token: 0x04003374 RID: 13172
		private const string COMMAND = "select BinData from `PlayerTitle`";

		// Token: 0x04003375 RID: 13173
		private const string KEY_PREFIX = "PlayerTitleAll";

		// Token: 0x04003376 RID: 13174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003377 RID: 13175
		private static int HandleId;
	}
}
