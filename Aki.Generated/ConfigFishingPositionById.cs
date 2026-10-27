using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E6 RID: 742
	public class ConfigFishingPositionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x000BBE8C File Offset: 0x000BA08C
		static ConfigFishingPositionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPositionById.CreateStaticDefaultValue), new Action(ConfigFishingPositionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000BBEAC File Offset: 0x000BA0AC
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

		// Token: 0x0600116B RID: 4459 RVA: 0x000BBF2B File Offset: 0x000BA12B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPositionById.LogPair = null;
			ConfigFishingPositionById.HandleId = 0;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000BBF39 File Offset: 0x000BA139
		public static void Init()
		{
			ConfigFishingPositionById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPositionById.HandleId, "db_fishing.db", "select BinData from `FishingPosition` where Id=?");
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000BBF54 File Offset: 0x000BA154
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

		// Token: 0x0400142E RID: 5166
		private const string DB = "db_fishing.db";

		// Token: 0x0400142F RID: 5167
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001430 RID: 5168
		private const string TABLE = "FishingPosition";

		// Token: 0x04001431 RID: 5169
		private const string COMMAND = "select BinData from `FishingPosition` where Id=?";

		// Token: 0x04001432 RID: 5170
		private const string KEY_PREFIX = "FishingPositionById";

		// Token: 0x04001433 RID: 5171
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001434 RID: 5172
		private static int HandleId;
	}
}
