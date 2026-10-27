using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000502 RID: 1282
	public class ConfigMailToById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x001034C0 File Offset: 0x001016C0
		static ConfigMailToById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMailToById.CreateStaticDefaultValue), new Action(ConfigMailToById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x001034E0 File Offset: 0x001016E0
		public static void CreateStaticDefaultValue()
		{
			ConfigMailToById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMailToById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mail.db"),
				new ValueTuple<string, object>("文件", "y.邮件.xlsx"),
				new ValueTuple<string, object>("表名", "MailTo"),
				new ValueTuple<string, object>("语句", "select BinData from `MailTo` where Id=?")
			});
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0010355F File Offset: 0x0010175F
		public static void ResetStaticDefaultValue()
		{
			ConfigMailToById.LogPair = null;
			ConfigMailToById.HandleId = 0;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0010356D File Offset: 0x0010176D
		public static void Init()
		{
			ConfigMailToById.HandleId = ConfigCommon.InitDataStatement(ConfigMailToById.HandleId, "db_mail.db", "select BinData from `MailTo` where Id=?");
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00103588 File Offset: 0x00101788
		public static MailTo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMailToById.HandleId, ConfigMailToById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailToById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MailTo?(MailTo.GetRootAsMailTo(configBuffer));
				}
			}
			ConfigMailToById.LogPair.Clear();
			ConfigMailToById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMailToById.HandleId, 1, p0Id, ConfigMailToById.LogPair) || ConfigCommon.Step(ConfigMailToById.HandleId, true, ConfigMailToById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMailToById.HandleId, ConfigMailToById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMailToById.HandleId, 0, ConfigMailToById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMailToById.HandleId, ConfigMailToById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MailTo rootAsMailTo = MailTo.GetRootAsMailTo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MailToById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMailToById.HandleId, ConfigMailToById.LogPair);
			return new MailTo?(rootAsMailTo);
		}

		// Token: 0x040022F2 RID: 8946
		private const string DB = "db_mail.db";

		// Token: 0x040022F3 RID: 8947
		private const string FILE = "y.邮件.xlsx";

		// Token: 0x040022F4 RID: 8948
		private const string TABLE = "MailTo";

		// Token: 0x040022F5 RID: 8949
		private const string COMMAND = "select BinData from `MailTo` where Id=?";

		// Token: 0x040022F6 RID: 8950
		private const string KEY_PREFIX = "MailToById";

		// Token: 0x040022F7 RID: 8951
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022F8 RID: 8952
		private static int HandleId;
	}
}
