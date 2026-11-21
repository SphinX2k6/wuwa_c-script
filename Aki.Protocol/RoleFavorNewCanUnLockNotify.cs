using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001066 RID: 4198
	[NetMessage(EMessageId.RoleFavorNewCanUnLockNotify)]
	public sealed class RoleFavorNewCanUnLockNotify : IMessage<RoleFavorNewCanUnLockNotify>, IMessage, IEquatable<RoleFavorNewCanUnLockNotify>, IDeepCloneable<RoleFavorNewCanUnLockNotify>, IBufferMessage
	{
		// Token: 0x0601675B RID: 91995 RVA: 0x003447A4 File Offset: 0x003429A4
		[NullableContext(1)]
		public static RoleFavorNewCanUnLockNotify Create()
		{
			return new RoleFavorNewCanUnLockNotify();
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x0601675C RID: 91996 RVA: 0x003447AB File Offset: 0x003429AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x0601675D RID: 91997 RVA: 0x003447AE File Offset: 0x003429AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorNewCanUnLockNotify.Descriptor;
			}
		}

		// Token: 0x0601675E RID: 91998 RVA: 0x003447B5 File Offset: 0x003429B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify()
		{
		}

		// Token: 0x0601675F RID: 91999 RVA: 0x003447BD File Offset: 0x003429BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify(RoleFavorNewCanUnLockNotify other) : this()
		{
			this.itemType_ = other.itemType_;
			this.roleId_ = other.roleId_;
			this.canUnLockId_ = other.canUnLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016760 RID: 92000 RVA: 0x003447FA File Offset: 0x003429FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify Clone()
		{
			return new RoleFavorNewCanUnLockNotify(this);
		}

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x06016761 RID: 92001 RVA: 0x00344802 File Offset: 0x00342A02
		// (set) Token: 0x06016762 RID: 92002 RVA: 0x0034480A File Offset: 0x00342A0A
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

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x06016763 RID: 92003 RVA: 0x00344813 File Offset: 0x00342A13
		// (set) Token: 0x06016764 RID: 92004 RVA: 0x0034481B File Offset: 0x00342A1B
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

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x06016765 RID: 92005 RVA: 0x00344824 File Offset: 0x00342A24
		// (set) Token: 0x06016766 RID: 92006 RVA: 0x0034482C File Offset: 0x00342A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanUnLockId
		{
			get
			{
				return this.canUnLockId_;
			}
			set
			{
				this.canUnLockId_ = value;
			}
		}

		// Token: 0x06016767 RID: 92007 RVA: 0x00344835 File Offset: 0x00342A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorNewCanUnLockNotify);
		}

		// Token: 0x06016768 RID: 92008 RVA: 0x00344844 File Offset: 0x00342A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorNewCanUnLockNotify other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.CanUnLockId == other.CanUnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016769 RID: 92009 RVA: 0x003448A0 File Offset: 0x00342AA0
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
			if (this.CanUnLockId != 0)
			{
				num ^= this.CanUnLockId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601676A RID: 92010 RVA: 0x00344917 File Offset: 0x00342B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601676B RID: 92011 RVA: 0x00344924 File Offset: 0x00342B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601676C RID: 92012 RVA: 0x00344930 File Offset: 0x00342B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanUnLockId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CanUnLockId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ItemType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601676D RID: 92013 RVA: 0x003449A8 File Offset: 0x00342BA8
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
			if (this.CanUnLockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanUnLockId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601676E RID: 92014 RVA: 0x00344A18 File Offset: 0x00342C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorNewCanUnLockNotify other)
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
			if (other.CanUnLockId != 0)
			{
				this.CanUnLockId = other.CanUnLockId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601676F RID: 92015 RVA: 0x00344A7C File Offset: 0x00342C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016770 RID: 92016 RVA: 0x00344A88 File Offset: 0x00342C88
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.CanUnLockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086CC RID: 34508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086CD RID: 34509
		public const int ItemTypeFieldNumber = 11;

		// Token: 0x040086CE RID: 34510
		private FavorItemType itemType_;

		// Token: 0x040086CF RID: 34511
		public const int RoleIdFieldNumber = 10;

		// Token: 0x040086D0 RID: 34512
		private int roleId_;

		// Token: 0x040086D1 RID: 34513
		public const int CanUnLockIdFieldNumber = 6;

		// Token: 0x040086D2 RID: 34514
		private int canUnLockId_;
	}
}
