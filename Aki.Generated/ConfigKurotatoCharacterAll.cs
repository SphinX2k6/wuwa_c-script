using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000487 RID: 1159
	public class ConfigKurotatoCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x000F31FC File Offset: 0x000F13FC
		static ConfigKurotatoCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterAll.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000F321C File Offset: 0x000F141C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoCharacterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoCharacterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoCharacter`")
			});
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000F329B File Offset: 0x000F149B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterAll.LogPair = null;
			ConfigKurotatoCharacterAll.HandleId = 0;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000F32A9 File Offset: 0x000F14A9
		public static void Init()
		{
			ConfigKurotatoCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter`");
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000F32C4 File Offset: 0x000F14C4
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoCharacter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoCharacterAll.HandleId, ConfigKurotatoCharacterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoCharacter> readOnlyList = (IReadOnlyList<KurotatoCharacter>)ConfigCommon.GetConfig("KurotatoCharacterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoCharacter> list = new List<KurotatoCharacter>();
			while (ConfigCommon.Step(ConfigKurotatoCharacterAll.HandleId, false, ConfigKurotatoCharacterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoCharacterAll.HandleId, 0, ConfigKurotatoCharacterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoCharacterAll.HandleId, ConfigKurotatoCharacterAll.LogPair);
					return null;
				}
				KurotatoCharacter rootAsKurotatoCharacter = KurotatoCharacter.GetRootAsKurotatoCharacter(new ByteBuffer(item2));
				list.Add(rootAsKurotatoCharacter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoCharacterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoCharacterAll.HandleId, ConfigKurotatoCharacterAll.LogPair);
			return list;
		}

		// Token: 0x04001F95 RID: 8085
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F96 RID: 8086
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04001F97 RID: 8087
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04001F98 RID: 8088
		private const string COMMAND = "select BinData from `KurotatoCharacter`";

		// Token: 0x04001F99 RID: 8089
		private const string KEY_PREFIX = "KurotatoCharacterAll";

		// Token: 0x04001F9A RID: 8090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F9B RID: 8091
		private static int HandleId;
	}
}
