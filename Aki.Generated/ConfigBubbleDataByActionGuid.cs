using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000121 RID: 289
	public class ConfigBubbleDataByActionGuid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x0007FFA0 File Offset: 0x0007E1A0
		static ConfigBubbleDataByActionGuid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBubbleDataByActionGuid.CreateStaticDefaultValue), new Action(ConfigBubbleDataByActionGuid.ResetStaticDefaultValue));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x0008003F File Offset: 0x0007E23F
		public static void ResetStaticDefaultValue()
		{
			ConfigBubbleDataByActionGuid.LogPair = null;
			ConfigBubbleDataByActionGuid.HandleId = 0;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0008004D File Offset: 0x0007E24D
		public static void Init()
		{
			ConfigBubbleDataByActionGuid.HandleId = ConfigCommon.InitDataStatement(ConfigBubbleDataByActionGuid.HandleId, "db_bubbledata.db", "select BinData from `BubbleData` where ActionGuid=?");
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00080068 File Offset: 0x0007E268
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

		// Token: 0x040007CB RID: 1995
		private const string DB = "db_bubbledata.db";

		// Token: 0x040007CC RID: 1996
		private const string FILE = "UniverseEditor/BubbleConfig/BubbleConfig.csv";

		// Token: 0x040007CD RID: 1997
		private const string TABLE = "BubbleData";

		// Token: 0x040007CE RID: 1998
		private const string COMMAND = "select BinData from `BubbleData` where ActionGuid=?";

		// Token: 0x040007CF RID: 1999
		private const string KEY_PREFIX = "BubbleDataByActionGuid";

		// Token: 0x040007D0 RID: 2000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007D1 RID: 2001
		private static int HandleId;
	}
}
