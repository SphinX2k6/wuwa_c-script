using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011F RID: 287
	[NetMessage(EMessageId.AtomicProcessTeleportRequest)]
	public sealed class AtomicProcessTeleportRequest : IMessage<AtomicProcessTeleportRequest>, IMessage, IEquatable<AtomicProcessTeleportRequest>, IDeepCloneable<AtomicProcessTeleportRequest>, IBufferMessage
	{
		// Token: 0x06002702 RID: 9986 RVA: 0x00067981 File Offset: 0x00065B81
		[NullableContext(1)]
		public static AtomicProcessTeleportRequest Create()
		{
			return new AtomicProcessTeleportRequest();
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x00067988 File Offset: 0x00065B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x0006798B File Offset: 0x00065B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00067992 File Offset: 0x00065B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest()
		{
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x0006799C File Offset: 0x00065B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest(AtomicProcessTeleportRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.splineEntityId_ = other.splineEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000679F0 File Offset: 0x00065BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportRequest Clone()
		{
			return new AtomicProcessTeleportRequest(this);
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000679F8 File Offset: 0x00065BF8
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x00067A00 File Offset: 0x00065C00
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x00067A09 File Offset: 0x00065C09
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x00067A11 File Offset: 0x00065C11
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x00067A1A File Offset: 0x00065C1A
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x00067A22 File Offset: 0x00065C22
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x00067A2B File Offset: 0x00065C2B
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x00067A33 File Offset: 0x00065C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00067A3C File Offset: 0x00065C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessTeleportRequest);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00067A4C File Offset: 0x00065C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessTeleportRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.SplineEntityId == other.SplineEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00067AB8 File Offset: 0x00065CB8
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
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00067B42 File Offset: 0x00065D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00067B4F File Offset: 0x00065D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00067B58 File Offset: 0x00065D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00067BE8 File Offset: 0x00065DE8
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
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00067C70 File Offset: 0x00065E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessTeleportRequest other)
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
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00067CE8 File Offset: 0x00065EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00067CF4 File Offset: 0x00065EF4
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.SplineEntityId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002692 RID: 9874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002693 RID: 9875
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x04002694 RID: 9876
		private int treeOwnerId_;

		// Token: 0x04002695 RID: 9877
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04002696 RID: 9878
		private long treeIncId_;

		// Token: 0x04002697 RID: 9879
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04002698 RID: 9880
		private int nodeId_;

		// Token: 0x04002699 RID: 9881
		public const int SplineEntityIdFieldNumber = 12;

		// Token: 0x0400269A RID: 9882
		private int splineEntityId_;
	}
}
