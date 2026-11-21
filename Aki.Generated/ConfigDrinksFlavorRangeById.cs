using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023C RID: 572
	public class ConfigDrinksFlavorRangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D6C RID: 3436 RVA: 0x000A8FDF File Offset: 0x000A71DF
		static ConfigDrinksFlavorRangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorRangeById.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorRangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000A9000 File Offset: 0x000A7200
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksFlavorRangeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksFlavorRange"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksFlavorRange` where Id=?")
			});
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000A907F File Offset: 0x000A727F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeById.LogPair = null;
			ConfigDrinksFlavorRangeById.HandleId = 0;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000A908D File Offset: 0x000A728D
		public static void Init()
		{
			ConfigDrinksFlavorRangeById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorRangeById.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorRange` where Id=?");
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000A90A8 File Offset: 0x000A72A8
		public static DrinksFlavorRange? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksFlavorRangeById.HandleId, ConfigDrinksFlavorRangeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorRangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksFlavorRange?(DrinksFlavorRange.GetRootAsDrinksFlavorRange(configBuffer));
				}
			}
			ConfigDrinksFlavorRangeById.LogPair.Clear();
			ConfigDrinksFlavorRangeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksFlavorRangeById.HandleId, 1, p0Id, ConfigDrinksFlavorRangeById.LogPair) || ConfigCommon.Step(ConfigDrinksFlavorRangeById.HandleId, true, ConfigDrinksFlavorRangeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksFlavorRangeById.HandleId, ConfigDrinksFlavorRangeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksFlavorRangeById.HandleId, 0, ConfigDrinksFlavorRangeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksFlavorRangeById.HandleId, ConfigDrinksFlavorRangeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksFlavorRange rootAsDrinksFlavorRange = DrinksFlavorRange.GetRootAsDrinksFlavorRange(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorRangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksFlavorRangeById.HandleId, ConfigDrinksFlavorRangeById.LogPair);
			return new DrinksFlavorRange?(rootAsDrinksFlavorRange);
		}

		// Token: 0x04000F88 RID: 3976
		private const string DB = "db_drinks.db";

		// Token: 0x04000F89 RID: 3977
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F8A RID: 3978
		private const string TABLE = "DrinksFlavorRange";

		// Token: 0x04000F8B RID: 3979
		private const string COMMAND = "select BinData from `DrinksFlavorRange` where Id=?";

		// Token: 0x04000F8C RID: 3980
		private const string KEY_PREFIX = "DrinksFlavorRangeById";

		// Token: 0x04000F8D RID: 3981
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F8E RID: 3982
		private static int HandleId;
	}
}
