using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BF RID: 1727
	public class ConfigPhoneMessageAttachmentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600288A RID: 10378 RVA: 0x0013EC34 File Offset: 0x0013CE34
		static ConfigPhoneMessageAttachmentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneMessageAttachmentById.CreateStaticDefaultValue), new Action(ConfigPhoneMessageAttachmentById.ResetStaticDefaultValue));
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0013EC54 File Offset: 0x0013CE54
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

		// Token: 0x0600288C RID: 10380 RVA: 0x0013ECD3 File Offset: 0x0013CED3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneMessageAttachmentById.LogPair = null;
			ConfigPhoneMessageAttachmentById.HandleId = 0;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0013ECE1 File Offset: 0x0013CEE1
		public static void Init()
		{
			ConfigPhoneMessageAttachmentById.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneMessageAttachmentById.HandleId, "db_phonemessageattachment.db", "select BinData from `PhoneMessageAttachment` where Id=?");
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0013ECFC File Offset: 0x0013CEFC
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

		// Token: 0x04002F1F RID: 12063
		private const string DB = "db_phonemessageattachment.db";

		// Token: 0x04002F20 RID: 12064
		private const string FILE = "k.可视化编辑/c.Csv/s.手机短信附件/*.csv*";

		// Token: 0x04002F21 RID: 12065
		private const string TABLE = "PhoneMessageAttachment";

		// Token: 0x04002F22 RID: 12066
		private const string COMMAND = "select BinData from `PhoneMessageAttachment` where Id=?";

		// Token: 0x04002F23 RID: 12067
		private const string KEY_PREFIX = "PhoneMessageAttachmentById";

		// Token: 0x04002F24 RID: 12068
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F25 RID: 12069
		private static int HandleId;
	}
}
