using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B50 RID: 2896
	public class ConfigWeaponConfByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043F4 RID: 17396 RVA: 0x001DD5AB File Offset: 0x001DB7AB
		static ConfigWeaponConfByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponConfByItemId.CreateStaticDefaultValue), new Action(ConfigWeaponConfByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x001DD5CC File Offset: 0x001DB7CC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponConfByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponConfByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponConf"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponConf` where ItemId = ?")
			});
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x001DD64B File Offset: 0x001DB84B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponConfByItemId.LogPair = null;
			ConfigWeaponConfByItemId.HandleId = 0;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x001DD659 File Offset: 0x001DB859
		public static void Init()
		{
			ConfigWeaponConfByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponConfByItemId.HandleId, "db_weapon.db", "select BinData from `WeaponConf` where ItemId = ?");
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x001DD674 File Offset: 0x001DB874
		public static WeaponConf? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponConfByItemId.HandleId, ConfigWeaponConfByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponConfByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponConf?(WeaponConf.GetRootAsWeaponConf(configBuffer));
				}
			}
			ConfigWeaponConfByItemId.LogPair.Clear();
			ConfigWeaponConfByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigWeaponConfByItemId.HandleId, 1, p0ItemId, ConfigWeaponConfByItemId.LogPair) || ConfigCommon.Step(ConfigWeaponConfByItemId.HandleId, true, ConfigWeaponConfByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponConfByItemId.HandleId, ConfigWeaponConfByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponConfByItemId.HandleId, 0, ConfigWeaponConfByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponConfByItemId.HandleId, ConfigWeaponConfByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponConf rootAsWeaponConf = WeaponConf.GetRootAsWeaponConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponConfByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponConfByItemId.HandleId, ConfigWeaponConfByItemId.LogPair);
			return new WeaponConf?(rootAsWeaponConf);
		}

		// Token: 0x04004F16 RID: 20246
		private const string DB = "db_weapon.db";

		// Token: 0x04004F17 RID: 20247
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F18 RID: 20248
		private const string TABLE = "WeaponConf";

		// Token: 0x04004F19 RID: 20249
		private const string COMMAND = "select BinData from `WeaponConf` where ItemId = ?";

		// Token: 0x04004F1A RID: 20250
		private const string KEY_PREFIX = "WeaponConfByItemId";

		// Token: 0x04004F1B RID: 20251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F1C RID: 20252
		private static int HandleId;
	}
}
