using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000802 RID: 2050
	public sealed class InfrV2OneTree : IMessage<InfrV2OneTree>, IMessage, IEquatable<InfrV2OneTree>, IDeepCloneable<InfrV2OneTree>, IBufferMessage
	{
		// Token: 0x0600B782 RID: 46978 RVA: 0x001B5665 File Offset: 0x001B3865
		[NullableContext(1)]
		public static InfrV2OneTree Create()
		{
			return new InfrV2OneTree();
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x0600B783 RID: 46979 RVA: 0x001B566C File Offset: 0x001B386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrV2OneTree> Parser
		{
			get
			{
				return InfrV2OneTree._parser;
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x0600B784 RID: 46980 RVA: 0x001B5673 File Offset: 0x001B3873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x0600B785 RID: 46981 RVA: 0x001B5676 File Offset: 0x001B3876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2OneTree.Descriptor;
			}
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x001B567D File Offset: 0x001B387D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2OneTree()
		{
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x001B5688 File Offset: 0x001B3888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2OneTree(InfrV2OneTree other) : this()
		{
			this.treeId_ = other.treeId_;
			this.status_ = other.status_;
			this.completeTime_ = other.completeTime_;
			this.totalGiftCount_ = other.totalGiftCount_;
			this.lastGiftTime_ = other.lastGiftTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x001B56E8 File Offset: 0x001B38E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2OneTree Clone()
		{
			return new InfrV2OneTree(this);
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x0600B789 RID: 46985 RVA: 0x001B56F0 File Offset: 0x001B38F0
		// (set) Token: 0x0600B78A RID: 46986 RVA: 0x001B56F8 File Offset: 0x001B38F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x0600B78B RID: 46987 RVA: 0x001B5701 File Offset: 0x001B3901
		// (set) Token: 0x0600B78C RID: 46988 RVA: 0x001B5709 File Offset: 0x001B3909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2StatusPb Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x001B5712 File Offset: 0x001B3912
		// (set) Token: 0x0600B78E RID: 46990 RVA: 0x001B571A File Offset: 0x001B391A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CompleteTime
		{
			get
			{
				return this.completeTime_;
			}
			set
			{
				this.completeTime_ = value;
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x0600B78F RID: 46991 RVA: 0x001B5723 File Offset: 0x001B3923
		// (set) Token: 0x0600B790 RID: 46992 RVA: 0x001B572B File Offset: 0x001B392B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalGiftCount
		{
			get
			{
				return this.totalGiftCount_;
			}
			set
			{
				this.totalGiftCount_ = value;
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x0600B791 RID: 46993 RVA: 0x001B5734 File Offset: 0x001B3934
		// (set) Token: 0x0600B792 RID: 46994 RVA: 0x001B573C File Offset: 0x001B393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastGiftTime
		{
			get
			{
				return this.lastGiftTime_;
			}
			set
			{
				this.lastGiftTime_ = value;
			}
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x001B5745 File Offset: 0x001B3945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2OneTree);
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x001B5754 File Offset: 0x001B3954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2OneTree other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.Status == other.Status && this.CompleteTime == other.CompleteTime && this.TotalGiftCount == other.TotalGiftCount && this.LastGiftTime == other.LastGiftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x001B57D0 File Offset: 0x001B39D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this.Status != InfrV2StatusPb.InfrV2StatusLock)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.CompleteTime != 0L)
			{
				num ^= this.CompleteTime.GetHashCode();
			}
			if (this.TotalGiftCount != 0L)
			{
				num ^= this.TotalGiftCount.GetHashCode();
			}
			if (this.LastGiftTime != 0L)
			{
				num ^= this.LastGiftTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x001B5879 File Offset: 0x001B3A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x001B5886 File Offset: 0x001B3A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x001B5890 File Offset: 0x001B3A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeId);
			}
			if (this.Status != InfrV2StatusPb.InfrV2StatusLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this.CompleteTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CompleteTime);
			}
			if (this.TotalGiftCount != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TotalGiftCount);
			}
			if (this.LastGiftTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LastGiftTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x001B593C File Offset: 0x001B3B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this.Status != InfrV2StatusPb.InfrV2StatusLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.CompleteTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CompleteTime);
			}
			if (this.TotalGiftCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalGiftCount);
			}
			if (this.LastGiftTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastGiftTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x001B59DC File Offset: 0x001B3BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2OneTree other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			if (other.Status != InfrV2StatusPb.InfrV2StatusLock)
			{
				this.Status = other.Status;
			}
			if (other.CompleteTime != 0L)
			{
				this.CompleteTime = other.CompleteTime;
			}
			if (other.TotalGiftCount != 0L)
			{
				this.TotalGiftCount = other.TotalGiftCount;
			}
			if (other.LastGiftTime != 0L)
			{
				this.LastGiftTime = other.LastGiftTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x001B5A68 File Offset: 0x001B3C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x001B5A74 File Offset: 0x001B3C74
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
						this.TreeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Status = (InfrV2StatusPb)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CompleteTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.TotalGiftCount = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.LastGiftTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050FD RID: 20733
		private static readonly MessageParser<InfrV2OneTree> _parser = new MessageParser<InfrV2OneTree>(() => new InfrV2OneTree());

		// Token: 0x040050FE RID: 20734
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050FF RID: 20735
		public const int TreeIdFieldNumber = 1;

		// Token: 0x04005100 RID: 20736
		private int treeId_;

		// Token: 0x04005101 RID: 20737
		public const int StatusFieldNumber = 2;

		// Token: 0x04005102 RID: 20738
		private InfrV2StatusPb status_;

		// Token: 0x04005103 RID: 20739
		public const int CompleteTimeFieldNumber = 3;

		// Token: 0x04005104 RID: 20740
		private long completeTime_;

		// Token: 0x04005105 RID: 20741
		public const int TotalGiftCountFieldNumber = 4;

		// Token: 0x04005106 RID: 20742
		private long totalGiftCount_;

		// Token: 0x04005107 RID: 20743
		public const int LastGiftTimeFieldNumber = 5;

		// Token: 0x04005108 RID: 20744
		private long lastGiftTime_;
	}
}
