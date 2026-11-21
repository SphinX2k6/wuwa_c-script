using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005ED RID: 1517
	public class ConfigMowTowerRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600239B RID: 9115 RVA: 0x0012645F File Offset: 0x0012465F
		static ConfigMowTowerRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerRewardReById.CreateStaticDefaultValue), new Action(ConfigMowTowerRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00126480 File Offset: 0x00124680
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerRewardReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerRewardReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerRewardRe` where Id=?")
			});
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x001264FF File Offset: 0x001246FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerRewardReById.LogPair = null;
			ConfigMowTowerRewardReById.HandleId = 0;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0012650D File Offset: 0x0012470D
		public static void Init()
		{
			ConfigMowTowerRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerRewardReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerRewardRe` where Id=?");
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00126528 File Offset: 0x00124728
		public static MowTowerRewardRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerRewardReById.HandleId, ConfigMowTowerRewardReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MowTowerRewardRe?(MowTowerRewardRe.GetRootAsMowTowerRewardRe(configBuffer));
				}
			}
			ConfigMowTowerRewardReById.LogPair.Clear();
			ConfigMowTowerRewardReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMowTowerRewardReById.HandleId, 1, p0Id, ConfigMowTowerRewardReById.LogPair) || ConfigCommon.Step(ConfigMowTowerRewardReById.HandleId, true, ConfigMowTowerRewardReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMowTowerRewardReById.HandleId, ConfigMowTowerRewardReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerRewardReById.HandleId, 0, ConfigMowTowerRewardReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMowTowerRewardReById.HandleId, ConfigMowTowerRewardReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MowTowerRewardRe rootAsMowTowerRewardRe = MowTowerRewardRe.GetRootAsMowTowerRewardRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMowTowerRewardReById.HandleId, ConfigMowTowerRewardReById.LogPair);
			return new MowTowerRewardRe?(rootAsMowTowerRewardRe);
		}

		// Token: 0x0400295F RID: 10591
		private const string DB = "db_mowtower.db";

		// Token: 0x04002960 RID: 10592
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x04002961 RID: 10593
		private const string TABLE = "MowTowerRewardRe";

		// Token: 0x04002962 RID: 10594
		private const string COMMAND = "select BinData from `MowTowerRewardRe` where Id=?";

		// Token: 0x04002963 RID: 10595
		private const string KEY_PREFIX = "MowTowerRewardReById";

		// Token: 0x04002964 RID: 10596
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002965 RID: 10597
		private static int HandleId;
	}
}
