using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C4 RID: 708
	public class ConfigFightPhotoTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x000B7600 File Offset: 0x000B5800
		static ConfigFightPhotoTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoTabAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000B7620 File Offset: 0x000B5820
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoTab`")
			});
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000B769F File Offset: 0x000B589F
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoTabAll.LogPair = null;
			ConfigFightPhotoTabAll.HandleId = 0;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000B76AD File Offset: 0x000B58AD
		public static void Init()
		{
			ConfigFightPhotoTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoTabAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoTab`");
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000B76C8 File Offset: 0x000B58C8
		[NullableContext(2)]
		public static IReadOnlyList<FightPhotoTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FightPhotoTab> readOnlyList = (IReadOnlyList<FightPhotoTab>)ConfigCommon.GetConfig("FightPhotoTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FightPhotoTab> list = new List<FightPhotoTab>();
			while (ConfigCommon.Step(ConfigFightPhotoTabAll.HandleId, false, ConfigFightPhotoTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoTabAll.HandleId, 0, ConfigFightPhotoTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair);
					return null;
				}
				FightPhotoTab rootAsFightPhotoTab = FightPhotoTab.GetRootAsFightPhotoTab(new ByteBuffer(item2));
				list.Add(rootAsFightPhotoTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FightPhotoTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair);
			return list;
		}

		// Token: 0x04001340 RID: 4928
		private const string DB = "db_fightphotooption.db";

		// Token: 0x04001341 RID: 4929
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x04001342 RID: 4930
		private const string TABLE = "FightPhotoTab";

		// Token: 0x04001343 RID: 4931
		private const string COMMAND = "select BinData from `FightPhotoTab`";

		// Token: 0x04001344 RID: 4932
		private const string KEY_PREFIX = "FightPhotoTabAll";

		// Token: 0x04001345 RID: 4933
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001346 RID: 4934
		private static int HandleId;
	}
}
