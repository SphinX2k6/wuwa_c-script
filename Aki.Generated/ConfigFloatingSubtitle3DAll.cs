using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000308 RID: 776
	public class ConfigFloatingSubtitle3DAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001235 RID: 4661 RVA: 0x000C082C File Offset: 0x000BEA2C
		static ConfigFloatingSubtitle3DAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle3DAll.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle3DAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000C084C File Offset: 0x000BEA4C
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

		// Token: 0x06001237 RID: 4663 RVA: 0x000C08CB File Offset: 0x000BEACB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DAll.LogPair = null;
			ConfigFloatingSubtitle3DAll.HandleId = 0;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000C08D9 File Offset: 0x000BEAD9
		public static void Init()
		{
			ConfigFloatingSubtitle3DAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle3DAll.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle3D`");
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000C08F4 File Offset: 0x000BEAF4
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

		// Token: 0x0400151C RID: 5404
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x0400151D RID: 5405
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x0400151E RID: 5406
		private const string TABLE = "FloatingSubtitle3D";

		// Token: 0x0400151F RID: 5407
		private const string COMMAND = "select BinData from `FloatingSubtitle3D`";

		// Token: 0x04001520 RID: 5408
		private const string KEY_PREFIX = "FloatingSubtitle3DAll";

		// Token: 0x04001521 RID: 5409
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001522 RID: 5410
		private static int HandleId;
	}
}
