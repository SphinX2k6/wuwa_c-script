using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D5 RID: 1493
	public class ConfigMowTowerRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600230B RID: 8971 RVA: 0x0011F9E3 File Offset: 0x0011DBE3
		static ConfigMowTowerRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerRewardReById.CreateStaticDefaultValue), new Action(ConfigMowTowerRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0011FA04 File Offset: 0x0011DC04
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

		// Token: 0x0600230D RID: 8973 RVA: 0x0011FA83 File Offset: 0x0011DC83
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerRewardReById.LogPair = null;
			ConfigMowTowerRewardReById.HandleId = 0;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0011FA91 File Offset: 0x0011DC91
		public static void Init()
		{
			ConfigMowTowerRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerRewardReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerRewardRe` where Id=?");
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0011FAAC File Offset: 0x0011DCAC
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

		// Token: 0x040028B7 RID: 10423
		private const string DB = "db_mowtower.db";

		// Token: 0x040028B8 RID: 10424
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x040028B9 RID: 10425
		private const string TABLE = "MowTowerRewardRe";

		// Token: 0x040028BA RID: 10426
		private const string COMMAND = "select BinData from `MowTowerRewardRe` where Id=?";

		// Token: 0x040028BB RID: 10427
		private const string KEY_PREFIX = "MowTowerRewardReById";

		// Token: 0x040028BC RID: 10428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028BD RID: 10429
		private static int HandleId;
	}
}
