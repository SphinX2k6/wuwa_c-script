using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B52 RID: 2898
	public class ConfigWeaponExpItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004400 RID: 17408 RVA: 0x001DD987 File Offset: 0x001DBB87
		static ConfigWeaponExpItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponExpItemById.CreateStaticDefaultValue), new Action(ConfigWeaponExpItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x001DD9A8 File Offset: 0x001DBBA8
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

		// Token: 0x06004402 RID: 17410 RVA: 0x001DDA27 File Offset: 0x001DBC27
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponExpItemById.LogPair = null;
			ConfigWeaponExpItemById.HandleId = 0;
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x001DDA35 File Offset: 0x001DBC35
		public static void Init()
		{
			ConfigWeaponExpItemById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponExpItemById.HandleId, "db_weapon.db", "select BinData from `WeaponExpItem` where Id = ?");
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x001DDA50 File Offset: 0x001DBC50
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

		// Token: 0x04004F24 RID: 20260
		private const string DB = "db_weapon.db";

		// Token: 0x04004F25 RID: 20261
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F26 RID: 20262
		private const string TABLE = "WeaponExpItem";

		// Token: 0x04004F27 RID: 20263
		private const string COMMAND = "select BinData from `WeaponExpItem` where Id = ?";

		// Token: 0x04004F28 RID: 20264
		private const string KEY_PREFIX = "WeaponExpItemById";

		// Token: 0x04004F29 RID: 20265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F2A RID: 20266
		private static int HandleId;
	}
}
