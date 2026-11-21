using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5C RID: 2908
	public class ConfigWeaponResonByResonIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600443C RID: 17468 RVA: 0x001DF140 File Offset: 0x001DD340
		static ConfigWeaponResonByResonIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponResonByResonIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponResonByResonIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x001DF160 File Offset: 0x001DD360
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponResonByResonIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponResonByResonIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponReson"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponReson` where ResonId = ? AND Level = ?")
			});
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x001DF1DF File Offset: 0x001DD3DF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponResonByResonIdAndLevel.LogPair = null;
			ConfigWeaponResonByResonIdAndLevel.HandleId = 0;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001DF1ED File Offset: 0x001DD3ED
		public static void Init()
		{
			ConfigWeaponResonByResonIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponResonByResonIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponReson` where ResonId = ? AND Level = ?");
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001DF208 File Offset: 0x001DD408
		public static WeaponReson? GetConfig(int p0ResonId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponResonByResonIdAndLevel.HandleId, ConfigWeaponResonByResonIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponResonByResonIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ResonId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponReson?(WeaponReson.GetRootAsWeaponReson(configBuffer));
				}
			}
			ConfigWeaponResonByResonIdAndLevel.LogPair.Clear();
			ConfigWeaponResonByResonIdAndLevel.LogPair.Add(new ValueTuple<string, object>("ResonId", p0ResonId));
			ConfigWeaponResonByResonIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigWeaponResonByResonIdAndLevel.HandleId, 1, p0ResonId, ConfigWeaponResonByResonIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigWeaponResonByResonIdAndLevel.HandleId, 2, p1Level, ConfigWeaponResonByResonIdAndLevel.LogPair) || ConfigCommon.Step(ConfigWeaponResonByResonIdAndLevel.HandleId, true, ConfigWeaponResonByResonIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponResonByResonIdAndLevel.HandleId, ConfigWeaponResonByResonIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponResonByResonIdAndLevel.HandleId, 0, ConfigWeaponResonByResonIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponResonByResonIdAndLevel.HandleId, ConfigWeaponResonByResonIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponReson rootAsWeaponReson = WeaponReson.GetRootAsWeaponReson(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponResonByResonIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ResonId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponResonByResonIdAndLevel.HandleId, ConfigWeaponResonByResonIdAndLevel.LogPair);
			return new WeaponReson?(rootAsWeaponReson);
		}

		// Token: 0x04004F6A RID: 20330
		private const string DB = "db_weapon.db";

		// Token: 0x04004F6B RID: 20331
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F6C RID: 20332
		private const string TABLE = "WeaponReson";

		// Token: 0x04004F6D RID: 20333
		private const string COMMAND = "select BinData from `WeaponReson` where ResonId = ? AND Level = ?";

		// Token: 0x04004F6E RID: 20334
		private const string KEY_PREFIX = "WeaponResonByResonIdAndLevel";

		// Token: 0x04004F6F RID: 20335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F70 RID: 20336
		private static int HandleId;
	}
}
