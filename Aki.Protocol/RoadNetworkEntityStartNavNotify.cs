using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F77 RID: 3959
	[NetMessage(EMessageId.RoadNetworkEntityStartNavNotify)]
	public sealed class RoadNetworkEntityStartNavNotify : IMessage<RoadNetworkEntityStartNavNotify>, IMessage, IEquatable<RoadNetworkEntityStartNavNotify>, IDeepCloneable<RoadNetworkEntityStartNavNotify>, IBufferMessage
	{
		// Token: 0x060152A4 RID: 86692 RVA: 0x00311854 File Offset: 0x0030FA54
		[NullableContext(1)]
		public static RoadNetworkEntityStartNavNotify Create()
		{
			return new RoadNetworkEntityStartNavNotify();
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x060152A5 RID: 86693 RVA: 0x0031185B File Offset: 0x0030FA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x060152A6 RID: 86694 RVA: 0x0031185E File Offset: 0x0030FA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkEntityStartNavNotify.Descriptor;
			}
		}

		// Token: 0x060152A7 RID: 86695 RVA: 0x00311865 File Offset: 0x0030FA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityStartNavNotify()
		{
		}

		// Token: 0x060152A8 RID: 86696 RVA: 0x00311870 File Offset: 0x0030FA70
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

		// Token: 0x060152A9 RID: 86697 RVA: 0x003118D0 File Offset: 0x0030FAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkEntityStartNavNotify Clone()
		{
			return new RoadNetworkEntityStartNavNotify(this);
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x060152AA RID: 86698 RVA: 0x003118D8 File Offset: 0x0030FAD8
		// (set) Token: 0x060152AB RID: 86699 RVA: 0x003118E0 File Offset: 0x0030FAE0
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

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x060152AC RID: 86700 RVA: 0x003118E9 File Offset: 0x0030FAE9
		// (set) Token: 0x060152AD RID: 86701 RVA: 0x003118F1 File Offset: 0x0030FAF1
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

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x060152AE RID: 86702 RVA: 0x003118FA File Offset: 0x0030FAFA
		// (set) Token: 0x060152AF RID: 86703 RVA: 0x00311902 File Offset: 0x0030FB02
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

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x060152B0 RID: 86704 RVA: 0x0031190B File Offset: 0x0030FB0B
		// (set) Token: 0x060152B1 RID: 86705 RVA: 0x00311913 File Offset: 0x0030FB13
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

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x060152B2 RID: 86706 RVA: 0x0031191C File Offset: 0x0030FB1C
		// (set) Token: 0x060152B3 RID: 86707 RVA: 0x00311924 File Offset: 0x0030FB24
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

		// Token: 0x060152B4 RID: 86708 RVA: 0x0031192D File Offset: 0x0030FB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkEntityStartNavNotify);
		}

		// Token: 0x060152B5 RID: 86709 RVA: 0x0031193C File Offset: 0x0030FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkEntityStartNavNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.StartRoadId == other.StartRoadId && this.StartRoadIndex == other.StartRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152B6 RID: 86710 RVA: 0x003119B8 File Offset: 0x0030FBB8
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

		// Token: 0x060152B7 RID: 86711 RVA: 0x00311A5B File Offset: 0x0030FC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152B8 RID: 86712 RVA: 0x00311A68 File Offset: 0x0030FC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152B9 RID: 86713 RVA: 0x00311A74 File Offset: 0x0030FC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartRoadIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StartRoadIndex);
			}
			if (this.DestIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DestIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.DestRoadId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DestRoadId);
			}
			if (this.StartRoadId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.StartRoadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152BA RID: 86714 RVA: 0x00311B24 File Offset: 0x0030FD24
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

		// Token: 0x060152BB RID: 86715 RVA: 0x00311BC4 File Offset: 0x0030FDC4
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

		// Token: 0x060152BC RID: 86716 RVA: 0x00311C50 File Offset: 0x0030FE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152BD RID: 86717 RVA: 0x00311C5C File Offset: 0x0030FE5C
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.StartRoadIndex = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.DestIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.DestRoadId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.StartRoadId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F4C RID: 32588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F4D RID: 32589
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04007F4E RID: 32590
		private long entityId_;

		// Token: 0x04007F4F RID: 32591
		public const int DestRoadIdFieldNumber = 12;

		// Token: 0x04007F50 RID: 32592
		private int destRoadId_;

		// Token: 0x04007F51 RID: 32593
		public const int DestIndexFieldNumber = 4;

		// Token: 0x04007F52 RID: 32594
		private int destIndex_;

		// Token: 0x04007F53 RID: 32595
		public const int StartRoadIdFieldNumber = 14;

		// Token: 0x04007F54 RID: 32596
		private int startRoadId_;

		// Token: 0x04007F55 RID: 32597
		public const int StartRoadIndexFieldNumber = 3;

		// Token: 0x04007F56 RID: 32598
		private int startRoadIndex_;
	}
}
