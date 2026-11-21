using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4E RID: 2894
	public class ConfigWeaponBreachByBreachIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043E8 RID: 17384 RVA: 0x001DD0D7 File Offset: 0x001DB2D7
		static ConfigWeaponBreachByBreachIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponBreachByBreachIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponBreachByBreachIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x001DD0F8 File Offset: 0x001DB2F8
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponBreachByBreachIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponBreach` where BreachId = ? AND Level = ?")
			});
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x001DD177 File Offset: 0x001DB377
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachIdAndLevel.LogPair = null;
			ConfigWeaponBreachByBreachIdAndLevel.HandleId = 0;
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x001DD185 File Offset: 0x001DB385
		public static void Init()
		{
			ConfigWeaponBreachByBreachIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponBreachByBreachIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponBreach` where BreachId = ? AND Level = ?");
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x001DD1A0 File Offset: 0x001DB3A0
		public static WeaponBreach? GetConfig(int p0BreachId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponBreachByBreachIdAndLevel.HandleId, ConfigWeaponBreachByBreachIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponBreachByBreachIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponBreach?(WeaponBreach.GetRootAsWeaponBreach(configBuffer));
				}
			}
			ConfigWeaponBreachByBreachIdAndLevel.LogPair.Clear();
			ConfigWeaponBreachByBreachIdAndLevel.LogPair.Add(new ValueTuple<string, object>("BreachId", p0BreachId));
			ConfigWeaponBreachByBreachIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigWeaponBreachByBreachIdAndLevel.HandleId, 1, p0BreachId, ConfigWeaponBreachByBreachIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigWeaponBreachByBreachIdAndLevel.HandleId, 2, p1Level, ConfigWeaponBreachByBreachIdAndLevel.LogPair) || ConfigCommon.Step(ConfigWeaponBreachByBreachIdAndLevel.HandleId, true, ConfigWeaponBreachByBreachIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponBreachByBreachIdAndLevel.HandleId, ConfigWeaponBreachByBreachIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponBreachByBreachIdAndLevel.HandleId, 0, ConfigWeaponBreachByBreachIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponBreachByBreachIdAndLevel.HandleId, ConfigWeaponBreachByBreachIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponBreach rootAsWeaponBreach = WeaponBreach.GetRootAsWeaponBreach(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponBreachByBreachIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponBreachByBreachIdAndLevel.HandleId, ConfigWeaponBreachByBreachIdAndLevel.LogPair);
			return new WeaponBreach?(rootAsWeaponBreach);
		}

		// Token: 0x04004F08 RID: 20232
		private const string DB = "db_weapon.db";

		// Token: 0x04004F09 RID: 20233
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F0A RID: 20234
		private const string TABLE = "WeaponBreach";

		// Token: 0x04004F0B RID: 20235
		private const string COMMAND = "select BinData from `WeaponBreach` where BreachId = ? AND Level = ?";

		// Token: 0x04004F0C RID: 20236
		private const string KEY_PREFIX = "WeaponBreachByBreachIdAndLevel";

		// Token: 0x04004F0D RID: 20237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F0E RID: 20238
		private static int HandleId;
	}
}
