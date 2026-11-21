using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000321 RID: 801
	public class ConfigFloroRanchAudioAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x000C75A4 File Offset: 0x000C57A4
		static ConfigFloroRanchAudioAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000C75C4 File Offset: 0x000C57C4
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchAudioAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchAudioAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAudio`")
			});
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000C7643 File Offset: 0x000C5843
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioAll.LogPair = null;
			ConfigFloroRanchAudioAll.HandleId = 0;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000C7651 File Offset: 0x000C5851
		public static void Init()
		{
			ConfigFloroRanchAudioAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio`");
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000C766C File Offset: 0x000C586C
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchAudio> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchAudio> readOnlyList = (IReadOnlyList<FloroRanchAudio>)ConfigCommon.GetConfig("FloroRanchAudioAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchAudio> list = new List<FloroRanchAudio>();
			while (ConfigCommon.Step(ConfigFloroRanchAudioAll.HandleId, false, ConfigFloroRanchAudioAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchAudioAll.HandleId, 0, ConfigFloroRanchAudioAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair);
					return null;
				}
				FloroRanchAudio rootAsFloroRanchAudio = FloroRanchAudio.GetRootAsFloroRanchAudio(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchAudio);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchAudioAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair);
			return list;
		}

		// Token: 0x040015CB RID: 5579
		private const string DB = "db_flororanch.db";

		// Token: 0x040015CC RID: 5580
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015CD RID: 5581
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x040015CE RID: 5582
		private const string COMMAND = "select BinData from `FloroRanchAudio`";

		// Token: 0x040015CF RID: 5583
		private const string KEY_PREFIX = "FloroRanchAudioAll";

		// Token: 0x040015D0 RID: 5584
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015D1 RID: 5585
		private static int HandleId;
	}
}
