using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091D RID: 2333
	public class ConfigSheriffQuestByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036C1 RID: 14017 RVA: 0x0018EE60 File Offset: 0x0018D060
		static ConfigSheriffQuestByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByQuestId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0018EE80 File Offset: 0x0018D080
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuest` where QuestId=?")
			});
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0018EEFF File Offset: 0x0018D0FF
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByQuestId.LogPair = null;
			ConfigSheriffQuestByQuestId.HandleId = 0;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0018EF0D File Offset: 0x0018D10D
		public static void Init()
		{
			ConfigSheriffQuestByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByQuestId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where QuestId=?");
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0018EF28 File Offset: 0x0018D128
		public static SheriffQuest? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestByQuestId.HandleId, ConfigSheriffQuestByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffQuest?(SheriffQuest.GetRootAsSheriffQuest(configBuffer));
				}
			}
			ConfigSheriffQuestByQuestId.LogPair.Clear();
			ConfigSheriffQuestByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestByQuestId.HandleId, 1, p0QuestId, ConfigSheriffQuestByQuestId.LogPair) || ConfigCommon.Step(ConfigSheriffQuestByQuestId.HandleId, true, ConfigSheriffQuestByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByQuestId.HandleId, ConfigSheriffQuestByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestByQuestId.HandleId, 0, ConfigSheriffQuestByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByQuestId.HandleId, ConfigSheriffQuestByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffQuest rootAsSheriffQuest = SheriffQuest.GetRootAsSheriffQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffQuestByQuestId.HandleId, ConfigSheriffQuestByQuestId.LogPair);
			return new SheriffQuest?(rootAsSheriffQuest);
		}

		// Token: 0x04003FB1 RID: 16305
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FB2 RID: 16306
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FB3 RID: 16307
		private const string TABLE = "SheriffQuest";

		// Token: 0x04003FB4 RID: 16308
		private const string COMMAND = "select BinData from `SheriffQuest` where QuestId=?";

		// Token: 0x04003FB5 RID: 16309
		private const string KEY_PREFIX = "SheriffQuestByQuestId";

		// Token: 0x04003FB6 RID: 16310
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FB7 RID: 16311
		private static int HandleId;
	}
}
