using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BA RID: 1978
	public class ConfigRealmBetweenTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E6E RID: 11886 RVA: 0x0015FD17 File Offset: 0x0015DF17
		static ConfigRealmBetweenTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRealmBetweenTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigRealmBetweenTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x0015FD38 File Offset: 0x0015DF38
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

		// Token: 0x06002E70 RID: 11888 RVA: 0x0015FDB7 File Offset: 0x0015DFB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRealmBetweenTaskByTaskId.LogPair = null;
			ConfigRealmBetweenTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x0015FDC5 File Offset: 0x0015DFC5
		public static void Init()
		{
			ConfigRealmBetweenTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigRealmBetweenTaskByTaskId.HandleId, "db_realmbetween.db", "select BinData from `RealmBetweenTask` where TaskId=?");
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x0015FDE0 File Offset: 0x0015DFE0
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

		// Token: 0x040035FC RID: 13820
		private const string DB = "db_realmbetween.db";

		// Token: 0x040035FD RID: 13821
		private const string FILE = "q.千岛路书3.5.xlsx";

		// Token: 0x040035FE RID: 13822
		private const string TABLE = "RealmBetweenTask";

		// Token: 0x040035FF RID: 13823
		private const string COMMAND = "select BinData from `RealmBetweenTask` where TaskId=?";

		// Token: 0x04003600 RID: 13824
		private const string KEY_PREFIX = "RealmBetweenTaskByTaskId";

		// Token: 0x04003601 RID: 13825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003602 RID: 13826
		private static int HandleId;
	}
}
