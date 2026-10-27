using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072D RID: 1837
	public class ConfigPinballRoleLevelConfigByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B1E RID: 11038 RVA: 0x0014D1F8 File Offset: 0x0014B3F8
		static ConfigPinballRoleLevelConfigByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigByGroupId.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0014D218 File Offset: 0x0014B418
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleLevelConfigByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleLevelConfig` where GroupId=?")
			});
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0014D297 File Offset: 0x0014B497
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupId.LogPair = null;
			ConfigPinballRoleLevelConfigByGroupId.HandleId = 0;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0014D2A5 File Offset: 0x0014B4A5
		public static void Init()
		{
			ConfigPinballRoleLevelConfigByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigByGroupId.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where GroupId=?");
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0014D2C0 File Offset: 0x0014B4C0
		[NullableContext(2)]
		public static IReadOnlyList<PinballRoleLevelConfig> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleLevelConfigByGroupId.HandleId, ConfigPinballRoleLevelConfigByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PinballRoleLevelConfig> readOnlyList = (IReadOnlyList<PinballRoleLevelConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPinballRoleLevelConfigByGroupId.LogPair.Clear();
			ConfigPinballRoleLevelConfigByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPinballRoleLevelConfigByGroupId.HandleId, 1, p0GroupId, ConfigPinballRoleLevelConfigByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupId.HandleId, ConfigPinballRoleLevelConfigByGroupId.LogPair);
				return null;
			}
			List<PinballRoleLevelConfig> list = new List<PinballRoleLevelConfig>();
			while (ConfigCommon.Step(ConfigPinballRoleLevelConfigByGroupId.HandleId, false, ConfigPinballRoleLevelConfigByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleLevelConfigByGroupId.HandleId, 0, ConfigPinballRoleLevelConfigByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupId.HandleId, ConfigPinballRoleLevelConfigByGroupId.LogPair);
					return null;
				}
				PinballRoleLevelConfig rootAsPinballRoleLevelConfig = PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballRoleLevelConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupId.HandleId, ConfigPinballRoleLevelConfigByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003221 RID: 12833
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003222 RID: 12834
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003223 RID: 12835
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x04003224 RID: 12836
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where GroupId=?";

		// Token: 0x04003225 RID: 12837
		private const string KEY_PREFIX = "PinballRoleLevelConfigByGroupId";

		// Token: 0x04003226 RID: 12838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003227 RID: 12839
		private static int HandleId;
	}
}
