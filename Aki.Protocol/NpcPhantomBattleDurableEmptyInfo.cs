using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B70 RID: 2928
	public sealed class NpcPhantomBattleDurableEmptyInfo : IMessage<NpcPhantomBattleDurableEmptyInfo>, IMessage, IEquatable<NpcPhantomBattleDurableEmptyInfo>, IDeepCloneable<NpcPhantomBattleDurableEmptyInfo>, IBufferMessage
	{
		// Token: 0x0600FDB2 RID: 64946 RVA: 0x0024F3D2 File Offset: 0x0024D5D2
		[NullableContext(1)]
		public static NpcPhantomBattleDurableEmptyInfo Create()
		{
			return new NpcPhantomBattleDurableEmptyInfo();
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600FDB3 RID: 64947 RVA: 0x0024F3D9 File Offset: 0x0024D5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600FDB4 RID: 64948 RVA: 0x0024F3DC File Offset: 0x0024D5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDurableEmptyInfo.Descriptor;
			}
		}

		// Token: 0x0600FDB5 RID: 64949 RVA: 0x0024F3E3 File Offset: 0x0024D5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo()
		{
		}

		// Token: 0x0600FDB6 RID: 64950 RVA: 0x0024F3EC File Offset: 0x0024D5EC
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

		// Token: 0x0600FDB7 RID: 64951 RVA: 0x0024F440 File Offset: 0x0024D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDurableEmptyInfo Clone()
		{
			return new NpcPhantomBattleDurableEmptyInfo(this);
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600FDB8 RID: 64952 RVA: 0x0024F448 File Offset: 0x0024D648
		// (set) Token: 0x0600FDB9 RID: 64953 RVA: 0x0024F450 File Offset: 0x0024D650
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

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600FDBA RID: 64954 RVA: 0x0024F459 File Offset: 0x0024D659
		// (set) Token: 0x0600FDBB RID: 64955 RVA: 0x0024F461 File Offset: 0x0024D661
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

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600FDBC RID: 64956 RVA: 0x0024F46A File Offset: 0x0024D66A
		// (set) Token: 0x0600FDBD RID: 64957 RVA: 0x0024F472 File Offset: 0x0024D672
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

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600FDBE RID: 64958 RVA: 0x0024F47B File Offset: 0x0024D67B
		// (set) Token: 0x0600FDBF RID: 64959 RVA: 0x0024F483 File Offset: 0x0024D683
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

		// Token: 0x0600FDC0 RID: 64960 RVA: 0x0024F48C File Offset: 0x0024D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDurableEmptyInfo);
		}

		// Token: 0x0600FDC1 RID: 64961 RVA: 0x0024F49C File Offset: 0x0024D69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDurableEmptyInfo other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.DealType == other.DealType && this.CardHeapSize == other.CardHeapSize && this.CardHandSize == other.CardHandSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDC2 RID: 64962 RVA: 0x0024F508 File Offset: 0x0024D708
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

		// Token: 0x0600FDC3 RID: 64963 RVA: 0x0024F598 File Offset: 0x0024D798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDC4 RID: 64964 RVA: 0x0024F5A5 File Offset: 0x0024D7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDC5 RID: 64965 RVA: 0x0024F5B0 File Offset: 0x0024D7B0
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

		// Token: 0x0600FDC6 RID: 64966 RVA: 0x0024F640 File Offset: 0x0024D840
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

		// Token: 0x0600FDC7 RID: 64967 RVA: 0x0024F6C8 File Offset: 0x0024D8C8
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

		// Token: 0x0600FDC8 RID: 64968 RVA: 0x0024F740 File Offset: 0x0024D940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDC9 RID: 64969 RVA: 0x0024F74C File Offset: 0x0024D94C
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

		// Token: 0x0400652F RID: 25903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006530 RID: 25904
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006531 RID: 25905
		private int cardUid_;

		// Token: 0x04006532 RID: 25906
		public const int DealTypeFieldNumber = 2;

		// Token: 0x04006533 RID: 25907
		private PhantomBattleCardDurableDealType dealType_;

		// Token: 0x04006534 RID: 25908
		public const int CardHeapSizeFieldNumber = 3;

		// Token: 0x04006535 RID: 25909
		private int cardHeapSize_;

		// Token: 0x04006536 RID: 25910
		public const int CardHandSizeFieldNumber = 4;

		// Token: 0x04006537 RID: 25911
		private int cardHandSize_;
	}
}
