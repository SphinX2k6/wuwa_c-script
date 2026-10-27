using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA2 RID: 3234
	[NetMessage(EMessageId.PhantomBattleReconstructCardNotify)]
	public sealed class PhantomBattleReconstructCardNotify : IMessage<PhantomBattleReconstructCardNotify>, IMessage, IEquatable<PhantomBattleReconstructCardNotify>, IDeepCloneable<PhantomBattleReconstructCardNotify>, IBufferMessage
	{
		// Token: 0x06011867 RID: 71783 RVA: 0x002914D9 File Offset: 0x0028F6D9
		[NullableContext(1)]
		public static PhantomBattleReconstructCardNotify Create()
		{
			return new PhantomBattleReconstructCardNotify();
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x06011868 RID: 71784 RVA: 0x002914E0 File Offset: 0x0028F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x06011869 RID: 71785 RVA: 0x002914E3 File Offset: 0x0028F6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardNotify.Descriptor;
			}
		}

		// Token: 0x0601186A RID: 71786 RVA: 0x002914EA File Offset: 0x0028F6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardNotify()
		{
		}

		// Token: 0x0601186B RID: 71787 RVA: 0x00291500 File Offset: 0x0028F700
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

		// Token: 0x0601186C RID: 71788 RVA: 0x00291565 File Offset: 0x0028F765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardNotify Clone()
		{
			return new PhantomBattleReconstructCardNotify(this);
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0601186D RID: 71789 RVA: 0x0029156D File Offset: 0x0028F76D
		// (set) Token: 0x0601186E RID: 71790 RVA: 0x00291575 File Offset: 0x0028F775
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

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0601186F RID: 71791 RVA: 0x0029157E File Offset: 0x0028F77E
		// (set) Token: 0x06011870 RID: 71792 RVA: 0x00291586 File Offset: 0x0028F786
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

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x06011871 RID: 71793 RVA: 0x0029158F File Offset: 0x0028F78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> SelectedCardList
		{
			get
			{
				return this.selectedCardList_;
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x06011872 RID: 71794 RVA: 0x00291597 File Offset: 0x0028F797
		// (set) Token: 0x06011873 RID: 71795 RVA: 0x0029159F File Offset: 0x0028F79F
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

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x06011874 RID: 71796 RVA: 0x002915A8 File Offset: 0x0028F7A8
		// (set) Token: 0x06011875 RID: 71797 RVA: 0x002915B0 File Offset: 0x0028F7B0
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

		// Token: 0x06011876 RID: 71798 RVA: 0x002915B9 File Offset: 0x0028F7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardNotify);
		}

		// Token: 0x06011877 RID: 71799 RVA: 0x002915C8 File Offset: 0x0028F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardNotify other)
		{
			return other != null && (other == this || (this.OwnerCardUid == other.OwnerCardUid && this.EffectUid == other.EffectUid && this.selectedCardList_.Equals(other.selectedCardList_) && this.CanSelectNum == other.CanSelectNum && this.CardFrom == other.CardFrom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011878 RID: 71800 RVA: 0x00291648 File Offset: 0x0028F848
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

		// Token: 0x06011879 RID: 71801 RVA: 0x002916E6 File Offset: 0x0028F8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601187A RID: 71802 RVA: 0x002916F3 File Offset: 0x0028F8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601187B RID: 71803 RVA: 0x002916FC File Offset: 0x0028F8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectedCardList_.WriteTo(ref output, PhantomBattleReconstructCardNotify._repeated_selectedCardList_codec);
			if (this.CanSelectNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CanSelectNum);
			}
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EffectUid);
			}
			if (this.OwnerCardUid != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.OwnerCardUid);
			}
			if (this.CardFrom != PhantomBattleSelectedCardFromType.HandCard)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.CardFrom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601187C RID: 71804 RVA: 0x002917A0 File Offset: 0x0028F9A0
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

		// Token: 0x0601187D RID: 71805 RVA: 0x0029183C File Offset: 0x0028FA3C
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

		// Token: 0x0601187E RID: 71806 RVA: 0x002918C5 File Offset: 0x0028FAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601187F RID: 71807 RVA: 0x002918D0 File Offset: 0x0028FAD0
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.selectedCardList_.AddEntriesFrom(ref input, PhantomBattleReconstructCardNotify._repeated_selectedCardList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.CanSelectNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.OwnerCardUid = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CardFrom = (PhantomBattleSelectedCardFromType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E83 RID: 28291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E84 RID: 28292
		public const int OwnerCardUidFieldNumber = 12;

		// Token: 0x04006E85 RID: 28293
		private int ownerCardUid_;

		// Token: 0x04006E86 RID: 28294
		public const int EffectUidFieldNumber = 9;

		// Token: 0x04006E87 RID: 28295
		private int effectUid_;

		// Token: 0x04006E88 RID: 28296
		public const int SelectedCardListFieldNumber = 1;

		// Token: 0x04006E89 RID: 28297
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_selectedCardList_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006E8A RID: 28298
		private readonly RepeatedField<PhantomBattleHandCardInfo> selectedCardList_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006E8B RID: 28299
		public const int CanSelectNumFieldNumber = 2;

		// Token: 0x04006E8C RID: 28300
		private int canSelectNum_;

		// Token: 0x04006E8D RID: 28301
		public const int CardFromFieldNumber = 14;

		// Token: 0x04006E8E RID: 28302
		private PhantomBattleSelectedCardFromType cardFrom_;
	}
}
