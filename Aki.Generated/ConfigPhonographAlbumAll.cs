using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DA RID: 1754
	public class ConfigPhonographAlbumAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600292C RID: 10540 RVA: 0x00145CD4 File Offset: 0x00143ED4
		static ConfigPhonographAlbumAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographAlbumAll.CreateStaticDefaultValue), new Action(ConfigPhonographAlbumAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00145CF4 File Offset: 0x00143EF4
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

		// Token: 0x0600292E RID: 10542 RVA: 0x00145D73 File Offset: 0x00143F73
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographAlbumAll.LogPair = null;
			ConfigPhonographAlbumAll.HandleId = 0;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00145D81 File Offset: 0x00143F81
		public static void Init()
		{
			ConfigPhonographAlbumAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographAlbumAll.HandleId, "db_phonograph.db", "select BinData from `PhonographAlbum`");
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00145D9C File Offset: 0x00143F9C
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

		// Token: 0x04002FDC RID: 12252
		private const string DB = "db_phonograph.db";

		// Token: 0x04002FDD RID: 12253
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002FDE RID: 12254
		private const string TABLE = "PhonographAlbum";

		// Token: 0x04002FDF RID: 12255
		private const string COMMAND = "select BinData from `PhonographAlbum`";

		// Token: 0x04002FE0 RID: 12256
		private const string KEY_PREFIX = "PhonographAlbumAll";

		// Token: 0x04002FE1 RID: 12257
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FE2 RID: 12258
		private static int HandleId;
	}
}
