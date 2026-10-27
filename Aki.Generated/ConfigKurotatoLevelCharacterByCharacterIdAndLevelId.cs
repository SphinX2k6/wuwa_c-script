using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049D RID: 1181
	public class ConfigKurotatoLevelCharacterByCharacterIdAndLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x000F616F File Offset: 0x000F436F
		static ConfigKurotatoLevelCharacterByCharacterIdAndLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000F6190 File Offset: 0x000F4390
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevelCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevelCharacter` where CharacterId=? And LevelId=?")
			});
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000F620F File Offset: 0x000F440F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair = null;
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId = 0;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000F621D File Offset: 0x000F441D
		public static void Init()
		{
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelCharacter` where CharacterId=? And LevelId=?");
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000F6238 File Offset: 0x000F4438
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLevelCharacter> GetConfigList(int p0CharacterId, int p1LevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelCharacterByCharacterIdAndLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CharacterId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1LevelId);
				IReadOnlyList<KurotatoLevelCharacter> readOnlyList = (IReadOnlyList<KurotatoLevelCharacter>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair.Clear();
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair.Add(new ValueTuple<string, object>("CharacterId", p0CharacterId));
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair.Add(new ValueTuple<string, object>("LevelId", p1LevelId));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, 1, p0CharacterId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair) || !ConfigCommon.BindInt(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, 2, p1LevelId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair);
				return null;
			}
			List<KurotatoLevelCharacter> list = new List<KurotatoLevelCharacter>();
			while (ConfigCommon.Step(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, false, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, 0, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair);
					return null;
				}
				KurotatoLevelCharacter rootAsKurotatoLevelCharacter = KurotatoLevelCharacter.GetRootAsKurotatoLevelCharacter(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLevelCharacter);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelCharacterByCharacterIdAndLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CharacterId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1LevelId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair);
			return list;
		}

		// Token: 0x0400202F RID: 8239
		private const string DB = "db_kurotato.db";

		// Token: 0x04002030 RID: 8240
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04002031 RID: 8241
		private const string TABLE = "KurotatoLevelCharacter";

		// Token: 0x04002032 RID: 8242
		private const string COMMAND = "select BinData from `KurotatoLevelCharacter` where CharacterId=? And LevelId=?";

		// Token: 0x04002033 RID: 8243
		private const string KEY_PREFIX = "KurotatoLevelCharacterByCharacterIdAndLevelId";

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
