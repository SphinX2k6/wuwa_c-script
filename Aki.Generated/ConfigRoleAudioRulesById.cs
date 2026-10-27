using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000885 RID: 2181
	public class ConfigRoleAudioRulesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003330 RID: 13104 RVA: 0x0017ACDB File Offset: 0x00178EDB
		static ConfigRoleAudioRulesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleAudioRulesById.CreateStaticDefaultValue), new Action(ConfigRoleAudioRulesById.ResetStaticDefaultValue));
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0017ACFC File Offset: 0x00178EFC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleAudioRulesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleAudioRulesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleAudioRules"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleAudioRules` where Id=?")
			});
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0017AD7B File Offset: 0x00178F7B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleAudioRulesById.LogPair = null;
			ConfigRoleAudioRulesById.HandleId = 0;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0017AD89 File Offset: 0x00178F89
		public static void Init()
		{
			ConfigRoleAudioRulesById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleAudioRulesById.HandleId, "db_audio.db", "select BinData from `RoleAudioRules` where Id=?");
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x0017ADA4 File Offset: 0x00178FA4
		public static RoleAudioRules? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleAudioRulesById.HandleId, ConfigRoleAudioRulesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleAudioRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleAudioRules?(RoleAudioRules.GetRootAsRoleAudioRules(configBuffer));
				}
			}
			ConfigRoleAudioRulesById.LogPair.Clear();
			ConfigRoleAudioRulesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleAudioRulesById.HandleId, 1, p0Id, ConfigRoleAudioRulesById.LogPair) || ConfigCommon.Step(ConfigRoleAudioRulesById.HandleId, true, ConfigRoleAudioRulesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleAudioRulesById.HandleId, ConfigRoleAudioRulesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleAudioRulesById.HandleId, 0, ConfigRoleAudioRulesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleAudioRulesById.HandleId, ConfigRoleAudioRulesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleAudioRules rootAsRoleAudioRules = RoleAudioRules.GetRootAsRoleAudioRules(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleAudioRulesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleAudioRulesById.HandleId, ConfigRoleAudioRulesById.LogPair);
			return new RoleAudioRules?(rootAsRoleAudioRules);
		}

		// Token: 0x04003B89 RID: 15241
		private const string DB = "db_audio.db";

		// Token: 0x04003B8A RID: 15242
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003B8B RID: 15243
		private const string TABLE = "RoleAudioRules";

		// Token: 0x04003B8C RID: 15244
		private const string COMMAND = "select BinData from `RoleAudioRules` where Id=?";

		// Token: 0x04003B8D RID: 15245
		private const string KEY_PREFIX = "RoleAudioRulesById";

		// Token: 0x04003B8E RID: 15246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B8F RID: 15247
		private static int HandleId;
	}
}
