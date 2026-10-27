using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A87 RID: 2695
	public class ConfigWeaponResonByResonIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F3E RID: 16190 RVA: 0x001BFDAC File Offset: 0x001BDFAC
		static ConfigWeaponResonByResonIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponResonByResonIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponResonByResonIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x001BFDCC File Offset: 0x001BDFCC
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

		// Token: 0x06003F40 RID: 16192 RVA: 0x001BFE4B File Offset: 0x001BE04B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponResonByResonIdAndLevel.LogPair = null;
			ConfigWeaponResonByResonIdAndLevel.HandleId = 0;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x001BFE59 File Offset: 0x001BE059
		public static void Init()
		{
			ConfigWeaponResonByResonIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponResonByResonIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponReson` where ResonId = ? AND Level = ?");
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x001BFE74 File Offset: 0x001BE074
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

		// Token: 0x04004997 RID: 18839
		private const string DB = "db_weapon.db";

		// Token: 0x04004998 RID: 18840
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004999 RID: 18841
		private const string TABLE = "WeaponReson";

		// Token: 0x0400499A RID: 18842
		private const string COMMAND = "select BinData from `WeaponReson` where ResonId = ? AND Level = ?";

		// Token: 0x0400499B RID: 18843
		private const string KEY_PREFIX = "WeaponResonByResonIdAndLevel";

		// Token: 0x0400499C RID: 18844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400499D RID: 18845
		private static int HandleId;
	}
}
