using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000483 RID: 1155
	public sealed class EntityDestructibleCtxPb : IMessage<EntityDestructibleCtxPb>, IMessage, IEquatable<EntityDestructibleCtxPb>, IDeepCloneable<EntityDestructibleCtxPb>, IBufferMessage
	{
		// Token: 0x06006E9C RID: 28316 RVA: 0x0010FAE3 File Offset: 0x0010DCE3
		[NullableContext(1)]
		public static EntityDestructibleCtxPb Create()
		{
			return new EntityDestructibleCtxPb();
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x0010FAEA File Offset: 0x0010DCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x0010FAED File Offset: 0x0010DCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDestructibleCtxPb.Descriptor;
			}
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x0010FAF4 File Offset: 0x0010DCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb()
		{
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x0010FAFC File Offset: 0x0010DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb(EntityDestructibleCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x0010FB31 File Offset: 0x0010DD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb Clone()
		{
			return new EntityDestructibleCtxPb(this);
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x0010FB39 File Offset: 0x0010DD39
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x0010FB41 File Offset: 0x0010DD41
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

		// Token: 0x06006EA4 RID: 28324 RVA: 0x0010FB4A File Offset: 0x0010DD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDestructibleCtxPb);
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x0010FB58 File Offset: 0x0010DD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDestructibleCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x0010FB8C File Offset: 0x0010DD8C
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

		// Token: 0x06006EA7 RID: 28327 RVA: 0x0010FBC8 File Offset: 0x0010DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0010FBD5 File Offset: 0x0010DDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x0010FBDE File Offset: 0x0010DDDE
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

		// Token: 0x06006EAA RID: 28330 RVA: 0x0010FC10 File Offset: 0x0010DE10
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

		// Token: 0x06006EAB RID: 28331 RVA: 0x0010FC50 File Offset: 0x0010DE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDestructibleCtxPb other)
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

		// Token: 0x06006EAC RID: 28332 RVA: 0x0010FCA4 File Offset: 0x0010DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x0010FCB0 File Offset: 0x0010DEB0
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

		// Token: 0x04003BB0 RID: 15280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB1 RID: 15281
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003BB2 RID: 15282
		private EntityCtxPb entityCtx_;
	}
}
