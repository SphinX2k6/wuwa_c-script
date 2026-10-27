using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000429 RID: 1065
	public class ConfigInfrAutoPilotCircleByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018FF RID: 6399 RVA: 0x000E6F60 File Offset: 0x000E5160
		static ConfigInfrAutoPilotCircleByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleByMapId.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000E6F80 File Offset: 0x000E5180
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

		// Token: 0x06001901 RID: 6401 RVA: 0x000E6FFF File Offset: 0x000E51FF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByMapId.LogPair = null;
			ConfigInfrAutoPilotCircleByMapId.HandleId = 0;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000E700D File Offset: 0x000E520D
		public static void Init()
		{
			ConfigInfrAutoPilotCircleByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleByMapId.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle` where MapId=?");
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x000E7028 File Offset: 0x000E5228
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

		// Token: 0x04001D03 RID: 7427
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D04 RID: 7428
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D05 RID: 7429
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001D06 RID: 7430
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle` where MapId=?";

		// Token: 0x04001D07 RID: 7431
		private const string KEY_PREFIX = "InfrAutoPilotCircleByMapId";

		// Token: 0x04001D08 RID: 7432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D09 RID: 7433
		private static int HandleId;
	}
}
