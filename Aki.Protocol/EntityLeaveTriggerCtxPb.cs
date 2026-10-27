using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049F RID: 1183
	public sealed class EntityLeaveTriggerCtxPb : IMessage<EntityLeaveTriggerCtxPb>, IMessage, IEquatable<EntityLeaveTriggerCtxPb>, IDeepCloneable<EntityLeaveTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x060070E6 RID: 28902 RVA: 0x0011500B File Offset: 0x0011320B
		[NullableContext(1)]
		public static EntityLeaveTriggerCtxPb Create()
		{
			return new EntityLeaveTriggerCtxPb();
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x060070E7 RID: 28903 RVA: 0x00115012 File Offset: 0x00113212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x00115015 File Offset: 0x00113215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLeaveTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x0011501C File Offset: 0x0011321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb()
		{
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x00115024 File Offset: 0x00113224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb(EntityLeaveTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerEntityIncId_ = other.triggerEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x00115070 File Offset: 0x00113270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb Clone()
		{
			return new EntityLeaveTriggerCtxPb(this);
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x00115078 File Offset: 0x00113278
		// (set) Token: 0x060070ED RID: 28909 RVA: 0x00115080 File Offset: 0x00113280
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

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x060070EE RID: 28910 RVA: 0x00115089 File Offset: 0x00113289
		// (set) Token: 0x060070EF RID: 28911 RVA: 0x00115091 File Offset: 0x00113291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TriggerEntityIncId
		{
			get
			{
				return this.triggerEntityIncId_;
			}
			set
			{
				this.triggerEntityIncId_ = value;
			}
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0011509A File Offset: 0x0011329A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLeaveTriggerCtxPb);
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x001150A8 File Offset: 0x001132A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLeaveTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerEntityIncId == other.TriggerEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x001150F8 File Offset: 0x001132F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.TriggerEntityIncId != 0L)
			{
				num ^= this.TriggerEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0011514D File Offset: 0x0011334D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0011515A File Offset: 0x0011335A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00115164 File Offset: 0x00113364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.TriggerEntityIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TriggerEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x001151C0 File Offset: 0x001133C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.TriggerEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TriggerEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x00115218 File Offset: 0x00113418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityLeaveTriggerCtxPb other)
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
			if (other.TriggerEntityIncId != 0L)
			{
				this.TriggerEntityIncId = other.TriggerEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x00115280 File Offset: 0x00113480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0011528C File Offset: 0x0011348C
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TriggerEntityIncId = input.ReadInt64();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04003C5A RID: 15450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C5B RID: 15451
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C5C RID: 15452
		private EntityCtxPb entityCtx_;

		// Token: 0x04003C5D RID: 15453
		public const int TriggerEntityIncIdFieldNumber = 2;

		// Token: 0x04003C5E RID: 15454
		private long triggerEntityIncId_;
	}
}
