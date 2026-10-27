using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CB RID: 1227
	public sealed class EntityTriggerCtxPb : IMessage<EntityTriggerCtxPb>, IMessage, IEquatable<EntityTriggerCtxPb>, IDeepCloneable<EntityTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x060074A4 RID: 29860 RVA: 0x0011DCEF File Offset: 0x0011BEEF
		[NullableContext(1)]
		public static EntityTriggerCtxPb Create()
		{
			return new EntityTriggerCtxPb();
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x060074A5 RID: 29861 RVA: 0x0011DCF6 File Offset: 0x0011BEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x060074A6 RID: 29862 RVA: 0x0011DCF9 File Offset: 0x0011BEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x0011DD00 File Offset: 0x0011BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb()
		{
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x0011DD08 File Offset: 0x0011BF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb(EntityTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerEntityIncId_ = other.triggerEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x0011DD54 File Offset: 0x0011BF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTriggerCtxPb Clone()
		{
			return new EntityTriggerCtxPb(this);
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x0011DD5C File Offset: 0x0011BF5C
		// (set) Token: 0x060074AB RID: 29867 RVA: 0x0011DD64 File Offset: 0x0011BF64
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

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x060074AC RID: 29868 RVA: 0x0011DD6D File Offset: 0x0011BF6D
		// (set) Token: 0x060074AD RID: 29869 RVA: 0x0011DD75 File Offset: 0x0011BF75
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

		// Token: 0x060074AE RID: 29870 RVA: 0x0011DD7E File Offset: 0x0011BF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTriggerCtxPb);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x0011DD8C File Offset: 0x0011BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerEntityIncId == other.TriggerEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x0011DDDC File Offset: 0x0011BFDC
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

		// Token: 0x060074B1 RID: 29873 RVA: 0x0011DE31 File Offset: 0x0011C031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x0011DE3E File Offset: 0x0011C03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x0011DE48 File Offset: 0x0011C048
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

		// Token: 0x060074B4 RID: 29876 RVA: 0x0011DEA4 File Offset: 0x0011C0A4
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

		// Token: 0x060074B5 RID: 29877 RVA: 0x0011DEFC File Offset: 0x0011C0FC
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

		// Token: 0x060074B6 RID: 29878 RVA: 0x0011DF64 File Offset: 0x0011C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x0011DF70 File Offset: 0x0011C170
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

		// Token: 0x04003D7C RID: 15740
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7D RID: 15741
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003D7E RID: 15742
		private EntityCtxPb entityCtx_;

		// Token: 0x04003D7F RID: 15743
		public const int TriggerEntityIncIdFieldNumber = 2;

		// Token: 0x04003D80 RID: 15744
		private long triggerEntityIncId_;
	}
}
