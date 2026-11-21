using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047D RID: 1149
	public sealed class EntityGroupFailureActionCtxPb : IMessage<EntityGroupFailureActionCtxPb>, IMessage, IEquatable<EntityGroupFailureActionCtxPb>, IDeepCloneable<EntityGroupFailureActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006E72 RID: 28274 RVA: 0x0010FE82 File Offset: 0x0010E082
		[NullableContext(1)]
		public static EntityGroupFailureActionCtxPb Create()
		{
			return new EntityGroupFailureActionCtxPb();
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0010FE89 File Offset: 0x0010E089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06006E74 RID: 28276 RVA: 0x0010FE8C File Offset: 0x0010E08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGroupFailureActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x0010FE93 File Offset: 0x0010E093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb()
		{
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x0010FE9B File Offset: 0x0010E09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb(EntityGroupFailureActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x0010FED0 File Offset: 0x0010E0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupFailureActionCtxPb Clone()
		{
			return new EntityGroupFailureActionCtxPb(this);
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		// (set) Token: 0x06006E79 RID: 28281 RVA: 0x0010FEE0 File Offset: 0x0010E0E0
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

		// Token: 0x06006E7A RID: 28282 RVA: 0x0010FEE9 File Offset: 0x0010E0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGroupFailureActionCtxPb);
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x0010FEF7 File Offset: 0x0010E0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGroupFailureActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x0010FF2C File Offset: 0x0010E12C
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

		// Token: 0x06006E7D RID: 28285 RVA: 0x0010FF68 File Offset: 0x0010E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x0010FF75 File Offset: 0x0010E175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x0010FF7E File Offset: 0x0010E17E
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

		// Token: 0x06006E80 RID: 28288 RVA: 0x0010FFB0 File Offset: 0x0010E1B0
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

		// Token: 0x06006E81 RID: 28289 RVA: 0x0010FFF0 File Offset: 0x0010E1F0
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

		// Token: 0x06006E82 RID: 28290 RVA: 0x00110044 File Offset: 0x0010E244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x00110050 File Offset: 0x0010E250
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

		// Token: 0x04003C08 RID: 15368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C09 RID: 15369
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C0A RID: 15370
		private EntityCtxPb entityCtx_;
	}
}
