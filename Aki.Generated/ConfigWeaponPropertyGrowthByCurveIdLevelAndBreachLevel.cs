using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A85 RID: 2693
	public class ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F32 RID: 16178 RVA: 0x001BF870 File Offset: 0x001BDA70
		static ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.CreateStaticDefaultValue), new Action(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x001BF890 File Offset: 0x001BDA90
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponPropertyGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponPropertyGrowth` where CurveId = ? AND Level = ? AND BreachLevel = ?")
			});
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x001BF90F File Offset: 0x001BDB0F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair = null;
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId = 0;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x001BF91D File Offset: 0x001BDB1D
		public static void Init()
		{
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, "db_property.db", "select BinData from `WeaponPropertyGrowth` where CurveId = ? AND Level = ? AND BreachLevel = ?");
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001BF938 File Offset: 0x001BDB38
		public static WeaponPropertyGrowth? GetConfig(int p0CurveId, int p1Level, int p2BreachLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponPropertyGrowthByCurveIdLevelAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CurveId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2BreachLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponPropertyGrowth?(WeaponPropertyGrowth.GetRootAsWeaponPropertyGrowth(configBuffer));
				}
			}
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair.Clear();
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("CurveId", p0CurveId));
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachLevel", p2BreachLevel));
			if (!ConfigCommon.BindInt(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, 1, p0CurveId, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair) || !ConfigCommon.BindInt(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, 2, p1Level, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair) || !ConfigCommon.BindInt(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, 3, p2BreachLevel, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair) || ConfigCommon.Step(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, true, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, 0, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponPropertyGrowth rootAsWeaponPropertyGrowth = WeaponPropertyGrowth.GetRootAsWeaponPropertyGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponPropertyGrowthByCurveIdLevelAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CurveId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2BreachLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.HandleId, ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.LogPair);
			return new WeaponPropertyGrowth?(rootAsWeaponPropertyGrowth);
		}

		// Token: 0x04004989 RID: 18825
		private const string DB = "db_property.db";

		// Token: 0x0400498A RID: 18826
		private const string FILE = "s.属性.xlsx";

		// Token: 0x0400498B RID: 18827
		private const string TABLE = "WeaponPropertyGrowth";

		// Token: 0x0400498C RID: 18828
		private const string COMMAND = "select BinData from `WeaponPropertyGrowth` where CurveId = ? AND Level = ? AND BreachLevel = ?";

		// Token: 0x0400498D RID: 18829
		private const string KEY_PREFIX = "WeaponPropertyGrowthByCurveIdLevelAndBreachLevel";

		// Token: 0x0400498E RID: 18830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400498F RID: 18831
		private static int HandleId;
	}
}
