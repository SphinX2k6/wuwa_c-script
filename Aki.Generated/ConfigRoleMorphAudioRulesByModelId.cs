using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B8 RID: 2232
	public class ConfigRoleMorphAudioRulesByModelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003463 RID: 13411 RVA: 0x00181463 File Offset: 0x0017F663
		static ConfigRoleMorphAudioRulesByModelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphAudioRulesByModelId.CreateStaticDefaultValue), new Action(ConfigRoleMorphAudioRulesByModelId.ResetStaticDefaultValue));
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00181484 File Offset: 0x0017F684
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

		// Token: 0x06003465 RID: 13413 RVA: 0x00181503 File Offset: 0x0017F703
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphAudioRulesByModelId.LogPair = null;
			ConfigRoleMorphAudioRulesByModelId.HandleId = 0;
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00181511 File Offset: 0x0017F711
		public static void Init()
		{
			ConfigRoleMorphAudioRulesByModelId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphAudioRulesByModelId.HandleId, "db_audio.db", "select BinData from `RoleMorphAudioRules` where MorphId=?");
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x0018152C File Offset: 0x0017F72C
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

		// Token: 0x04003CEE RID: 15598
		private const string DB = "db_audio.db";

		// Token: 0x04003CEF RID: 15599
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CF0 RID: 15600
		private const string TABLE = "RoleMorphAudioRules";

		// Token: 0x04003CF1 RID: 15601
		private const string COMMAND = "select BinData from `RoleMorphAudioRules` where MorphId=?";

		// Token: 0x04003CF2 RID: 15602
		private const string KEY_PREFIX = "RoleMorphAudioRulesByModelId";

		// Token: 0x04003CF3 RID: 15603
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CF4 RID: 15604
		private static int HandleId;
	}
}
