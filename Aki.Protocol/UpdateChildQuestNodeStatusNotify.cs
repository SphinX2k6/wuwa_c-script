using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001505 RID: 5381
	[NetMessage(EMessageId.UpdateChildQuestNodeStatusNotify)]
	public sealed class UpdateChildQuestNodeStatusNotify : IMessage<UpdateChildQuestNodeStatusNotify>, IMessage, IEquatable<UpdateChildQuestNodeStatusNotify>, IDeepCloneable<UpdateChildQuestNodeStatusNotify>, IBufferMessage
	{
		// Token: 0x0601C84C RID: 116812 RVA: 0x00422591 File Offset: 0x00420791
		[NullableContext(1)]
		public static UpdateChildQuestNodeStatusNotify Create()
		{
			return new UpdateChildQuestNodeStatusNotify();
		}

		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x0601C84D RID: 116813 RVA: 0x00422598 File Offset: 0x00420798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x0601C84E RID: 116814 RVA: 0x0042259B File Offset: 0x0042079B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChildQuestNodeStatusNotify.Descriptor;
			}
		}

		// Token: 0x0601C84F RID: 116815 RVA: 0x004225A2 File Offset: 0x004207A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateChildQuestNodeStatusNotify()
		{
		}

		// Token: 0x0601C850 RID: 116816 RVA: 0x004225AC File Offset: 0x004207AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateChildQuestNodeStatusNotify(UpdateChildQuestNodeStatusNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C851 RID: 116817 RVA: 0x00422600 File Offset: 0x00420800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateChildQuestNodeStatusNotify Clone()
		{
			return new UpdateChildQuestNodeStatusNotify(this);
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x0601C852 RID: 116818 RVA: 0x00422608 File Offset: 0x00420808
		// (set) Token: 0x0601C853 RID: 116819 RVA: 0x00422610 File Offset: 0x00420810
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

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x0601C854 RID: 116820 RVA: 0x00422619 File Offset: 0x00420819
		// (set) Token: 0x0601C855 RID: 116821 RVA: 0x00422621 File Offset: 0x00420821
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

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x0601C856 RID: 116822 RVA: 0x0042262A File Offset: 0x0042082A
		// (set) Token: 0x0601C857 RID: 116823 RVA: 0x00422632 File Offset: 0x00420832
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

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x0601C858 RID: 116824 RVA: 0x0042263B File Offset: 0x0042083B
		// (set) Token: 0x0601C859 RID: 116825 RVA: 0x00422643 File Offset: 0x00420843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeStatus Status
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

		// Token: 0x0601C85A RID: 116826 RVA: 0x0042264C File Offset: 0x0042084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChildQuestNodeStatusNotify);
		}

		// Token: 0x0601C85B RID: 116827 RVA: 0x0042265C File Offset: 0x0042085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateChildQuestNodeStatusNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C85C RID: 116828 RVA: 0x004226C8 File Offset: 0x004208C8
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
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C85D RID: 116829 RVA: 0x00422758 File Offset: 0x00420958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C85E RID: 116830 RVA: 0x00422765 File Offset: 0x00420965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C85F RID: 116831 RVA: 0x00422770 File Offset: 0x00420970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.NodeId);
			}
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C860 RID: 116832 RVA: 0x00422804 File Offset: 0x00420A04
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
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C861 RID: 116833 RVA: 0x0042288C File Offset: 0x00420A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateChildQuestNodeStatusNotify other)
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
			if (other.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C862 RID: 116834 RVA: 0x00422904 File Offset: 0x00420B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C863 RID: 116835 RVA: 0x00422910 File Offset: 0x00420B10
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
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Status = (ChildQuestNodeStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A47A RID: 42106
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A47B RID: 42107
		public const int TreeOwnerIdFieldNumber = 10;

		// Token: 0x0400A47C RID: 42108
		private int treeOwnerId_;

		// Token: 0x0400A47D RID: 42109
		public const int TreeIncIdFieldNumber = 6;

		// Token: 0x0400A47E RID: 42110
		private long treeIncId_;

		// Token: 0x0400A47F RID: 42111
		public const int NodeIdFieldNumber = 11;

		// Token: 0x0400A480 RID: 42112
		private int nodeId_;

		// Token: 0x0400A481 RID: 42113
		public const int StatusFieldNumber = 14;

		// Token: 0x0400A482 RID: 42114
		private ChildQuestNodeStatus status_;
	}
}
