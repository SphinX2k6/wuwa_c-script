using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A81 RID: 2689
	public class ConfigSurvivorsTaskByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F1A RID: 16154 RVA: 0x001C194C File Offset: 0x001BFB4C
		static ConfigSurvivorsTaskByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTaskByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsTaskByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x001C196C File Offset: 0x001BFB6C
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

		// Token: 0x06003F1C RID: 16156 RVA: 0x001C19EB File Offset: 0x001BFBEB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTaskByActivityId.LogPair = null;
			ConfigSurvivorsTaskByActivityId.HandleId = 0;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x001C19F9 File Offset: 0x001BFBF9
		public static void Init()
		{
			ConfigSurvivorsTaskByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTaskByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsTask` where ActivityId=?");
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x001C1A14 File Offset: 0x001BFC14
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

		// Token: 0x0400496D RID: 18797
		private const string DB = "db_survivors.db";

		// Token: 0x0400496E RID: 18798
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x0400496F RID: 18799
		private const string TABLE = "SurvivorsTask";

		// Token: 0x04004970 RID: 18800
		private const string COMMAND = "select BinData from `SurvivorsTask` where ActivityId=?";

		// Token: 0x04004971 RID: 18801
		private const string KEY_PREFIX = "SurvivorsTaskByActivityId";

		// Token: 0x04004972 RID: 18802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004973 RID: 18803
		private static int HandleId;
	}
}
