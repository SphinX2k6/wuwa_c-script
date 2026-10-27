using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C45 RID: 3141
	[NetMessage(EMessageId.PhantomBattleCardDurableEmptyNotify)]
	public sealed class PhantomBattleCardDurableEmptyNotify : IMessage<PhantomBattleCardDurableEmptyNotify>, IMessage, IEquatable<PhantomBattleCardDurableEmptyNotify>, IDeepCloneable<PhantomBattleCardDurableEmptyNotify>, IBufferMessage
	{
		// Token: 0x06011085 RID: 69765 RVA: 0x0027E53A File Offset: 0x0027C73A
		[NullableContext(1)]
		public static PhantomBattleCardDurableEmptyNotify Create()
		{
			return new PhantomBattleCardDurableEmptyNotify();
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x06011086 RID: 69766 RVA: 0x0027E541 File Offset: 0x0027C741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x06011087 RID: 69767 RVA: 0x0027E544 File Offset: 0x0027C744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardDurableEmptyNotify.Descriptor;
			}
		}

		// Token: 0x06011088 RID: 69768 RVA: 0x0027E54B File Offset: 0x0027C74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify()
		{
		}

		// Token: 0x06011089 RID: 69769 RVA: 0x0027E553 File Offset: 0x0027C753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify(PhantomBattleCardDurableEmptyNotify other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.dealType_ = other.dealType_;
			this.cardHeapSize_ = other.cardHeapSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601108A RID: 69770 RVA: 0x0027E590 File Offset: 0x0027C790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify Clone()
		{
			return new PhantomBattleCardDurableEmptyNotify(this);
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0601108B RID: 69771 RVA: 0x0027E598 File Offset: 0x0027C798
		// (set) Token: 0x0601108C RID: 69772 RVA: 0x0027E5A0 File Offset: 0x0027C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0601108D RID: 69773 RVA: 0x0027E5A9 File Offset: 0x0027C7A9
		// (set) Token: 0x0601108E RID: 69774 RVA: 0x0027E5B1 File Offset: 0x0027C7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableDealType DealType
		{
			get
			{
				return this.dealType_;
			}
			set
			{
				this.dealType_ = value;
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0601108F RID: 69775 RVA: 0x0027E5BA File Offset: 0x0027C7BA
		// (set) Token: 0x06011090 RID: 69776 RVA: 0x0027E5C2 File Offset: 0x0027C7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardHeapSize
		{
			get
			{
				return this.cardHeapSize_;
			}
			set
			{
				this.cardHeapSize_ = value;
			}
		}

		// Token: 0x06011091 RID: 69777 RVA: 0x0027E5CB File Offset: 0x0027C7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardDurableEmptyNotify);
		}

		// Token: 0x06011092 RID: 69778 RVA: 0x0027E5DC File Offset: 0x0027C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardDurableEmptyNotify other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.DealType == other.DealType && this.CardHeapSize == other.CardHeapSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011093 RID: 69779 RVA: 0x0027E638 File Offset: 0x0027C838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				num ^= this.DealType.GetHashCode();
			}
			if (this.CardHeapSize != 0)
			{
				num ^= this.CardHeapSize.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011094 RID: 69780 RVA: 0x0027E6AF File Offset: 0x0027C8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011095 RID: 69781 RVA: 0x0027E6BC File Offset: 0x0027C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011096 RID: 69782 RVA: 0x0027E6C8 File Offset: 0x0027C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardUid);
			}
			if (this.CardHeapSize != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CardHeapSize);
			}
			if (this.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.DealType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011097 RID: 69783 RVA: 0x0027E740 File Offset: 0x0027C940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DealType);
			}
			if (this.CardHeapSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardHeapSize);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011098 RID: 69784 RVA: 0x0027E7B0 File Offset: 0x0027C9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardDurableEmptyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				this.DealType = other.DealType;
			}
			if (other.CardHeapSize != 0)
			{
				this.CardHeapSize = other.CardHeapSize;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011099 RID: 69785 RVA: 0x0027E814 File Offset: 0x0027CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601109A RID: 69786 RVA: 0x0027E820 File Offset: 0x0027CA20
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DealType = (PhantomBattleCardDurableDealType)input.ReadEnum();
						}
					}
					else
					{
						this.CardHeapSize = input.ReadInt32();
					}
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006BEA RID: 27626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BEB RID: 27627
		public const int CardUidFieldNumber = 2;

		// Token: 0x04006BEC RID: 27628
		private int cardUid_;

		// Token: 0x04006BED RID: 27629
		public const int DealTypeFieldNumber = 11;

		// Token: 0x04006BEE RID: 27630
		private PhantomBattleCardDurableDealType dealType_;

		// Token: 0x04006BEF RID: 27631
		public const int CardHeapSizeFieldNumber = 5;

		// Token: 0x04006BF0 RID: 27632
		private int cardHeapSize_;
	}
}
