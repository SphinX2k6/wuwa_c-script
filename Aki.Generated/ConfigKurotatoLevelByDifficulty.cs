using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B0 RID: 1200
	public class ConfigKurotatoLevelByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C2B RID: 7211 RVA: 0x000FC20B File Offset: 0x000FA40B
		static ConfigKurotatoLevelByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelByDifficulty.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000FC22C File Offset: 0x000FA42C
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

		// Token: 0x06001C2D RID: 7213 RVA: 0x000FC2AB File Offset: 0x000FA4AB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelByDifficulty.LogPair = null;
			ConfigKurotatoLevelByDifficulty.HandleId = 0;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000FC2B9 File Offset: 0x000FA4B9
		public static void Init()
		{
			ConfigKurotatoLevelByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelByDifficulty.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where Difficulty=?");
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000FC2D4 File Offset: 0x000FA4D4
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

		// Token: 0x040020B4 RID: 8372
		private const string DB = "db_kurotato.db";

		// Token: 0x040020B5 RID: 8373
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020B6 RID: 8374
		private const string TABLE = "KurotatoLevel";

		// Token: 0x040020B7 RID: 8375
		private const string COMMAND = "select BinData from `KurotatoLevel` where Difficulty=?";

		// Token: 0x040020B8 RID: 8376
		private const string KEY_PREFIX = "KurotatoLevelByDifficulty";

		// Token: 0x040020B9 RID: 8377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020BA RID: 8378
		private static int HandleId;
	}
}
