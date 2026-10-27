using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000568 RID: 1384
	public class ConfigMoraleLevelDiffShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600207D RID: 8317 RVA: 0x00111104 File Offset: 0x0010F304
		static ConfigMoraleLevelDiffShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffShowAll.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00111124 File Offset: 0x0010F324
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLevelDiffShowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLevelDiffShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLevelDiffShow`")
			});
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x001111A3 File Offset: 0x0010F3A3
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffShowAll.LogPair = null;
			ConfigMoraleLevelDiffShowAll.HandleId = 0;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x001111B1 File Offset: 0x0010F3B1
		public static void Init()
		{
			ConfigMoraleLevelDiffShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffShowAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiffShow`");
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x001111CC File Offset: 0x0010F3CC
		[NullableContext(2)]
		public static IReadOnlyList<MoraleLevelDiffShow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleLevelDiffShow> readOnlyList = (IReadOnlyList<MoraleLevelDiffShow>)ConfigCommon.GetConfig("MoraleLevelDiffShowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleLevelDiffShow> list = new List<MoraleLevelDiffShow>();
			while (ConfigCommon.Step(ConfigMoraleLevelDiffShowAll.HandleId, false, ConfigMoraleLevelDiffShowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLevelDiffShowAll.HandleId, 0, ConfigMoraleLevelDiffShowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair);
					return null;
				}
				MoraleLevelDiffShow rootAsMoraleLevelDiffShow = MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(new ByteBuffer(item2));
				list.Add(rootAsMoraleLevelDiffShow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleLevelDiffShowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleLevelDiffShowAll.HandleId, ConfigMoraleLevelDiffShowAll.LogPair);
			return list;
		}

		// Token: 0x040025BC RID: 9660
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025BD RID: 9661
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025BE RID: 9662
		private const string TABLE = "MoraleLevelDiffShow";

		// Token: 0x040025BF RID: 9663
		private const string COMMAND = "select BinData from `MoraleLevelDiffShow`";

		// Token: 0x040025C0 RID: 9664
		private const string KEY_PREFIX = "MoraleLevelDiffShowAll";

		// Token: 0x040025C1 RID: 9665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025C2 RID: 9666
		private static int HandleId;
	}
}
