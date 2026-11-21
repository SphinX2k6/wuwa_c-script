using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106A RID: 4202
	[NetMessage(EMessageId.RoleFavorUnLockRequest)]
	public sealed class RoleFavorUnLockRequest : IMessage<RoleFavorUnLockRequest>, IMessage, IEquatable<RoleFavorUnLockRequest>, IDeepCloneable<RoleFavorUnLockRequest>, IBufferMessage
	{
		// Token: 0x060167AD RID: 92077 RVA: 0x00345308 File Offset: 0x00343508
		[NullableContext(1)]
		public static RoleFavorUnLockRequest Create()
		{
			return new RoleFavorUnLockRequest();
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x060167AE RID: 92078 RVA: 0x0034530F File Offset: 0x0034350F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x060167AF RID: 92079 RVA: 0x00345312 File Offset: 0x00343512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorUnLockRequest.Descriptor;
			}
		}

		// Token: 0x060167B0 RID: 92080 RVA: 0x00345319 File Offset: 0x00343519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest()
		{
		}

		// Token: 0x060167B1 RID: 92081 RVA: 0x00345321 File Offset: 0x00343521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest(RoleFavorUnLockRequest other) : this()
		{
			this.itemType_ = other.itemType_;
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167B2 RID: 92082 RVA: 0x0034535E File Offset: 0x0034355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest Clone()
		{
			return new RoleFavorUnLockRequest(this);
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x060167B3 RID: 92083 RVA: 0x00345366 File Offset: 0x00343566
		// (set) Token: 0x060167B4 RID: 92084 RVA: 0x0034536E File Offset: 0x0034356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorItemType ItemType
		{
			get
			{
				return this.itemType_;
			}
			set
			{
				this.itemType_ = value;
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x060167B5 RID: 92085 RVA: 0x00345377 File Offset: 0x00343577
		// (set) Token: 0x060167B6 RID: 92086 RVA: 0x0034537F File Offset: 0x0034357F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x060167B7 RID: 92087 RVA: 0x00345388 File Offset: 0x00343588
		// (set) Token: 0x060167B8 RID: 92088 RVA: 0x00345390 File Offset: 0x00343590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockId
		{
			get
			{
				return this.unLockId_;
			}
			set
			{
				this.unLockId_ = value;
			}
		}

		// Token: 0x060167B9 RID: 92089 RVA: 0x00345399 File Offset: 0x00343599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorUnLockRequest);
		}

		// Token: 0x060167BA RID: 92090 RVA: 0x003453A8 File Offset: 0x003435A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorUnLockRequest other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167BB RID: 92091 RVA: 0x00345404 File Offset: 0x00343604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemType != FavorItemType.Word)
			{
				num ^= this.ItemType.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.UnLockId != 0)
			{
				num ^= this.UnLockId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167BC RID: 92092 RVA: 0x0034547B File Offset: 0x0034367B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167BD RID: 92093 RVA: 0x00345488 File Offset: 0x00343688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167BE RID: 92094 RVA: 0x00345494 File Offset: 0x00343694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ItemType);
			}
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167BF RID: 92095 RVA: 0x0034550C File Offset: 0x0034370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemType != FavorItemType.Word)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ItemType);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.UnLockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167C0 RID: 92096 RVA: 0x0034557C File Offset: 0x0034377C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorUnLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemType != FavorItemType.Word)
			{
				this.ItemType = other.ItemType;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.UnLockId != 0)
			{
				this.UnLockId = other.UnLockId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167C1 RID: 92097 RVA: 0x003455E0 File Offset: 0x003437E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167C2 RID: 92098 RVA: 0x003455EC File Offset: 0x003437EC
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnLockId = input.ReadInt32();
						}
					}
					else
					{
						this.ItemType = (FavorItemType)input.ReadEnum();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086E2 RID: 34530
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086E3 RID: 34531
		public const int ItemTypeFieldNumber = 9;

		// Token: 0x040086E4 RID: 34532
		private FavorItemType itemType_;

		// Token: 0x040086E5 RID: 34533
		public const int RoleIdFieldNumber = 4;

		// Token: 0x040086E6 RID: 34534
		private int roleId_;

		// Token: 0x040086E7 RID: 34535
		public const int UnLockIdFieldNumber = 14;

		// Token: 0x040086E8 RID: 34536
		private int unLockId_;
	}
}
