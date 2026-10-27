using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C2 RID: 1730
	public class ConfigPhonographAlbumAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x0013F258 File Offset: 0x0013D458
		static ConfigPhonographAlbumAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographAlbumAll.CreateStaticDefaultValue), new Action(ConfigPhonographAlbumAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0013F278 File Offset: 0x0013D478
		public static void CreateStaticDefaultValue()
		{
			ConfigPhonographAlbumAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhonographAlbumAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonograph.db"),
				new ValueTuple<string, object>("文件", "l.留声机.xlsx"),
				new ValueTuple<string, object>("表名", "PhonographAlbum"),
				new ValueTuple<string, object>("语句", "select BinData from `PhonographAlbum`")
			});
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0013F2F7 File Offset: 0x0013D4F7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographAlbumAll.LogPair = null;
			ConfigPhonographAlbumAll.HandleId = 0;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0013F305 File Offset: 0x0013D505
		public static void Init()
		{
			ConfigPhonographAlbumAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographAlbumAll.HandleId, "db_phonograph.db", "select BinData from `PhonographAlbum`");
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0013F320 File Offset: 0x0013D520
		[NullableContext(2)]
		public static IReadOnlyList<PhonographAlbum> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhonographAlbumAll.HandleId, ConfigPhonographAlbumAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhonographAlbum> readOnlyList = (IReadOnlyList<PhonographAlbum>)ConfigCommon.GetConfig("PhonographAlbumAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhonographAlbum> list = new List<PhonographAlbum>();
			while (ConfigCommon.Step(ConfigPhonographAlbumAll.HandleId, false, ConfigPhonographAlbumAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhonographAlbumAll.HandleId, 0, ConfigPhonographAlbumAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhonographAlbumAll.HandleId, ConfigPhonographAlbumAll.LogPair);
					return null;
				}
				PhonographAlbum rootAsPhonographAlbum = PhonographAlbum.GetRootAsPhonographAlbum(new ByteBuffer(item2));
				list.Add(rootAsPhonographAlbum);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhonographAlbumAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhonographAlbumAll.HandleId, ConfigPhonographAlbumAll.LogPair);
			return list;
		}

		// Token: 0x04002F34 RID: 12084
		private const string DB = "db_phonograph.db";

		// Token: 0x04002F35 RID: 12085
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002F36 RID: 12086
		private const string TABLE = "PhonographAlbum";

		// Token: 0x04002F37 RID: 12087
		private const string COMMAND = "select BinData from `PhonographAlbum`";

		// Token: 0x04002F38 RID: 12088
		private const string KEY_PREFIX = "PhonographAlbumAll";

		// Token: 0x04002F39 RID: 12089
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F3A RID: 12090
		private static int HandleId;
	}
}
