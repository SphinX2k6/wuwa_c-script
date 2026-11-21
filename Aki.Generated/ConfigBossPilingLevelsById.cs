using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000115 RID: 277
	public class ConfigBossPilingLevelsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00081FDC File Offset: 0x000801DC
		static ConfigBossPilingLevelsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingLevelsById.CreateStaticDefaultValue), new Action(ConfigBossPilingLevelsById.ResetStaticDefaultValue));
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00081FFC File Offset: 0x000801FC
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

		// Token: 0x06000681 RID: 1665 RVA: 0x0008207B File Offset: 0x0008027B
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingLevelsById.LogPair = null;
			ConfigBossPilingLevelsById.HandleId = 0;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00082089 File Offset: 0x00080289
		public static void Init()
		{
			ConfigBossPilingLevelsById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingLevelsById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingLevels` where Id=?");
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000820A4 File Offset: 0x000802A4
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

		// Token: 0x04000777 RID: 1911
		private const string DB = "db_bosspiling.db";

		// Token: 0x04000778 RID: 1912
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000779 RID: 1913
		private const string TABLE = "BossPilingLevels";

		// Token: 0x0400077A RID: 1914
		private const string COMMAND = "select BinData from `BossPilingLevels` where Id=?";

		// Token: 0x0400077B RID: 1915
		private const string KEY_PREFIX = "BossPilingLevelsById";

		// Token: 0x0400077C RID: 1916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400077D RID: 1917
		private static int HandleId;
	}
}
