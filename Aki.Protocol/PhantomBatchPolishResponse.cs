using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C21 RID: 3105
	[NetMessage(EMessageId.PhantomBatchPolishResponse)]
	public sealed class PhantomBatchPolishResponse : IMessage<PhantomBatchPolishResponse>, IMessage, IEquatable<PhantomBatchPolishResponse>, IDeepCloneable<PhantomBatchPolishResponse>, IBufferMessage
	{
		// Token: 0x06010D9E RID: 69022 RVA: 0x00277BB4 File Offset: 0x00275DB4
		[NullableContext(1)]
		public static PhantomBatchPolishResponse Create()
		{
			return new PhantomBatchPolishResponse();
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x06010D9F RID: 69023 RVA: 0x00277BBB File Offset: 0x00275DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x06010DA0 RID: 69024 RVA: 0x00277BBE File Offset: 0x00275DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchPolishResponse.Descriptor;
			}
		}

		// Token: 0x06010DA1 RID: 69025 RVA: 0x00277BC5 File Offset: 0x00275DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishResponse()
		{
		}

		// Token: 0x06010DA2 RID: 69026 RVA: 0x00277BF0 File Offset: 0x00275DF0
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

		// Token: 0x06010DA3 RID: 69027 RVA: 0x00277C53 File Offset: 0x00275E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishResponse Clone()
		{
			return new PhantomBatchPolishResponse(this);
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x06010DA4 RID: 69028 RVA: 0x00277C5B File Offset: 0x00275E5B
		// (set) Token: 0x06010DA5 RID: 69029 RVA: 0x00277C63 File Offset: 0x00275E63
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

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x06010DA6 RID: 69030 RVA: 0x00277C6C File Offset: 0x00275E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> UpdateInfos
		{
			get
			{
				return this.updateInfos_;
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x06010DA7 RID: 69031 RVA: 0x00277C74 File Offset: 0x00275E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackSplitInfo> StackSplitInfos
		{
			get
			{
				return this.stackSplitInfos_;
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x06010DA8 RID: 69032 RVA: 0x00277C7C File Offset: 0x00275E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackMergeInfo> StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
		}

		// Token: 0x06010DA9 RID: 69033 RVA: 0x00277C84 File Offset: 0x00275E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchPolishResponse);
		}

		// Token: 0x06010DAA RID: 69034 RVA: 0x00277C94 File Offset: 0x00275E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchPolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.updateInfos_.Equals(other.updateInfos_) && this.stackSplitInfos_.Equals(other.stackSplitInfos_) && this.stackMergeInfos_.Equals(other.stackMergeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DAB RID: 69035 RVA: 0x00277D0C File Offset: 0x00275F0C
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

		// Token: 0x06010DAC RID: 69036 RVA: 0x00277D7B File Offset: 0x00275F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DAD RID: 69037 RVA: 0x00277D88 File Offset: 0x00275F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DAE RID: 69038 RVA: 0x00277D94 File Offset: 0x00275F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.stackMergeInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_stackMergeInfos_codec);
			this.updateInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_updateInfos_codec);
			this.stackSplitInfos_.WriteTo(ref output, PhantomBatchPolishResponse._repeated_stackSplitInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010DAF RID: 69039 RVA: 0x00277E04 File Offset: 0x00276004
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

		// Token: 0x06010DB0 RID: 69040 RVA: 0x00277E7C File Offset: 0x0027607C
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

		// Token: 0x06010DB1 RID: 69041 RVA: 0x00277EEB File Offset: 0x002760EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DB2 RID: 69042 RVA: 0x00277EF4 File Offset: 0x002760F4
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
				if (num <= 82U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 82U)
					{
						this.stackMergeInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_stackMergeInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.updateInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_updateInfos_codec);
						continue;
					}
					if (num == 114U)
					{
						this.stackSplitInfos_.AddEntriesFrom(ref input, PhantomBatchPolishResponse._repeated_stackSplitInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006AF5 RID: 27381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AF6 RID: 27382
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006AF7 RID: 27383
		private ErrorCode errorCode_;

		// Token: 0x04006AF8 RID: 27384
		public const int UpdateInfosFieldNumber = 12;

		// Token: 0x04006AF9 RID: 27385
		private static readonly FieldCodec<PhantomItem> _repeated_updateInfos_codec = FieldCodec.ForMessage<PhantomItem>(98U, PhantomItem.Parser);

		// Token: 0x04006AFA RID: 27386
		private readonly RepeatedField<PhantomItem> updateInfos_ = new RepeatedField<PhantomItem>();

		// Token: 0x04006AFB RID: 27387
		public const int StackSplitInfosFieldNumber = 14;

		// Token: 0x04006AFC RID: 27388
		private static readonly FieldCodec<PhantomStackSplitInfo> _repeated_stackSplitInfos_codec = FieldCodec.ForMessage<PhantomStackSplitInfo>(114U, PhantomStackSplitInfo.Parser);

		// Token: 0x04006AFD RID: 27389
		private readonly RepeatedField<PhantomStackSplitInfo> stackSplitInfos_ = new RepeatedField<PhantomStackSplitInfo>();

		// Token: 0x04006AFE RID: 27390
		public const int StackMergeInfosFieldNumber = 10;

		// Token: 0x04006AFF RID: 27391
		private static readonly FieldCodec<PhantomStackMergeInfo> _repeated_stackMergeInfos_codec = FieldCodec.ForMessage<PhantomStackMergeInfo>(82U, PhantomStackMergeInfo.Parser);

		// Token: 0x04006B00 RID: 27392
		private readonly RepeatedField<PhantomStackMergeInfo> stackMergeInfos_ = new RepeatedField<PhantomStackMergeInfo>();
	}
}
