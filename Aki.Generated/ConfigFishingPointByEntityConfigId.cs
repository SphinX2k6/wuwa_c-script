using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F7 RID: 759
	public class ConfigFishingPointByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011CF RID: 4559 RVA: 0x000C1A89 File Offset: 0x000BFC89
		static ConfigFishingPointByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigFishingPointByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000C1AA8 File Offset: 0x000BFCA8
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPointByEntityConfigId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPointByEntityConfigId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPoint` where EntityConfigId=?")
			});
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000C1B27 File Offset: 0x000BFD27
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointByEntityConfigId.LogPair = null;
			ConfigFishingPointByEntityConfigId.HandleId = 0;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000C1B35 File Offset: 0x000BFD35
		public static void Init()
		{
			ConfigFishingPointByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointByEntityConfigId.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where EntityConfigId=?");
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000C1B50 File Offset: 0x000BFD50
		public static FishingPoint? GetConfig(int p0EntityConfigId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPointByEntityConfigId.HandleId, ConfigFishingPointByEntityConfigId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPoint?(FishingPoint.GetRootAsFishingPoint(configBuffer));
				}
			}
			ConfigFishingPointByEntityConfigId.LogPair.Clear();
			ConfigFishingPointByEntityConfigId.LogPair.Add(new ValueTuple<string, object>("EntityConfigId", p0EntityConfigId));
			if (!ConfigCommon.BindInt(ConfigFishingPointByEntityConfigId.HandleId, 1, p0EntityConfigId, ConfigFishingPointByEntityConfigId.LogPair) || ConfigCommon.Step(ConfigFishingPointByEntityConfigId.HandleId, true, ConfigFishingPointByEntityConfigId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPointByEntityConfigId.HandleId, ConfigFishingPointByEntityConfigId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPointByEntityConfigId.HandleId, 0, ConfigFishingPointByEntityConfigId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPointByEntityConfigId.HandleId, ConfigFishingPointByEntityConfigId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPoint rootAsFishingPoint = FishingPoint.GetRootAsFishingPoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPointByEntityConfigId.HandleId, ConfigFishingPointByEntityConfigId.LogPair);
			return new FishingPoint?(rootAsFishingPoint);
		}

		// Token: 0x040014A5 RID: 5285
		private const string DB = "db_fishing.db";

		// Token: 0x040014A6 RID: 5286
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014A7 RID: 5287
		private const string TABLE = "FishingPoint";

		// Token: 0x040014A8 RID: 5288
		private const string COMMAND = "select BinData from `FishingPoint` where EntityConfigId=?";

		// Token: 0x040014A9 RID: 5289
		private const string KEY_PREFIX = "FishingPointByEntityConfigId";

		// Token: 0x040014AA RID: 5290
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014AB RID: 5291
		private static int HandleId;
	}
}
