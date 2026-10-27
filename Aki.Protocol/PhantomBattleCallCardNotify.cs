using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C41 RID: 3137
	[NetMessage(EMessageId.PhantomBattleCallCardNotify)]
	public sealed class PhantomBattleCallCardNotify : IMessage<PhantomBattleCallCardNotify>, IMessage, IEquatable<PhantomBattleCallCardNotify>, IDeepCloneable<PhantomBattleCallCardNotify>, IBufferMessage
	{
		// Token: 0x0601102B RID: 69675 RVA: 0x0027D72A File Offset: 0x0027B92A
		[NullableContext(1)]
		public static PhantomBattleCallCardNotify Create()
		{
			return new PhantomBattleCallCardNotify();
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0601102C RID: 69676 RVA: 0x0027D731 File Offset: 0x0027B931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0601102D RID: 69677 RVA: 0x0027D734 File Offset: 0x0027B934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardNotify.Descriptor;
			}
		}

		// Token: 0x0601102E RID: 69678 RVA: 0x0027D73B File Offset: 0x0027B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardNotify()
		{
		}

		// Token: 0x0601102F RID: 69679 RVA: 0x0027D750 File Offset: 0x0027B950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardNotify(PhantomBattleCallCardNotify other) : this()
		{
			this.ownerCardUid_ = other.ownerCardUid_;
			this.effectUid_ = other.effectUid_;
			this.selectedCardList_ = other.selectedCardList_.Clone();
			this.canSelectNum_ = other.canSelectNum_;
			this.cardFrom_ = other.cardFrom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011030 RID: 69680 RVA: 0x0027D7B5 File Offset: 0x0027B9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardNotify Clone()
		{
			return new PhantomBattleCallCardNotify(this);
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x06011031 RID: 69681 RVA: 0x0027D7BD File Offset: 0x0027B9BD
		// (set) Token: 0x06011032 RID: 69682 RVA: 0x0027D7C5 File Offset: 0x0027B9C5
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

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x06011033 RID: 69683 RVA: 0x0027D7CE File Offset: 0x0027B9CE
		// (set) Token: 0x06011034 RID: 69684 RVA: 0x0027D7D6 File Offset: 0x0027B9D6
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

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x06011035 RID: 69685 RVA: 0x0027D7DF File Offset: 0x0027B9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> SelectedCardList
		{
			get
			{
				return this.selectedCardList_;
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x06011036 RID: 69686 RVA: 0x0027D7E7 File Offset: 0x0027B9E7
		// (set) Token: 0x06011037 RID: 69687 RVA: 0x0027D7EF File Offset: 0x0027B9EF
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

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x06011038 RID: 69688 RVA: 0x0027D7F8 File Offset: 0x0027B9F8
		// (set) Token: 0x06011039 RID: 69689 RVA: 0x0027D800 File Offset: 0x0027BA00
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

		// Token: 0x0601103A RID: 69690 RVA: 0x0027D809 File Offset: 0x0027BA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardNotify);
		}

		// Token: 0x0601103B RID: 69691 RVA: 0x0027D818 File Offset: 0x0027BA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardNotify other)
		{
			return other != null && (other == this || (this.OwnerCardUid == other.OwnerCardUid && this.EffectUid == other.EffectUid && this.selectedCardList_.Equals(other.selectedCardList_) && this.CanSelectNum == other.CanSelectNum && this.CardFrom == other.CardFrom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601103C RID: 69692 RVA: 0x0027D898 File Offset: 0x0027BA98
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

		// Token: 0x0601103D RID: 69693 RVA: 0x0027D936 File Offset: 0x0027BB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601103E RID: 69694 RVA: 0x0027D943 File Offset: 0x0027BB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601103F RID: 69695 RVA: 0x0027D94C File Offset: 0x0027BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EffectUid);
			}
			if (this.CanSelectNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CanSelectNum);
			}
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.CardFrom);
			}
			if (this.OwnerCardUid != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.OwnerCardUid);
			}
			this.selectedCardList_.WriteTo(ref output, PhantomBattleCallCardNotify._repeated_selectedCardList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011040 RID: 69696 RVA: 0x0027D9F0 File Offset: 0x0027BBF0
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
			num += this.selectedCardList_.CalculateSize(PhantomBattleCallCardNotify._repeated_selectedCardList_codec);
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

		// Token: 0x06011041 RID: 69697 RVA: 0x0027DA8C File Offset: 0x0027BC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCallCardNotify other)
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

		// Token: 0x06011042 RID: 69698 RVA: 0x0027DB15 File Offset: 0x0027BD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011043 RID: 69699 RVA: 0x0027DB20 File Offset: 0x0027BD20
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
					if (num == 8U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.CanSelectNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.CardFrom = (PhantomBattleSelectedCardFromType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.OwnerCardUid = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.selectedCardList_.AddEntriesFrom(ref input, PhantomBattleCallCardNotify._repeated_selectedCardList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BC8 RID: 27592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BC9 RID: 27593
		public const int OwnerCardUidFieldNumber = 12;

		// Token: 0x04006BCA RID: 27594
		private int ownerCardUid_;

		// Token: 0x04006BCB RID: 27595
		public const int EffectUidFieldNumber = 1;

		// Token: 0x04006BCC RID: 27596
		private int effectUid_;

		// Token: 0x04006BCD RID: 27597
		public const int SelectedCardListFieldNumber = 15;

		// Token: 0x04006BCE RID: 27598
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_selectedCardList_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(122U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006BCF RID: 27599
		private readonly RepeatedField<PhantomBattleHandCardInfo> selectedCardList_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006BD0 RID: 27600
		public const int CanSelectNumFieldNumber = 6;

		// Token: 0x04006BD1 RID: 27601
		private int canSelectNum_;

		// Token: 0x04006BD2 RID: 27602
		public const int CardFromFieldNumber = 11;

		// Token: 0x04006BD3 RID: 27603
		private PhantomBattleSelectedCardFromType cardFrom_;
	}
}
