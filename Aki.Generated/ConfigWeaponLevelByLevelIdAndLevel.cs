using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B58 RID: 2904
	public class ConfigWeaponLevelByLevelIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004424 RID: 17444 RVA: 0x001DE71F File Offset: 0x001DC91F
		static ConfigWeaponLevelByLevelIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponLevelByLevelIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponLevelByLevelIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x001DE740 File Offset: 0x001DC940
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

		// Token: 0x06004426 RID: 17446 RVA: 0x001DE7BF File Offset: 0x001DC9BF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelIdAndLevel.LogPair = null;
			ConfigWeaponLevelByLevelIdAndLevel.HandleId = 0;
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x001DE7CD File Offset: 0x001DC9CD
		public static void Init()
		{
			ConfigWeaponLevelByLevelIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponLevelByLevelIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponLevel` where LevelId = ? AND Level =?");
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x001DE7E8 File Offset: 0x001DC9E8
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

		// Token: 0x04004F4E RID: 20302
		private const string DB = "db_weapon.db";

		// Token: 0x04004F4F RID: 20303
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F50 RID: 20304
		private const string TABLE = "WeaponLevel";

		// Token: 0x04004F51 RID: 20305
		private const string COMMAND = "select BinData from `WeaponLevel` where LevelId = ? AND Level =?";

		// Token: 0x04004F52 RID: 20306
		private const string KEY_PREFIX = "WeaponLevelByLevelIdAndLevel";

		// Token: 0x04004F53 RID: 20307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F54 RID: 20308
		private static int HandleId;
	}
}
