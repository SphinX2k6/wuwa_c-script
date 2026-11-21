using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B4 RID: 1204
	public sealed class EntityTriggerCtxPb : IMessage<EntityTriggerCtxPb>, IMessage, IEquatable<EntityTriggerCtxPb>, IDeepCloneable<EntityTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x06007314 RID: 29460 RVA: 0x0011ABD7 File Offset: 0x00118DD7
		[NullableContext(1)]
		public static EntityTriggerCtxPb Create()
		{
			return new EntityTriggerCtxPb();
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x0011ABDE File Offset: 0x00118DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06007316 RID: 29462 RVA: 0x0011ABE1 File Offset: 0x00118DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x0011ABE8 File Offset: 0x00118DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb()
		{
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x0011ABF0 File Offset: 0x00118DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb(EntityTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerEntityIncId_ = other.triggerEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x0011AC3C File Offset: 0x00118E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb Clone()
		{
			return new EntityTriggerCtxPb(this);
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x0011AC44 File Offset: 0x00118E44
		// (set) Token: 0x0600731B RID: 29467 RVA: 0x0011AC4C File Offset: 0x00118E4C
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

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x0011AC55 File Offset: 0x00118E55
		// (set) Token: 0x0600731D RID: 29469 RVA: 0x0011AC5D File Offset: 0x00118E5D
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

		// Token: 0x0600731E RID: 29470 RVA: 0x0011AC66 File Offset: 0x00118E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTriggerCtxPb);
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0011AC74 File Offset: 0x00118E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerEntityIncId == other.TriggerEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x0011ACC4 File Offset: 0x00118EC4
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

		// Token: 0x06007321 RID: 29473 RVA: 0x0011AD19 File Offset: 0x00118F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0011AD26 File Offset: 0x00118F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x0011AD30 File Offset: 0x00118F30
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

		// Token: 0x06007324 RID: 29476 RVA: 0x0011AD8C File Offset: 0x00118F8C
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

		// Token: 0x06007325 RID: 29477 RVA: 0x0011ADE4 File Offset: 0x00118FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityTriggerCtxPb other)
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

		// Token: 0x06007326 RID: 29478 RVA: 0x0011AE4C File Offset: 0x0011904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x0011AE58 File Offset: 0x00119058
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

		// Token: 0x04003D68 RID: 15720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D69 RID: 15721
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003D6A RID: 15722
		private EntityCtxPb entityCtx_;

		// Token: 0x04003D6B RID: 15723
		public const int TriggerEntityIncIdFieldNumber = 2;

		// Token: 0x04003D6C RID: 15724
		private long triggerEntityIncId_;
	}
}
