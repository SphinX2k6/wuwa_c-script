using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EF RID: 2543
	public class ConfigSolarSchoolItemEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BAE RID: 15278 RVA: 0x001AE1AB File Offset: 0x001AC3AB
		static ConfigSolarSchoolItemEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolItemEffectById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolItemEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x001AE1CC File Offset: 0x001AC3CC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolItemEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolItemEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolItemEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolItemEffect` where Id=?")
			});
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x001AE24B File Offset: 0x001AC44B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolItemEffectById.LogPair = null;
			ConfigSolarSchoolItemEffectById.HandleId = 0;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x001AE259 File Offset: 0x001AC459
		public static void Init()
		{
			ConfigSolarSchoolItemEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolItemEffectById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolItemEffect` where Id=?");
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001AE274 File Offset: 0x001AC474
		public static SolarSchoolItemEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolItemEffectById.HandleId, ConfigSolarSchoolItemEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolItemEffect?(SolarSchoolItemEffect.GetRootAsSolarSchoolItemEffect(configBuffer));
				}
			}
			ConfigSolarSchoolItemEffectById.LogPair.Clear();
			ConfigSolarSchoolItemEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolItemEffectById.HandleId, 1, p0Id, ConfigSolarSchoolItemEffectById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolItemEffectById.HandleId, true, ConfigSolarSchoolItemEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolItemEffectById.HandleId, ConfigSolarSchoolItemEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolItemEffectById.HandleId, 0, ConfigSolarSchoolItemEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolItemEffectById.HandleId, ConfigSolarSchoolItemEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolItemEffect rootAsSolarSchoolItemEffect = SolarSchoolItemEffect.GetRootAsSolarSchoolItemEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolItemEffectById.HandleId, ConfigSolarSchoolItemEffectById.LogPair);
			return new SolarSchoolItemEffect?(rootAsSolarSchoolItemEffect);
		}

		// Token: 0x0400456F RID: 17775
		private const string DB = "db_solarschool.db";

		// Token: 0x04004570 RID: 17776
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004571 RID: 17777
		private const string TABLE = "SolarSchoolItemEffect";

		// Token: 0x04004572 RID: 17778
		private const string COMMAND = "select BinData from `SolarSchoolItemEffect` where Id=?";

		// Token: 0x04004573 RID: 17779
		private const string KEY_PREFIX = "SolarSchoolItemEffectById";

		// Token: 0x04004574 RID: 17780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004575 RID: 17781
		private static int HandleId;
	}
}
