using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000501 RID: 1281
	public class ConfigMailFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E11 RID: 7697 RVA: 0x00103277 File Offset: 0x00101477
		static ConfigMailFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailFilterById.CreateStaticDefaultValue), new Action(ConfigMailFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00103298 File Offset: 0x00101498
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

		// Token: 0x06001E13 RID: 7699 RVA: 0x00103317 File Offset: 0x00101517
		public static void ResetStaticDefaultValue()
		{
			ConfigMailFilterById.LogPair = null;
			ConfigMailFilterById.HandleId = 0;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00103325 File Offset: 0x00101525
		public static void Init()
		{
			ConfigMailFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigMailFilterById.HandleId, "db_mail.db", "select BinData from `MailFilter` where Id=?");
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00103340 File Offset: 0x00101540
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

		// Token: 0x040022EB RID: 8939
		private const string DB = "db_mail.db";

		// Token: 0x040022EC RID: 8940
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x040022ED RID: 8941
		private const string TABLE = "MailFilter";

		// Token: 0x040022EE RID: 8942
		private const string COMMAND = "select BinData from `MailFilter` where Id=?";

		// Token: 0x040022EF RID: 8943
		private const string KEY_PREFIX = "MailFilterById";

		// Token: 0x040022F0 RID: 8944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022F1 RID: 8945
		private static int HandleId;
	}
}
