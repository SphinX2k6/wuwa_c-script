using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001ED RID: 493
	public class ConfigDangoMonopolyPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x0009B0FB File Offset: 0x000992FB
		static ConfigDangoMonopolyPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyPropertyById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0009B11C File Offset: 0x0009931C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyProperty` where Id=?")
			});
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0009B19B File Offset: 0x0009939B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyById.LogPair = null;
			ConfigDangoMonopolyPropertyById.HandleId = 0;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0009B1A9 File Offset: 0x000993A9
		public static void Init()
		{
			ConfigDangoMonopolyPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyPropertyById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyProperty` where Id=?");
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0009B1C4 File Offset: 0x000993C4
		public static DangoMonopolyProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyPropertyById.HandleId, ConfigDangoMonopolyPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopolyProperty?(DangoMonopolyProperty.GetRootAsDangoMonopolyProperty(configBuffer));
				}
			}
			ConfigDangoMonopolyPropertyById.LogPair.Clear();
			ConfigDangoMonopolyPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyPropertyById.HandleId, 1, p0Id, ConfigDangoMonopolyPropertyById.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyPropertyById.HandleId, true, ConfigDangoMonopolyPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyPropertyById.HandleId, ConfigDangoMonopolyPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyPropertyById.HandleId, 0, ConfigDangoMonopolyPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyPropertyById.HandleId, ConfigDangoMonopolyPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopolyProperty rootAsDangoMonopolyProperty = DangoMonopolyProperty.GetRootAsDangoMonopolyProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyPropertyById.HandleId, ConfigDangoMonopolyPropertyById.LogPair);
			return new DangoMonopolyProperty?(rootAsDangoMonopolyProperty);
		}

		// Token: 0x04000D5F RID: 3423
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D60 RID: 3424
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D61 RID: 3425
		private const string TABLE = "DangoMonopolyProperty";

		// Token: 0x04000D62 RID: 3426
		private const string COMMAND = "select BinData from `DangoMonopolyProperty` where Id=?";

		// Token: 0x04000D63 RID: 3427
		private const string KEY_PREFIX = "DangoMonopolyPropertyById";

		// Token: 0x04000D64 RID: 3428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D65 RID: 3429
		private static int HandleId;
	}
}
