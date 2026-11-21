using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000968 RID: 2408
	public class ConfigSheriffQuestByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003883 RID: 14467 RVA: 0x0019C080 File Offset: 0x0019A280
		static ConfigSheriffQuestByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByQuestId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0019C0A0 File Offset: 0x0019A2A0
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

		// Token: 0x06003885 RID: 14469 RVA: 0x0019C11F File Offset: 0x0019A31F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByQuestId.LogPair = null;
			ConfigSheriffQuestByQuestId.HandleId = 0;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0019C12D File Offset: 0x0019A32D
		public static void Init()
		{
			ConfigSheriffQuestByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByQuestId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where QuestId=?");
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0019C148 File Offset: 0x0019A348
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

		// Token: 0x040041BE RID: 16830
		private const string DB = "db_sheriff.db";

		// Token: 0x040041BF RID: 16831
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041C0 RID: 16832
		private const string TABLE = "SheriffQuest";

		// Token: 0x040041C1 RID: 16833
		private const string COMMAND = "select BinData from `SheriffQuest` where QuestId=?";

		// Token: 0x040041C2 RID: 16834
		private const string KEY_PREFIX = "SheriffQuestByQuestId";

		// Token: 0x040041C3 RID: 16835
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041C4 RID: 16836
		private static int HandleId;
	}
}
