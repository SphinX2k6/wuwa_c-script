using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D5 RID: 725
	public class ConfigFightPhotoOptionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x000BD354 File Offset: 0x000BB554
		static ConfigFightPhotoOptionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoOptionAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoOptionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000BD374 File Offset: 0x000BB574
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoOptionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoOptionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoOption"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoOption`")
			});
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000BD3F3 File Offset: 0x000BB5F3
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoOptionAll.LogPair = null;
			ConfigFightPhotoOptionAll.HandleId = 0;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000BD401 File Offset: 0x000BB601
		public static void Init()
		{
			ConfigFightPhotoOptionAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoOptionAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoOption`");
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000BD41C File Offset: 0x000BB61C
		[NullableContext(2)]
		public static IReadOnlyList<FightPhotoOption> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoOptionAll.HandleId, ConfigFightPhotoOptionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FightPhotoOption> readOnlyList = (IReadOnlyList<FightPhotoOption>)ConfigCommon.GetConfig("FightPhotoOptionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FightPhotoOption> list = new List<FightPhotoOption>();
			while (ConfigCommon.Step(ConfigFightPhotoOptionAll.HandleId, false, ConfigFightPhotoOptionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoOptionAll.HandleId, 0, ConfigFightPhotoOptionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFightPhotoOptionAll.HandleId, ConfigFightPhotoOptionAll.LogPair);
					return null;
				}
				FightPhotoOption rootAsFightPhotoOption = FightPhotoOption.GetRootAsFightPhotoOption(new ByteBuffer(item2));
				list.Add(rootAsFightPhotoOption);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FightPhotoOptionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFightPhotoOptionAll.HandleId, ConfigFightPhotoOptionAll.LogPair);
			return list;
		}

		// Token: 0x040013B7 RID: 5047
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013B8 RID: 5048
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013B9 RID: 5049
		private const string TABLE = "FightPhotoOption";

		// Token: 0x040013BA RID: 5050
		private const string COMMAND = "select BinData from `FightPhotoOption`";

		// Token: 0x040013BB RID: 5051
		private const string KEY_PREFIX = "FightPhotoOptionAll";

		// Token: 0x040013BC RID: 5052
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013BD RID: 5053
		private static int HandleId;
	}
}
