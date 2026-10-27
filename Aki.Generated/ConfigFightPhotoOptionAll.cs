using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C0 RID: 704
	public class ConfigFightPhotoOptionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001085 RID: 4229 RVA: 0x000B6E48 File Offset: 0x000B5048
		static ConfigFightPhotoOptionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoOptionAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoOptionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000B6E68 File Offset: 0x000B5068
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

		// Token: 0x06001087 RID: 4231 RVA: 0x000B6EE7 File Offset: 0x000B50E7
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoOptionAll.LogPair = null;
			ConfigFightPhotoOptionAll.HandleId = 0;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000B6EF5 File Offset: 0x000B50F5
		public static void Init()
		{
			ConfigFightPhotoOptionAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoOptionAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoOption`");
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000B6F10 File Offset: 0x000B5110
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

		// Token: 0x04001324 RID: 4900
		private const string DB = "db_fightphotooption.db";

		// Token: 0x04001325 RID: 4901
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x04001326 RID: 4902
		private const string TABLE = "FightPhotoOption";

		// Token: 0x04001327 RID: 4903
		private const string COMMAND = "select BinData from `FightPhotoOption`";

		// Token: 0x04001328 RID: 4904
		private const string KEY_PREFIX = "FightPhotoOptionAll";

		// Token: 0x04001329 RID: 4905
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400132A RID: 4906
		private static int HandleId;
	}
}
