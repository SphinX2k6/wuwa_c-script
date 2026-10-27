using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2B RID: 2603
	public class ConfigTrapDefenseCsvConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D16 RID: 15638 RVA: 0x001B33D4 File Offset: 0x001B15D4
		static ConfigTrapDefenseCsvConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseCsvConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseCsvConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x001B33F4 File Offset: 0x001B15F4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseCsvConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseCsvConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefensecsvconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.塔防玩法总表/*.csv*"),
				new ValueTuple<string, object>("表名", "TrapDefenseCsvConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseCsvConfig` where Id=?")
			});
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x001B3473 File Offset: 0x001B1673
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseCsvConfigById.LogPair = null;
			ConfigTrapDefenseCsvConfigById.HandleId = 0;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x001B3481 File Offset: 0x001B1681
		public static void Init()
		{
			ConfigTrapDefenseCsvConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseCsvConfigById.HandleId, "db_trapdefensecsvconfig.db", "select BinData from `TrapDefenseCsvConfig` where Id=?");
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x001B349C File Offset: 0x001B169C
		public static TrapDefenseCsvConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseCsvConfigById.HandleId, ConfigTrapDefenseCsvConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseCsvConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseCsvConfig?(TrapDefenseCsvConfig.GetRootAsTrapDefenseCsvConfig(configBuffer));
				}
			}
			ConfigTrapDefenseCsvConfigById.LogPair.Clear();
			ConfigTrapDefenseCsvConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseCsvConfigById.HandleId, 1, p0Id, ConfigTrapDefenseCsvConfigById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseCsvConfigById.HandleId, true, ConfigTrapDefenseCsvConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseCsvConfigById.HandleId, ConfigTrapDefenseCsvConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseCsvConfigById.HandleId, 0, ConfigTrapDefenseCsvConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseCsvConfigById.HandleId, ConfigTrapDefenseCsvConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseCsvConfig rootAsTrapDefenseCsvConfig = TrapDefenseCsvConfig.GetRootAsTrapDefenseCsvConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseCsvConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseCsvConfigById.HandleId, ConfigTrapDefenseCsvConfigById.LogPair);
			return new TrapDefenseCsvConfig?(rootAsTrapDefenseCsvConfig);
		}

		// Token: 0x04004713 RID: 18195
		private const string DB = "db_trapdefensecsvconfig.db";

		// Token: 0x04004714 RID: 18196
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防玩法总表/*.csv*";

		// Token: 0x04004715 RID: 18197
		private const string TABLE = "TrapDefenseCsvConfig";

		// Token: 0x04004716 RID: 18198
		private const string COMMAND = "select BinData from `TrapDefenseCsvConfig` where Id=?";

		// Token: 0x04004717 RID: 18199
		private const string KEY_PREFIX = "TrapDefenseCsvConfigById";

		// Token: 0x04004718 RID: 18200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004719 RID: 18201
		private static int HandleId;
	}
}
