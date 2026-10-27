using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C4 RID: 1732
	public class ConfigPhonographMusicAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x0013F634 File Offset: 0x0013D834
		static ConfigPhonographMusicAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographMusicAll.CreateStaticDefaultValue), new Action(ConfigPhonographMusicAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0013F654 File Offset: 0x0013D854
		public static void CreateStaticDefaultValue()
		{
			ConfigPhonographMusicAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhonographMusicAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonograph.db"),
				new ValueTuple<string, object>("文件", "l.留声机.xlsx"),
				new ValueTuple<string, object>("表名", "PhonographMusic"),
				new ValueTuple<string, object>("语句", "select BinData from `PhonographMusic`")
			});
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0013F6D3 File Offset: 0x0013D8D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographMusicAll.LogPair = null;
			ConfigPhonographMusicAll.HandleId = 0;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0013F6E1 File Offset: 0x0013D8E1
		public static void Init()
		{
			ConfigPhonographMusicAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographMusicAll.HandleId, "db_phonograph.db", "select BinData from `PhonographMusic`");
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0013F6FC File Offset: 0x0013D8FC
		[NullableContext(2)]
		public static IReadOnlyList<PhonographMusic> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhonographMusicAll.HandleId, ConfigPhonographMusicAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhonographMusic> readOnlyList = (IReadOnlyList<PhonographMusic>)ConfigCommon.GetConfig("PhonographMusicAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhonographMusic> list = new List<PhonographMusic>();
			while (ConfigCommon.Step(ConfigPhonographMusicAll.HandleId, false, ConfigPhonographMusicAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhonographMusicAll.HandleId, 0, ConfigPhonographMusicAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhonographMusicAll.HandleId, ConfigPhonographMusicAll.LogPair);
					return null;
				}
				PhonographMusic rootAsPhonographMusic = PhonographMusic.GetRootAsPhonographMusic(new ByteBuffer(item2));
				list.Add(rootAsPhonographMusic);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhonographMusicAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhonographMusicAll.HandleId, ConfigPhonographMusicAll.LogPair);
			return list;
		}

		// Token: 0x04002F42 RID: 12098
		private const string DB = "db_phonograph.db";

		// Token: 0x04002F43 RID: 12099
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002F44 RID: 12100
		private const string TABLE = "PhonographMusic";

		// Token: 0x04002F45 RID: 12101
		private const string COMMAND = "select BinData from `PhonographMusic`";

		// Token: 0x04002F46 RID: 12102
		private const string KEY_PREFIX = "PhonographMusicAll";

		// Token: 0x04002F47 RID: 12103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F48 RID: 12104
		private static int HandleId;
	}
}
