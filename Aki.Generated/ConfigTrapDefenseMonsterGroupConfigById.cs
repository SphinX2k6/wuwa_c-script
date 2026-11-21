using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0C RID: 2828
	public class ConfigTrapDefenseMonsterGroupConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600425C RID: 16988 RVA: 0x001D3FF8 File Offset: 0x001D21F8
		static ConfigTrapDefenseMonsterGroupConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterGroupConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterGroupConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x001D4018 File Offset: 0x001D2218
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

		// Token: 0x0600425E RID: 16990 RVA: 0x001D4097 File Offset: 0x001D2297
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterGroupConfigById.LogPair = null;
			ConfigTrapDefenseMonsterGroupConfigById.HandleId = 0;
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x001D40A5 File Offset: 0x001D22A5
		public static void Init()
		{
			ConfigTrapDefenseMonsterGroupConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterGroupConfigById.HandleId, "db_trapdefensemonstergroupconfig.db", "select BinData from `TrapDefenseMonsterGroupConfig` where Id=?");
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x001D40C0 File Offset: 0x001D22C0
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

		// Token: 0x04004D3A RID: 19770
		private const string DB = "db_trapdefensemonstergroupconfig.db";

		// Token: 0x04004D3B RID: 19771
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防怪物组配置/*.csv*";

		// Token: 0x04004D3C RID: 19772
		private const string TABLE = "TrapDefenseMonsterGroupConfig";

		// Token: 0x04004D3D RID: 19773
		private const string COMMAND = "select BinData from `TrapDefenseMonsterGroupConfig` where Id=?";

		// Token: 0x04004D3E RID: 19774
		private const string KEY_PREFIX = "TrapDefenseMonsterGroupConfigById";

		// Token: 0x04004D3F RID: 19775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D40 RID: 19776
		private static int HandleId;
	}
}
