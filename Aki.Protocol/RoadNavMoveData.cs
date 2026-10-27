using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F75 RID: 3957
	public sealed class RoadNavMoveData : IMessage<RoadNavMoveData>, IMessage, IEquatable<RoadNavMoveData>, IDeepCloneable<RoadNavMoveData>, IBufferMessage
	{
		// Token: 0x06015272 RID: 86642 RVA: 0x00310F83 File Offset: 0x0030F183
		[NullableContext(1)]
		public static RoadNavMoveData Create()
		{
			return new RoadNavMoveData();
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x06015273 RID: 86643 RVA: 0x00310F8A File Offset: 0x0030F18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x06015274 RID: 86644 RVA: 0x00310F8D File Offset: 0x0030F18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNavMoveData.Descriptor;
			}
		}

		// Token: 0x06015275 RID: 86645 RVA: 0x00310F94 File Offset: 0x0030F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData()
		{
		}

		// Token: 0x06015276 RID: 86646 RVA: 0x00310F9C File Offset: 0x0030F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData(RoadNavMoveData other) : this()
		{
			this.destRoadId_ = other.destRoadId_;
			this.destIndex_ = other.destIndex_;
			this.genRoadId_ = other.genRoadId_;
			this.genRoadIndex_ = other.genRoadIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015277 RID: 86647 RVA: 0x00310FF0 File Offset: 0x0030F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData Clone()
		{
			return new RoadNavMoveData(this);
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x06015278 RID: 86648 RVA: 0x00310FF8 File Offset: 0x0030F1F8
		// (set) Token: 0x06015279 RID: 86649 RVA: 0x00311000 File Offset: 0x0030F200
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

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x0601527A RID: 86650 RVA: 0x00311009 File Offset: 0x0030F209
		// (set) Token: 0x0601527B RID: 86651 RVA: 0x00311011 File Offset: 0x0030F211
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

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x0601527C RID: 86652 RVA: 0x0031101A File Offset: 0x0030F21A
		// (set) Token: 0x0601527D RID: 86653 RVA: 0x00311022 File Offset: 0x0030F222
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

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x0601527E RID: 86654 RVA: 0x0031102B File Offset: 0x0030F22B
		// (set) Token: 0x0601527F RID: 86655 RVA: 0x00311033 File Offset: 0x0030F233
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

		// Token: 0x06015280 RID: 86656 RVA: 0x0031103C File Offset: 0x0030F23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNavMoveData);
		}

		// Token: 0x06015281 RID: 86657 RVA: 0x0031104C File Offset: 0x0030F24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNavMoveData other)
		{
			return other != null && (other == this || (this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.GenRoadId == other.GenRoadId && this.GenRoadIndex == other.GenRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015282 RID: 86658 RVA: 0x003110B8 File Offset: 0x0030F2B8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015283 RID: 86659 RVA: 0x00311142 File Offset: 0x0030F342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015284 RID: 86660 RVA: 0x0031114F File Offset: 0x0030F34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015285 RID: 86661 RVA: 0x00311158 File Offset: 0x0030F358
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015286 RID: 86662 RVA: 0x003111E8 File Offset: 0x0030F3E8
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015287 RID: 86663 RVA: 0x00311270 File Offset: 0x0030F470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNavMoveData other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015288 RID: 86664 RVA: 0x003112E8 File Offset: 0x0030F4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015289 RID: 86665 RVA: 0x003112F4 File Offset: 0x0030F4F4
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F38 RID: 32568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F39 RID: 32569
		public const int DestRoadIdFieldNumber = 1;

		// Token: 0x04007F3A RID: 32570
		private int destRoadId_;

		// Token: 0x04007F3B RID: 32571
		public const int DestIndexFieldNumber = 2;

		// Token: 0x04007F3C RID: 32572
		private int destIndex_;

		// Token: 0x04007F3D RID: 32573
		public const int GenRoadIdFieldNumber = 3;

		// Token: 0x04007F3E RID: 32574
		private int genRoadId_;

		// Token: 0x04007F3F RID: 32575
		public const int GenRoadIndexFieldNumber = 4;

		// Token: 0x04007F40 RID: 32576
		private int genRoadIndex_;
	}
}
