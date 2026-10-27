using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DA RID: 218
	public class ConfigBabelTowerQuickById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x00076873 File Offset: 0x00074A73
		static ConfigBabelTowerQuickById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickById.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickById.ResetStaticDefaultValue));
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00076894 File Offset: 0x00074A94
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerQuickById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerQuickById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerQuick"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerQuick` where Id=?")
			});
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00076913 File Offset: 0x00074B13
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickById.LogPair = null;
			ConfigBabelTowerQuickById.HandleId = 0;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00076921 File Offset: 0x00074B21
		public static void Init()
		{
			ConfigBabelTowerQuickById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick` where Id=?");
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0007693C File Offset: 0x00074B3C
		public static BabelTowerQuick? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerQuick?(BabelTowerQuick.GetRootAsBabelTowerQuick(configBuffer));
				}
			}
			ConfigBabelTowerQuickById.LogPair.Clear();
			ConfigBabelTowerQuickById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerQuickById.HandleId, 1, p0Id, ConfigBabelTowerQuickById.LogPair) || ConfigCommon.Step(ConfigBabelTowerQuickById.HandleId, true, ConfigBabelTowerQuickById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerQuickById.HandleId, 0, ConfigBabelTowerQuickById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerQuick rootAsBabelTowerQuick = BabelTowerQuick.GetRootAsBabelTowerQuick(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
			return new BabelTowerQuick?(rootAsBabelTowerQuick);
		}

		// Token: 0x040005DA RID: 1498
		private const string DB = "db_babeltower.db";

		// Token: 0x040005DB RID: 1499
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005DC RID: 1500
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x040005DD RID: 1501
		private const string COMMAND = "select BinData from `BabelTowerQuick` where Id=?";

		// Token: 0x040005DE RID: 1502
		private const string KEY_PREFIX = "BabelTowerQuickById";

		// Token: 0x040005DF RID: 1503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005E0 RID: 1504
		private static int HandleId;
	}
}
