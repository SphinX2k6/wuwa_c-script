using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6F RID: 2671
	public class ConfigUiWeaponVisibleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EAE RID: 16046 RVA: 0x001BC6C9 File Offset: 0x001BA8C9
		static ConfigUiWeaponVisibleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiWeaponVisibleConfigById.CreateStaticDefaultValue), new Action(ConfigUiWeaponVisibleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x001BC6E8 File Offset: 0x001BA8E8
		public static void CreateStaticDefaultValue()
		{
			ConfigUiWeaponVisibleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiWeaponVisibleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "UiWeaponVisibleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `UiWeaponVisibleConfig` where Id=?")
			});
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x001BC767 File Offset: 0x001BA967
		public static void ResetStaticDefaultValue()
		{
			ConfigUiWeaponVisibleConfigById.LogPair = null;
			ConfigUiWeaponVisibleConfigById.HandleId = 0;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x001BC775 File Offset: 0x001BA975
		public static void Init()
		{
			ConfigUiWeaponVisibleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigUiWeaponVisibleConfigById.HandleId, "db_weapon_visible.db", "select BinData from `UiWeaponVisibleConfig` where Id=?");
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x001BC790 File Offset: 0x001BA990
		public static UiWeaponVisibleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiWeaponVisibleConfigById.HandleId, ConfigUiWeaponVisibleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiWeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiWeaponVisibleConfig?(UiWeaponVisibleConfig.GetRootAsUiWeaponVisibleConfig(configBuffer));
				}
			}
			ConfigUiWeaponVisibleConfigById.LogPair.Clear();
			ConfigUiWeaponVisibleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigUiWeaponVisibleConfigById.HandleId, 1, p0Id, ConfigUiWeaponVisibleConfigById.LogPair) || ConfigCommon.Step(ConfigUiWeaponVisibleConfigById.HandleId, true, ConfigUiWeaponVisibleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiWeaponVisibleConfigById.HandleId, ConfigUiWeaponVisibleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiWeaponVisibleConfigById.HandleId, 0, ConfigUiWeaponVisibleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiWeaponVisibleConfigById.HandleId, ConfigUiWeaponVisibleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiWeaponVisibleConfig rootAsUiWeaponVisibleConfig = UiWeaponVisibleConfig.GetRootAsUiWeaponVisibleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiWeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiWeaponVisibleConfigById.HandleId, ConfigUiWeaponVisibleConfigById.LogPair);
			return new UiWeaponVisibleConfig?(rootAsUiWeaponVisibleConfig);
		}

		// Token: 0x040048EF RID: 18671
		private const string DB = "db_weapon_visible.db";

		// Token: 0x040048F0 RID: 18672
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x040048F1 RID: 18673
		private const string TABLE = "UiWeaponVisibleConfig";

		// Token: 0x040048F2 RID: 18674
		private const string COMMAND = "select BinData from `UiWeaponVisibleConfig` where Id=?";

		// Token: 0x040048F3 RID: 18675
		private const string KEY_PREFIX = "UiWeaponVisibleConfigById";

		// Token: 0x040048F4 RID: 18676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048F5 RID: 18677
		private static int HandleId;
	}
}
