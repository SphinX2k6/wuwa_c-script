using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F68 RID: 3944
	[NetMessage(EMessageId.RoadNetworkEntityUpdateCurRoadPush)]
	public sealed class RoadNetworkEntityUpdateCurRoadPush : IMessage<RoadNetworkEntityUpdateCurRoadPush>, IMessage, IEquatable<RoadNetworkEntityUpdateCurRoadPush>, IDeepCloneable<RoadNetworkEntityUpdateCurRoadPush>, IBufferMessage
	{
		// Token: 0x060151D9 RID: 86489 RVA: 0x0031064B File Offset: 0x0030E84B
		[NullableContext(1)]
		public static RoadNetworkEntityUpdateCurRoadPush Create()
		{
			return new RoadNetworkEntityUpdateCurRoadPush();
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x060151DA RID: 86490 RVA: 0x00310652 File Offset: 0x0030E852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x060151DB RID: 86491 RVA: 0x00310655 File Offset: 0x0030E855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkEntityUpdateCurRoadPush.Descriptor;
			}
		}

		// Token: 0x060151DC RID: 86492 RVA: 0x0031065C File Offset: 0x0030E85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush()
		{
		}

		// Token: 0x060151DD RID: 86493 RVA: 0x00310664 File Offset: 0x0030E864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush(RoadNetworkEntityUpdateCurRoadPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.curRoadId_ = other.curRoadId_;
			this.curRoadIndex_ = other.curRoadIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151DE RID: 86494 RVA: 0x003106A1 File Offset: 0x0030E8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush Clone()
		{
			return new RoadNetworkEntityUpdateCurRoadPush(this);
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x060151DF RID: 86495 RVA: 0x003106A9 File Offset: 0x0030E8A9
		// (set) Token: 0x060151E0 RID: 86496 RVA: 0x003106B1 File Offset: 0x0030E8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x060151E1 RID: 86497 RVA: 0x003106BA File Offset: 0x0030E8BA
		// (set) Token: 0x060151E2 RID: 86498 RVA: 0x003106C2 File Offset: 0x0030E8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoadId
		{
			get
			{
				return this.curRoadId_;
			}
			set
			{
				this.curRoadId_ = value;
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x060151E3 RID: 86499 RVA: 0x003106CB File Offset: 0x0030E8CB
		// (set) Token: 0x060151E4 RID: 86500 RVA: 0x003106D3 File Offset: 0x0030E8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoadIndex
		{
			get
			{
				return this.curRoadIndex_;
			}
			set
			{
				this.curRoadIndex_ = value;
			}
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x003106DC File Offset: 0x0030E8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkEntityUpdateCurRoadPush);
		}

		// Token: 0x060151E6 RID: 86502 RVA: 0x003106EC File Offset: 0x0030E8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkEntityUpdateCurRoadPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CurRoadId == other.CurRoadId && this.CurRoadIndex == other.CurRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151E7 RID: 86503 RVA: 0x00310748 File Offset: 0x0030E948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.CurRoadId != 0)
			{
				num ^= this.CurRoadId.GetHashCode();
			}
			if (this.CurRoadIndex != 0)
			{
				num ^= this.CurRoadIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060151E8 RID: 86504 RVA: 0x003107B9 File Offset: 0x0030E9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151E9 RID: 86505 RVA: 0x003107C6 File Offset: 0x0030E9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151EA RID: 86506 RVA: 0x003107D0 File Offset: 0x0030E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurRoadId);
			}
			if (this.CurRoadIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurRoadIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151EB RID: 86507 RVA: 0x00310844 File Offset: 0x0030EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.CurRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoadId);
			}
			if (this.CurRoadIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoadIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151EC RID: 86508 RVA: 0x003108B4 File Offset: 0x0030EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNetworkEntityUpdateCurRoadPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.CurRoadId != 0)
			{
				this.CurRoadId = other.CurRoadId;
			}
			if (other.CurRoadIndex != 0)
			{
				this.CurRoadIndex = other.CurRoadIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151ED RID: 86509 RVA: 0x00310918 File Offset: 0x0030EB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151EE RID: 86510 RVA: 0x00310924 File Offset: 0x0030EB24
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
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.CurRoadIndex = input.ReadInt32();
					}
				}
				else
				{
					this.CurRoadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F81 RID: 32641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F82 RID: 32642
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04007F83 RID: 32643
		private long entityId_;

		// Token: 0x04007F84 RID: 32644
		public const int CurRoadIdFieldNumber = 1;

		// Token: 0x04007F85 RID: 32645
		private int curRoadId_;

		// Token: 0x04007F86 RID: 32646
		public const int CurRoadIndexFieldNumber = 7;

		// Token: 0x04007F87 RID: 32647
		private int curRoadIndex_;
	}
}
