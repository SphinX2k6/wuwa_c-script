using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000266 RID: 614
	public class ConfigEdgeRunnerTrialByCyberPunkActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E68 RID: 3688 RVA: 0x000AE753 File Offset: 0x000AC953
		static ConfigEdgeRunnerTrialByCyberPunkActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialByCyberPunkActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialByCyberPunkActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000AE774 File Offset: 0x000AC974
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTrial"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?")
			});
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000AE7F3 File Offset: 0x000AC9F3
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair = null;
			ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId = 0;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000AE801 File Offset: 0x000ACA01
		public static void Init()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?");
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000AE81C File Offset: 0x000ACA1C
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerTrial> GetConfigList(int p0CyberPunkActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByCyberPunkActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CyberPunkActivityId);
				IReadOnlyList<EdgeRunnerTrial> readOnlyList = (IReadOnlyList<EdgeRunnerTrial>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.Clear();
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.Add(new ValueTuple<string, object>("CyberPunkActivityId", p0CyberPunkActivityId));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, 1, p0CyberPunkActivityId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
				return null;
			}
			List<EdgeRunnerTrial> list = new List<EdgeRunnerTrial>();
			while (ConfigCommon.Step(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, false, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, 0, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
					return null;
				}
				EdgeRunnerTrial rootAsEdgeRunnerTrial = EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerTrial);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByCyberPunkActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CyberPunkActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
			return list;
		}

		// Token: 0x040010AE RID: 4270
		private const string DB = "db_edgerunner.db";

		// Token: 0x040010AF RID: 4271
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x040010B0 RID: 4272
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x040010B1 RID: 4273
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?";

		// Token: 0x040010B2 RID: 4274
		private const string KEY_PREFIX = "EdgeRunnerTrialByCyberPunkActivityId";

		// Token: 0x040010B3 RID: 4275
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010B4 RID: 4276
		private static int HandleId;
	}
}
