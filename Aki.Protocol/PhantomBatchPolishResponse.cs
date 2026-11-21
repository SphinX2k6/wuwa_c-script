using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C11 RID: 3089
	[NetMessage(EMessageId.PhantomBatchPolishResponse)]
	public sealed class PhantomBatchPolishResponse : IMessage<PhantomBatchPolishResponse>, IMessage, IEquatable<PhantomBatchPolishResponse>, IDeepCloneable<PhantomBatchPolishResponse>, IBufferMessage
	{
		// Token: 0x06010C9E RID: 68766 RVA: 0x00275E50 File Offset: 0x00274050
		[NullableContext(1)]
		public static PhantomBatchPolishResponse Create()
		{
			return new PhantomBatchPolishResponse();
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x06010C9F RID: 68767 RVA: 0x00275E57 File Offset: 0x00274057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x06010CA0 RID: 68768 RVA: 0x00275E5A File Offset: 0x0027405A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchPolishResponse.Descriptor;
			}
		}

		// Token: 0x06010CA1 RID: 68769 RVA: 0x00275E61 File Offset: 0x00274061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishResponse()
		{
		}

		// Token: 0x06010CA2 RID: 68770 RVA: 0x00275E8C File Offset: 0x0027408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishResponse(PhantomBatchPolishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfos_ = other.updateInfos_.Clone();
			this.stackSplitInfos_ = other.stackSplitInfos_.Clone();
			this.stackMergeInfos_ = other.stackMergeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CA3 RID: 68771 RVA: 0x00275EEF File Offset: 0x002740EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishResponse Clone()
		{
			return new PhantomBatchPolishResponse(this);
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x06010CA4 RID: 68772 RVA: 0x00275EF7 File Offset: 0x002740F7
		// (set) Token: 0x06010CA5 RID: 68773 RVA: 0x00275EFF File Offset: 0x002740FF
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

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x06010CA6 RID: 68774 RVA: 0x00275F08 File Offset: 0x00274108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> UpdateInfos
		{
			get
			{
				return this.updateInfos_;
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x06010CA7 RID: 68775 RVA: 0x00275F10 File Offset: 0x00274110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x06010CA8 RID: 68776 RVA: 0x00275F18 File Offset: 0x00274118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06010CA9 RID: 68777 RVA: 0x00275F20 File Offset: 0x00274120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchPolishResponse);
		}

		// Token: 0x06010CAA RID: 68778 RVA: 0x00275F30 File Offset: 0x00274130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchPolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.updateInfos_.Equals(other.updateInfos_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CAB RID: 68779 RVA: 0x00275FA8 File Offset: 0x002741A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.updateInfos_.GetHashCode();
			num ^= this.stackSplitInfos_.GetHashCode();
			num ^= this.stackMergeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010CAC RID: 68780 RVA: 0x00276017 File Offset: 0x00274217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CAD RID: 68781 RVA: 0x00276024 File Offset: 0x00274224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CAE RID: 68782 RVA: 0x00276030 File Offset: 0x00274230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackSplitInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_stackSplitInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.stackMergeInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_stackMergeInfos_codec);
			this.updateInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_updateInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CAF RID: 68783 RVA: 0x002760A0 File Offset: 0x002742A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.updateInfos_.CalculateSize(PhantomBatchPolishResponse._repeated_updateInfos_codec);
			num += this.stackSplitInfos_.CalculateSize(PhantomBatchPolishResponse._repeated_stackSplitInfos_codec);
			num += this.stackMergeInfos_.CalculateSize(PhantomBatchPolishResponse._repeated_stackMergeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CB0 RID: 68784 RVA: 0x00276118 File Offset: 0x00274318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchPolishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.updateInfos_.Add(other.updateInfos_);
			this.stackSplitInfos_.Add(other.stackSplitInfos_);
			this.stackMergeInfos_.Add(other.stackMergeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CB1 RID: 68785 RVA: 0x00276187 File Offset: 0x00274387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CB2 RID: 68786 RVA: 0x00276190 File Offset: 0x00274390
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
				if (num <= 48U)
				{
					if (num == 26U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_stackSplitInfos_codec);
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_stackMergeInfos_codec);
						continue;
					}
					if (num == 122U)
					{
						this.updateInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_updateInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B09 RID: 27401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B0A RID: 27402
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006B0B RID: 27403
		private ErrorCode errorCode_;

		// Token: 0x04006B0C RID: 27404
		public const int UpdateInfosFieldNumber = 15;

		// Token: 0x04006B0D RID: 27405
		private static readonly FieldCodec<PhantomItem> _repeated_updateInfos_codec = FieldCodec.ForMessage<PhantomItem>(122U, PhantomItem.Parser);

		// Token: 0x04006B0E RID: 27406
		private readonly RepeatedField<PhantomItem> updateInfos_ = new RepeatedField<PhantomItem>();

		// Token: 0x04006B0F RID: 27407
		public const int StackSplitInfosFieldNumber = 3;

		// Token: 0x04006B10 RID: 27408
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(26U, PhantomStackSplitInfo.Parser);

		// Token: 0x04006B11 RID: 27409
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x04006B12 RID: 27410
		public const int StackMergeInfosFieldNumber = 14;

		// Token: 0x04006B13 RID: 27411
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(114U, PhantomStackMergeInfo.Parser);

		// Token: 0x04006B14 RID: 27412
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
