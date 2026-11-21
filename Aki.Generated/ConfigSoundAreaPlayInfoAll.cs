using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A39 RID: 2617
	public class ConfigSoundAreaPlayInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x001B7CDD File Offset: 0x001B5EDD
		static ConfigSoundAreaPlayInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundAreaPlayInfoAll.CreateStaticDefaultValue), new Action(ConfigSoundAreaPlayInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x001B7CFC File Offset: 0x001B5EFC
		public static void CreateStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoundAreaPlayInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_soundareaplayinfo.db"),
				new ValueTuple<string, object>("文件", "w.无音区玩法信息.xlsx"),
				new ValueTuple<string, object>("表名", "SoundAreaPlayInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SoundAreaPlayInfo`")
			});
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x001B7D7B File Offset: 0x001B5F7B
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoAll.LogPair = null;
			ConfigSoundAreaPlayInfoAll.HandleId = 0;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x001B7D89 File Offset: 0x001B5F89
		public static void Init()
		{
			ConfigSoundAreaPlayInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigSoundAreaPlayInfoAll.HandleId, "db_soundareaplayinfo.db", "select BinData from `SoundAreaPlayInfo`");
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x001B7DA4 File Offset: 0x001B5FA4
		[NullableContext(2)]
		public static IReadOnlyList<SoundAreaPlayInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SoundAreaPlayInfo> readOnlyList = (IReadOnlyList<SoundAreaPlayInfo>)ConfigCommon.GetConfig("SoundAreaPlayInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SoundAreaPlayInfo> list = new List<SoundAreaPlayInfo>();
			while (ConfigCommon.Step(ConfigSoundAreaPlayInfoAll.HandleId, false, ConfigSoundAreaPlayInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoundAreaPlayInfoAll.HandleId, 0, ConfigSoundAreaPlayInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair);
					return null;
				}
				SoundAreaPlayInfo rootAsSoundAreaPlayInfo = SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(new ByteBuffer(item2));
				list.Add(rootAsSoundAreaPlayInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SoundAreaPlayInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair);
			return list;
		}

		// Token: 0x04004775 RID: 18293
		private const string DB = "db_soundareaplayinfo.db";

		// Token: 0x04004776 RID: 18294
		private const string FILE = "w.无音区玩法信息.xlsx";

		// Token: 0x04004777 RID: 18295
		private const string TABLE = "SoundAreaPlayInfo";

		// Token: 0x04004778 RID: 18296
		private const string COMMAND = "select BinData from `SoundAreaPlayInfo`";

		// Token: 0x04004779 RID: 18297
		private const string KEY_PREFIX = "SoundAreaPlayInfoAll";

		// Token: 0x0400477A RID: 18298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400477B RID: 18299
		private static int HandleId;
	}
}
