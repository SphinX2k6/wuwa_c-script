using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048B RID: 1163
	[NetMessage(EMessageId.EntityEquipSkinChangeNotify)]
	public sealed class EntityEquipSkinChangeNotify : IMessage<EntityEquipSkinChangeNotify>, IMessage, IEquatable<EntityEquipSkinChangeNotify>, IDeepCloneable<EntityEquipSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06006F46 RID: 28486 RVA: 0x0011139F File Offset: 0x0010F59F
		[NullableContext(1)]
		public static EntityEquipSkinChangeNotify Create()
		{
			return new EntityEquipSkinChangeNotify();
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x001113A6 File Offset: 0x0010F5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x001113A9 File Offset: 0x0010F5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEquipSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x001113B0 File Offset: 0x0010F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify()
		{
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x001113B8 File Offset: 0x0010F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify(EntityEquipSkinChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleWeaponSkinComponent_ = ((other.roleWeaponSkinComponent_ != null) ? other.roleWeaponSkinComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00111404 File Offset: 0x0010F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify Clone()
		{
			return new EntityEquipSkinChangeNotify(this);
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06006F4C RID: 28492 RVA: 0x0011140C File Offset: 0x0010F60C
		// (set) Token: 0x06006F4D RID: 28493 RVA: 0x00111414 File Offset: 0x0010F614
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

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x0011141D File Offset: 0x0010F61D
		// (set) Token: 0x06006F4F RID: 28495 RVA: 0x00111425 File Offset: 0x0010F625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb RoleWeaponSkinComponent
		{
			get
			{
				return this.roleWeaponSkinComponent_;
			}
			set
			{
				this.roleWeaponSkinComponent_ = value;
			}
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x0011142E File Offset: 0x0010F62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEquipSkinChangeNotify);
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x0011143C File Offset: 0x0010F63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEquipSkinChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RoleWeaponSkinComponent, other.RoleWeaponSkinComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0011148C File Offset: 0x0010F68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.roleWeaponSkinComponent_ != null)
			{
				num ^= this.RoleWeaponSkinComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x001114E1 File Offset: 0x0010F6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x001114EE File Offset: 0x0010F6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x001114F8 File Offset: 0x0010F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.roleWeaponSkinComponent_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RoleWeaponSkinComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00111554 File Offset: 0x0010F754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.roleWeaponSkinComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleWeaponSkinComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x001115AC File Offset: 0x0010F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityEquipSkinChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.roleWeaponSkinComponent_ != null)
			{
				if (this.roleWeaponSkinComponent_ == null)
				{
					this.RoleWeaponSkinComponent = new RoleWeaponSkinComponentPb();
				}
				this.RoleWeaponSkinComponent.MergeFrom(other.RoleWeaponSkinComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00111614 File Offset: 0x0010F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x00111620 File Offset: 0x0010F820
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
				if (num != 16U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.roleWeaponSkinComponent_ == null)
						{
							this.RoleWeaponSkinComponent = new RoleWeaponSkinComponentPb();
						}
						input.ReadMessage(this.RoleWeaponSkinComponent);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BE2 RID: 15330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE3 RID: 15331
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003BE4 RID: 15332
		private long entityId_;

		// Token: 0x04003BE5 RID: 15333
		public const int RoleWeaponSkinComponentFieldNumber = 4;

		// Token: 0x04003BE6 RID: 15334
		private RoleWeaponSkinComponentPb roleWeaponSkinComponent_;
	}
}
