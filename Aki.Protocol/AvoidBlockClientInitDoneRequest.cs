using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000135 RID: 309
	[NetMessage(EMessageId.AvoidBlockClientInitDoneRequest)]
	public sealed class AvoidBlockClientInitDoneRequest : IMessage<AvoidBlockClientInitDoneRequest>, IMessage, IEquatable<AvoidBlockClientInitDoneRequest>, IDeepCloneable<AvoidBlockClientInitDoneRequest>, IBufferMessage
	{
		// Token: 0x060028C8 RID: 10440 RVA: 0x0006B72E File Offset: 0x0006992E
		[NullableContext(1)]
		public static AvoidBlockClientInitDoneRequest Create()
		{
			return new AvoidBlockClientInitDoneRequest();
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0006B735 File Offset: 0x00069935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0006B738 File Offset: 0x00069938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockClientInitDoneRequest.Descriptor;
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0006B73F File Offset: 0x0006993F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest()
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0006B747 File Offset: 0x00069947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest(AvoidBlockClientInitDoneRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0006B784 File Offset: 0x00069984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockClientInitDoneRequest Clone()
		{
			return new AvoidBlockClientInitDoneRequest(this);
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x0006B78C File Offset: 0x0006998C
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x0006B794 File Offset: 0x00069994
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x0006B79D File Offset: 0x0006999D
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x0006B7A5 File Offset: 0x000699A5
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0006B7AE File Offset: 0x000699AE
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0006B7B6 File Offset: 0x000699B6
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

		// Token: 0x060028D4 RID: 10452 RVA: 0x0006B7BF File Offset: 0x000699BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockClientInitDoneRequest);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0006B7D0 File Offset: 0x000699D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockClientInitDoneRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0006B82C File Offset: 0x00069A2C
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

		// Token: 0x060028D7 RID: 10455 RVA: 0x0006B89D File Offset: 0x00069A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0006B8AA File Offset: 0x00069AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0006B8B4 File Offset: 0x00069AB4
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
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0006B92C File Offset: 0x00069B2C
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

		// Token: 0x060028DB RID: 10459 RVA: 0x0006B99C File Offset: 0x00069B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockClientInitDoneRequest other)
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

		// Token: 0x060028DC RID: 10460 RVA: 0x0006BA00 File Offset: 0x00069C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0006BA0C File Offset: 0x00069C0C
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
						if (num != 88U)
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

		// Token: 0x0400270E RID: 9998
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400270F RID: 9999
		public const int TreeOwnerIdFieldNumber = 3;

		// Token: 0x04002710 RID: 10000
		private int treeOwnerId_;

		// Token: 0x04002711 RID: 10001
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x04002712 RID: 10002
		private long treeIncId_;

		// Token: 0x04002713 RID: 10003
		public const int NodeIdFieldNumber = 4;

		// Token: 0x04002714 RID: 10004
		private int nodeId_;
	}
}
