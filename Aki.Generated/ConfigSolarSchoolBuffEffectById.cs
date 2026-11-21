using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C0 RID: 2496
	public class ConfigSolarSchoolBuffEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A94 RID: 14996 RVA: 0x001A7DF8 File Offset: 0x001A5FF8
		static ConfigSolarSchoolBuffEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBuffEffectById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBuffEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x001A7E18 File Offset: 0x001A6018
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBuffEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBuffEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBuffEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBuffEffect` where Id=?")
			});
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x001A7E97 File Offset: 0x001A6097
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBuffEffectById.LogPair = null;
			ConfigSolarSchoolBuffEffectById.HandleId = 0;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x001A7EA5 File Offset: 0x001A60A5
		public static void Init()
		{
			ConfigSolarSchoolBuffEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBuffEffectById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBuffEffect` where Id=?");
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001A7EC0 File Offset: 0x001A60C0
		public static SolarSchoolBuffEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBuffEffectById.HandleId, ConfigSolarSchoolBuffEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBuffEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolBuffEffect?(SolarSchoolBuffEffect.GetRootAsSolarSchoolBuffEffect(configBuffer));
				}
			}
			ConfigSolarSchoolBuffEffectById.LogPair.Clear();
			ConfigSolarSchoolBuffEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBuffEffectById.HandleId, 1, p0Id, ConfigSolarSchoolBuffEffectById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolBuffEffectById.HandleId, true, ConfigSolarSchoolBuffEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBuffEffectById.HandleId, ConfigSolarSchoolBuffEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBuffEffectById.HandleId, 0, ConfigSolarSchoolBuffEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBuffEffectById.HandleId, ConfigSolarSchoolBuffEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolBuffEffect rootAsSolarSchoolBuffEffect = SolarSchoolBuffEffect.GetRootAsSolarSchoolBuffEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBuffEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBuffEffectById.HandleId, ConfigSolarSchoolBuffEffectById.LogPair);
			return new SolarSchoolBuffEffect?(rootAsSolarSchoolBuffEffect);
		}

		// Token: 0x04004426 RID: 17446
		private const string DB = "db_solarschool.db";

		// Token: 0x04004427 RID: 17447
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004428 RID: 17448
		private const string TABLE = "SolarSchoolBuffEffect";

		// Token: 0x04004429 RID: 17449
		private const string COMMAND = "select BinData from `SolarSchoolBuffEffect` where Id=?";

		// Token: 0x0400442A RID: 17450
		private const string KEY_PREFIX = "SolarSchoolBuffEffectById";

		// Token: 0x0400442B RID: 17451
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400442C RID: 17452
		private static int HandleId;
	}
}
