using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A37 RID: 2615
	public class ConfigTrapDefenseMonsterGroupConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x001B4C64 File Offset: 0x001B2E64
		static ConfigTrapDefenseMonsterGroupConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterGroupConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterGroupConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x001B4C84 File Offset: 0x001B2E84
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterGroupConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterGroupConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefensemonstergroupconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.塔防怪物组配置/*.csv*"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterGroupConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterGroupConfig` where Id=?")
			});
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x001B4D03 File Offset: 0x001B2F03
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterGroupConfigById.LogPair = null;
			ConfigTrapDefenseMonsterGroupConfigById.HandleId = 0;
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x001B4D11 File Offset: 0x001B2F11
		public static void Init()
		{
			ConfigTrapDefenseMonsterGroupConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterGroupConfigById.HandleId, "db_trapdefensemonstergroupconfig.db", "select BinData from `TrapDefenseMonsterGroupConfig` where Id=?");
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x001B4D2C File Offset: 0x001B2F2C
		public static TrapDefenseMonsterGroupConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterGroupConfigById.HandleId, ConfigTrapDefenseMonsterGroupConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterGroupConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterGroupConfig?(TrapDefenseMonsterGroupConfig.GetRootAsTrapDefenseMonsterGroupConfig(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterGroupConfigById.LogPair.Clear();
			ConfigTrapDefenseMonsterGroupConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterGroupConfigById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterGroupConfigById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterGroupConfigById.HandleId, true, ConfigTrapDefenseMonsterGroupConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterGroupConfigById.HandleId, ConfigTrapDefenseMonsterGroupConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterGroupConfigById.HandleId, 0, ConfigTrapDefenseMonsterGroupConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterGroupConfigById.HandleId, ConfigTrapDefenseMonsterGroupConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterGroupConfig rootAsTrapDefenseMonsterGroupConfig = TrapDefenseMonsterGroupConfig.GetRootAsTrapDefenseMonsterGroupConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterGroupConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterGroupConfigById.HandleId, ConfigTrapDefenseMonsterGroupConfigById.LogPair);
			return new TrapDefenseMonsterGroupConfig?(rootAsTrapDefenseMonsterGroupConfig);
		}

		// Token: 0x04004767 RID: 18279
		private const string DB = "db_trapdefensemonstergroupconfig.db";

		// Token: 0x04004768 RID: 18280
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防怪物组配置/*.csv*";

		// Token: 0x04004769 RID: 18281
		private const string TABLE = "TrapDefenseMonsterGroupConfig";

		// Token: 0x0400476A RID: 18282
		private const string COMMAND = "select BinData from `TrapDefenseMonsterGroupConfig` where Id=?";

		// Token: 0x0400476B RID: 18283
		private const string KEY_PREFIX = "TrapDefenseMonsterGroupConfigById";

		// Token: 0x0400476C RID: 18284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400476D RID: 18285
		private static int HandleId;
	}
}
