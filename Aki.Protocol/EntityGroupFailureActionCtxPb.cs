using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000494 RID: 1172
	public sealed class EntityGroupFailureActionCtxPb : IMessage<EntityGroupFailureActionCtxPb>, IMessage, IEquatable<EntityGroupFailureActionCtxPb>, IDeepCloneable<EntityGroupFailureActionCtxPb>, IBufferMessage
	{
		// Token: 0x06007000 RID: 28672 RVA: 0x00112EF6 File Offset: 0x001110F6
		[NullableContext(1)]
		public static EntityGroupFailureActionCtxPb Create()
		{
			return new EntityGroupFailureActionCtxPb();
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x00112EFD File Offset: 0x001110FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06007002 RID: 28674 RVA: 0x00112F00 File Offset: 0x00111100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGroupFailureActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00112F07 File Offset: 0x00111107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb()
		{
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00112F0F File Offset: 0x0011110F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb(EntityGroupFailureActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00112F44 File Offset: 0x00111144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb Clone()
		{
			return new EntityGroupFailureActionCtxPb(this);
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x00112F4C File Offset: 0x0011114C
		// (set) Token: 0x06007007 RID: 28679 RVA: 0x00112F54 File Offset: 0x00111154
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

		// Token: 0x06007008 RID: 28680 RVA: 0x00112F5D File Offset: 0x0011115D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGroupFailureActionCtxPb);
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x00112F6B File Offset: 0x0011116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGroupFailureActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x00112FA0 File Offset: 0x001111A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x00112FDC File Offset: 0x001111DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x00112FE9 File Offset: 0x001111E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x00112FF2 File Offset: 0x001111F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00113024 File Offset: 0x00111224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00113064 File Offset: 0x00111264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityGroupFailureActionCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x001130B8 File Offset: 0x001112B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x001130C4 File Offset: 0x001112C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04003C1A RID: 15386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1B RID: 15387
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C1C RID: 15388
		private EntityCtxPb entityCtx_;
	}
}
