using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000627 RID: 1575
	public class ConfigOnlineMotorBroadcastById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x0012AC53 File Offset: 0x00128E53
		static ConfigOnlineMotorBroadcastById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorBroadcastById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorBroadcastById.ResetStaticDefaultValue));
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0012AC74 File Offset: 0x00128E74
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorBroadcastById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorBroadcast"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorBroadcast` where Id=?")
			});
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0012ACF3 File Offset: 0x00128EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastById.LogPair = null;
			ConfigOnlineMotorBroadcastById.HandleId = 0;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0012AD01 File Offset: 0x00128F01
		public static void Init()
		{
			ConfigOnlineMotorBroadcastById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorBroadcastById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorBroadcast` where Id=?");
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0012AD1C File Offset: 0x00128F1C
		public static OnlineMotorBroadcast? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorBroadcastById.HandleId, ConfigOnlineMotorBroadcastById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorBroadcastById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorBroadcast?(OnlineMotorBroadcast.GetRootAsOnlineMotorBroadcast(configBuffer));
				}
			}
			ConfigOnlineMotorBroadcastById.LogPair.Clear();
			ConfigOnlineMotorBroadcastById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorBroadcastById.HandleId, 1, p0Id, ConfigOnlineMotorBroadcastById.LogPair) || ConfigCommon.Step(ConfigOnlineMotorBroadcastById.HandleId, true, ConfigOnlineMotorBroadcastById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorBroadcastById.HandleId, ConfigOnlineMotorBroadcastById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorBroadcastById.HandleId, 0, ConfigOnlineMotorBroadcastById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorBroadcastById.HandleId, ConfigOnlineMotorBroadcastById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorBroadcast rootAsOnlineMotorBroadcast = OnlineMotorBroadcast.GetRootAsOnlineMotorBroadcast(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorBroadcastById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorBroadcastById.HandleId, ConfigOnlineMotorBroadcastById.LogPair);
			return new OnlineMotorBroadcast?(rootAsOnlineMotorBroadcast);
		}

		// Token: 0x04002AF7 RID: 10999
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002AF8 RID: 11000
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002AF9 RID: 11001
		private const string TABLE = "OnlineMotorBroadcast";

		// Token: 0x04002AFA RID: 11002
		private const string COMMAND = "select BinData from `OnlineMotorBroadcast` where Id=?";

		// Token: 0x04002AFB RID: 11003
		private const string KEY_PREFIX = "OnlineMotorBroadcastById";

		// Token: 0x04002AFC RID: 11004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AFD RID: 11005
		private static int HandleId;
	}
}
