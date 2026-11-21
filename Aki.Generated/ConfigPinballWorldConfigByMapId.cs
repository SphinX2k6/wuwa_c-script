using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000755 RID: 1877
	public class ConfigPinballWorldConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C0E RID: 11278 RVA: 0x00156074 File Offset: 0x00154274
		static ConfigPinballWorldConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWorldConfigByMapId.CreateStaticDefaultValue), new Action(ConfigPinballWorldConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00156094 File Offset: 0x00154294
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

		// Token: 0x06002C10 RID: 11280 RVA: 0x00156113 File Offset: 0x00154313
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWorldConfigByMapId.LogPair = null;
			ConfigPinballWorldConfigByMapId.HandleId = 0;
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00156121 File Offset: 0x00154321
		public static void Init()
		{
			ConfigPinballWorldConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWorldConfigByMapId.HandleId, "db_pinballbattle.db", "select BinData from `PinballWorldConfig` where MapId=?");
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0015613C File Offset: 0x0015433C
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

		// Token: 0x04003339 RID: 13113
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400333A RID: 13114
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x0400333B RID: 13115
		private const string TABLE = "PinballWorldConfig";

		// Token: 0x0400333C RID: 13116
		private const string COMMAND = "select BinData from `PinballWorldConfig` where MapId=?";

		// Token: 0x0400333D RID: 13117
		private const string KEY_PREFIX = "PinballWorldConfigByMapId";

		// Token: 0x0400333E RID: 13118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400333F RID: 13119
		private static int HandleId;
	}
}
