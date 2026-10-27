using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5C RID: 2652
	public class ConfigTurntableAwardsByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E3C RID: 15932 RVA: 0x001B9D8F File Offset: 0x001B7F8F
		static ConfigTurntableAwardsByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableAwardsByActivityId.CreateStaticDefaultValue), new Action(ConfigTurntableAwardsByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x001B9DB0 File Offset: 0x001B7FB0
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

		// Token: 0x06003E3E RID: 15934 RVA: 0x001B9E2F File Offset: 0x001B802F
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableAwardsByActivityId.LogPair = null;
			ConfigTurntableAwardsByActivityId.HandleId = 0;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x001B9E3D File Offset: 0x001B803D
		public static void Init()
		{
			ConfigTurntableAwardsByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableAwardsByActivityId.HandleId, "db_turntableactivity.db", "select BinData from `TurntableAwards` where ActivityId = ?");
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x001B9E58 File Offset: 0x001B8058
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

		// Token: 0x0400486A RID: 18538
		private const string DB = "db_turntableactivity.db";

		// Token: 0x0400486B RID: 18539
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x0400486C RID: 18540
		private const string TABLE = "TurntableAwards";

		// Token: 0x0400486D RID: 18541
		private const string COMMAND = "select BinData from `TurntableAwards` where ActivityId = ?";

		// Token: 0x0400486E RID: 18542
		private const string KEY_PREFIX = "TurntableAwardsByActivityId";

		// Token: 0x0400486F RID: 18543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004870 RID: 18544
		private static int HandleId;
	}
}
