using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060F RID: 1551
	public class ConfigNewPlayerSupV2TrialByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002469 RID: 9321 RVA: 0x0012ACD0 File Offset: 0x00128ED0
		static ConfigNewPlayerSupV2TrialByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupV2TrialByActivityId.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupV2TrialByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0012ACF0 File Offset: 0x00128EF0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupV2TrialByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动V2.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupV2Trial"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupV2Trial` where ActivityId=?")
			});
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0012AD6F File Offset: 0x00128F6F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialByActivityId.LogPair = null;
			ConfigNewPlayerSupV2TrialByActivityId.HandleId = 0;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0012AD7D File Offset: 0x00128F7D
		public static void Init()
		{
			ConfigNewPlayerSupV2TrialByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupV2TrialByActivityId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupV2Trial` where ActivityId=?");
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0012AD98 File Offset: 0x00128F98
		[NullableContext(2)]
		public static IReadOnlyList<NewPlayerSupV2Trial> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupV2TrialByActivityId.HandleId, ConfigNewPlayerSupV2TrialByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<NewPlayerSupV2Trial> readOnlyList = (IReadOnlyList<NewPlayerSupV2Trial>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewPlayerSupV2TrialByActivityId.LogPair.Clear();
			ConfigNewPlayerSupV2TrialByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupV2TrialByActivityId.HandleId, 1, p0ActivityId, ConfigNewPlayerSupV2TrialByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByActivityId.HandleId, ConfigNewPlayerSupV2TrialByActivityId.LogPair);
				return null;
			}
			List<NewPlayerSupV2Trial> list = new List<NewPlayerSupV2Trial>();
			while (ConfigCommon.Step(ConfigNewPlayerSupV2TrialByActivityId.HandleId, false, ConfigNewPlayerSupV2TrialByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupV2TrialByActivityId.HandleId, 0, ConfigNewPlayerSupV2TrialByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByActivityId.HandleId, ConfigNewPlayerSupV2TrialByActivityId.LogPair);
					return null;
				}
				NewPlayerSupV2Trial rootAsNewPlayerSupV2Trial = NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(new ByteBuffer(item2));
				list.Add(rootAsNewPlayerSupV2Trial);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByActivityId.HandleId, ConfigNewPlayerSupV2TrialByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002A4F RID: 10831
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A50 RID: 10832
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002A51 RID: 10833
		private const string TABLE = "NewPlayerSupV2Trial";

		// Token: 0x04002A52 RID: 10834
		private const string COMMAND = "select BinData from `NewPlayerSupV2Trial` where ActivityId=?";

		// Token: 0x04002A53 RID: 10835
		private const string KEY_PREFIX = "NewPlayerSupV2TrialByActivityId";

		// Token: 0x04002A54 RID: 10836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A55 RID: 10837
		private static int HandleId;
	}
}
