using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085B RID: 2139
	[NetMessage(EMessageId.ItemRelateFoundationNotify)]
	public sealed class ItemRelateFoundationNotify : IMessage<ItemRelateFoundationNotify>, IMessage, IEquatable<ItemRelateFoundationNotify>, IDeepCloneable<ItemRelateFoundationNotify>, IBufferMessage
	{
		// Token: 0x0600BEA9 RID: 48809 RVA: 0x001C4EAD File Offset: 0x001C30AD
		[NullableContext(1)]
		public static ItemRelateFoundationNotify Create()
		{
			return new ItemRelateFoundationNotify();
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600BEAA RID: 48810 RVA: 0x001C4EB4 File Offset: 0x001C30B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600BEAB RID: 48811 RVA: 0x001C4EB7 File Offset: 0x001C30B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemRelateFoundationNotify.Descriptor;
			}
		}

		// Token: 0x0600BEAC RID: 48812 RVA: 0x001C4EBE File Offset: 0x001C30BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationNotify()
		{
		}

		// Token: 0x0600BEAD RID: 48813 RVA: 0x001C4EC8 File Offset: 0x001C30C8
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

		// Token: 0x0600BEAE RID: 48814 RVA: 0x001C4F28 File Offset: 0x001C3128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemRelateFoundationNotify Clone()
		{
			return new ItemRelateFoundationNotify(this);
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x001C4F30 File Offset: 0x001C3130
		// (set) Token: 0x0600BEB0 RID: 48816 RVA: 0x001C4F38 File Offset: 0x001C3138
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

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x001C4F41 File Offset: 0x001C3141
		// (set) Token: 0x0600BEB2 RID: 48818 RVA: 0x001C4F49 File Offset: 0x001C3149
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

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x001C4F52 File Offset: 0x001C3152
		// (set) Token: 0x0600BEB4 RID: 48820 RVA: 0x001C4F5A File Offset: 0x001C315A
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

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600BEB5 RID: 48821 RVA: 0x001C4F63 File Offset: 0x001C3163
		// (set) Token: 0x0600BEB6 RID: 48822 RVA: 0x001C4F6B File Offset: 0x001C316B
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

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600BEB7 RID: 48823 RVA: 0x001C4F74 File Offset: 0x001C3174
		// (set) Token: 0x0600BEB8 RID: 48824 RVA: 0x001C4F7C File Offset: 0x001C317C
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

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x001C4F85 File Offset: 0x001C3185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemRelateFoundationNotify);
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x001C4F94 File Offset: 0x001C3194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemRelateFoundationNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.ItemEntityId == other.ItemEntityId && this.InstId == other.InstId && this.MatchIndex == other.MatchIndex && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x001C5010 File Offset: 0x001C3210
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

		// Token: 0x0600BEBC RID: 48828 RVA: 0x001C50B9 File Offset: 0x001C32B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x001C50C6 File Offset: 0x001C32C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x001C50D0 File Offset: 0x001C32D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.ItemEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ItemEntityId);
			}
			if (this.Reason != ItemRelateFoundationReason.Normal)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			if (this.FoundationEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.FoundationEntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEBF RID: 48831 RVA: 0x001C517C File Offset: 0x001C337C
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

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x001C521C File Offset: 0x001C341C
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

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x001C52A8 File Offset: 0x001C34A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x001C52B4 File Offset: 0x001C34B4
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
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Reason = (ItemRelateFoundationReason)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.FoundationEntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400531C RID: 21276
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400531D RID: 21277
		public const int FoundationEntityIdFieldNumber = 9;

		// Token: 0x0400531E RID: 21278
		private long foundationEntityId_;

		// Token: 0x0400531F RID: 21279
		public const int ItemEntityIdFieldNumber = 2;

		// Token: 0x04005320 RID: 21280
		private long itemEntityId_;

		// Token: 0x04005321 RID: 21281
		public const int InstIdFieldNumber = 14;

		// Token: 0x04005322 RID: 21282
		private int instId_;

		// Token: 0x04005323 RID: 21283
		public const int MatchIndexFieldNumber = 1;

		// Token: 0x04005324 RID: 21284
		private int matchIndex_;

		// Token: 0x04005325 RID: 21285
		public const int ReasonFieldNumber = 5;

		// Token: 0x04005326 RID: 21286
		private ItemRelateFoundationReason reason_;
	}
}
