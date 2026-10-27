using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000481 RID: 1153
	public class ConfigKujiQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x000F250F File Offset: 0x000F070F
		static ConfigKujiQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestById.CreateStaticDefaultValue), new Action(ConfigKujiQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000F2530 File Offset: 0x000F0730
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiQuest` where Id=?")
			});
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000F25AF File Offset: 0x000F07AF
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestById.LogPair = null;
			ConfigKujiQuestById.HandleId = 0;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000F25BD File Offset: 0x000F07BD
		public static void Init()
		{
			ConfigKujiQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestById.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest` where Id=?");
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000F25D8 File Offset: 0x000F07D8
		public static KujiQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiQuestById.HandleId, ConfigKujiQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KujiQuest?(KujiQuest.GetRootAsKujiQuest(configBuffer));
				}
			}
			ConfigKujiQuestById.LogPair.Clear();
			ConfigKujiQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKujiQuestById.HandleId, 1, p0Id, ConfigKujiQuestById.LogPair) || ConfigCommon.Step(ConfigKujiQuestById.HandleId, true, ConfigKujiQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKujiQuestById.HandleId, ConfigKujiQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiQuestById.HandleId, 0, ConfigKujiQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKujiQuestById.HandleId, ConfigKujiQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KujiQuest rootAsKujiQuest = KujiQuest.GetRootAsKujiQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKujiQuestById.HandleId, ConfigKujiQuestById.LogPair);
			return new KujiQuest?(rootAsKujiQuest);
		}

		// Token: 0x04001F6B RID: 8043
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F6C RID: 8044
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F6D RID: 8045
		private const string TABLE = "KujiQuest";

		// Token: 0x04001F6E RID: 8046
		private const string COMMAND = "select BinData from `KujiQuest` where Id=?";

		// Token: 0x04001F6F RID: 8047
		private const string KEY_PREFIX = "KujiQuestById";

		// Token: 0x04001F70 RID: 8048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F71 RID: 8049
		private static int HandleId;
	}
}
