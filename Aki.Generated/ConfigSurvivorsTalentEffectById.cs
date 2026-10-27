using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A9 RID: 2473
	public class ConfigSurvivorsTalentEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A0A RID: 14858 RVA: 0x001A1EF0 File Offset: 0x001A00F0
		static ConfigSurvivorsTalentEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentEffectById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x001A1F10 File Offset: 0x001A0110
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

		// Token: 0x06003A0C RID: 14860 RVA: 0x001A1F8F File Offset: 0x001A018F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentEffectById.LogPair = null;
			ConfigSurvivorsTalentEffectById.HandleId = 0;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x001A1F9D File Offset: 0x001A019D
		public static void Init()
		{
			ConfigSurvivorsTalentEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentEffectById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentEffect` where Id=?");
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x001A1FB8 File Offset: 0x001A01B8
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

		// Token: 0x04004385 RID: 17285
		private const string DB = "db_survivors.db";

		// Token: 0x04004386 RID: 17286
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004387 RID: 17287
		private const string TABLE = "SurvivorsTalentEffect";

		// Token: 0x04004388 RID: 17288
		private const string COMMAND = "select BinData from `SurvivorsTalentEffect` where Id=?";

		// Token: 0x04004389 RID: 17289
		private const string KEY_PREFIX = "SurvivorsTalentEffectById";

		// Token: 0x0400438A RID: 17290
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400438B RID: 17291
		private static int HandleId;
	}
}
