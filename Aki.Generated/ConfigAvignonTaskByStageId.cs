using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C0 RID: 192
	public class ConfigAvignonTaskByStageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00073320 File Offset: 0x00071520
		static ConfigAvignonTaskByStageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonTaskByStageId.CreateStaticDefaultValue), new Action(ConfigAvignonTaskByStageId.ResetStaticDefaultValue));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00073340 File Offset: 0x00071540
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

		// Token: 0x06000483 RID: 1155 RVA: 0x000733BF File Offset: 0x000715BF
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonTaskByStageId.LogPair = null;
			ConfigAvignonTaskByStageId.HandleId = 0;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000733CD File Offset: 0x000715CD
		public static void Init()
		{
			ConfigAvignonTaskByStageId.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonTaskByStageId.HandleId, "db_avignon.db", "select BinData from `AvignonTask` where Step=?");
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000733E8 File Offset: 0x000715E8
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

		// Token: 0x04000524 RID: 1316
		private const string DB = "db_avignon.db";

		// Token: 0x04000525 RID: 1317
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x04000526 RID: 1318
		private const string TABLE = "AvignonTask";

		// Token: 0x04000527 RID: 1319
		private const string COMMAND = "select BinData from `AvignonTask` where Step=?";

		// Token: 0x04000528 RID: 1320
		private const string KEY_PREFIX = "AvignonTaskByStageId";

		// Token: 0x04000529 RID: 1321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400052A RID: 1322
		private static int HandleId;
	}
}
