using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046A RID: 1130
	public sealed class EntityAfterConditionActionCtxPb : IMessage<EntityAfterConditionActionCtxPb>, IMessage, IEquatable<EntityAfterConditionActionCtxPb>, IDeepCloneable<EntityAfterConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006BC6 RID: 27590 RVA: 0x00103F11 File Offset: 0x00102111
		[NullableContext(1)]
		public static EntityAfterConditionActionCtxPb Create()
		{
			return new EntityAfterConditionActionCtxPb();
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00103F18 File Offset: 0x00102118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x00103F1B File Offset: 0x0010211B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAfterConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00103F22 File Offset: 0x00102122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb()
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00103F2C File Offset: 0x0010212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb(EntityAfterConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.preConditionListeningIndex_ = other.preConditionListeningIndex_;
			this.afterConditionActionIndex_ = other.afterConditionActionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00103F84 File Offset: 0x00102184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAfterConditionActionCtxPb Clone()
		{
			return new EntityAfterConditionActionCtxPb(this);
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06006BCC RID: 27596 RVA: 0x00103F8C File Offset: 0x0010218C
		// (set) Token: 0x06006BCD RID: 27597 RVA: 0x00103F94 File Offset: 0x00102194
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

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06006BCE RID: 27598 RVA: 0x00103F9D File Offset: 0x0010219D
		// (set) Token: 0x06006BCF RID: 27599 RVA: 0x00103FA5 File Offset: 0x001021A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreConditionListeningIndex
		{
			get
			{
				return this.preConditionListeningIndex_;
			}
			set
			{
				this.preConditionListeningIndex_ = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x00103FAE File Offset: 0x001021AE
		// (set) Token: 0x06006BD1 RID: 27601 RVA: 0x00103FB6 File Offset: 0x001021B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterConditionActionIndex
		{
			get
			{
				return this.afterConditionActionIndex_;
			}
			set
			{
				this.afterConditionActionIndex_ = value;
			}
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00103FBF File Offset: 0x001021BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAfterConditionActionCtxPb);
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00103FD0 File Offset: 0x001021D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAfterConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.PreConditionListeningIndex == other.PreConditionListeningIndex && this.AfterConditionActionIndex == other.AfterConditionActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00104030 File Offset: 0x00102230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.PreConditionListeningIndex != 0)
			{
				num ^= this.PreConditionListeningIndex.GetHashCode();
			}
			if (this.AfterConditionActionIndex != 0)
			{
				num ^= this.AfterConditionActionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0010409E File Offset: 0x0010229E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x001040AB File Offset: 0x001022AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x001040B4 File Offset: 0x001022B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.PreConditionListeningIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PreConditionListeningIndex);
			}
			if (this.AfterConditionActionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AfterConditionActionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x0010412C File Offset: 0x0010232C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.PreConditionListeningIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreConditionListeningIndex);
			}
			if (this.AfterConditionActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterConditionActionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x0010419C File Offset: 0x0010239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAfterConditionActionCtxPb other)
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
			if (other.PreConditionListeningIndex != 0)
			{
				this.PreConditionListeningIndex = other.PreConditionListeningIndex;
			}
			if (other.AfterConditionActionIndex != 0)
			{
				this.AfterConditionActionIndex = other.AfterConditionActionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x00104218 File Offset: 0x00102418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00104224 File Offset: 0x00102424
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AfterConditionActionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.PreConditionListeningIndex = input.ReadInt32();
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

		// Token: 0x04003AAE RID: 15022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AAF RID: 15023
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003AB0 RID: 15024
		private EntityCtxPb entityCtx_;

		// Token: 0x04003AB1 RID: 15025
		public const int PreConditionListeningIndexFieldNumber = 2;

		// Token: 0x04003AB2 RID: 15026
		private int preConditionListeningIndex_;

		// Token: 0x04003AB3 RID: 15027
		public const int AfterConditionActionIndexFieldNumber = 3;

		// Token: 0x04003AB4 RID: 15028
		private int afterConditionActionIndex_;
	}
}
