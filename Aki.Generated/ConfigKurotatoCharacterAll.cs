using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049D RID: 1181
	public class ConfigKurotatoCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BB8 RID: 7096 RVA: 0x000F9950 File Offset: 0x000F7B50
		static ConfigKurotatoCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterAll.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000F9970 File Offset: 0x000F7B70
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

		// Token: 0x06001BBA RID: 7098 RVA: 0x000F99EF File Offset: 0x000F7BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterAll.LogPair = null;
			ConfigKurotatoCharacterAll.HandleId = 0;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000F99FD File Offset: 0x000F7BFD
		public static void Init()
		{
			ConfigKurotatoCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter`");
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000F9A18 File Offset: 0x000F7C18
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

		// Token: 0x0400202F RID: 8239
		private const string DB = "db_kurotato.db";

		// Token: 0x04002030 RID: 8240
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04002031 RID: 8241
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04002032 RID: 8242
		private const string COMMAND = "select BinData from `KurotatoCharacter`";

		// Token: 0x04002033 RID: 8243
		private const string KEY_PREFIX = "KurotatoCharacterAll";

		// Token: 0x04002034 RID: 8244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002035 RID: 8245
		private static int HandleId;
	}
}
