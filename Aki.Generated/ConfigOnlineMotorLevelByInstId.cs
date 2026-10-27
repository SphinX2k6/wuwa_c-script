using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062B RID: 1579
	public class ConfigOnlineMotorLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002512 RID: 9490 RVA: 0x0012B4C0 File Offset: 0x001296C0
		static ConfigOnlineMotorLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelByInstId.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0012B4E0 File Offset: 0x001296E0
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

		// Token: 0x06002514 RID: 9492 RVA: 0x0012B55F File Offset: 0x0012975F
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelByInstId.LogPair = null;
			ConfigOnlineMotorLevelByInstId.HandleId = 0;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0012B56D File Offset: 0x0012976D
		public static void Init()
		{
			ConfigOnlineMotorLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelByInstId.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel` where InstId=?");
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0012B588 File Offset: 0x00129788
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

		// Token: 0x04002B13 RID: 11027
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002B14 RID: 11028
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B15 RID: 11029
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002B16 RID: 11030
		private const string COMMAND = "select BinData from `OnlineMotorLevel` where InstId=?";

		// Token: 0x04002B17 RID: 11031
		private const string KEY_PREFIX = "OnlineMotorLevelByInstId";

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
