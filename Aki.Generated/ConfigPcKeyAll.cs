using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064A RID: 1610
	public class ConfigPcKeyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025CC RID: 9676 RVA: 0x0012F5DD File Offset: 0x0012D7DD
		static ConfigPcKeyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyAll.CreateStaticDefaultValue), new Action(ConfigPcKeyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x0012F5FC File Offset: 0x0012D7FC
		public static void CreateStaticDefaultValue()
		{
			ConfigPcKeyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPcKeyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_key.db"),
				new ValueTuple<string, object>("文件", "a.按键.xlsx"),
				new ValueTuple<string, object>("表名", "PcKey"),
				new ValueTuple<string, object>("语句", "select BinData from `PcKey`")
			});
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x0012F67B File Offset: 0x0012D87B
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyAll.LogPair = null;
			ConfigPcKeyAll.HandleId = 0;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0012F689 File Offset: 0x0012D889
		public static void Init()
		{
			ConfigPcKeyAll.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyAll.HandleId, "db_key.db", "select BinData from `PcKey`");
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x0012F6A4 File Offset: 0x0012D8A4
		[NullableContext(2)]
		public static IReadOnlyList<PcKey> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPcKeyAll.HandleId, ConfigPcKeyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PcKey> readOnlyList = (IReadOnlyList<PcKey>)ConfigCommon.GetConfig("PcKeyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PcKey> list = new List<PcKey>();
			while (ConfigCommon.Step(ConfigPcKeyAll.HandleId, false, ConfigPcKeyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPcKeyAll.HandleId, 0, ConfigPcKeyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPcKeyAll.HandleId, ConfigPcKeyAll.LogPair);
					return null;
				}
				PcKey rootAsPcKey = PcKey.GetRootAsPcKey(new ByteBuffer(item2));
				list.Add(rootAsPcKey);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PcKeyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPcKeyAll.HandleId, ConfigPcKeyAll.LogPair);
			return list;
		}

		// Token: 0x04002BEC RID: 11244
		private const string DB = "db_key.db";

		// Token: 0x04002BED RID: 11245
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002BEE RID: 11246
		private const string TABLE = "PcKey";

		// Token: 0x04002BEF RID: 11247
		private const string COMMAND = "select BinData from `PcKey`";

		// Token: 0x04002BF0 RID: 11248
		private const string KEY_PREFIX = "PcKeyAll";

		// Token: 0x04002BF1 RID: 11249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BF2 RID: 11250
		private static int HandleId;
	}
}
