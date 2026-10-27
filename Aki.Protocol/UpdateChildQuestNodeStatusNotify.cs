using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001491 RID: 5265
	[NetMessage(EMessageId.UpdateChildQuestNodeStatusNotify)]
	public sealed class UpdateChildQuestNodeStatusNotify : IMessage<UpdateChildQuestNodeStatusNotify>, IMessage, IEquatable<UpdateChildQuestNodeStatusNotify>, IDeepCloneable<UpdateChildQuestNodeStatusNotify>, IBufferMessage
	{
		// Token: 0x0601BDAF RID: 114095 RVA: 0x004070ED File Offset: 0x004052ED
		[NullableContext(1)]
		public static UpdateChildQuestNodeStatusNotify Create()
		{
			return new UpdateChildQuestNodeStatusNotify();
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x0601BDB0 RID: 114096 RVA: 0x004070F4 File Offset: 0x004052F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x0601BDB1 RID: 114097 RVA: 0x004070F7 File Offset: 0x004052F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateChildQuestNodeStatusNotify.Descriptor;
			}
		}

		// Token: 0x0601BDB2 RID: 114098 RVA: 0x004070FE File Offset: 0x004052FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateChildQuestNodeStatusNotify()
		{
		}

		// Token: 0x0601BDB3 RID: 114099 RVA: 0x00407108 File Offset: 0x00405308
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

		// Token: 0x0601BDB4 RID: 114100 RVA: 0x0040715C File Offset: 0x0040535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateChildQuestNodeStatusNotify Clone()
		{
			return new UpdateChildQuestNodeStatusNotify(this);
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x0601BDB5 RID: 114101 RVA: 0x00407164 File Offset: 0x00405364
		// (set) Token: 0x0601BDB6 RID: 114102 RVA: 0x0040716C File Offset: 0x0040536C
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

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x0601BDB7 RID: 114103 RVA: 0x00407175 File Offset: 0x00405375
		// (set) Token: 0x0601BDB8 RID: 114104 RVA: 0x0040717D File Offset: 0x0040537D
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

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x0601BDB9 RID: 114105 RVA: 0x00407186 File Offset: 0x00405386
		// (set) Token: 0x0601BDBA RID: 114106 RVA: 0x0040718E File Offset: 0x0040538E
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

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x0601BDBB RID: 114107 RVA: 0x00407197 File Offset: 0x00405397
		// (set) Token: 0x0601BDBC RID: 114108 RVA: 0x0040719F File Offset: 0x0040539F
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

		// Token: 0x0601BDBD RID: 114109 RVA: 0x004071A8 File Offset: 0x004053A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateChildQuestNodeStatusNotify);
		}

		// Token: 0x0601BDBE RID: 114110 RVA: 0x004071B8 File Offset: 0x004053B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateChildQuestNodeStatusNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDBF RID: 114111 RVA: 0x00407224 File Offset: 0x00405424
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

		// Token: 0x0601BDC0 RID: 114112 RVA: 0x004072B4 File Offset: 0x004054B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDC1 RID: 114113 RVA: 0x004072C1 File Offset: 0x004054C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDC2 RID: 114114 RVA: 0x004072CC File Offset: 0x004054CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Status);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDC3 RID: 114115 RVA: 0x00407360 File Offset: 0x00405560
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

		// Token: 0x0601BDC4 RID: 114116 RVA: 0x004073E8 File Offset: 0x004055E8
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

		// Token: 0x0601BDC5 RID: 114117 RVA: 0x00407460 File Offset: 0x00405660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDC6 RID: 114118 RVA: 0x0040746C File Offset: 0x0040566C
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Status = (ChildQuestNodeStatus)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A02F RID: 41007
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A030 RID: 41008
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x0400A031 RID: 41009
		private int treeOwnerId_;

		// Token: 0x0400A032 RID: 41010
		public const int TreeIncIdFieldNumber = 7;

		// Token: 0x0400A033 RID: 41011
		private long treeIncId_;

		// Token: 0x0400A034 RID: 41012
		public const int NodeIdFieldNumber = 3;

		// Token: 0x0400A035 RID: 41013
		private int nodeId_;

		// Token: 0x0400A036 RID: 41014
		public const int StatusFieldNumber = 10;

		// Token: 0x0400A037 RID: 41015
		private ChildQuestNodeStatus status_;
	}
}
