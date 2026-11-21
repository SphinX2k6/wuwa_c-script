using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C35 RID: 3125
	[NetMessage(EMessageId.PhantomBattleCardDurableEmptyNotify)]
	public sealed class PhantomBattleCardDurableEmptyNotify : IMessage<PhantomBattleCardDurableEmptyNotify>, IMessage, IEquatable<PhantomBattleCardDurableEmptyNotify>, IDeepCloneable<PhantomBattleCardDurableEmptyNotify>, IBufferMessage
	{
		// Token: 0x06010F85 RID: 69509 RVA: 0x0027C7D2 File Offset: 0x0027A9D2
		[NullableContext(1)]
		public static PhantomBattleCardDurableEmptyNotify Create()
		{
			return new PhantomBattleCardDurableEmptyNotify();
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x06010F86 RID: 69510 RVA: 0x0027C7D9 File Offset: 0x0027A9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x06010F87 RID: 69511 RVA: 0x0027C7DC File Offset: 0x0027A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardDurableEmptyNotify.Descriptor;
			}
		}

		// Token: 0x06010F88 RID: 69512 RVA: 0x0027C7E3 File Offset: 0x0027A9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify()
		{
		}

		// Token: 0x06010F89 RID: 69513 RVA: 0x0027C7EB File Offset: 0x0027A9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify(PhantomBattleCardDurableEmptyNotify other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.dealType_ = other.dealType_;
			this.cardHeapSize_ = other.cardHeapSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F8A RID: 69514 RVA: 0x0027C828 File Offset: 0x0027AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardDurableEmptyNotify Clone()
		{
			return new PhantomBattleCardDurableEmptyNotify(this);
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x06010F8B RID: 69515 RVA: 0x0027C830 File Offset: 0x0027AA30
		// (set) Token: 0x06010F8C RID: 69516 RVA: 0x0027C838 File Offset: 0x0027AA38
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

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x06010F8D RID: 69517 RVA: 0x0027C841 File Offset: 0x0027AA41
		// (set) Token: 0x06010F8E RID: 69518 RVA: 0x0027C849 File Offset: 0x0027AA49
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

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x06010F8F RID: 69519 RVA: 0x0027C852 File Offset: 0x0027AA52
		// (set) Token: 0x06010F90 RID: 69520 RVA: 0x0027C85A File Offset: 0x0027AA5A
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

		// Token: 0x06010F91 RID: 69521 RVA: 0x0027C863 File Offset: 0x0027AA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardDurableEmptyNotify);
		}

		// Token: 0x06010F92 RID: 69522 RVA: 0x0027C874 File Offset: 0x0027AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardDurableEmptyNotify other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.DealType == other.DealType && this.CardHeapSize == other.CardHeapSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F93 RID: 69523 RVA: 0x0027C8D0 File Offset: 0x0027AAD0
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

		// Token: 0x06010F94 RID: 69524 RVA: 0x0027C947 File Offset: 0x0027AB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F95 RID: 69525 RVA: 0x0027C954 File Offset: 0x0027AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F96 RID: 69526 RVA: 0x0027C960 File Offset: 0x0027AB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardHeapSize != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CardHeapSize);
			}
			if (this.DealType != PhantomBattleCardDurableDealType.BackHeap)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.DealType);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F97 RID: 69527 RVA: 0x0027C9D8 File Offset: 0x0027ABD8
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

		// Token: 0x06010F98 RID: 69528 RVA: 0x0027CA48 File Offset: 0x0027AC48
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

		// Token: 0x06010F99 RID: 69529 RVA: 0x0027CAAC File Offset: 0x0027ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F9A RID: 69530 RVA: 0x0027CAB8 File Offset: 0x0027ACB8
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
				if (num != 40U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CardUid = input.ReadInt32();
						}
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
		}

		// Token: 0x04006BFE RID: 27646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BFF RID: 27647
		public const int CardUidFieldNumber = 15;

		// Token: 0x04006C00 RID: 27648
		private int cardUid_;

		// Token: 0x04006C01 RID: 27649
		public const int DealTypeFieldNumber = 14;

		// Token: 0x04006C02 RID: 27650
		private PhantomBattleCardDurableDealType dealType_;

		// Token: 0x04006C03 RID: 27651
		public const int CardHeapSizeFieldNumber = 5;

		// Token: 0x04006C04 RID: 27652
		private int cardHeapSize_;
	}
}
