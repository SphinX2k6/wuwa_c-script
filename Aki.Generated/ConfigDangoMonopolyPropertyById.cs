using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FF RID: 511
	public class ConfigDangoMonopolyPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x000A1033 File Offset: 0x0009F233
		static ConfigDangoMonopolyPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyPropertyById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000A1054 File Offset: 0x0009F254
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

		// Token: 0x06000BFF RID: 3071 RVA: 0x000A10D3 File Offset: 0x0009F2D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyPropertyById.LogPair = null;
			ConfigDangoMonopolyPropertyById.HandleId = 0;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000A10E1 File Offset: 0x0009F2E1
		public static void Init()
		{
			ConfigDangoMonopolyPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyPropertyById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyProperty` where Id=?");
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000A10FC File Offset: 0x0009F2FC
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

		// Token: 0x04000DDD RID: 3549
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DDE RID: 3550
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DDF RID: 3551
		private const string TABLE = "DangoMonopolyProperty";

		// Token: 0x04000DE0 RID: 3552
		private const string COMMAND = "select BinData from `DangoMonopolyProperty` where Id=?";

		// Token: 0x04000DE1 RID: 3553
		private const string KEY_PREFIX = "DangoMonopolyPropertyById";

		// Token: 0x04000DE2 RID: 3554
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DE3 RID: 3555
		private static int HandleId;
	}
}
