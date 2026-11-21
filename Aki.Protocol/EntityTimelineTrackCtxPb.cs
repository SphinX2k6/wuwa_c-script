using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B3 RID: 1203
	public sealed class EntityTimelineTrackCtxPb : IMessage<EntityTimelineTrackCtxPb>, IMessage, IEquatable<EntityTimelineTrackCtxPb>, IDeepCloneable<EntityTimelineTrackCtxPb>, IBufferMessage
	{
		// Token: 0x060072FC RID: 29436 RVA: 0x0011A794 File Offset: 0x00118994
		[NullableContext(1)]
		public static EntityTimelineTrackCtxPb Create()
		{
			return new EntityTimelineTrackCtxPb();
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x0011A79B File Offset: 0x0011899B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x0011A79E File Offset: 0x0011899E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTimelineTrackCtxPb.Descriptor;
			}
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x0011A7A5 File Offset: 0x001189A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb()
		{
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x0011A7B0 File Offset: 0x001189B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb(EntityTimelineTrackCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.groupIndex_ = other.groupIndex_;
			this.controlPoint_ = other.controlPoint_;
			this.eventType_ = other.eventType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x0011A814 File Offset: 0x00118A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb Clone()
		{
			return new EntityTimelineTrackCtxPb(this);
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06007302 RID: 29442 RVA: 0x0011A81C File Offset: 0x00118A1C
		// (set) Token: 0x06007303 RID: 29443 RVA: 0x0011A824 File Offset: 0x00118A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06007304 RID: 29444 RVA: 0x0011A82D File Offset: 0x00118A2D
		// (set) Token: 0x06007305 RID: 29445 RVA: 0x0011A835 File Offset: 0x00118A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupIndex
		{
			get
			{
				return this.groupIndex_;
			}
			set
			{
				this.groupIndex_ = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06007306 RID: 29446 RVA: 0x0011A83E File Offset: 0x00118A3E
		// (set) Token: 0x06007307 RID: 29447 RVA: 0x0011A846 File Offset: 0x00118A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ControlPoint
		{
			get
			{
				return this.controlPoint_;
			}
			set
			{
				this.controlPoint_ = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x0011A84F File Offset: 0x00118A4F
		// (set) Token: 0x06007309 RID: 29449 RVA: 0x0011A857 File Offset: 0x00118A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineEventType EventType
		{
			get
			{
				return this.eventType_;
			}
			set
			{
				this.eventType_ = value;
			}
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x0011A860 File Offset: 0x00118A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTimelineTrackCtxPb);
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x0011A870 File Offset: 0x00118A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTimelineTrackCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.GroupIndex == other.GroupIndex && this.ControlPoint == other.ControlPoint && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0011A8E0 File Offset: 0x00118AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.GroupIndex != 0)
			{
				num ^= this.GroupIndex.GetHashCode();
			}
			if (this.ControlPoint != 0)
			{
				num ^= this.ControlPoint.GetHashCode();
			}
			if (this.EventType != EntityTimelineEventType.LeftIn)
			{
				num ^= this.EventType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x0011A96D File Offset: 0x00118B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x0011A97A File Offset: 0x00118B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x0011A984 File Offset: 0x00118B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.GroupIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupIndex);
			}
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ControlPoint);
			}
			if (this.EventType != EntityTimelineEventType.LeftIn)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.EventType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x0011AA18 File Offset: 0x00118C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.GroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupIndex);
			}
			if (this.ControlPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ControlPoint);
			}
			if (this.EventType != EntityTimelineEventType.LeftIn)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EventType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x0011AAA0 File Offset: 0x00118CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityTimelineTrackCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.GroupIndex != 0)
			{
				this.GroupIndex = other.GroupIndex;
			}
			if (other.ControlPoint != 0)
			{
				this.ControlPoint = other.ControlPoint;
			}
			if (other.EventType != EntityTimelineEventType.LeftIn)
			{
				this.EventType = other.EventType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x0011AB30 File Offset: 0x00118D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x0011AB3C File Offset: 0x00118D3C
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
					if (num == 10U)
					{
						if (this.entityCtx_ == null)
						{
							this.EntityCtx = new EntityCtxPb();
						}
						input.ReadMessage(this.EntityCtx);
						continue;
					}
					if (num == 16U)
					{
						this.GroupIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ControlPoint = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EventType = (EntityTimelineEventType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D5F RID: 15711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D60 RID: 15712
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003D61 RID: 15713
		private EntityCtxPb entityCtx_;

		// Token: 0x04003D62 RID: 15714
		public const int GroupIndexFieldNumber = 2;

		// Token: 0x04003D63 RID: 15715
		private int groupIndex_;

		// Token: 0x04003D64 RID: 15716
		public const int ControlPointFieldNumber = 3;

		// Token: 0x04003D65 RID: 15717
		private int controlPoint_;

		// Token: 0x04003D66 RID: 15718
		public const int EventTypeFieldNumber = 4;

		// Token: 0x04003D67 RID: 15719
		private EntityTimelineEventType eventType_;
	}
}
