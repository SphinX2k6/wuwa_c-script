using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B42 RID: 2882
	public class ConfigUiSceneCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043A0 RID: 17312 RVA: 0x001DB66D File Offset: 0x001D986D
		static ConfigUiSceneCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiSceneCsvById.CreateStaticDefaultValue), new Action(ConfigUiSceneCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x001DB68C File Offset: 0x001D988C
		public static void CreateStaticDefaultValue()
		{
			ConfigUiSceneCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiSceneCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uiscene.db"),
				new ValueTuple<string, object>("文件", "u.UI场景.csv"),
				new ValueTuple<string, object>("表名", "UiSceneCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `UiSceneCsv` where Id=?")
			});
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x001DB70B File Offset: 0x001D990B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiSceneCsvById.LogPair = null;
			ConfigUiSceneCsvById.HandleId = 0;
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x001DB719 File Offset: 0x001D9919
		public static void Init()
		{
			ConfigUiSceneCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigUiSceneCsvById.HandleId, "db_uiscene.db", "select BinData from `UiSceneCsv` where Id=?");
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x001DB734 File Offset: 0x001D9934
		public static UiSceneCsv? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiSceneCsvById.HandleId, ConfigUiSceneCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiSceneCsvById#" + p0Id);
				if (configBuffer != null)
				{
					return new UiSceneCsv?(UiSceneCsv.GetRootAsUiSceneCsv(configBuffer));
				}
			}
			ConfigUiSceneCsvById.LogPair.Clear();
			ConfigUiSceneCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigUiSceneCsvById.HandleId, 1, p0Id, ConfigUiSceneCsvById.LogPair) || ConfigCommon.Step(ConfigUiSceneCsvById.HandleId, true, ConfigUiSceneCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiSceneCsvById.HandleId, ConfigUiSceneCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiSceneCsvById.HandleId, 0, ConfigUiSceneCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiSceneCsvById.HandleId, ConfigUiSceneCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiSceneCsv rootAsUiSceneCsv = UiSceneCsv.GetRootAsUiSceneCsv(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiSceneCsvById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiSceneCsvById.HandleId, ConfigUiSceneCsvById.LogPair);
			return new UiSceneCsv?(rootAsUiSceneCsv);
		}

		// Token: 0x04004EB4 RID: 20148
		private const string DB = "db_uiscene.db";

		// Token: 0x04004EB5 RID: 20149
		private const string FILE = "u.UI场景.csv";

		// Token: 0x04004EB6 RID: 20150
		private const string TABLE = "UiSceneCsv";

		// Token: 0x04004EB7 RID: 20151
		private const string COMMAND = "select BinData from `UiSceneCsv` where Id=?";

		// Token: 0x04004EB8 RID: 20152
		private const string KEY_PREFIX = "UiSceneCsvById";

		// Token: 0x04004EB9 RID: 20153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EBA RID: 20154
		private static int HandleId;
	}
}
