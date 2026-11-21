using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000662 RID: 1634
	public class ConfigPcKeyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600265C RID: 9820 RVA: 0x00136059 File Offset: 0x00134259
		static ConfigPcKeyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyAll.CreateStaticDefaultValue), new Action(ConfigPcKeyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00136078 File Offset: 0x00134278
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

		// Token: 0x0600265E RID: 9822 RVA: 0x001360F7 File Offset: 0x001342F7
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyAll.LogPair = null;
			ConfigPcKeyAll.HandleId = 0;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00136105 File Offset: 0x00134305
		public static void Init()
		{
			ConfigPcKeyAll.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyAll.HandleId, "db_key.db", "select BinData from `PcKey`");
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00136120 File Offset: 0x00134320
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

		// Token: 0x04002C94 RID: 11412
		private const string DB = "db_key.db";

		// Token: 0x04002C95 RID: 11413
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002C96 RID: 11414
		private const string TABLE = "PcKey";

		// Token: 0x04002C97 RID: 11415
		private const string COMMAND = "select BinData from `PcKey`";

		// Token: 0x04002C98 RID: 11416
		private const string KEY_PREFIX = "PcKeyAll";

		// Token: 0x04002C99 RID: 11417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C9A RID: 11418
		private static int HandleId;
	}
}
