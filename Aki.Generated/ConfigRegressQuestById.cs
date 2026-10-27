using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D5 RID: 2005
	public class ConfigRegressQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x001633AF File Offset: 0x001615AF
		static ConfigRegressQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressQuestById.CreateStaticDefaultValue), new Action(ConfigRegressQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x001633D0 File Offset: 0x001615D0
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

		// Token: 0x06002F12 RID: 12050 RVA: 0x0016344F File Offset: 0x0016164F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressQuestById.LogPair = null;
			ConfigRegressQuestById.HandleId = 0;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x0016345D File Offset: 0x0016165D
		public static void Init()
		{
			ConfigRegressQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressQuestById.HandleId, "db_regressactivity.db", "select BinData from `RegressQuest` where Id=?");
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00163478 File Offset: 0x00161678
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

		// Token: 0x040036B9 RID: 14009
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036BA RID: 14010
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036BB RID: 14011
		private const string TABLE = "RegressQuest";

		// Token: 0x040036BC RID: 14012
		private const string COMMAND = "select BinData from `RegressQuest` where Id=?";

		// Token: 0x040036BD RID: 14013
		private const string KEY_PREFIX = "RegressQuestById";

		// Token: 0x040036BE RID: 14014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036BF RID: 14015
		private static int HandleId;
	}
}
