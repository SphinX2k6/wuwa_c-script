using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D7 RID: 727
	public class ConfigFightPhotoSetupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x000BD730 File Offset: 0x000BB930
		static ConfigFightPhotoSetupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoSetupAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoSetupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000BD750 File Offset: 0x000BB950
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoSetupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoSetupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoSetup`")
			});
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000BD7CF File Offset: 0x000BB9CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoSetupAll.LogPair = null;
			ConfigFightPhotoSetupAll.HandleId = 0;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000BD7DD File Offset: 0x000BB9DD
		public static void Init()
		{
			ConfigFightPhotoSetupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoSetupAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoSetup`");
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
		[NullableContext(2)]
		public static IReadOnlyList<FightPhotoSetup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoSetupAll.HandleId, ConfigFightPhotoSetupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FightPhotoSetup> readOnlyList = (IReadOnlyList<FightPhotoSetup>)ConfigCommon.GetConfig("FightPhotoSetupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FightPhotoSetup> list = new List<FightPhotoSetup>();
			while (ConfigCommon.Step(ConfigFightPhotoSetupAll.HandleId, false, ConfigFightPhotoSetupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoSetupAll.HandleId, 0, ConfigFightPhotoSetupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFightPhotoSetupAll.HandleId, ConfigFightPhotoSetupAll.LogPair);
					return null;
				}
				FightPhotoSetup rootAsFightPhotoSetup = FightPhotoSetup.GetRootAsFightPhotoSetup(new ByteBuffer(item2));
				list.Add(rootAsFightPhotoSetup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FightPhotoSetupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFightPhotoSetupAll.HandleId, ConfigFightPhotoSetupAll.LogPair);
			return list;
		}

		// Token: 0x040013C5 RID: 5061
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013C6 RID: 5062
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013C7 RID: 5063
		private const string TABLE = "FightPhotoSetup";

		// Token: 0x040013C8 RID: 5064
		private const string COMMAND = "select BinData from `FightPhotoSetup`";

		// Token: 0x040013C9 RID: 5065
		private const string KEY_PREFIX = "FightPhotoSetupAll";

		// Token: 0x040013CA RID: 5066
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013CB RID: 5067
		private static int HandleId;
	}
}
