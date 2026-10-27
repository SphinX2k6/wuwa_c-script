using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107B RID: 4219
	[NetMessage(EMessageId.RoleFavorUnLockResponse)]
	public sealed class RoleFavorUnLockResponse : IMessage<RoleFavorUnLockResponse>, IMessage, IEquatable<RoleFavorUnLockResponse>, IDeepCloneable<RoleFavorUnLockResponse>, IBufferMessage
	{
		// Token: 0x060168A8 RID: 92328 RVA: 0x00346D2B File Offset: 0x00344F2B
		[NullableContext(1)]
		public static RoleFavorUnLockResponse Create()
		{
			return new RoleFavorUnLockResponse();
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x060168A9 RID: 92329 RVA: 0x00346D32 File Offset: 0x00344F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x060168AA RID: 92330 RVA: 0x00346D35 File Offset: 0x00344F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorUnLockResponse.Descriptor;
			}
		}

		// Token: 0x060168AB RID: 92331 RVA: 0x00346D3C File Offset: 0x00344F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockResponse()
		{
		}

		// Token: 0x060168AC RID: 92332 RVA: 0x00346D44 File Offset: 0x00344F44
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

		// Token: 0x060168AD RID: 92333 RVA: 0x00346D98 File Offset: 0x00344F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorUnLockResponse Clone()
		{
			return new RoleFavorUnLockResponse(this);
		}

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x060168AE RID: 92334 RVA: 0x00346DA0 File Offset: 0x00344FA0
		// (set) Token: 0x060168AF RID: 92335 RVA: 0x00346DA8 File Offset: 0x00344FA8
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

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x060168B0 RID: 92336 RVA: 0x00346DB1 File Offset: 0x00344FB1
		// (set) Token: 0x060168B1 RID: 92337 RVA: 0x00346DB9 File Offset: 0x00344FB9
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

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x060168B2 RID: 92338 RVA: 0x00346DC2 File Offset: 0x00344FC2
		// (set) Token: 0x060168B3 RID: 92339 RVA: 0x00346DCA File Offset: 0x00344FCA
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

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x060168B4 RID: 92340 RVA: 0x00346DD3 File Offset: 0x00344FD3
		// (set) Token: 0x060168B5 RID: 92341 RVA: 0x00346DDB File Offset: 0x00344FDB
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

		// Token: 0x060168B6 RID: 92342 RVA: 0x00346DE4 File Offset: 0x00344FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorUnLockResponse);
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x00346DF4 File Offset: 0x00344FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ItemType == other.ItemType && this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x00346E60 File Offset: 0x00345060
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

		// Token: 0x060168B9 RID: 92345 RVA: 0x00346EF6 File Offset: 0x003450F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x00346F03 File Offset: 0x00345103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168BB RID: 92347 RVA: 0x00346F0C File Offset: 0x0034510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this.ItemType != FavorItemType.Word)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ItemType);
			}
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168BC RID: 92348 RVA: 0x00346FA0 File Offset: 0x003451A0
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

		// Token: 0x060168BD RID: 92349 RVA: 0x00347028 File Offset: 0x00345228
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

		// Token: 0x060168BE RID: 92350 RVA: 0x003470A0 File Offset: 0x003452A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168BF RID: 92351 RVA: 0x003470AC File Offset: 0x003452AC
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
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ItemType = (FavorItemType)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.UnLockId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040086BF RID: 34495
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086C0 RID: 34496
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x040086C1 RID: 34497
		private ErrorCode errCode_;

		// Token: 0x040086C2 RID: 34498
		public const int ItemTypeFieldNumber = 10;

		// Token: 0x040086C3 RID: 34499
		private FavorItemType itemType_;

		// Token: 0x040086C4 RID: 34500
		public const int RoleIdFieldNumber = 8;

		// Token: 0x040086C5 RID: 34501
		private int roleId_;

		// Token: 0x040086C6 RID: 34502
		public const int UnLockIdFieldNumber = 13;

		// Token: 0x040086C7 RID: 34503
		private int unLockId_;
	}
}
