using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000473 RID: 1139
	[NetMessage(EMessageId.EntityEquipChangeNotify)]
	public sealed class EntityEquipChangeNotify : IMessage<EntityEquipChangeNotify>, IMessage, IEquatable<EntityEquipChangeNotify>, IDeepCloneable<EntityEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x06006DA4 RID: 28068 RVA: 0x0010E03D File Offset: 0x0010C23D
		[NullableContext(1)]
		public static EntityEquipChangeNotify Create()
		{
			return new EntityEquipChangeNotify();
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x0010E044 File Offset: 0x0010C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06006DA6 RID: 28070 RVA: 0x0010E047 File Offset: 0x0010C247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x0010E04E File Offset: 0x0010C24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify()
		{
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x0010E058 File Offset: 0x0010C258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify(EntityEquipChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.equipComponent_ = ((other.equipComponent_ != null) ? other.equipComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x0010E0A4 File Offset: 0x0010C2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipChangeNotify Clone()
		{
			return new EntityEquipChangeNotify(this);
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x0010E0AC File Offset: 0x0010C2AC
		// (set) Token: 0x06006DAB RID: 28075 RVA: 0x0010E0B4 File Offset: 0x0010C2B4
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

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06006DAC RID: 28076 RVA: 0x0010E0BD File Offset: 0x0010C2BD
		// (set) Token: 0x06006DAD RID: 28077 RVA: 0x0010E0C5 File Offset: 0x0010C2C5
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

		// Token: 0x06006DAE RID: 28078 RVA: 0x0010E0CE File Offset: 0x0010C2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEquipChangeNotify);
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x0010E0DC File Offset: 0x0010C2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEquipChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.EquipComponent, other.EquipComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x0010E12C File Offset: 0x0010C32C
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

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0010E181 File Offset: 0x0010C381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x0010E18E File Offset: 0x0010C38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x0010E198 File Offset: 0x0010C398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.equipComponent_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.EquipComponent);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x0010E1F4 File Offset: 0x0010C3F4
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

		// Token: 0x06006DB5 RID: 28085 RVA: 0x0010E24C File Offset: 0x0010C44C
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

		// Token: 0x06006DB6 RID: 28086 RVA: 0x0010E2B4 File Offset: 0x0010C4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x0010E2C0 File Offset: 0x0010C4C0
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
				if (num != 58U)
				{
					if (num != 88U)
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

		// Token: 0x04003BCB RID: 15307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BCC RID: 15308
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003BCD RID: 15309
		private long entityId_;

		// Token: 0x04003BCE RID: 15310
		public const int EquipComponentFieldNumber = 7;

		// Token: 0x04003BCF RID: 15311
		private EquipComponentPb equipComponent_;
	}
}
