using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D1 RID: 2513
	public class ConfigTermConfigByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AFA RID: 15098 RVA: 0x001A7434 File Offset: 0x001A5634
		static ConfigTermConfigByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermConfigByKey.CreateStaticDefaultValue), new Action(ConfigTermConfigByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001A7454 File Offset: 0x001A5654
		public static void CreateStaticDefaultValue()
		{
			ConfigTermConfigByKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTermConfigByKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_term.db"),
				new ValueTuple<string, object>("文件", "s.术语/*.csv*"),
				new ValueTuple<string, object>("表名", "TermConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TermConfig` where Term=?")
			});
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x001A74D3 File Offset: 0x001A56D3
		public static void ResetStaticDefaultValue()
		{
			ConfigTermConfigByKey.LogPair = null;
			ConfigTermConfigByKey.HandleId = 0;
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x001A74E1 File Offset: 0x001A56E1
		public static void Init()
		{
			ConfigTermConfigByKey.HandleId = ConfigCommon.InitDataStatement(ConfigTermConfigByKey.HandleId, "db_term.db", "select BinData from `TermConfig` where Term=?");
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001A74FC File Offset: 0x001A56FC
		public static TermConfig? GetConfig(string p0Term, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTermConfigByKey.HandleId, ConfigTermConfigByKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TermConfigByKey#" + p0Term);
				if (configBuffer != null)
				{
					return new TermConfig?(TermConfig.GetRootAsTermConfig(configBuffer));
				}
			}
			ConfigTermConfigByKey.LogPair.Clear();
			ConfigTermConfigByKey.LogPair.Add(new ValueTuple<string, object>("Term", p0Term));
			if (!ConfigCommon.BindString(ConfigTermConfigByKey.HandleId, 1, p0Term, ConfigTermConfigByKey.LogPair) || ConfigCommon.Step(ConfigTermConfigByKey.HandleId, true, ConfigTermConfigByKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTermConfigByKey.HandleId, ConfigTermConfigByKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTermConfigByKey.HandleId, 0, ConfigTermConfigByKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTermConfigByKey.HandleId, ConfigTermConfigByKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TermConfig rootAsTermConfig = TermConfig.GetRootAsTermConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TermConfigByKey#" + p0Term, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTermConfigByKey.HandleId, ConfigTermConfigByKey.LogPair);
			return new TermConfig?(rootAsTermConfig);
		}

		// Token: 0x0400449D RID: 17565
		private const string DB = "db_term.db";

		// Token: 0x0400449E RID: 17566
		private const string FILE = "s.术语/*.csv*";

		// Token: 0x0400449F RID: 17567
		private const string TABLE = "TermConfig";

		// Token: 0x040044A0 RID: 17568
		private const string COMMAND = "select BinData from `TermConfig` where Term=?";

		// Token: 0x040044A1 RID: 17569
		private const string KEY_PREFIX = "TermConfigByKey";

		// Token: 0x040044A2 RID: 17570
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044A3 RID: 17571
		private static int HandleId;
	}
}
