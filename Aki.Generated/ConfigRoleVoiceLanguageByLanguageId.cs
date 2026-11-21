using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000921 RID: 2337
	public class ConfigRoleVoiceLanguageByLanguageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036D9 RID: 14041 RVA: 0x0019292F File Offset: 0x00190B2F
		static ConfigRoleVoiceLanguageByLanguageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleVoiceLanguageByLanguageId.CreateStaticDefaultValue), new Action(ConfigRoleVoiceLanguageByLanguageId.ResetStaticDefaultValue));
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00192950 File Offset: 0x00190B50
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageByLanguageId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleVoiceLanguageByLanguageId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "RoleVoiceLanguage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleVoiceLanguage` where LanguageId=?")
			});
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x001929CF File Offset: 0x00190BCF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageByLanguageId.LogPair = null;
			ConfigRoleVoiceLanguageByLanguageId.HandleId = 0;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x001929DD File Offset: 0x00190BDD
		public static void Init()
		{
			ConfigRoleVoiceLanguageByLanguageId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleVoiceLanguageByLanguageId.HandleId, "db_menu.db", "select BinData from `RoleVoiceLanguage` where LanguageId=?");
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x001929F8 File Offset: 0x00190BF8
		public static RoleVoiceLanguage? GetConfig(int p0LanguageId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleVoiceLanguageByLanguageId.HandleId, ConfigRoleVoiceLanguageByLanguageId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleVoiceLanguageByLanguageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LanguageId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleVoiceLanguage?(RoleVoiceLanguage.GetRootAsRoleVoiceLanguage(configBuffer));
				}
			}
			ConfigRoleVoiceLanguageByLanguageId.LogPair.Clear();
			ConfigRoleVoiceLanguageByLanguageId.LogPair.Add(new ValueTuple<string, object>("LanguageId", p0LanguageId));
			if (!ConfigCommon.BindInt(ConfigRoleVoiceLanguageByLanguageId.HandleId, 1, p0LanguageId, ConfigRoleVoiceLanguageByLanguageId.LogPair) || ConfigCommon.Step(ConfigRoleVoiceLanguageByLanguageId.HandleId, true, ConfigRoleVoiceLanguageByLanguageId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleVoiceLanguageByLanguageId.HandleId, ConfigRoleVoiceLanguageByLanguageId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleVoiceLanguageByLanguageId.HandleId, 0, ConfigRoleVoiceLanguageByLanguageId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleVoiceLanguageByLanguageId.HandleId, ConfigRoleVoiceLanguageByLanguageId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleVoiceLanguage rootAsRoleVoiceLanguage = RoleVoiceLanguage.GetRootAsRoleVoiceLanguage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleVoiceLanguageByLanguageId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LanguageId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleVoiceLanguageByLanguageId.HandleId, ConfigRoleVoiceLanguageByLanguageId.LogPair);
			return new RoleVoiceLanguage?(rootAsRoleVoiceLanguage);
		}

		// Token: 0x04003FCD RID: 16333
		private const string DB = "db_menu.db";

		// Token: 0x04003FCE RID: 16334
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04003FCF RID: 16335
		private const string TABLE = "RoleVoiceLanguage";

		// Token: 0x04003FD0 RID: 16336
		private const string COMMAND = "select BinData from `RoleVoiceLanguage` where LanguageId=?";

		// Token: 0x04003FD1 RID: 16337
		private const string KEY_PREFIX = "RoleVoiceLanguageByLanguageId";

		// Token: 0x04003FD2 RID: 16338
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FD3 RID: 16339
		private static int HandleId;
	}
}
