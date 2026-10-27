using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B4 RID: 2228
	public class ConfigRoleInfoLangByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600344B RID: 13387 RVA: 0x00180C57 File Offset: 0x0017EE57
		static ConfigRoleInfoLangByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoLangByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleInfoLangByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00180C78 File Offset: 0x0017EE78
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoLangByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoLangByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoLang"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoLang` where RoleId=?")
			});
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00180CF7 File Offset: 0x0017EEF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoLangByRoleId.LogPair = null;
			ConfigRoleInfoLangByRoleId.HandleId = 0;
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00180D05 File Offset: 0x0017EF05
		public static void Init()
		{
			ConfigRoleInfoLangByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoLangByRoleId.HandleId, "db_audio.db", "select BinData from `RoleInfoLang` where RoleId=?");
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00180D20 File Offset: 0x0017EF20
		public static RoleInfoLang? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoLangByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleInfoLang?(RoleInfoLang.GetRootAsRoleInfoLang(configBuffer));
				}
			}
			ConfigRoleInfoLangByRoleId.LogPair.Clear();
			ConfigRoleInfoLangByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleInfoLangByRoleId.HandleId, 1, p0RoleId, ConfigRoleInfoLangByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleInfoLangByRoleId.HandleId, true, ConfigRoleInfoLangByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoLangByRoleId.HandleId, 0, ConfigRoleInfoLangByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleInfoLang rootAsRoleInfoLang = RoleInfoLang.GetRootAsRoleInfoLang(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoLangByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
			return new RoleInfoLang?(rootAsRoleInfoLang);
		}

		// Token: 0x04003CD2 RID: 15570
		private const string DB = "db_audio.db";

		// Token: 0x04003CD3 RID: 15571
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CD4 RID: 15572
		private const string TABLE = "RoleInfoLang";

		// Token: 0x04003CD5 RID: 15573
		private const string COMMAND = "select BinData from `RoleInfoLang` where RoleId=?";

		// Token: 0x04003CD6 RID: 15574
		private const string KEY_PREFIX = "RoleInfoLangByRoleId";

		// Token: 0x04003CD7 RID: 15575
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CD8 RID: 15576
		private static int HandleId;
	}
}
