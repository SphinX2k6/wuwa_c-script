using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000238 RID: 568
	public class ConfigDrinksDrinkBaseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x000A8783 File Offset: 0x000A6983
		static ConfigDrinksDrinkBaseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkBaseById.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkBaseById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000A87A4 File Offset: 0x000A69A4
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

		// Token: 0x06000D56 RID: 3414 RVA: 0x000A8823 File Offset: 0x000A6A23
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseById.LogPair = null;
			ConfigDrinksDrinkBaseById.HandleId = 0;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000A8831 File Offset: 0x000A6A31
		public static void Init()
		{
			ConfigDrinksDrinkBaseById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkBaseById.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkBase` where Id=?");
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000A884C File Offset: 0x000A6A4C
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

		// Token: 0x04000F6C RID: 3948
		private const string DB = "db_drinks.db";

		// Token: 0x04000F6D RID: 3949
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F6E RID: 3950
		private const string TABLE = "DrinksDrinkBase";

		// Token: 0x04000F6F RID: 3951
		private const string COMMAND = "select BinData from `DrinksDrinkBase` where Id=?";

		// Token: 0x04000F70 RID: 3952
		private const string KEY_PREFIX = "DrinksDrinkBaseById";

		// Token: 0x04000F71 RID: 3953
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F72 RID: 3954
		private static int HandleId;
	}
}
