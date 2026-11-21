using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A89 RID: 2697
	public class ConfigSurvivorsWeaponEvolveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x001C2AA8 File Offset: 0x001C0CA8
		static ConfigSurvivorsWeaponEvolveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponEvolveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponEvolveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x001C2AC8 File Offset: 0x001C0CC8
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

		// Token: 0x06003F4C RID: 16204 RVA: 0x001C2B47 File Offset: 0x001C0D47
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponEvolveById.LogPair = null;
			ConfigSurvivorsWeaponEvolveById.HandleId = 0;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x001C2B55 File Offset: 0x001C0D55
		public static void Init()
		{
			ConfigSurvivorsWeaponEvolveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponEvolveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeaponEvolve` where Id=?");
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x001C2B70 File Offset: 0x001C0D70
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

		// Token: 0x040049A5 RID: 18853
		private const string DB = "db_survivors.db";

		// Token: 0x040049A6 RID: 18854
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040049A7 RID: 18855
		private const string TABLE = "SurvivorsWeaponEvolve";

		// Token: 0x040049A8 RID: 18856
		private const string COMMAND = "select BinData from `SurvivorsWeaponEvolve` where Id=?";

		// Token: 0x040049A9 RID: 18857
		private const string KEY_PREFIX = "SurvivorsWeaponEvolveById";

		// Token: 0x040049AA RID: 18858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049AB RID: 18859
		private static int HandleId;
	}
}
