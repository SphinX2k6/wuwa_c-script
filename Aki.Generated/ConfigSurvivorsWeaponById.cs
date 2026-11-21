using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A88 RID: 2696
	public class ConfigSurvivorsWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F44 RID: 16196 RVA: 0x001C285F File Offset: 0x001C0A5F
		static ConfigSurvivorsWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x001C2880 File Offset: 0x001C0A80
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeapon` where Id=?")
			});
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x001C28FF File Offset: 0x001C0AFF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponById.LogPair = null;
			ConfigSurvivorsWeaponById.HandleId = 0;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x001C290D File Offset: 0x001C0B0D
		public static void Init()
		{
			ConfigSurvivorsWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeapon` where Id=?");
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x001C2928 File Offset: 0x001C0B28
		public static SurvivorsWeapon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWeapon?(SurvivorsWeapon.GetRootAsSurvivorsWeapon(configBuffer));
				}
			}
			ConfigSurvivorsWeaponById.LogPair.Clear();
			ConfigSurvivorsWeaponById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponById.HandleId, 1, p0Id, ConfigSurvivorsWeaponById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWeaponById.HandleId, true, ConfigSurvivorsWeaponById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponById.HandleId, 0, ConfigSurvivorsWeaponById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWeapon rootAsSurvivorsWeapon = SurvivorsWeapon.GetRootAsSurvivorsWeapon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
			return new SurvivorsWeapon?(rootAsSurvivorsWeapon);
		}

		// Token: 0x0400499E RID: 18846
		private const string DB = "db_survivors.db";

		// Token: 0x0400499F RID: 18847
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040049A0 RID: 18848
		private const string TABLE = "SurvivorsWeapon";

		// Token: 0x040049A1 RID: 18849
		private const string COMMAND = "select BinData from `SurvivorsWeapon` where Id=?";

		// Token: 0x040049A2 RID: 18850
		private const string KEY_PREFIX = "SurvivorsWeaponById";

		// Token: 0x040049A3 RID: 18851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049A4 RID: 18852
		private static int HandleId;
	}
}
