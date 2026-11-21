using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000462 RID: 1122
	public sealed class EntityBulletComponentPb : IMessage<EntityBulletComponentPb>, IMessage, IEquatable<EntityBulletComponentPb>, IDeepCloneable<EntityBulletComponentPb>, IBufferMessage
	{
		// Token: 0x06006B7E RID: 27518 RVA: 0x001040ED File Offset: 0x001022ED
		[NullableContext(1)]
		public static EntityBulletComponentPb Create()
		{
			return new EntityBulletComponentPb();
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06006B7F RID: 27519 RVA: 0x001040F4 File Offset: 0x001022F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x001040F7 File Offset: 0x001022F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBulletComponentPb.Descriptor;
			}
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x001040FE File Offset: 0x001022FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb()
		{
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00104106 File Offset: 0x00102306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb(EntityBulletComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x0010412B File Offset: 0x0010232B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb Clone()
		{
			return new EntityBulletComponentPb(this);
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x00104133 File Offset: 0x00102333
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x0010413B File Offset: 0x0010233B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00104144 File Offset: 0x00102344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBulletComponentPb);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00104152 File Offset: 0x00102352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBulletComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00104180 File Offset: 0x00102380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x001041BF File Offset: 0x001023BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x001041CC File Offset: 0x001023CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x001041D5 File Offset: 0x001023D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x00104208 File Offset: 0x00102408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00104246 File Offset: 0x00102446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBulletComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00104277 File Offset: 0x00102477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x00104280 File Offset: 0x00102480
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B07 RID: 15111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B08 RID: 15112
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04003B09 RID: 15113
		private long contextId_;
	}
}
