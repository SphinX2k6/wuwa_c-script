using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F9 RID: 249
	public class ConfigBlackCoastThemeTaskReByStageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0007AC00 File Offset: 0x00078E00
		static ConfigBlackCoastThemeTaskReByStageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeTaskReByStageId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeTaskReByStageId.ResetStaticDefaultValue));
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0007AC20 File Offset: 0x00078E20
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

		// Token: 0x060005D9 RID: 1497 RVA: 0x0007AC9F File Offset: 0x00078E9F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByStageId.LogPair = null;
			ConfigBlackCoastThemeTaskReByStageId.HandleId = 0;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0007ACAD File Offset: 0x00078EAD
		public static void Init()
		{
			ConfigBlackCoastThemeTaskReByStageId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeTaskReByStageId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeTaskRe` where StageId=?");
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0007ACC8 File Offset: 0x00078EC8
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

		// Token: 0x040006B3 RID: 1715
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x040006B4 RID: 1716
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006B5 RID: 1717
		private const string TABLE = "BlackCoastThemeTaskRe";

		// Token: 0x040006B6 RID: 1718
		private const string COMMAND = "select BinData from `BlackCoastThemeTaskRe` where StageId=?";

		// Token: 0x040006B7 RID: 1719
		private const string KEY_PREFIX = "BlackCoastThemeTaskReByStageId";

		// Token: 0x040006B8 RID: 1720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006B9 RID: 1721
		private static int HandleId;
	}
}
