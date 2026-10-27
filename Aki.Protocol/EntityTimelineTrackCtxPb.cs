using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CA RID: 1226
	public sealed class EntityTimelineTrackCtxPb : IMessage<EntityTimelineTrackCtxPb>, IMessage, IEquatable<EntityTimelineTrackCtxPb>, IDeepCloneable<EntityTimelineTrackCtxPb>, IBufferMessage
	{
		// Token: 0x0600748C RID: 29836 RVA: 0x0011D8AC File Offset: 0x0011BAAC
		[NullableContext(1)]
		public static EntityTimelineTrackCtxPb Create()
		{
			return new EntityTimelineTrackCtxPb();
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x0600748D RID: 29837 RVA: 0x0011D8B3 File Offset: 0x0011BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x0011D8B6 File Offset: 0x0011BAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTimelineTrackCtxPb.Descriptor;
			}
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x0011D8BD File Offset: 0x0011BABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb()
		{
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x0011D8C8 File Offset: 0x0011BAC8
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

		// Token: 0x06007491 RID: 29841 RVA: 0x0011D92C File Offset: 0x0011BB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimelineTrackCtxPb Clone()
		{
			return new EntityTimelineTrackCtxPb(this);
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x0011D934 File Offset: 0x0011BB34
		// (set) Token: 0x06007493 RID: 29843 RVA: 0x0011D93C File Offset: 0x0011BB3C
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x0011D945 File Offset: 0x0011BB45
		// (set) Token: 0x06007495 RID: 29845 RVA: 0x0011D94D File Offset: 0x0011BB4D
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x0011D956 File Offset: 0x0011BB56
		// (set) Token: 0x06007497 RID: 29847 RVA: 0x0011D95E File Offset: 0x0011BB5E
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

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x0011D967 File Offset: 0x0011BB67
		// (set) Token: 0x06007499 RID: 29849 RVA: 0x0011D96F File Offset: 0x0011BB6F
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

		// Token: 0x0600749A RID: 29850 RVA: 0x0011D978 File Offset: 0x0011BB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTimelineTrackCtxPb);
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x0011D988 File Offset: 0x0011BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTimelineTrackCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.GroupIndex == other.GroupIndex && this.ControlPoint == other.ControlPoint && this.EventType == other.EventType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x0011D9F8 File Offset: 0x0011BBF8
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

		// Token: 0x0600749D RID: 29853 RVA: 0x0011DA85 File Offset: 0x0011BC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x0011DA92 File Offset: 0x0011BC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x0011DA9C File Offset: 0x0011BC9C
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

		// Token: 0x060074A0 RID: 29856 RVA: 0x0011DB30 File Offset: 0x0011BD30
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

		// Token: 0x060074A1 RID: 29857 RVA: 0x0011DBB8 File Offset: 0x0011BDB8
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

		// Token: 0x060074A2 RID: 29858 RVA: 0x0011DC48 File Offset: 0x0011BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x0011DC54 File Offset: 0x0011BE54
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

		// Token: 0x04003D73 RID: 15731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D74 RID: 15732
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003D75 RID: 15733
		private EntityCtxPb entityCtx_;

		// Token: 0x04003D76 RID: 15734
		public const int GroupIndexFieldNumber = 2;

		// Token: 0x04003D77 RID: 15735
		private int groupIndex_;

		// Token: 0x04003D78 RID: 15736
		public const int ControlPointFieldNumber = 3;

		// Token: 0x04003D79 RID: 15737
		private int controlPoint_;

		// Token: 0x04003D7A RID: 15738
		public const int EventTypeFieldNumber = 4;

		// Token: 0x04003D7B RID: 15739
		private EntityTimelineEventType eventType_;
	}
}
