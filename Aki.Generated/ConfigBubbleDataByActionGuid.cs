using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000130 RID: 304
	public class ConfigBubbleDataByActionGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00085904 File Offset: 0x00083B04
		static ConfigBubbleDataByActionGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBubbleDataByActionGuid.CreateStaticDefaultValue), new Action(ConfigBubbleDataByActionGuid.ResetStaticDefaultValue));
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00085924 File Offset: 0x00083B24
		public static void CreateStaticDefaultValue()
		{
			ConfigBubbleDataByActionGuid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBubbleDataByActionGuid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bubbledata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/BubbleConfig/BubbleConfig.csv"),
				new ValueTuple<string, object>("表名", "BubbleData"),
				new ValueTuple<string, object>("语句", "select BinData from `BubbleData` where ActionGuid=?")
			});
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000859A3 File Offset: 0x00083BA3
		public static void ResetStaticDefaultValue()
		{
			ConfigBubbleDataByActionGuid.LogPair = null;
			ConfigBubbleDataByActionGuid.HandleId = 0;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000859B1 File Offset: 0x00083BB1
		public static void Init()
		{
			ConfigBubbleDataByActionGuid.HandleId = ConfigCommon.InitDataStatement(ConfigBubbleDataByActionGuid.HandleId, "db_bubbledata.db", "select BinData from `BubbleData` where ActionGuid=?");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000859CC File Offset: 0x00083BCC
		public static BubbleData? GetConfig(string p0ActionGuid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBubbleDataByActionGuid.HandleId, ConfigBubbleDataByActionGuid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("BubbleDataByActionGuid#" + p0ActionGuid);
				if (configBuffer != null)
				{
					return new BubbleData?(BubbleData.GetRootAsBubbleData(configBuffer));
				}
			}
			ConfigBubbleDataByActionGuid.LogPair.Clear();
			ConfigBubbleDataByActionGuid.LogPair.Add(new ValueTuple<string, object>("ActionGuid", p0ActionGuid));
			if (!ConfigCommon.BindString(ConfigBubbleDataByActionGuid.HandleId, 1, p0ActionGuid, ConfigBubbleDataByActionGuid.LogPair) || ConfigCommon.Step(ConfigBubbleDataByActionGuid.HandleId, true, ConfigBubbleDataByActionGuid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBubbleDataByActionGuid.HandleId, ConfigBubbleDataByActionGuid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBubbleDataByActionGuid.HandleId, 0, ConfigBubbleDataByActionGuid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBubbleDataByActionGuid.HandleId, ConfigBubbleDataByActionGuid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BubbleData rootAsBubbleData = BubbleData.GetRootAsBubbleData(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("BubbleDataByActionGuid#" + p0ActionGuid, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBubbleDataByActionGuid.HandleId, ConfigBubbleDataByActionGuid.LogPair);
			return new BubbleData?(rootAsBubbleData);
		}

		// Token: 0x04000834 RID: 2100
		private const string DB = "db_bubbledata.db";

		// Token: 0x04000835 RID: 2101
		private const string FILE = "UniverseEditor/BubbleConfig/BubbleConfig.csv";

		// Token: 0x04000836 RID: 2102
		private const string TABLE = "BubbleData";

		// Token: 0x04000837 RID: 2103
		private const string COMMAND = "select BinData from `BubbleData` where ActionGuid=?";

		// Token: 0x04000838 RID: 2104
		private const string KEY_PREFIX = "BubbleDataByActionGuid";

		// Token: 0x04000839 RID: 2105
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400083A RID: 2106
		private static int HandleId;
	}
}
