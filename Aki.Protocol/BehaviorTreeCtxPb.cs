using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000199 RID: 409
	public sealed class BehaviorTreeCtxPb : IMessage<BehaviorTreeCtxPb>, IMessage, IEquatable<BehaviorTreeCtxPb>, IDeepCloneable<BehaviorTreeCtxPb>, IBufferMessage
	{
		// Token: 0x060030B2 RID: 12466 RVA: 0x0007C7FE File Offset: 0x0007A9FE
		[NullableContext(1)]
		public static BehaviorTreeCtxPb Create()
		{
			return new BehaviorTreeCtxPb();
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x0007C805 File Offset: 0x0007AA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x0007C808 File Offset: 0x0007AA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeCtxPb.Descriptor;
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0007C80F File Offset: 0x0007AA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb()
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0007C818 File Offset: 0x0007AA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb(BehaviorTreeCtxPb other) : this()
		{
			this.incId_ = other.incId_;
			this.btType_ = other.btType_;
			this.btId_ = other.btId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0007C86C File Offset: 0x0007AA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb Clone()
		{
			return new BehaviorTreeCtxPb(this);
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x0007C874 File Offset: 0x0007AA74
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x0007C87C File Offset: 0x0007AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x0007C885 File Offset: 0x0007AA85
		// (set) Token: 0x060030BB RID: 12475 RVA: 0x0007C88D File Offset: 0x0007AA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BtType
		{
			get
			{
				return this.btType_;
			}
			set
			{
				this.btType_ = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x0007C896 File Offset: 0x0007AA96
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x0007C89E File Offset: 0x0007AA9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BtId
		{
			get
			{
				return this.btId_;
			}
			set
			{
				this.btId_ = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x0007C8A7 File Offset: 0x0007AAA7
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x0007C8AF File Offset: 0x0007AAAF
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

		// Token: 0x060030C0 RID: 12480 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeCtxPb);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeCtxPb other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.BtType == other.BtType && this.BtId == other.BtId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0007C934 File Offset: 0x0007AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.BtType != 0)
			{
				num ^= this.BtType.GetHashCode();
			}
			if (this.BtId != 0)
			{
				num ^= this.BtId.GetHashCode();
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

		// Token: 0x060030C3 RID: 12483 RVA: 0x0007C9BE File Offset: 0x0007ABBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0007C9CB File Offset: 0x0007ABCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0007C9D4 File Offset: 0x0007ABD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.IncId);
			}
			if (this.BtType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BtType);
			}
			if (this.BtId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BtId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0007CA64 File Offset: 0x0007AC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this.BtType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BtType);
			}
			if (this.BtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BtId);
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

		// Token: 0x060030C7 RID: 12487 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BehaviorTreeCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			if (other.BtType != 0)
			{
				this.BtType = other.BtType;
			}
			if (other.BtId != 0)
			{
				this.BtId = other.BtId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0007CB64 File Offset: 0x0007AD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0007CB70 File Offset: 0x0007AD70
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IncId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.BtType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BtId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400295A RID: 10586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400295B RID: 10587
		public const int IncIdFieldNumber = 1;

		// Token: 0x0400295C RID: 10588
		private long incId_;

		// Token: 0x0400295D RID: 10589
		public const int BtTypeFieldNumber = 2;

		// Token: 0x0400295E RID: 10590
		private int btType_;

		// Token: 0x0400295F RID: 10591
		public const int BtIdFieldNumber = 3;

		// Token: 0x04002960 RID: 10592
		private int btId_;

		// Token: 0x04002961 RID: 10593
		public const int NodeIdFieldNumber = 4;

		// Token: 0x04002962 RID: 10594
		private int nodeId_;
	}
}
