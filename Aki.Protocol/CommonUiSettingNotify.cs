using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C1 RID: 705
	[NetMessage(EMessageId.CommonUiSettingNotify)]
	public sealed class CommonUiSettingNotify : IMessage<CommonUiSettingNotify>, IMessage, IEquatable<CommonUiSettingNotify>, IDeepCloneable<CommonUiSettingNotify>, IBufferMessage
	{
		// Token: 0x06004892 RID: 18578 RVA: 0x000B1C19 File Offset: 0x000AFE19
		[NullableContext(1)]
		public static CommonUiSettingNotify Create()
		{
			return new CommonUiSettingNotify();
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x000B1C20 File Offset: 0x000AFE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x000B1C23 File Offset: 0x000AFE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonUiSettingNotify.Descriptor;
			}
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x000B1C2A File Offset: 0x000AFE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify()
		{
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x000B1C3D File Offset: 0x000AFE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify(CommonUiSettingNotify other) : this()
		{
			this.commonUiButtonSetting_ = other.commonUiButtonSetting_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x000B1C67 File Offset: 0x000AFE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify Clone()
		{
			return new CommonUiSettingNotify(this);
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x000B1C6F File Offset: 0x000AFE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> CommonUiButtonSetting
		{
			get
			{
				return this.commonUiButtonSetting_;
			}
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x000B1C77 File Offset: 0x000AFE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonUiSettingNotify);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x000B1C85 File Offset: 0x000AFE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonUiSettingNotify other)
		{
			return other != null && (other == this || (this.commonUiButtonSetting_.Equals(other.commonUiButtonSetting_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x000B1CB8 File Offset: 0x000AFEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.commonUiButtonSetting_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x000B1CEC File Offset: 0x000AFEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x000B1CF9 File Offset: 0x000AFEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x000B1D02 File Offset: 0x000AFF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.commonUiButtonSetting_.WriteTo(ref output, CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x000B1D2C File Offset: 0x000AFF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.commonUiButtonSetting_.CalculateSize(CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x000B1D65 File Offset: 0x000AFF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonUiSettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.commonUiButtonSetting_.Add(other.commonUiButtonSetting_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x000B1D93 File Offset: 0x000AFF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x000B1D9C File Offset: 0x000AFF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.commonUiButtonSetting_.AddEntriesFrom(ref input, CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
				}
			}
		}

		// Token: 0x04002FE9 RID: 12265
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FEA RID: 12266
		public const int CommonUiButtonSettingFieldNumber = 1;

		// Token: 0x04002FEB RID: 12267
		private static readonly FieldCodec<MobileButtonSetting> _repeated_commonUiButtonSetting_codec = FieldCodec.ForMessage<MobileButtonSetting>(10U, MobileButtonSetting.Parser);

		// Token: 0x04002FEC RID: 12268
		private readonly RepeatedField<MobileButtonSetting> commonUiButtonSetting_ = new RepeatedField<MobileButtonSetting>();
	}
}
