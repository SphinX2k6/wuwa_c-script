using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D4 RID: 1236
	public class ConfigKurotatoWaypointsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D03 RID: 7427 RVA: 0x00100BF8 File Offset: 0x000FEDF8
		static ConfigKurotatoWaypointsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaypointsById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaypointsById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00100C18 File Offset: 0x000FEE18
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaypointsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaypointsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWaypoints"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWaypoints` where Id=?")
			});
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00100C97 File Offset: 0x000FEE97
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaypointsById.LogPair = null;
			ConfigKurotatoWaypointsById.HandleId = 0;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00100CA5 File Offset: 0x000FEEA5
		public static void Init()
		{
			ConfigKurotatoWaypointsById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaypointsById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaypoints` where Id=?");
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00100CC0 File Offset: 0x000FEEC0
		public static KurotatoWaypoints? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaypointsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWaypoints?(KurotatoWaypoints.GetRootAsKurotatoWaypoints(configBuffer));
				}
			}
			ConfigKurotatoWaypointsById.LogPair.Clear();
			ConfigKurotatoWaypointsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWaypointsById.HandleId, 1, p0Id, ConfigKurotatoWaypointsById.LogPair) || ConfigCommon.Step(ConfigKurotatoWaypointsById.HandleId, true, ConfigKurotatoWaypointsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaypointsById.HandleId, 0, ConfigKurotatoWaypointsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWaypoints rootAsKurotatoWaypoints = KurotatoWaypoints.GetRootAsKurotatoWaypoints(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaypointsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
			return new KurotatoWaypoints?(rootAsKurotatoWaypoints);
		}

		// Token: 0x040021B0 RID: 8624
		private const string DB = "db_kurotato.db";

		// Token: 0x040021B1 RID: 8625
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040021B2 RID: 8626
		private const string TABLE = "KurotatoWaypoints";

		// Token: 0x040021B3 RID: 8627
		private const string COMMAND = "select BinData from `KurotatoWaypoints` where Id=?";

		// Token: 0x040021B4 RID: 8628
		private const string KEY_PREFIX = "KurotatoWaypointsById";

		// Token: 0x040021B5 RID: 8629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021B6 RID: 8630
		private static int HandleId;
	}
}
