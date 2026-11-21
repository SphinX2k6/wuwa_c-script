using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043F RID: 1087
	public class ConfigInfrAutoPilotCircleByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001983 RID: 6531 RVA: 0x000ED6B4 File Offset: 0x000EB8B4
		static ConfigInfrAutoPilotCircleByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleByMapId.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000ED6D4 File Offset: 0x000EB8D4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrAutoPilotCircleByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrAutoPilotCircle"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrAutoPilotCircle` where MapId=?")
			});
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000ED753 File Offset: 0x000EB953
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByMapId.LogPair = null;
			ConfigInfrAutoPilotCircleByMapId.HandleId = 0;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000ED761 File Offset: 0x000EB961
		public static void Init()
		{
			ConfigInfrAutoPilotCircleByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleByMapId.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle` where MapId=?");
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000ED77C File Offset: 0x000EB97C
		[NullableContext(2)]
		public static IReadOnlyList<InfrAutoPilotCircle> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrAutoPilotCircleByMapId.HandleId, ConfigInfrAutoPilotCircleByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrAutoPilotCircleByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<InfrAutoPilotCircle> readOnlyList = (IReadOnlyList<InfrAutoPilotCircle>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigInfrAutoPilotCircleByMapId.LogPair.Clear();
			ConfigInfrAutoPilotCircleByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigInfrAutoPilotCircleByMapId.HandleId, 1, p0MapId, ConfigInfrAutoPilotCircleByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigInfrAutoPilotCircleByMapId.HandleId, ConfigInfrAutoPilotCircleByMapId.LogPair);
				return null;
			}
			List<InfrAutoPilotCircle> list = new List<InfrAutoPilotCircle>();
			while (ConfigCommon.Step(ConfigInfrAutoPilotCircleByMapId.HandleId, false, ConfigInfrAutoPilotCircleByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrAutoPilotCircleByMapId.HandleId, 0, ConfigInfrAutoPilotCircleByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrAutoPilotCircleByMapId.HandleId, ConfigInfrAutoPilotCircleByMapId.LogPair);
					return null;
				}
				InfrAutoPilotCircle rootAsInfrAutoPilotCircle = InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(new ByteBuffer(item2));
				list.Add(rootAsInfrAutoPilotCircle);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrAutoPilotCircleByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrAutoPilotCircleByMapId.HandleId, ConfigInfrAutoPilotCircleByMapId.LogPair);
			return list;
		}

		// Token: 0x04001D9D RID: 7581
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D9E RID: 7582
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D9F RID: 7583
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001DA0 RID: 7584
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle` where MapId=?";

		// Token: 0x04001DA1 RID: 7585
		private const string KEY_PREFIX = "InfrAutoPilotCircleByMapId";

		// Token: 0x04001DA2 RID: 7586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DA3 RID: 7587
		private static int HandleId;
	}
}
