using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DF RID: 4831
	[NetMessage(EMessageId.SplinePositionUpdateRequest)]
	public sealed class SplinePositionUpdateRequest : IMessage<SplinePositionUpdateRequest>, IMessage, IEquatable<SplinePositionUpdateRequest>, IDeepCloneable<SplinePositionUpdateRequest>, IBufferMessage
	{
		// Token: 0x06019C7E RID: 105598 RVA: 0x003C2B8B File Offset: 0x003C0D8B
		[NullableContext(1)]
		public static SplinePositionUpdateRequest Create()
		{
			return new SplinePositionUpdateRequest();
		}

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x06019C7F RID: 105599 RVA: 0x003C2B92 File Offset: 0x003C0D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x06019C80 RID: 105600 RVA: 0x003C2B95 File Offset: 0x003C0D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplinePositionUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06019C81 RID: 105601 RVA: 0x003C2B9C File Offset: 0x003C0D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest()
		{
		}

		// Token: 0x06019C82 RID: 105602 RVA: 0x003C2BA4 File Offset: 0x003C0DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest(SplinePositionUpdateRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.splineId_ = other.splineId_;
			this.splineIdx_ = other.splineIdx_;
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this.splineType_ = other.splineType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C83 RID: 105603 RVA: 0x003C2C10 File Offset: 0x003C0E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplinePositionUpdateRequest Clone()
		{
			return new SplinePositionUpdateRequest(this);
		}

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x06019C84 RID: 105604 RVA: 0x003C2C18 File Offset: 0x003C0E18
		// (set) Token: 0x06019C85 RID: 105605 RVA: 0x003C2C20 File Offset: 0x003C0E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x06019C86 RID: 105606 RVA: 0x003C2C29 File Offset: 0x003C0E29
		// (set) Token: 0x06019C87 RID: 105607 RVA: 0x003C2C31 File Offset: 0x003C0E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineId
		{
			get
			{
				return this.splineId_;
			}
			set
			{
				this.splineId_ = value;
			}
		}

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x06019C88 RID: 105608 RVA: 0x003C2C3A File Offset: 0x003C0E3A
		// (set) Token: 0x06019C89 RID: 105609 RVA: 0x003C2C42 File Offset: 0x003C0E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineIdx
		{
			get
			{
				return this.splineIdx_;
			}
			set
			{
				this.splineIdx_ = value;
			}
		}

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x06019C8A RID: 105610 RVA: 0x003C2C4B File Offset: 0x003C0E4B
		// (set) Token: 0x06019C8B RID: 105611 RVA: 0x003C2C53 File Offset: 0x003C0E53
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

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x06019C8C RID: 105612 RVA: 0x003C2C5C File Offset: 0x003C0E5C
		// (set) Token: 0x06019C8D RID: 105613 RVA: 0x003C2C64 File Offset: 0x003C0E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x06019C8E RID: 105614 RVA: 0x003C2C6D File Offset: 0x003C0E6D
		// (set) Token: 0x06019C8F RID: 105615 RVA: 0x003C2C75 File Offset: 0x003C0E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcTimeScheduleSplineType SplineType
		{
			get
			{
				return this.splineType_;
			}
			set
			{
				this.splineType_ = value;
			}
		}

		// Token: 0x06019C90 RID: 105616 RVA: 0x003C2C7E File Offset: 0x003C0E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplinePositionUpdateRequest);
		}

		// Token: 0x06019C91 RID: 105617 RVA: 0x003C2C8C File Offset: 0x003C0E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplinePositionUpdateRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SplineId == other.SplineId && this.SplineIdx == other.SplineIdx && this.EntityId == other.EntityId && this.Dir == other.Dir && this.SplineType == other.SplineType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C92 RID: 105618 RVA: 0x003C2D18 File Offset: 0x003C0F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SplineId != 0)
			{
				num ^= this.SplineId.GetHashCode();
			}
			if (this.SplineIdx != 0)
			{
				num ^= this.SplineIdx.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				num ^= this.SplineType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C93 RID: 105619 RVA: 0x003C2DDB File Offset: 0x003C0FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C94 RID: 105620 RVA: 0x003C2DE8 File Offset: 0x003C0FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C95 RID: 105621 RVA: 0x003C2DF4 File Offset: 0x003C0FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SplineId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SplineId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.Dir)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Dir);
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.SplineType);
			}
			if (this.SplineIdx != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SplineIdx);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C96 RID: 105622 RVA: 0x003C2EC0 File Offset: 0x003C10C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SplineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineId);
			}
			if (this.SplineIdx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineIdx);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Dir)
			{
				num += 2;
			}
			if (this.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SplineType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C97 RID: 105623 RVA: 0x003C2F6C File Offset: 0x003C116C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplinePositionUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SplineId != 0)
			{
				this.SplineId = other.SplineId;
			}
			if (other.SplineIdx != 0)
			{
				this.SplineIdx = other.SplineIdx;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			if (other.SplineType != NpcTimeScheduleSplineType.PathSpline)
			{
				this.SplineType = other.SplineType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C98 RID: 105624 RVA: 0x003C300C File Offset: 0x003C120C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C99 RID: 105625 RVA: 0x003C3018 File Offset: 0x003C1218
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
					if (num == 16U)
					{
						this.SplineId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.Dir = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.SplineType = (NpcTimeScheduleSplineType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.SplineIdx = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009826 RID: 38950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009827 RID: 38951
		public const int InstIdFieldNumber = 12;

		// Token: 0x04009828 RID: 38952
		private int instId_;

		// Token: 0x04009829 RID: 38953
		public const int SplineIdFieldNumber = 2;

		// Token: 0x0400982A RID: 38954
		private int splineId_;

		// Token: 0x0400982B RID: 38955
		public const int SplineIdxFieldNumber = 7;

		// Token: 0x0400982C RID: 38956
		private int splineIdx_;

		// Token: 0x0400982D RID: 38957
		public const int EntityIdFieldNumber = 3;

		// Token: 0x0400982E RID: 38958
		private long entityId_;

		// Token: 0x0400982F RID: 38959
		public const int DirFieldNumber = 4;

		// Token: 0x04009830 RID: 38960
		private bool dir_;

		// Token: 0x04009831 RID: 38961
		public const int SplineTypeFieldNumber = 6;

		// Token: 0x04009832 RID: 38962
		private NpcTimeScheduleSplineType splineType_;
	}
}
