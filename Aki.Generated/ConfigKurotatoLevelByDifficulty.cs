using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049A RID: 1178
	public class ConfigKurotatoLevelByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x000F5AB7 File Offset: 0x000F3CB7
		static ConfigKurotatoLevelByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelByDifficulty.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000F5AD8 File Offset: 0x000F3CD8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelByDifficulty.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelByDifficulty.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevel` where Difficulty=?")
			});
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000F5B57 File Offset: 0x000F3D57
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelByDifficulty.LogPair = null;
			ConfigKurotatoLevelByDifficulty.HandleId = 0;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000F5B65 File Offset: 0x000F3D65
		public static void Init()
		{
			ConfigKurotatoLevelByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelByDifficulty.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where Difficulty=?");
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000F5B80 File Offset: 0x000F3D80
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLevel> GetConfigList(int p0Difficulty, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelByDifficulty.HandleId, ConfigKurotatoLevelByDifficulty.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				IReadOnlyList<KurotatoLevel> readOnlyList = (IReadOnlyList<KurotatoLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoLevelByDifficulty.LogPair.Clear();
			ConfigKurotatoLevelByDifficulty.LogPair.Add(new ValueTuple<string, object>("Difficulty", p0Difficulty));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelByDifficulty.HandleId, 1, p0Difficulty, ConfigKurotatoLevelByDifficulty.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoLevelByDifficulty.HandleId, ConfigKurotatoLevelByDifficulty.LogPair);
				return null;
			}
			List<KurotatoLevel> list = new List<KurotatoLevel>();
			while (ConfigCommon.Step(ConfigKurotatoLevelByDifficulty.HandleId, false, ConfigKurotatoLevelByDifficulty.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelByDifficulty.HandleId, 0, ConfigKurotatoLevelByDifficulty.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLevelByDifficulty.HandleId, ConfigKurotatoLevelByDifficulty.LogPair);
					return null;
				}
				KurotatoLevel rootAsKurotatoLevel = KurotatoLevel.GetRootAsKurotatoLevel(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelByDifficulty.HandleId, ConfigKurotatoLevelByDifficulty.LogPair);
			return list;
		}

		// Token: 0x0400201A RID: 8218
		private const string DB = "db_kurotato.db";

		// Token: 0x0400201B RID: 8219
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400201C RID: 8220
		private const string TABLE = "KurotatoLevel";

		// Token: 0x0400201D RID: 8221
		private const string COMMAND = "select BinData from `KurotatoLevel` where Difficulty=?";

		// Token: 0x0400201E RID: 8222
		private const string KEY_PREFIX = "KurotatoLevelByDifficulty";

		// Token: 0x0400201F RID: 8223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002020 RID: 8224
		private static int HandleId;
	}
}
