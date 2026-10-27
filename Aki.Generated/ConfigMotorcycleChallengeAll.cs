using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000576 RID: 1398
	public class ConfigMotorcycleChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x00112F48 File Offset: 0x00111148
		static ConfigMotorcycleChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorcycleChallengeAll.CreateStaticDefaultValue), new Action(ConfigMotorcycleChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00112F68 File Offset: 0x00111168
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorcycleChallengeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorcycleChallengeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "MotorcycleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorcycleChallenge`")
			});
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00112FE7 File Offset: 0x001111E7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorcycleChallengeAll.LogPair = null;
			ConfigMotorcycleChallengeAll.HandleId = 0;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00112FF5 File Offset: 0x001111F5
		public static void Init()
		{
			ConfigMotorcycleChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorcycleChallengeAll.HandleId, "db_roadbook.db", "select BinData from `MotorcycleChallenge`");
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00113010 File Offset: 0x00111210
		[NullableContext(2)]
		public static IReadOnlyList<MotorcycleChallenge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorcycleChallenge> readOnlyList = (IReadOnlyList<MotorcycleChallenge>)ConfigCommon.GetConfig("MotorcycleChallengeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorcycleChallenge> list = new List<MotorcycleChallenge>();
			while (ConfigCommon.Step(ConfigMotorcycleChallengeAll.HandleId, false, ConfigMotorcycleChallengeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorcycleChallengeAll.HandleId, 0, ConfigMotorcycleChallengeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair);
					return null;
				}
				MotorcycleChallenge rootAsMotorcycleChallenge = MotorcycleChallenge.GetRootAsMotorcycleChallenge(new ByteBuffer(item2));
				list.Add(rootAsMotorcycleChallenge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorcycleChallengeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorcycleChallengeAll.HandleId, ConfigMotorcycleChallengeAll.LogPair);
			return list;
		}

		// Token: 0x0400261E RID: 9758
		private const string DB = "db_roadbook.db";

		// Token: 0x0400261F RID: 9759
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04002620 RID: 9760
		private const string TABLE = "MotorcycleChallenge";

		// Token: 0x04002621 RID: 9761
		private const string COMMAND = "select BinData from `MotorcycleChallenge`";

		// Token: 0x04002622 RID: 9762
		private const string KEY_PREFIX = "MotorcycleChallengeAll";

		// Token: 0x04002623 RID: 9763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002624 RID: 9764
		private static int HandleId;
	}
}
