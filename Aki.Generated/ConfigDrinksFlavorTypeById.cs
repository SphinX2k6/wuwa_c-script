using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023D RID: 573
	public class ConfigDrinksFlavorTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D72 RID: 3442 RVA: 0x000A9228 File Offset: 0x000A7428
		static ConfigDrinksFlavorTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorTypeById.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000A9248 File Offset: 0x000A7448
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

		// Token: 0x06000D74 RID: 3444 RVA: 0x000A92C7 File Offset: 0x000A74C7
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorTypeById.LogPair = null;
			ConfigDrinksFlavorTypeById.HandleId = 0;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000A92D5 File Offset: 0x000A74D5
		public static void Init()
		{
			ConfigDrinksFlavorTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorTypeById.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorType` where Id=?");
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000A92F0 File Offset: 0x000A74F0
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

		// Token: 0x04000F8F RID: 3983
		private const string DB = "db_drinks.db";

		// Token: 0x04000F90 RID: 3984
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F91 RID: 3985
		private const string TABLE = "DrinksFlavorType";

		// Token: 0x04000F92 RID: 3986
		private const string COMMAND = "select BinData from `DrinksFlavorType` where Id=?";

		// Token: 0x04000F93 RID: 3987
		private const string KEY_PREFIX = "DrinksFlavorTypeById";

		// Token: 0x04000F94 RID: 3988
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F95 RID: 3989
		private static int HandleId;
	}
}
