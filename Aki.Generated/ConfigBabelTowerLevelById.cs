using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D8 RID: 216
	public class ConfigBabelTowerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00076497 File Offset: 0x00074697
		static ConfigBabelTowerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerLevelById.CreateStaticDefaultValue), new Action(ConfigBabelTowerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000764B8 File Offset: 0x000746B8
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

		// Token: 0x06000513 RID: 1299 RVA: 0x00076537 File Offset: 0x00074737
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerLevelById.LogPair = null;
			ConfigBabelTowerLevelById.HandleId = 0;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00076545 File Offset: 0x00074745
		public static void Init()
		{
			ConfigBabelTowerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerLevelById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerLevel` where Id=?");
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00076560 File Offset: 0x00074760
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

		// Token: 0x040005CC RID: 1484
		private const string DB = "db_babeltower.db";

		// Token: 0x040005CD RID: 1485
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005CE RID: 1486
		private const string TABLE = "BabelTowerLevel";

		// Token: 0x040005CF RID: 1487
		private const string COMMAND = "select BinData from `BabelTowerLevel` where Id=?";

		// Token: 0x040005D0 RID: 1488
		private const string KEY_PREFIX = "BabelTowerLevelById";

		// Token: 0x040005D1 RID: 1489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005D2 RID: 1490
		private static int HandleId;
	}
}
