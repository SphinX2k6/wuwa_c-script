using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EE RID: 2030
	public sealed class InfrV2OneTree : IMessage<InfrV2OneTree>, IMessage, IEquatable<InfrV2OneTree>, IDeepCloneable<InfrV2OneTree>, IBufferMessage
	{
		// Token: 0x0600B62C RID: 46636 RVA: 0x001B2C25 File Offset: 0x001B0E25
		[NullableContext(1)]
		public static InfrV2OneTree Create()
		{
			return new InfrV2OneTree();
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600B62D RID: 46637 RVA: 0x001B2C2C File Offset: 0x001B0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrV2OneTree> Parser
		{
			get
			{
				return InfrV2OneTree._parser;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600B62E RID: 46638 RVA: 0x001B2C33 File Offset: 0x001B0E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600B62F RID: 46639 RVA: 0x001B2C36 File Offset: 0x001B0E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2OneTree.Descriptor;
			}
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x001B2C3D File Offset: 0x001B0E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2OneTree()
		{
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x001B2C48 File Offset: 0x001B0E48
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

		// Token: 0x0600B632 RID: 46642 RVA: 0x001B2CA8 File Offset: 0x001B0EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2OneTree Clone()
		{
			return new InfrV2OneTree(this);
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600B633 RID: 46643 RVA: 0x001B2CB0 File Offset: 0x001B0EB0
		// (set) Token: 0x0600B634 RID: 46644 RVA: 0x001B2CB8 File Offset: 0x001B0EB8
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

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x001B2CC1 File Offset: 0x001B0EC1
		// (set) Token: 0x0600B636 RID: 46646 RVA: 0x001B2CC9 File Offset: 0x001B0EC9
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

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0600B637 RID: 46647 RVA: 0x001B2CD2 File Offset: 0x001B0ED2
		// (set) Token: 0x0600B638 RID: 46648 RVA: 0x001B2CDA File Offset: 0x001B0EDA
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

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0600B639 RID: 46649 RVA: 0x001B2CE3 File Offset: 0x001B0EE3
		// (set) Token: 0x0600B63A RID: 46650 RVA: 0x001B2CEB File Offset: 0x001B0EEB
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

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x001B2CF4 File Offset: 0x001B0EF4
		// (set) Token: 0x0600B63C RID: 46652 RVA: 0x001B2CFC File Offset: 0x001B0EFC
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

		// Token: 0x0600B63D RID: 46653 RVA: 0x001B2D05 File Offset: 0x001B0F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2OneTree);
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x001B2D14 File Offset: 0x001B0F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2OneTree other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.Status == other.Status && this.CompleteTime == other.CompleteTime && this.TotalGiftCount == other.TotalGiftCount && this.LastGiftTime == other.LastGiftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x001B2D90 File Offset: 0x001B0F90
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

		// Token: 0x0600B640 RID: 46656 RVA: 0x001B2E39 File Offset: 0x001B1039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x001B2E46 File Offset: 0x001B1046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x001B2E50 File Offset: 0x001B1050
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

		// Token: 0x0600B643 RID: 46659 RVA: 0x001B2EFC File Offset: 0x001B10FC
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

		// Token: 0x0600B644 RID: 46660 RVA: 0x001B2F9C File Offset: 0x001B119C
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

		// Token: 0x0600B645 RID: 46661 RVA: 0x001B3028 File Offset: 0x001B1228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x001B3034 File Offset: 0x001B1234
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

		// Token: 0x040050F6 RID: 20726
		private static readonly MessageParser<InfrV2OneTree> _parser = new MessageParser<InfrV2OneTree>(() => new InfrV2OneTree());

		// Token: 0x040050F7 RID: 20727
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F8 RID: 20728
		public const int TreeIdFieldNumber = 1;

		// Token: 0x040050F9 RID: 20729
		private int treeId_;

		// Token: 0x040050FA RID: 20730
		public const int StatusFieldNumber = 2;

		// Token: 0x040050FB RID: 20731
		private InfrV2StatusPb status_;

		// Token: 0x040050FC RID: 20732
		public const int CompleteTimeFieldNumber = 3;

		// Token: 0x040050FD RID: 20733
		private long completeTime_;

		// Token: 0x040050FE RID: 20734
		public const int TotalGiftCountFieldNumber = 4;

		// Token: 0x040050FF RID: 20735
		private long totalGiftCount_;

		// Token: 0x04005100 RID: 20736
		public const int LastGiftTimeFieldNumber = 5;

		// Token: 0x04005101 RID: 20737
		private long lastGiftTime_;
	}
}
