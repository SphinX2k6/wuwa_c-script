using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000974 RID: 2420
	public class ConfigSignalDecodeGamePlayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038CB RID: 14539 RVA: 0x0019DAAC File Offset: 0x0019BCAC
		static ConfigSignalDecodeGamePlayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeGamePlayById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeGamePlayById.ResetStaticDefaultValue));
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x0019DACC File Offset: 0x0019BCCC
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

		// Token: 0x060038CD RID: 14541 RVA: 0x0019DB4B File Offset: 0x0019BD4B
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeGamePlayById.LogPair = null;
			ConfigSignalDecodeGamePlayById.HandleId = 0;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0019DB59 File Offset: 0x0019BD59
		public static void Init()
		{
			ConfigSignalDecodeGamePlayById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeGamePlayById.HandleId, "db_signaldecodegameplay.db", "select BinData from `SignalDecodeGamePlay` where Id=?");
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0019DB74 File Offset: 0x0019BD74
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

		// Token: 0x04004212 RID: 16914
		private const string DB = "db_signaldecodegameplay.db";

		// Token: 0x04004213 RID: 16915
		private const string FILE = "k.可视化编辑/c.Csv/x.信号破译玩法配置/*.csv*";

		// Token: 0x04004214 RID: 16916
		private const string TABLE = "SignalDecodeGamePlay";

		// Token: 0x04004215 RID: 16917
		private const string COMMAND = "select BinData from `SignalDecodeGamePlay` where Id=?";

		// Token: 0x04004216 RID: 16918
		private const string KEY_PREFIX = "SignalDecodeGamePlayById";

		// Token: 0x04004217 RID: 16919
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004218 RID: 16920
		private static int HandleId;
	}
}
