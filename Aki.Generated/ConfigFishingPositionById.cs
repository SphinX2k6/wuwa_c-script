using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FB RID: 763
	public class ConfigFishingPositionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x000C2398 File Offset: 0x000C0598
		static ConfigFishingPositionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPositionById.CreateStaticDefaultValue), new Action(ConfigFishingPositionById.ResetStaticDefaultValue));
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000C23B8 File Offset: 0x000C05B8
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPositionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPositionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPosition"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPosition` where Id=?")
			});
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000C2437 File Offset: 0x000C0637
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPositionById.LogPair = null;
			ConfigFishingPositionById.HandleId = 0;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000C2445 File Offset: 0x000C0645
		public static void Init()
		{
			ConfigFishingPositionById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPositionById.HandleId, "db_fishing.db", "select BinData from `FishingPosition` where Id=?");
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000C2460 File Offset: 0x000C0660
		public static FishingPosition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPositionById.HandleId, ConfigFishingPositionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPositionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPosition?(FishingPosition.GetRootAsFishingPosition(configBuffer));
				}
			}
			ConfigFishingPositionById.LogPair.Clear();
			ConfigFishingPositionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingPositionById.HandleId, 1, p0Id, ConfigFishingPositionById.LogPair) || ConfigCommon.Step(ConfigFishingPositionById.HandleId, true, ConfigFishingPositionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPositionById.HandleId, ConfigFishingPositionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPositionById.HandleId, 0, ConfigFishingPositionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPositionById.HandleId, ConfigFishingPositionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPosition rootAsFishingPosition = FishingPosition.GetRootAsFishingPosition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPositionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPositionById.HandleId, ConfigFishingPositionById.LogPair);
			return new FishingPosition?(rootAsFishingPosition);
		}

		// Token: 0x040014C1 RID: 5313
		private const string DB = "db_fishing.db";

		// Token: 0x040014C2 RID: 5314
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014C3 RID: 5315
		private const string TABLE = "FishingPosition";

		// Token: 0x040014C4 RID: 5316
		private const string COMMAND = "select BinData from `FishingPosition` where Id=?";

		// Token: 0x040014C5 RID: 5317
		private const string KEY_PREFIX = "FishingPositionById";

		// Token: 0x040014C6 RID: 5318
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014C7 RID: 5319
		private static int HandleId;
	}
}
