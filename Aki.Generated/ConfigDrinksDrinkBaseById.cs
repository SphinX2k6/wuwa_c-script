using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000226 RID: 550
	public class ConfigDrinksDrinkBaseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CE8 RID: 3304 RVA: 0x000A284B File Offset: 0x000A0A4B
		static ConfigDrinksDrinkBaseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkBaseById.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkBaseById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000A286C File Offset: 0x000A0A6C
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksDrinkBaseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksDrinkBase"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksDrinkBase` where Id=?")
			});
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000A28EB File Offset: 0x000A0AEB
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseById.LogPair = null;
			ConfigDrinksDrinkBaseById.HandleId = 0;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000A28F9 File Offset: 0x000A0AF9
		public static void Init()
		{
			ConfigDrinksDrinkBaseById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkBaseById.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkBase` where Id=?");
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000A2914 File Offset: 0x000A0B14
		public static DrinksDrinkBase? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksDrinkBaseById.HandleId, ConfigDrinksDrinkBaseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksDrinkBaseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksDrinkBase?(DrinksDrinkBase.GetRootAsDrinksDrinkBase(configBuffer));
				}
			}
			ConfigDrinksDrinkBaseById.LogPair.Clear();
			ConfigDrinksDrinkBaseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksDrinkBaseById.HandleId, 1, p0Id, ConfigDrinksDrinkBaseById.LogPair) || ConfigCommon.Step(ConfigDrinksDrinkBaseById.HandleId, true, ConfigDrinksDrinkBaseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksDrinkBaseById.HandleId, ConfigDrinksDrinkBaseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksDrinkBaseById.HandleId, 0, ConfigDrinksDrinkBaseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksDrinkBaseById.HandleId, ConfigDrinksDrinkBaseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksDrinkBase rootAsDrinksDrinkBase = DrinksDrinkBase.GetRootAsDrinksDrinkBase(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksDrinkBaseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksDrinkBaseById.HandleId, ConfigDrinksDrinkBaseById.LogPair);
			return new DrinksDrinkBase?(rootAsDrinksDrinkBase);
		}

		// Token: 0x04000EEE RID: 3822
		private const string DB = "db_drinks.db";

		// Token: 0x04000EEF RID: 3823
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EF0 RID: 3824
		private const string TABLE = "DrinksDrinkBase";

		// Token: 0x04000EF1 RID: 3825
		private const string COMMAND = "select BinData from `DrinksDrinkBase` where Id=?";

		// Token: 0x04000EF2 RID: 3826
		private const string KEY_PREFIX = "DrinksDrinkBaseById";

		// Token: 0x04000EF3 RID: 3827
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EF4 RID: 3828
		private static int HandleId;
	}
}
