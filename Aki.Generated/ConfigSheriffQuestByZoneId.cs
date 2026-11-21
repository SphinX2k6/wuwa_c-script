using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000969 RID: 2409
	public class ConfigSheriffQuestByZoneId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003889 RID: 14473 RVA: 0x0019C2C8 File Offset: 0x0019A4C8
		static ConfigSheriffQuestByZoneId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByZoneId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByZoneId.ResetStaticDefaultValue));
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0019C2E8 File Offset: 0x0019A4E8
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

		// Token: 0x0600388B RID: 14475 RVA: 0x0019C367 File Offset: 0x0019A567
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByZoneId.LogPair = null;
			ConfigSheriffQuestByZoneId.HandleId = 0;
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0019C375 File Offset: 0x0019A575
		public static void Init()
		{
			ConfigSheriffQuestByZoneId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByZoneId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where SheriffZoneId=?");
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x0019C390 File Offset: 0x0019A590
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

		// Token: 0x040041C5 RID: 16837
		private const string DB = "db_sheriff.db";

		// Token: 0x040041C6 RID: 16838
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041C7 RID: 16839
		private const string TABLE = "SheriffQuest";

		// Token: 0x040041C8 RID: 16840
		private const string COMMAND = "select BinData from `SheriffQuest` where SheriffZoneId=?";

		// Token: 0x040041C9 RID: 16841
		private const string KEY_PREFIX = "SheriffQuestByZoneId";

		// Token: 0x040041CA RID: 16842
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041CB RID: 16843
		private static int HandleId;
	}
}
