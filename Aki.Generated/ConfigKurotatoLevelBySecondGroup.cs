using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049C RID: 1180
	public class ConfigKurotatoLevelBySecondGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x000F5F38 File Offset: 0x000F4138
		static ConfigKurotatoLevelBySecondGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelBySecondGroup.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelBySecondGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000F5F58 File Offset: 0x000F4158
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

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000F5FD7 File Offset: 0x000F41D7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelBySecondGroup.LogPair = null;
			ConfigKurotatoLevelBySecondGroup.HandleId = 0;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000F5FE5 File Offset: 0x000F41E5
		public static void Init()
		{
			ConfigKurotatoLevelBySecondGroup.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelBySecondGroup.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where SecondGroup=?");
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000F6000 File Offset: 0x000F4200
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

		// Token: 0x04002028 RID: 8232
		private const string DB = "db_kurotato.db";

		// Token: 0x04002029 RID: 8233
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400202A RID: 8234
		private const string TABLE = "KurotatoLevel";

		// Token: 0x0400202B RID: 8235
		private const string COMMAND = "select BinData from `KurotatoLevel` where SecondGroup=?";

		// Token: 0x0400202C RID: 8236
		private const string KEY_PREFIX = "KurotatoLevelBySecondGroup";

		// Token: 0x0400202D RID: 8237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400202E RID: 8238
		private static int HandleId;
	}
}
