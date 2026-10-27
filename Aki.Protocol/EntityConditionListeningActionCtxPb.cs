using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000480 RID: 1152
	public sealed class EntityConditionListeningActionCtxPb : IMessage<EntityConditionListeningActionCtxPb>, IMessage, IEquatable<EntityConditionListeningActionCtxPb>, IDeepCloneable<EntityConditionListeningActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006E5E RID: 28254 RVA: 0x0010F2B4 File Offset: 0x0010D4B4
		[NullableContext(1)]
		public static EntityConditionListeningActionCtxPb Create()
		{
			return new EntityConditionListeningActionCtxPb();
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x0010F2BB File Offset: 0x0010D4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x0010F2BE File Offset: 0x0010D4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityConditionListeningActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x0010F2C5 File Offset: 0x0010D4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb()
		{
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x0010F2D0 File Offset: 0x0010D4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb(EntityConditionListeningActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.entityConditionListeningIndex_ = other.entityConditionListeningIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x0010F31C File Offset: 0x0010D51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb Clone()
		{
			return new EntityConditionListeningActionCtxPb(this);
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x0010F324 File Offset: 0x0010D524
		// (set) Token: 0x06006E65 RID: 28261 RVA: 0x0010F32C File Offset: 0x0010D52C
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

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x0010F335 File Offset: 0x0010D535
		// (set) Token: 0x06006E67 RID: 28263 RVA: 0x0010F33D File Offset: 0x0010D53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConditionListeningIndex
		{
			get
			{
				return this.entityConditionListeningIndex_;
			}
			set
			{
				this.entityConditionListeningIndex_ = value;
			}
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x0010F346 File Offset: 0x0010D546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityConditionListeningActionCtxPb);
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x0010F354 File Offset: 0x0010D554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityConditionListeningActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.EntityConditionListeningIndex == other.EntityConditionListeningIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.EntityConditionListeningIndex != 0)
			{
				num ^= this.EntityConditionListeningIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x0010F3F9 File Offset: 0x0010D5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x0010F406 File Offset: 0x0010D606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0010F410 File Offset: 0x0010D610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.EntityConditionListeningIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityConditionListeningIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x0010F46C File Offset: 0x0010D66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.EntityConditionListeningIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConditionListeningIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E6F RID: 28271 RVA: 0x0010F4C4 File Offset: 0x0010D6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityConditionListeningActionCtxPb other)
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
			if (other.EntityConditionListeningIndex != 0)
			{
				this.EntityConditionListeningIndex = other.EntityConditionListeningIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x0010F52C File Offset: 0x0010D72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x0010F538 File Offset: 0x0010D738
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
						this.EntityConditionListeningIndex = input.ReadInt32();
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

		// Token: 0x04003BA0 RID: 15264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA1 RID: 15265
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003BA2 RID: 15266
		private EntityCtxPb entityCtx_;

		// Token: 0x04003BA3 RID: 15267
		public const int EntityConditionListeningIndexFieldNumber = 2;

		// Token: 0x04003BA4 RID: 15268
		private int entityConditionListeningIndex_;
	}
}
