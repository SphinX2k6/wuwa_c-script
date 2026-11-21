using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000108 RID: 264
	public class ConfigBlackCoastThemeTaskReByStageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x00080564 File Offset: 0x0007E764
		static ConfigBlackCoastThemeTaskReByStageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeTaskReByStageId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeTaskReByStageId.ResetStaticDefaultValue));
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00080584 File Offset: 0x0007E784
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByStageId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeTaskReByStageId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeTaskRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeTaskRe` where StageId=?")
			});
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00080603 File Offset: 0x0007E803
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByStageId.LogPair = null;
			ConfigBlackCoastThemeTaskReByStageId.HandleId = 0;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00080611 File Offset: 0x0007E811
		public static void Init()
		{
			ConfigBlackCoastThemeTaskReByStageId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeTaskReByStageId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeTaskRe` where StageId=?");
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0008062C File Offset: 0x0007E82C
		[NullableContext(2)]
		public static IReadOnlyList<BlackCoastThemeTaskRe> GetConfigList(int p0StageId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeTaskReByStageId.HandleId, ConfigBlackCoastThemeTaskReByStageId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeTaskReByStageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StageId);
				IReadOnlyList<BlackCoastThemeTaskRe> readOnlyList = (IReadOnlyList<BlackCoastThemeTaskRe>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBlackCoastThemeTaskReByStageId.LogPair.Clear();
			ConfigBlackCoastThemeTaskReByStageId.LogPair.Add(new ValueTuple<string, object>("StageId", p0StageId));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeTaskReByStageId.HandleId, 1, p0StageId, ConfigBlackCoastThemeTaskReByStageId.LogPair))
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByStageId.HandleId, ConfigBlackCoastThemeTaskReByStageId.LogPair);
				return null;
			}
			List<BlackCoastThemeTaskRe> list = new List<BlackCoastThemeTaskRe>();
			while (ConfigCommon.Step(ConfigBlackCoastThemeTaskReByStageId.HandleId, false, ConfigBlackCoastThemeTaskReByStageId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeTaskReByStageId.HandleId, 0, ConfigBlackCoastThemeTaskReByStageId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByStageId.HandleId, ConfigBlackCoastThemeTaskReByStageId.LogPair);
					return null;
				}
				BlackCoastThemeTaskRe rootAsBlackCoastThemeTaskRe = BlackCoastThemeTaskRe.GetRootAsBlackCoastThemeTaskRe(new ByteBuffer(item2));
				list.Add(rootAsBlackCoastThemeTaskRe);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeTaskReByStageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StageId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByStageId.HandleId, ConfigBlackCoastThemeTaskReByStageId.LogPair);
			return list;
		}

		// Token: 0x0400071C RID: 1820
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x0400071D RID: 1821
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x0400071E RID: 1822
		private const string TABLE = "BlackCoastThemeTaskRe";

		// Token: 0x0400071F RID: 1823
		private const string COMMAND = "select BinData from `BlackCoastThemeTaskRe` where StageId=?";

		// Token: 0x04000720 RID: 1824
		private const string KEY_PREFIX = "BlackCoastThemeTaskReByStageId";

		// Token: 0x04000721 RID: 1825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000722 RID: 1826
		private static int HandleId;
	}
}
