using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048A RID: 1162
	[NetMessage(EMessageId.EntityEquipChangeNotify)]
	public sealed class EntityEquipChangeNotify : IMessage<EntityEquipChangeNotify>, IMessage, IEquatable<EntityEquipChangeNotify>, IDeepCloneable<EntityEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x06006F32 RID: 28466 RVA: 0x001110B1 File Offset: 0x0010F2B1
		[NullableContext(1)]
		public static EntityEquipChangeNotify Create()
		{
			return new EntityEquipChangeNotify();
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06006F33 RID: 28467 RVA: 0x001110B8 File Offset: 0x0010F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x001110BB File Offset: 0x0010F2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x001110C2 File Offset: 0x0010F2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify()
		{
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x001110CC File Offset: 0x0010F2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify(EntityEquipChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.equipComponent_ = ((other.equipComponent_ != null) ? other.equipComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00111118 File Offset: 0x0010F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify Clone()
		{
			return new EntityEquipChangeNotify(this);
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x00111120 File Offset: 0x0010F320
		// (set) Token: 0x06006F39 RID: 28473 RVA: 0x00111128 File Offset: 0x0010F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x00111131 File Offset: 0x0010F331
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x00111139 File Offset: 0x0010F339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb EquipComponent
		{
			get
			{
				return this.equipComponent_;
			}
			set
			{
				this.equipComponent_ = value;
			}
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x00111142 File Offset: 0x0010F342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEquipChangeNotify);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x00111150 File Offset: 0x0010F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEquipChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.EquipComponent, other.EquipComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x001111A0 File Offset: 0x0010F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.equipComponent_ != null)
			{
				num ^= this.EquipComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x001111F5 File Offset: 0x0010F3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00111202 File Offset: 0x0010F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x0011120C File Offset: 0x0010F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.equipComponent_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EquipComponent);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x00111268 File Offset: 0x0010F468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.equipComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EquipComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x001112C0 File Offset: 0x0010F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityEquipChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.equipComponent_ != null)
			{
				if (this.equipComponent_ == null)
				{
					this.EquipComponent = new EquipComponentPb();
				}
				this.EquipComponent.MergeFrom(other.EquipComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x00111328 File Offset: 0x0010F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x00111334 File Offset: 0x0010F534
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
				if (num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.equipComponent_ == null)
					{
						this.EquipComponent = new EquipComponentPb();
					}
					input.ReadMessage(this.EquipComponent);
				}
			}
		}

		// Token: 0x04003BDD RID: 15325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BDE RID: 15326
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003BDF RID: 15327
		private long entityId_;

		// Token: 0x04003BE0 RID: 15328
		public const int EquipComponentFieldNumber = 5;

		// Token: 0x04003BE1 RID: 15329
		private EquipComponentPb equipComponent_;
	}
}
