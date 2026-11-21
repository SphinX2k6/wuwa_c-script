using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EC RID: 1004
	public class ConfigHiddenQuestWhiteByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600178F RID: 6031 RVA: 0x000E23CC File Offset: 0x000E05CC
		static ConfigHiddenQuestWhiteByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHiddenQuestWhiteByQuestId.CreateStaticDefaultValue), new Action(ConfigHiddenQuestWhiteByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000E23EC File Offset: 0x000E05EC
		public static void CreateStaticDefaultValue()
		{
			ConfigHiddenQuestWhiteByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHiddenQuestWhiteByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "HiddenQuestWhite"),
				new ValueTuple<string, object>("语句", "select BinData from `HiddenQuestWhite` where QuestId=?")
			});
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000E246B File Offset: 0x000E066B
		public static void ResetStaticDefaultValue()
		{
			ConfigHiddenQuestWhiteByQuestId.LogPair = null;
			ConfigHiddenQuestWhiteByQuestId.HandleId = 0;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000E2479 File Offset: 0x000E0679
		public static void Init()
		{
			ConfigHiddenQuestWhiteByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigHiddenQuestWhiteByQuestId.HandleId, "db_download.db", "select BinData from `HiddenQuestWhite` where QuestId=?");
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000E2494 File Offset: 0x000E0694
		public static HiddenQuestWhite? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHiddenQuestWhiteByQuestId.HandleId, ConfigHiddenQuestWhiteByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HiddenQuestWhiteByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HiddenQuestWhite?(HiddenQuestWhite.GetRootAsHiddenQuestWhite(configBuffer));
				}
			}
			ConfigHiddenQuestWhiteByQuestId.LogPair.Clear();
			ConfigHiddenQuestWhiteByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigHiddenQuestWhiteByQuestId.HandleId, 1, p0QuestId, ConfigHiddenQuestWhiteByQuestId.LogPair) || ConfigCommon.Step(ConfigHiddenQuestWhiteByQuestId.HandleId, true, ConfigHiddenQuestWhiteByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHiddenQuestWhiteByQuestId.HandleId, ConfigHiddenQuestWhiteByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHiddenQuestWhiteByQuestId.HandleId, 0, ConfigHiddenQuestWhiteByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHiddenQuestWhiteByQuestId.HandleId, ConfigHiddenQuestWhiteByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HiddenQuestWhite rootAsHiddenQuestWhite = HiddenQuestWhite.GetRootAsHiddenQuestWhite(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HiddenQuestWhiteByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHiddenQuestWhiteByQuestId.HandleId, ConfigHiddenQuestWhiteByQuestId.LogPair);
			return new HiddenQuestWhite?(rootAsHiddenQuestWhite);
		}

		// Token: 0x04001B58 RID: 7000
		private const string DB = "db_download.db";

		// Token: 0x04001B59 RID: 7001
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04001B5A RID: 7002
		private const string TABLE = "HiddenQuestWhite";

		// Token: 0x04001B5B RID: 7003
		private const string COMMAND = "select BinData from `HiddenQuestWhite` where QuestId=?";

		// Token: 0x04001B5C RID: 7004
		private const string KEY_PREFIX = "HiddenQuestWhiteByQuestId";

		// Token: 0x04001B5D RID: 7005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B5E RID: 7006
		private static int HandleId;
	}
}
