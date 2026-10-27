using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000238 RID: 568
	public class ConfigDropCatchGameplayByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x000A4E6C File Offset: 0x000A306C
		static ConfigDropCatchGameplayByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchGameplayByActivityId.CreateStaticDefaultValue), new Action(ConfigDropCatchGameplayByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000A4E8C File Offset: 0x000A308C
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

		// Token: 0x06000D56 RID: 3414 RVA: 0x000A4F0B File Offset: 0x000A310B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchGameplayByActivityId.LogPair = null;
			ConfigDropCatchGameplayByActivityId.HandleId = 0;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000A4F19 File Offset: 0x000A3119
		public static void Init()
		{
			ConfigDropCatchGameplayByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchGameplayByActivityId.HandleId, "db_dropcatch.db", "select BinData from `DropCatchGameplay` where ActivityId=?");
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000A4F34 File Offset: 0x000A3134
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

		// Token: 0x04000F6C RID: 3948
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F6D RID: 3949
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F6E RID: 3950
		private const string TABLE = "DropCatchGameplay";

		// Token: 0x04000F6F RID: 3951
		private const string COMMAND = "select BinData from `DropCatchGameplay` where ActivityId=?";

		// Token: 0x04000F70 RID: 3952
		private const string KEY_PREFIX = "DropCatchGameplayByActivityId";

		// Token: 0x04000F71 RID: 3953
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F72 RID: 3954
		private static int HandleId;
	}
}
