using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000640 RID: 1600
	public class ConfigOnlineMotorGlobalTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002590 RID: 9616 RVA: 0x00131918 File Offset: 0x0012FB18
		static ConfigOnlineMotorGlobalTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorGlobalTaskById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorGlobalTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00131938 File Offset: 0x0012FB38
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

		// Token: 0x06002592 RID: 9618 RVA: 0x001319B7 File Offset: 0x0012FBB7
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorGlobalTaskById.LogPair = null;
			ConfigOnlineMotorGlobalTaskById.HandleId = 0;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x001319C5 File Offset: 0x0012FBC5
		public static void Init()
		{
			ConfigOnlineMotorGlobalTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorGlobalTaskById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorGlobalTask` where Id=?");
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x001319E0 File Offset: 0x0012FBE0
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

		// Token: 0x04002BA6 RID: 11174
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BA7 RID: 11175
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BA8 RID: 11176
		private const string TABLE = "OnlineMotorGlobalTask";

		// Token: 0x04002BA9 RID: 11177
		private const string COMMAND = "select BinData from `OnlineMotorGlobalTask` where Id=?";

		// Token: 0x04002BAA RID: 11178
		private const string KEY_PREFIX = "OnlineMotorGlobalTaskById";

		// Token: 0x04002BAB RID: 11179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BAC RID: 11180
		private static int HandleId;
	}
}
