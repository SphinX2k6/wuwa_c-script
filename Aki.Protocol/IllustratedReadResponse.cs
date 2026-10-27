using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C9 RID: 1993
	[NetMessage(EMessageId.IllustratedReadResponse)]
	public sealed class IllustratedReadResponse : IMessage<IllustratedReadResponse>, IMessage, IEquatable<IllustratedReadResponse>, IDeepCloneable<IllustratedReadResponse>, IBufferMessage
	{
		// Token: 0x0600B346 RID: 45894 RVA: 0x001AD274 File Offset: 0x001AB474
		[NullableContext(1)]
		public static IllustratedReadResponse Create()
		{
			return new IllustratedReadResponse();
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x0600B347 RID: 45895 RVA: 0x001AD27B File Offset: 0x001AB47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x001AD27E File Offset: 0x001AB47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedReadResponse.Descriptor;
			}
		}

		// Token: 0x0600B349 RID: 45897 RVA: 0x001AD285 File Offset: 0x001AB485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse()
		{
		}

		// Token: 0x0600B34A RID: 45898 RVA: 0x001AD298 File Offset: 0x001AB498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse(IllustratedReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x001AD2CE File Offset: 0x001AB4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedReadResponse Clone()
		{
			return new IllustratedReadResponse(this);
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x001AD2D6 File Offset: 0x001AB4D6
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x001AD2DE File Offset: 0x001AB4DE
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

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x001AD2E7 File Offset: 0x001AB4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x001AD2EF File Offset: 0x001AB4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedReadResponse);
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x001AD300 File Offset: 0x001AB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x001AD350 File Offset: 0x001AB550
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

		// Token: 0x0600B352 RID: 45906 RVA: 0x001AD3A3 File Offset: 0x001AB5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x001AD3B0 File Offset: 0x001AB5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x001AD3BC File Offset: 0x001AB5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, IllustratedReadResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x001AD40C File Offset: 0x001AB60C
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

		// Token: 0x0600B356 RID: 45910 RVA: 0x001AD460 File Offset: 0x001AB660
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

		// Token: 0x0600B357 RID: 45911 RVA: 0x001AD4AD File Offset: 0x001AB6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x001AD4B8 File Offset: 0x001AB6B8
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
					if (num != 26U)
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

		// Token: 0x04005005 RID: 20485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005006 RID: 20486
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005007 RID: 20487
		private ErrorCode errorCode_;

		// Token: 0x04005008 RID: 20488
		public const int ErrorParamsFieldNumber = 3;

		// Token: 0x04005009 RID: 20489
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(26U);

		// Token: 0x0400500A RID: 20490
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
