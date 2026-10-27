using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A0 RID: 4768
	[NetMessage(EMessageId.SubmitAwakeAndLoadEntityNodeRequest)]
	public sealed class SubmitAwakeAndLoadEntityNodeRequest : IMessage<SubmitAwakeAndLoadEntityNodeRequest>, IMessage, IEquatable<SubmitAwakeAndLoadEntityNodeRequest>, IDeepCloneable<SubmitAwakeAndLoadEntityNodeRequest>, IBufferMessage
	{
		// Token: 0x0601960C RID: 103948 RVA: 0x003B059F File Offset: 0x003AE79F
		[NullableContext(1)]
		public static SubmitAwakeAndLoadEntityNodeRequest Create()
		{
			return new SubmitAwakeAndLoadEntityNodeRequest();
		}

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x0601960D RID: 103949 RVA: 0x003B05A6 File Offset: 0x003AE7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x0601960E RID: 103950 RVA: 0x003B05A9 File Offset: 0x003AE7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitAwakeAndLoadEntityNodeRequest.Descriptor;
			}
		}

		// Token: 0x0601960F RID: 103951 RVA: 0x003B05B0 File Offset: 0x003AE7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest()
		{
		}

		// Token: 0x06019610 RID: 103952 RVA: 0x003B05B8 File Offset: 0x003AE7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest(SubmitAwakeAndLoadEntityNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019611 RID: 103953 RVA: 0x003B05F5 File Offset: 0x003AE7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitAwakeAndLoadEntityNodeRequest Clone()
		{
			return new SubmitAwakeAndLoadEntityNodeRequest(this);
		}

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x06019612 RID: 103954 RVA: 0x003B05FD File Offset: 0x003AE7FD
		// (set) Token: 0x06019613 RID: 103955 RVA: 0x003B0605 File Offset: 0x003AE805
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

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x06019614 RID: 103956 RVA: 0x003B060E File Offset: 0x003AE80E
		// (set) Token: 0x06019615 RID: 103957 RVA: 0x003B0616 File Offset: 0x003AE816
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

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x06019616 RID: 103958 RVA: 0x003B061F File Offset: 0x003AE81F
		// (set) Token: 0x06019617 RID: 103959 RVA: 0x003B0627 File Offset: 0x003AE827
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

		// Token: 0x06019618 RID: 103960 RVA: 0x003B0630 File Offset: 0x003AE830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitAwakeAndLoadEntityNodeRequest);
		}

		// Token: 0x06019619 RID: 103961 RVA: 0x003B0640 File Offset: 0x003AE840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitAwakeAndLoadEntityNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601961A RID: 103962 RVA: 0x003B069C File Offset: 0x003AE89C
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

		// Token: 0x0601961B RID: 103963 RVA: 0x003B070D File Offset: 0x003AE90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601961C RID: 103964 RVA: 0x003B071A File Offset: 0x003AE91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601961D RID: 103965 RVA: 0x003B0724 File Offset: 0x003AE924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601961E RID: 103966 RVA: 0x003B0798 File Offset: 0x003AE998
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

		// Token: 0x0601961F RID: 103967 RVA: 0x003B0808 File Offset: 0x003AEA08
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

		// Token: 0x06019620 RID: 103968 RVA: 0x003B086C File Offset: 0x003AEA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019621 RID: 103969 RVA: 0x003B0878 File Offset: 0x003AEA78
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NodeId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400950D RID: 38157
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400950E RID: 38158
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x0400950F RID: 38159
		private int treeOwnerId_;

		// Token: 0x04009510 RID: 38160
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x04009511 RID: 38161
		private long treeIncId_;

		// Token: 0x04009512 RID: 38162
		public const int NodeIdFieldNumber = 3;

		// Token: 0x04009513 RID: 38163
		private int nodeId_;
	}
}
