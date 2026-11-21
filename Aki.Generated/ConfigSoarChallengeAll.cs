using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AB RID: 2475
	public class ConfigSoarChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A16 RID: 14870 RVA: 0x001A52A9 File Offset: 0x001A34A9
		static ConfigSoarChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarChallengeAll.CreateStaticDefaultValue), new Action(ConfigSoarChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x001A52C8 File Offset: 0x001A34C8
		public static void CreateStaticDefaultValue()
		{
			ConfigSoarChallengeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoarChallengeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "SoarChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `SoarChallenge`")
			});
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x001A5347 File Offset: 0x001A3547
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarChallengeAll.LogPair = null;
			ConfigSoarChallengeAll.HandleId = 0;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x001A5355 File Offset: 0x001A3555
		public static void Init()
		{
			ConfigSoarChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSoarChallengeAll.HandleId, "db_activitymaptravel.db", "select BinData from `SoarChallenge`");
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x001A5370 File Offset: 0x001A3570
		[NullableContext(2)]
		public static IReadOnlyList<SoarChallenge> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoarChallengeAll.HandleId, ConfigSoarChallengeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SoarChallenge> readOnlyList = (IReadOnlyList<SoarChallenge>)ConfigCommon.GetConfig("SoarChallengeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SoarChallenge> list = new List<SoarChallenge>();
			while (ConfigCommon.Step(ConfigSoarChallengeAll.HandleId, false, ConfigSoarChallengeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoarChallengeAll.HandleId, 0, ConfigSoarChallengeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSoarChallengeAll.HandleId, ConfigSoarChallengeAll.LogPair);
					return null;
				}
				SoarChallenge rootAsSoarChallenge = SoarChallenge.GetRootAsSoarChallenge(new ByteBuffer(item2));
				list.Add(rootAsSoarChallenge);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SoarChallengeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSoarChallengeAll.HandleId, ConfigSoarChallengeAll.LogPair);
			return list;
		}

		// Token: 0x04004393 RID: 17299
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004394 RID: 17300
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004395 RID: 17301
		private const string TABLE = "SoarChallenge";

		// Token: 0x04004396 RID: 17302
		private const string COMMAND = "select BinData from `SoarChallenge`";

		// Token: 0x04004397 RID: 17303
		private const string KEY_PREFIX = "SoarChallengeAll";

		// Token: 0x04004398 RID: 17304
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004399 RID: 17305
		private static int HandleId;
	}
}
