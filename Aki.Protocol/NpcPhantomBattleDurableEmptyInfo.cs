using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B60 RID: 2912
	public sealed class NpcPhantomBattleDurableEmptyInfo : IMessage<NpcPhantomBattleDurableEmptyInfo>, IMessage, IEquatable<NpcPhantomBattleDurableEmptyInfo>, IDeepCloneable<NpcPhantomBattleDurableEmptyInfo>, IBufferMessage
	{
		// Token: 0x0600FCAE RID: 64686 RVA: 0x0024D502 File Offset: 0x0024B702
		[NullableContext(1)]
		public static NpcPhantomBattleDurableEmptyInfo Create()
		{
			return new NpcPhantomBattleDurableEmptyInfo();
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600FCAF RID: 64687 RVA: 0x0024D509 File Offset: 0x0024B709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600FCB0 RID: 64688 RVA: 0x0024D50C File Offset: 0x0024B70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDurableEmptyInfo.Descriptor;
			}
		}

		// Token: 0x0600FCB1 RID: 64689 RVA: 0x0024D513 File Offset: 0x0024B713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo()
		{
		}

		// Token: 0x0600FCB2 RID: 64690 RVA: 0x0024D51C File Offset: 0x0024B71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo(NpcPhantomBattleDurableEmptyInfo other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.dealType_ = other.dealType_;
			this.cardHeapSize_ = other.cardHeapSize_;
			this.cardHandSize_ = other.cardHandSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCB3 RID: 64691 RVA: 0x0024D570 File Offset: 0x0024B770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo Clone()
		{
			return new NpcPhantomBattleDurableEmptyInfo(this);
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600FCB4 RID: 64692 RVA: 0x0024D578 File Offset: 0x0024B778
		// (set) Token: 0x0600FCB5 RID: 64693 RVA: 0x0024D580 File Offset: 0x0024B780
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

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600FCB6 RID: 64694 RVA: 0x0024D589 File Offset: 0x0024B789
		// (set) Token: 0x0600FCB7 RID: 64695 RVA: 0x0024D591 File Offset: 0x0024B791
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

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600FCB8 RID: 64696 RVA: 0x0024D59A File Offset: 0x0024B79A
		// (set) Token: 0x0600FCB9 RID: 64697 RVA: 0x0024D5A2 File Offset: 0x0024B7A2
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

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600FCBA RID: 64698 RVA: 0x0024D5AB File Offset: 0x0024B7AB
		// (set) Token: 0x0600FCBB RID: 64699 RVA: 0x0024D5B3 File Offset: 0x0024B7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardHandSize
		{
			get
			{
				return this.cardHandSize_;
			}
			set
			{
				this.cardHandSize_ = value;
			}
		}

		// Token: 0x0600FCBC RID: 64700 RVA: 0x0024D5BC File Offset: 0x0024B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDurableEmptyInfo);
		}

		// Token: 0x0600FCBD RID: 64701 RVA: 0x0024D5CC File Offset: 0x0024B7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDurableEmptyInfo other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.DealType == other.DealType && this.CardHeapSize == other.CardHeapSize && this.CardHandSize == other.CardHandSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCBE RID: 64702 RVA: 0x0024D638 File Offset: 0x0024B838
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
			if (this.CardHandSize != 0)
			{
				num ^= this.CardHandSize.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCBF RID: 64703 RVA: 0x0024D6C8 File Offset: 0x0024B8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCC0 RID: 64704 RVA: 0x0024D6D5 File Offset: 0x0024B8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCC1 RID: 64705 RVA: 0x0024D6E0 File Offset: 0x0024B8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUid);
			}
			if (this.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.DealType);
			}
			if (this.CardHeapSize != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardHeapSize);
			}
			if (this.CardHandSize != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardHandSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCC2 RID: 64706 RVA: 0x0024D770 File Offset: 0x0024B970
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
			if (this.CardHandSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardHandSize);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCC3 RID: 64707 RVA: 0x0024D7F8 File Offset: 0x0024B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleDurableEmptyInfo other)
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
			if (other.CardHandSize != 0)
			{
				this.CardHandSize = other.CardHandSize;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCC4 RID: 64708 RVA: 0x0024D870 File Offset: 0x0024BA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCC5 RID: 64709 RVA: 0x0024D87C File Offset: 0x0024BA7C
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
					if (num == 8U)
					{
						this.CardUid = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DealType = (PhantomBattleCardDurableDealType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CardHeapSize = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CardHandSize = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400653F RID: 25919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006540 RID: 25920
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006541 RID: 25921
		private int cardUid_;

		// Token: 0x04006542 RID: 25922
		public const int DealTypeFieldNumber = 2;

		// Token: 0x04006543 RID: 25923
		private PhantomBattleCardDurableDealType dealType_;

		// Token: 0x04006544 RID: 25924
		public const int CardHeapSizeFieldNumber = 3;

		// Token: 0x04006545 RID: 25925
		private int cardHeapSize_;

		// Token: 0x04006546 RID: 25926
		public const int CardHandSizeFieldNumber = 4;

		// Token: 0x04006547 RID: 25927
		private int cardHandSize_;
	}
}
