using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028E RID: 654
	public class ConfigEntityOwnerDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x000B3BE5 File Offset: 0x000B1DE5
		static ConfigEntityOwnerDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityOwnerDataById.CreateStaticDefaultValue), new Action(ConfigEntityOwnerDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000B3C04 File Offset: 0x000B1E04
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityOwnerDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityOwnerDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entityownerdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/EntityOwnerConfig/EntityOwner.csv"),
				new ValueTuple<string, object>("表名", "EntityOwnerData"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityOwnerData` where Guid=?")
			});
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000B3C83 File Offset: 0x000B1E83
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityOwnerDataById.LogPair = null;
			ConfigEntityOwnerDataById.HandleId = 0;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000B3C91 File Offset: 0x000B1E91
		public static void Init()
		{
			ConfigEntityOwnerDataById.HandleId = ConfigCommon.InitDataStatement(ConfigEntityOwnerDataById.HandleId, "db_entityownerdata.db", "select BinData from `EntityOwnerData` where Guid=?");
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000B3CAC File Offset: 0x000B1EAC
		[return: Nullable(2)]
		public static IReadOnlyList<EntityOwnerData> GetConfigList(string p0Guid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityOwnerDataById.HandleId, ConfigEntityOwnerDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EntityOwnerData> readOnlyList = (IReadOnlyList<EntityOwnerData>)ConfigCommon.GetConfig("EntityOwnerDataById#" + p0Guid);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEntityOwnerDataById.LogPair.Clear();
			ConfigEntityOwnerDataById.LogPair.Add(new ValueTuple<string, object>("Guid", p0Guid));
			if (!ConfigCommon.BindString(ConfigEntityOwnerDataById.HandleId, 1, p0Guid, ConfigEntityOwnerDataById.LogPair))
			{
				ConfigCommon.Reset(ConfigEntityOwnerDataById.HandleId, ConfigEntityOwnerDataById.LogPair);
				return null;
			}
			List<EntityOwnerData> list = new List<EntityOwnerData>();
			while (ConfigCommon.Step(ConfigEntityOwnerDataById.HandleId, false, ConfigEntityOwnerDataById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityOwnerDataById.HandleId, 0, ConfigEntityOwnerDataById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEntityOwnerDataById.HandleId, ConfigEntityOwnerDataById.LogPair);
					return null;
				}
				EntityOwnerData rootAsEntityOwnerData = EntityOwnerData.GetRootAsEntityOwnerData(new ByteBuffer(item2));
				list.Add(rootAsEntityOwnerData);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EntityOwnerDataById#" + p0Guid, list, list.Count);
			}
			ConfigCommon.Reset(ConfigEntityOwnerDataById.HandleId, ConfigEntityOwnerDataById.LogPair);
			return list;
		}

		// Token: 0x040011C6 RID: 4550
		private const string DB = "db_entityownerdata.db";

		// Token: 0x040011C7 RID: 4551
		private const string FILE = "UniverseEditor/EntityOwnerConfig/EntityOwner.csv";

		// Token: 0x040011C8 RID: 4552
		private const string TABLE = "EntityOwnerData";

		// Token: 0x040011C9 RID: 4553
		private const string COMMAND = "select BinData from `EntityOwnerData` where Guid=?";

		// Token: 0x040011CA RID: 4554
		private const string KEY_PREFIX = "EntityOwnerDataById";

		// Token: 0x040011CB RID: 4555
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011CC RID: 4556
		private static int HandleId;
	}
}
