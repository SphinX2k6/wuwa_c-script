using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107A RID: 4218
	[NetMessage(EMessageId.RoleFavorUnLockRequest)]
	public sealed class RoleFavorUnLockRequest : IMessage<RoleFavorUnLockRequest>, IMessage, IEquatable<RoleFavorUnLockRequest>, IDeepCloneable<RoleFavorUnLockRequest>, IBufferMessage
	{
		// Token: 0x06016892 RID: 92306 RVA: 0x003469DC File Offset: 0x00344BDC
		[NullableContext(1)]
		public static RoleFavorUnLockRequest Create()
		{
			return new RoleFavorUnLockRequest();
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x06016893 RID: 92307 RVA: 0x003469E3 File Offset: 0x00344BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x06016894 RID: 92308 RVA: 0x003469E6 File Offset: 0x00344BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorUnLockRequest.Descriptor;
			}
		}

		// Token: 0x06016895 RID: 92309 RVA: 0x003469ED File Offset: 0x00344BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest()
		{
		}

		// Token: 0x06016896 RID: 92310 RVA: 0x003469F5 File Offset: 0x00344BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest(RoleFavorUnLockRequest other) : this()
		{
			this.itemType_ = other.itemType_;
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016897 RID: 92311 RVA: 0x00346A32 File Offset: 0x00344C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockRequest Clone()
		{
			return new RoleFavorUnLockRequest(this);
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x06016898 RID: 92312 RVA: 0x00346A3A File Offset: 0x00344C3A
		// (set) Token: 0x06016899 RID: 92313 RVA: 0x00346A42 File Offset: 0x00344C42
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

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x0601689A RID: 92314 RVA: 0x00346A4B File Offset: 0x00344C4B
		// (set) Token: 0x0601689B RID: 92315 RVA: 0x00346A53 File Offset: 0x00344C53
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

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x0601689C RID: 92316 RVA: 0x00346A5C File Offset: 0x00344C5C
		// (set) Token: 0x0601689D RID: 92317 RVA: 0x00346A64 File Offset: 0x00344C64
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

		// Token: 0x0601689E RID: 92318 RVA: 0x00346A6D File Offset: 0x00344C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorUnLockRequest);
		}

		// Token: 0x0601689F RID: 92319 RVA: 0x00346A7C File Offset: 0x00344C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorUnLockRequest other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168A0 RID: 92320 RVA: 0x00346AD8 File Offset: 0x00344CD8
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

		// Token: 0x060168A1 RID: 92321 RVA: 0x00346B4F File Offset: 0x00344D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168A2 RID: 92322 RVA: 0x00346B5C File Offset: 0x00344D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168A3 RID: 92323 RVA: 0x00346B68 File Offset: 0x00344D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ItemType);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168A4 RID: 92324 RVA: 0x00346BE0 File Offset: 0x00344DE0
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

		// Token: 0x060168A5 RID: 92325 RVA: 0x00346C50 File Offset: 0x00344E50
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

		// Token: 0x060168A6 RID: 92326 RVA: 0x00346CB4 File Offset: 0x00344EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168A7 RID: 92327 RVA: 0x00346CC0 File Offset: 0x00344EC0
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
				if (num != 24U)
				{
					if (num != 80U)
					{
						if (num != 96U)
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
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemType = (FavorItemType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040086B8 RID: 34488
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086B9 RID: 34489
		public const int ItemTypeFieldNumber = 3;

		// Token: 0x040086BA RID: 34490
		private FavorItemType itemType_;

		// Token: 0x040086BB RID: 34491
		public const int RoleIdFieldNumber = 10;

		// Token: 0x040086BC RID: 34492
		private int roleId_;

		// Token: 0x040086BD RID: 34493
		public const int UnLockIdFieldNumber = 12;

		// Token: 0x040086BE RID: 34494
		private int unLockId_;
	}
}
