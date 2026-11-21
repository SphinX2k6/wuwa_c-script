using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C31 RID: 3121
	[NetMessage(EMessageId.PhantomBattleCallCardNotify)]
	public sealed class PhantomBattleCallCardNotify : IMessage<PhantomBattleCallCardNotify>, IMessage, IEquatable<PhantomBattleCallCardNotify>, IDeepCloneable<PhantomBattleCallCardNotify>, IBufferMessage
	{
		// Token: 0x06010F2B RID: 69419 RVA: 0x0027B9C2 File Offset: 0x00279BC2
		[NullableContext(1)]
		public static PhantomBattleCallCardNotify Create()
		{
			return new PhantomBattleCallCardNotify();
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x06010F2C RID: 69420 RVA: 0x0027B9C9 File Offset: 0x00279BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x06010F2D RID: 69421 RVA: 0x0027B9CC File Offset: 0x00279BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardNotify.Descriptor;
			}
		}

		// Token: 0x06010F2E RID: 69422 RVA: 0x0027B9D3 File Offset: 0x00279BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardNotify()
		{
		}

		// Token: 0x06010F2F RID: 69423 RVA: 0x0027B9E8 File Offset: 0x00279BE8
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

		// Token: 0x06010F30 RID: 69424 RVA: 0x0027BA4D File Offset: 0x00279C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardNotify Clone()
		{
			return new PhantomBattleCallCardNotify(this);
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x06010F31 RID: 69425 RVA: 0x0027BA55 File Offset: 0x00279C55
		// (set) Token: 0x06010F32 RID: 69426 RVA: 0x0027BA5D File Offset: 0x00279C5D
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

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x06010F33 RID: 69427 RVA: 0x0027BA66 File Offset: 0x00279C66
		// (set) Token: 0x06010F34 RID: 69428 RVA: 0x0027BA6E File Offset: 0x00279C6E
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

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x06010F35 RID: 69429 RVA: 0x0027BA77 File Offset: 0x00279C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> SelectedCardList
		{
			get
			{
				return this.selectedCardList_;
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x06010F36 RID: 69430 RVA: 0x0027BA7F File Offset: 0x00279C7F
		// (set) Token: 0x06010F37 RID: 69431 RVA: 0x0027BA87 File Offset: 0x00279C87
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

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x06010F38 RID: 69432 RVA: 0x0027BA90 File Offset: 0x00279C90
		// (set) Token: 0x06010F39 RID: 69433 RVA: 0x0027BA98 File Offset: 0x00279C98
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

		// Token: 0x06010F3A RID: 69434 RVA: 0x0027BAA1 File Offset: 0x00279CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardNotify);
		}

		// Token: 0x06010F3B RID: 69435 RVA: 0x0027BAB0 File Offset: 0x00279CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardNotify other)
		{
			return other != null && (other == this || (this.OwnerCardUid == other.OwnerCardUid && this.EffectUid == other.EffectUid && this.selectedCardList_.Equals(other.selectedCardList_) && this.CanSelectNum == other.CanSelectNum && this.CardFrom == other.CardFrom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F3C RID: 69436 RVA: 0x0027BB30 File Offset: 0x00279D30
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

		// Token: 0x06010F3D RID: 69437 RVA: 0x0027BBCE File Offset: 0x00279DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F3E RID: 69438 RVA: 0x0027BBDB File Offset: 0x00279DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F3F RID: 69439 RVA: 0x0027BBE4 File Offset: 0x00279DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.CardFrom);
			}
			if (this.CanSelectNum != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CanSelectNum);
			}
			if (this.OwnerCardUid != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.OwnerCardUid);
			}
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EffectUid);
			}
			this.selectedCardList_.WriteTo(ref output, PhantomBattleCallCardNotify._repeated_selectedCardList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F40 RID: 69440 RVA: 0x0027BC88 File Offset: 0x00279E88
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

		// Token: 0x06010F41 RID: 69441 RVA: 0x0027BD24 File Offset: 0x00279F24
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

		// Token: 0x06010F42 RID: 69442 RVA: 0x0027BDAD File Offset: 0x00279FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F43 RID: 69443 RVA: 0x0027BDB8 File Offset: 0x00279FB8
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.CardFrom = (PhantomBattleSelectedCardFromType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.CanSelectNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.OwnerCardUid = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.EffectUid = input.ReadInt32();
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

		// Token: 0x04006BDC RID: 27612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BDD RID: 27613
		public const int OwnerCardUidFieldNumber = 10;

		// Token: 0x04006BDE RID: 27614
		private int ownerCardUid_;

		// Token: 0x04006BDF RID: 27615
		public const int EffectUidFieldNumber = 13;

		// Token: 0x04006BE0 RID: 27616
		private int effectUid_;

		// Token: 0x04006BE1 RID: 27617
		public const int SelectedCardListFieldNumber = 15;

		// Token: 0x04006BE2 RID: 27618
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_selectedCardList_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(122U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006BE3 RID: 27619
		private readonly RepeatedField<PhantomBattleHandCardInfo> selectedCardList_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006BE4 RID: 27620
		public const int CanSelectNumFieldNumber = 9;

		// Token: 0x04006BE5 RID: 27621
		private int canSelectNum_;

		// Token: 0x04006BE6 RID: 27622
		public const int CardFromFieldNumber = 2;

		// Token: 0x04006BE7 RID: 27623
		private PhantomBattleSelectedCardFromType cardFrom_;
	}
}
