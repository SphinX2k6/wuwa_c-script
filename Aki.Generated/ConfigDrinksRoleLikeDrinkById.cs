using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000233 RID: 563
	public class ConfigDrinksRoleLikeDrinkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x000A43B8 File Offset: 0x000A25B8
		static ConfigDrinksRoleLikeDrinkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleLikeDrinkById.CreateStaticDefaultValue), new Action(ConfigDrinksRoleLikeDrinkById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000A43D8 File Offset: 0x000A25D8
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksRoleLikeDrinkById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksRoleLikeDrinkById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksRoleLikeDrink"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksRoleLikeDrink` where Id=?")
			});
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000A4457 File Offset: 0x000A2657
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleLikeDrinkById.LogPair = null;
			ConfigDrinksRoleLikeDrinkById.HandleId = 0;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000A4465 File Offset: 0x000A2665
		public static void Init()
		{
			ConfigDrinksRoleLikeDrinkById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleLikeDrinkById.HandleId, "db_drinks.db", "select BinData from `DrinksRoleLikeDrink` where Id=?");
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000A4480 File Offset: 0x000A2680
		public static DrinksRoleLikeDrink? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksRoleLikeDrinkById.HandleId, ConfigDrinksRoleLikeDrinkById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRoleLikeDrinkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksRoleLikeDrink?(DrinksRoleLikeDrink.GetRootAsDrinksRoleLikeDrink(configBuffer));
				}
			}
			ConfigDrinksRoleLikeDrinkById.LogPair.Clear();
			ConfigDrinksRoleLikeDrinkById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksRoleLikeDrinkById.HandleId, 1, p0Id, ConfigDrinksRoleLikeDrinkById.LogPair) || ConfigCommon.Step(ConfigDrinksRoleLikeDrinkById.HandleId, true, ConfigDrinksRoleLikeDrinkById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksRoleLikeDrinkById.HandleId, ConfigDrinksRoleLikeDrinkById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksRoleLikeDrinkById.HandleId, 0, ConfigDrinksRoleLikeDrinkById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksRoleLikeDrinkById.HandleId, ConfigDrinksRoleLikeDrinkById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksRoleLikeDrink rootAsDrinksRoleLikeDrink = DrinksRoleLikeDrink.GetRootAsDrinksRoleLikeDrink(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRoleLikeDrinkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksRoleLikeDrinkById.HandleId, ConfigDrinksRoleLikeDrinkById.LogPair);
			return new DrinksRoleLikeDrink?(rootAsDrinksRoleLikeDrink);
		}

		// Token: 0x04000F49 RID: 3913
		private const string DB = "db_drinks.db";

		// Token: 0x04000F4A RID: 3914
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F4B RID: 3915
		private const string TABLE = "DrinksRoleLikeDrink";

		// Token: 0x04000F4C RID: 3916
		private const string COMMAND = "select BinData from `DrinksRoleLikeDrink` where Id=?";

		// Token: 0x04000F4D RID: 3917
		private const string KEY_PREFIX = "DrinksRoleLikeDrinkById";

		// Token: 0x04000F4E RID: 3918
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F4F RID: 3919
		private static int HandleId;
	}
}
