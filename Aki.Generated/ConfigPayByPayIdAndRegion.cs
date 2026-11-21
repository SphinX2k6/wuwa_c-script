using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000652 RID: 1618
	public class ConfigPayByPayIdAndRegion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x00133EE4 File Offset: 0x001320E4
		static ConfigPayByPayIdAndRegion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayByPayIdAndRegion.CreateStaticDefaultValue), new Action(ConfigPayByPayIdAndRegion.ResetStaticDefaultValue));
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00133F04 File Offset: 0x00132104
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

		// Token: 0x060025FE RID: 9726 RVA: 0x00133F83 File Offset: 0x00132183
		public static void ResetStaticDefaultValue()
		{
			ConfigPayByPayIdAndRegion.LogPair = null;
			ConfigPayByPayIdAndRegion.HandleId = 0;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00133F91 File Offset: 0x00132191
		public static void Init()
		{
			ConfigPayByPayIdAndRegion.HandleId = ConfigCommon.InitDataStatement(ConfigPayByPayIdAndRegion.HandleId, "db_paycurrency.db", "select BinData from `Pay` where PayId=? AND Region=?");
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00133FAC File Offset: 0x001321AC
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

		// Token: 0x04002C24 RID: 11300
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C25 RID: 11301
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C26 RID: 11302
		private const string TABLE = "Pay";

		// Token: 0x04002C27 RID: 11303
		private const string COMMAND = "select BinData from `Pay` where PayId=? AND Region=?";

		// Token: 0x04002C28 RID: 11304
		private const string KEY_PREFIX = "PayByPayIdAndRegion";

		// Token: 0x04002C29 RID: 11305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C2A RID: 11306
		private static int HandleId;
	}
}
