using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F6 RID: 758
	public class ConfigFlagChallengeAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x000BE0D0 File Offset: 0x000BC2D0
		static ConfigFlagChallengeAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaAll.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeArea`")
			});
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000BE16F File Offset: 0x000BC36F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaAll.LogPair = null;
			ConfigFlagChallengeAreaAll.HandleId = 0;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000BE17D File Offset: 0x000BC37D
		public static void Init()
		{
			ConfigFlagChallengeAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaAll.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea`");
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x000BE198 File Offset: 0x000BC398
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FlagChallengeArea> readOnlyList = (IReadOnlyList<FlagChallengeArea>)ConfigCommon.GetConfig("FlagChallengeAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FlagChallengeArea> list = new List<FlagChallengeArea>();
			while (ConfigCommon.Step(ConfigFlagChallengeAreaAll.HandleId, false, ConfigFlagChallengeAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeAreaAll.HandleId, 0, ConfigFlagChallengeAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair);
					return null;
				}
				FlagChallengeArea rootAsFlagChallengeArea = FlagChallengeArea.GetRootAsFlagChallengeArea(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FlagChallengeAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeAreaAll.HandleId, ConfigFlagChallengeAreaAll.LogPair);
			return list;
		}

		// Token: 0x0400149E RID: 5278
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400149F RID: 5279
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x040014A0 RID: 5280
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x040014A1 RID: 5281
		private const string COMMAND = "select BinData from `FlagChallengeArea`";

		// Token: 0x040014A2 RID: 5282
		private const string KEY_PREFIX = "FlagChallengeAreaAll";

		// Token: 0x040014A3 RID: 5283
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014A4 RID: 5284
		private static int HandleId;
	}
}
