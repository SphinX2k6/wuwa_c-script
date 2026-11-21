using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B3 RID: 1971
	[NetMessage(EMessageId.IllustratedInfoResponse)]
	public sealed class IllustratedInfoResponse : IMessage<IllustratedInfoResponse>, IMessage, IEquatable<IllustratedInfoResponse>, IDeepCloneable<IllustratedInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B1C7 RID: 45511 RVA: 0x001AA251 File Offset: 0x001A8451
		[NullableContext(1)]
		public static IllustratedInfoResponse Create()
		{
			return new IllustratedInfoResponse();
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600B1C8 RID: 45512 RVA: 0x001AA258 File Offset: 0x001A8458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600B1C9 RID: 45513 RVA: 0x001AA25B File Offset: 0x001A845B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x001AA262 File Offset: 0x001A8462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse()
		{
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x001AA280 File Offset: 0x001A8480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse(IllustratedInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.illustratedClassList_ = other.illustratedClassList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x001AA2D2 File Offset: 0x001A84D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedInfoResponse Clone()
		{
			return new IllustratedInfoResponse(this);
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600B1CD RID: 45517 RVA: 0x001AA2DA File Offset: 0x001A84DA
		// (set) Token: 0x0600B1CE RID: 45518 RVA: 0x001AA2E2 File Offset: 0x001A84E2
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

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600B1CF RID: 45519 RVA: 0x001AA2EB File Offset: 0x001A84EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600B1D0 RID: 45520 RVA: 0x001AA2F3 File Offset: 0x001A84F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedClass> IllustratedClassList
		{
			get
			{
				return this.illustratedClassList_;
			}
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x001AA2FB File Offset: 0x001A84FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedInfoResponse);
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x001AA30C File Offset: 0x001A850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.illustratedClassList_.Equals(other.illustratedClassList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x001AA370 File Offset: 0x001A8570
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
			num ^= this.illustratedClassList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x001AA3D1 File Offset: 0x001A85D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x001AA3DE File Offset: 0x001A85DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x001AA3E8 File Offset: 0x001A85E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.illustratedClassList_.WriteTo(ref output, IllustratedInfoResponse._repeated_illustratedClassList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, IllustratedInfoResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x001AA448 File Offset: 0x001A8648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(IllustratedInfoResponse._repeated_errorParams_codec);
			num += this.illustratedClassList_.CalculateSize(IllustratedInfoResponse._repeated_illustratedClassList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x001AA4AC File Offset: 0x001A86AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedInfoResponse other)
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
			this.illustratedClassList_.Add(other.illustratedClassList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x001AA50A File Offset: 0x001A870A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x001AA514 File Offset: 0x001A8714
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
				if (num != 18U)
				{
					if (num != 80U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, IllustratedInfoResponse._repeated_errorParams_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.illustratedClassList_.AddEntriesFrom(ref input, IllustratedInfoResponse._repeated_illustratedClassList_codec);
				}
			}
		}

		// Token: 0x04004FF0 RID: 20464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FF1 RID: 20465
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004FF2 RID: 20466
		private ErrorCode errorCode_;

		// Token: 0x04004FF3 RID: 20467
		public const int ErrorParamsFieldNumber = 15;

		// Token: 0x04004FF4 RID: 20468
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(122U);

		// Token: 0x04004FF5 RID: 20469
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04004FF6 RID: 20470
		public const int IllustratedClassListFieldNumber = 2;

		// Token: 0x04004FF7 RID: 20471
		private static readonly FieldCodec<IllustratedClass> _repeated_illustratedClassList_codec = FieldCodec.ForMessage<IllustratedClass>(18U, IllustratedClass.Parser);

		// Token: 0x04004FF8 RID: 20472
		private readonly RepeatedField<IllustratedClass> illustratedClassList_ = new RepeatedField<IllustratedClass>();
	}
}
