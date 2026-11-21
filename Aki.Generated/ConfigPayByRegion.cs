using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000653 RID: 1619
	public class ConfigPayByRegion : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x0013416E File Offset: 0x0013236E
		static ConfigPayByRegion()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayByRegion.CreateStaticDefaultValue), new Action(ConfigPayByRegion.ResetStaticDefaultValue));
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00134190 File Offset: 0x00132390
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

		// Token: 0x06002604 RID: 9732 RVA: 0x0013420F File Offset: 0x0013240F
		public static void ResetStaticDefaultValue()
		{
			ConfigPayByRegion.LogPair = null;
			ConfigPayByRegion.HandleId = 0;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0013421D File Offset: 0x0013241D
		public static void Init()
		{
			ConfigPayByRegion.HandleId = ConfigCommon.InitDataStatement(ConfigPayByRegion.HandleId, "db_paycurrency.db", "select BinData from `Pay` where Region=?");
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00134238 File Offset: 0x00132438
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

		// Token: 0x04002C2B RID: 11307
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C2C RID: 11308
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C2D RID: 11309
		private const string TABLE = "Pay";

		// Token: 0x04002C2E RID: 11310
		private const string COMMAND = "select BinData from `Pay` where Region=?";

		// Token: 0x04002C2F RID: 11311
		private const string KEY_PREFIX = "PayByRegion";

		// Token: 0x04002C30 RID: 11312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C31 RID: 11313
		private static int HandleId;
	}
}
