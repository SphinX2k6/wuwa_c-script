using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149E RID: 5278
	[NetMessage(EMessageId.UpdateNodeStatusNotify)]
	public sealed class UpdateNodeStatusNotify : IMessage<UpdateNodeStatusNotify>, IMessage, IEquatable<UpdateNodeStatusNotify>, IDeepCloneable<UpdateNodeStatusNotify>, IBufferMessage
	{
		// Token: 0x0601BEAB RID: 114347 RVA: 0x0040910F File Offset: 0x0040730F
		[NullableContext(1)]
		public static UpdateNodeStatusNotify Create()
		{
			return new UpdateNodeStatusNotify();
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x0601BEAC RID: 114348 RVA: 0x00409116 File Offset: 0x00407316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x0601BEAD RID: 114349 RVA: 0x00409119 File Offset: 0x00407319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateNodeStatusNotify.Descriptor;
			}
		}

		// Token: 0x0601BEAE RID: 114350 RVA: 0x00409120 File Offset: 0x00407320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeStatusNotify()
		{
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x00409128 File Offset: 0x00407328
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

		// Token: 0x0601BEB0 RID: 114352 RVA: 0x0040917C File Offset: 0x0040737C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeStatusNotify Clone()
		{
			return new UpdateNodeStatusNotify(this);
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x0601BEB1 RID: 114353 RVA: 0x00409184 File Offset: 0x00407384
		// (set) Token: 0x0601BEB2 RID: 114354 RVA: 0x0040918C File Offset: 0x0040738C
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

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x0601BEB3 RID: 114355 RVA: 0x00409195 File Offset: 0x00407395
		// (set) Token: 0x0601BEB4 RID: 114356 RVA: 0x0040919D File Offset: 0x0040739D
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

		// Token: 0x17005E19 RID: 24089
		// (get) Token: 0x0601BEB5 RID: 114357 RVA: 0x004091A6 File Offset: 0x004073A6
		// (set) Token: 0x0601BEB6 RID: 114358 RVA: 0x004091AE File Offset: 0x004073AE
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

		// Token: 0x17005E1A RID: 24090
		// (get) Token: 0x0601BEB7 RID: 114359 RVA: 0x004091B7 File Offset: 0x004073B7
		// (set) Token: 0x0601BEB8 RID: 114360 RVA: 0x004091BF File Offset: 0x004073BF
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

		// Token: 0x0601BEB9 RID: 114361 RVA: 0x004091C8 File Offset: 0x004073C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateNodeStatusNotify);
		}

		// Token: 0x0601BEBA RID: 114362 RVA: 0x004091D8 File Offset: 0x004073D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateNodeStatusNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x00409244 File Offset: 0x00407444
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

		// Token: 0x0601BEBC RID: 114364 RVA: 0x004092D4 File Offset: 0x004074D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEBD RID: 114365 RVA: 0x004092E1 File Offset: 0x004074E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEBE RID: 114366 RVA: 0x004092EC File Offset: 0x004074EC
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
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Status);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEBF RID: 114367 RVA: 0x00409380 File Offset: 0x00407580
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

		// Token: 0x0601BEC0 RID: 114368 RVA: 0x00409408 File Offset: 0x00407608
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

		// Token: 0x0601BEC1 RID: 114369 RVA: 0x00409480 File Offset: 0x00407680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEC2 RID: 114370 RVA: 0x0040948C File Offset: 0x0040768C
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Status = (NodeStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A06F RID: 41071
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A070 RID: 41072
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x0400A071 RID: 41073
		private int treeOwnerId_;

		// Token: 0x0400A072 RID: 41074
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x0400A073 RID: 41075
		private long treeIncId_;

		// Token: 0x0400A074 RID: 41076
		public const int NodeIdFieldNumber = 2;

		// Token: 0x0400A075 RID: 41077
		private int nodeId_;

		// Token: 0x0400A076 RID: 41078
		public const int StatusFieldNumber = 6;

		// Token: 0x0400A077 RID: 41079
		private NodeStatus status_;
	}
}
