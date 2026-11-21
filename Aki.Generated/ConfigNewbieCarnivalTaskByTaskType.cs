using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FC RID: 1532
	public class ConfigNewbieCarnivalTaskByTaskType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023F7 RID: 9207 RVA: 0x00128640 File Offset: 0x00126840
		static ConfigNewbieCarnivalTaskByTaskType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskByTaskType.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskByTaskType.ResetStaticDefaultValue));
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00128660 File Offset: 0x00126860
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalTaskByTaskType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalTask` where TaskType=?")
			});
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x001286DF File Offset: 0x001268DF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskByTaskType.LogPair = null;
			ConfigNewbieCarnivalTaskByTaskType.HandleId = 0;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x001286ED File Offset: 0x001268ED
		public static void Init()
		{
			ConfigNewbieCarnivalTaskByTaskType.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskByTaskType.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTask` where TaskType=?");
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00128708 File Offset: 0x00126908
		[NullableContext(2)]
		public static IReadOnlyList<NewbieCarnivalTask> GetConfigList(int p0TaskType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				IReadOnlyList<NewbieCarnivalTask> readOnlyList = (IReadOnlyList<NewbieCarnivalTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieCarnivalTaskByTaskType.LogPair.Clear();
			ConfigNewbieCarnivalTaskByTaskType.LogPair.Add(new ValueTuple<string, object>("TaskType", p0TaskType));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalTaskByTaskType.HandleId, 1, p0TaskType, ConfigNewbieCarnivalTaskByTaskType.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
				return null;
			}
			List<NewbieCarnivalTask> list = new List<NewbieCarnivalTask>();
			while (ConfigCommon.Step(ConfigNewbieCarnivalTaskByTaskType.HandleId, false, ConfigNewbieCarnivalTaskByTaskType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalTaskByTaskType.HandleId, 0, ConfigNewbieCarnivalTaskByTaskType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
					return null;
				}
				NewbieCarnivalTask rootAsNewbieCarnivalTask = NewbieCarnivalTask.GetRootAsNewbieCarnivalTask(new ByteBuffer(item2));
				list.Add(rootAsNewbieCarnivalTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskByTaskType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalTaskByTaskType.HandleId, ConfigNewbieCarnivalTaskByTaskType.LogPair);
			return list;
		}

		// Token: 0x040029CA RID: 10698
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x040029CB RID: 10699
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x040029CC RID: 10700
		private const string TABLE = "NewbieCarnivalTask";

		// Token: 0x040029CD RID: 10701
		private const string COMMAND = "select BinData from `NewbieCarnivalTask` where TaskType=?";

		// Token: 0x040029CE RID: 10702
		private const string KEY_PREFIX = "NewbieCarnivalTaskByTaskType";

		// Token: 0x040029CF RID: 10703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029D0 RID: 10704
		private static int HandleId;
	}
}
