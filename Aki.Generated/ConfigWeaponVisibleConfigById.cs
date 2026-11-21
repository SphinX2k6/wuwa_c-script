using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B61 RID: 2913
	public class ConfigWeaponVisibleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600445A RID: 17498 RVA: 0x001DFCDB File Offset: 0x001DDEDB
		static ConfigWeaponVisibleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponVisibleConfigById.CreateStaticDefaultValue), new Action(ConfigWeaponVisibleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x001DFCFC File Offset: 0x001DDEFC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponVisibleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponVisibleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponVisibleConfig` where Id=?")
			});
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x001DFD7B File Offset: 0x001DDF7B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigById.LogPair = null;
			ConfigWeaponVisibleConfigById.HandleId = 0;
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x001DFD89 File Offset: 0x001DDF89
		public static void Init()
		{
			ConfigWeaponVisibleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponVisibleConfigById.HandleId, "db_weapon_visible.db", "select BinData from `WeaponVisibleConfig` where Id=?");
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x001DFDA4 File Offset: 0x001DDFA4
		public static WeaponVisibleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponVisibleConfig?(WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(configBuffer));
				}
			}
			ConfigWeaponVisibleConfigById.LogPair.Clear();
			ConfigWeaponVisibleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponVisibleConfigById.HandleId, 1, p0Id, ConfigWeaponVisibleConfigById.LogPair) || ConfigCommon.Step(ConfigWeaponVisibleConfigById.HandleId, true, ConfigWeaponVisibleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponVisibleConfigById.HandleId, 0, ConfigWeaponVisibleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponVisibleConfig rootAsWeaponVisibleConfig = WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
			return new WeaponVisibleConfig?(rootAsWeaponVisibleConfig);
		}

		// Token: 0x04004F8D RID: 20365
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004F8E RID: 20366
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004F8F RID: 20367
		private const string TABLE = "WeaponVisibleConfig";

		// Token: 0x04004F90 RID: 20368
		private const string COMMAND = "select BinData from `WeaponVisibleConfig` where Id=?";

		// Token: 0x04004F91 RID: 20369
		private const string KEY_PREFIX = "WeaponVisibleConfigById";

		// Token: 0x04004F92 RID: 20370
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F93 RID: 20371
		private static int HandleId;
	}
}
