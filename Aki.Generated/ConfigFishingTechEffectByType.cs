using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000306 RID: 774
	public class ConfigFishingTechEffectByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001229 RID: 4649 RVA: 0x000C3A94 File Offset: 0x000C1C94
		static ConfigFishingTechEffectByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechEffectByType.CreateStaticDefaultValue), new Action(ConfigFishingTechEffectByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000C3AB4 File Offset: 0x000C1CB4
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTechEffectByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTechEffectByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTechEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTechEffect` where Type=?")
			});
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000C3B33 File Offset: 0x000C1D33
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechEffectByType.LogPair = null;
			ConfigFishingTechEffectByType.HandleId = 0;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000C3B41 File Offset: 0x000C1D41
		public static void Init()
		{
			ConfigFishingTechEffectByType.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechEffectByType.HandleId, "db_fishing.db", "select BinData from `FishingTechEffect` where Type=?");
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000C3B5C File Offset: 0x000C1D5C
		[NullableContext(2)]
		public static IReadOnlyList<FishingTechEffect> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTechEffectByType.HandleId, ConfigFishingTechEffectByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechEffectByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<FishingTechEffect> readOnlyList = (IReadOnlyList<FishingTechEffect>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFishingTechEffectByType.LogPair.Clear();
			ConfigFishingTechEffectByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigFishingTechEffectByType.HandleId, 1, p0Type, ConfigFishingTechEffectByType.LogPair))
			{
				ConfigCommon.Reset(ConfigFishingTechEffectByType.HandleId, ConfigFishingTechEffectByType.LogPair);
				return null;
			}
			List<FishingTechEffect> list = new List<FishingTechEffect>();
			while (ConfigCommon.Step(ConfigFishingTechEffectByType.HandleId, false, ConfigFishingTechEffectByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTechEffectByType.HandleId, 0, ConfigFishingTechEffectByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingTechEffectByType.HandleId, ConfigFishingTechEffectByType.LogPair);
					return null;
				}
				FishingTechEffect rootAsFishingTechEffect = FishingTechEffect.GetRootAsFishingTechEffect(new ByteBuffer(item2));
				list.Add(rootAsFishingTechEffect);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTechEffectByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingTechEffectByType.HandleId, ConfigFishingTechEffectByType.LogPair);
			return list;
		}

		// Token: 0x0400150E RID: 5390
		private const string DB = "db_fishing.db";

		// Token: 0x0400150F RID: 5391
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001510 RID: 5392
		private const string TABLE = "FishingTechEffect";

		// Token: 0x04001511 RID: 5393
		private const string COMMAND = "select BinData from `FishingTechEffect` where Type=?";

		// Token: 0x04001512 RID: 5394
		private const string KEY_PREFIX = "FishingTechEffectByType";

		// Token: 0x04001513 RID: 5395
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001514 RID: 5396
		private static int HandleId;
	}
}
