using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FF RID: 1279
	public class ConfigMailByMailId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x00102E9C File Offset: 0x0010109C
		static ConfigMailByMailId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailByMailId.CreateStaticDefaultValue), new Action(ConfigMailByMailId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00102EBC File Offset: 0x001010BC
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

		// Token: 0x06001E07 RID: 7687 RVA: 0x00102F3B File Offset: 0x0010113B
		public static void ResetStaticDefaultValue()
		{
			ConfigMailByMailId.LogPair = null;
			ConfigMailByMailId.HandleId = 0;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00102F49 File Offset: 0x00101149
		public static void Init()
		{
			ConfigMailByMailId.HandleId = ConfigCommon.InitDataStatement(ConfigMailByMailId.HandleId, "db_mail.db", "select BinData from `Mail` where MailId=?");
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00102F64 File Offset: 0x00101164
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

		// Token: 0x040022DD RID: 8925
		private const string DB = "db_mail.db";

		// Token: 0x040022DE RID: 8926
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x040022DF RID: 8927
		private const string TABLE = "Mail";

		// Token: 0x040022E0 RID: 8928
		private const string COMMAND = "select BinData from `Mail` where MailId=?";

		// Token: 0x040022E1 RID: 8929
		private const string KEY_PREFIX = "MailByMailId";

		// Token: 0x040022E2 RID: 8930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022E3 RID: 8931
		private static int HandleId;
	}
}
