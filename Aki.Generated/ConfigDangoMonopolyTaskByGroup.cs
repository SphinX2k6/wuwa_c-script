using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EF RID: 495
	public class ConfigDangoMonopolyTaskByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0009B58C File Offset: 0x0009978C
		static ConfigDangoMonopolyTaskByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyTaskByGroup.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyTaskByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0009B5AC File Offset: 0x000997AC
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

		// Token: 0x06000B9F RID: 2975 RVA: 0x0009B62B File Offset: 0x0009982B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskByGroup.LogPair = null;
			ConfigDangoMonopolyTaskByGroup.HandleId = 0;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0009B639 File Offset: 0x00099839
		public static void Init()
		{
			ConfigDangoMonopolyTaskByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyTaskByGroup.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyTask` where TaskGroupId=?");
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0009B654 File Offset: 0x00099854
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

		// Token: 0x04000D6D RID: 3437
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D6E RID: 3438
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D6F RID: 3439
		private const string TABLE = "DangoMonopolyTask";

		// Token: 0x04000D70 RID: 3440
		private const string COMMAND = "select BinData from `DangoMonopolyTask` where TaskGroupId=?";

		// Token: 0x04000D71 RID: 3441
		private const string KEY_PREFIX = "DangoMonopolyTaskByGroup";

		// Token: 0x04000D72 RID: 3442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D73 RID: 3443
		private static int HandleId;
	}
}
