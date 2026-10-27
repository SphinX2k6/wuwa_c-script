using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000960 RID: 2400
	public class ConfigSoarChallengeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003854 RID: 14420 RVA: 0x00198089 File Offset: 0x00196289
		static ConfigSoarChallengeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarChallengeAll.CreateStaticDefaultValue), new Action(ConfigSoarChallengeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x001980A8 File Offset: 0x001962A8
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

		// Token: 0x06003856 RID: 14422 RVA: 0x00198127 File Offset: 0x00196327
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarChallengeAll.LogPair = null;
			ConfigSoarChallengeAll.HandleId = 0;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00198135 File Offset: 0x00196335
		public static void Init()
		{
			ConfigSoarChallengeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSoarChallengeAll.HandleId, "db_activitymaptravel.db", "select BinData from `SoarChallenge`");
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00198150 File Offset: 0x00196350
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

		// Token: 0x04004186 RID: 16774
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004187 RID: 16775
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004188 RID: 16776
		private const string TABLE = "SoarChallenge";

		// Token: 0x04004189 RID: 16777
		private const string COMMAND = "select BinData from `SoarChallenge`";

		// Token: 0x0400418A RID: 16778
		private const string KEY_PREFIX = "SoarChallengeAll";

		// Token: 0x0400418B RID: 16779
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400418C RID: 16780
		private static int HandleId;
	}
}
