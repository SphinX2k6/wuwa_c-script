using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A86 RID: 2694
	public class ConfigWeaponQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F38 RID: 16184 RVA: 0x001BFB62 File Offset: 0x001BDD62
		static ConfigWeaponQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponQualityInfoById.CreateStaticDefaultValue), new Action(ConfigWeaponQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x001BFB84 File Offset: 0x001BDD84
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponQualityInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponQualityInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponQualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponQualityInfo` where Id =?")
			});
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x001BFC03 File Offset: 0x001BDE03
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponQualityInfoById.LogPair = null;
			ConfigWeaponQualityInfoById.HandleId = 0;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x001BFC11 File Offset: 0x001BDE11
		public static void Init()
		{
			ConfigWeaponQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponQualityInfoById.HandleId, "db_weapon.db", "select BinData from `WeaponQualityInfo` where Id =?");
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x001BFC2C File Offset: 0x001BDE2C
		public static WeaponQualityInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponQualityInfo?(WeaponQualityInfo.GetRootAsWeaponQualityInfo(configBuffer));
				}
			}
			ConfigWeaponQualityInfoById.LogPair.Clear();
			ConfigWeaponQualityInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponQualityInfoById.HandleId, 1, p0Id, ConfigWeaponQualityInfoById.LogPair) || ConfigCommon.Step(ConfigWeaponQualityInfoById.HandleId, true, ConfigWeaponQualityInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponQualityInfoById.HandleId, 0, ConfigWeaponQualityInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponQualityInfo rootAsWeaponQualityInfo = WeaponQualityInfo.GetRootAsWeaponQualityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponQualityInfoById.HandleId, ConfigWeaponQualityInfoById.LogPair);
			return new WeaponQualityInfo?(rootAsWeaponQualityInfo);
		}

		// Token: 0x04004990 RID: 18832
		private const string DB = "db_weapon.db";

		// Token: 0x04004991 RID: 18833
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004992 RID: 18834
		private const string TABLE = "WeaponQualityInfo";

		// Token: 0x04004993 RID: 18835
		private const string COMMAND = "select BinData from `WeaponQualityInfo` where Id =?";

		// Token: 0x04004994 RID: 18836
		private const string KEY_PREFIX = "WeaponQualityInfoById";

		// Token: 0x04004995 RID: 18837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004996 RID: 18838
		private static int HandleId;
	}
}
