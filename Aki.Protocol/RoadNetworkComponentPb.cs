using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F76 RID: 3958
	public sealed class RoadNetworkComponentPb : IMessage<RoadNetworkComponentPb>, IMessage, IEquatable<RoadNetworkComponentPb>, IDeepCloneable<RoadNetworkComponentPb>, IBufferMessage
	{
		// Token: 0x0601528A RID: 86666 RVA: 0x00311378 File Offset: 0x0030F578
		[NullableContext(1)]
		public static RoadNetworkComponentPb Create()
		{
			return new RoadNetworkComponentPb();
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x0601528B RID: 86667 RVA: 0x0031137F File Offset: 0x0030F57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x0601528C RID: 86668 RVA: 0x00311382 File Offset: 0x0030F582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNetworkComponentPb.Descriptor;
			}
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x00311389 File Offset: 0x0030F589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb()
		{
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x00311394 File Offset: 0x0030F594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb(RoadNetworkComponentPb other) : this()
		{
			this.destRoadId_ = other.destRoadId_;
			this.destIndex_ = other.destIndex_;
			this.genRoadId_ = other.genRoadId_;
			this.genRoadIndex_ = other.genRoadIndex_;
			this.navMoveData_ = ((other.navMoveData_ != null) ? other.navMoveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601528F RID: 86671 RVA: 0x00311404 File Offset: 0x0030F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb Clone()
		{
			return new RoadNetworkComponentPb(this);
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x06015290 RID: 86672 RVA: 0x0031140C File Offset: 0x0030F60C
		// (set) Token: 0x06015291 RID: 86673 RVA: 0x00311414 File Offset: 0x0030F614
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

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x06015292 RID: 86674 RVA: 0x0031141D File Offset: 0x0030F61D
		// (set) Token: 0x06015293 RID: 86675 RVA: 0x00311425 File Offset: 0x0030F625
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

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x06015294 RID: 86676 RVA: 0x0031142E File Offset: 0x0030F62E
		// (set) Token: 0x06015295 RID: 86677 RVA: 0x00311436 File Offset: 0x0030F636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadId
		{
			get
			{
				return this.genRoadId_;
			}
			set
			{
				this.genRoadId_ = value;
			}
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x06015296 RID: 86678 RVA: 0x0031143F File Offset: 0x0030F63F
		// (set) Token: 0x06015297 RID: 86679 RVA: 0x00311447 File Offset: 0x0030F647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadIndex
		{
			get
			{
				return this.genRoadIndex_;
			}
			set
			{
				this.genRoadIndex_ = value;
			}
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06015298 RID: 86680 RVA: 0x00311450 File Offset: 0x0030F650
		// (set) Token: 0x06015299 RID: 86681 RVA: 0x00311458 File Offset: 0x0030F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData NavMoveData
		{
			get
			{
				return this.navMoveData_;
			}
			set
			{
				this.navMoveData_ = value;
			}
		}

		// Token: 0x0601529A RID: 86682 RVA: 0x00311461 File Offset: 0x0030F661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNetworkComponentPb);
		}

		// Token: 0x0601529B RID: 86683 RVA: 0x00311470 File Offset: 0x0030F670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNetworkComponentPb other)
		{
			return other != null && (other == this || (this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.GenRoadId == other.GenRoadId && this.GenRoadIndex == other.GenRoadIndex && object.Equals(this.NavMoveData, other.NavMoveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601529C RID: 86684 RVA: 0x003114F0 File Offset: 0x0030F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DestRoadId != 0)
			{
				num ^= this.DestRoadId.GetHashCode();
			}
			if (this.DestIndex != 0)
			{
				num ^= this.DestIndex.GetHashCode();
			}
			if (this.GenRoadId != 0)
			{
				num ^= this.GenRoadId.GetHashCode();
			}
			if (this.GenRoadIndex != 0)
			{
				num ^= this.GenRoadIndex.GetHashCode();
			}
			if (this.navMoveData_ != null)
			{
				num ^= this.NavMoveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601529D RID: 86685 RVA: 0x00311590 File Offset: 0x0030F790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601529E RID: 86686 RVA: 0x0031159D File Offset: 0x0030F79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601529F RID: 86687 RVA: 0x003115A8 File Offset: 0x0030F7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DestRoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GenRoadIndex);
			}
			if (this.navMoveData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NavMoveData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x00311654 File Offset: 0x0030F854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DestRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadIndex);
			}
			if (this.navMoveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NavMoveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060152A1 RID: 86689 RVA: 0x003116F4 File Offset: 0x0030F8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNetworkComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DestRoadId != 0)
			{
				this.DestRoadId = other.DestRoadId;
			}
			if (other.DestIndex != 0)
			{
				this.DestIndex = other.DestIndex;
			}
			if (other.GenRoadId != 0)
			{
				this.GenRoadId = other.GenRoadId;
			}
			if (other.GenRoadIndex != 0)
			{
				this.GenRoadIndex = other.GenRoadIndex;
			}
			if (other.navMoveData_ != null)
			{
				if (this.navMoveData_ == null)
				{
					this.NavMoveData = new RoadNavMoveData();
				}
				this.NavMoveData.MergeFrom(other.NavMoveData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060152A2 RID: 86690 RVA: 0x00311798 File Offset: 0x0030F998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152A3 RID: 86691 RVA: 0x003117A4 File Offset: 0x0030F9A4
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
						this.DestRoadId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DestIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.GenRoadId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GenRoadIndex = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.navMoveData_ == null)
						{
							this.NavMoveData = new RoadNavMoveData();
						}
						input.ReadMessage(this.NavMoveData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F41 RID: 32577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F42 RID: 32578
		public const int DestRoadIdFieldNumber = 1;

		// Token: 0x04007F43 RID: 32579
		private int destRoadId_;

		// Token: 0x04007F44 RID: 32580
		public const int DestIndexFieldNumber = 2;

		// Token: 0x04007F45 RID: 32581
		private int destIndex_;

		// Token: 0x04007F46 RID: 32582
		public const int GenRoadIdFieldNumber = 3;

		// Token: 0x04007F47 RID: 32583
		private int genRoadId_;

		// Token: 0x04007F48 RID: 32584
		public const int GenRoadIndexFieldNumber = 4;

		// Token: 0x04007F49 RID: 32585
		private int genRoadIndex_;

		// Token: 0x04007F4A RID: 32586
		public const int NavMoveDataFieldNumber = 5;

		// Token: 0x04007F4B RID: 32587
		private RoadNavMoveData navMoveData_;
	}
}
