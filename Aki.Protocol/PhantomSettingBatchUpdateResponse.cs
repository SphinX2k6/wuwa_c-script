using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF0 RID: 3312
	[NetMessage(EMessageId.PhantomSettingBatchUpdateResponse)]
	public sealed class PhantomSettingBatchUpdateResponse : IMessage<PhantomSettingBatchUpdateResponse>, IMessage, IEquatable<PhantomSettingBatchUpdateResponse>, IDeepCloneable<PhantomSettingBatchUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011EDA RID: 73434 RVA: 0x0029F91D File Offset: 0x0029DB1D
		[NullableContext(1)]
		public static PhantomSettingBatchUpdateResponse Create()
		{
			return new PhantomSettingBatchUpdateResponse();
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x06011EDB RID: 73435 RVA: 0x0029F924 File Offset: 0x0029DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x06011EDC RID: 73436 RVA: 0x0029F927 File Offset: 0x0029DB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingBatchUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011EDD RID: 73437 RVA: 0x0029F92E File Offset: 0x0029DB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse()
		{
		}

		// Token: 0x06011EDE RID: 73438 RVA: 0x0029F941 File Offset: 0x0029DB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse(PhantomSettingBatchUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.settings_ = other.settings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EDF RID: 73439 RVA: 0x0029F977 File Offset: 0x0029DB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse Clone()
		{
			return new PhantomSettingBatchUpdateResponse(this);
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x06011EE0 RID: 73440 RVA: 0x0029F97F File Offset: 0x0029DB7F
		// (set) Token: 0x06011EE1 RID: 73441 RVA: 0x0029F987 File Offset: 0x0029DB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x06011EE2 RID: 73442 RVA: 0x0029F990 File Offset: 0x0029DB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomSettingInfo> Settings
		{
			get
			{
				return this.settings_;
			}
		}

		// Token: 0x06011EE3 RID: 73443 RVA: 0x0029F998 File Offset: 0x0029DB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingBatchUpdateResponse);
		}

		// Token: 0x06011EE4 RID: 73444 RVA: 0x0029F9A8 File Offset: 0x0029DBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingBatchUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.settings_.Equals(other.settings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EE5 RID: 73445 RVA: 0x0029F9F8 File Offset: 0x0029DBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.settings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011EE6 RID: 73446 RVA: 0x0029FA4B File Offset: 0x0029DC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EE7 RID: 73447 RVA: 0x0029FA58 File Offset: 0x0029DC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EE8 RID: 73448 RVA: 0x0029FA64 File Offset: 0x0029DC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.settings_.WriteTo(ref output, PhantomSettingBatchUpdateResponse._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EE9 RID: 73449 RVA: 0x0029FAB4 File Offset: 0x0029DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.settings_.CalculateSize(PhantomSettingBatchUpdateResponse._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EEA RID: 73450 RVA: 0x0029FB08 File Offset: 0x0029DD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingBatchUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.settings_.Add(other.settings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011EEB RID: 73451 RVA: 0x0029FB55 File Offset: 0x0029DD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EEC RID: 73452 RVA: 0x0029FB60 File Offset: 0x0029DD60
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
				if (num != 8U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.settings_.AddEntriesFrom(ref input, PhantomSettingBatchUpdateResponse._repeated_settings_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070D2 RID: 28882
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070D3 RID: 28883
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040070D4 RID: 28884
		private ErrorCode errorCode_;

		// Token: 0x040070D5 RID: 28885
		public const int SettingsFieldNumber = 9;

		// Token: 0x040070D6 RID: 28886
		private static readonly FieldCodec<PhantomSettingInfo> _repeated_settings_codec = FieldCodec.ForMessage<PhantomSettingInfo>(74U, PhantomSettingInfo.Parser);

		// Token: 0x040070D7 RID: 28887
		private readonly RepeatedField<PhantomSettingInfo> settings_ = new RepeatedField<PhantomSettingInfo>();
	}
}
