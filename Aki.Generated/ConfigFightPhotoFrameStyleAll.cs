using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D3 RID: 723
	public class ConfigFightPhotoFrameStyleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x000BCF78 File Offset: 0x000BB178
		static ConfigFightPhotoFrameStyleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoFrameStyleAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoFrameStyleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000BCF98 File Offset: 0x000BB198
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

		// Token: 0x060010F9 RID: 4345 RVA: 0x000BD017 File Offset: 0x000BB217
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoFrameStyleAll.LogPair = null;
			ConfigFightPhotoFrameStyleAll.HandleId = 0;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000BD025 File Offset: 0x000BB225
		public static void Init()
		{
			ConfigFightPhotoFrameStyleAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoFrameStyleAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoFrameStyle`");
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000BD040 File Offset: 0x000BB240
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

		// Token: 0x040013A9 RID: 5033
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013AA RID: 5034
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013AB RID: 5035
		private const string TABLE = "FightPhotoFrameStyle";

		// Token: 0x040013AC RID: 5036
		private const string COMMAND = "select BinData from `FightPhotoFrameStyle`";

		// Token: 0x040013AD RID: 5037
		private const string KEY_PREFIX = "FightPhotoFrameStyleAll";

		// Token: 0x040013AE RID: 5038
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013AF RID: 5039
		private static int HandleId;
	}
}
