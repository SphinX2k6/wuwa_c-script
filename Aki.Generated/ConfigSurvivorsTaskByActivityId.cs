using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AC RID: 2476
	public class ConfigSurvivorsTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A1C RID: 14876 RVA: 0x001A25B8 File Offset: 0x001A07B8
		static ConfigSurvivorsTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x001A25D8 File Offset: 0x001A07D8
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTaskByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTaskByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTask` where ActivityId=?")
			});
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x001A2657 File Offset: 0x001A0857
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTaskByActivityId.LogPair = null;
			ConfigSurvivorsTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001A2665 File Offset: 0x001A0865
		public static void Init()
		{
			ConfigSurvivorsTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTaskByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsTask` where ActivityId=?");
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001A2680 File Offset: 0x001A0880
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsTask> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTaskByActivityId.HandleId, ConfigSurvivorsTaskByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsTask> readOnlyList = (IReadOnlyList<SurvivorsTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsTaskByActivityId.LogPair.Clear();
			ConfigSurvivorsTaskByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTaskByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsTaskByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsTaskByActivityId.HandleId, ConfigSurvivorsTaskByActivityId.LogPair);
				return null;
			}
			List<SurvivorsTask> list = new List<SurvivorsTask>();
			while (ConfigCommon.Step(ConfigSurvivorsTaskByActivityId.HandleId, false, ConfigSurvivorsTaskByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTaskByActivityId.HandleId, 0, ConfigSurvivorsTaskByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsTaskByActivityId.HandleId, ConfigSurvivorsTaskByActivityId.LogPair);
					return null;
				}
				SurvivorsTask rootAsSurvivorsTask = SurvivorsTask.GetRootAsSurvivorsTask(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsTaskByActivityId.HandleId, ConfigSurvivorsTaskByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400439A RID: 17306
		private const string DB = "db_survivors.db";

		// Token: 0x0400439B RID: 17307
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x0400439C RID: 17308
		private const string TABLE = "SurvivorsTask";

		// Token: 0x0400439D RID: 17309
		private const string COMMAND = "select BinData from `SurvivorsTask` where ActivityId=?";

		// Token: 0x0400439E RID: 17310
		private const string KEY_PREFIX = "SurvivorsTaskByActivityId";

		// Token: 0x0400439F RID: 17311
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043A0 RID: 17312
		private static int HandleId;
	}
}
