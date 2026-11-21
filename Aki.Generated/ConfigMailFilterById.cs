using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000517 RID: 1303
	public class ConfigMailFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E95 RID: 7829 RVA: 0x001099CB File Offset: 0x00107BCB
		static ConfigMailFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailFilterById.CreateStaticDefaultValue), new Action(ConfigMailFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x001099EC File Offset: 0x00107BEC
		public static void CreateStaticDefaultValue()
		{
			ConfigMailFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMailFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mail.db"),
				new ValueTuple<string, object>("文件", "y.邮件.xlsx"),
				new ValueTuple<string, object>("表名", "MailFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `MailFilter` where Id=?")
			});
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00109A6B File Offset: 0x00107C6B
		public static void ResetStaticDefaultValue()
		{
			ConfigMailFilterById.LogPair = null;
			ConfigMailFilterById.HandleId = 0;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00109A79 File Offset: 0x00107C79
		public static void Init()
		{
			ConfigMailFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigMailFilterById.HandleId, "db_mail.db", "select BinData from `MailFilter` where Id=?");
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00109A94 File Offset: 0x00107C94
		public static MailFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMailFilterById.HandleId, ConfigMailFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MailFilter?(MailFilter.GetRootAsMailFilter(configBuffer));
				}
			}
			ConfigMailFilterById.LogPair.Clear();
			ConfigMailFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMailFilterById.HandleId, 1, p0Id, ConfigMailFilterById.LogPair) || ConfigCommon.Step(ConfigMailFilterById.HandleId, true, ConfigMailFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMailFilterById.HandleId, ConfigMailFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMailFilterById.HandleId, 0, ConfigMailFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMailFilterById.HandleId, ConfigMailFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MailFilter rootAsMailFilter = MailFilter.GetRootAsMailFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMailFilterById.HandleId, ConfigMailFilterById.LogPair);
			return new MailFilter?(rootAsMailFilter);
		}

		// Token: 0x04002385 RID: 9093
		private const string DB = "db_mail.db";

		// Token: 0x04002386 RID: 9094
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x04002387 RID: 9095
		private const string TABLE = "MailFilter";

		// Token: 0x04002388 RID: 9096
		private const string COMMAND = "select BinData from `MailFilter` where Id=?";

		// Token: 0x04002389 RID: 9097
		private const string KEY_PREFIX = "MailFilterById";

		// Token: 0x0400238A RID: 9098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400238B RID: 9099
		private static int HandleId;
	}
}
