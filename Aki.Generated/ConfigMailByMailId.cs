using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000515 RID: 1301
	public class ConfigMailByMailId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E89 RID: 7817 RVA: 0x001095F0 File Offset: 0x001077F0
		static ConfigMailByMailId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailByMailId.CreateStaticDefaultValue), new Action(ConfigMailByMailId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00109610 File Offset: 0x00107810
		public static void CreateStaticDefaultValue()
		{
			ConfigMailByMailId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMailByMailId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mail.db"),
				new ValueTuple<string, object>("文件", "y.邮件.xlsx"),
				new ValueTuple<string, object>("表名", "Mail"),
				new ValueTuple<string, object>("语句", "select BinData from `Mail` where MailId=?")
			});
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0010968F File Offset: 0x0010788F
		public static void ResetStaticDefaultValue()
		{
			ConfigMailByMailId.LogPair = null;
			ConfigMailByMailId.HandleId = 0;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0010969D File Offset: 0x0010789D
		public static void Init()
		{
			ConfigMailByMailId.HandleId = ConfigCommon.InitDataStatement(ConfigMailByMailId.HandleId, "db_mail.db", "select BinData from `Mail` where MailId=?");
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x001096B8 File Offset: 0x001078B8
		public static Mail? GetConfig(int p0MailId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMailByMailId.HandleId, ConfigMailByMailId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailByMailId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MailId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Mail?(Mail.GetRootAsMail(configBuffer));
				}
			}
			ConfigMailByMailId.LogPair.Clear();
			ConfigMailByMailId.LogPair.Add(new ValueTuple<string, object>("MailId", p0MailId));
			if (!ConfigCommon.BindInt(ConfigMailByMailId.HandleId, 1, p0MailId, ConfigMailByMailId.LogPair) || ConfigCommon.Step(ConfigMailByMailId.HandleId, true, ConfigMailByMailId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMailByMailId.HandleId, ConfigMailByMailId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMailByMailId.HandleId, 0, ConfigMailByMailId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMailByMailId.HandleId, ConfigMailByMailId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Mail rootAsMail = Mail.GetRootAsMail(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailByMailId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MailId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMailByMailId.HandleId, ConfigMailByMailId.LogPair);
			return new Mail?(rootAsMail);
		}

		// Token: 0x04002377 RID: 9079
		private const string DB = "db_mail.db";

		// Token: 0x04002378 RID: 9080
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x04002379 RID: 9081
		private const string TABLE = "Mail";

		// Token: 0x0400237A RID: 9082
		private const string COMMAND = "select BinData from `Mail` where MailId=?";

		// Token: 0x0400237B RID: 9083
		private const string KEY_PREFIX = "MailByMailId";

		// Token: 0x0400237C RID: 9084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400237D RID: 9085
		private static int HandleId;
	}
}
