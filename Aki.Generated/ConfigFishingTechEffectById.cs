using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000305 RID: 773
	public class ConfigFishingTechEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001223 RID: 4643 RVA: 0x000C384C File Offset: 0x000C1A4C
		static ConfigFishingTechEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechEffectById.CreateStaticDefaultValue), new Action(ConfigFishingTechEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000C386C File Offset: 0x000C1A6C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTechEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTechEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTechEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTechEffect` where Id=?")
			});
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000C38EB File Offset: 0x000C1AEB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechEffectById.LogPair = null;
			ConfigFishingTechEffectById.HandleId = 0;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000C38F9 File Offset: 0x000C1AF9
		public static void Init()
		{
			ConfigFishingTechEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechEffectById.HandleId, "db_fishing.db", "select BinData from `FishingTechEffect` where Id=?");
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000C3914 File Offset: 0x000C1B14
		public static FishingTechEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTechEffectById.HandleId, ConfigFishingTechEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingTechEffect?(FishingTechEffect.GetRootAsFishingTechEffect(configBuffer));
				}
			}
			ConfigFishingTechEffectById.LogPair.Clear();
			ConfigFishingTechEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingTechEffectById.HandleId, 1, p0Id, ConfigFishingTechEffectById.LogPair) || ConfigCommon.Step(ConfigFishingTechEffectById.HandleId, true, ConfigFishingTechEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingTechEffectById.HandleId, ConfigFishingTechEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTechEffectById.HandleId, 0, ConfigFishingTechEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingTechEffectById.HandleId, ConfigFishingTechEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingTechEffect rootAsFishingTechEffect = FishingTechEffect.GetRootAsFishingTechEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingTechEffectById.HandleId, ConfigFishingTechEffectById.LogPair);
			return new FishingTechEffect?(rootAsFishingTechEffect);
		}

		// Token: 0x04001507 RID: 5383
		private const string DB = "db_fishing.db";

		// Token: 0x04001508 RID: 5384
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001509 RID: 5385
		private const string TABLE = "FishingTechEffect";

		// Token: 0x0400150A RID: 5386
		private const string COMMAND = "select BinData from `FishingTechEffect` where Id=?";

		// Token: 0x0400150B RID: 5387
		private const string KEY_PREFIX = "FishingTechEffectById";

		// Token: 0x0400150C RID: 5388
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400150D RID: 5389
		private static int HandleId;
	}
}
