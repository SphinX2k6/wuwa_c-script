using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FB RID: 507
	public class ConfigDangoMonopolyByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x000A0734 File Offset: 0x0009E934
		static ConfigDangoMonopolyByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000A0754 File Offset: 0x0009E954
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

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000A07D3 File Offset: 0x0009E9D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyByActivityId.LogPair = null;
			ConfigDangoMonopolyByActivityId.HandleId = 0;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000A07E1 File Offset: 0x0009E9E1
		public static void Init()
		{
			ConfigDangoMonopolyByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyByActivityId.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopoly` where ActivityId=?");
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000A07FC File Offset: 0x0009E9FC
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

		// Token: 0x04000DC1 RID: 3521
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DC2 RID: 3522
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DC3 RID: 3523
		private const string TABLE = "DangoMonopoly";

		// Token: 0x04000DC4 RID: 3524
		private const string COMMAND = "select BinData from `DangoMonopoly` where ActivityId=?";

		// Token: 0x04000DC5 RID: 3525
		private const string KEY_PREFIX = "DangoMonopolyByActivityId";

		// Token: 0x04000DC6 RID: 3526
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DC7 RID: 3527
		private static int HandleId;
	}
}
