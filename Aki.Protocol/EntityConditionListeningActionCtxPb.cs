using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000469 RID: 1129
	public sealed class EntityConditionListeningActionCtxPb : IMessage<EntityConditionListeningActionCtxPb>, IMessage, IEquatable<EntityConditionListeningActionCtxPb>, IDeepCloneable<EntityConditionListeningActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006CD0 RID: 27856 RVA: 0x0010C240 File Offset: 0x0010A440
		[NullableContext(1)]
		public static EntityConditionListeningActionCtxPb Create()
		{
			return new EntityConditionListeningActionCtxPb();
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x0010C247 File Offset: 0x0010A447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06006CD2 RID: 27858 RVA: 0x0010C24A File Offset: 0x0010A44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityConditionListeningActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x0010C251 File Offset: 0x0010A451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb()
		{
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x0010C25C File Offset: 0x0010A45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb(EntityConditionListeningActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.entityConditionListeningIndex_ = other.entityConditionListeningIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x0010C2A8 File Offset: 0x0010A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConditionListeningActionCtxPb Clone()
		{
			return new EntityConditionListeningActionCtxPb(this);
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06006CD6 RID: 27862 RVA: 0x0010C2B0 File Offset: 0x0010A4B0
		// (set) Token: 0x06006CD7 RID: 27863 RVA: 0x0010C2B8 File Offset: 0x0010A4B8
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06006CD8 RID: 27864 RVA: 0x0010C2C1 File Offset: 0x0010A4C1
		// (set) Token: 0x06006CD9 RID: 27865 RVA: 0x0010C2C9 File Offset: 0x0010A4C9
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

		// Token: 0x06006CDA RID: 27866 RVA: 0x0010C2D2 File Offset: 0x0010A4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityConditionListeningActionCtxPb);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x0010C2E0 File Offset: 0x0010A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityConditionListeningActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.EntityConditionListeningIndex == other.EntityConditionListeningIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x0010C330 File Offset: 0x0010A530
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

		// Token: 0x06006CDD RID: 27869 RVA: 0x0010C385 File Offset: 0x0010A585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x0010C392 File Offset: 0x0010A592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x0010C39C File Offset: 0x0010A59C
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

		// Token: 0x06006CE0 RID: 27872 RVA: 0x0010C3F8 File Offset: 0x0010A5F8
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

		// Token: 0x06006CE1 RID: 27873 RVA: 0x0010C450 File Offset: 0x0010A650
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

		// Token: 0x06006CE2 RID: 27874 RVA: 0x0010C4B8 File Offset: 0x0010A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x0010C4C4 File Offset: 0x0010A6C4
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

		// Token: 0x04003B8E RID: 15246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B8F RID: 15247
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003B90 RID: 15248
		private EntityCtxPb entityCtx_;

		// Token: 0x04003B91 RID: 15249
		public const int EntityConditionListeningIndexFieldNumber = 2;

		// Token: 0x04003B92 RID: 15250
		private int entityConditionListeningIndex_;
	}
}
