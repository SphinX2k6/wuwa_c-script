using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046C RID: 1132
	public sealed class EntityDestructibleCtxPb : IMessage<EntityDestructibleCtxPb>, IMessage, IEquatable<EntityDestructibleCtxPb>, IDeepCloneable<EntityDestructibleCtxPb>, IBufferMessage
	{
		// Token: 0x06006D0E RID: 27918 RVA: 0x0010CA6F File Offset: 0x0010AC6F
		[NullableContext(1)]
		public static EntityDestructibleCtxPb Create()
		{
			return new EntityDestructibleCtxPb();
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x0010CA76 File Offset: 0x0010AC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06006D10 RID: 27920 RVA: 0x0010CA79 File Offset: 0x0010AC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDestructibleCtxPb.Descriptor;
			}
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0010CA80 File Offset: 0x0010AC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb()
		{
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x0010CA88 File Offset: 0x0010AC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb(EntityDestructibleCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x0010CABD File Offset: 0x0010ACBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestructibleCtxPb Clone()
		{
			return new EntityDestructibleCtxPb(this);
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x0010CAC5 File Offset: 0x0010ACC5
		// (set) Token: 0x06006D15 RID: 27925 RVA: 0x0010CACD File Offset: 0x0010ACCD
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

		// Token: 0x06006D16 RID: 27926 RVA: 0x0010CAD6 File Offset: 0x0010ACD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDestructibleCtxPb);
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x0010CAE4 File Offset: 0x0010ACE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDestructibleCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x0010CB18 File Offset: 0x0010AD18
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

		// Token: 0x06006D19 RID: 27929 RVA: 0x0010CB54 File Offset: 0x0010AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x0010CB61 File Offset: 0x0010AD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x0010CB6A File Offset: 0x0010AD6A
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

		// Token: 0x06006D1C RID: 27932 RVA: 0x0010CB9C File Offset: 0x0010AD9C
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

		// Token: 0x06006D1D RID: 27933 RVA: 0x0010CBDC File Offset: 0x0010ADDC
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

		// Token: 0x06006D1E RID: 27934 RVA: 0x0010CC30 File Offset: 0x0010AE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x0010CC3C File Offset: 0x0010AE3C
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

		// Token: 0x04003B9E RID: 15262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B9F RID: 15263
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003BA0 RID: 15264
		private EntityCtxPb entityCtx_;
	}
}
