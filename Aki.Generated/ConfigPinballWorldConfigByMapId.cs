using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073D RID: 1853
	public class ConfigPinballWorldConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B7E RID: 11134 RVA: 0x0014F5F8 File Offset: 0x0014D7F8
		static ConfigPinballWorldConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWorldConfigByMapId.CreateStaticDefaultValue), new Action(ConfigPinballWorldConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0014F618 File Offset: 0x0014D818
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWorldConfigByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWorldConfigByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWorldConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWorldConfig` where MapId=?")
			});
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x0014F697 File Offset: 0x0014D897
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWorldConfigByMapId.LogPair = null;
			ConfigPinballWorldConfigByMapId.HandleId = 0;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0014F6A5 File Offset: 0x0014D8A5
		public static void Init()
		{
			ConfigPinballWorldConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWorldConfigByMapId.HandleId, "db_pinballbattle.db", "select BinData from `PinballWorldConfig` where MapId=?");
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0014F6C0 File Offset: 0x0014D8C0
		[NullableContext(2)]
		public static IReadOnlyList<PinballWorldConfig> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWorldConfigByMapId.HandleId, ConfigPinballWorldConfigByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWorldConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<PinballWorldConfig> readOnlyList = (IReadOnlyList<PinballWorldConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPinballWorldConfigByMapId.LogPair.Clear();
			ConfigPinballWorldConfigByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPinballWorldConfigByMapId.HandleId, 1, p0MapId, ConfigPinballWorldConfigByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigPinballWorldConfigByMapId.HandleId, ConfigPinballWorldConfigByMapId.LogPair);
				return null;
			}
			List<PinballWorldConfig> list = new List<PinballWorldConfig>();
			while (ConfigCommon.Step(ConfigPinballWorldConfigByMapId.HandleId, false, ConfigPinballWorldConfigByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWorldConfigByMapId.HandleId, 0, ConfigPinballWorldConfigByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballWorldConfigByMapId.HandleId, ConfigPinballWorldConfigByMapId.LogPair);
					return null;
				}
				PinballWorldConfig rootAsPinballWorldConfig = PinballWorldConfig.GetRootAsPinballWorldConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballWorldConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWorldConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballWorldConfigByMapId.HandleId, ConfigPinballWorldConfigByMapId.LogPair);
			return list;
		}

		// Token: 0x04003291 RID: 12945
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003292 RID: 12946
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x04003293 RID: 12947
		private const string TABLE = "PinballWorldConfig";

		// Token: 0x04003294 RID: 12948
		private const string COMMAND = "select BinData from `PinballWorldConfig` where MapId=?";

		// Token: 0x04003295 RID: 12949
		private const string KEY_PREFIX = "PinballWorldConfigByMapId";

		// Token: 0x04003296 RID: 12950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003297 RID: 12951
		private static int HandleId;
	}
}
