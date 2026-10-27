using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7A RID: 2938
	[NetMessage(EMessageId.NpcTraceFailedRequest)]
	public sealed class NpcTraceFailedRequest : IMessage<NpcTraceFailedRequest>, IMessage, IEquatable<NpcTraceFailedRequest>, IDeepCloneable<NpcTraceFailedRequest>, IBufferMessage
	{
		// Token: 0x0600FEAA RID: 65194 RVA: 0x0025256E File Offset: 0x0025076E
		[NullableContext(1)]
		public static NpcTraceFailedRequest Create()
		{
			return new NpcTraceFailedRequest();
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600FEAB RID: 65195 RVA: 0x00252575 File Offset: 0x00250775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600FEAC RID: 65196 RVA: 0x00252578 File Offset: 0x00250778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcTraceFailedRequest.Descriptor;
			}
		}

		// Token: 0x0600FEAD RID: 65197 RVA: 0x0025257F File Offset: 0x0025077F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest()
		{
		}

		// Token: 0x0600FEAE RID: 65198 RVA: 0x00252587 File Offset: 0x00250787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest(NpcTraceFailedRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FEAF RID: 65199 RVA: 0x002525C4 File Offset: 0x002507C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest Clone()
		{
			return new NpcTraceFailedRequest(this);
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600FEB0 RID: 65200 RVA: 0x002525CC File Offset: 0x002507CC
		// (set) Token: 0x0600FEB1 RID: 65201 RVA: 0x002525D4 File Offset: 0x002507D4
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

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600FEB2 RID: 65202 RVA: 0x002525DD File Offset: 0x002507DD
		// (set) Token: 0x0600FEB3 RID: 65203 RVA: 0x002525E5 File Offset: 0x002507E5
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

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600FEB4 RID: 65204 RVA: 0x002525EE File Offset: 0x002507EE
		// (set) Token: 0x0600FEB5 RID: 65205 RVA: 0x002525F6 File Offset: 0x002507F6
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

		// Token: 0x0600FEB6 RID: 65206 RVA: 0x002525FF File Offset: 0x002507FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcTraceFailedRequest);
		}

		// Token: 0x0600FEB7 RID: 65207 RVA: 0x00252610 File Offset: 0x00250810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcTraceFailedRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEB8 RID: 65208 RVA: 0x0025266C File Offset: 0x0025086C
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

		// Token: 0x0600FEB9 RID: 65209 RVA: 0x002526DD File Offset: 0x002508DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEBA RID: 65210 RVA: 0x002526EA File Offset: 0x002508EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEBB RID: 65211 RVA: 0x002526F4 File Offset: 0x002508F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
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

		// Token: 0x0600FEBC RID: 65212 RVA: 0x0025276C File Offset: 0x0025096C
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

		// Token: 0x0600FEBD RID: 65213 RVA: 0x002527DC File Offset: 0x002509DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcTraceFailedRequest other)
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

		// Token: 0x0600FEBE RID: 65214 RVA: 0x00252840 File Offset: 0x00250A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEBF RID: 65215 RVA: 0x0025284C File Offset: 0x00250A4C
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						if (num != 112U)
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

		// Token: 0x04006580 RID: 25984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006581 RID: 25985
		public const int TreeOwnerIdFieldNumber = 8;

		// Token: 0x04006582 RID: 25986
		private int treeOwnerId_;

		// Token: 0x04006583 RID: 25987
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04006584 RID: 25988
		private long treeIncId_;

		// Token: 0x04006585 RID: 25989
		public const int NodeIdFieldNumber = 14;

		// Token: 0x04006586 RID: 25990
		private int nodeId_;
	}
}
