using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059C RID: 1436
	public class ConfigMotorFightAttrShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021B5 RID: 8629 RVA: 0x0011B8DF File Offset: 0x00119ADF
		static ConfigMotorFightAttrShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrShowAll.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0011B900 File Offset: 0x00119B00
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightAttrShowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightAttrShowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightAttrShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightAttrShow`")
			});
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0011B97F File Offset: 0x00119B7F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrShowAll.LogPair = null;
			ConfigMotorFightAttrShowAll.HandleId = 0;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0011B98D File Offset: 0x00119B8D
		public static void Init()
		{
			ConfigMotorFightAttrShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrShowAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttrShow`");
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0011B9A8 File Offset: 0x00119BA8
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightAttrShow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightAttrShow> readOnlyList = (IReadOnlyList<MotorFightAttrShow>)ConfigCommon.GetConfig("MotorFightAttrShowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightAttrShow> list = new List<MotorFightAttrShow>();
			while (ConfigCommon.Step(ConfigMotorFightAttrShowAll.HandleId, false, ConfigMotorFightAttrShowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightAttrShowAll.HandleId, 0, ConfigMotorFightAttrShowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair);
					return null;
				}
				MotorFightAttrShow rootAsMotorFightAttrShow = MotorFightAttrShow.GetRootAsMotorFightAttrShow(new ByteBuffer(item2));
				list.Add(rootAsMotorFightAttrShow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightAttrShowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair);
			return list;
		}

		// Token: 0x04002728 RID: 10024
		private const string DB = "db_motorfight.db";

		// Token: 0x04002729 RID: 10025
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400272A RID: 10026
		private const string TABLE = "MotorFightAttrShow";

		// Token: 0x0400272B RID: 10027
		private const string COMMAND = "select BinData from `MotorFightAttrShow`";

		// Token: 0x0400272C RID: 10028
		private const string KEY_PREFIX = "MotorFightAttrShowAll";

		// Token: 0x0400272D RID: 10029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400272E RID: 10030
		private static int HandleId;
	}
}
