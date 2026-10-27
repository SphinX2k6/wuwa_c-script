using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000613 RID: 1555
	public class ConfigNodeUnlockDefaultById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002482 RID: 9346 RVA: 0x001280AF File Offset: 0x001262AF
		static ConfigNodeUnlockDefaultById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNodeUnlockDefaultById.CreateStaticDefaultValue), new Action(ConfigNodeUnlockDefaultById.ResetStaticDefaultValue));
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x001280D0 File Offset: 0x001262D0
		public static void CreateStaticDefaultValue()
		{
			ConfigNodeUnlockDefaultById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNodeUnlockDefaultById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtree.db"),
				new ValueTuple<string, object>("文件", "r.任务树.xlsx"),
				new ValueTuple<string, object>("表名", "NodeUnlockDefault"),
				new ValueTuple<string, object>("语句", "select BinData from `NodeUnlockDefault` where Id=?")
			});
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0012814F File Offset: 0x0012634F
		public static void ResetStaticDefaultValue()
		{
			ConfigNodeUnlockDefaultById.LogPair = null;
			ConfigNodeUnlockDefaultById.HandleId = 0;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0012815D File Offset: 0x0012635D
		public static void Init()
		{
			ConfigNodeUnlockDefaultById.HandleId = ConfigCommon.InitDataStatement(ConfigNodeUnlockDefaultById.HandleId, "db_questtree.db", "select BinData from `NodeUnlockDefault` where Id=?");
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00128178 File Offset: 0x00126378
		public static NodeUnlockDefault? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNodeUnlockDefaultById.HandleId, ConfigNodeUnlockDefaultById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("NodeUnlockDefaultById#" + p0Id);
				if (configBuffer != null)
				{
					return new NodeUnlockDefault?(NodeUnlockDefault.GetRootAsNodeUnlockDefault(configBuffer));
				}
			}
			ConfigNodeUnlockDefaultById.LogPair.Clear();
			ConfigNodeUnlockDefaultById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigNodeUnlockDefaultById.HandleId, 1, p0Id, ConfigNodeUnlockDefaultById.LogPair) || ConfigCommon.Step(ConfigNodeUnlockDefaultById.HandleId, true, ConfigNodeUnlockDefaultById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNodeUnlockDefaultById.HandleId, ConfigNodeUnlockDefaultById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNodeUnlockDefaultById.HandleId, 0, ConfigNodeUnlockDefaultById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNodeUnlockDefaultById.HandleId, ConfigNodeUnlockDefaultById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NodeUnlockDefault rootAsNodeUnlockDefault = NodeUnlockDefault.GetRootAsNodeUnlockDefault(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("NodeUnlockDefaultById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNodeUnlockDefaultById.HandleId, ConfigNodeUnlockDefaultById.LogPair);
			return new NodeUnlockDefault?(rootAsNodeUnlockDefault);
		}

		// Token: 0x04002A6B RID: 10859
		private const string DB = "db_questtree.db";

		// Token: 0x04002A6C RID: 10860
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x04002A6D RID: 10861
		private const string TABLE = "NodeUnlockDefault";

		// Token: 0x04002A6E RID: 10862
		private const string COMMAND = "select BinData from `NodeUnlockDefault` where Id=?";

		// Token: 0x04002A6F RID: 10863
		private const string KEY_PREFIX = "NodeUnlockDefaultById";

		// Token: 0x04002A70 RID: 10864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A71 RID: 10865
		private static int HandleId;
	}
}
