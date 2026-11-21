using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000106 RID: 262
	public class ConfigBlackCoastThemeStageReByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x000800E4 File Offset: 0x0007E2E4
		static ConfigBlackCoastThemeStageReByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeStageReByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeStageReByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00080104 File Offset: 0x0007E304
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

		// Token: 0x06000627 RID: 1575 RVA: 0x00080183 File Offset: 0x0007E383
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReByActivityId.LogPair = null;
			ConfigBlackCoastThemeStageReByActivityId.HandleId = 0;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00080191 File Offset: 0x0007E391
		public static void Init()
		{
			ConfigBlackCoastThemeStageReByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeStageReByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeStageRe` where ActivityId=?");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000801AC File Offset: 0x0007E3AC
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

		// Token: 0x0400070E RID: 1806
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x0400070F RID: 1807
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000710 RID: 1808
		private const string TABLE = "BlackCoastThemeStageRe";

		// Token: 0x04000711 RID: 1809
		private const string COMMAND = "select BinData from `BlackCoastThemeStageRe` where ActivityId=?";

		// Token: 0x04000712 RID: 1810
		private const string KEY_PREFIX = "BlackCoastThemeStageReByActivityId";

		// Token: 0x04000713 RID: 1811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000714 RID: 1812
		private static int HandleId;
	}
}
