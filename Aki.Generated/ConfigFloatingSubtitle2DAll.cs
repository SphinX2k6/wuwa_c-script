using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000306 RID: 774
	public class ConfigFloatingSubtitle2DAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001229 RID: 4649 RVA: 0x000C0450 File Offset: 0x000BE650
		static ConfigFloatingSubtitle2DAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle2DAll.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle2DAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000C0470 File Offset: 0x000BE670
		public static void CreateStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloatingSubtitle2DAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_floatingsubtitle.db"),
				new ValueTuple<string, object>("文件", "p.飘浮字幕.xlsx"),
				new ValueTuple<string, object>("表名", "FloatingSubtitle2D"),
				new ValueTuple<string, object>("语句", "select BinData from `FloatingSubtitle2D`")
			});
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000C04EF File Offset: 0x000BE6EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DAll.LogPair = null;
			ConfigFloatingSubtitle2DAll.HandleId = 0;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000C04FD File Offset: 0x000BE6FD
		public static void Init()
		{
			ConfigFloatingSubtitle2DAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle2DAll.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle2D`");
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000C0518 File Offset: 0x000BE718
		[NullableContext(2)]
		public static IReadOnlyList<FloatingSubtitle2D> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloatingSubtitle2D> readOnlyList = (IReadOnlyList<FloatingSubtitle2D>)ConfigCommon.GetConfig("FloatingSubtitle2DAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloatingSubtitle2D> list = new List<FloatingSubtitle2D>();
			while (ConfigCommon.Step(ConfigFloatingSubtitle2DAll.HandleId, false, ConfigFloatingSubtitle2DAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloatingSubtitle2DAll.HandleId, 0, ConfigFloatingSubtitle2DAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair);
					return null;
				}
				FloatingSubtitle2D rootAsFloatingSubtitle2D = FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(new ByteBuffer(item2));
				list.Add(rootAsFloatingSubtitle2D);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloatingSubtitle2DAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloatingSubtitle2DAll.HandleId, ConfigFloatingSubtitle2DAll.LogPair);
			return list;
		}

		// Token: 0x0400150E RID: 5390
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x0400150F RID: 5391
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x04001510 RID: 5392
		private const string TABLE = "FloatingSubtitle2D";

		// Token: 0x04001511 RID: 5393
		private const string COMMAND = "select BinData from `FloatingSubtitle2D`";

		// Token: 0x04001512 RID: 5394
		private const string KEY_PREFIX = "FloatingSubtitle2DAll";

		// Token: 0x04001513 RID: 5395
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001514 RID: 5396
		private static int HandleId;
	}
}
