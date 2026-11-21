using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031D RID: 797
	public class ConfigFloatingSubtitle3DAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x000C6D38 File Offset: 0x000C4F38
		static ConfigFloatingSubtitle3DAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle3DAll.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle3DAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000C6D58 File Offset: 0x000C4F58
		public static void CreateStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloatingSubtitle3DAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_floatingsubtitle.db"),
				new ValueTuple<string, object>("文件", "p.飘浮字幕.xlsx"),
				new ValueTuple<string, object>("表名", "FloatingSubtitle3D"),
				new ValueTuple<string, object>("语句", "select BinData from `FloatingSubtitle3D`")
			});
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000C6DD7 File Offset: 0x000C4FD7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DAll.LogPair = null;
			ConfigFloatingSubtitle3DAll.HandleId = 0;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000C6DE5 File Offset: 0x000C4FE5
		public static void Init()
		{
			ConfigFloatingSubtitle3DAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle3DAll.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle3D`");
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000C6E00 File Offset: 0x000C5000
		[NullableContext(2)]
		public static IReadOnlyList<FloatingSubtitle3D> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloatingSubtitle3DAll.HandleId, ConfigFloatingSubtitle3DAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloatingSubtitle3D> readOnlyList = (IReadOnlyList<FloatingSubtitle3D>)ConfigCommon.GetConfig("FloatingSubtitle3DAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloatingSubtitle3D> list = new List<FloatingSubtitle3D>();
			while (ConfigCommon.Step(ConfigFloatingSubtitle3DAll.HandleId, false, ConfigFloatingSubtitle3DAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloatingSubtitle3DAll.HandleId, 0, ConfigFloatingSubtitle3DAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloatingSubtitle3DAll.HandleId, ConfigFloatingSubtitle3DAll.LogPair);
					return null;
				}
				FloatingSubtitle3D rootAsFloatingSubtitle3D = FloatingSubtitle3D.GetRootAsFloatingSubtitle3D(new ByteBuffer(item2));
				list.Add(rootAsFloatingSubtitle3D);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloatingSubtitle3DAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloatingSubtitle3DAll.HandleId, ConfigFloatingSubtitle3DAll.LogPair);
			return list;
		}

		// Token: 0x040015AF RID: 5551
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x040015B0 RID: 5552
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x040015B1 RID: 5553
		private const string TABLE = "FloatingSubtitle3D";

		// Token: 0x040015B2 RID: 5554
		private const string COMMAND = "select BinData from `FloatingSubtitle3D`";

		// Token: 0x040015B3 RID: 5555
		private const string KEY_PREFIX = "FloatingSubtitle3DAll";

		// Token: 0x040015B4 RID: 5556
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015B5 RID: 5557
		private static int HandleId;
	}
}
