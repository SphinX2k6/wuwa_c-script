using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E8 RID: 1256
	public class ConfigLoadingTipsTextByLevelAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D7B RID: 7547 RVA: 0x000FFD54 File Offset: 0x000FDF54
		static ConfigLoadingTipsTextByLevelAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextByLevelAreaId.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextByLevelAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000FFD74 File Offset: 0x000FDF74
		public static void CreateStaticDefaultValue()
		{
			ConfigLoadingTipsTextByLevelAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoadingTipsTextByLevelAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "LoadingTipsText"),
				new ValueTuple<string, object>("语句", "select BinData from `LoadingTipsText` where LevelAreaId=?")
			});
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000FFDF3 File Offset: 0x000FDFF3
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextByLevelAreaId.LogPair = null;
			ConfigLoadingTipsTextByLevelAreaId.HandleId = 0;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000FFE01 File Offset: 0x000FE001
		public static void Init()
		{
			ConfigLoadingTipsTextByLevelAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextByLevelAreaId.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText` where LevelAreaId=?");
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000FFE1C File Offset: 0x000FE01C
		[NullableContext(2)]
		public static IReadOnlyList<LoadingTipsText> GetConfigList(int p0LevelAreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoadingTipsTextByLevelAreaId.HandleId, ConfigLoadingTipsTextByLevelAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingTipsTextByLevelAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelAreaId);
				IReadOnlyList<LoadingTipsText> readOnlyList = (IReadOnlyList<LoadingTipsText>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLoadingTipsTextByLevelAreaId.LogPair.Clear();
			ConfigLoadingTipsTextByLevelAreaId.LogPair.Add(new ValueTuple<string, object>("LevelAreaId", p0LevelAreaId));
			if (!ConfigCommon.BindInt(ConfigLoadingTipsTextByLevelAreaId.HandleId, 1, p0LevelAreaId, ConfigLoadingTipsTextByLevelAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigLoadingTipsTextByLevelAreaId.HandleId, ConfigLoadingTipsTextByLevelAreaId.LogPair);
				return null;
			}
			List<LoadingTipsText> list = new List<LoadingTipsText>();
			while (ConfigCommon.Step(ConfigLoadingTipsTextByLevelAreaId.HandleId, false, ConfigLoadingTipsTextByLevelAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoadingTipsTextByLevelAreaId.HandleId, 0, ConfigLoadingTipsTextByLevelAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLoadingTipsTextByLevelAreaId.HandleId, ConfigLoadingTipsTextByLevelAreaId.LogPair);
					return null;
				}
				LoadingTipsText rootAsLoadingTipsText = LoadingTipsText.GetRootAsLoadingTipsText(new ByteBuffer(item2));
				list.Add(rootAsLoadingTipsText);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingTipsTextByLevelAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelAreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLoadingTipsTextByLevelAreaId.HandleId, ConfigLoadingTipsTextByLevelAreaId.LogPair);
			return list;
		}

		// Token: 0x0400223C RID: 8764
		private const string DB = "db_loadingtips.db";

		// Token: 0x0400223D RID: 8765
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x0400223E RID: 8766
		private const string TABLE = "LoadingTipsText";

		// Token: 0x0400223F RID: 8767
		private const string COMMAND = "select BinData from `LoadingTipsText` where LevelAreaId=?";

		// Token: 0x04002240 RID: 8768
		private const string KEY_PREFIX = "LoadingTipsTextByLevelAreaId";

		// Token: 0x04002241 RID: 8769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002242 RID: 8770
		private static int HandleId;
	}
}
