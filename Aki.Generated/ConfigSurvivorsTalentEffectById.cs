using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7E RID: 2686
	public class ConfigSurvivorsTalentEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F08 RID: 16136 RVA: 0x001C1284 File Offset: 0x001BF484
		static ConfigSurvivorsTalentEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentEffectById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x001C12A4 File Offset: 0x001BF4A4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTalentEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTalentEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTalentEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTalentEffect` where Id=?")
			});
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x001C1323 File Offset: 0x001BF523
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentEffectById.LogPair = null;
			ConfigSurvivorsTalentEffectById.HandleId = 0;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x001C1331 File Offset: 0x001BF531
		public static void Init()
		{
			ConfigSurvivorsTalentEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentEffectById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentEffect` where Id=?");
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x001C134C File Offset: 0x001BF54C
		public static SurvivorsTalentEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTalentEffectById.HandleId, ConfigSurvivorsTalentEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTalentEffect?(SurvivorsTalentEffect.GetRootAsSurvivorsTalentEffect(configBuffer));
				}
			}
			ConfigSurvivorsTalentEffectById.LogPair.Clear();
			ConfigSurvivorsTalentEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTalentEffectById.HandleId, 1, p0Id, ConfigSurvivorsTalentEffectById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTalentEffectById.HandleId, true, ConfigSurvivorsTalentEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentEffectById.HandleId, ConfigSurvivorsTalentEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTalentEffectById.HandleId, 0, ConfigSurvivorsTalentEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentEffectById.HandleId, ConfigSurvivorsTalentEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTalentEffect rootAsSurvivorsTalentEffect = SurvivorsTalentEffect.GetRootAsSurvivorsTalentEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTalentEffectById.HandleId, ConfigSurvivorsTalentEffectById.LogPair);
			return new SurvivorsTalentEffect?(rootAsSurvivorsTalentEffect);
		}

		// Token: 0x04004958 RID: 18776
		private const string DB = "db_survivors.db";

		// Token: 0x04004959 RID: 18777
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x0400495A RID: 18778
		private const string TABLE = "SurvivorsTalentEffect";

		// Token: 0x0400495B RID: 18779
		private const string COMMAND = "select BinData from `SurvivorsTalentEffect` where Id=?";

		// Token: 0x0400495C RID: 18780
		private const string KEY_PREFIX = "SurvivorsTalentEffectById";

		// Token: 0x0400495D RID: 18781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400495E RID: 18782
		private static int HandleId;
	}
}
