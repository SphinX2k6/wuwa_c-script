using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062C RID: 1580
	public class ConfigOnlineMotorLevelTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002518 RID: 9496 RVA: 0x0012B708 File Offset: 0x00129908
		static ConfigOnlineMotorLevelTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelTaskById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0012B728 File Offset: 0x00129928
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevelTask"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevelTask` where Id=?")
			});
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x0012B7A7 File Offset: 0x001299A7
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelTaskById.LogPair = null;
			ConfigOnlineMotorLevelTaskById.HandleId = 0;
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x0012B7B5 File Offset: 0x001299B5
		public static void Init()
		{
			ConfigOnlineMotorLevelTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelTaskById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevelTask` where Id=?");
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0012B7D0 File Offset: 0x001299D0
		public static OnlineMotorLevelTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelTaskById.HandleId, ConfigOnlineMotorLevelTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorLevelTask?(OnlineMotorLevelTask.GetRootAsOnlineMotorLevelTask(configBuffer));
				}
			}
			ConfigOnlineMotorLevelTaskById.LogPair.Clear();
			ConfigOnlineMotorLevelTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorLevelTaskById.HandleId, 1, p0Id, ConfigOnlineMotorLevelTaskById.LogPair) || ConfigCommon.Step(ConfigOnlineMotorLevelTaskById.HandleId, true, ConfigOnlineMotorLevelTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelTaskById.HandleId, ConfigOnlineMotorLevelTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelTaskById.HandleId, 0, ConfigOnlineMotorLevelTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelTaskById.HandleId, ConfigOnlineMotorLevelTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorLevelTask rootAsOnlineMotorLevelTask = OnlineMotorLevelTask.GetRootAsOnlineMotorLevelTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelTaskById.HandleId, ConfigOnlineMotorLevelTaskById.LogPair);
			return new OnlineMotorLevelTask?(rootAsOnlineMotorLevelTask);
		}

		// Token: 0x04002B1A RID: 11034
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002B1B RID: 11035
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B1C RID: 11036
		private const string TABLE = "OnlineMotorLevelTask";

		// Token: 0x04002B1D RID: 11037
		private const string COMMAND = "select BinData from `OnlineMotorLevelTask` where Id=?";

		// Token: 0x04002B1E RID: 11038
		private const string KEY_PREFIX = "OnlineMotorLevelTaskById";

		// Token: 0x04002B1F RID: 11039
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B20 RID: 11040
		private static int HandleId;
	}
}
