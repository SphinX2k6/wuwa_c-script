using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000200 RID: 512
	public class ConfigDangoMonopolyPropertyTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x000A127C File Offset: 0x0009F47C
		static ConfigDangoMonopolyPropertyTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyPropertyTypeByType.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyPropertyTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000A129C File Offset: 0x0009F49C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyTypeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyPropertyTypeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyPropertyType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyPropertyType` where PropertyType=?")
			});
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000A131B File Offset: 0x0009F51B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyTypeByType.LogPair = null;
			ConfigDangoMonopolyPropertyTypeByType.HandleId = 0;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000A1329 File Offset: 0x0009F529
		public static void Init()
		{
			ConfigDangoMonopolyPropertyTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyPropertyTypeByType.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyPropertyType` where PropertyType=?");
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000A1344 File Offset: 0x0009F544
		public static DangoMonopolyPropertyType? GetConfig(int p0PropertyType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyPropertyTypeByType.HandleId, ConfigDangoMonopolyPropertyTypeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyPropertyTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropertyType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopolyPropertyType?(DangoMonopolyPropertyType.GetRootAsDangoMonopolyPropertyType(configBuffer));
				}
			}
			ConfigDangoMonopolyPropertyTypeByType.LogPair.Clear();
			ConfigDangoMonopolyPropertyTypeByType.LogPair.Add(new ValueTuple<string, object>("PropertyType", p0PropertyType));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyPropertyTypeByType.HandleId, 1, p0PropertyType, ConfigDangoMonopolyPropertyTypeByType.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyPropertyTypeByType.HandleId, true, ConfigDangoMonopolyPropertyTypeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyPropertyTypeByType.HandleId, ConfigDangoMonopolyPropertyTypeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyPropertyTypeByType.HandleId, 0, ConfigDangoMonopolyPropertyTypeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyPropertyTypeByType.HandleId, ConfigDangoMonopolyPropertyTypeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopolyPropertyType rootAsDangoMonopolyPropertyType = DangoMonopolyPropertyType.GetRootAsDangoMonopolyPropertyType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyPropertyTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropertyType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyPropertyTypeByType.HandleId, ConfigDangoMonopolyPropertyTypeByType.LogPair);
			return new DangoMonopolyPropertyType?(rootAsDangoMonopolyPropertyType);
		}

		// Token: 0x04000DE4 RID: 3556
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DE5 RID: 3557
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DE6 RID: 3558
		private const string TABLE = "DangoMonopolyPropertyType";

		// Token: 0x04000DE7 RID: 3559
		private const string COMMAND = "select BinData from `DangoMonopolyPropertyType` where PropertyType=?";

		// Token: 0x04000DE8 RID: 3560
		private const string KEY_PREFIX = "DangoMonopolyPropertyTypeByType";

		// Token: 0x04000DE9 RID: 3561
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DEA RID: 3562
		private static int HandleId;
	}
}
