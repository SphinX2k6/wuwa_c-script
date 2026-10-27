using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CA RID: 202
	public class ConfigBabelTowerActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x000747F7 File Offset: 0x000729F7
		static ConfigBabelTowerActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigBabelTowerActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00074818 File Offset: 0x00072A18
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

		// Token: 0x060004BF RID: 1215 RVA: 0x00074897 File Offset: 0x00072A97
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerActivityByActivityId.LogPair = null;
			ConfigBabelTowerActivityByActivityId.HandleId = 0;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000748A5 File Offset: 0x00072AA5
		public static void Init()
		{
			ConfigBabelTowerActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerActivityByActivityId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerActivity` where ActivityId=?");
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000748C0 File Offset: 0x00072AC0
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

		// Token: 0x0400056A RID: 1386
		private const string DB = "db_babeltower.db";

		// Token: 0x0400056B RID: 1387
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400056C RID: 1388
		private const string TABLE = "BabelTowerActivity";

		// Token: 0x0400056D RID: 1389
		private const string COMMAND = "select BinData from `BabelTowerActivity` where ActivityId=?";

		// Token: 0x0400056E RID: 1390
		private const string KEY_PREFIX = "BabelTowerActivityByActivityId";

		// Token: 0x0400056F RID: 1391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000570 RID: 1392
		private static int HandleId;
	}
}
