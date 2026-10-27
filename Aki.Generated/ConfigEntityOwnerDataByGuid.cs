using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000279 RID: 633
	public class ConfigEntityOwnerDataByGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x000AD729 File Offset: 0x000AB929
		static ConfigEntityOwnerDataByGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityOwnerDataByGuid.CreateStaticDefaultValue), new Action(ConfigEntityOwnerDataByGuid.ResetStaticDefaultValue));
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000AD748 File Offset: 0x000AB948
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityOwnerDataByGuid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityOwnerDataByGuid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entityownerdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/EntityOwnerConfig/EntityOwner.csv"),
				new ValueTuple<string, object>("表名", "EntityOwnerData"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityOwnerData` where Guid=?")
			});
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000AD7C7 File Offset: 0x000AB9C7
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityOwnerDataByGuid.LogPair = null;
			ConfigEntityOwnerDataByGuid.HandleId = 0;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000AD7D5 File Offset: 0x000AB9D5
		public static void Init()
		{
			ConfigEntityOwnerDataByGuid.HandleId = ConfigCommon.InitDataStatement(ConfigEntityOwnerDataByGuid.HandleId, "db_entityownerdata.db", "select BinData from `EntityOwnerData` where Guid=?");
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000AD7F0 File Offset: 0x000AB9F0
		public static EntityOwnerData? GetConfig(string p0Guid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityOwnerDataByGuid.HandleId, ConfigEntityOwnerDataByGuid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EntityOwnerDataByGuid#" + p0Guid);
				if (configBuffer != null)
				{
					return new EntityOwnerData?(EntityOwnerData.GetRootAsEntityOwnerData(configBuffer));
				}
			}
			ConfigEntityOwnerDataByGuid.LogPair.Clear();
			ConfigEntityOwnerDataByGuid.LogPair.Add(new ValueTuple<string, object>("Guid", p0Guid));
			if (!ConfigCommon.BindString(ConfigEntityOwnerDataByGuid.HandleId, 1, p0Guid, ConfigEntityOwnerDataByGuid.LogPair) || ConfigCommon.Step(ConfigEntityOwnerDataByGuid.HandleId, false, ConfigEntityOwnerDataByGuid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntityOwnerDataByGuid.HandleId, ConfigEntityOwnerDataByGuid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityOwnerDataByGuid.HandleId, 0, ConfigEntityOwnerDataByGuid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntityOwnerDataByGuid.HandleId, ConfigEntityOwnerDataByGuid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntityOwnerData rootAsEntityOwnerData = EntityOwnerData.GetRootAsEntityOwnerData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EntityOwnerDataByGuid#" + p0Guid, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntityOwnerDataByGuid.HandleId, ConfigEntityOwnerDataByGuid.LogPair);
			return new EntityOwnerData?(rootAsEntityOwnerData);
		}

		// Token: 0x04001133 RID: 4403
		private const string DB = "db_entityownerdata.db";

		// Token: 0x04001134 RID: 4404
		private const string FILE = "UniverseEditor/EntityOwnerConfig/EntityOwner.csv";

		// Token: 0x04001135 RID: 4405
		private const string TABLE = "EntityOwnerData";

		// Token: 0x04001136 RID: 4406
		private const string COMMAND = "select BinData from `EntityOwnerData` where Guid=?";

		// Token: 0x04001137 RID: 4407
		private const string KEY_PREFIX = "EntityOwnerDataByGuid";

		// Token: 0x04001138 RID: 4408
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001139 RID: 4409
		private static int HandleId;
	}
}
