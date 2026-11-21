using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062B RID: 1579
	public class ConfigNodeUnlockDefaultById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002512 RID: 9490 RVA: 0x0012EB2B File Offset: 0x0012CD2B
		static ConfigNodeUnlockDefaultById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNodeUnlockDefaultById.CreateStaticDefaultValue), new Action(ConfigNodeUnlockDefaultById.ResetStaticDefaultValue));
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0012EB4C File Offset: 0x0012CD4C
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

		// Token: 0x06002514 RID: 9492 RVA: 0x0012EBCB File Offset: 0x0012CDCB
		public static void ResetStaticDefaultValue()
		{
			ConfigNodeUnlockDefaultById.LogPair = null;
			ConfigNodeUnlockDefaultById.HandleId = 0;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0012EBD9 File Offset: 0x0012CDD9
		public static void Init()
		{
			ConfigNodeUnlockDefaultById.HandleId = ConfigCommon.InitDataStatement(ConfigNodeUnlockDefaultById.HandleId, "db_questtree.db", "select BinData from `NodeUnlockDefault` where Id=?");
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0012EBF4 File Offset: 0x0012CDF4
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

		// Token: 0x04002B13 RID: 11027
		private const string DB = "db_questtree.db";

		// Token: 0x04002B14 RID: 11028
		private const string FILE = "r.任务树.xlsx";

		// Token: 0x04002B15 RID: 11029
		private const string TABLE = "NodeUnlockDefault";

		// Token: 0x04002B16 RID: 11030
		private const string COMMAND = "select BinData from `NodeUnlockDefault` where Id=?";

		// Token: 0x04002B17 RID: 11031
		private const string KEY_PREFIX = "NodeUnlockDefaultById";

		// Token: 0x04002B18 RID: 11032
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B19 RID: 11033
		private static int HandleId;
	}
}
