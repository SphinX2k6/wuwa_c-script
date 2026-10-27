using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DE RID: 2526
	public class ConfigTetrisStyleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B48 RID: 15176 RVA: 0x001A90A9 File Offset: 0x001A72A9
		static ConfigTetrisStyleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigAll.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x001A90C8 File Offset: 0x001A72C8
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

		// Token: 0x06003B4A RID: 15178 RVA: 0x001A9147 File Offset: 0x001A7347
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigAll.LogPair = null;
			ConfigTetrisStyleConfigAll.HandleId = 0;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x001A9155 File Offset: 0x001A7355
		public static void Init()
		{
			ConfigTetrisStyleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigAll.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig`");
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x001A9170 File Offset: 0x001A7370
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

		// Token: 0x040044F8 RID: 17656
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x040044F9 RID: 17657
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x040044FA RID: 17658
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x040044FB RID: 17659
		private const string COMMAND = "select BinData from `TetrisStyleConfig`";

		// Token: 0x040044FC RID: 17660
		private const string KEY_PREFIX = "TetrisStyleConfigAll";

		// Token: 0x040044FD RID: 17661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044FE RID: 17662
		private static int HandleId;
	}
}
