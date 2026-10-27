using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B4 RID: 2484
	public class ConfigSurvivorsWeaponEvolveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A4C RID: 14924 RVA: 0x001A3714 File Offset: 0x001A1914
		static ConfigSurvivorsWeaponEvolveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponEvolveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponEvolveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x001A3734 File Offset: 0x001A1934
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponEvolveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponEvolveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeaponEvolve"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeaponEvolve` where Id=?")
			});
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001A37B3 File Offset: 0x001A19B3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponEvolveById.LogPair = null;
			ConfigSurvivorsWeaponEvolveById.HandleId = 0;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x001A37C1 File Offset: 0x001A19C1
		public static void Init()
		{
			ConfigSurvivorsWeaponEvolveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponEvolveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeaponEvolve` where Id=?");
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x001A37DC File Offset: 0x001A19DC
		public static SurvivorsWeaponEvolve? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponEvolveById.HandleId, ConfigSurvivorsWeaponEvolveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponEvolveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWeaponEvolve?(SurvivorsWeaponEvolve.GetRootAsSurvivorsWeaponEvolve(configBuffer));
				}
			}
			ConfigSurvivorsWeaponEvolveById.LogPair.Clear();
			ConfigSurvivorsWeaponEvolveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponEvolveById.HandleId, 1, p0Id, ConfigSurvivorsWeaponEvolveById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWeaponEvolveById.HandleId, true, ConfigSurvivorsWeaponEvolveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponEvolveById.HandleId, ConfigSurvivorsWeaponEvolveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponEvolveById.HandleId, 0, ConfigSurvivorsWeaponEvolveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponEvolveById.HandleId, ConfigSurvivorsWeaponEvolveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWeaponEvolve rootAsSurvivorsWeaponEvolve = SurvivorsWeaponEvolve.GetRootAsSurvivorsWeaponEvolve(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponEvolveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponEvolveById.HandleId, ConfigSurvivorsWeaponEvolveById.LogPair);
			return new SurvivorsWeaponEvolve?(rootAsSurvivorsWeaponEvolve);
		}

		// Token: 0x040043D2 RID: 17362
		private const string DB = "db_survivors.db";

		// Token: 0x040043D3 RID: 17363
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040043D4 RID: 17364
		private const string TABLE = "SurvivorsWeaponEvolve";

		// Token: 0x040043D5 RID: 17365
		private const string COMMAND = "select BinData from `SurvivorsWeaponEvolve` where Id=?";

		// Token: 0x040043D6 RID: 17366
		private const string KEY_PREFIX = "SurvivorsWeaponEvolveById";

		// Token: 0x040043D7 RID: 17367
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043D8 RID: 17368
		private static int HandleId;
	}
}
