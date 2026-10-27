using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F7 RID: 247
	public class ConfigBlackCoastThemeStageReByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0007A780 File Offset: 0x00078980
		static ConfigBlackCoastThemeStageReByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeStageReByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeStageReByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0007A7A0 File Offset: 0x000789A0
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeStageReByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeStageRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeStageRe` where ActivityId=?")
			});
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0007A81F File Offset: 0x00078A1F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReByActivityId.LogPair = null;
			ConfigBlackCoastThemeStageReByActivityId.HandleId = 0;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0007A82D File Offset: 0x00078A2D
		public static void Init()
		{
			ConfigBlackCoastThemeStageReByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeStageReByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeStageRe` where ActivityId=?");
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0007A848 File Offset: 0x00078A48
		[NullableContext(2)]
		public static IReadOnlyList<BlackCoastThemeStageRe> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeStageReByActivityId.HandleId, ConfigBlackCoastThemeStageReByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeStageReByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<BlackCoastThemeStageRe> readOnlyList = (IReadOnlyList<BlackCoastThemeStageRe>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBlackCoastThemeStageReByActivityId.LogPair.Clear();
			ConfigBlackCoastThemeStageReByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeStageReByActivityId.HandleId, 1, p0ActivityId, ConfigBlackCoastThemeStageReByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeStageReByActivityId.HandleId, ConfigBlackCoastThemeStageReByActivityId.LogPair);
				return null;
			}
			List<BlackCoastThemeStageRe> list = new List<BlackCoastThemeStageRe>();
			while (ConfigCommon.Step(ConfigBlackCoastThemeStageReByActivityId.HandleId, false, ConfigBlackCoastThemeStageReByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeStageReByActivityId.HandleId, 0, ConfigBlackCoastThemeStageReByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackCoastThemeStageReByActivityId.HandleId, ConfigBlackCoastThemeStageReByActivityId.LogPair);
					return null;
				}
				BlackCoastThemeStageRe rootAsBlackCoastThemeStageRe = BlackCoastThemeStageRe.GetRootAsBlackCoastThemeStageRe(new ByteBuffer(item2));
				list.Add(rootAsBlackCoastThemeStageRe);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeStageReByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeStageReByActivityId.HandleId, ConfigBlackCoastThemeStageReByActivityId.LogPair);
			return list;
		}

		// Token: 0x040006A5 RID: 1701
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x040006A6 RID: 1702
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006A7 RID: 1703
		private const string TABLE = "BlackCoastThemeStageRe";

		// Token: 0x040006A8 RID: 1704
		private const string COMMAND = "select BinData from `BlackCoastThemeStageRe` where ActivityId=?";

		// Token: 0x040006A9 RID: 1705
		private const string KEY_PREFIX = "BlackCoastThemeStageReByActivityId";

		// Token: 0x040006AA RID: 1706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006AB RID: 1707
		private static int HandleId;
	}
}
