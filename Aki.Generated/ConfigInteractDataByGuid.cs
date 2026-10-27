using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000451 RID: 1105
	public class ConfigInteractDataByGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019F0 RID: 6640 RVA: 0x000EC181 File Offset: 0x000EA381
		static ConfigInteractDataByGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractDataByGuid.CreateStaticDefaultValue), new Action(ConfigInteractDataByGuid.ResetStaticDefaultValue));
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000EC1A0 File Offset: 0x000EA3A0
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

		// Token: 0x060019F2 RID: 6642 RVA: 0x000EC21F File Offset: 0x000EA41F
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractDataByGuid.LogPair = null;
			ConfigInteractDataByGuid.HandleId = 0;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000EC22D File Offset: 0x000EA42D
		public static void Init()
		{
			ConfigInteractDataByGuid.HandleId = ConfigCommon.InitDataStatement(ConfigInteractDataByGuid.HandleId, "db_interactdata.db", "select BinData from `InteractData` where Guid=?");
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000EC248 File Offset: 0x000EA448
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

		// Token: 0x04001E1B RID: 7707
		private const string DB = "db_interactdata.db";

		// Token: 0x04001E1C RID: 7708
		private const string FILE = "UniverseEditor/InteractOption/InteractOption.csv";

		// Token: 0x04001E1D RID: 7709
		private const string TABLE = "InteractData";

		// Token: 0x04001E1E RID: 7710
		private const string COMMAND = "select BinData from `InteractData` where Guid=?";

		// Token: 0x04001E1F RID: 7711
		private const string KEY_PREFIX = "InteractDataByGuid";

		// Token: 0x04001E20 RID: 7712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E21 RID: 7713
		private static int HandleId;
	}
}
