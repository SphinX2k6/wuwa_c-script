using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000168 RID: 360
	public class ConfigChildEntityOwnerDataByGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x0008CDC8 File Offset: 0x0008AFC8
		static ConfigChildEntityOwnerDataByGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildEntityOwnerDataByGuid.CreateStaticDefaultValue), new Action(ConfigChildEntityOwnerDataByGuid.ResetStaticDefaultValue));
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0008CDE8 File Offset: 0x0008AFE8
		public static void CreateStaticDefaultValue()
		{
			ConfigChildEntityOwnerDataByGuid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChildEntityOwnerDataByGuid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_childentityownerdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/ChildEntityOwnerConfig/ChildEntityOwner.csv"),
				new ValueTuple<string, object>("表名", "ChildEntityOwnerData"),
				new ValueTuple<string, object>("语句", "select BinData from `ChildEntityOwnerData` where Guid=?")
			});
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0008CE67 File Offset: 0x0008B067
		public static void ResetStaticDefaultValue()
		{
			ConfigChildEntityOwnerDataByGuid.LogPair = null;
			ConfigChildEntityOwnerDataByGuid.HandleId = 0;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0008CE75 File Offset: 0x0008B075
		public static void Init()
		{
			ConfigChildEntityOwnerDataByGuid.HandleId = ConfigCommon.InitDataStatement(ConfigChildEntityOwnerDataByGuid.HandleId, "db_childentityownerdata.db", "select BinData from `ChildEntityOwnerData` where Guid=?");
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0008CE90 File Offset: 0x0008B090
		public static ChildEntityOwnerData? GetConfig(string p0Guid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChildEntityOwnerDataByGuid.HandleId, ConfigChildEntityOwnerDataByGuid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ChildEntityOwnerDataByGuid#" + p0Guid);
				if (configBuffer != null)
				{
					return new ChildEntityOwnerData?(ChildEntityOwnerData.GetRootAsChildEntityOwnerData(configBuffer));
				}
			}
			ConfigChildEntityOwnerDataByGuid.LogPair.Clear();
			ConfigChildEntityOwnerDataByGuid.LogPair.Add(new ValueTuple<string, object>("Guid", p0Guid));
			if (!ConfigCommon.BindString(ConfigChildEntityOwnerDataByGuid.HandleId, 1, p0Guid, ConfigChildEntityOwnerDataByGuid.LogPair) || ConfigCommon.Step(ConfigChildEntityOwnerDataByGuid.HandleId, true, ConfigChildEntityOwnerDataByGuid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChildEntityOwnerDataByGuid.HandleId, ConfigChildEntityOwnerDataByGuid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChildEntityOwnerDataByGuid.HandleId, 0, ConfigChildEntityOwnerDataByGuid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChildEntityOwnerDataByGuid.HandleId, ConfigChildEntityOwnerDataByGuid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChildEntityOwnerData rootAsChildEntityOwnerData = ChildEntityOwnerData.GetRootAsChildEntityOwnerData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ChildEntityOwnerDataByGuid#" + p0Guid, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChildEntityOwnerDataByGuid.HandleId, ConfigChildEntityOwnerDataByGuid.LogPair);
			return new ChildEntityOwnerData?(rootAsChildEntityOwnerData);
		}

		// Token: 0x040009BC RID: 2492
		private const string DB = "db_childentityownerdata.db";

		// Token: 0x040009BD RID: 2493
		private const string FILE = "UniverseEditor/ChildEntityOwnerConfig/ChildEntityOwner.csv";

		// Token: 0x040009BE RID: 2494
		private const string TABLE = "ChildEntityOwnerData";

		// Token: 0x040009BF RID: 2495
		private const string COMMAND = "select BinData from `ChildEntityOwnerData` where Guid=?";

		// Token: 0x040009C0 RID: 2496
		private const string KEY_PREFIX = "ChildEntityOwnerDataByGuid";

		// Token: 0x040009C1 RID: 2497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009C2 RID: 2498
		private static int HandleId;
	}
}
