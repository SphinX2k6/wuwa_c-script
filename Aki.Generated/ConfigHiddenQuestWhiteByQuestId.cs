using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D6 RID: 982
	public class ConfigHiddenQuestWhiteByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x000DBC78 File Offset: 0x000D9E78
		static ConfigHiddenQuestWhiteByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHiddenQuestWhiteByQuestId.CreateStaticDefaultValue), new Action(ConfigHiddenQuestWhiteByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000DBC98 File Offset: 0x000D9E98
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

		// Token: 0x0600170D RID: 5901 RVA: 0x000DBD17 File Offset: 0x000D9F17
		public static void ResetStaticDefaultValue()
		{
			ConfigHiddenQuestWhiteByQuestId.LogPair = null;
			ConfigHiddenQuestWhiteByQuestId.HandleId = 0;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000DBD25 File Offset: 0x000D9F25
		public static void Init()
		{
			ConfigHiddenQuestWhiteByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigHiddenQuestWhiteByQuestId.HandleId, "db_download.db", "select BinData from `HiddenQuestWhite` where QuestId=?");
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000DBD40 File Offset: 0x000D9F40
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

		// Token: 0x04001ABE RID: 6846
		private const string DB = "db_download.db";

		// Token: 0x04001ABF RID: 6847
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04001AC0 RID: 6848
		private const string TABLE = "HiddenQuestWhite";

		// Token: 0x04001AC1 RID: 6849
		private const string COMMAND = "select BinData from `HiddenQuestWhite` where QuestId=?";

		// Token: 0x04001AC2 RID: 6850
		private const string KEY_PREFIX = "HiddenQuestWhiteByQuestId";

		// Token: 0x04001AC3 RID: 6851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AC4 RID: 6852
		private static int HandleId;
	}
}
