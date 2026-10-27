using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000119 RID: 281
	[NetMessage(EMessageId.AtomicProcessAddBuffRequest)]
	public sealed class AtomicProcessAddBuffRequest : IMessage<AtomicProcessAddBuffRequest>, IMessage, IEquatable<AtomicProcessAddBuffRequest>, IDeepCloneable<AtomicProcessAddBuffRequest>, IBufferMessage
	{
		// Token: 0x0600264B RID: 9803 RVA: 0x00065C49 File Offset: 0x00063E49
		[NullableContext(1)]
		public static AtomicProcessAddBuffRequest Create()
		{
			return new AtomicProcessAddBuffRequest();
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00065C50 File Offset: 0x00063E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00065C53 File Offset: 0x00063E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessAddBuffRequest.Descriptor;
			}
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00065C5A File Offset: 0x00063E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest()
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00065C70 File Offset: 0x00063E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest(AtomicProcessAddBuffRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.entityId_ = other.entityId_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00065CD5 File Offset: 0x00063ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffRequest Clone()
		{
			return new AtomicProcessAddBuffRequest(this);
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x00065CDD File Offset: 0x00063EDD
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x00065CE5 File Offset: 0x00063EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x00065CEE File Offset: 0x00063EEE
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x00065CF6 File Offset: 0x00063EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x00065CFF File Offset: 0x00063EFF
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x00065D07 File Offset: 0x00063F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x00065D10 File Offset: 0x00063F10
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x00065D18 File Offset: 0x00063F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x00065D21 File Offset: 0x00063F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00065D29 File Offset: 0x00063F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessAddBuffRequest);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00065D38 File Offset: 0x00063F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessAddBuffRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00065DB8 File Offset: 0x00063FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00065E50 File Offset: 0x00064050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00065E5D File Offset: 0x0006405D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00065E68 File Offset: 0x00064068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntityId);
			}
			this.buffIds_.WriteTo(ref output, AtomicProcessAddBuffRequest._repeated_buffIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00065F0C File Offset: 0x0006410C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			num += this.buffIds_.CalculateSize(AtomicProcessAddBuffRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00065FA8 File Offset: 0x000641A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessAddBuffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00066031 File Offset: 0x00064231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0006603C File Offset: 0x0006423C
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
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.buffIds_.AddEntriesFrom(ref input, AtomicProcessAddBuffRequest._repeated_buffIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002609 RID: 9737
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400260A RID: 9738
		public const int TreeOwnerIdFieldNumber = 12;

		// Token: 0x0400260B RID: 9739
		private int treeOwnerId_;

		// Token: 0x0400260C RID: 9740
		public const int TreeIncIdFieldNumber = 5;

		// Token: 0x0400260D RID: 9741
		private long treeIncId_;

		// Token: 0x0400260E RID: 9742
		public const int NodeIdFieldNumber = 14;

		// Token: 0x0400260F RID: 9743
		private int nodeId_;

		// Token: 0x04002610 RID: 9744
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04002611 RID: 9745
		private int entityId_;

		// Token: 0x04002612 RID: 9746
		public const int BuffIdsFieldNumber = 4;

		// Token: 0x04002613 RID: 9747
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04002614 RID: 9748
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
