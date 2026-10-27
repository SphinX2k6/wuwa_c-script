using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BE RID: 702
	public class ConfigFightPhotoFrameStyleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x000B6A6C File Offset: 0x000B4C6C
		static ConfigFightPhotoFrameStyleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoFrameStyleAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoFrameStyleAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000B6A8C File Offset: 0x000B4C8C
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoFrameStyleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoFrameStyle"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoFrameStyle`")
			});
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x000B6B0B File Offset: 0x000B4D0B
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleAll.LogPair = null;
			ConfigFightPhotoFrameStyleAll.HandleId = 0;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000B6B19 File Offset: 0x000B4D19
		public static void Init()
		{
			ConfigFightPhotoFrameStyleAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoFrameStyleAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoFrameStyle`");
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000B6B34 File Offset: 0x000B4D34
		[NullableContext(2)]
		public static IReadOnlyList<FightPhotoFrameStyle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoFrameStyleAll.HandleId, ConfigFightPhotoFrameStyleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FightPhotoFrameStyle> readOnlyList = (IReadOnlyList<FightPhotoFrameStyle>)ConfigCommon.GetConfig("FightPhotoFrameStyleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FightPhotoFrameStyle> list = new List<FightPhotoFrameStyle>();
			while (ConfigCommon.Step(ConfigFightPhotoFrameStyleAll.HandleId, false, ConfigFightPhotoFrameStyleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoFrameStyleAll.HandleId, 0, ConfigFightPhotoFrameStyleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFightPhotoFrameStyleAll.HandleId, ConfigFightPhotoFrameStyleAll.LogPair);
					return null;
				}
				FightPhotoFrameStyle rootAsFightPhotoFrameStyle = FightPhotoFrameStyle.GetRootAsFightPhotoFrameStyle(new ByteBuffer(item2));
				list.Add(rootAsFightPhotoFrameStyle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FightPhotoFrameStyleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFightPhotoFrameStyleAll.HandleId, ConfigFightPhotoFrameStyleAll.LogPair);
			return list;
		}

		// Token: 0x04001316 RID: 4886
		private const string DB = "db_fightphotooption.db";

		// Token: 0x04001317 RID: 4887
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x04001318 RID: 4888
		private const string TABLE = "FightPhotoFrameStyle";

		// Token: 0x04001319 RID: 4889
		private const string COMMAND = "select BinData from `FightPhotoFrameStyle`";

		// Token: 0x0400131A RID: 4890
		private const string KEY_PREFIX = "FightPhotoFrameStyleAll";

		// Token: 0x0400131B RID: 4891
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400131C RID: 4892
		private static int HandleId;
	}
}
