using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094F RID: 2383
	public class ConfigServerLimitById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037ED RID: 14317 RVA: 0x00198AD7 File Offset: 0x00196CD7
		static ConfigServerLimitById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigServerLimitById.CreateStaticDefaultValue), new Action(ConfigServerLimitById.ResetStaticDefaultValue));
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00198AF8 File Offset: 0x00196CF8
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

		// Token: 0x060037EF RID: 14319 RVA: 0x00198B77 File Offset: 0x00196D77
		public static void ResetStaticDefaultValue()
		{
			ConfigServerLimitById.LogPair = null;
			ConfigServerLimitById.HandleId = 0;
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00198B85 File Offset: 0x00196D85
		public static void Init()
		{
			ConfigServerLimitById.HandleId = ConfigCommon.InitDataStatement(ConfigServerLimitById.HandleId, "db_serverlimit.db", "select BinData from `ServerLimit` where Id=?");
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00198BA0 File Offset: 0x00196DA0
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

		// Token: 0x0400410F RID: 16655
		private const string DB = "db_serverlimit.db";

		// Token: 0x04004110 RID: 16656
		private const string FILE = "f.服务器限制.xlsx";

		// Token: 0x04004111 RID: 16657
		private const string TABLE = "ServerLimit";

		// Token: 0x04004112 RID: 16658
		private const string COMMAND = "select BinData from `ServerLimit` where Id=?";

		// Token: 0x04004113 RID: 16659
		private const string KEY_PREFIX = "ServerLimitById";

		// Token: 0x04004114 RID: 16660
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004115 RID: 16661
		private static int HandleId;
	}
}
