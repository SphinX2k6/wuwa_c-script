using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000943 RID: 2371
	public class ConfigRoverRogueTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037A5 RID: 14245 RVA: 0x001970F0 File Offset: 0x001952F0
		static ConfigRoverRogueTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00197110 File Offset: 0x00195310
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueTalentTreeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueTalentTree`")
			});
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0019718F File Offset: 0x0019538F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeAll.LogPair = null;
			ConfigRoverRogueTalentTreeAll.HandleId = 0;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0019719D File Offset: 0x0019539D
		public static void Init()
		{
			ConfigRoverRogueTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueTalentTreeAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueTalentTree`");
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x001971B8 File Offset: 0x001953B8
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueTalentTree> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueTalentTree> readOnlyList = (IReadOnlyList<RoverRogueTalentTree>)ConfigCommon.GetConfig("RoverRogueTalentTreeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueTalentTree> list = new List<RoverRogueTalentTree>();
			while (ConfigCommon.Step(ConfigRoverRogueTalentTreeAll.HandleId, false, ConfigRoverRogueTalentTreeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueTalentTreeAll.HandleId, 0, ConfigRoverRogueTalentTreeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair);
					return null;
				}
				RoverRogueTalentTree rootAsRoverRogueTalentTree = RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueTalentTree);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueTalentTreeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueTalentTreeAll.HandleId, ConfigRoverRogueTalentTreeAll.LogPair);
			return list;
		}

		// Token: 0x040040BB RID: 16571
		private const string DB = "db_roverlike.db";

		// Token: 0x040040BC RID: 16572
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x040040BD RID: 16573
		private const string TABLE = "RoverRogueTalentTree";

		// Token: 0x040040BE RID: 16574
		private const string COMMAND = "select BinData from `RoverRogueTalentTree`";

		// Token: 0x040040BF RID: 16575
		private const string KEY_PREFIX = "RoverRogueTalentTreeAll";

		// Token: 0x040040C0 RID: 16576
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040C1 RID: 16577
		private static int HandleId;
	}
}
