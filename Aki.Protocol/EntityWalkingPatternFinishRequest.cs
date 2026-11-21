using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B6 RID: 1206
	[NetMessage(EMessageId.EntityWalkingPatternFinishRequest)]
	public sealed class EntityWalkingPatternFinishRequest : IMessage<EntityWalkingPatternFinishRequest>, IMessage, IEquatable<EntityWalkingPatternFinishRequest>, IDeepCloneable<EntityWalkingPatternFinishRequest>, IBufferMessage
	{
		// Token: 0x0600733E RID: 29502 RVA: 0x0011B279 File Offset: 0x00119479
		[NullableContext(1)]
		public static EntityWalkingPatternFinishRequest Create()
		{
			return new EntityWalkingPatternFinishRequest();
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x0011B280 File Offset: 0x00119480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x0011B283 File Offset: 0x00119483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityWalkingPatternFinishRequest.Descriptor;
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x0011B28A File Offset: 0x0011948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest()
		{
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x0011B292 File Offset: 0x00119492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest(EntityWalkingPatternFinishRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x0011B2CF File Offset: 0x001194CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest Clone()
		{
			return new EntityWalkingPatternFinishRequest(this);
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x0011B2D7 File Offset: 0x001194D7
		// (set) Token: 0x06007345 RID: 29509 RVA: 0x0011B2DF File Offset: 0x001194DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x0011B2E8 File Offset: 0x001194E8
		// (set) Token: 0x06007347 RID: 29511 RVA: 0x0011B2F0 File Offset: 0x001194F0
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

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x0011B2F9 File Offset: 0x001194F9
		// (set) Token: 0x06007349 RID: 29513 RVA: 0x0011B301 File Offset: 0x00119501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x0011B30A File Offset: 0x0011950A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityWalkingPatternFinishRequest);
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x0011B318 File Offset: 0x00119518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityWalkingPatternFinishRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x0011B374 File Offset: 0x00119574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x0011B3E5 File Offset: 0x001195E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x0011B3F2 File Offset: 0x001195F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x0011B3FC File Offset: 0x001195FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x0011B474 File Offset: 0x00119674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x0011B4E4 File Offset: 0x001196E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityWalkingPatternFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x0011B548 File Offset: 0x00119748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x0011B554 File Offset: 0x00119754
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
				if (num != 16U)
				{
					if (num != 64U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Point = input.ReadInt32();
						}
					}
					else
					{
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D74 RID: 15732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D75 RID: 15733
		public const int HostPlayerIdFieldNumber = 8;

		// Token: 0x04003D76 RID: 15734
		private int hostPlayerId_;

		// Token: 0x04003D77 RID: 15735
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003D78 RID: 15736
		private long entityId_;

		// Token: 0x04003D79 RID: 15737
		public const int PointFieldNumber = 9;

		// Token: 0x04003D7A RID: 15738
		private int point_;
	}
}
