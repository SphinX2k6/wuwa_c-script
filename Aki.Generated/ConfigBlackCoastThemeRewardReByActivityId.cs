using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000104 RID: 260
	public class ConfigBlackCoastThemeRewardReByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x0007FC64 File Offset: 0x0007DE64
		static ConfigBlackCoastThemeRewardReByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeRewardReByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeRewardReByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0007FC84 File Offset: 0x0007DE84
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

		// Token: 0x0600061B RID: 1563 RVA: 0x0007FD03 File Offset: 0x0007DF03
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReByActivityId.LogPair = null;
			ConfigBlackCoastThemeRewardReByActivityId.HandleId = 0;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0007FD11 File Offset: 0x0007DF11
		public static void Init()
		{
			ConfigBlackCoastThemeRewardReByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeRewardReByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeRewardRe` where ActivityId=?");
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0007FD2C File Offset: 0x0007DF2C
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

		// Token: 0x04000700 RID: 1792
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000701 RID: 1793
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000702 RID: 1794
		private const string TABLE = "BlackCoastThemeRewardRe";

		// Token: 0x04000703 RID: 1795
		private const string COMMAND = "select BinData from `BlackCoastThemeRewardRe` where ActivityId=?";

		// Token: 0x04000704 RID: 1796
		private const string KEY_PREFIX = "BlackCoastThemeRewardReByActivityId";

		// Token: 0x04000705 RID: 1797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000706 RID: 1798
		private static int HandleId;
	}
}
