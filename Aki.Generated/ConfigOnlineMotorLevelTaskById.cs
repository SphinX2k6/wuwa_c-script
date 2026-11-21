using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000644 RID: 1604
	public class ConfigOnlineMotorLevelTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025A8 RID: 9640 RVA: 0x00132184 File Offset: 0x00130384
		static ConfigOnlineMotorLevelTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelTaskById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x001321A4 File Offset: 0x001303A4
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

		// Token: 0x060025AA RID: 9642 RVA: 0x00132223 File Offset: 0x00130423
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelTaskById.LogPair = null;
			ConfigOnlineMotorLevelTaskById.HandleId = 0;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00132231 File Offset: 0x00130431
		public static void Init()
		{
			ConfigOnlineMotorLevelTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelTaskById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevelTask` where Id=?");
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0013224C File Offset: 0x0013044C
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

		// Token: 0x04002BC2 RID: 11202
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BC3 RID: 11203
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BC4 RID: 11204
		private const string TABLE = "OnlineMotorLevelTask";

		// Token: 0x04002BC5 RID: 11205
		private const string COMMAND = "select BinData from `OnlineMotorLevelTask` where Id=?";

		// Token: 0x04002BC6 RID: 11206
		private const string KEY_PREFIX = "OnlineMotorLevelTaskById";

		// Token: 0x04002BC7 RID: 11207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BC8 RID: 11208
		private static int HandleId;
	}
}
