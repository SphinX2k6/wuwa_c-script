using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CD RID: 205
	public class ConfigAvignonStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x000788A8 File Offset: 0x00076AA8
		static ConfigAvignonStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonStageAll.CreateStaticDefaultValue), new Action(ConfigAvignonStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000788C8 File Offset: 0x00076AC8
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonStageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonStageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonStage"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonStage`")
			});
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00078947 File Offset: 0x00076B47
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonStageAll.LogPair = null;
			ConfigAvignonStageAll.HandleId = 0;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00078955 File Offset: 0x00076B55
		public static void Init()
		{
			ConfigAvignonStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonStageAll.HandleId, "db_avignon.db", "select BinData from `AvignonStage`");
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00078970 File Offset: 0x00076B70
		[NullableContext(2)]
		public static IReadOnlyList<AvignonStage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AvignonStage> readOnlyList = (IReadOnlyList<AvignonStage>)ConfigCommon.GetConfig("AvignonStageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AvignonStage> list = new List<AvignonStage>();
			while (ConfigCommon.Step(ConfigAvignonStageAll.HandleId, false, ConfigAvignonStageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonStageAll.HandleId, 0, ConfigAvignonStageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair);
					return null;
				}
				AvignonStage rootAsAvignonStage = AvignonStage.GetRootAsAvignonStage(new ByteBuffer(item2));
				list.Add(rootAsAvignonStage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AvignonStageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair);
			return list;
		}

		// Token: 0x0400057F RID: 1407
		private const string DB = "db_avignon.db";

		// Token: 0x04000580 RID: 1408
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x04000581 RID: 1409
		private const string TABLE = "AvignonStage";

		// Token: 0x04000582 RID: 1410
		private const string COMMAND = "select BinData from `AvignonStage`";

		// Token: 0x04000583 RID: 1411
		private const string KEY_PREFIX = "AvignonStageAll";

		// Token: 0x04000584 RID: 1412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000585 RID: 1413
		private static int HandleId;
	}
}
