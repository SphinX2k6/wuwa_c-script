using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4C RID: 2636
	public class ConfigTravelTaskAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DDC RID: 15836 RVA: 0x001B7AC7 File Offset: 0x001B5CC7
		static ConfigTravelTaskAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskAreaById.CreateStaticDefaultValue), new Action(ConfigTravelTaskAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x001B7AE8 File Offset: 0x001B5CE8
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelTaskAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelTaskAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelTaskArea"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelTaskArea` where Id=?")
			});
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x001B7B67 File Offset: 0x001B5D67
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskAreaById.LogPair = null;
			ConfigTravelTaskAreaById.HandleId = 0;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x001B7B75 File Offset: 0x001B5D75
		public static void Init()
		{
			ConfigTravelTaskAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskAreaById.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTaskArea` where Id=?");
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x001B7B90 File Offset: 0x001B5D90
		public static TravelTaskArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TravelTaskArea?(TravelTaskArea.GetRootAsTravelTaskArea(configBuffer));
				}
			}
			ConfigTravelTaskAreaById.LogPair.Clear();
			ConfigTravelTaskAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTravelTaskAreaById.HandleId, 1, p0Id, ConfigTravelTaskAreaById.LogPair) || ConfigCommon.Step(ConfigTravelTaskAreaById.HandleId, true, ConfigTravelTaskAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelTaskAreaById.HandleId, 0, ConfigTravelTaskAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TravelTaskArea rootAsTravelTaskArea = TravelTaskArea.GetRootAsTravelTaskArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
			return new TravelTaskArea?(rootAsTravelTaskArea);
		}

		// Token: 0x040047FA RID: 18426
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x040047FB RID: 18427
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x040047FC RID: 18428
		private const string TABLE = "TravelTaskArea";

		// Token: 0x040047FD RID: 18429
		private const string COMMAND = "select BinData from `TravelTaskArea` where Id=?";

		// Token: 0x040047FE RID: 18430
		private const string KEY_PREFIX = "TravelTaskAreaById";

		// Token: 0x040047FF RID: 18431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004800 RID: 18432
		private static int HandleId;
	}
}
