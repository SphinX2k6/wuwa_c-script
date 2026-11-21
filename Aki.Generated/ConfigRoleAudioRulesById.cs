using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A1 RID: 2209
	public class ConfigRoleAudioRulesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x00181FC3 File Offset: 0x001801C3
		static ConfigRoleAudioRulesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleAudioRulesById.CreateStaticDefaultValue), new Action(ConfigRoleAudioRulesById.ResetStaticDefaultValue));
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00181FE4 File Offset: 0x001801E4
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

		// Token: 0x060033DA RID: 13274 RVA: 0x00182063 File Offset: 0x00180263
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleAudioRulesById.LogPair = null;
			ConfigRoleAudioRulesById.HandleId = 0;
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00182071 File Offset: 0x00180271
		public static void Init()
		{
			ConfigRoleAudioRulesById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleAudioRulesById.HandleId, "db_audio.db", "select BinData from `RoleAudioRules` where Id=?");
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0018208C File Offset: 0x0018028C
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

		// Token: 0x04003C4D RID: 15437
		private const string DB = "db_audio.db";

		// Token: 0x04003C4E RID: 15438
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003C4F RID: 15439
		private const string TABLE = "RoleAudioRules";

		// Token: 0x04003C50 RID: 15440
		private const string COMMAND = "select BinData from `RoleAudioRules` where Id=?";

		// Token: 0x04003C51 RID: 15441
		private const string KEY_PREFIX = "RoleAudioRulesById";

		// Token: 0x04003C52 RID: 15442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C53 RID: 15443
		private static int HandleId;
	}
}
