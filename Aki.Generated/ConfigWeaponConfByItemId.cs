using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7B RID: 2683
	public class ConfigWeaponConfByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x001BE217 File Offset: 0x001BC417
		static ConfigWeaponConfByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponConfByItemId.CreateStaticDefaultValue), new Action(ConfigWeaponConfByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x001BE238 File Offset: 0x001BC438
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

		// Token: 0x06003EF8 RID: 16120 RVA: 0x001BE2B7 File Offset: 0x001BC4B7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponConfByItemId.LogPair = null;
			ConfigWeaponConfByItemId.HandleId = 0;
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x001BE2C5 File Offset: 0x001BC4C5
		public static void Init()
		{
			ConfigWeaponConfByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponConfByItemId.HandleId, "db_weapon.db", "select BinData from `WeaponConf` where ItemId = ?");
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x001BE2E0 File Offset: 0x001BC4E0
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

		// Token: 0x04004943 RID: 18755
		private const string DB = "db_weapon.db";

		// Token: 0x04004944 RID: 18756
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004945 RID: 18757
		private const string TABLE = "WeaponConf";

		// Token: 0x04004946 RID: 18758
		private const string COMMAND = "select BinData from `WeaponConf` where ItemId = ?";

		// Token: 0x04004947 RID: 18759
		private const string KEY_PREFIX = "WeaponConfByItemId";

		// Token: 0x04004948 RID: 18760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004949 RID: 18761
		private static int HandleId;
	}
}
