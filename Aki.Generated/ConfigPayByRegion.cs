using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063B RID: 1595
	public class ConfigPayByRegion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002572 RID: 9586 RVA: 0x0012D6F2 File Offset: 0x0012B8F2
		static ConfigPayByRegion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayByRegion.CreateStaticDefaultValue), new Action(ConfigPayByRegion.ResetStaticDefaultValue));
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0012D714 File Offset: 0x0012B914
		public static void CreateStaticDefaultValue()
		{
			ConfigPayByRegion.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayByRegion.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "Pay"),
				new ValueTuple<string, object>("语句", "select BinData from `Pay` where Region=?")
			});
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0012D793 File Offset: 0x0012B993
		public static void ResetStaticDefaultValue()
		{
			ConfigPayByRegion.LogPair = null;
			ConfigPayByRegion.HandleId = 0;
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0012D7A1 File Offset: 0x0012B9A1
		public static void Init()
		{
			ConfigPayByRegion.HandleId = ConfigCommon.InitDataStatement(ConfigPayByRegion.HandleId, "db_paycurrency.db", "select BinData from `Pay` where Region=?");
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0012D7BC File Offset: 0x0012B9BC
		[return: Nullable(2)]
		public static IReadOnlyList<Pay> GetConfigList(string p0Region, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayByRegion.HandleId, ConfigPayByRegion.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Pay> readOnlyList = (IReadOnlyList<Pay>)ConfigCommon.GetConfig("PayByRegion#" + p0Region);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPayByRegion.LogPair.Clear();
			ConfigPayByRegion.LogPair.Add(new ValueTuple<string, object>("Region", p0Region));
			if (!ConfigCommon.BindString(ConfigPayByRegion.HandleId, 1, p0Region, ConfigPayByRegion.LogPair))
			{
				ConfigCommon.Reset(ConfigPayByRegion.HandleId, ConfigPayByRegion.LogPair);
				return null;
			}
			List<Pay> list = new List<Pay>();
			while (ConfigCommon.Step(ConfigPayByRegion.HandleId, false, ConfigPayByRegion.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayByRegion.HandleId, 0, ConfigPayByRegion.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayByRegion.HandleId, ConfigPayByRegion.LogPair);
					return null;
				}
				Pay rootAsPay = Pay.GetRootAsPay(new ByteBuffer(item2));
				list.Add(rootAsPay);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PayByRegion#" + p0Region, list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayByRegion.HandleId, ConfigPayByRegion.LogPair);
			return list;
		}

		// Token: 0x04002B83 RID: 11139
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B84 RID: 11140
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B85 RID: 11141
		private const string TABLE = "Pay";

		// Token: 0x04002B86 RID: 11142
		private const string COMMAND = "select BinData from `Pay` where Region=?";

		// Token: 0x04002B87 RID: 11143
		private const string KEY_PREFIX = "PayByRegion";

		// Token: 0x04002B88 RID: 11144
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B89 RID: 11145
		private static int HandleId;
	}
}
