using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A79 RID: 2681
	public class ConfigWeaponBreachByBreachIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x001BDD43 File Offset: 0x001BBF43
		static ConfigWeaponBreachByBreachIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponBreachByBreachIdAndLevel.CreateStaticDefaultValue), new Action(ConfigWeaponBreachByBreachIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x001BDD64 File Offset: 0x001BBF64
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

		// Token: 0x06003EEC RID: 16108 RVA: 0x001BDDE3 File Offset: 0x001BBFE3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachIdAndLevel.LogPair = null;
			ConfigWeaponBreachByBreachIdAndLevel.HandleId = 0;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x001BDDF1 File Offset: 0x001BBFF1
		public static void Init()
		{
			ConfigWeaponBreachByBreachIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponBreachByBreachIdAndLevel.HandleId, "db_weapon.db", "select BinData from `WeaponBreach` where BreachId = ? AND Level = ?");
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x001BDE0C File Offset: 0x001BC00C
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

		// Token: 0x04004935 RID: 18741
		private const string DB = "db_weapon.db";

		// Token: 0x04004936 RID: 18742
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004937 RID: 18743
		private const string TABLE = "WeaponBreach";

		// Token: 0x04004938 RID: 18744
		private const string COMMAND = "select BinData from `WeaponBreach` where BreachId = ? AND Level = ?";

		// Token: 0x04004939 RID: 18745
		private const string KEY_PREFIX = "WeaponBreachByBreachIdAndLevel";

		// Token: 0x0400493A RID: 18746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400493B RID: 18747
		private static int HandleId;
	}
}
