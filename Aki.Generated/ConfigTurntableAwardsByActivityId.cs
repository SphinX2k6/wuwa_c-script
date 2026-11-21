using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B31 RID: 2865
	public class ConfigTurntableAwardsByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600433A RID: 17210 RVA: 0x001D9123 File Offset: 0x001D7323
		static ConfigTurntableAwardsByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableAwardsByActivityId.CreateStaticDefaultValue), new Action(ConfigTurntableAwardsByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x001D9144 File Offset: 0x001D7344
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableAwardsByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableAwardsByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableAwards"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableAwards` where ActivityId = ?")
			});
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x001D91C3 File Offset: 0x001D73C3
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableAwardsByActivityId.LogPair = null;
			ConfigTurntableAwardsByActivityId.HandleId = 0;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001D91D1 File Offset: 0x001D73D1
		public static void Init()
		{
			ConfigTurntableAwardsByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableAwardsByActivityId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableAwards` where ActivityId = ?");
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x001D91EC File Offset: 0x001D73EC
		[NullableContext(2)]
		public static IReadOnlyList<TurntableAwards> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableAwardsByActivityId.HandleId, ConfigTurntableAwardsByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableAwardsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TurntableAwards> readOnlyList = (IReadOnlyList<TurntableAwards>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTurntableAwardsByActivityId.LogPair.Clear();
			ConfigTurntableAwardsByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTurntableAwardsByActivityId.HandleId, 1, p0ActivityId, ConfigTurntableAwardsByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTurntableAwardsByActivityId.HandleId, ConfigTurntableAwardsByActivityId.LogPair);
				return null;
			}
			List<TurntableAwards> list = new List<TurntableAwards>();
			while (ConfigCommon.Step(ConfigTurntableAwardsByActivityId.HandleId, false, ConfigTurntableAwardsByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableAwardsByActivityId.HandleId, 0, ConfigTurntableAwardsByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTurntableAwardsByActivityId.HandleId, ConfigTurntableAwardsByActivityId.LogPair);
					return null;
				}
				TurntableAwards rootAsTurntableAwards = TurntableAwards.GetRootAsTurntableAwards(new ByteBuffer(item2));
				list.Add(rootAsTurntableAwards);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableAwardsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTurntableAwardsByActivityId.HandleId, ConfigTurntableAwardsByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004E3D RID: 20029
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004E3E RID: 20030
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004E3F RID: 20031
		private const string TABLE = "TurntableAwards";

		// Token: 0x04004E40 RID: 20032
		private const string COMMAND = "select BinData from `TurntableAwards` where ActivityId = ?";

		// Token: 0x04004E41 RID: 20033
		private const string KEY_PREFIX = "TurntableAwardsByActivityId";

		// Token: 0x04004E42 RID: 20034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E43 RID: 20035
		private static int HandleId;
	}
}
