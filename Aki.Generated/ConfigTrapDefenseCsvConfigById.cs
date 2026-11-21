using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B00 RID: 2816
	public class ConfigTrapDefenseCsvConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004214 RID: 16916 RVA: 0x001D2768 File Offset: 0x001D0968
		static ConfigTrapDefenseCsvConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseCsvConfigById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseCsvConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x001D2788 File Offset: 0x001D0988
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

		// Token: 0x06004216 RID: 16918 RVA: 0x001D2807 File Offset: 0x001D0A07
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseCsvConfigById.LogPair = null;
			ConfigTrapDefenseCsvConfigById.HandleId = 0;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x001D2815 File Offset: 0x001D0A15
		public static void Init()
		{
			ConfigTrapDefenseCsvConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseCsvConfigById.HandleId, "db_trapdefensecsvconfig.db", "select BinData from `TrapDefenseCsvConfig` where Id=?");
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x001D2830 File Offset: 0x001D0A30
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

		// Token: 0x04004CE6 RID: 19686
		private const string DB = "db_trapdefensecsvconfig.db";

		// Token: 0x04004CE7 RID: 19687
		private const string FILE = "k.可视化编辑/c.Csv/t.塔防玩法总表/*.csv*";

		// Token: 0x04004CE8 RID: 19688
		private const string TABLE = "TrapDefenseCsvConfig";

		// Token: 0x04004CE9 RID: 19689
		private const string COMMAND = "select BinData from `TrapDefenseCsvConfig` where Id=?";

		// Token: 0x04004CEA RID: 19690
		private const string KEY_PREFIX = "TrapDefenseCsvConfigById";

		// Token: 0x04004CEB RID: 19691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CEC RID: 19692
		private static int HandleId;
	}
}
