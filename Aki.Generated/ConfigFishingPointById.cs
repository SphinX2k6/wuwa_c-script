using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E3 RID: 739
	public class ConfigFishingPointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001157 RID: 4439 RVA: 0x000BB7C4 File Offset: 0x000B99C4
		static ConfigFishingPointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPointById.CreateStaticDefaultValue), new Action(ConfigFishingPointById.ResetStaticDefaultValue));
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000BB7E4 File Offset: 0x000B99E4
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPointById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPointById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPoint` where Id=?")
			});
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000BB863 File Offset: 0x000B9A63
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPointById.LogPair = null;
			ConfigFishingPointById.HandleId = 0;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000BB871 File Offset: 0x000B9A71
		public static void Init()
		{
			ConfigFishingPointById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPointById.HandleId, "db_fishing.db", "select BinData from `FishingPoint` where Id=?");
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000BB88C File Offset: 0x000B9A8C
		public static FishingPoint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPoint?(FishingPoint.GetRootAsFishingPoint(configBuffer));
				}
			}
			ConfigFishingPointById.LogPair.Clear();
			ConfigFishingPointById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingPointById.HandleId, 1, p0Id, ConfigFishingPointById.LogPair) || ConfigCommon.Step(ConfigFishingPointById.HandleId, true, ConfigFishingPointById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPointById.HandleId, 0, ConfigFishingPointById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPoint rootAsFishingPoint = FishingPoint.GetRootAsFishingPoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPointById.HandleId, ConfigFishingPointById.LogPair);
			return new FishingPoint?(rootAsFishingPoint);
		}

		// Token: 0x04001419 RID: 5145
		private const string DB = "db_fishing.db";

		// Token: 0x0400141A RID: 5146
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x0400141B RID: 5147
		private const string TABLE = "FishingPoint";

		// Token: 0x0400141C RID: 5148
		private const string COMMAND = "select BinData from `FishingPoint` where Id=?";

		// Token: 0x0400141D RID: 5149
		private const string KEY_PREFIX = "FishingPointById";

		// Token: 0x0400141E RID: 5150
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400141F RID: 5151
		private static int HandleId;
	}
}
