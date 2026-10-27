using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C2 RID: 706
	public class ConfigFightPhotoSetupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001091 RID: 4241 RVA: 0x000B7224 File Offset: 0x000B5424
		static ConfigFightPhotoSetupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoSetupAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoSetupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000B7244 File Offset: 0x000B5444
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

		// Token: 0x06001093 RID: 4243 RVA: 0x000B72C3 File Offset: 0x000B54C3
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoSetupAll.LogPair = null;
			ConfigFightPhotoSetupAll.HandleId = 0;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000B72D1 File Offset: 0x000B54D1
		public static void Init()
		{
			ConfigFightPhotoSetupAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoSetupAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoSetup`");
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000B72EC File Offset: 0x000B54EC
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

		// Token: 0x04001332 RID: 4914
		private const string DB = "db_fightphotooption.db";

		// Token: 0x04001333 RID: 4915
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x04001334 RID: 4916
		private const string TABLE = "FightPhotoSetup";

		// Token: 0x04001335 RID: 4917
		private const string COMMAND = "select BinData from `FightPhotoSetup`";

		// Token: 0x04001336 RID: 4918
		private const string KEY_PREFIX = "FightPhotoSetupAll";

		// Token: 0x04001337 RID: 4919
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001338 RID: 4920
		private static int HandleId;
	}
}
