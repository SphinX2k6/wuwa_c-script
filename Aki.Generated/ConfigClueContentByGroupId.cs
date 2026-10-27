using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000175 RID: 373
	public class ConfigClueContentByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x0008AE29 File Offset: 0x00089029
		static ConfigClueContentByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueContentByGroupId.CreateStaticDefaultValue), new Action(ConfigClueContentByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0008AE48 File Offset: 0x00089048
		public static void CreateStaticDefaultValue()
		{
			ConfigClueContentByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigClueContentByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_clue.db"),
				new ValueTuple<string, object>("文件", "x.线索.xlsx"),
				new ValueTuple<string, object>("表名", "ClueContent"),
				new ValueTuple<string, object>("语句", "select BinData from `ClueContent` where GroupId=?")
			});
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0008AEC7 File Offset: 0x000890C7
		public static void ResetStaticDefaultValue()
		{
			ConfigClueContentByGroupId.LogPair = null;
			ConfigClueContentByGroupId.HandleId = 0;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0008AED5 File Offset: 0x000890D5
		public static void Init()
		{
			ConfigClueContentByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigClueContentByGroupId.HandleId, "db_clue.db", "select BinData from `ClueContent` where GroupId=?");
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0008AEF0 File Offset: 0x000890F0
		[NullableContext(2)]
		public static IReadOnlyList<ClueContent> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigClueContentByGroupId.HandleId, ConfigClueContentByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueContentByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<ClueContent> readOnlyList = (IReadOnlyList<ClueContent>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigClueContentByGroupId.LogPair.Clear();
			ConfigClueContentByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigClueContentByGroupId.HandleId, 1, p0GroupId, ConfigClueContentByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigClueContentByGroupId.HandleId, ConfigClueContentByGroupId.LogPair);
				return null;
			}
			List<ClueContent> list = new List<ClueContent>();
			while (ConfigCommon.Step(ConfigClueContentByGroupId.HandleId, false, ConfigClueContentByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigClueContentByGroupId.HandleId, 0, ConfigClueContentByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigClueContentByGroupId.HandleId, ConfigClueContentByGroupId.LogPair);
					return null;
				}
				ClueContent rootAsClueContent = ClueContent.GetRootAsClueContent(new ByteBuffer(item2));
				list.Add(rootAsClueContent);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ClueContentByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigClueContentByGroupId.HandleId, ConfigClueContentByGroupId.LogPair);
			return list;
		}

		// Token: 0x04000A17 RID: 2583
		private const string DB = "db_clue.db";

		// Token: 0x04000A18 RID: 2584
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A19 RID: 2585
		private const string TABLE = "ClueContent";

		// Token: 0x04000A1A RID: 2586
		private const string COMMAND = "select BinData from `ClueContent` where GroupId=?";

		// Token: 0x04000A1B RID: 2587
		private const string KEY_PREFIX = "ClueContentByGroupId";

		// Token: 0x04000A1C RID: 2588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A1D RID: 2589
		private static int HandleId;
	}
}
