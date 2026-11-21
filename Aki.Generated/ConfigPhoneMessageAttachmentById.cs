using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D7 RID: 1751
	public class ConfigPhoneMessageAttachmentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600291A RID: 10522 RVA: 0x001456B0 File Offset: 0x001438B0
		static ConfigPhoneMessageAttachmentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneMessageAttachmentById.CreateStaticDefaultValue), new Action(ConfigPhoneMessageAttachmentById.ResetStaticDefaultValue));
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x001456D0 File Offset: 0x001438D0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhoneMessageAttachmentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhoneMessageAttachmentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemessageattachment.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/s.手机短信附件/*.csv*"),
				new ValueTuple<string, object>("表名", "PhoneMessageAttachment"),
				new ValueTuple<string, object>("语句", "select BinData from `PhoneMessageAttachment` where Id=?")
			});
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0014574F File Offset: 0x0014394F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneMessageAttachmentById.LogPair = null;
			ConfigPhoneMessageAttachmentById.HandleId = 0;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0014575D File Offset: 0x0014395D
		public static void Init()
		{
			ConfigPhoneMessageAttachmentById.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneMessageAttachmentById.HandleId, "db_phonemessageattachment.db", "select BinData from `PhoneMessageAttachment` where Id=?");
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00145778 File Offset: 0x00143978
		public static PhoneMessageAttachment? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhoneMessageAttachmentById.HandleId, ConfigPhoneMessageAttachmentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneMessageAttachmentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhoneMessageAttachment?(PhoneMessageAttachment.GetRootAsPhoneMessageAttachment(configBuffer));
				}
			}
			ConfigPhoneMessageAttachmentById.LogPair.Clear();
			ConfigPhoneMessageAttachmentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhoneMessageAttachmentById.HandleId, 1, p0Id, ConfigPhoneMessageAttachmentById.LogPair) || ConfigCommon.Step(ConfigPhoneMessageAttachmentById.HandleId, true, ConfigPhoneMessageAttachmentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhoneMessageAttachmentById.HandleId, ConfigPhoneMessageAttachmentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhoneMessageAttachmentById.HandleId, 0, ConfigPhoneMessageAttachmentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhoneMessageAttachmentById.HandleId, ConfigPhoneMessageAttachmentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhoneMessageAttachment rootAsPhoneMessageAttachment = PhoneMessageAttachment.GetRootAsPhoneMessageAttachment(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneMessageAttachmentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhoneMessageAttachmentById.HandleId, ConfigPhoneMessageAttachmentById.LogPair);
			return new PhoneMessageAttachment?(rootAsPhoneMessageAttachment);
		}

		// Token: 0x04002FC7 RID: 12231
		private const string DB = "db_phonemessageattachment.db";

		// Token: 0x04002FC8 RID: 12232
		private const string FILE = "k.可视化编辑/c.Csv/s.手机短信附件/*.csv*";

		// Token: 0x04002FC9 RID: 12233
		private const string TABLE = "PhoneMessageAttachment";

		// Token: 0x04002FCA RID: 12234
		private const string COMMAND = "select BinData from `PhoneMessageAttachment` where Id=?";

		// Token: 0x04002FCB RID: 12235
		private const string KEY_PREFIX = "PhoneMessageAttachmentById";

		// Token: 0x04002FCC RID: 12236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FCD RID: 12237
		private static int HandleId;
	}
}
