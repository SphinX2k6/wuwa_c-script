using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F0 RID: 752
	public class ConfigFishingTechEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x000BD340 File Offset: 0x000BB540
		static ConfigFishingTechEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechEffectById.CreateStaticDefaultValue), new Action(ConfigFishingTechEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000BD360 File Offset: 0x000BB560
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

		// Token: 0x060011A7 RID: 4519 RVA: 0x000BD3DF File Offset: 0x000BB5DF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechEffectById.LogPair = null;
			ConfigFishingTechEffectById.HandleId = 0;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000BD3ED File Offset: 0x000BB5ED
		public static void Init()
		{
			ConfigFishingTechEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechEffectById.HandleId, "db_fishing.db", "select BinData from `FishingTechEffect` where Id=?");
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000BD408 File Offset: 0x000BB608
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

		// Token: 0x04001474 RID: 5236
		private const string DB = "db_fishing.db";

		// Token: 0x04001475 RID: 5237
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001476 RID: 5238
		private const string TABLE = "FishingTechEffect";

		// Token: 0x04001477 RID: 5239
		private const string COMMAND = "select BinData from `FishingTechEffect` where Id=?";

		// Token: 0x04001478 RID: 5240
		private const string KEY_PREFIX = "FishingTechEffectById";

		// Token: 0x04001479 RID: 5241
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400147A RID: 5242
		private static int HandleId;
	}
}
