using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024A RID: 586
	public class ConfigDropCatchGameplayByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x000AADA4 File Offset: 0x000A8FA4
		static ConfigDropCatchGameplayByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchGameplayByActivityId.CreateStaticDefaultValue), new Action(ConfigDropCatchGameplayByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000AADC4 File Offset: 0x000A8FC4
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchGameplayByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchGameplayByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchGameplay` where ActivityId=?")
			});
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000AAE43 File Offset: 0x000A9043
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchGameplayByActivityId.LogPair = null;
			ConfigDropCatchGameplayByActivityId.HandleId = 0;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000AAE51 File Offset: 0x000A9051
		public static void Init()
		{
			ConfigDropCatchGameplayByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchGameplayByActivityId.HandleId, "db_dropcatch.db", "select BinData from `DropCatchGameplay` where ActivityId=?");
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000AAE6C File Offset: 0x000A906C
		[NullableContext(2)]
		public static IReadOnlyList<DropCatchGameplay> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchGameplayByActivityId.HandleId, ConfigDropCatchGameplayByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<DropCatchGameplay> readOnlyList = (IReadOnlyList<DropCatchGameplay>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDropCatchGameplayByActivityId.LogPair.Clear();
			ConfigDropCatchGameplayByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDropCatchGameplayByActivityId.HandleId, 1, p0ActivityId, ConfigDropCatchGameplayByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigDropCatchGameplayByActivityId.HandleId, ConfigDropCatchGameplayByActivityId.LogPair);
				return null;
			}
			List<DropCatchGameplay> list = new List<DropCatchGameplay>();
			while (ConfigCommon.Step(ConfigDropCatchGameplayByActivityId.HandleId, false, ConfigDropCatchGameplayByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchGameplayByActivityId.HandleId, 0, ConfigDropCatchGameplayByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDropCatchGameplayByActivityId.HandleId, ConfigDropCatchGameplayByActivityId.LogPair);
					return null;
				}
				DropCatchGameplay rootAsDropCatchGameplay = DropCatchGameplay.GetRootAsDropCatchGameplay(new ByteBuffer(item2));
				list.Add(rootAsDropCatchGameplay);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDropCatchGameplayByActivityId.HandleId, ConfigDropCatchGameplayByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000FEA RID: 4074
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FEB RID: 4075
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FEC RID: 4076
		private const string TABLE = "DropCatchGameplay";

		// Token: 0x04000FED RID: 4077
		private const string COMMAND = "select BinData from `DropCatchGameplay` where ActivityId=?";

		// Token: 0x04000FEE RID: 4078
		private const string KEY_PREFIX = "DropCatchGameplayByActivityId";

		// Token: 0x04000FEF RID: 4079
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FF0 RID: 4080
		private static int HandleId;
	}
}
