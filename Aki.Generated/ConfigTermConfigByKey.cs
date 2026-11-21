using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA6 RID: 2726
	public class ConfigTermConfigByKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FF8 RID: 16376 RVA: 0x001C67C8 File Offset: 0x001C49C8
		static ConfigTermConfigByKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermConfigByKey.CreateStaticDefaultValue), new Action(ConfigTermConfigByKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x001C67E8 File Offset: 0x001C49E8
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

		// Token: 0x06003FFA RID: 16378 RVA: 0x001C6867 File Offset: 0x001C4A67
		public static void ResetStaticDefaultValue()
		{
			ConfigTermConfigByKey.LogPair = null;
			ConfigTermConfigByKey.HandleId = 0;
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x001C6875 File Offset: 0x001C4A75
		public static void Init()
		{
			ConfigTermConfigByKey.HandleId = ConfigCommon.InitDataStatement(ConfigTermConfigByKey.HandleId, "db_term.db", "select BinData from `TermConfig` where Term=?");
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x001C6890 File Offset: 0x001C4A90
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

		// Token: 0x04004A70 RID: 19056
		private const string DB = "db_term.db";

		// Token: 0x04004A71 RID: 19057
		private const string FILE = "s.术语/*.csv*";

		// Token: 0x04004A72 RID: 19058
		private const string TABLE = "TermConfig";

		// Token: 0x04004A73 RID: 19059
		private const string COMMAND = "select BinData from `TermConfig` where Term=?";

		// Token: 0x04004A74 RID: 19060
		private const string KEY_PREFIX = "TermConfigByKey";

		// Token: 0x04004A75 RID: 19061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A76 RID: 19062
		private static int HandleId;
	}
}
