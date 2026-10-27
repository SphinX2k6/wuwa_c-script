using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000195 RID: 405
	public sealed class BehaviorTreeCtxPb : IMessage<BehaviorTreeCtxPb>, IMessage, IEquatable<BehaviorTreeCtxPb>, IDeepCloneable<BehaviorTreeCtxPb>, IBufferMessage
	{
		// Token: 0x06003025 RID: 12325 RVA: 0x0007B090 File Offset: 0x00079290
		[NullableContext(1)]
		public static BehaviorTreeCtxPb Create()
		{
			return new BehaviorTreeCtxPb();
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x0007B097 File Offset: 0x00079297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x0007B09A File Offset: 0x0007929A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BehaviorTreeCtxPb.Descriptor;
			}
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0007B0A1 File Offset: 0x000792A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb()
		{
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x0007B0AC File Offset: 0x000792AC
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

		// Token: 0x0600302A RID: 12330 RVA: 0x0007B100 File Offset: 0x00079300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb Clone()
		{
			return new BehaviorTreeCtxPb(this);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x0007B108 File Offset: 0x00079308
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x0007B110 File Offset: 0x00079310
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

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x0007B119 File Offset: 0x00079319
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x0007B121 File Offset: 0x00079321
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

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x0007B12A File Offset: 0x0007932A
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x0007B132 File Offset: 0x00079332
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

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x0007B13B File Offset: 0x0007933B
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x0007B143 File Offset: 0x00079343
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

		// Token: 0x06003033 RID: 12339 RVA: 0x0007B14C File Offset: 0x0007934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BehaviorTreeCtxPb);
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0007B15C File Offset: 0x0007935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BehaviorTreeCtxPb other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.BtType == other.BtType && this.BtId == other.BtId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x0007B1C8 File Offset: 0x000793C8
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

		// Token: 0x06003036 RID: 12342 RVA: 0x0007B252 File Offset: 0x00079452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0007B25F File Offset: 0x0007945F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0007B268 File Offset: 0x00079468
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

		// Token: 0x06003039 RID: 12345 RVA: 0x0007B2F8 File Offset: 0x000794F8
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

		// Token: 0x0600303A RID: 12346 RVA: 0x0007B380 File Offset: 0x00079580
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

		// Token: 0x0600303B RID: 12347 RVA: 0x0007B3F8 File Offset: 0x000795F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0007B404 File Offset: 0x00079604
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

		// Token: 0x040028DF RID: 10463
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E0 RID: 10464
		public const int IncIdFieldNumber = 1;

		// Token: 0x040028E1 RID: 10465
		private long incId_;

		// Token: 0x040028E2 RID: 10466
		public const int BtTypeFieldNumber = 2;

		// Token: 0x040028E3 RID: 10467
		private int btType_;

		// Token: 0x040028E4 RID: 10468
		public const int BtIdFieldNumber = 3;

		// Token: 0x040028E5 RID: 10469
		private int btId_;

		// Token: 0x040028E6 RID: 10470
		public const int NodeIdFieldNumber = 4;

		// Token: 0x040028E7 RID: 10471
		private int nodeId_;
	}
}
