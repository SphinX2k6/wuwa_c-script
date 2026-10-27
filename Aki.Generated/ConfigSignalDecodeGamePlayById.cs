using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000929 RID: 2345
	public class ConfigSignalDecodeGamePlayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003709 RID: 14089 RVA: 0x0019088C File Offset: 0x0018EA8C
		static ConfigSignalDecodeGamePlayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeGamePlayById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeGamePlayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x001908AC File Offset: 0x0018EAAC
		public static void CreateStaticDefaultValue()
		{
			ConfigSignalDecodeGamePlayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSignalDecodeGamePlayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_signaldecodegameplay.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/x.信号破译玩法配置/*.csv*"),
				new ValueTuple<string, object>("表名", "SignalDecodeGamePlay"),
				new ValueTuple<string, object>("语句", "select BinData from `SignalDecodeGamePlay` where Id=?")
			});
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x0019092B File Offset: 0x0018EB2B
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeGamePlayById.LogPair = null;
			ConfigSignalDecodeGamePlayById.HandleId = 0;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00190939 File Offset: 0x0018EB39
		public static void Init()
		{
			ConfigSignalDecodeGamePlayById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeGamePlayById.HandleId, "db_signaldecodegameplay.db", "select BinData from `SignalDecodeGamePlay` where Id=?");
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00190954 File Offset: 0x0018EB54
		public static SignalDecodeGamePlay? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSignalDecodeGamePlayById.HandleId, ConfigSignalDecodeGamePlayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("SignalDecodeGamePlayById#" + p0Id);
				if (configBuffer != null)
				{
					return new SignalDecodeGamePlay?(SignalDecodeGamePlay.GetRootAsSignalDecodeGamePlay(configBuffer));
				}
			}
			ConfigSignalDecodeGamePlayById.LogPair.Clear();
			ConfigSignalDecodeGamePlayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigSignalDecodeGamePlayById.HandleId, 1, p0Id, ConfigSignalDecodeGamePlayById.LogPair) || ConfigCommon.Step(ConfigSignalDecodeGamePlayById.HandleId, true, ConfigSignalDecodeGamePlayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSignalDecodeGamePlayById.HandleId, ConfigSignalDecodeGamePlayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSignalDecodeGamePlayById.HandleId, 0, ConfigSignalDecodeGamePlayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSignalDecodeGamePlayById.HandleId, ConfigSignalDecodeGamePlayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SignalDecodeGamePlay rootAsSignalDecodeGamePlay = SignalDecodeGamePlay.GetRootAsSignalDecodeGamePlay(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("SignalDecodeGamePlayById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSignalDecodeGamePlayById.HandleId, ConfigSignalDecodeGamePlayById.LogPair);
			return new SignalDecodeGamePlay?(rootAsSignalDecodeGamePlay);
		}

		// Token: 0x04004005 RID: 16389
		private const string DB = "db_signaldecodegameplay.db";

		// Token: 0x04004006 RID: 16390
		private const string FILE = "k.可视化编辑/c.Csv/x.信号破译玩法配置/*.csv*";

		// Token: 0x04004007 RID: 16391
		private const string TABLE = "SignalDecodeGamePlay";

		// Token: 0x04004008 RID: 16392
		private const string COMMAND = "select BinData from `SignalDecodeGamePlay` where Id=?";

		// Token: 0x04004009 RID: 16393
		private const string KEY_PREFIX = "SignalDecodeGamePlayById";

		// Token: 0x0400400A RID: 16394
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400400B RID: 16395
		private static int HandleId;
	}
}
