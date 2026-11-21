using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000745 RID: 1861
	public class ConfigPinballRoleLevelConfigByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BAE RID: 11182 RVA: 0x00153C74 File Offset: 0x00151E74
		static ConfigPinballRoleLevelConfigByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigByGroupId.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00153C94 File Offset: 0x00151E94
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

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00153D13 File Offset: 0x00151F13
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupId.LogPair = null;
			ConfigPinballRoleLevelConfigByGroupId.HandleId = 0;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00153D21 File Offset: 0x00151F21
		public static void Init()
		{
			ConfigPinballRoleLevelConfigByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigByGroupId.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where GroupId=?");
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00153D3C File Offset: 0x00151F3C
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

		// Token: 0x040032C9 RID: 13001
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032CA RID: 13002
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032CB RID: 13003
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x040032CC RID: 13004
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where GroupId=?";

		// Token: 0x040032CD RID: 13005
		private const string KEY_PREFIX = "PinballRoleLevelConfigByGroupId";

		// Token: 0x040032CE RID: 13006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032CF RID: 13007
		private static int HandleId;
	}
}
