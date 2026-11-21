using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C70 RID: 3184
	[NetMessage(EMessageId.PhantomBattleDiscardCardResponse)]
	public sealed class PhantomBattleDiscardCardResponse : IMessage<PhantomBattleDiscardCardResponse>, IMessage, IEquatable<PhantomBattleDiscardCardResponse>, IDeepCloneable<PhantomBattleDiscardCardResponse>, IBufferMessage
	{
		// Token: 0x06011478 RID: 70776 RVA: 0x0028810D File Offset: 0x0028630D
		[NullableContext(1)]
		public static PhantomBattleDiscardCardResponse Create()
		{
			return new PhantomBattleDiscardCardResponse();
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06011479 RID: 70777 RVA: 0x00288114 File Offset: 0x00286314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0601147A RID: 70778 RVA: 0x00288117 File Offset: 0x00286317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardResponse.Descriptor;
			}
		}

		// Token: 0x0601147B RID: 70779 RVA: 0x0028811E File Offset: 0x0028631E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse()
		{
		}

		// Token: 0x0601147C RID: 70780 RVA: 0x00288134 File Offset: 0x00286334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse(PhantomBattleDiscardCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.discardCardIds_ = other.discardCardIds_.Clone();
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601147D RID: 70781 RVA: 0x0028818D File Offset: 0x0028638D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardResponse Clone()
		{
			return new PhantomBattleDiscardCardResponse(this);
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0601147E RID: 70782 RVA: 0x00288195 File Offset: 0x00286395
		// (set) Token: 0x0601147F RID: 70783 RVA: 0x0028819D File Offset: 0x0028639D
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

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06011480 RID: 70784 RVA: 0x002881A6 File Offset: 0x002863A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiscardCardIds
		{
			get
			{
				return this.discardCardIds_;
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06011481 RID: 70785 RVA: 0x002881AE File Offset: 0x002863AE
		// (set) Token: 0x06011482 RID: 70786 RVA: 0x002881B6 File Offset: 0x002863B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06011483 RID: 70787 RVA: 0x002881BF File Offset: 0x002863BF
		// (set) Token: 0x06011484 RID: 70788 RVA: 0x002881C7 File Offset: 0x002863C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x06011485 RID: 70789 RVA: 0x002881D0 File Offset: 0x002863D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardResponse);
		}

		// Token: 0x06011486 RID: 70790 RVA: 0x002881E0 File Offset: 0x002863E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.discardCardIds_.Equals(other.discardCardIds_) && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011487 RID: 70791 RVA: 0x00288250 File Offset: 0x00286450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.discardCardIds_.GetHashCode();
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011488 RID: 70792 RVA: 0x002882D5 File Offset: 0x002864D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011489 RID: 70793 RVA: 0x002882E2 File Offset: 0x002864E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601148A RID: 70794 RVA: 0x002882EC File Offset: 0x002864EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.discardCardIds_.WriteTo(ref output, PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601148B RID: 70795 RVA: 0x00288374 File Offset: 0x00286574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.discardCardIds_.CalculateSize(PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601148C RID: 70796 RVA: 0x002883F8 File Offset: 0x002865F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDiscardCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.discardCardIds_.Add(other.discardCardIds_);
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601148D RID: 70797 RVA: 0x0028846D File Offset: 0x0028666D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x00288478 File Offset: 0x00286678
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.discardCardIds_.AddEntriesFrom(ref input, PhantomBattleDiscardCardResponse._repeated_discardCardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DAA RID: 28074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DAB RID: 28075
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006DAC RID: 28076
		private ErrorCode errorCode_;

		// Token: 0x04006DAD RID: 28077
		public const int DiscardCardIdsFieldNumber = 4;

		// Token: 0x04006DAE RID: 28078
		private static readonly FieldCodec<int> _repeated_discardCardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006DAF RID: 28079
		private readonly RepeatedField<int> discardCardIds_ = new RepeatedField<int>();

		// Token: 0x04006DB0 RID: 28080
		public const int HandCardNumFieldNumber = 5;

		// Token: 0x04006DB1 RID: 28081
		private int handCardNum_;

		// Token: 0x04006DB2 RID: 28082
		public const int CurCardLibraryNumFieldNumber = 15;

		// Token: 0x04006DB3 RID: 28083
		private int curCardLibraryNum_;
	}
}
