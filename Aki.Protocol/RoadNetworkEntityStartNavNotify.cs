using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F67 RID: 3943
	[NetMessage(EMessageId.RoadNetworkEntityStartNavNotify)]
	public sealed class RoadNetworkEntityStartNavNotify : IMessage<RoadNetworkEntityStartNavNotify>, IMessage, IEquatable<RoadNetworkEntityStartNavNotify>, IDeepCloneable<RoadNetworkEntityStartNavNotify>, IBufferMessage
	{
		// Token: 0x060151BF RID: 86463 RVA: 0x003101A8 File Offset: 0x0030E3A8
		[NullableContext(1)]
		public static RoadNetworkEntityStartNavNotify Create()
		{
			return new RoadNetworkEntityStartNavNotify();
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x060151C0 RID: 86464 RVA: 0x003101AF File Offset: 0x0030E3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x060151C1 RID: 86465 RVA: 0x003101B2 File Offset: 0x0030E3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkEntityStartNavNotify.Descriptor;
			}
		}

		// Token: 0x060151C2 RID: 86466 RVA: 0x003101B9 File Offset: 0x0030E3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityStartNavNotify()
		{
		}

		// Token: 0x060151C3 RID: 86467 RVA: 0x003101C4 File Offset: 0x0030E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityStartNavNotify(RoadNetworkEntityStartNavNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.destRoadId_ = other.destRoadId_;
			this.destIndex_ = other.destIndex_;
			this.startRoadId_ = other.startRoadId_;
			this.startRoadIndex_ = other.startRoadIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151C4 RID: 86468 RVA: 0x00310224 File Offset: 0x0030E424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityStartNavNotify Clone()
		{
			return new RoadNetworkEntityStartNavNotify(this);
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x060151C5 RID: 86469 RVA: 0x0031022C File Offset: 0x0030E42C
		// (set) Token: 0x060151C6 RID: 86470 RVA: 0x00310234 File Offset: 0x0030E434
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

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x060151C7 RID: 86471 RVA: 0x0031023D File Offset: 0x0030E43D
		// (set) Token: 0x060151C8 RID: 86472 RVA: 0x00310245 File Offset: 0x0030E445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestRoadId
		{
			get
			{
				return this.destRoadId_;
			}
			set
			{
				this.destRoadId_ = value;
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x060151C9 RID: 86473 RVA: 0x0031024E File Offset: 0x0030E44E
		// (set) Token: 0x060151CA RID: 86474 RVA: 0x00310256 File Offset: 0x0030E456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestIndex
		{
			get
			{
				return this.destIndex_;
			}
			set
			{
				this.destIndex_ = value;
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x060151CB RID: 86475 RVA: 0x0031025F File Offset: 0x0030E45F
		// (set) Token: 0x060151CC RID: 86476 RVA: 0x00310267 File Offset: 0x0030E467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartRoadId
		{
			get
			{
				return this.startRoadId_;
			}
			set
			{
				this.startRoadId_ = value;
			}
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x060151CD RID: 86477 RVA: 0x00310270 File Offset: 0x0030E470
		// (set) Token: 0x060151CE RID: 86478 RVA: 0x00310278 File Offset: 0x0030E478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartRoadIndex
		{
			get
			{
				return this.startRoadIndex_;
			}
			set
			{
				this.startRoadIndex_ = value;
			}
		}

		// Token: 0x060151CF RID: 86479 RVA: 0x00310281 File Offset: 0x0030E481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkEntityStartNavNotify);
		}

		// Token: 0x060151D0 RID: 86480 RVA: 0x00310290 File Offset: 0x0030E490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkEntityStartNavNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.StartRoadId == other.StartRoadId && this.StartRoadIndex == other.StartRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151D1 RID: 86481 RVA: 0x0031030C File Offset: 0x0030E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.DestRoadId != 0)
			{
				num ^= this.DestRoadId.GetHashCode();
			}
			if (this.DestIndex != 0)
			{
				num ^= this.DestIndex.GetHashCode();
			}
			if (this.StartRoadId != 0)
			{
				num ^= this.StartRoadId.GetHashCode();
			}
			if (this.StartRoadIndex != 0)
			{
				num ^= this.StartRoadIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060151D2 RID: 86482 RVA: 0x003103AF File Offset: 0x0030E5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151D3 RID: 86483 RVA: 0x003103BC File Offset: 0x0030E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151D4 RID: 86484 RVA: 0x003103C8 File Offset: 0x0030E5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.DestRoadId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DestRoadId);
			}
			if (this.StartRoadIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StartRoadIndex);
			}
			if (this.StartRoadId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.StartRoadId);
			}
			if (this.DestIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DestIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151D5 RID: 86485 RVA: 0x00310478 File Offset: 0x0030E678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.DestRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestIndex);
			}
			if (this.StartRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartRoadId);
			}
			if (this.StartRoadIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartRoadIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151D6 RID: 86486 RVA: 0x00310518 File Offset: 0x0030E718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNetworkEntityStartNavNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.DestRoadId != 0)
			{
				this.DestRoadId = other.DestRoadId;
			}
			if (other.DestIndex != 0)
			{
				this.DestIndex = other.DestIndex;
			}
			if (other.StartRoadId != 0)
			{
				this.StartRoadId = other.StartRoadId;
			}
			if (other.StartRoadIndex != 0)
			{
				this.StartRoadIndex = other.StartRoadIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151D7 RID: 86487 RVA: 0x003105A4 File Offset: 0x0030E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151D8 RID: 86488 RVA: 0x003105B0 File Offset: 0x0030E7B0
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
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.DestRoadId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.StartRoadIndex = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.StartRoadId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.DestIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F76 RID: 32630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F77 RID: 32631
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04007F78 RID: 32632
		private long entityId_;

		// Token: 0x04007F79 RID: 32633
		public const int DestRoadIdFieldNumber = 9;

		// Token: 0x04007F7A RID: 32634
		private int destRoadId_;

		// Token: 0x04007F7B RID: 32635
		public const int DestIndexFieldNumber = 13;

		// Token: 0x04007F7C RID: 32636
		private int destIndex_;

		// Token: 0x04007F7D RID: 32637
		public const int StartRoadIdFieldNumber = 12;

		// Token: 0x04007F7E RID: 32638
		private int startRoadId_;

		// Token: 0x04007F7F RID: 32639
		public const int StartRoadIndexFieldNumber = 10;

		// Token: 0x04007F80 RID: 32640
		private int startRoadIndex_;
	}
}
