using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000469 RID: 1129
	public class ConfigKeyPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x000EF2E7 File Offset: 0x000ED4E7
		static ConfigKeyPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKeyPoolById.CreateStaticDefaultValue), new Action(ConfigKeyPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000EF308 File Offset: 0x000ED508
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

		// Token: 0x06001A82 RID: 6786 RVA: 0x000EF387 File Offset: 0x000ED587
		public static void ResetStaticDefaultValue()
		{
			ConfigKeyPoolById.LogPair = null;
			ConfigKeyPoolById.HandleId = 0;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000EF395 File Offset: 0x000ED595
		public static void Init()
		{
			ConfigKeyPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigKeyPoolById.HandleId, "db_menu.db", "select BinData from `KeyPool` where Id=?");
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000EF3B0 File Offset: 0x000ED5B0
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

		// Token: 0x04001EC3 RID: 7875
		private const string DB = "db_menu.db";

		// Token: 0x04001EC4 RID: 7876
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001EC5 RID: 7877
		private const string TABLE = "KeyPool";

		// Token: 0x04001EC6 RID: 7878
		private const string COMMAND = "select BinData from `KeyPool` where Id=?";

		// Token: 0x04001EC7 RID: 7879
		private const string KEY_PREFIX = "KeyPoolById";

		// Token: 0x04001EC8 RID: 7880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EC9 RID: 7881
		private static int HandleId;
	}
}
