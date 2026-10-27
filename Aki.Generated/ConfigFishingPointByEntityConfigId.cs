using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E2 RID: 738
	public class ConfigFishingPointByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x000BB57D File Offset: 0x000B977D
		static ConfigFishingPointByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigFishingPointByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000BB59C File Offset: 0x000B979C
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

		// Token: 0x06001153 RID: 4435 RVA: 0x000BB61B File Offset: 0x000B981B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointByEntityConfigId.LogPair = null;
			ConfigFishingPointByEntityConfigId.HandleId = 0;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000BB629 File Offset: 0x000B9829
		public static void Init()
		{
			ConfigFishingPointByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointByEntityConfigId.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where EntityConfigId=?");
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x000BB644 File Offset: 0x000B9844
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

		// Token: 0x04001412 RID: 5138
		private const string DB = "db_fishing.db";

		// Token: 0x04001413 RID: 5139
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x04001414 RID: 5140
		private const string TABLE = "FishingPoint";

		// Token: 0x04001415 RID: 5141
		private const string COMMAND = "select BinData from `FishingPoint` where EntityConfigId=?";

		// Token: 0x04001416 RID: 5142
		private const string KEY_PREFIX = "FishingPointByEntityConfigId";

		// Token: 0x04001417 RID: 5143
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001418 RID: 5144
		private static int HandleId;
	}
}
