using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7D RID: 2685
	public class ConfigWeaponExpItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F02 RID: 16130 RVA: 0x001BE5F3 File Offset: 0x001BC7F3
		static ConfigWeaponExpItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponExpItemById.CreateStaticDefaultValue), new Action(ConfigWeaponExpItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x001BE614 File Offset: 0x001BC814
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponExpItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponExpItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponExpItem` where Id = ?")
			});
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x001BE693 File Offset: 0x001BC893
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponExpItemById.LogPair = null;
			ConfigWeaponExpItemById.HandleId = 0;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x001BE6A1 File Offset: 0x001BC8A1
		public static void Init()
		{
			ConfigWeaponExpItemById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponExpItemById.HandleId, "db_weapon.db", "select BinData from `WeaponExpItem` where Id = ?");
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x001BE6BC File Offset: 0x001BC8BC
		public static WeaponExpItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponExpItemById.HandleId, ConfigWeaponExpItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponExpItem?(WeaponExpItem.GetRootAsWeaponExpItem(configBuffer));
				}
			}
			ConfigWeaponExpItemById.LogPair.Clear();
			ConfigWeaponExpItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponExpItemById.HandleId, 1, p0Id, ConfigWeaponExpItemById.LogPair) || ConfigCommon.Step(ConfigWeaponExpItemById.HandleId, true, ConfigWeaponExpItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponExpItemById.HandleId, ConfigWeaponExpItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponExpItemById.HandleId, 0, ConfigWeaponExpItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponExpItemById.HandleId, ConfigWeaponExpItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponExpItem rootAsWeaponExpItem = WeaponExpItem.GetRootAsWeaponExpItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponExpItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponExpItemById.HandleId, ConfigWeaponExpItemById.LogPair);
			return new WeaponExpItem?(rootAsWeaponExpItem);
		}

		// Token: 0x04004951 RID: 18769
		private const string DB = "db_weapon.db";

		// Token: 0x04004952 RID: 18770
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004953 RID: 18771
		private const string TABLE = "WeaponExpItem";

		// Token: 0x04004954 RID: 18772
		private const string COMMAND = "select BinData from `WeaponExpItem` where Id = ?";

		// Token: 0x04004955 RID: 18773
		private const string KEY_PREFIX = "WeaponExpItemById";

		// Token: 0x04004956 RID: 18774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004957 RID: 18775
		private static int HandleId;
	}
}
