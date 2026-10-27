using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A81 RID: 2689
	public class ConfigWeaponHideConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F1A RID: 16154 RVA: 0x001BEE60 File Offset: 0x001BD060
		static ConfigWeaponHideConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHideConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigWeaponHideConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x001BEE80 File Offset: 0x001BD080
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHideConfigByIdWithZero.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHideConfigByIdWithZero.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHideConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x001BEEFF File Offset: 0x001BD0FF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHideConfigByIdWithZero.LogPair = null;
			ConfigWeaponHideConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x001BEF0D File Offset: 0x001BD10D
		public static void Init()
		{
			ConfigWeaponHideConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHideConfigByIdWithZero.HandleId, "db_weapon_visible.db", "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x001BEF28 File Offset: 0x001BD128
		public static WeaponHideConfig? GetConfig(int p0Id, int p1Id, int p2Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponHideConfig?(WeaponHideConfig.GetRootAsWeaponHideConfig(configBuffer));
				}
			}
			ConfigWeaponHideConfigByIdWithZero.LogPair.Clear();
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			if (!ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 1, p0Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 2, p1Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 3, p2Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || ConfigCommon.Step(ConfigWeaponHideConfigByIdWithZero.HandleId, true, ConfigWeaponHideConfigByIdWithZero.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHideConfigByIdWithZero.HandleId, 0, ConfigWeaponHideConfigByIdWithZero.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponHideConfig rootAsWeaponHideConfig = WeaponHideConfig.GetRootAsWeaponHideConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
			return new WeaponHideConfig?(rootAsWeaponHideConfig);
		}

		// Token: 0x0400496D RID: 18797
		private const string DB = "db_weapon_visible.db";

		// Token: 0x0400496E RID: 18798
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x0400496F RID: 18799
		private const string TABLE = "WeaponHideConfig";

		// Token: 0x04004970 RID: 18800
		private const string COMMAND = "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;";

		// Token: 0x04004971 RID: 18801
		private const string KEY_PREFIX = "WeaponHideConfigByIdWithZero";

		// Token: 0x04004972 RID: 18802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004973 RID: 18803
		private static int HandleId;
	}
}
