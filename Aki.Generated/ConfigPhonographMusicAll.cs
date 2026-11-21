using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DC RID: 1756
	public class ConfigPhonographMusicAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002938 RID: 10552 RVA: 0x001460B0 File Offset: 0x001442B0
		static ConfigPhonographMusicAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographMusicAll.CreateStaticDefaultValue), new Action(ConfigPhonographMusicAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x001460D0 File Offset: 0x001442D0
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

		// Token: 0x0600293A RID: 10554 RVA: 0x0014614F File Offset: 0x0014434F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographMusicAll.LogPair = null;
			ConfigPhonographMusicAll.HandleId = 0;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0014615D File Offset: 0x0014435D
		public static void Init()
		{
			ConfigPhonographMusicAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographMusicAll.HandleId, "db_phonograph.db", "select BinData from `PhonographMusic`");
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00146178 File Offset: 0x00144378
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

		// Token: 0x04002FEA RID: 12266
		private const string DB = "db_phonograph.db";

		// Token: 0x04002FEB RID: 12267
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002FEC RID: 12268
		private const string TABLE = "PhonographMusic";

		// Token: 0x04002FED RID: 12269
		private const string COMMAND = "select BinData from `PhonographMusic`";

		// Token: 0x04002FEE RID: 12270
		private const string KEY_PREFIX = "PhonographMusicAll";

		// Token: 0x04002FEF RID: 12271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FF0 RID: 12272
		private static int HandleId;
	}
}
