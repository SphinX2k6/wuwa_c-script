using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B54 RID: 2900
	public class ConfigWeaponHandBookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600440C RID: 17420 RVA: 0x001DDD63 File Offset: 0x001DBF63
		static ConfigWeaponHandBookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHandBookById.CreateStaticDefaultValue), new Action(ConfigWeaponHandBookById.ResetStaticDefaultValue));
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001DDD84 File Offset: 0x001DBF84
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

		// Token: 0x0600440E RID: 17422 RVA: 0x001DDE03 File Offset: 0x001DC003
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHandBookById.LogPair = null;
			ConfigWeaponHandBookById.HandleId = 0;
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x001DDE11 File Offset: 0x001DC011
		public static void Init()
		{
			ConfigWeaponHandBookById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHandBookById.HandleId, "db_handbook.db", "select BinData from `WeaponHandBook` where Id = ?");
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x001DDE2C File Offset: 0x001DC02C
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

		// Token: 0x04004F32 RID: 20274
		private const string DB = "db_handbook.db";

		// Token: 0x04004F33 RID: 20275
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04004F34 RID: 20276
		private const string TABLE = "WeaponHandBook";

		// Token: 0x04004F35 RID: 20277
		private const string COMMAND = "select BinData from `WeaponHandBook` where Id = ?";

		// Token: 0x04004F36 RID: 20278
		private const string KEY_PREFIX = "WeaponHandBookById";

		// Token: 0x04004F37 RID: 20279
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F38 RID: 20280
		private static int HandleId;
	}
}
