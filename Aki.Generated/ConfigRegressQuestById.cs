using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F1 RID: 2033
	public class ConfigRegressQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x0016A697 File Offset: 0x00168897
		static ConfigRegressQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressQuestById.CreateStaticDefaultValue), new Action(ConfigRegressQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0016A6B8 File Offset: 0x001688B8
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressQuest` where Id=?")
			});
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0016A737 File Offset: 0x00168937
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressQuestById.LogPair = null;
			ConfigRegressQuestById.HandleId = 0;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x0016A745 File Offset: 0x00168945
		public static void Init()
		{
			ConfigRegressQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressQuestById.HandleId, "db_regressactivity.db", "select BinData from `RegressQuest` where Id=?");
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0016A760 File Offset: 0x00168960
		public static RegressQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressQuestById.HandleId, ConfigRegressQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressQuest?(RegressQuest.GetRootAsRegressQuest(configBuffer));
				}
			}
			ConfigRegressQuestById.LogPair.Clear();
			ConfigRegressQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressQuestById.HandleId, 1, p0Id, ConfigRegressQuestById.LogPair) || ConfigCommon.Step(ConfigRegressQuestById.HandleId, true, ConfigRegressQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressQuestById.HandleId, ConfigRegressQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressQuestById.HandleId, 0, ConfigRegressQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressQuestById.HandleId, ConfigRegressQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressQuest rootAsRegressQuest = RegressQuest.GetRootAsRegressQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressQuestById.HandleId, ConfigRegressQuestById.LogPair);
			return new RegressQuest?(rootAsRegressQuest);
		}

		// Token: 0x0400377D RID: 14205
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400377E RID: 14206
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400377F RID: 14207
		private const string TABLE = "RegressQuest";

		// Token: 0x04003780 RID: 14208
		private const string COMMAND = "select BinData from `RegressQuest` where Id=?";

		// Token: 0x04003781 RID: 14209
		private const string KEY_PREFIX = "RegressQuestById";

		// Token: 0x04003782 RID: 14210
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003783 RID: 14211
		private static int HandleId;
	}
}
