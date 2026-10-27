using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091C RID: 2332
	public class ConfigSheriffQuestByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036BB RID: 14011 RVA: 0x0018EC17 File Offset: 0x0018CE17
		static ConfigSheriffQuestByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByMarkId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0018EC38 File Offset: 0x0018CE38
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuest` where MarkId=?")
			});
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x0018ECB7 File Offset: 0x0018CEB7
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByMarkId.LogPair = null;
			ConfigSheriffQuestByMarkId.HandleId = 0;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x0018ECC5 File Offset: 0x0018CEC5
		public static void Init()
		{
			ConfigSheriffQuestByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByMarkId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where MarkId=?");
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0018ECE0 File Offset: 0x0018CEE0
		public static SheriffQuest? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffQuest?(SheriffQuest.GetRootAsSheriffQuest(configBuffer));
				}
			}
			ConfigSheriffQuestByMarkId.LogPair.Clear();
			ConfigSheriffQuestByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestByMarkId.HandleId, 1, p0MarkId, ConfigSheriffQuestByMarkId.LogPair) || ConfigCommon.Step(ConfigSheriffQuestByMarkId.HandleId, true, ConfigSheriffQuestByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestByMarkId.HandleId, 0, ConfigSheriffQuestByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffQuest rootAsSheriffQuest = SheriffQuest.GetRootAsSheriffQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
			return new SheriffQuest?(rootAsSheriffQuest);
		}

		// Token: 0x04003FAA RID: 16298
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FAB RID: 16299
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FAC RID: 16300
		private const string TABLE = "SheriffQuest";

		// Token: 0x04003FAD RID: 16301
		private const string COMMAND = "select BinData from `SheriffQuest` where MarkId=?";

		// Token: 0x04003FAE RID: 16302
		private const string KEY_PREFIX = "SheriffQuestByMarkId";

		// Token: 0x04003FAF RID: 16303
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FB0 RID: 16304
		private static int HandleId;
	}
}
