using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CE RID: 206
	[NetMessage(EMessageId.AdviceResponse)]
	public sealed class AdviceResponse : IMessage<AdviceResponse>, IMessage, IEquatable<AdviceResponse>, IDeepCloneable<AdviceResponse>, IBufferMessage
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x0005646A File Offset: 0x0005466A
		[NullableContext(1)]
		public static AdviceResponse Create()
		{
			return new AdviceResponse();
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00056471 File Offset: 0x00054671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00056474 File Offset: 0x00054674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceResponse.Descriptor;
			}
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0005647B File Offset: 0x0005467B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse()
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0005649C File Offset: 0x0005469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse(AdviceResponse other) : this()
		{
			this.advices_ = other.advices_.Clone();
			this.upVoteIds_ = other.upVoteIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000564EE File Offset: 0x000546EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceResponse Clone()
		{
			return new AdviceResponse(this);
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000564F6 File Offset: 0x000546F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdvice> Advices
		{
			get
			{
				return this.advices_;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000564FE File Offset: 0x000546FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> UpVoteIds
		{
			get
			{
				return this.upVoteIds_;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00056506 File Offset: 0x00054706
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x0005650E File Offset: 0x0005470E
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

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00056517 File Offset: 0x00054717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceResponse);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00056528 File Offset: 0x00054728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceResponse other)
		{
			return other != null && (other == this || (this.advices_.Equals(other.advices_) && this.upVoteIds_.Equals(other.upVoteIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0005658C File Offset: 0x0005478C
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

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000565ED File Offset: 0x000547ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000565FA File Offset: 0x000547FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00056604 File Offset: 0x00054804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.advices_.WriteTo(ref output, AdviceResponse._repeated_advices_codec);
			this.upVoteIds_.WriteTo(ref output, AdviceResponse._repeated_upVoteIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00056664 File Offset: 0x00054864
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

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000566C8 File Offset: 0x000548C8
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

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00056726 File Offset: 0x00054926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00056730 File Offset: 0x00054930
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
				if (num <= 74U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 74U)
					{
						this.advices_.AddEntriesFrom(ref input, AdviceResponse._repeated_advices_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.upVoteIds_.AddEntriesFrom(ref input, AdviceResponse._repeated_upVoteIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023D0 RID: 9168
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D1 RID: 9169
		public const int AdvicesFieldNumber = 9;

		// Token: 0x040023D2 RID: 9170
		private static readonly FieldCodec<PbAdvice> _repeated_advices_codec = FieldCodec.ForMessage<PbAdvice>(74U, PbAdvice.Parser);

		// Token: 0x040023D3 RID: 9171
		private readonly RepeatedField<PbAdvice> advices_ = new RepeatedField<PbAdvice>();

		// Token: 0x040023D4 RID: 9172
		public const int UpVoteIdsFieldNumber = 15;

		// Token: 0x040023D5 RID: 9173
		private static readonly FieldCodec<long> _repeated_upVoteIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x040023D6 RID: 9174
		private readonly RepeatedField<long> upVoteIds_ = new RepeatedField<long>();

		// Token: 0x040023D7 RID: 9175
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040023D8 RID: 9176
		private ErrorCode errorCode_;
	}
}
