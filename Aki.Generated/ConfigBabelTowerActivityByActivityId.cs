using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D9 RID: 217
	public class ConfigBabelTowerActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x0007A15B File Offset: 0x0007835B
		static ConfigBabelTowerActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigBabelTowerActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0007A17C File Offset: 0x0007837C
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerActivity` where ActivityId=?")
			});
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0007A1FB File Offset: 0x000783FB
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerActivityByActivityId.LogPair = null;
			ConfigBabelTowerActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0007A209 File Offset: 0x00078409
		public static void Init()
		{
			ConfigBabelTowerActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerActivityByActivityId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerActivity` where ActivityId=?");
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0007A224 File Offset: 0x00078424
		public static BabelTowerActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerActivityByActivityId.HandleId, ConfigBabelTowerActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerActivity?(BabelTowerActivity.GetRootAsBabelTowerActivity(configBuffer));
				}
			}
			ConfigBabelTowerActivityByActivityId.LogPair.Clear();
			ConfigBabelTowerActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerActivityByActivityId.HandleId, 1, p0ActivityId, ConfigBabelTowerActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigBabelTowerActivityByActivityId.HandleId, true, ConfigBabelTowerActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerActivityByActivityId.HandleId, ConfigBabelTowerActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerActivityByActivityId.HandleId, 0, ConfigBabelTowerActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerActivityByActivityId.HandleId, ConfigBabelTowerActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerActivity rootAsBabelTowerActivity = BabelTowerActivity.GetRootAsBabelTowerActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerActivityByActivityId.HandleId, ConfigBabelTowerActivityByActivityId.LogPair);
			return new BabelTowerActivity?(rootAsBabelTowerActivity);
		}

		// Token: 0x040005D3 RID: 1491
		private const string DB = "db_babeltower.db";

		// Token: 0x040005D4 RID: 1492
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005D5 RID: 1493
		private const string TABLE = "BabelTowerActivity";

		// Token: 0x040005D6 RID: 1494
		private const string COMMAND = "select BinData from `BabelTowerActivity` where ActivityId=?";

		// Token: 0x040005D7 RID: 1495
		private const string KEY_PREFIX = "BabelTowerActivityByActivityId";

		// Token: 0x040005D8 RID: 1496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005D9 RID: 1497
		private static int HandleId;
	}
}
