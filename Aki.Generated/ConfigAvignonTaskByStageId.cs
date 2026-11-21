using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CF RID: 207
	public class ConfigAvignonTaskByStageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x00078C84 File Offset: 0x00076E84
		static ConfigAvignonTaskByStageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonTaskByStageId.CreateStaticDefaultValue), new Action(ConfigAvignonTaskByStageId.ResetStaticDefaultValue));
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00078CA4 File Offset: 0x00076EA4
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonTaskByStageId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonTaskByStageId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonTask"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonTask` where Step=?")
			});
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00078D23 File Offset: 0x00076F23
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonTaskByStageId.LogPair = null;
			ConfigAvignonTaskByStageId.HandleId = 0;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00078D31 File Offset: 0x00076F31
		public static void Init()
		{
			ConfigAvignonTaskByStageId.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonTaskByStageId.HandleId, "db_avignon.db", "select BinData from `AvignonTask` where Step=?");
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00078D4C File Offset: 0x00076F4C
		[NullableContext(2)]
		public static IReadOnlyList<AvignonTask> GetConfigList(int p0Step, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonTaskByStageId.HandleId, ConfigAvignonTaskByStageId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonTaskByStageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Step);
				IReadOnlyList<AvignonTask> readOnlyList = (IReadOnlyList<AvignonTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAvignonTaskByStageId.LogPair.Clear();
			ConfigAvignonTaskByStageId.LogPair.Add(new ValueTuple<string, object>("Step", p0Step));
			if (!ConfigCommon.BindInt(ConfigAvignonTaskByStageId.HandleId, 1, p0Step, ConfigAvignonTaskByStageId.LogPair))
			{
				ConfigCommon.Reset(ConfigAvignonTaskByStageId.HandleId, ConfigAvignonTaskByStageId.LogPair);
				return null;
			}
			List<AvignonTask> list = new List<AvignonTask>();
			while (ConfigCommon.Step(ConfigAvignonTaskByStageId.HandleId, false, ConfigAvignonTaskByStageId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonTaskByStageId.HandleId, 0, ConfigAvignonTaskByStageId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAvignonTaskByStageId.HandleId, ConfigAvignonTaskByStageId.LogPair);
					return null;
				}
				AvignonTask rootAsAvignonTask = AvignonTask.GetRootAsAvignonTask(new ByteBuffer(item2));
				list.Add(rootAsAvignonTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvignonTaskByStageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Step);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAvignonTaskByStageId.HandleId, ConfigAvignonTaskByStageId.LogPair);
			return list;
		}

		// Token: 0x0400058D RID: 1421
		private const string DB = "db_avignon.db";

		// Token: 0x0400058E RID: 1422
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x0400058F RID: 1423
		private const string TABLE = "AvignonTask";

		// Token: 0x04000590 RID: 1424
		private const string COMMAND = "select BinData from `AvignonTask` where Step=?";

		// Token: 0x04000591 RID: 1425
		private const string KEY_PREFIX = "AvignonTaskByStageId";

		// Token: 0x04000592 RID: 1426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000593 RID: 1427
		private static int HandleId;
	}
}
