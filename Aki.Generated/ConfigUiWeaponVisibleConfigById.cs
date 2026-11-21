using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B44 RID: 2884
	public class ConfigUiWeaponVisibleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043AC RID: 17324 RVA: 0x001DBA5D File Offset: 0x001D9C5D
		static ConfigUiWeaponVisibleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiWeaponVisibleConfigById.CreateStaticDefaultValue), new Action(ConfigUiWeaponVisibleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x001DBA7C File Offset: 0x001D9C7C
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

		// Token: 0x060043AE RID: 17326 RVA: 0x001DBAFB File Offset: 0x001D9CFB
		public static void ResetStaticDefaultValue()
		{
			ConfigUiWeaponVisibleConfigById.LogPair = null;
			ConfigUiWeaponVisibleConfigById.HandleId = 0;
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x001DBB09 File Offset: 0x001D9D09
		public static void Init()
		{
			ConfigUiWeaponVisibleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigUiWeaponVisibleConfigById.HandleId, "db_weapon_visible.db", "select BinData from `UiWeaponVisibleConfig` where Id=?");
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x001DBB24 File Offset: 0x001D9D24
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

		// Token: 0x04004EC2 RID: 20162
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004EC3 RID: 20163
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004EC4 RID: 20164
		private const string TABLE = "UiWeaponVisibleConfig";

		// Token: 0x04004EC5 RID: 20165
		private const string COMMAND = "select BinData from `UiWeaponVisibleConfig` where Id=?";

		// Token: 0x04004EC6 RID: 20166
		private const string KEY_PREFIX = "UiWeaponVisibleConfigById";

		// Token: 0x04004EC7 RID: 20167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EC8 RID: 20168
		private static int HandleId;
	}
}
