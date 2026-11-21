using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B2 RID: 1202
	public class ConfigKurotatoLevelBySecondGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C37 RID: 7223 RVA: 0x000FC68C File Offset: 0x000FA88C
		static ConfigKurotatoLevelBySecondGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelBySecondGroup.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelBySecondGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000FC6AC File Offset: 0x000FA8AC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelBySecondGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelBySecondGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevel` where SecondGroup=?")
			});
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000FC72B File Offset: 0x000FA92B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelBySecondGroup.LogPair = null;
			ConfigKurotatoLevelBySecondGroup.HandleId = 0;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000FC739 File Offset: 0x000FA939
		public static void Init()
		{
			ConfigKurotatoLevelBySecondGroup.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelBySecondGroup.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where SecondGroup=?");
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000FC754 File Offset: 0x000FA954
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLevel> GetConfigList(int p0SecondGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelBySecondGroup.HandleId, ConfigKurotatoLevelBySecondGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelBySecondGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SecondGroup);
				IReadOnlyList<KurotatoLevel> readOnlyList = (IReadOnlyList<KurotatoLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoLevelBySecondGroup.LogPair.Clear();
			ConfigKurotatoLevelBySecondGroup.LogPair.Add(new ValueTuple<string, object>("SecondGroup", p0SecondGroup));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelBySecondGroup.HandleId, 1, p0SecondGroup, ConfigKurotatoLevelBySecondGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoLevelBySecondGroup.HandleId, ConfigKurotatoLevelBySecondGroup.LogPair);
				return null;
			}
			List<KurotatoLevel> list = new List<KurotatoLevel>();
			while (ConfigCommon.Step(ConfigKurotatoLevelBySecondGroup.HandleId, false, ConfigKurotatoLevelBySecondGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelBySecondGroup.HandleId, 0, ConfigKurotatoLevelBySecondGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLevelBySecondGroup.HandleId, ConfigKurotatoLevelBySecondGroup.LogPair);
					return null;
				}
				KurotatoLevel rootAsKurotatoLevel = KurotatoLevel.GetRootAsKurotatoLevel(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelBySecondGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SecondGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelBySecondGroup.HandleId, ConfigKurotatoLevelBySecondGroup.LogPair);
			return list;
		}

		// Token: 0x040020C2 RID: 8386
		private const string DB = "db_kurotato.db";

		// Token: 0x040020C3 RID: 8387
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020C4 RID: 8388
		private const string TABLE = "KurotatoLevel";

		// Token: 0x040020C5 RID: 8389
		private const string COMMAND = "select BinData from `KurotatoLevel` where SecondGroup=?";

		// Token: 0x040020C6 RID: 8390
		private const string KEY_PREFIX = "KurotatoLevelBySecondGroup";

		// Token: 0x040020C7 RID: 8391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020C8 RID: 8392
		private static int HandleId;
	}
}
