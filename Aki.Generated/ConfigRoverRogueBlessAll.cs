using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DD RID: 2269
	public class ConfigRoverRogueBlessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003541 RID: 13633 RVA: 0x00186654 File Offset: 0x00184854
		static ConfigRoverRogueBlessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00186674 File Offset: 0x00184874
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBless"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBless`")
			});
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x001866F3 File Offset: 0x001848F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessAll.LogPair = null;
			ConfigRoverRogueBlessAll.HandleId = 0;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00186701 File Offset: 0x00184901
		public static void Init()
		{
			ConfigRoverRogueBlessAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBless`");
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0018671C File Offset: 0x0018491C
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueBless> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessAll.HandleId, ConfigRoverRogueBlessAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueBless> readOnlyList = (IReadOnlyList<RoverRogueBless>)ConfigCommon.GetConfig("RoverRogueBlessAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueBless> list = new List<RoverRogueBless>();
			while (ConfigCommon.Step(ConfigRoverRogueBlessAll.HandleId, false, ConfigRoverRogueBlessAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessAll.HandleId, 0, ConfigRoverRogueBlessAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueBlessAll.HandleId, ConfigRoverRogueBlessAll.LogPair);
					return null;
				}
				RoverRogueBless rootAsRoverRogueBless = RoverRogueBless.GetRootAsRoverRogueBless(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueBless);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueBlessAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessAll.HandleId, ConfigRoverRogueBlessAll.LogPair);
			return list;
		}

		// Token: 0x04003DF1 RID: 15857
		private const string DB = "db_roverlike.db";

		// Token: 0x04003DF2 RID: 15858
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003DF3 RID: 15859
		private const string TABLE = "RoverRogueBless";

		// Token: 0x04003DF4 RID: 15860
		private const string COMMAND = "select BinData from `RoverRogueBless`";

		// Token: 0x04003DF5 RID: 15861
		private const string KEY_PREFIX = "RoverRogueBlessAll";

		// Token: 0x04003DF6 RID: 15862
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DF7 RID: 15863
		private static int HandleId;
	}
}
