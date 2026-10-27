using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E9 RID: 489
	public class ConfigDangoMonopolyByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x0009A7FC File Offset: 0x000989FC
		static ConfigDangoMonopolyByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0009A81C File Offset: 0x00098A1C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopoly"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopoly` where ActivityId=?")
			});
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0009A89B File Offset: 0x00098A9B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyByActivityId.LogPair = null;
			ConfigDangoMonopolyByActivityId.HandleId = 0;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0009A8A9 File Offset: 0x00098AA9
		public static void Init()
		{
			ConfigDangoMonopolyByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyByActivityId.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopoly` where ActivityId=?");
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0009A8C4 File Offset: 0x00098AC4
		public static DangoMonopoly? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyByActivityId.HandleId, ConfigDangoMonopolyByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopoly?(DangoMonopoly.GetRootAsDangoMonopoly(configBuffer));
				}
			}
			ConfigDangoMonopolyByActivityId.LogPair.Clear();
			ConfigDangoMonopolyByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyByActivityId.HandleId, 1, p0ActivityId, ConfigDangoMonopolyByActivityId.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyByActivityId.HandleId, true, ConfigDangoMonopolyByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyByActivityId.HandleId, ConfigDangoMonopolyByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyByActivityId.HandleId, 0, ConfigDangoMonopolyByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyByActivityId.HandleId, ConfigDangoMonopolyByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopoly rootAsDangoMonopoly = DangoMonopoly.GetRootAsDangoMonopoly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyByActivityId.HandleId, ConfigDangoMonopolyByActivityId.LogPair);
			return new DangoMonopoly?(rootAsDangoMonopoly);
		}

		// Token: 0x04000D43 RID: 3395
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D44 RID: 3396
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D45 RID: 3397
		private const string TABLE = "DangoMonopoly";

		// Token: 0x04000D46 RID: 3398
		private const string COMMAND = "select BinData from `DangoMonopoly` where ActivityId=?";

		// Token: 0x04000D47 RID: 3399
		private const string KEY_PREFIX = "DangoMonopolyByActivityId";

		// Token: 0x04000D48 RID: 3400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D49 RID: 3401
		private static int HandleId;
	}
}
