using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000497 RID: 1175
	public class ConfigKujiQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B94 RID: 7060 RVA: 0x000F8C63 File Offset: 0x000F6E63
		static ConfigKujiQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiQuestById.CreateStaticDefaultValue), new Action(ConfigKujiQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000F8C84 File Offset: 0x000F6E84
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

		// Token: 0x06001B96 RID: 7062 RVA: 0x000F8D03 File Offset: 0x000F6F03
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiQuestById.LogPair = null;
			ConfigKujiQuestById.HandleId = 0;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000F8D11 File Offset: 0x000F6F11
		public static void Init()
		{
			ConfigKujiQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigKujiQuestById.HandleId, "db_wuwukuji.db", "select BinData from `KujiQuest` where Id=?");
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000F8D2C File Offset: 0x000F6F2C
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

		// Token: 0x04002005 RID: 8197
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04002006 RID: 8198
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04002007 RID: 8199
		private const string TABLE = "KujiQuest";

		// Token: 0x04002008 RID: 8200
		private const string COMMAND = "select BinData from `KujiQuest` where Id=?";

		// Token: 0x04002009 RID: 8201
		private const string KEY_PREFIX = "KujiQuestById";

		// Token: 0x0400200A RID: 8202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400200B RID: 8203
		private static int HandleId;
	}
}
