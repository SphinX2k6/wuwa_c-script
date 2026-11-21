using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6A RID: 2922
	[NetMessage(EMessageId.NpcTraceFailedRequest)]
	public sealed class NpcTraceFailedRequest : IMessage<NpcTraceFailedRequest>, IMessage, IEquatable<NpcTraceFailedRequest>, IDeepCloneable<NpcTraceFailedRequest>, IBufferMessage
	{
		// Token: 0x0600FDA6 RID: 64934 RVA: 0x0025069E File Offset: 0x0024E89E
		[NullableContext(1)]
		public static NpcTraceFailedRequest Create()
		{
			return new NpcTraceFailedRequest();
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600FDA7 RID: 64935 RVA: 0x002506A5 File Offset: 0x0024E8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600FDA8 RID: 64936 RVA: 0x002506A8 File Offset: 0x0024E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcTraceFailedRequest.Descriptor;
			}
		}

		// Token: 0x0600FDA9 RID: 64937 RVA: 0x002506AF File Offset: 0x0024E8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest()
		{
		}

		// Token: 0x0600FDAA RID: 64938 RVA: 0x002506B7 File Offset: 0x0024E8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest(NpcTraceFailedRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDAB RID: 64939 RVA: 0x002506F4 File Offset: 0x0024E8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTraceFailedRequest Clone()
		{
			return new NpcTraceFailedRequest(this);
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600FDAC RID: 64940 RVA: 0x002506FC File Offset: 0x0024E8FC
		// (set) Token: 0x0600FDAD RID: 64941 RVA: 0x00250704 File Offset: 0x0024E904
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

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600FDAE RID: 64942 RVA: 0x0025070D File Offset: 0x0024E90D
		// (set) Token: 0x0600FDAF RID: 64943 RVA: 0x00250715 File Offset: 0x0024E915
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

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600FDB0 RID: 64944 RVA: 0x0025071E File Offset: 0x0024E91E
		// (set) Token: 0x0600FDB1 RID: 64945 RVA: 0x00250726 File Offset: 0x0024E926
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

		// Token: 0x0600FDB2 RID: 64946 RVA: 0x0025072F File Offset: 0x0024E92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcTraceFailedRequest);
		}

		// Token: 0x0600FDB3 RID: 64947 RVA: 0x00250740 File Offset: 0x0024E940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcTraceFailedRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDB4 RID: 64948 RVA: 0x0025079C File Offset: 0x0024E99C
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

		// Token: 0x0600FDB5 RID: 64949 RVA: 0x0025080D File Offset: 0x0024EA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDB6 RID: 64950 RVA: 0x0025081A File Offset: 0x0024EA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDB7 RID: 64951 RVA: 0x00250824 File Offset: 0x0024EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDB8 RID: 64952 RVA: 0x0025089C File Offset: 0x0024EA9C
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

		// Token: 0x0600FDB9 RID: 64953 RVA: 0x0025090C File Offset: 0x0024EB0C
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

		// Token: 0x0600FDBA RID: 64954 RVA: 0x00250970 File Offset: 0x0024EB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDBB RID: 64955 RVA: 0x0025097C File Offset: 0x0024EB7C
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
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
		}

		// Token: 0x04006590 RID: 26000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006591 RID: 26001
		public const int TreeOwnerIdFieldNumber = 14;

		// Token: 0x04006592 RID: 26002
		private int treeOwnerId_;

		// Token: 0x04006593 RID: 26003
		public const int TreeIncIdFieldNumber = 4;

		// Token: 0x04006594 RID: 26004
		private long treeIncId_;

		// Token: 0x04006595 RID: 26005
		public const int NodeIdFieldNumber = 11;

		// Token: 0x04006596 RID: 26006
		private int nodeId_;
	}
}
