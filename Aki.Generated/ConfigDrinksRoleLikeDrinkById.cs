using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000245 RID: 581
	public class ConfigDrinksRoleLikeDrinkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DA2 RID: 3490 RVA: 0x000AA2F0 File Offset: 0x000A84F0
		static ConfigDrinksRoleLikeDrinkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleLikeDrinkById.CreateStaticDefaultValue), new Action(ConfigDrinksRoleLikeDrinkById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000AA310 File Offset: 0x000A8510
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000AA38F File Offset: 0x000A858F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleLikeDrinkById.LogPair = null;
			ConfigDrinksRoleLikeDrinkById.HandleId = 0;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000AA39D File Offset: 0x000A859D
		public static void Init()
		{
			ConfigDrinksRoleLikeDrinkById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleLikeDrinkById.HandleId, "db_drinks.db", "select BinData from `DrinksRoleLikeDrink` where Id=?");
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000AA3B8 File Offset: 0x000A85B8
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

		// Token: 0x04000FC7 RID: 4039
		private const string DB = "db_drinks.db";

		// Token: 0x04000FC8 RID: 4040
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FC9 RID: 4041
		private const string TABLE = "DrinksRoleLikeDrink";

		// Token: 0x04000FCA RID: 4042
		private const string COMMAND = "select BinData from `DrinksRoleLikeDrink` where Id=?";

		// Token: 0x04000FCB RID: 4043
		private const string KEY_PREFIX = "DrinksRoleLikeDrinkById";

		// Token: 0x04000FCC RID: 4044
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FCD RID: 4045
		private static int HandleId;
	}
}
