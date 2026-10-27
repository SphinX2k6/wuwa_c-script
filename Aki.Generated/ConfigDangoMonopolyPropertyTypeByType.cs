using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EE RID: 494
	public class ConfigDangoMonopolyPropertyTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x0009B344 File Offset: 0x00099544
		static ConfigDangoMonopolyPropertyTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyPropertyTypeByType.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyPropertyTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0009B364 File Offset: 0x00099564
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

		// Token: 0x06000B99 RID: 2969 RVA: 0x0009B3E3 File Offset: 0x000995E3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyTypeByType.LogPair = null;
			ConfigDangoMonopolyPropertyTypeByType.HandleId = 0;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0009B3F1 File Offset: 0x000995F1
		public static void Init()
		{
			ConfigDangoMonopolyPropertyTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyPropertyTypeByType.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyPropertyType` where PropertyType=?");
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0009B40C File Offset: 0x0009960C
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

		// Token: 0x04000D66 RID: 3430
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D67 RID: 3431
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D68 RID: 3432
		private const string TABLE = "DangoMonopolyPropertyType";

		// Token: 0x04000D69 RID: 3433
		private const string COMMAND = "select BinData from `DangoMonopolyPropertyType` where PropertyType=?";

		// Token: 0x04000D6A RID: 3434
		private const string KEY_PREFIX = "DangoMonopolyPropertyTypeByType";

		// Token: 0x04000D6B RID: 3435
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D6C RID: 3436
		private static int HandleId;
	}
}
