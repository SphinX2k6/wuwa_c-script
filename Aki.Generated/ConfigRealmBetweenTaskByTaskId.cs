using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D4 RID: 2004
	public class ConfigRealmBetweenTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F0A RID: 12042 RVA: 0x00166C23 File Offset: 0x00164E23
		static ConfigRealmBetweenTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00166C44 File Offset: 0x00164E44
		public static void CreateStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRealmBetweenTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_realmbetween.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.5.xlsx"),
				new ValueTuple<string, object>("表名", "RealmBetweenTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RealmBetweenTask` where TaskId=?")
			});
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00166CC3 File Offset: 0x00164EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByTaskId.LogPair = null;
			ConfigRealmBetweenTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00166CD1 File Offset: 0x00164ED1
		public static void Init()
		{
			ConfigRealmBetweenTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenTaskByTaskId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenTask` where TaskId=?");
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00166CEC File Offset: 0x00164EEC
		public static RealmBetweenTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRealmBetweenTaskByTaskId.HandleId, ConfigRealmBetweenTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RealmBetweenTask?(RealmBetweenTask.GetRootAsRealmBetweenTask(configBuffer));
				}
			}
			ConfigRealmBetweenTaskByTaskId.LogPair.Clear();
			ConfigRealmBetweenTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigRealmBetweenTaskByTaskId.HandleId, 1, p0TaskId, ConfigRealmBetweenTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigRealmBetweenTaskByTaskId.HandleId, true, ConfigRealmBetweenTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRealmBetweenTaskByTaskId.HandleId, ConfigRealmBetweenTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRealmBetweenTaskByTaskId.HandleId, 0, ConfigRealmBetweenTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRealmBetweenTaskByTaskId.HandleId, ConfigRealmBetweenTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RealmBetweenTask rootAsRealmBetweenTask = RealmBetweenTask.GetRootAsRealmBetweenTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RealmBetweenTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRealmBetweenTaskByTaskId.HandleId, ConfigRealmBetweenTaskByTaskId.LogPair);
			return new RealmBetweenTask?(rootAsRealmBetweenTask);
		}

		// Token: 0x040036B2 RID: 14002
		private const string DB = "db_realmbetween.db";

		// Token: 0x040036B3 RID: 14003
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040036B4 RID: 14004
		private const string TABLE = "RealmBetweenTask";

		// Token: 0x040036B5 RID: 14005
		private const string COMMAND = "select BinData from `RealmBetweenTask` where TaskId=?";

		// Token: 0x040036B6 RID: 14006
		private const string KEY_PREFIX = "RealmBetweenTaskByTaskId";

		// Token: 0x040036B7 RID: 14007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036B8 RID: 14008
		private static int HandleId;
	}
}
