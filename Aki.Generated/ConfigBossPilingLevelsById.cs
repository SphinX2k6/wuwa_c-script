using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000106 RID: 262
	public class ConfigBossPilingLevelsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x0007C678 File Offset: 0x0007A878
		static ConfigBossPilingLevelsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingLevelsById.CreateStaticDefaultValue), new Action(ConfigBossPilingLevelsById.ResetStaticDefaultValue));
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0007C698 File Offset: 0x0007A898
		public static void CreateStaticDefaultValue()
		{
			ConfigBossPilingLevelsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossPilingLevelsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bosspiling.db"),
				new ValueTuple<string, object>("文件", "b.Boss打桩活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossPilingLevels"),
				new ValueTuple<string, object>("语句", "select BinData from `BossPilingLevels` where Id=?")
			});
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0007C717 File Offset: 0x0007A917
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingLevelsById.LogPair = null;
			ConfigBossPilingLevelsById.HandleId = 0;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0007C725 File Offset: 0x0007A925
		public static void Init()
		{
			ConfigBossPilingLevelsById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingLevelsById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingLevels` where Id=?");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0007C740 File Offset: 0x0007A940
		public static BossPilingLevels? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossPilingLevelsById.HandleId, ConfigBossPilingLevelsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingLevelsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossPilingLevels?(BossPilingLevels.GetRootAsBossPilingLevels(configBuffer));
				}
			}
			ConfigBossPilingLevelsById.LogPair.Clear();
			ConfigBossPilingLevelsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossPilingLevelsById.HandleId, 1, p0Id, ConfigBossPilingLevelsById.LogPair) || ConfigCommon.Step(ConfigBossPilingLevelsById.HandleId, true, ConfigBossPilingLevelsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossPilingLevelsById.HandleId, ConfigBossPilingLevelsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossPilingLevelsById.HandleId, 0, ConfigBossPilingLevelsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossPilingLevelsById.HandleId, ConfigBossPilingLevelsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossPilingLevels rootAsBossPilingLevels = BossPilingLevels.GetRootAsBossPilingLevels(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingLevelsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossPilingLevelsById.HandleId, ConfigBossPilingLevelsById.LogPair);
			return new BossPilingLevels?(rootAsBossPilingLevels);
		}

		// Token: 0x0400070E RID: 1806
		private const string DB = "db_bosspiling.db";

		// Token: 0x0400070F RID: 1807
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000710 RID: 1808
		private const string TABLE = "BossPilingLevels";

		// Token: 0x04000711 RID: 1809
		private const string COMMAND = "select BinData from `BossPilingLevels` where Id=?";

		// Token: 0x04000712 RID: 1810
		private const string KEY_PREFIX = "BossPilingLevelsById";

		// Token: 0x04000713 RID: 1811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000714 RID: 1812
		private static int HandleId;
	}
}
