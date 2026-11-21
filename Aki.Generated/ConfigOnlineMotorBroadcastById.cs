using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063F RID: 1599
	public class ConfigOnlineMotorBroadcastById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600258A RID: 9610 RVA: 0x001316CF File Offset: 0x0012F8CF
		static ConfigOnlineMotorBroadcastById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorBroadcastById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorBroadcastById.ResetStaticDefaultValue));
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x001316F0 File Offset: 0x0012F8F0
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

		// Token: 0x0600258C RID: 9612 RVA: 0x0013176F File Offset: 0x0012F96F
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorBroadcastById.LogPair = null;
			ConfigOnlineMotorBroadcastById.HandleId = 0;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0013177D File Offset: 0x0012F97D
		public static void Init()
		{
			ConfigOnlineMotorBroadcastById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorBroadcastById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorBroadcast` where Id=?");
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00131798 File Offset: 0x0012F998
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

		// Token: 0x04002B9F RID: 11167
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BA0 RID: 11168
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BA1 RID: 11169
		private const string TABLE = "OnlineMotorBroadcast";

		// Token: 0x04002BA2 RID: 11170
		private const string COMMAND = "select BinData from `OnlineMotorBroadcast` where Id=?";

		// Token: 0x04002BA3 RID: 11171
		private const string KEY_PREFIX = "OnlineMotorBroadcastById";

		// Token: 0x04002BA4 RID: 11172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BA5 RID: 11173
		private static int HandleId;
	}
}
