using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027A RID: 634
	public class ConfigEntityOwnerDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EE1 RID: 3809 RVA: 0x000AD921 File Offset: 0x000ABB21
		static ConfigEntityOwnerDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityOwnerDataById.CreateStaticDefaultValue), new Action(ConfigEntityOwnerDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000AD940 File Offset: 0x000ABB40
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

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000AD9BF File Offset: 0x000ABBBF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityOwnerDataById.LogPair = null;
			ConfigEntityOwnerDataById.HandleId = 0;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000AD9CD File Offset: 0x000ABBCD
		public static void Init()
		{
			ConfigEntityOwnerDataById.HandleId = ConfigCommon.InitDataStatement(ConfigEntityOwnerDataById.HandleId, "db_entityownerdata.db", "select BinData from `EntityOwnerData` where Guid=?");
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000AD9E8 File Offset: 0x000ABBE8
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

		// Token: 0x0400113A RID: 4410
		private const string DB = "db_entityownerdata.db";

		// Token: 0x0400113B RID: 4411
		private const string FILE = "UniverseEditor/EntityOwnerConfig/EntityOwner.csv";

		// Token: 0x0400113C RID: 4412
		private const string TABLE = "EntityOwnerData";

		// Token: 0x0400113D RID: 4413
		private const string COMMAND = "select BinData from `EntityOwnerData` where Guid=?";

		// Token: 0x0400113E RID: 4414
		private const string KEY_PREFIX = "EntityOwnerDataById";

		// Token: 0x0400113F RID: 4415
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001140 RID: 4416
		private static int HandleId;
	}
}
