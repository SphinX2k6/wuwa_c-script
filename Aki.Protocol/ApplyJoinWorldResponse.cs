using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000107 RID: 263
	[NetMessage(EMessageId.ApplyJoinWorldResponse)]
	public sealed class ApplyJoinWorldResponse : IMessage<ApplyJoinWorldResponse>, IMessage, IEquatable<ApplyJoinWorldResponse>, IDeepCloneable<ApplyJoinWorldResponse>, IBufferMessage
	{
		// Token: 0x06002507 RID: 9479 RVA: 0x000633CC File Offset: 0x000615CC
		[NullableContext(1)]
		public static ApplyJoinWorldResponse Create()
		{
			return new ApplyJoinWorldResponse();
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x000633D3 File Offset: 0x000615D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000633D6 File Offset: 0x000615D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldResponse.Descriptor;
			}
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000633DD File Offset: 0x000615DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse()
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000633F0 File Offset: 0x000615F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse(ApplyJoinWorldResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00063426 File Offset: 0x00061626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse Clone()
		{
			return new ApplyJoinWorldResponse(this);
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0006342E File Offset: 0x0006162E
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x00063436 File Offset: 0x00061636
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0006343F File Offset: 0x0006163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00063447 File Offset: 0x00061647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldResponse);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00063458 File Offset: 0x00061658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000634A8 File Offset: 0x000616A8
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

		// Token: 0x06002513 RID: 9491 RVA: 0x000634FB File Offset: 0x000616FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00063508 File Offset: 0x00061708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00063514 File Offset: 0x00061714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, ApplyJoinWorldResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00063564 File Offset: 0x00061764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(ApplyJoinWorldResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000635B8 File Offset: 0x000617B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyJoinWorldResponse other)
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

		// Token: 0x06002518 RID: 9496 RVA: 0x00063605 File Offset: 0x00061805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00063610 File Offset: 0x00061810
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
				if (num != 26U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.errorParams_.AddEntriesFrom(ref input, ApplyJoinWorldResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x040025F6 RID: 9718
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025F7 RID: 9719
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040025F8 RID: 9720
		private ErrorCode errorCode_;

		// Token: 0x040025F9 RID: 9721
		public const int ErrorParamsFieldNumber = 3;

		// Token: 0x040025FA RID: 9722
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(26U);

		// Token: 0x040025FB RID: 9723
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
