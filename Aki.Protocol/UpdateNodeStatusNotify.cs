using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001512 RID: 5394
	[NetMessage(EMessageId.UpdateNodeStatusNotify)]
	public sealed class UpdateNodeStatusNotify : IMessage<UpdateNodeStatusNotify>, IMessage, IEquatable<UpdateNodeStatusNotify>, IDeepCloneable<UpdateNodeStatusNotify>, IBufferMessage
	{
		// Token: 0x0601C948 RID: 117064 RVA: 0x004245B3 File Offset: 0x004227B3
		[NullableContext(1)]
		public static UpdateNodeStatusNotify Create()
		{
			return new UpdateNodeStatusNotify();
		}

		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x0601C949 RID: 117065 RVA: 0x004245BA File Offset: 0x004227BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060AE RID: 24750
		// (get) Token: 0x0601C94A RID: 117066 RVA: 0x004245BD File Offset: 0x004227BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateNodeStatusNotify.Descriptor;
			}
		}

		// Token: 0x0601C94B RID: 117067 RVA: 0x004245C4 File Offset: 0x004227C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeStatusNotify()
		{
		}

		// Token: 0x0601C94C RID: 117068 RVA: 0x004245CC File Offset: 0x004227CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeStatusNotify(UpdateNodeStatusNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C94D RID: 117069 RVA: 0x00424620 File Offset: 0x00422820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeStatusNotify Clone()
		{
			return new UpdateNodeStatusNotify(this);
		}

		// Token: 0x170060AF RID: 24751
		// (get) Token: 0x0601C94E RID: 117070 RVA: 0x00424628 File Offset: 0x00422828
		// (set) Token: 0x0601C94F RID: 117071 RVA: 0x00424630 File Offset: 0x00422830
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

		// Token: 0x170060B0 RID: 24752
		// (get) Token: 0x0601C950 RID: 117072 RVA: 0x00424639 File Offset: 0x00422839
		// (set) Token: 0x0601C951 RID: 117073 RVA: 0x00424641 File Offset: 0x00422841
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

		// Token: 0x170060B1 RID: 24753
		// (get) Token: 0x0601C952 RID: 117074 RVA: 0x0042464A File Offset: 0x0042284A
		// (set) Token: 0x0601C953 RID: 117075 RVA: 0x00424652 File Offset: 0x00422852
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

		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x0601C954 RID: 117076 RVA: 0x0042465B File Offset: 0x0042285B
		// (set) Token: 0x0601C955 RID: 117077 RVA: 0x00424663 File Offset: 0x00422863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeStatus Status
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

		// Token: 0x0601C956 RID: 117078 RVA: 0x0042466C File Offset: 0x0042286C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateNodeStatusNotify);
		}

		// Token: 0x0601C957 RID: 117079 RVA: 0x0042467C File Offset: 0x0042287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateNodeStatusNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C958 RID: 117080 RVA: 0x004246E8 File Offset: 0x004228E8
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
			if (this.Status != NodeStatus.NotActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C959 RID: 117081 RVA: 0x00424778 File Offset: 0x00422978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C95A RID: 117082 RVA: 0x00424785 File Offset: 0x00422985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C95B RID: 117083 RVA: 0x00424790 File Offset: 0x00422990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.Status != NodeStatus.NotActive)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Status);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C95C RID: 117084 RVA: 0x00424824 File Offset: 0x00422A24
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
			if (this.Status != NodeStatus.NotActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C95D RID: 117085 RVA: 0x004248AC File Offset: 0x00422AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateNodeStatusNotify other)
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
			if (other.Status != NodeStatus.NotActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C95E RID: 117086 RVA: 0x00424924 File Offset: 0x00422B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C95F RID: 117087 RVA: 0x00424930 File Offset: 0x00422B30
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Status = (NodeStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A4BA RID: 42170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4BB RID: 42171
		public const int TreeOwnerIdFieldNumber = 5;

		// Token: 0x0400A4BC RID: 42172
		private int treeOwnerId_;

		// Token: 0x0400A4BD RID: 42173
		public const int TreeIncIdFieldNumber = 4;

		// Token: 0x0400A4BE RID: 42174
		private long treeIncId_;

		// Token: 0x0400A4BF RID: 42175
		public const int NodeIdFieldNumber = 2;

		// Token: 0x0400A4C0 RID: 42176
		private int nodeId_;

		// Token: 0x0400A4C1 RID: 42177
		public const int StatusFieldNumber = 3;

		// Token: 0x0400A4C2 RID: 42178
		private NodeStatus status_;
	}
}
