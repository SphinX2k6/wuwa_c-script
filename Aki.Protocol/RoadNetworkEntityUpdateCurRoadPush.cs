using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F78 RID: 3960
	[NetMessage(EMessageId.RoadNetworkEntityUpdateCurRoadPush)]
	public sealed class RoadNetworkEntityUpdateCurRoadPush : IMessage<RoadNetworkEntityUpdateCurRoadPush>, IMessage, IEquatable<RoadNetworkEntityUpdateCurRoadPush>, IDeepCloneable<RoadNetworkEntityUpdateCurRoadPush>, IBufferMessage
	{
		// Token: 0x060152BE RID: 86718 RVA: 0x00311CF7 File Offset: 0x0030FEF7
		[NullableContext(1)]
		public static RoadNetworkEntityUpdateCurRoadPush Create()
		{
			return new RoadNetworkEntityUpdateCurRoadPush();
		}

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x060152BF RID: 86719 RVA: 0x00311CFE File Offset: 0x0030FEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x060152C0 RID: 86720 RVA: 0x00311D01 File Offset: 0x0030FF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkEntityUpdateCurRoadPush.Descriptor;
			}
		}

		// Token: 0x060152C1 RID: 86721 RVA: 0x00311D08 File Offset: 0x0030FF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush()
		{
		}

		// Token: 0x060152C2 RID: 86722 RVA: 0x00311D10 File Offset: 0x0030FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush(RoadNetworkEntityUpdateCurRoadPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.curRoadId_ = other.curRoadId_;
			this.curRoadIndex_ = other.curRoadIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152C3 RID: 86723 RVA: 0x00311D4D File Offset: 0x0030FF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityUpdateCurRoadPush Clone()
		{
			return new RoadNetworkEntityUpdateCurRoadPush(this);
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x060152C4 RID: 86724 RVA: 0x00311D55 File Offset: 0x0030FF55
		// (set) Token: 0x060152C5 RID: 86725 RVA: 0x00311D5D File Offset: 0x0030FF5D
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

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x060152C6 RID: 86726 RVA: 0x00311D66 File Offset: 0x0030FF66
		// (set) Token: 0x060152C7 RID: 86727 RVA: 0x00311D6E File Offset: 0x0030FF6E
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

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x060152C8 RID: 86728 RVA: 0x00311D77 File Offset: 0x0030FF77
		// (set) Token: 0x060152C9 RID: 86729 RVA: 0x00311D7F File Offset: 0x0030FF7F
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

		// Token: 0x060152CA RID: 86730 RVA: 0x00311D88 File Offset: 0x0030FF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkEntityUpdateCurRoadPush);
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x00311D98 File Offset: 0x0030FF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkEntityUpdateCurRoadPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CurRoadId == other.CurRoadId && this.CurRoadIndex == other.CurRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152CC RID: 86732 RVA: 0x00311DF4 File Offset: 0x0030FFF4
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

		// Token: 0x060152CD RID: 86733 RVA: 0x00311E65 File Offset: 0x00310065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152CE RID: 86734 RVA: 0x00311E72 File Offset: 0x00310072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152CF RID: 86735 RVA: 0x00311E7C File Offset: 0x0031007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.CurRoadId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurRoadId);
			}
			if (this.CurRoadIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurRoadIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152D0 RID: 86736 RVA: 0x00311EF0 File Offset: 0x003100F0
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

		// Token: 0x060152D1 RID: 86737 RVA: 0x00311F60 File Offset: 0x00310160
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

		// Token: 0x060152D2 RID: 86738 RVA: 0x00311FC4 File Offset: 0x003101C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152D3 RID: 86739 RVA: 0x00311FD0 File Offset: 0x003101D0
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
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007F57 RID: 32599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F58 RID: 32600
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04007F59 RID: 32601
		private long entityId_;

		// Token: 0x04007F5A RID: 32602
		public const int CurRoadIdFieldNumber = 11;

		// Token: 0x04007F5B RID: 32603
		private int curRoadId_;

		// Token: 0x04007F5C RID: 32604
		public const int CurRoadIndexFieldNumber = 14;

		// Token: 0x04007F5D RID: 32605
		private int curRoadIndex_;
	}
}
