using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001312 RID: 4882
	[NetMessage(EMessageId.SubmitNodeRequest)]
	public sealed class SubmitNodeRequest : IMessage<SubmitNodeRequest>, IMessage, IEquatable<SubmitNodeRequest>, IDeepCloneable<SubmitNodeRequest>, IBufferMessage
	{
		// Token: 0x0601A07C RID: 106620 RVA: 0x003CB3D9 File Offset: 0x003C95D9
		[NullableContext(1)]
		public static SubmitNodeRequest Create()
		{
			return new SubmitNodeRequest();
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x0601A07D RID: 106621 RVA: 0x003CB3E0 File Offset: 0x003C95E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x0601A07E RID: 106622 RVA: 0x003CB3E3 File Offset: 0x003C95E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitNodeRequest.Descriptor;
			}
		}

		// Token: 0x0601A07F RID: 106623 RVA: 0x003CB3EA File Offset: 0x003C95EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest()
		{
		}

		// Token: 0x0601A080 RID: 106624 RVA: 0x003CB3F2 File Offset: 0x003C95F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest(SubmitNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A081 RID: 106625 RVA: 0x003CB42F File Offset: 0x003C962F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeRequest Clone()
		{
			return new SubmitNodeRequest(this);
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x0601A082 RID: 106626 RVA: 0x003CB437 File Offset: 0x003C9637
		// (set) Token: 0x0601A083 RID: 106627 RVA: 0x003CB43F File Offset: 0x003C963F
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

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x0601A084 RID: 106628 RVA: 0x003CB448 File Offset: 0x003C9648
		// (set) Token: 0x0601A085 RID: 106629 RVA: 0x003CB450 File Offset: 0x003C9650
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

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x0601A086 RID: 106630 RVA: 0x003CB459 File Offset: 0x003C9659
		// (set) Token: 0x0601A087 RID: 106631 RVA: 0x003CB461 File Offset: 0x003C9661
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

		// Token: 0x0601A088 RID: 106632 RVA: 0x003CB46A File Offset: 0x003C966A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitNodeRequest);
		}

		// Token: 0x0601A089 RID: 106633 RVA: 0x003CB478 File Offset: 0x003C9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A08A RID: 106634 RVA: 0x003CB4D4 File Offset: 0x003C96D4
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

		// Token: 0x0601A08B RID: 106635 RVA: 0x003CB545 File Offset: 0x003C9745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A08C RID: 106636 RVA: 0x003CB552 File Offset: 0x003C9752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A08D RID: 106637 RVA: 0x003CB55C File Offset: 0x003C975C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A08E RID: 106638 RVA: 0x003CB5D4 File Offset: 0x003C97D4
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

		// Token: 0x0601A08F RID: 106639 RVA: 0x003CB644 File Offset: 0x003C9844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitNodeRequest other)
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

		// Token: 0x0601A090 RID: 106640 RVA: 0x003CB6A8 File Offset: 0x003C98A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A091 RID: 106641 RVA: 0x003CB6B4 File Offset: 0x003C98B4
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 96U)
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

		// Token: 0x04009945 RID: 39237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009946 RID: 39238
		public const int TreeOwnerIdFieldNumber = 3;

		// Token: 0x04009947 RID: 39239
		private int treeOwnerId_;

		// Token: 0x04009948 RID: 39240
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04009949 RID: 39241
		private long treeIncId_;

		// Token: 0x0400994A RID: 39242
		public const int NodeIdFieldNumber = 4;

		// Token: 0x0400994B RID: 39243
		private int nodeId_;
	}
}
