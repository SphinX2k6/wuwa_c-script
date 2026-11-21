using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B3 RID: 1203
	public class ConfigKurotatoLevelCharacterByCharacterIdAndLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x000FC8C3 File Offset: 0x000FAAC3
		static ConfigKurotatoLevelCharacterByCharacterIdAndLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000FC8E4 File Offset: 0x000FAAE4
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

		// Token: 0x06001C3F RID: 7231 RVA: 0x000FC963 File Offset: 0x000FAB63
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.LogPair = null;
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId = 0;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000FC971 File Offset: 0x000FAB71
		public static void Init()
		{
			ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelCharacter` where CharacterId=? And LevelId=?");
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000FC98C File Offset: 0x000FAB8C
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

		// Token: 0x040020C9 RID: 8393
		private const string DB = "db_kurotato.db";

		// Token: 0x040020CA RID: 8394
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x040020CB RID: 8395
		private const string TABLE = "KurotatoLevelCharacter";

		// Token: 0x040020CC RID: 8396
		private const string COMMAND = "select BinData from `KurotatoLevelCharacter` where CharacterId=? And LevelId=?";

		// Token: 0x040020CD RID: 8397
		private const string KEY_PREFIX = "KurotatoLevelCharacterByCharacterIdAndLevelId";

		// Token: 0x040020CE RID: 8398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020CF RID: 8399
		private static int HandleId;
	}
}
