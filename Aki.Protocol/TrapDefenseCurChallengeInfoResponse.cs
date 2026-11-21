using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001492 RID: 5266
	[NetMessage(EMessageId.TrapDefenseCurChallengeInfoResponse)]
	public sealed class TrapDefenseCurChallengeInfoResponse : IMessage<TrapDefenseCurChallengeInfoResponse>, IMessage, IEquatable<TrapDefenseCurChallengeInfoResponse>, IDeepCloneable<TrapDefenseCurChallengeInfoResponse>, IBufferMessage
	{
		// Token: 0x0601BF5F RID: 114527 RVA: 0x0040FF02 File Offset: 0x0040E102
		[NullableContext(1)]
		public static TrapDefenseCurChallengeInfoResponse Create()
		{
			return new TrapDefenseCurChallengeInfoResponse();
		}

		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x0601BF60 RID: 114528 RVA: 0x0040FF09 File Offset: 0x0040E109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x0601BF61 RID: 114529 RVA: 0x0040FF0C File Offset: 0x0040E10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCurChallengeInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601BF62 RID: 114530 RVA: 0x0040FF13 File Offset: 0x0040E113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse()
		{
		}

		// Token: 0x0601BF63 RID: 114531 RVA: 0x0040FF26 File Offset: 0x0040E126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse(TrapDefenseCurChallengeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.target_ = other.target_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF64 RID: 114532 RVA: 0x0040FF5C File Offset: 0x0040E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse Clone()
		{
			return new TrapDefenseCurChallengeInfoResponse(this);
		}

		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x0601BF65 RID: 114533 RVA: 0x0040FF64 File Offset: 0x0040E164
		// (set) Token: 0x0601BF66 RID: 114534 RVA: 0x0040FF6C File Offset: 0x0040E16C
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

		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x0601BF67 RID: 114535 RVA: 0x0040FF75 File Offset: 0x0040E175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x0601BF68 RID: 114536 RVA: 0x0040FF7D File Offset: 0x0040E17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCurChallengeInfoResponse);
		}

		// Token: 0x0601BF69 RID: 114537 RVA: 0x0040FF8C File Offset: 0x0040E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCurChallengeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.target_.Equals(other.target_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF6A RID: 114538 RVA: 0x0040FFDC File Offset: 0x0040E1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.target_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF6B RID: 114539 RVA: 0x0041002F File Offset: 0x0040E22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF6C RID: 114540 RVA: 0x0041003C File Offset: 0x0040E23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF6D RID: 114541 RVA: 0x00410048 File Offset: 0x0040E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.target_.WriteTo(ref output, TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF6E RID: 114542 RVA: 0x00410098 File Offset: 0x0040E298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.target_.CalculateSize(TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF6F RID: 114543 RVA: 0x004100EC File Offset: 0x0040E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCurChallengeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.target_.Add(other.target_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF70 RID: 114544 RVA: 0x00410139 File Offset: 0x0040E339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF71 RID: 114545 RVA: 0x00410144 File Offset: 0x0040E344
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
				if (num != 80U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.target_.AddEntriesFrom(ref input, TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A214 RID: 41492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A215 RID: 41493
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A216 RID: 41494
		private ErrorCode errorCode_;

		// Token: 0x0400A217 RID: 41495
		public const int TargetFieldNumber = 11;

		// Token: 0x0400A218 RID: 41496
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400A219 RID: 41497
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();
	}
}
