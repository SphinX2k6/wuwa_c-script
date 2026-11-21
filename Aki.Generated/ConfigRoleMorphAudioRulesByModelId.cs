using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D4 RID: 2260
	public class ConfigRoleMorphAudioRulesByModelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600350B RID: 13579 RVA: 0x0018874B File Offset: 0x0018694B
		static ConfigRoleMorphAudioRulesByModelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAudioRulesByModelId.CreateStaticDefaultValue), new Action(ConfigRoleMorphAudioRulesByModelId.ResetStaticDefaultValue));
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0018876C File Offset: 0x0018696C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesByModelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphAudioRulesByModelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorphAudioRules"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorphAudioRules` where MorphId=?")
			});
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x001887EB File Offset: 0x001869EB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesByModelId.LogPair = null;
			ConfigRoleMorphAudioRulesByModelId.HandleId = 0;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x001887F9 File Offset: 0x001869F9
		public static void Init()
		{
			ConfigRoleMorphAudioRulesByModelId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAudioRulesByModelId.HandleId, "db_audio.db", "select BinData from `RoleMorphAudioRules` where MorphId=?");
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00188814 File Offset: 0x00186A14
		public static RoleMorphAudioRules? GetConfig(int p0MorphId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphAudioRulesByModelId.HandleId, ConfigRoleMorphAudioRulesByModelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphAudioRulesByModelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MorphId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleMorphAudioRules?(RoleMorphAudioRules.GetRootAsRoleMorphAudioRules(configBuffer));
				}
			}
			ConfigRoleMorphAudioRulesByModelId.LogPair.Clear();
			ConfigRoleMorphAudioRulesByModelId.LogPair.Add(new ValueTuple<string, object>("MorphId", p0MorphId));
			if (!ConfigCommon.BindInt(ConfigRoleMorphAudioRulesByModelId.HandleId, 1, p0MorphId, ConfigRoleMorphAudioRulesByModelId.LogPair) || ConfigCommon.Step(ConfigRoleMorphAudioRulesByModelId.HandleId, true, ConfigRoleMorphAudioRulesByModelId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleMorphAudioRulesByModelId.HandleId, ConfigRoleMorphAudioRulesByModelId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphAudioRulesByModelId.HandleId, 0, ConfigRoleMorphAudioRulesByModelId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleMorphAudioRulesByModelId.HandleId, ConfigRoleMorphAudioRulesByModelId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleMorphAudioRules rootAsRoleMorphAudioRules = RoleMorphAudioRules.GetRootAsRoleMorphAudioRules(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphAudioRulesByModelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MorphId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleMorphAudioRulesByModelId.HandleId, ConfigRoleMorphAudioRulesByModelId.LogPair);
			return new RoleMorphAudioRules?(rootAsRoleMorphAudioRules);
		}

		// Token: 0x04003DB2 RID: 15794
		private const string DB = "db_audio.db";

		// Token: 0x04003DB3 RID: 15795
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003DB4 RID: 15796
		private const string TABLE = "RoleMorphAudioRules";

		// Token: 0x04003DB5 RID: 15797
		private const string COMMAND = "select BinData from `RoleMorphAudioRules` where MorphId=?";

		// Token: 0x04003DB6 RID: 15798
		private const string KEY_PREFIX = "RoleMorphAudioRulesByModelId";

		// Token: 0x04003DB7 RID: 15799
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DB8 RID: 15800
		private static int HandleId;
	}
}
