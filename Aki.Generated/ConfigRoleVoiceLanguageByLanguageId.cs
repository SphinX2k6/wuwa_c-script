using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D6 RID: 2262
	public class ConfigRoleVoiceLanguageByLanguageId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003517 RID: 13591 RVA: 0x0018570F File Offset: 0x0018390F
		static ConfigRoleVoiceLanguageByLanguageId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleVoiceLanguageByLanguageId.CreateStaticDefaultValue), new Action(ConfigRoleVoiceLanguageByLanguageId.ResetStaticDefaultValue));
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00185730 File Offset: 0x00183930
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

		// Token: 0x06003519 RID: 13593 RVA: 0x001857AF File Offset: 0x001839AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleVoiceLanguageByLanguageId.LogPair = null;
			ConfigRoleVoiceLanguageByLanguageId.HandleId = 0;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x001857BD File Offset: 0x001839BD
		public static void Init()
		{
			ConfigRoleVoiceLanguageByLanguageId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleVoiceLanguageByLanguageId.HandleId, "db_menu.db", "select BinData from `RoleVoiceLanguage` where LanguageId=?");
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x001857D8 File Offset: 0x001839D8
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

		// Token: 0x04003DC0 RID: 15808
		private const string DB = "db_menu.db";

		// Token: 0x04003DC1 RID: 15809
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04003DC2 RID: 15810
		private const string TABLE = "RoleVoiceLanguage";

		// Token: 0x04003DC3 RID: 15811
		private const string COMMAND = "select BinData from `RoleVoiceLanguage` where LanguageId=?";

		// Token: 0x04003DC4 RID: 15812
		private const string KEY_PREFIX = "RoleVoiceLanguageByLanguageId";

		// Token: 0x04003DC5 RID: 15813
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DC6 RID: 15814
		private static int HandleId;
	}
}
