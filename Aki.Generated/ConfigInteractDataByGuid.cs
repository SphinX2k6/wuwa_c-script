using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000467 RID: 1127
	public class ConfigInteractDataByGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x000F28D5 File Offset: 0x000F0AD5
		static ConfigInteractDataByGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractDataByGuid.CreateStaticDefaultValue), new Action(ConfigInteractDataByGuid.ResetStaticDefaultValue));
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000F28F4 File Offset: 0x000F0AF4
		public static void CreateStaticDefaultValue()
		{
			ConfigInteractDataByGuid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInteractDataByGuid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_interactdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/InteractOption/InteractOption.csv"),
				new ValueTuple<string, object>("表名", "InteractData"),
				new ValueTuple<string, object>("语句", "select BinData from `InteractData` where Guid=?")
			});
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000F2973 File Offset: 0x000F0B73
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractDataByGuid.LogPair = null;
			ConfigInteractDataByGuid.HandleId = 0;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000F2981 File Offset: 0x000F0B81
		public static void Init()
		{
			ConfigInteractDataByGuid.HandleId = ConfigCommon.InitDataStatement(ConfigInteractDataByGuid.HandleId, "db_interactdata.db", "select BinData from `InteractData` where Guid=?");
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000F299C File Offset: 0x000F0B9C
		public static InteractData? GetConfig(string p0Guid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInteractDataByGuid.HandleId, ConfigInteractDataByGuid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("InteractDataByGuid#" + p0Guid);
				if (configBuffer != null)
				{
					return new InteractData?(InteractData.GetRootAsInteractData(configBuffer));
				}
			}
			ConfigInteractDataByGuid.LogPair.Clear();
			ConfigInteractDataByGuid.LogPair.Add(new ValueTuple<string, object>("Guid", p0Guid));
			if (!ConfigCommon.BindString(ConfigInteractDataByGuid.HandleId, 1, p0Guid, ConfigInteractDataByGuid.LogPair) || ConfigCommon.Step(ConfigInteractDataByGuid.HandleId, true, ConfigInteractDataByGuid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInteractDataByGuid.HandleId, ConfigInteractDataByGuid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInteractDataByGuid.HandleId, 0, ConfigInteractDataByGuid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInteractDataByGuid.HandleId, ConfigInteractDataByGuid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InteractData rootAsInteractData = InteractData.GetRootAsInteractData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("InteractDataByGuid#" + p0Guid, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInteractDataByGuid.HandleId, ConfigInteractDataByGuid.LogPair);
			return new InteractData?(rootAsInteractData);
		}

		// Token: 0x04001EB5 RID: 7861
		private const string DB = "db_interactdata.db";

		// Token: 0x04001EB6 RID: 7862
		private const string FILE = "UniverseEditor/InteractOption/InteractOption.csv";

		// Token: 0x04001EB7 RID: 7863
		private const string TABLE = "InteractData";

		// Token: 0x04001EB8 RID: 7864
		private const string COMMAND = "select BinData from `InteractData` where Guid=?";

		// Token: 0x04001EB9 RID: 7865
		private const string KEY_PREFIX = "InteractDataByGuid";

		// Token: 0x04001EBA RID: 7866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EBB RID: 7867
		private static int HandleId;
	}
}
