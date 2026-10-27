using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022B RID: 555
	public class ConfigDrinksFlavorTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x000A32F0 File Offset: 0x000A14F0
		static ConfigDrinksFlavorTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorTypeById.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000A3310 File Offset: 0x000A1510
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksFlavorTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksFlavorTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksFlavorType"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksFlavorType` where Id=?")
			});
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000A338F File Offset: 0x000A158F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorTypeById.LogPair = null;
			ConfigDrinksFlavorTypeById.HandleId = 0;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000A339D File Offset: 0x000A159D
		public static void Init()
		{
			ConfigDrinksFlavorTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorTypeById.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorType` where Id=?");
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000A33B8 File Offset: 0x000A15B8
		public static DrinksFlavorType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksFlavorTypeById.HandleId, ConfigDrinksFlavorTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksFlavorType?(DrinksFlavorType.GetRootAsDrinksFlavorType(configBuffer));
				}
			}
			ConfigDrinksFlavorTypeById.LogPair.Clear();
			ConfigDrinksFlavorTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksFlavorTypeById.HandleId, 1, p0Id, ConfigDrinksFlavorTypeById.LogPair) || ConfigCommon.Step(ConfigDrinksFlavorTypeById.HandleId, true, ConfigDrinksFlavorTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksFlavorTypeById.HandleId, ConfigDrinksFlavorTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksFlavorTypeById.HandleId, 0, ConfigDrinksFlavorTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksFlavorTypeById.HandleId, ConfigDrinksFlavorTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksFlavorType rootAsDrinksFlavorType = DrinksFlavorType.GetRootAsDrinksFlavorType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksFlavorTypeById.HandleId, ConfigDrinksFlavorTypeById.LogPair);
			return new DrinksFlavorType?(rootAsDrinksFlavorType);
		}

		// Token: 0x04000F11 RID: 3857
		private const string DB = "db_drinks.db";

		// Token: 0x04000F12 RID: 3858
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F13 RID: 3859
		private const string TABLE = "DrinksFlavorType";

		// Token: 0x04000F14 RID: 3860
		private const string COMMAND = "select BinData from `DrinksFlavorType` where Id=?";

		// Token: 0x04000F15 RID: 3861
		private const string KEY_PREFIX = "DrinksFlavorTypeById";

		// Token: 0x04000F16 RID: 3862
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F17 RID: 3863
		private static int HandleId;
	}
}
