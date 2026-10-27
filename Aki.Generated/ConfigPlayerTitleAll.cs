using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000745 RID: 1861
	public class ConfigPlayerTitleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BAF RID: 11183 RVA: 0x001507F0 File Offset: 0x0014E9F0
		static ConfigPlayerTitleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerTitleAll.CreateStaticDefaultValue), new Action(ConfigPlayerTitleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00150810 File Offset: 0x0014EA10
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

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0015088F File Offset: 0x0014EA8F
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerTitleAll.LogPair = null;
			ConfigPlayerTitleAll.HandleId = 0;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0015089D File Offset: 0x0014EA9D
		public static void Init()
		{
			ConfigPlayerTitleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerTitleAll.HandleId, "db_personaltitle.db", "select BinData from `PlayerTitle`");
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x001508B8 File Offset: 0x0014EAB8
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

		// Token: 0x040032C9 RID: 13001
		private const string DB = "db_personaltitle.db";

		// Token: 0x040032CA RID: 13002
		private const string FILE = "c.称号.xlsx";

		// Token: 0x040032CB RID: 13003
		private const string TABLE = "PlayerTitle";

		// Token: 0x040032CC RID: 13004
		private const string COMMAND = "select BinData from `PlayerTitle`";

		// Token: 0x040032CD RID: 13005
		private const string KEY_PREFIX = "PlayerTitleAll";

		// Token: 0x040032CE RID: 13006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032CF RID: 13007
		private static int HandleId;
	}
}
