using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000849 RID: 2121
	[NetMessage(EMessageId.ItemRelateFoundationNotify)]
	public sealed class ItemRelateFoundationNotify : IMessage<ItemRelateFoundationNotify>, IMessage, IEquatable<ItemRelateFoundationNotify>, IDeepCloneable<ItemRelateFoundationNotify>, IBufferMessage
	{
		// Token: 0x0600BD7B RID: 48507 RVA: 0x001C29E1 File Offset: 0x001C0BE1
		[NullableContext(1)]
		public static ItemRelateFoundationNotify Create()
		{
			return new ItemRelateFoundationNotify();
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x001C29E8 File Offset: 0x001C0BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x001C29EB File Offset: 0x001C0BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemRelateFoundationNotify.Descriptor;
			}
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x001C29F2 File Offset: 0x001C0BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationNotify()
		{
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x001C29FC File Offset: 0x001C0BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationNotify(ItemRelateFoundationNotify other) : this()
		{
			this.foundationEntityId_ = other.foundationEntityId_;
			this.itemEntityId_ = other.itemEntityId_;
			this.instId_ = other.instId_;
			this.matchIndex_ = other.matchIndex_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x001C2A5C File Offset: 0x001C0C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationNotify Clone()
		{
			return new ItemRelateFoundationNotify(this);
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x0600BD81 RID: 48513 RVA: 0x001C2A64 File Offset: 0x001C0C64
		// (set) Token: 0x0600BD82 RID: 48514 RVA: 0x001C2A6C File Offset: 0x001C0C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FoundationEntityId
		{
			get
			{
				return this.foundationEntityId_;
			}
			set
			{
				this.foundationEntityId_ = value;
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x001C2A75 File Offset: 0x001C0C75
		// (set) Token: 0x0600BD84 RID: 48516 RVA: 0x001C2A7D File Offset: 0x001C0C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ItemEntityId
		{
			get
			{
				return this.itemEntityId_;
			}
			set
			{
				this.itemEntityId_ = value;
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x0600BD85 RID: 48517 RVA: 0x001C2A86 File Offset: 0x001C0C86
		// (set) Token: 0x0600BD86 RID: 48518 RVA: 0x001C2A8E File Offset: 0x001C0C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x0600BD87 RID: 48519 RVA: 0x001C2A97 File Offset: 0x001C0C97
		// (set) Token: 0x0600BD88 RID: 48520 RVA: 0x001C2A9F File Offset: 0x001C0C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchIndex
		{
			get
			{
				return this.matchIndex_;
			}
			set
			{
				this.matchIndex_ = value;
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600BD89 RID: 48521 RVA: 0x001C2AA8 File Offset: 0x001C0CA8
		// (set) Token: 0x0600BD8A RID: 48522 RVA: 0x001C2AB0 File Offset: 0x001C0CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x001C2AB9 File Offset: 0x001C0CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemRelateFoundationNotify);
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x001C2AC8 File Offset: 0x001C0CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemRelateFoundationNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.ItemEntityId == other.ItemEntityId && this.InstId == other.InstId && this.MatchIndex == other.MatchIndex && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x001C2B44 File Offset: 0x001C0D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityId != 0L)
			{
				num ^= this.FoundationEntityId.GetHashCode();
			}
			if (this.ItemEntityId != 0L)
			{
				num ^= this.ItemEntityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this.Reason != ItemRelateFoundationReason.Normal)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x001C2BED File Offset: 0x001C0DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x001C2BFA File Offset: 0x001C0DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD90 RID: 48528 RVA: 0x001C2C04 File Offset: 0x001C0E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FoundationEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.FoundationEntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this.Reason != ItemRelateFoundationReason.Normal)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Reason);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.ItemEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ItemEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x001C2CB4 File Offset: 0x001C0EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FoundationEntityId);
			}
			if (this.ItemEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ItemEntityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this.Reason != ItemRelateFoundationReason.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD92 RID: 48530 RVA: 0x001C2D54 File Offset: 0x001C0F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemRelateFoundationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityId != 0L)
			{
				this.FoundationEntityId = other.FoundationEntityId;
			}
			if (other.ItemEntityId != 0L)
			{
				this.ItemEntityId = other.ItemEntityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			if (other.Reason != ItemRelateFoundationReason.Normal)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x001C2DE0 File Offset: 0x001C0FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x001C2DEC File Offset: 0x001C0FEC
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.FoundationEntityId = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Reason = (ItemRelateFoundationReason)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ItemEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400531F RID: 21279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005320 RID: 21280
		public const int FoundationEntityIdFieldNumber = 4;

		// Token: 0x04005321 RID: 21281
		private long foundationEntityId_;

		// Token: 0x04005322 RID: 21282
		public const int ItemEntityIdFieldNumber = 15;

		// Token: 0x04005323 RID: 21283
		private long itemEntityId_;

		// Token: 0x04005324 RID: 21284
		public const int InstIdFieldNumber = 8;

		// Token: 0x04005325 RID: 21285
		private int instId_;

		// Token: 0x04005326 RID: 21286
		public const int MatchIndexFieldNumber = 14;

		// Token: 0x04005327 RID: 21287
		private int matchIndex_;

		// Token: 0x04005328 RID: 21288
		public const int ReasonFieldNumber = 10;

		// Token: 0x04005329 RID: 21289
		private ItemRelateFoundationReason reason_;
	}
}
