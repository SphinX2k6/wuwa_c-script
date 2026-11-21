using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000474 RID: 1140
	[NetMessage(EMessageId.EntityEquipSkinChangeNotify)]
	public sealed class EntityEquipSkinChangeNotify : IMessage<EntityEquipSkinChangeNotify>, IMessage, IEquatable<EntityEquipSkinChangeNotify>, IDeepCloneable<EntityEquipSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06006DB8 RID: 28088 RVA: 0x0010E32B File Offset: 0x0010C52B
		[NullableContext(1)]
		public static EntityEquipSkinChangeNotify Create()
		{
			return new EntityEquipSkinChangeNotify();
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x0010E332 File Offset: 0x0010C532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06006DBA RID: 28090 RVA: 0x0010E335 File Offset: 0x0010C535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEquipSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x0010E33C File Offset: 0x0010C53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify()
		{
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x0010E344 File Offset: 0x0010C544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify(EntityEquipSkinChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleWeaponSkinComponent_ = ((other.roleWeaponSkinComponent_ != null) ? other.roleWeaponSkinComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x0010E390 File Offset: 0x0010C590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEquipSkinChangeNotify Clone()
		{
			return new EntityEquipSkinChangeNotify(this);
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x0010E398 File Offset: 0x0010C598
		// (set) Token: 0x06006DBF RID: 28095 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
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

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x0010E3A9 File Offset: 0x0010C5A9
		// (set) Token: 0x06006DC1 RID: 28097 RVA: 0x0010E3B1 File Offset: 0x0010C5B1
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

		// Token: 0x06006DC2 RID: 28098 RVA: 0x0010E3BA File Offset: 0x0010C5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEquipSkinChangeNotify);
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x0010E3C8 File Offset: 0x0010C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEquipSkinChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RoleWeaponSkinComponent, other.RoleWeaponSkinComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x0010E418 File Offset: 0x0010C618
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

		// Token: 0x06006DC5 RID: 28101 RVA: 0x0010E46D File Offset: 0x0010C66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x0010E47A File Offset: 0x0010C67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x0010E484 File Offset: 0x0010C684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.roleWeaponSkinComponent_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RoleWeaponSkinComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x0010E4E0 File Offset: 0x0010C6E0
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

		// Token: 0x06006DC9 RID: 28105 RVA: 0x0010E538 File Offset: 0x0010C738
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

		// Token: 0x06006DCA RID: 28106 RVA: 0x0010E5A0 File Offset: 0x0010C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x0010E5AC File Offset: 0x0010C7AC
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
				if (num != 40U)
				{
					if (num != 98U)
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

		// Token: 0x04003BD0 RID: 15312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BD1 RID: 15313
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003BD2 RID: 15314
		private long entityId_;

		// Token: 0x04003BD3 RID: 15315
		public const int RoleWeaponSkinComponentFieldNumber = 12;

		// Token: 0x04003BD4 RID: 15316
		private RoleWeaponSkinComponentPb roleWeaponSkinComponent_;
	}
}
