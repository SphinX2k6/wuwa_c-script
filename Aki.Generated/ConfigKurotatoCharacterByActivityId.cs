using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049E RID: 1182
	public class ConfigKurotatoCharacterByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BBE RID: 7102 RVA: 0x000F9AE3 File Offset: 0x000F7CE3
		static ConfigKurotatoCharacterByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterByActivityId.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000F9B04 File Offset: 0x000F7D04
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoCharacterByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoCharacterByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoCharacter` where ActivityId=?")
			});
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000F9B83 File Offset: 0x000F7D83
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterByActivityId.LogPair = null;
			ConfigKurotatoCharacterByActivityId.HandleId = 0;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000F9B91 File Offset: 0x000F7D91
		public static void Init()
		{
			ConfigKurotatoCharacterByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterByActivityId.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter` where ActivityId=?");
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000F9BAC File Offset: 0x000F7DAC
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoCharacter> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoCharacterByActivityId.HandleId, ConfigKurotatoCharacterByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<KurotatoCharacter> readOnlyList = (IReadOnlyList<KurotatoCharacter>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoCharacterByActivityId.LogPair.Clear();
			ConfigKurotatoCharacterByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigKurotatoCharacterByActivityId.HandleId, 1, p0ActivityId, ConfigKurotatoCharacterByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoCharacterByActivityId.HandleId, ConfigKurotatoCharacterByActivityId.LogPair);
				return null;
			}
			List<KurotatoCharacter> list = new List<KurotatoCharacter>();
			while (ConfigCommon.Step(ConfigKurotatoCharacterByActivityId.HandleId, false, ConfigKurotatoCharacterByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoCharacterByActivityId.HandleId, 0, ConfigKurotatoCharacterByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoCharacterByActivityId.HandleId, ConfigKurotatoCharacterByActivityId.LogPair);
					return null;
				}
				KurotatoCharacter rootAsKurotatoCharacter = KurotatoCharacter.GetRootAsKurotatoCharacter(new ByteBuffer(item2));
				list.Add(rootAsKurotatoCharacter);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoCharacterByActivityId.HandleId, ConfigKurotatoCharacterByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002036 RID: 8246
		private const string DB = "db_kurotato.db";

		// Token: 0x04002037 RID: 8247
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04002038 RID: 8248
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04002039 RID: 8249
		private const string COMMAND = "select BinData from `KurotatoCharacter` where ActivityId=?";

		// Token: 0x0400203A RID: 8250
		private const string KEY_PREFIX = "KurotatoCharacterByActivityId";

		// Token: 0x0400203B RID: 8251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400203C RID: 8252
		private static int HandleId;
	}
}
