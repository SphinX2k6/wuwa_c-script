using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000488 RID: 1160
	public class ConfigKurotatoCharacterByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x000F338F File Offset: 0x000F158F
		static ConfigKurotatoCharacterByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterByActivityId.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000F33B0 File Offset: 0x000F15B0
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

		// Token: 0x06001B3C RID: 6972 RVA: 0x000F342F File Offset: 0x000F162F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterByActivityId.LogPair = null;
			ConfigKurotatoCharacterByActivityId.HandleId = 0;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000F343D File Offset: 0x000F163D
		public static void Init()
		{
			ConfigKurotatoCharacterByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterByActivityId.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter` where ActivityId=?");
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000F3458 File Offset: 0x000F1658
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

		// Token: 0x04001F9C RID: 8092
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F9D RID: 8093
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04001F9E RID: 8094
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04001F9F RID: 8095
		private const string COMMAND = "select BinData from `KurotatoCharacter` where ActivityId=?";

		// Token: 0x04001FA0 RID: 8096
		private const string KEY_PREFIX = "KurotatoCharacterByActivityId";

		// Token: 0x04001FA1 RID: 8097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FA2 RID: 8098
		private static int HandleId;
	}
}
