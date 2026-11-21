using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E7 RID: 231
	public class ConfigBabelTowerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x0007BDFB File Offset: 0x00079FFB
		static ConfigBabelTowerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerLevelById.CreateStaticDefaultValue), new Action(ConfigBabelTowerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0007BE1C File Offset: 0x0007A01C
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerLevel` where Id=?")
			});
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0007BE9B File Offset: 0x0007A09B
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerLevelById.LogPair = null;
			ConfigBabelTowerLevelById.HandleId = 0;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0007BEA9 File Offset: 0x0007A0A9
		public static void Init()
		{
			ConfigBabelTowerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerLevelById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerLevel` where Id=?");
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0007BEC4 File Offset: 0x0007A0C4
		public static BabelTowerLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerLevelById.HandleId, ConfigBabelTowerLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerLevel?(BabelTowerLevel.GetRootAsBabelTowerLevel(configBuffer));
				}
			}
			ConfigBabelTowerLevelById.LogPair.Clear();
			ConfigBabelTowerLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerLevelById.HandleId, 1, p0Id, ConfigBabelTowerLevelById.LogPair) || ConfigCommon.Step(ConfigBabelTowerLevelById.HandleId, true, ConfigBabelTowerLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerLevelById.HandleId, ConfigBabelTowerLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerLevelById.HandleId, 0, ConfigBabelTowerLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerLevelById.HandleId, ConfigBabelTowerLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerLevel rootAsBabelTowerLevel = BabelTowerLevel.GetRootAsBabelTowerLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerLevelById.HandleId, ConfigBabelTowerLevelById.LogPair);
			return new BabelTowerLevel?(rootAsBabelTowerLevel);
		}

		// Token: 0x04000635 RID: 1589
		private const string DB = "db_babeltower.db";

		// Token: 0x04000636 RID: 1590
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000637 RID: 1591
		private const string TABLE = "BabelTowerLevel";

		// Token: 0x04000638 RID: 1592
		private const string COMMAND = "select BinData from `BabelTowerLevel` where Id=?";

		// Token: 0x04000639 RID: 1593
		private const string KEY_PREFIX = "BabelTowerLevelById";

		// Token: 0x0400063A RID: 1594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400063B RID: 1595
		private static int HandleId;
	}
}
