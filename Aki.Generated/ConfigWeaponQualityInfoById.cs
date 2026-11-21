using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5B RID: 2907
	public class ConfigWeaponQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004436 RID: 17462 RVA: 0x001DEEF6 File Offset: 0x001DD0F6
		static ConfigWeaponQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponQualityInfoById.CreateStaticDefaultValue), new Action(ConfigWeaponQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x001DEF18 File Offset: 0x001DD118
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponQualityInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponQualityInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponQualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponQualityInfo` where Id =?")
			});
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x001DEF97 File Offset: 0x001DD197
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponQualityInfoById.LogPair = null;
			ConfigWeaponQualityInfoById.HandleId = 0;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x001DEFA5 File Offset: 0x001DD1A5
		public static void Init()
		{
			ConfigWeaponQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponQualityInfoById.HandleId, "db_weapon.db", "select BinData from `WeaponQualityInfo` where Id =?");
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		public static WeaponQualityInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponQualityInfo?(WeaponQualityInfo.GetRootAsWeaponQualityInfo(configBuffer));
				}
			}
			ConfigWeaponQualityInfoById.LogPair.Clear();
			ConfigWeaponQualityInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponQualityInfoById.HandleId, 1, p0Id, ConfigWeaponQualityInfoById.LogPair) || ConfigCommon.Step(ConfigWeaponQualityInfoById.HandleId, true, ConfigWeaponQualityInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponQualityInfoById.HandleId, 0, ConfigWeaponQualityInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponQualityInfo rootAsWeaponQualityInfo = WeaponQualityInfo.GetRootAsWeaponQualityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
			return new WeaponQualityInfo?(rootAsWeaponQualityInfo);
		}

		// Token: 0x04004F63 RID: 20323
		private const string DB = "db_weapon.db";

		// Token: 0x04004F64 RID: 20324
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F65 RID: 20325
		private const string TABLE = "WeaponQualityInfo";

		// Token: 0x04004F66 RID: 20326
		private const string COMMAND = "select BinData from `WeaponQualityInfo` where Id =?";

		// Token: 0x04004F67 RID: 20327
		private const string KEY_PREFIX = "WeaponQualityInfoById";

		// Token: 0x04004F68 RID: 20328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F69 RID: 20329
		private static int HandleId;
	}
}
