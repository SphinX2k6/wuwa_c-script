using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7F RID: 2687
	public class ConfigWeaponHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F0E RID: 16142 RVA: 0x001BE9CF File Offset: 0x001BCBCF
		static ConfigWeaponHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHandBookById.CreateStaticDefaultValue), new Action(ConfigWeaponHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x001BE9F0 File Offset: 0x001BCBF0
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHandBookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHandBookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHandBook` where Id = ?")
			});
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x001BEA6F File Offset: 0x001BCC6F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHandBookById.LogPair = null;
			ConfigWeaponHandBookById.HandleId = 0;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x001BEA7D File Offset: 0x001BCC7D
		public static void Init()
		{
			ConfigWeaponHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHandBookById.HandleId, "db_handbook.db", "select BinData from `WeaponHandBook` where Id = ?");
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x001BEA98 File Offset: 0x001BCC98
		public static WeaponHandBook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHandBookById.HandleId, ConfigWeaponHandBookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponHandBook?(WeaponHandBook.GetRootAsWeaponHandBook(configBuffer));
				}
			}
			ConfigWeaponHandBookById.LogPair.Clear();
			ConfigWeaponHandBookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponHandBookById.HandleId, 1, p0Id, ConfigWeaponHandBookById.LogPair) || ConfigCommon.Step(ConfigWeaponHandBookById.HandleId, true, ConfigWeaponHandBookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponHandBookById.HandleId, ConfigWeaponHandBookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHandBookById.HandleId, 0, ConfigWeaponHandBookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponHandBookById.HandleId, ConfigWeaponHandBookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponHandBook rootAsWeaponHandBook = WeaponHandBook.GetRootAsWeaponHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHandBookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponHandBookById.HandleId, ConfigWeaponHandBookById.LogPair);
			return new WeaponHandBook?(rootAsWeaponHandBook);
		}

		// Token: 0x0400495F RID: 18783
		private const string DB = "db_handbook.db";

		// Token: 0x04004960 RID: 18784
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04004961 RID: 18785
		private const string TABLE = "WeaponHandBook";

		// Token: 0x04004962 RID: 18786
		private const string COMMAND = "select BinData from `WeaponHandBook` where Id = ?";

		// Token: 0x04004963 RID: 18787
		private const string KEY_PREFIX = "WeaponHandBookById";

		// Token: 0x04004964 RID: 18788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004965 RID: 18789
		private static int HandleId;
	}
}
