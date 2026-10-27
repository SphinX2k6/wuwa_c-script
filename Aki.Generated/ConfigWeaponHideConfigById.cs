using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A80 RID: 2688
	public class ConfigWeaponHideConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F14 RID: 16148 RVA: 0x001BEC18 File Offset: 0x001BCE18
		static ConfigWeaponHideConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHideConfigById.CreateStaticDefaultValue), new Action(ConfigWeaponHideConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x001BEC38 File Offset: 0x001BCE38
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHideConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHideConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHideConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHideConfig` where Id=?")
			});
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x001BECB7 File Offset: 0x001BCEB7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHideConfigById.LogPair = null;
			ConfigWeaponHideConfigById.HandleId = 0;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x001BECC5 File Offset: 0x001BCEC5
		public static void Init()
		{
			ConfigWeaponHideConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHideConfigById.HandleId, "db_weapon_visible.db", "select BinData from `WeaponHideConfig` where Id=?");
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x001BECE0 File Offset: 0x001BCEE0
		public static WeaponHideConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponHideConfig?(WeaponHideConfig.GetRootAsWeaponHideConfig(configBuffer));
				}
			}
			ConfigWeaponHideConfigById.LogPair.Clear();
			ConfigWeaponHideConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponHideConfigById.HandleId, 1, p0Id, ConfigWeaponHideConfigById.LogPair) || ConfigCommon.Step(ConfigWeaponHideConfigById.HandleId, true, ConfigWeaponHideConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHideConfigById.HandleId, 0, ConfigWeaponHideConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponHideConfig rootAsWeaponHideConfig = WeaponHideConfig.GetRootAsWeaponHideConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
			return new WeaponHideConfig?(rootAsWeaponHideConfig);
		}

		// Token: 0x04004966 RID: 18790
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004967 RID: 18791
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004968 RID: 18792
		private const string TABLE = "WeaponHideConfig";

		// Token: 0x04004969 RID: 18793
		private const string COMMAND = "select BinData from `WeaponHideConfig` where Id=?";

		// Token: 0x0400496A RID: 18794
		private const string KEY_PREFIX = "WeaponHideConfigById";

		// Token: 0x0400496B RID: 18795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400496C RID: 18796
		private static int HandleId;
	}
}
