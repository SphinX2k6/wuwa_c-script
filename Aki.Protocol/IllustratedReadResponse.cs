using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B5 RID: 1973
	[NetMessage(EMessageId.IllustratedReadResponse)]
	public sealed class IllustratedReadResponse : IMessage<IllustratedReadResponse>, IMessage, IEquatable<IllustratedReadResponse>, IDeepCloneable<IllustratedReadResponse>, IBufferMessage
	{
		// Token: 0x0600B1F0 RID: 45552 RVA: 0x001AA844 File Offset: 0x001A8A44
		[NullableContext(1)]
		public static IllustratedReadResponse Create()
		{
			return new IllustratedReadResponse();
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x001AA84B File Offset: 0x001A8A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x001AA84E File Offset: 0x001A8A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedReadResponse.Descriptor;
			}
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x001AA855 File Offset: 0x001A8A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse()
		{
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x001AA868 File Offset: 0x001A8A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse(IllustratedReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x001AA89E File Offset: 0x001A8A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse Clone()
		{
			return new IllustratedReadResponse(this);
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600B1F6 RID: 45558 RVA: 0x001AA8A6 File Offset: 0x001A8AA6
		// (set) Token: 0x0600B1F7 RID: 45559 RVA: 0x001AA8AE File Offset: 0x001A8AAE
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

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600B1F8 RID: 45560 RVA: 0x001AA8B7 File Offset: 0x001A8AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x001AA8BF File Offset: 0x001A8ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedReadResponse);
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x001AA8D0 File Offset: 0x001A8AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x001AA920 File Offset: 0x001A8B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x001AA973 File Offset: 0x001A8B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x001AA980 File Offset: 0x001A8B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x001AA98C File Offset: 0x001A8B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, IllustratedReadResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x001AA9DC File Offset: 0x001A8BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(IllustratedReadResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x001AAA30 File Offset: 0x001A8C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x001AAA7D File Offset: 0x001A8C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x001AAA88 File Offset: 0x001A8C88
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
				if (num != 16U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, IllustratedReadResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FFE RID: 20478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FFF RID: 20479
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005000 RID: 20480
		private ErrorCode errorCode_;

		// Token: 0x04005001 RID: 20481
		public const int ErrorParamsFieldNumber = 12;

		// Token: 0x04005002 RID: 20482
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(98U);

		// Token: 0x04005003 RID: 20483
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
