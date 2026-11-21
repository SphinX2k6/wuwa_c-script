using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130F RID: 4879
	[NetMessage(EMessageId.SubmitAwakeAndLoadEntityNodeRequest)]
	public sealed class SubmitAwakeAndLoadEntityNodeRequest : IMessage<SubmitAwakeAndLoadEntityNodeRequest>, IMessage, IEquatable<SubmitAwakeAndLoadEntityNodeRequest>, IDeepCloneable<SubmitAwakeAndLoadEntityNodeRequest>, IBufferMessage
	{
		// Token: 0x0601A042 RID: 106562 RVA: 0x003CACCF File Offset: 0x003C8ECF
		[NullableContext(1)]
		public static SubmitAwakeAndLoadEntityNodeRequest Create()
		{
			return new SubmitAwakeAndLoadEntityNodeRequest();
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x0601A043 RID: 106563 RVA: 0x003CACD6 File Offset: 0x003C8ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x0601A044 RID: 106564 RVA: 0x003CACD9 File Offset: 0x003C8ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitAwakeAndLoadEntityNodeRequest.Descriptor;
			}
		}

		// Token: 0x0601A045 RID: 106565 RVA: 0x003CACE0 File Offset: 0x003C8EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest()
		{
		}

		// Token: 0x0601A046 RID: 106566 RVA: 0x003CACE8 File Offset: 0x003C8EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest(SubmitAwakeAndLoadEntityNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x003CAD25 File Offset: 0x003C8F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest Clone()
		{
			return new SubmitAwakeAndLoadEntityNodeRequest(this);
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x0601A048 RID: 106568 RVA: 0x003CAD2D File Offset: 0x003C8F2D
		// (set) Token: 0x0601A049 RID: 106569 RVA: 0x003CAD35 File Offset: 0x003C8F35
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

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x0601A04A RID: 106570 RVA: 0x003CAD3E File Offset: 0x003C8F3E
		// (set) Token: 0x0601A04B RID: 106571 RVA: 0x003CAD46 File Offset: 0x003C8F46
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

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x0601A04C RID: 106572 RVA: 0x003CAD4F File Offset: 0x003C8F4F
		// (set) Token: 0x0601A04D RID: 106573 RVA: 0x003CAD57 File Offset: 0x003C8F57
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

		// Token: 0x0601A04E RID: 106574 RVA: 0x003CAD60 File Offset: 0x003C8F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitAwakeAndLoadEntityNodeRequest);
		}

		// Token: 0x0601A04F RID: 106575 RVA: 0x003CAD70 File Offset: 0x003C8F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitAwakeAndLoadEntityNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A050 RID: 106576 RVA: 0x003CADCC File Offset: 0x003C8FCC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A051 RID: 106577 RVA: 0x003CAE3D File Offset: 0x003C903D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A052 RID: 106578 RVA: 0x003CAE4A File Offset: 0x003C904A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A053 RID: 106579 RVA: 0x003CAE54 File Offset: 0x003C9054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.NodeId);
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

		// Token: 0x0601A054 RID: 106580 RVA: 0x003CAECC File Offset: 0x003C90CC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A055 RID: 106581 RVA: 0x003CAF3C File Offset: 0x003C913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitAwakeAndLoadEntityNodeRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A056 RID: 106582 RVA: 0x003CAFA0 File Offset: 0x003C91A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A057 RID: 106583 RVA: 0x003CAFAC File Offset: 0x003C91AC
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeIncId = input.ReadInt64();
						}
					}
					else
					{
						this.NodeId = input.ReadInt32();
					}
				}
				else
				{
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009937 RID: 39223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009938 RID: 39224
		public const int TreeOwnerIdFieldNumber = 2;

		// Token: 0x04009939 RID: 39225
		private int treeOwnerId_;

		// Token: 0x0400993A RID: 39226
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x0400993B RID: 39227
		private long treeIncId_;

		// Token: 0x0400993C RID: 39228
		public const int NodeIdFieldNumber = 9;

		// Token: 0x0400993D RID: 39229
		private int nodeId_;
	}
}
