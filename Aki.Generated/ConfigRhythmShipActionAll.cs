using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F2 RID: 2034
	public class ConfigRhythmShipActionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FBE RID: 12222 RVA: 0x00167244 File Offset: 0x00165444
		static ConfigRhythmShipActionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipActionAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipActionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00167264 File Offset: 0x00165464
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipActionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipActionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipAction"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipAction`")
			});
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x001672E3 File Offset: 0x001654E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipActionAll.LogPair = null;
			ConfigRhythmShipActionAll.HandleId = 0;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x001672F1 File Offset: 0x001654F1
		public static void Init()
		{
			ConfigRhythmShipActionAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipActionAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipAction`");
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x0016730C File Offset: 0x0016550C
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipAction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RhythmShipAction> readOnlyList = (IReadOnlyList<RhythmShipAction>)ConfigCommon.GetConfig("RhythmShipActionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RhythmShipAction> list = new List<RhythmShipAction>();
			while (ConfigCommon.Step(ConfigRhythmShipActionAll.HandleId, false, ConfigRhythmShipActionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipActionAll.HandleId, 0, ConfigRhythmShipActionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair);
					return null;
				}
				RhythmShipAction rootAsRhythmShipAction = RhythmShipAction.GetRootAsRhythmShipAction(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipAction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RhythmShipActionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipActionAll.HandleId, ConfigRhythmShipActionAll.LogPair);
			return list;
		}

		// Token: 0x04003784 RID: 14212
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003785 RID: 14213
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003786 RID: 14214
		private const string TABLE = "RhythmShipAction";

		// Token: 0x04003787 RID: 14215
		private const string COMMAND = "select BinData from `RhythmShipAction`";

		// Token: 0x04003788 RID: 14216
		private const string KEY_PREFIX = "RhythmShipActionAll";

		// Token: 0x04003789 RID: 14217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400378A RID: 14218
		private static int HandleId;
	}
}
