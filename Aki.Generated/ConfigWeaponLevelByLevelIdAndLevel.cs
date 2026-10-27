using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A83 RID: 2691
	public class ConfigWeaponLevelByLevelIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F26 RID: 16166 RVA: 0x001BF38B File Offset: 0x001BD58B
		static ConfigWeaponLevelByLevelIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponLevelByLevelIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponLevelByLevelIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x001BF3AC File Offset: 0x001BD5AC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponLevelByLevelIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponLevel` where LevelId = ? AND Level =?")
			});
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x001BF42B File Offset: 0x001BD62B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelIdAndLevel.LogPair = null;
			ConfigWeaponLevelByLevelIdAndLevel.HandleId = 0;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x001BF439 File Offset: 0x001BD639
		public static void Init()
		{
			ConfigWeaponLevelByLevelIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponLevelByLevelIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponLevel` where LevelId = ? AND Level =?");
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x001BF454 File Offset: 0x001BD654
		public static WeaponLevel? GetConfig(int p0LevelId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponLevelByLevelIdAndLevel.HandleId, ConfigWeaponLevelByLevelIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponLevelByLevelIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponLevel?(WeaponLevel.GetRootAsWeaponLevel(configBuffer));
				}
			}
			ConfigWeaponLevelByLevelIdAndLevel.LogPair.Clear();
			ConfigWeaponLevelByLevelIdAndLevel.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			ConfigWeaponLevelByLevelIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigWeaponLevelByLevelIdAndLevel.HandleId, 1, p0LevelId, ConfigWeaponLevelByLevelIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigWeaponLevelByLevelIdAndLevel.HandleId, 2, p1Level, ConfigWeaponLevelByLevelIdAndLevel.LogPair) || ConfigCommon.Step(ConfigWeaponLevelByLevelIdAndLevel.HandleId, true, ConfigWeaponLevelByLevelIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponLevelByLevelIdAndLevel.HandleId, ConfigWeaponLevelByLevelIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponLevelByLevelIdAndLevel.HandleId, 0, ConfigWeaponLevelByLevelIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponLevelByLevelIdAndLevel.HandleId, ConfigWeaponLevelByLevelIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponLevel rootAsWeaponLevel = WeaponLevel.GetRootAsWeaponLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponLevelByLevelIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponLevelByLevelIdAndLevel.HandleId, ConfigWeaponLevelByLevelIdAndLevel.LogPair);
			return new WeaponLevel?(rootAsWeaponLevel);
		}

		// Token: 0x0400497B RID: 18811
		private const string DB = "db_weapon.db";

		// Token: 0x0400497C RID: 18812
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x0400497D RID: 18813
		private const string TABLE = "WeaponLevel";

		// Token: 0x0400497E RID: 18814
		private const string COMMAND = "select BinData from `WeaponLevel` where LevelId = ? AND Level =?";

		// Token: 0x0400497F RID: 18815
		private const string KEY_PREFIX = "WeaponLevelByLevelIdAndLevel";

		// Token: 0x04004980 RID: 18816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004981 RID: 18817
		private static int HandleId;
	}
}
