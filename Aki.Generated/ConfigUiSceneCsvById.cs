using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6D RID: 2669
	public class ConfigUiSceneCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EA2 RID: 16034 RVA: 0x001BC2D9 File Offset: 0x001BA4D9
		static ConfigUiSceneCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiSceneCsvById.CreateStaticDefaultValue), new Action(ConfigUiSceneCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x001BC2F8 File Offset: 0x001BA4F8
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

		// Token: 0x06003EA4 RID: 16036 RVA: 0x001BC377 File Offset: 0x001BA577
		public static void ResetStaticDefaultValue()
		{
			ConfigUiSceneCsvById.LogPair = null;
			ConfigUiSceneCsvById.HandleId = 0;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x001BC385 File Offset: 0x001BA585
		public static void Init()
		{
			ConfigUiSceneCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigUiSceneCsvById.HandleId, "db_uiscene.db", "select BinData from `UiSceneCsv` where Id=?");
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x001BC3A0 File Offset: 0x001BA5A0
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

		// Token: 0x040048E1 RID: 18657
		private const string DB = "db_uiscene.db";

		// Token: 0x040048E2 RID: 18658
		private const string FILE = "u.UI场景.csv";

		// Token: 0x040048E3 RID: 18659
		private const string TABLE = "UiSceneCsv";

		// Token: 0x040048E4 RID: 18660
		private const string COMMAND = "select BinData from `UiSceneCsv` where Id=?";

		// Token: 0x040048E5 RID: 18661
		private const string KEY_PREFIX = "UiSceneCsvById";

		// Token: 0x040048E6 RID: 18662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048E7 RID: 18663
		private static int HandleId;
	}
}
