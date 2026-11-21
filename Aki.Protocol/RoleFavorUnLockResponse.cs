using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106B RID: 4203
	[NetMessage(EMessageId.RoleFavorUnLockResponse)]
	public sealed class RoleFavorUnLockResponse : IMessage<RoleFavorUnLockResponse>, IMessage, IEquatable<RoleFavorUnLockResponse>, IDeepCloneable<RoleFavorUnLockResponse>, IBufferMessage
	{
		// Token: 0x060167C3 RID: 92099 RVA: 0x00345657 File Offset: 0x00343857
		[NullableContext(1)]
		public static RoleFavorUnLockResponse Create()
		{
			return new RoleFavorUnLockResponse();
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x060167C4 RID: 92100 RVA: 0x0034565E File Offset: 0x0034385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x060167C5 RID: 92101 RVA: 0x00345661 File Offset: 0x00343861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorUnLockResponse.Descriptor;
			}
		}

		// Token: 0x060167C6 RID: 92102 RVA: 0x00345668 File Offset: 0x00343868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockResponse()
		{
		}

		// Token: 0x060167C7 RID: 92103 RVA: 0x00345670 File Offset: 0x00343870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockResponse(RoleFavorUnLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.itemType_ = other.itemType_;
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167C8 RID: 92104 RVA: 0x003456C4 File Offset: 0x003438C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockResponse Clone()
		{
			return new RoleFavorUnLockResponse(this);
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x060167C9 RID: 92105 RVA: 0x003456CC File Offset: 0x003438CC
		// (set) Token: 0x060167CA RID: 92106 RVA: 0x003456D4 File Offset: 0x003438D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x060167CB RID: 92107 RVA: 0x003456DD File Offset: 0x003438DD
		// (set) Token: 0x060167CC RID: 92108 RVA: 0x003456E5 File Offset: 0x003438E5
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

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x060167CD RID: 92109 RVA: 0x003456EE File Offset: 0x003438EE
		// (set) Token: 0x060167CE RID: 92110 RVA: 0x003456F6 File Offset: 0x003438F6
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

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x060167CF RID: 92111 RVA: 0x003456FF File Offset: 0x003438FF
		// (set) Token: 0x060167D0 RID: 92112 RVA: 0x00345707 File Offset: 0x00343907
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

		// Token: 0x060167D1 RID: 92113 RVA: 0x00345710 File Offset: 0x00343910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorUnLockResponse);
		}

		// Token: 0x060167D2 RID: 92114 RVA: 0x00345720 File Offset: 0x00343920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167D3 RID: 92115 RVA: 0x0034578C File Offset: 0x0034398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
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

		// Token: 0x060167D4 RID: 92116 RVA: 0x00345822 File Offset: 0x00343A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167D5 RID: 92117 RVA: 0x0034582F File Offset: 0x00343A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167D6 RID: 92118 RVA: 0x00345838 File Offset: 0x00343A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ItemType);
			}
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UnLockId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167D7 RID: 92119 RVA: 0x003458C8 File Offset: 0x00343AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
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

		// Token: 0x060167D8 RID: 92120 RVA: 0x00345950 File Offset: 0x00343B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorUnLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
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

		// Token: 0x060167D9 RID: 92121 RVA: 0x003459C8 File Offset: 0x00343BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167DA RID: 92122 RVA: 0x003459D4 File Offset: 0x00343BD4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ItemType = (FavorItemType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.UnLockId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040086E9 RID: 34537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086EA RID: 34538
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x040086EB RID: 34539
		private ErrorCode errCode_;

		// Token: 0x040086EC RID: 34540
		public const int ItemTypeFieldNumber = 3;

		// Token: 0x040086ED RID: 34541
		private FavorItemType itemType_;

		// Token: 0x040086EE RID: 34542
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086EF RID: 34543
		private int roleId_;

		// Token: 0x040086F0 RID: 34544
		public const int UnLockIdFieldNumber = 6;

		// Token: 0x040086F1 RID: 34545
		private int unLockId_;
	}
}
