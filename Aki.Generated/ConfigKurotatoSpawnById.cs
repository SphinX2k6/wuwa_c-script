using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B6 RID: 1206
	public class ConfigKurotatoSpawnById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x000F9480 File Offset: 0x000F7680
		static ConfigKurotatoSpawnById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoSpawnById.CreateStaticDefaultValue), new Action(ConfigKurotatoSpawnById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000F94A0 File Offset: 0x000F76A0
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

		// Token: 0x06001C51 RID: 7249 RVA: 0x000F951F File Offset: 0x000F771F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoSpawnById.LogPair = null;
			ConfigKurotatoSpawnById.HandleId = 0;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000F952D File Offset: 0x000F772D
		public static void Init()
		{
			ConfigKurotatoSpawnById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoSpawnById.HandleId, "db_kurotato.db", "select BinData from `KurotatoSpawn` where Id=?");
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000F9548 File Offset: 0x000F7748
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

		// Token: 0x040020DE RID: 8414
		private const string DB = "db_kurotato.db";

		// Token: 0x040020DF RID: 8415
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020E0 RID: 8416
		private const string TABLE = "KurotatoSpawn";

		// Token: 0x040020E1 RID: 8417
		private const string COMMAND = "select BinData from `KurotatoSpawn` where Id=?";

		// Token: 0x040020E2 RID: 8418
		private const string KEY_PREFIX = "KurotatoSpawnById";

		// Token: 0x040020E3 RID: 8419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020E4 RID: 8420
		private static int HandleId;
	}
}
