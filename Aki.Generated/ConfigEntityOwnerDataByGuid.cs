using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028D RID: 653
	public class ConfigEntityOwnerDataByGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x000B39ED File Offset: 0x000B1BED
		static ConfigEntityOwnerDataByGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityOwnerDataByGuid.CreateStaticDefaultValue), new Action(ConfigEntityOwnerDataByGuid.ResetStaticDefaultValue));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000B3A0C File Offset: 0x000B1C0C
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

		// Token: 0x06000F55 RID: 3925 RVA: 0x000B3A8B File Offset: 0x000B1C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityOwnerDataByGuid.LogPair = null;
			ConfigEntityOwnerDataByGuid.HandleId = 0;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000B3A99 File Offset: 0x000B1C99
		public static void Init()
		{
			ConfigEntityOwnerDataByGuid.HandleId = ConfigCommon.InitDataStatement(ConfigEntityOwnerDataByGuid.HandleId, "db_entityownerdata.db", "select BinData from `EntityOwnerData` where Guid=?");
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
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

		// Token: 0x040011BF RID: 4543
		private const string DB = "db_entityownerdata.db";

		// Token: 0x040011C0 RID: 4544
		private const string FILE = "UniverseEditor/EntityOwnerConfig/EntityOwner.csv";

		// Token: 0x040011C1 RID: 4545
		private const string TABLE = "EntityOwnerData";

		// Token: 0x040011C2 RID: 4546
		private const string COMMAND = "select BinData from `EntityOwnerData` where Guid=?";

		// Token: 0x040011C3 RID: 4547
		private const string KEY_PREFIX = "EntityOwnerDataByGuid";

		// Token: 0x040011C4 RID: 4548
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011C5 RID: 4549
		private static int HandleId;
	}
}
