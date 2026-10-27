using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022A RID: 554
	public class ConfigDrinksFlavorRangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D00 RID: 3328 RVA: 0x000A30A7 File Offset: 0x000A12A7
		static ConfigDrinksFlavorRangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorRangeById.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorRangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000A30C8 File Offset: 0x000A12C8
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

		// Token: 0x06000D02 RID: 3330 RVA: 0x000A3147 File Offset: 0x000A1347
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeById.LogPair = null;
			ConfigDrinksFlavorRangeById.HandleId = 0;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000A3155 File Offset: 0x000A1355
		public static void Init()
		{
			ConfigDrinksFlavorRangeById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorRangeById.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorRange` where Id=?");
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000A3170 File Offset: 0x000A1370
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

		// Token: 0x04000F0A RID: 3850
		private const string DB = "db_drinks.db";

		// Token: 0x04000F0B RID: 3851
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F0C RID: 3852
		private const string TABLE = "DrinksFlavorRange";

		// Token: 0x04000F0D RID: 3853
		private const string COMMAND = "select BinData from `DrinksFlavorRange` where Id=?";

		// Token: 0x04000F0E RID: 3854
		private const string KEY_PREFIX = "DrinksFlavorRangeById";

		// Token: 0x04000F0F RID: 3855
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F10 RID: 3856
		private static int HandleId;
	}
}
