using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000643 RID: 1603
	public class ConfigOnlineMotorLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x00131F3C File Offset: 0x0013013C
		static ConfigOnlineMotorLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelByInstId.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00131F5C File Offset: 0x0013015C
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevel` where InstId=?")
			});
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00131FDB File Offset: 0x001301DB
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelByInstId.LogPair = null;
			ConfigOnlineMotorLevelByInstId.HandleId = 0;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00131FE9 File Offset: 0x001301E9
		public static void Init()
		{
			ConfigOnlineMotorLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelByInstId.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel` where InstId=?");
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00132004 File Offset: 0x00130204
		public static OnlineMotorLevel? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelByInstId.HandleId, ConfigOnlineMotorLevelByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorLevel?(OnlineMotorLevel.GetRootAsOnlineMotorLevel(configBuffer));
				}
			}
			ConfigOnlineMotorLevelByInstId.LogPair.Clear();
			ConfigOnlineMotorLevelByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorLevelByInstId.HandleId, 1, p0InstId, ConfigOnlineMotorLevelByInstId.LogPair) || ConfigCommon.Step(ConfigOnlineMotorLevelByInstId.HandleId, true, ConfigOnlineMotorLevelByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelByInstId.HandleId, ConfigOnlineMotorLevelByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelByInstId.HandleId, 0, ConfigOnlineMotorLevelByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelByInstId.HandleId, ConfigOnlineMotorLevelByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorLevel rootAsOnlineMotorLevel = OnlineMotorLevel.GetRootAsOnlineMotorLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelByInstId.HandleId, ConfigOnlineMotorLevelByInstId.LogPair);
			return new OnlineMotorLevel?(rootAsOnlineMotorLevel);
		}

		// Token: 0x04002BBB RID: 11195
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BBC RID: 11196
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BBD RID: 11197
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002BBE RID: 11198
		private const string COMMAND = "select BinData from `OnlineMotorLevel` where InstId=?";

		// Token: 0x04002BBF RID: 11199
		private const string KEY_PREFIX = "OnlineMotorLevelByInstId";

		// Token: 0x04002BC0 RID: 11200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BC1 RID: 11201
		private static int HandleId;
	}
}
