using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047F RID: 1151
	public class ConfigKeyPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x000F5A3B File Offset: 0x000F3C3B
		static ConfigKeyPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyPoolById.CreateStaticDefaultValue), new Action(ConfigKeyPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x000F5A5C File Offset: 0x000F3C5C
		public static void CreateStaticDefaultValue()
		{
			ConfigKeyPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKeyPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "KeyPool"),
				new ValueTuple<string, object>("语句", "select BinData from `KeyPool` where Id=?")
			});
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000F5ADB File Offset: 0x000F3CDB
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyPoolById.LogPair = null;
			ConfigKeyPoolById.HandleId = 0;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000F5AE9 File Offset: 0x000F3CE9
		public static void Init()
		{
			ConfigKeyPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigKeyPoolById.HandleId, "db_menu.db", "select BinData from `KeyPool` where Id=?");
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000F5B04 File Offset: 0x000F3D04
		public static KeyPool? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKeyPoolById.HandleId, ConfigKeyPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("KeyPoolById#" + p0Id);
				if (configBuffer != null)
				{
					return new KeyPool?(KeyPool.GetRootAsKeyPool(configBuffer));
				}
			}
			ConfigKeyPoolById.LogPair.Clear();
			ConfigKeyPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigKeyPoolById.HandleId, 1, p0Id, ConfigKeyPoolById.LogPair) || ConfigCommon.Step(ConfigKeyPoolById.HandleId, true, ConfigKeyPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKeyPoolById.HandleId, ConfigKeyPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKeyPoolById.HandleId, 0, ConfigKeyPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKeyPoolById.HandleId, ConfigKeyPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KeyPool rootAsKeyPool = KeyPool.GetRootAsKeyPool(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("KeyPoolById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKeyPoolById.HandleId, ConfigKeyPoolById.LogPair);
			return new KeyPool?(rootAsKeyPool);
		}

		// Token: 0x04001F5D RID: 8029
		private const string DB = "db_menu.db";

		// Token: 0x04001F5E RID: 8030
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001F5F RID: 8031
		private const string TABLE = "KeyPool";

		// Token: 0x04001F60 RID: 8032
		private const string COMMAND = "select BinData from `KeyPool` where Id=?";

		// Token: 0x04001F61 RID: 8033
		private const string KEY_PREFIX = "KeyPoolById";

		// Token: 0x04001F62 RID: 8034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F63 RID: 8035
		private static int HandleId;
	}
}
