using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CF RID: 207
	[NetMessage(EMessageId.AdviceResponse)]
	public sealed class AdviceResponse : IMessage<AdviceResponse>, IMessage, IEquatable<AdviceResponse>, IDeepCloneable<AdviceResponse>, IBufferMessage
	{
		// Token: 0x06002020 RID: 8224 RVA: 0x0005711E File Offset: 0x0005531E
		[NullableContext(1)]
		public static AdviceResponse Create()
		{
			return new AdviceResponse();
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00057125 File Offset: 0x00055325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00057128 File Offset: 0x00055328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceResponse.Descriptor;
			}
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0005712F File Offset: 0x0005532F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse()
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00057150 File Offset: 0x00055350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse(AdviceResponse other) : this()
		{
			this.advices_ = other.advices_.Clone();
			this.upVoteIds_ = other.upVoteIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000571A2 File Offset: 0x000553A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse Clone()
		{
			return new AdviceResponse(this);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x000571AA File Offset: 0x000553AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdvice> Advices
		{
			get
			{
				return this.advices_;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x000571B2 File Offset: 0x000553B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> UpVoteIds
		{
			get
			{
				return this.upVoteIds_;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x000571BA File Offset: 0x000553BA
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x000571C2 File Offset: 0x000553C2
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

		// Token: 0x0600202A RID: 8234 RVA: 0x000571CB File Offset: 0x000553CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceResponse);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000571DC File Offset: 0x000553DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceResponse other)
		{
			return other != null && (other == this || (this.advices_.Equals(other.advices_) && this.upVoteIds_.Equals(other.upVoteIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00057240 File Offset: 0x00055440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.advices_.GetHashCode();
			num ^= this.upVoteIds_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000572A1 File Offset: 0x000554A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000572AE File Offset: 0x000554AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x000572B8 File Offset: 0x000554B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.upVoteIds_.WriteTo(ref output, AdviceResponse._repeated_upVoteIds_codec);
			this.advices_.WriteTo(ref output, AdviceResponse._repeated_advices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00057318 File Offset: 0x00055518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.advices_.CalculateSize(AdviceResponse._repeated_advices_codec);
			num += this.upVoteIds_.CalculateSize(AdviceResponse._repeated_upVoteIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0005737C File Offset: 0x0005557C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.advices_.Add(other.advices_);
			this.upVoteIds_.Add(other.upVoteIds_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000573DA File Offset: 0x000555DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000573E4 File Offset: 0x000555E4
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
				if (num <= 80U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_45;
					}
					if (num == 114U)
					{
						this.advices_.AddEntriesFrom(ref input, AdviceResponse._repeated_advices_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.upVoteIds_.AddEntriesFrom(ref input, AdviceResponse._repeated_upVoteIds_codec);
			}
		}

		// Token: 0x04002433 RID: 9267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002434 RID: 9268
		public const int AdvicesFieldNumber = 14;

		// Token: 0x04002435 RID: 9269
		private static readonly FieldCodec<PbAdvice> _repeated_advices_codec = FieldCodec.ForMessage<PbAdvice>(114U, PbAdvice.Parser);

		// Token: 0x04002436 RID: 9270
		private readonly RepeatedField<PbAdvice> advices_ = new RepeatedField<PbAdvice>();

		// Token: 0x04002437 RID: 9271
		public const int UpVoteIdsFieldNumber = 10;

		// Token: 0x04002438 RID: 9272
		private static readonly FieldCodec<long> _repeated_upVoteIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04002439 RID: 9273
		private readonly RepeatedField<long> upVoteIds_ = new RepeatedField<long>();

		// Token: 0x0400243A RID: 9274
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400243B RID: 9275
		private ErrorCode errorCode_;
	}
}
