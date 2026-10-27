using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000904 RID: 2308
	public class ConfigServerLimitById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600362B RID: 13867 RVA: 0x0018B8B7 File Offset: 0x00189AB7
		static ConfigServerLimitById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigServerLimitById.CreateStaticDefaultValue), new Action(ConfigServerLimitById.ResetStaticDefaultValue));
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0018B8D8 File Offset: 0x00189AD8
		public static void CreateStaticDefaultValue()
		{
			ConfigServerLimitById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigServerLimitById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_serverlimit.db"),
				new ValueTuple<string, object>("文件", "f.服务器限制.xlsx"),
				new ValueTuple<string, object>("表名", "ServerLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `ServerLimit` where Id=?")
			});
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0018B957 File Offset: 0x00189B57
		public static void ResetStaticDefaultValue()
		{
			ConfigServerLimitById.LogPair = null;
			ConfigServerLimitById.HandleId = 0;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0018B965 File Offset: 0x00189B65
		public static void Init()
		{
			ConfigServerLimitById.HandleId = ConfigCommon.InitDataStatement(ConfigServerLimitById.HandleId, "db_serverlimit.db", "select BinData from `ServerLimit` where Id=?");
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0018B980 File Offset: 0x00189B80
		public static ServerLimit? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigServerLimitById.HandleId, ConfigServerLimitById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ServerLimitById#" + p0Id);
				if (configBuffer != null)
				{
					return new ServerLimit?(ServerLimit.GetRootAsServerLimit(configBuffer));
				}
			}
			ConfigServerLimitById.LogPair.Clear();
			ConfigServerLimitById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigServerLimitById.HandleId, 1, p0Id, ConfigServerLimitById.LogPair) || ConfigCommon.Step(ConfigServerLimitById.HandleId, true, ConfigServerLimitById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigServerLimitById.HandleId, ConfigServerLimitById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigServerLimitById.HandleId, 0, ConfigServerLimitById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigServerLimitById.HandleId, ConfigServerLimitById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ServerLimit rootAsServerLimit = ServerLimit.GetRootAsServerLimit(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ServerLimitById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigServerLimitById.HandleId, ConfigServerLimitById.LogPair);
			return new ServerLimit?(rootAsServerLimit);
		}

		// Token: 0x04003F02 RID: 16130
		private const string DB = "db_serverlimit.db";

		// Token: 0x04003F03 RID: 16131
		private const string FILE = "f.服务器限制.xlsx";

		// Token: 0x04003F04 RID: 16132
		private const string TABLE = "ServerLimit";

		// Token: 0x04003F05 RID: 16133
		private const string COMMAND = "select BinData from `ServerLimit` where Id=?";

		// Token: 0x04003F06 RID: 16134
		private const string KEY_PREFIX = "ServerLimitById";

		// Token: 0x04003F07 RID: 16135
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F08 RID: 16136
		private static int HandleId;
	}
}
