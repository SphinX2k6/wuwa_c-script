using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CC RID: 1228
	public class ConfigKurotatoSpawnById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CD3 RID: 7379 RVA: 0x000FFBD4 File Offset: 0x000FDDD4
		static ConfigKurotatoSpawnById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoSpawnById.CreateStaticDefaultValue), new Action(ConfigKurotatoSpawnById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000FFBF4 File Offset: 0x000FDDF4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoSpawnById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoSpawnById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoSpawn"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoSpawn` where Id=?")
			});
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000FFC73 File Offset: 0x000FDE73
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoSpawnById.LogPair = null;
			ConfigKurotatoSpawnById.HandleId = 0;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000FFC81 File Offset: 0x000FDE81
		public static void Init()
		{
			ConfigKurotatoSpawnById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoSpawnById.HandleId, "db_kurotato.db", "select BinData from `KurotatoSpawn` where Id=?");
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000FFC9C File Offset: 0x000FDE9C
		public static KurotatoSpawn? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoSpawnById.HandleId, ConfigKurotatoSpawnById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoSpawnById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoSpawn?(KurotatoSpawn.GetRootAsKurotatoSpawn(configBuffer));
				}
			}
			ConfigKurotatoSpawnById.LogPair.Clear();
			ConfigKurotatoSpawnById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoSpawnById.HandleId, 1, p0Id, ConfigKurotatoSpawnById.LogPair) || ConfigCommon.Step(ConfigKurotatoSpawnById.HandleId, true, ConfigKurotatoSpawnById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoSpawnById.HandleId, ConfigKurotatoSpawnById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoSpawnById.HandleId, 0, ConfigKurotatoSpawnById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoSpawnById.HandleId, ConfigKurotatoSpawnById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoSpawn rootAsKurotatoSpawn = KurotatoSpawn.GetRootAsKurotatoSpawn(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoSpawnById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoSpawnById.HandleId, ConfigKurotatoSpawnById.LogPair);
			return new KurotatoSpawn?(rootAsKurotatoSpawn);
		}

		// Token: 0x04002178 RID: 8568
		private const string DB = "db_kurotato.db";

		// Token: 0x04002179 RID: 8569
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400217A RID: 8570
		private const string TABLE = "KurotatoSpawn";

		// Token: 0x0400217B RID: 8571
		private const string COMMAND = "select BinData from `KurotatoSpawn` where Id=?";

		// Token: 0x0400217C RID: 8572
		private const string KEY_PREFIX = "KurotatoSpawnById";

		// Token: 0x0400217D RID: 8573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400217E RID: 8574
		private static int HandleId;
	}
}
