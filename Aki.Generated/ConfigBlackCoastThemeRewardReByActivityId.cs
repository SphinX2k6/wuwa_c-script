using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F5 RID: 245
	public class ConfigBlackCoastThemeRewardReByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x0007A300 File Offset: 0x00078500
		static ConfigBlackCoastThemeRewardReByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeRewardReByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeRewardReByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0007A320 File Offset: 0x00078520
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeRewardReByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeRewardRe` where ActivityId=?")
			});
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0007A39F File Offset: 0x0007859F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReByActivityId.LogPair = null;
			ConfigBlackCoastThemeRewardReByActivityId.HandleId = 0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0007A3AD File Offset: 0x000785AD
		public static void Init()
		{
			ConfigBlackCoastThemeRewardReByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeRewardReByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeRewardRe` where ActivityId=?");
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0007A3C8 File Offset: 0x000785C8
		[NullableContext(2)]
		public static IReadOnlyList<BlackCoastThemeRewardRe> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeRewardReByActivityId.HandleId, ConfigBlackCoastThemeRewardReByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeRewardReByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<BlackCoastThemeRewardRe> readOnlyList = (IReadOnlyList<BlackCoastThemeRewardRe>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBlackCoastThemeRewardReByActivityId.LogPair.Clear();
			ConfigBlackCoastThemeRewardReByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeRewardReByActivityId.HandleId, 1, p0ActivityId, ConfigBlackCoastThemeRewardReByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeRewardReByActivityId.HandleId, ConfigBlackCoastThemeRewardReByActivityId.LogPair);
				return null;
			}
			List<BlackCoastThemeRewardRe> list = new List<BlackCoastThemeRewardRe>();
			while (ConfigCommon.Step(ConfigBlackCoastThemeRewardReByActivityId.HandleId, false, ConfigBlackCoastThemeRewardReByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeRewardReByActivityId.HandleId, 0, ConfigBlackCoastThemeRewardReByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBlackCoastThemeRewardReByActivityId.HandleId, ConfigBlackCoastThemeRewardReByActivityId.LogPair);
					return null;
				}
				BlackCoastThemeRewardRe rootAsBlackCoastThemeRewardRe = BlackCoastThemeRewardRe.GetRootAsBlackCoastThemeRewardRe(new ByteBuffer(item2));
				list.Add(rootAsBlackCoastThemeRewardRe);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeRewardReByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeRewardReByActivityId.HandleId, ConfigBlackCoastThemeRewardReByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000697 RID: 1687
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000698 RID: 1688
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000699 RID: 1689
		private const string TABLE = "BlackCoastThemeRewardRe";

		// Token: 0x0400069A RID: 1690
		private const string COMMAND = "select BinData from `BlackCoastThemeRewardRe` where ActivityId=?";

		// Token: 0x0400069B RID: 1691
		private const string KEY_PREFIX = "BlackCoastThemeRewardReByActivityId";

		// Token: 0x0400069C RID: 1692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400069D RID: 1693
		private static int HandleId;
	}
}
