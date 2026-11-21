using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB3 RID: 2739
	public class ConfigTetrisStyleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x001C843D File Offset: 0x001C663D
		static ConfigTetrisStyleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigAll.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x001C845C File Offset: 0x001C665C
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisStyleConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisStyleConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetrisstyleconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*"),
				new ValueTuple<string, object>("表名", "TetrisStyleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisStyleConfig`")
			});
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x001C84DB File Offset: 0x001C66DB
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigAll.LogPair = null;
			ConfigTetrisStyleConfigAll.HandleId = 0;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x001C84E9 File Offset: 0x001C66E9
		public static void Init()
		{
			ConfigTetrisStyleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigAll.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig`");
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x001C8504 File Offset: 0x001C6704
		[NullableContext(2)]
		public static IReadOnlyList<TetrisStyleConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisStyleConfigAll.HandleId, ConfigTetrisStyleConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TetrisStyleConfig> readOnlyList = (IReadOnlyList<TetrisStyleConfig>)ConfigCommon.GetConfig("TetrisStyleConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TetrisStyleConfig> list = new List<TetrisStyleConfig>();
			while (ConfigCommon.Step(ConfigTetrisStyleConfigAll.HandleId, false, ConfigTetrisStyleConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisStyleConfigAll.HandleId, 0, ConfigTetrisStyleConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTetrisStyleConfigAll.HandleId, ConfigTetrisStyleConfigAll.LogPair);
					return null;
				}
				TetrisStyleConfig rootAsTetrisStyleConfig = TetrisStyleConfig.GetRootAsTetrisStyleConfig(new ByteBuffer(item2));
				list.Add(rootAsTetrisStyleConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TetrisStyleConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTetrisStyleConfigAll.HandleId, ConfigTetrisStyleConfigAll.LogPair);
			return list;
		}

		// Token: 0x04004ACB RID: 19147
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x04004ACC RID: 19148
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x04004ACD RID: 19149
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x04004ACE RID: 19150
		private const string COMMAND = "select BinData from `TetrisStyleConfig`";

		// Token: 0x04004ACF RID: 19151
		private const string KEY_PREFIX = "TetrisStyleConfigAll";

		// Token: 0x04004AD0 RID: 19152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AD1 RID: 19153
		private static int HandleId;
	}
}
