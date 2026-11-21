using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C92 RID: 3218
	[NetMessage(EMessageId.PhantomBattleReconstructCardNotify)]
	public sealed class PhantomBattleReconstructCardNotify : IMessage<PhantomBattleReconstructCardNotify>, IMessage, IEquatable<PhantomBattleReconstructCardNotify>, IDeepCloneable<PhantomBattleReconstructCardNotify>, IBufferMessage
	{
		// Token: 0x06011767 RID: 71527 RVA: 0x0028F76D File Offset: 0x0028D96D
		[NullableContext(1)]
		public static PhantomBattleReconstructCardNotify Create()
		{
			return new PhantomBattleReconstructCardNotify();
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x06011768 RID: 71528 RVA: 0x0028F774 File Offset: 0x0028D974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x06011769 RID: 71529 RVA: 0x0028F777 File Offset: 0x0028D977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardNotify.Descriptor;
			}
		}

		// Token: 0x0601176A RID: 71530 RVA: 0x0028F77E File Offset: 0x0028D97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardNotify()
		{
		}

		// Token: 0x0601176B RID: 71531 RVA: 0x0028F794 File Offset: 0x0028D994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardNotify(PhantomBattleReconstructCardNotify other) : this()
		{
			this.ownerCardUid_ = other.ownerCardUid_;
			this.effectUid_ = other.effectUid_;
			this.selectedCardList_ = other.selectedCardList_.Clone();
			this.canSelectNum_ = other.canSelectNum_;
			this.cardFrom_ = other.cardFrom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601176C RID: 71532 RVA: 0x0028F7F9 File Offset: 0x0028D9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardNotify Clone()
		{
			return new PhantomBattleReconstructCardNotify(this);
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0601176D RID: 71533 RVA: 0x0028F801 File Offset: 0x0028DA01
		// (set) Token: 0x0601176E RID: 71534 RVA: 0x0028F809 File Offset: 0x0028DA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerCardUid
		{
			get
			{
				return this.ownerCardUid_;
			}
			set
			{
				this.ownerCardUid_ = value;
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0601176F RID: 71535 RVA: 0x0028F812 File Offset: 0x0028DA12
		// (set) Token: 0x06011770 RID: 71536 RVA: 0x0028F81A File Offset: 0x0028DA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectUid
		{
			get
			{
				return this.effectUid_;
			}
			set
			{
				this.effectUid_ = value;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x06011771 RID: 71537 RVA: 0x0028F823 File Offset: 0x0028DA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> SelectedCardList
		{
			get
			{
				return this.selectedCardList_;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x06011772 RID: 71538 RVA: 0x0028F82B File Offset: 0x0028DA2B
		// (set) Token: 0x06011773 RID: 71539 RVA: 0x0028F833 File Offset: 0x0028DA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanSelectNum
		{
			get
			{
				return this.canSelectNum_;
			}
			set
			{
				this.canSelectNum_ = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x06011774 RID: 71540 RVA: 0x0028F83C File Offset: 0x0028DA3C
		// (set) Token: 0x06011775 RID: 71541 RVA: 0x0028F844 File Offset: 0x0028DA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectedCardFromType CardFrom
		{
			get
			{
				return this.cardFrom_;
			}
			set
			{
				this.cardFrom_ = value;
			}
		}

		// Token: 0x06011776 RID: 71542 RVA: 0x0028F84D File Offset: 0x0028DA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardNotify);
		}

		// Token: 0x06011777 RID: 71543 RVA: 0x0028F85C File Offset: 0x0028DA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardNotify other)
		{
			return other != null && (other == this || (this.OwnerCardUid == other.OwnerCardUid && this.EffectUid == other.EffectUid && this.selectedCardList_.Equals(other.selectedCardList_) && this.CanSelectNum == other.CanSelectNum && this.CardFrom == other.CardFrom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011778 RID: 71544 RVA: 0x0028F8DC File Offset: 0x0028DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OwnerCardUid != 0)
			{
				num ^= this.OwnerCardUid.GetHashCode();
			}
			if (this.EffectUid != 0)
			{
				num ^= this.EffectUid.GetHashCode();
			}
			num ^= this.selectedCardList_.GetHashCode();
			if (this.CanSelectNum != 0)
			{
				num ^= this.CanSelectNum.GetHashCode();
			}
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				num ^= this.CardFrom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011779 RID: 71545 RVA: 0x0028F97A File Offset: 0x0028DB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601177A RID: 71546 RVA: 0x0028F987 File Offset: 0x0028DB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601177B RID: 71547 RVA: 0x0028F990 File Offset: 0x0028DB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectedCardList_.WriteTo(ref output, PhantomBattleReconstructCardNotify._repeated_selectedCardList_codec);
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EffectUid);
			}
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.CardFrom);
			}
			if (this.CanSelectNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CanSelectNum);
			}
			if (this.OwnerCardUid != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.OwnerCardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601177C RID: 71548 RVA: 0x0028FA34 File Offset: 0x0028DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OwnerCardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerCardUid);
			}
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.selectedCardList_.CalculateSize(PhantomBattleReconstructCardNotify._repeated_selectedCardList_codec);
			if (this.CanSelectNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanSelectNum);
			}
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CardFrom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601177D RID: 71549 RVA: 0x0028FAD0 File Offset: 0x0028DCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReconstructCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OwnerCardUid != 0)
			{
				this.OwnerCardUid = other.OwnerCardUid;
			}
			if (other.EffectUid != 0)
			{
				this.EffectUid = other.EffectUid;
			}
			this.selectedCardList_.Add(other.selectedCardList_);
			if (other.CanSelectNum != 0)
			{
				this.CanSelectNum = other.CanSelectNum;
			}
			if (other.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				this.CardFrom = other.CardFrom;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601177E RID: 71550 RVA: 0x0028FB59 File Offset: 0x0028DD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601177F RID: 71551 RVA: 0x0028FB64 File Offset: 0x0028DD64
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
				if (num <= 32U)
				{
					if (num == 26U)
					{
						this.selectedCardList_.AddEntriesFrom(ref input, PhantomBattleReconstructCardNotify._repeated_selectedCardList_codec);
						continue;
					}
					if (num == 32U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.CardFrom = (PhantomBattleSelectedCardFromType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.CanSelectNum = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.OwnerCardUid = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E97 RID: 28311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E98 RID: 28312
		public const int OwnerCardUidFieldNumber = 15;

		// Token: 0x04006E99 RID: 28313
		private int ownerCardUid_;

		// Token: 0x04006E9A RID: 28314
		public const int EffectUidFieldNumber = 4;

		// Token: 0x04006E9B RID: 28315
		private int effectUid_;

		// Token: 0x04006E9C RID: 28316
		public const int SelectedCardListFieldNumber = 3;

		// Token: 0x04006E9D RID: 28317
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_selectedCardList_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(26U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006E9E RID: 28318
		private readonly RepeatedField<PhantomBattleHandCardInfo> selectedCardList_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006E9F RID: 28319
		public const int CanSelectNumFieldNumber = 12;

		// Token: 0x04006EA0 RID: 28320
		private int canSelectNum_;

		// Token: 0x04006EA1 RID: 28321
		public const int CardFromFieldNumber = 9;

		// Token: 0x04006EA2 RID: 28322
		private PhantomBattleSelectedCardFromType cardFrom_;
	}
}
