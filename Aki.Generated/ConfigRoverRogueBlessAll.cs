using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000928 RID: 2344
	public class ConfigRoverRogueBlessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003703 RID: 14083 RVA: 0x00193874 File Offset: 0x00191A74
		static ConfigRoverRogueBlessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00193894 File Offset: 0x00191A94
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

		// Token: 0x06003705 RID: 14085 RVA: 0x00193913 File Offset: 0x00191B13
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessAll.LogPair = null;
			ConfigRoverRogueBlessAll.HandleId = 0;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00193921 File Offset: 0x00191B21
		public static void Init()
		{
			ConfigRoverRogueBlessAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBless`");
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0019393C File Offset: 0x00191B3C
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

		// Token: 0x04003FFE RID: 16382
		private const string DB = "db_roverlike.db";

		// Token: 0x04003FFF RID: 16383
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04004000 RID: 16384
		private const string TABLE = "RoverRogueBless";

		// Token: 0x04004001 RID: 16385
		private const string COMMAND = "select BinData from `RoverRogueBless`";

		// Token: 0x04004002 RID: 16386
		private const string KEY_PREFIX = "RoverRogueBlessAll";

		// Token: 0x04004003 RID: 16387
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004004 RID: 16388
		private static int HandleId;
	}
}
