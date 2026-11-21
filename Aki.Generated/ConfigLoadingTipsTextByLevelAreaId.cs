using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FE RID: 1278
	public class ConfigLoadingTipsTextByLevelAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DFF RID: 7679 RVA: 0x001064A8 File Offset: 0x001046A8
		static ConfigLoadingTipsTextByLevelAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextByLevelAreaId.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextByLevelAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x001064C8 File Offset: 0x001046C8
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

		// Token: 0x06001E01 RID: 7681 RVA: 0x00106547 File Offset: 0x00104747
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextByLevelAreaId.LogPair = null;
			ConfigLoadingTipsTextByLevelAreaId.HandleId = 0;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00106555 File Offset: 0x00104755
		public static void Init()
		{
			ConfigLoadingTipsTextByLevelAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextByLevelAreaId.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText` where LevelAreaId=?");
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00106570 File Offset: 0x00104770
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

		// Token: 0x040022D6 RID: 8918
		private const string DB = "db_loadingtips.db";

		// Token: 0x040022D7 RID: 8919
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040022D8 RID: 8920
		private const string TABLE = "LoadingTipsText";

		// Token: 0x040022D9 RID: 8921
		private const string COMMAND = "select BinData from `LoadingTipsText` where LevelAreaId=?";

		// Token: 0x040022DA RID: 8922
		private const string KEY_PREFIX = "LoadingTipsTextByLevelAreaId";

		// Token: 0x040022DB RID: 8923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022DC RID: 8924
		private static int HandleId;
	}
}
