using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091E RID: 2334
	public class ConfigSheriffQuestByZoneId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036C7 RID: 14023 RVA: 0x0018F0A8 File Offset: 0x0018D2A8
		static ConfigSheriffQuestByZoneId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByZoneId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByZoneId.ResetStaticDefaultValue));
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0018F0C8 File Offset: 0x0018D2C8
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestByZoneId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestByZoneId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuest` where SheriffZoneId=?")
			});
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0018F147 File Offset: 0x0018D347
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByZoneId.LogPair = null;
			ConfigSheriffQuestByZoneId.HandleId = 0;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0018F155 File Offset: 0x0018D355
		public static void Init()
		{
			ConfigSheriffQuestByZoneId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByZoneId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where SheriffZoneId=?");
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0018F170 File Offset: 0x0018D370
		[NullableContext(2)]
		public static IReadOnlyList<SheriffQuest> GetConfigList(int p0SheriffZoneId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestByZoneId.HandleId, ConfigSheriffQuestByZoneId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByZoneId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SheriffZoneId);
				IReadOnlyList<SheriffQuest> readOnlyList = (IReadOnlyList<SheriffQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSheriffQuestByZoneId.LogPair.Clear();
			ConfigSheriffQuestByZoneId.LogPair.Add(new ValueTuple<string, object>("SheriffZoneId", p0SheriffZoneId));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestByZoneId.HandleId, 1, p0SheriffZoneId, ConfigSheriffQuestByZoneId.LogPair))
			{
				ConfigCommon.Reset(ConfigSheriffQuestByZoneId.HandleId, ConfigSheriffQuestByZoneId.LogPair);
				return null;
			}
			List<SheriffQuest> list = new List<SheriffQuest>();
			while (ConfigCommon.Step(ConfigSheriffQuestByZoneId.HandleId, false, ConfigSheriffQuestByZoneId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestByZoneId.HandleId, 0, ConfigSheriffQuestByZoneId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffQuestByZoneId.HandleId, ConfigSheriffQuestByZoneId.LogPair);
					return null;
				}
				SheriffQuest rootAsSheriffQuest = SheriffQuest.GetRootAsSheriffQuest(new ByteBuffer(item2));
				list.Add(rootAsSheriffQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByZoneId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SheriffZoneId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffQuestByZoneId.HandleId, ConfigSheriffQuestByZoneId.LogPair);
			return list;
		}

		// Token: 0x04003FB8 RID: 16312
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FB9 RID: 16313
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FBA RID: 16314
		private const string TABLE = "SheriffQuest";

		// Token: 0x04003FBB RID: 16315
		private const string COMMAND = "select BinData from `SheriffQuest` where SheriffZoneId=?";

		// Token: 0x04003FBC RID: 16316
		private const string KEY_PREFIX = "SheriffQuestByZoneId";

		// Token: 0x04003FBD RID: 16317
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FBE RID: 16318
		private static int HandleId;
	}
}
