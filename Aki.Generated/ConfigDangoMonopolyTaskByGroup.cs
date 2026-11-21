using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000201 RID: 513
	public class ConfigDangoMonopolyTaskByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x000A14C4 File Offset: 0x0009F6C4
		static ConfigDangoMonopolyTaskByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyTaskByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyTaskByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000A14E4 File Offset: 0x0009F6E4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskByGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyTaskByGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyTask"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyTask` where TaskGroupId=?")
			});
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000A1563 File Offset: 0x0009F763
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskByGroup.LogPair = null;
			ConfigDangoMonopolyTaskByGroup.HandleId = 0;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000A1571 File Offset: 0x0009F771
		public static void Init()
		{
			ConfigDangoMonopolyTaskByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyTaskByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyTask` where TaskGroupId=?");
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000A158C File Offset: 0x0009F78C
		[NullableContext(2)]
		public static IReadOnlyList<DangoMonopolyTask> GetConfigList(int p0TaskGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyTaskByGroup.HandleId, ConfigDangoMonopolyTaskByGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyTaskByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskGroupId);
				IReadOnlyList<DangoMonopolyTask> readOnlyList = (IReadOnlyList<DangoMonopolyTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoMonopolyTaskByGroup.LogPair.Clear();
			ConfigDangoMonopolyTaskByGroup.LogPair.Add(new ValueTuple<string, object>("TaskGroupId", p0TaskGroupId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyTaskByGroup.HandleId, 1, p0TaskGroupId, ConfigDangoMonopolyTaskByGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoMonopolyTaskByGroup.HandleId, ConfigDangoMonopolyTaskByGroup.LogPair);
				return null;
			}
			List<DangoMonopolyTask> list = new List<DangoMonopolyTask>();
			while (ConfigCommon.Step(ConfigDangoMonopolyTaskByGroup.HandleId, false, ConfigDangoMonopolyTaskByGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyTaskByGroup.HandleId, 0, ConfigDangoMonopolyTaskByGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoMonopolyTaskByGroup.HandleId, ConfigDangoMonopolyTaskByGroup.LogPair);
					return null;
				}
				DangoMonopolyTask rootAsDangoMonopolyTask = DangoMonopolyTask.GetRootAsDangoMonopolyTask(new ByteBuffer(item2));
				list.Add(rootAsDangoMonopolyTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyTaskByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyTaskByGroup.HandleId, ConfigDangoMonopolyTaskByGroup.LogPair);
			return list;
		}

		// Token: 0x04000DEB RID: 3563
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DEC RID: 3564
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DED RID: 3565
		private const string TABLE = "DangoMonopolyTask";

		// Token: 0x04000DEE RID: 3566
		private const string COMMAND = "select BinData from `DangoMonopolyTask` where TaskGroupId=?";

		// Token: 0x04000DEF RID: 3567
		private const string KEY_PREFIX = "DangoMonopolyTaskByGroup";

		// Token: 0x04000DF0 RID: 3568
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DF1 RID: 3569
		private static int HandleId;
	}
}
