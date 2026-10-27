using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063A RID: 1594
	public class ConfigPayByPayIdAndRegion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x0012D468 File Offset: 0x0012B668
		static ConfigPayByPayIdAndRegion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayByPayIdAndRegion.CreateStaticDefaultValue), new Action(ConfigPayByPayIdAndRegion.ResetStaticDefaultValue));
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0012D488 File Offset: 0x0012B688
		public static void CreateStaticDefaultValue()
		{
			ConfigPayByPayIdAndRegion.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayByPayIdAndRegion.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "Pay"),
				new ValueTuple<string, object>("语句", "select BinData from `Pay` where PayId=? AND Region=?")
			});
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x0012D507 File Offset: 0x0012B707
		public static void ResetStaticDefaultValue()
		{
			ConfigPayByPayIdAndRegion.LogPair = null;
			ConfigPayByPayIdAndRegion.HandleId = 0;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x0012D515 File Offset: 0x0012B715
		public static void Init()
		{
			ConfigPayByPayIdAndRegion.HandleId = ConfigCommon.InitDataStatement(ConfigPayByPayIdAndRegion.HandleId, "db_paycurrency.db", "select BinData from `Pay` where PayId=? AND Region=?");
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x0012D530 File Offset: 0x0012B730
		[return: Nullable(2)]
		public static IReadOnlyList<Pay> GetConfigList(int p0PayId, string p1Region, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayByPayIdAndRegion.HandleId, ConfigPayByPayIdAndRegion.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PayByPayIdAndRegion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Region);
				IReadOnlyList<Pay> readOnlyList = (IReadOnlyList<Pay>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPayByPayIdAndRegion.LogPair.Clear();
			ConfigPayByPayIdAndRegion.LogPair.Add(new ValueTuple<string, object>("PayId", p0PayId));
			ConfigPayByPayIdAndRegion.LogPair.Add(new ValueTuple<string, object>("Region", p1Region));
			if (!ConfigCommon.BindInt(ConfigPayByPayIdAndRegion.HandleId, 1, p0PayId, ConfigPayByPayIdAndRegion.LogPair) || !ConfigCommon.BindString(ConfigPayByPayIdAndRegion.HandleId, 2, p1Region, ConfigPayByPayIdAndRegion.LogPair))
			{
				ConfigCommon.Reset(ConfigPayByPayIdAndRegion.HandleId, ConfigPayByPayIdAndRegion.LogPair);
				return null;
			}
			List<Pay> list = new List<Pay>();
			while (ConfigCommon.Step(ConfigPayByPayIdAndRegion.HandleId, false, ConfigPayByPayIdAndRegion.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayByPayIdAndRegion.HandleId, 0, ConfigPayByPayIdAndRegion.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayByPayIdAndRegion.HandleId, ConfigPayByPayIdAndRegion.LogPair);
					return null;
				}
				Pay rootAsPay = Pay.GetRootAsPay(new ByteBuffer(item2));
				list.Add(rootAsPay);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PayByPayIdAndRegion");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Region);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayByPayIdAndRegion.HandleId, ConfigPayByPayIdAndRegion.LogPair);
			return list;
		}

		// Token: 0x04002B7C RID: 11132
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B7D RID: 11133
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B7E RID: 11134
		private const string TABLE = "Pay";

		// Token: 0x04002B7F RID: 11135
		private const string COMMAND = "select BinData from `Pay` where PayId=? AND Region=?";

		// Token: 0x04002B80 RID: 11136
		private const string KEY_PREFIX = "PayByPayIdAndRegion";

		// Token: 0x04002B81 RID: 11137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B82 RID: 11138
		private static int HandleId;
	}
}
