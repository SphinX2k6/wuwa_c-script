using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000488 RID: 1160
	public sealed class EntityLeaveTriggerCtxPb : IMessage<EntityLeaveTriggerCtxPb>, IMessage, IEquatable<EntityLeaveTriggerCtxPb>, IDeepCloneable<EntityLeaveTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x06006F58 RID: 28504 RVA: 0x00111F93 File Offset: 0x00110193
		[NullableContext(1)]
		public static EntityLeaveTriggerCtxPb Create()
		{
			return new EntityLeaveTriggerCtxPb();
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06006F59 RID: 28505 RVA: 0x00111F9A File Offset: 0x0011019A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06006F5A RID: 28506 RVA: 0x00111F9D File Offset: 0x0011019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLeaveTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x00111FA4 File Offset: 0x001101A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb()
		{
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x00111FAC File Offset: 0x001101AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb(EntityLeaveTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerEntityIncId_ = other.triggerEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00111FF8 File Offset: 0x001101F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLeaveTriggerCtxPb Clone()
		{
			return new EntityLeaveTriggerCtxPb(this);
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00112000 File Offset: 0x00110200
		// (set) Token: 0x06006F5F RID: 28511 RVA: 0x00112008 File Offset: 0x00110208
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

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x00112011 File Offset: 0x00110211
		// (set) Token: 0x06006F61 RID: 28513 RVA: 0x00112019 File Offset: 0x00110219
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

		// Token: 0x06006F62 RID: 28514 RVA: 0x00112022 File Offset: 0x00110222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLeaveTriggerCtxPb);
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x00112030 File Offset: 0x00110230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLeaveTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerEntityIncId == other.TriggerEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x00112080 File Offset: 0x00110280
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

		// Token: 0x06006F65 RID: 28517 RVA: 0x001120D5 File Offset: 0x001102D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x001120E2 File Offset: 0x001102E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x001120EC File Offset: 0x001102EC
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

		// Token: 0x06006F68 RID: 28520 RVA: 0x00112148 File Offset: 0x00110348
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

		// Token: 0x06006F69 RID: 28521 RVA: 0x001121A0 File Offset: 0x001103A0
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

		// Token: 0x06006F6A RID: 28522 RVA: 0x00112208 File Offset: 0x00110408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00112214 File Offset: 0x00110414
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

		// Token: 0x04003C48 RID: 15432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C49 RID: 15433
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C4A RID: 15434
		private EntityCtxPb entityCtx_;

		// Token: 0x04003C4B RID: 15435
		public const int TriggerEntityIncIdFieldNumber = 2;

		// Token: 0x04003C4C RID: 15436
		private long triggerEntityIncId_;
	}
}
