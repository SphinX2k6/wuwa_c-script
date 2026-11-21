using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000185 RID: 389
	public class ConfigClueContentByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00090985 File Offset: 0x0008EB85
		static ConfigClueContentByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClueContentByGroupId.CreateStaticDefaultValue), new Action(ConfigClueContentByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000909A4 File Offset: 0x0008EBA4
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

		// Token: 0x06000921 RID: 2337 RVA: 0x00090A23 File Offset: 0x0008EC23
		public static void ResetStaticDefaultValue()
		{
			ConfigClueContentByGroupId.LogPair = null;
			ConfigClueContentByGroupId.HandleId = 0;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00090A31 File Offset: 0x0008EC31
		public static void Init()
		{
			ConfigClueContentByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigClueContentByGroupId.HandleId, "db_clue.db", "select BinData from `ClueContent` where GroupId=?");
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00090A4C File Offset: 0x0008EC4C
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

		// Token: 0x04000A87 RID: 2695
		private const string DB = "db_clue.db";

		// Token: 0x04000A88 RID: 2696
		private const string FILE = "x.线索.xlsx";

		// Token: 0x04000A89 RID: 2697
		private const string TABLE = "ClueContent";

		// Token: 0x04000A8A RID: 2698
		private const string COMMAND = "select BinData from `ClueContent` where GroupId=?";

		// Token: 0x04000A8B RID: 2699
		private const string KEY_PREFIX = "ClueContentByGroupId";

		// Token: 0x04000A8C RID: 2700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A8D RID: 2701
		private static int HandleId;
	}
}
