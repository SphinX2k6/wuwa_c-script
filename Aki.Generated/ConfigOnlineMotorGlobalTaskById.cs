using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000628 RID: 1576
	public class ConfigOnlineMotorGlobalTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002500 RID: 9472 RVA: 0x0012AE9C File Offset: 0x0012909C
		static ConfigOnlineMotorGlobalTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorGlobalTaskById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorGlobalTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x0012AEBC File Offset: 0x001290BC
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorGlobalTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorGlobalTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorGlobalTask"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorGlobalTask` where Id=?")
			});
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0012AF3B File Offset: 0x0012913B
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorGlobalTaskById.LogPair = null;
			ConfigOnlineMotorGlobalTaskById.HandleId = 0;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0012AF49 File Offset: 0x00129149
		public static void Init()
		{
			ConfigOnlineMotorGlobalTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorGlobalTaskById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorGlobalTask` where Id=?");
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0012AF64 File Offset: 0x00129164
		public static OnlineMotorGlobalTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorGlobalTaskById.HandleId, ConfigOnlineMotorGlobalTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorGlobalTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorGlobalTask?(OnlineMotorGlobalTask.GetRootAsOnlineMotorGlobalTask(configBuffer));
				}
			}
			ConfigOnlineMotorGlobalTaskById.LogPair.Clear();
			ConfigOnlineMotorGlobalTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorGlobalTaskById.HandleId, 1, p0Id, ConfigOnlineMotorGlobalTaskById.LogPair) || ConfigCommon.Step(ConfigOnlineMotorGlobalTaskById.HandleId, true, ConfigOnlineMotorGlobalTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorGlobalTaskById.HandleId, ConfigOnlineMotorGlobalTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorGlobalTaskById.HandleId, 0, ConfigOnlineMotorGlobalTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorGlobalTaskById.HandleId, ConfigOnlineMotorGlobalTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorGlobalTask rootAsOnlineMotorGlobalTask = OnlineMotorGlobalTask.GetRootAsOnlineMotorGlobalTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorGlobalTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorGlobalTaskById.HandleId, ConfigOnlineMotorGlobalTaskById.LogPair);
			return new OnlineMotorGlobalTask?(rootAsOnlineMotorGlobalTask);
		}

		// Token: 0x04002AFE RID: 11006
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002AFF RID: 11007
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B00 RID: 11008
		private const string TABLE = "OnlineMotorGlobalTask";

		// Token: 0x04002B01 RID: 11009
		private const string COMMAND = "select BinData from `OnlineMotorGlobalTask` where Id=?";

		// Token: 0x04002B02 RID: 11010
		private const string KEY_PREFIX = "OnlineMotorGlobalTaskById";

		// Token: 0x04002B03 RID: 11011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B04 RID: 11012
		private static int HandleId;
	}
}
