using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001076 RID: 4214
	[NetMessage(EMessageId.RoleFavorNewCanUnLockNotify)]
	public sealed class RoleFavorNewCanUnLockNotify : IMessage<RoleFavorNewCanUnLockNotify>, IMessage, IEquatable<RoleFavorNewCanUnLockNotify>, IDeepCloneable<RoleFavorNewCanUnLockNotify>, IBufferMessage
	{
		// Token: 0x06016840 RID: 92224 RVA: 0x00345E78 File Offset: 0x00344078
		[NullableContext(1)]
		public static RoleFavorNewCanUnLockNotify Create()
		{
			return new RoleFavorNewCanUnLockNotify();
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06016841 RID: 92225 RVA: 0x00345E7F File Offset: 0x0034407F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06016842 RID: 92226 RVA: 0x00345E82 File Offset: 0x00344082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorNewCanUnLockNotify.Descriptor;
			}
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x00345E89 File Offset: 0x00344089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify()
		{
		}

		// Token: 0x06016844 RID: 92228 RVA: 0x00345E91 File Offset: 0x00344091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify(RoleFavorNewCanUnLockNotify other) : this()
		{
			this.itemType_ = other.itemType_;
			this.roleId_ = other.roleId_;
			this.canUnLockId_ = other.canUnLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016845 RID: 92229 RVA: 0x00345ECE File Offset: 0x003440CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorNewCanUnLockNotify Clone()
		{
			return new RoleFavorNewCanUnLockNotify(this);
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x06016846 RID: 92230 RVA: 0x00345ED6 File Offset: 0x003440D6
		// (set) Token: 0x06016847 RID: 92231 RVA: 0x00345EDE File Offset: 0x003440DE
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

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x06016848 RID: 92232 RVA: 0x00345EE7 File Offset: 0x003440E7
		// (set) Token: 0x06016849 RID: 92233 RVA: 0x00345EEF File Offset: 0x003440EF
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

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x0601684A RID: 92234 RVA: 0x00345EF8 File Offset: 0x003440F8
		// (set) Token: 0x0601684B RID: 92235 RVA: 0x00345F00 File Offset: 0x00344100
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

		// Token: 0x0601684C RID: 92236 RVA: 0x00345F09 File Offset: 0x00344109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorNewCanUnLockNotify);
		}

		// Token: 0x0601684D RID: 92237 RVA: 0x00345F18 File Offset: 0x00344118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorNewCanUnLockNotify other)
		{
			return other != null && (other == this || (this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.CanUnLockId == other.CanUnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601684E RID: 92238 RVA: 0x00345F74 File Offset: 0x00344174
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

		// Token: 0x0601684F RID: 92239 RVA: 0x00345FEB File Offset: 0x003441EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016850 RID: 92240 RVA: 0x00345FF8 File Offset: 0x003441F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016851 RID: 92241 RVA: 0x00346004 File Offset: 0x00344204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanUnLockId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CanUnLockId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ItemType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016852 RID: 92242 RVA: 0x0034607C File Offset: 0x0034427C
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

		// Token: 0x06016853 RID: 92243 RVA: 0x003460EC File Offset: 0x003442EC
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

		// Token: 0x06016854 RID: 92244 RVA: 0x00346150 File Offset: 0x00344350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016855 RID: 92245 RVA: 0x0034615C File Offset: 0x0034435C
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
					if (num != 48U)
					{
						if (num != 96U)
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

		// Token: 0x040086A2 RID: 34466
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086A3 RID: 34467
		public const int ItemTypeFieldNumber = 12;

		// Token: 0x040086A4 RID: 34468
		private FavorItemType itemType_;

		// Token: 0x040086A5 RID: 34469
		public const int RoleIdFieldNumber = 6;

		// Token: 0x040086A6 RID: 34470
		private int roleId_;

		// Token: 0x040086A7 RID: 34471
		public const int CanUnLockIdFieldNumber = 2;

		// Token: 0x040086A8 RID: 34472
		private int canUnLockId_;
	}
}
