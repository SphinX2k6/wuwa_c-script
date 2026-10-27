using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106E RID: 4206
	[NetMessage(EMessageId.RoleFavorAcceptQuestResponse)]
	public sealed class RoleFavorAcceptQuestResponse : IMessage<RoleFavorAcceptQuestResponse>, IMessage, IEquatable<RoleFavorAcceptQuestResponse>, IDeepCloneable<RoleFavorAcceptQuestResponse>, IBufferMessage
	{
		// Token: 0x060167A3 RID: 92067 RVA: 0x003449E7 File Offset: 0x00342BE7
		[NullableContext(1)]
		public static RoleFavorAcceptQuestResponse Create()
		{
			return new RoleFavorAcceptQuestResponse();
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x060167A4 RID: 92068 RVA: 0x003449EE File Offset: 0x00342BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x060167A5 RID: 92069 RVA: 0x003449F1 File Offset: 0x00342BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorAcceptQuestResponse.Descriptor;
			}
		}

		// Token: 0x060167A6 RID: 92070 RVA: 0x003449F8 File Offset: 0x00342BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse()
		{
		}

		// Token: 0x060167A7 RID: 92071 RVA: 0x00344A00 File Offset: 0x00342C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse(RoleFavorAcceptQuestResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.roleId_ = other.roleId_;
			this.questType_ = other.questType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167A8 RID: 92072 RVA: 0x00344A3D File Offset: 0x00342C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorAcceptQuestResponse Clone()
		{
			return new RoleFavorAcceptQuestResponse(this);
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x060167A9 RID: 92073 RVA: 0x00344A45 File Offset: 0x00342C45
		// (set) Token: 0x060167AA RID: 92074 RVA: 0x00344A4D File Offset: 0x00342C4D
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

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x060167AB RID: 92075 RVA: 0x00344A56 File Offset: 0x00342C56
		// (set) Token: 0x060167AC RID: 92076 RVA: 0x00344A5E File Offset: 0x00342C5E
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

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x060167AD RID: 92077 RVA: 0x00344A67 File Offset: 0x00342C67
		// (set) Token: 0x060167AE RID: 92078 RVA: 0x00344A6F File Offset: 0x00342C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuestType QuestType
		{
			get
			{
				return this.questType_;
			}
			set
			{
				this.questType_ = value;
			}
		}

		// Token: 0x060167AF RID: 92079 RVA: 0x00344A78 File Offset: 0x00342C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorAcceptQuestResponse);
		}

		// Token: 0x060167B0 RID: 92080 RVA: 0x00344A88 File Offset: 0x00342C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorAcceptQuestResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.RoleId == other.RoleId && this.QuestType == other.QuestType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167B1 RID: 92081 RVA: 0x00344AE4 File Offset: 0x00342CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num ^= this.QuestType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167B2 RID: 92082 RVA: 0x00344B61 File Offset: 0x00342D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167B3 RID: 92083 RVA: 0x00344B6E File Offset: 0x00342D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167B4 RID: 92084 RVA: 0x00344B78 File Offset: 0x00342D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestType != FavorQuestType.Talk)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.QuestType);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167B5 RID: 92085 RVA: 0x00344BF0 File Offset: 0x00342DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.QuestType != FavorQuestType.Talk)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.QuestType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167B6 RID: 92086 RVA: 0x00344C60 File Offset: 0x00342E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorAcceptQuestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.QuestType != FavorQuestType.Talk)
			{
				this.QuestType = other.QuestType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167B7 RID: 92087 RVA: 0x00344CC4 File Offset: 0x00342EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167B8 RID: 92088 RVA: 0x00344CD0 File Offset: 0x00342ED0
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.QuestType = (FavorQuestType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008677 RID: 34423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008678 RID: 34424
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04008679 RID: 34425
		private ErrorCode errCode_;

		// Token: 0x0400867A RID: 34426
		public const int RoleIdFieldNumber = 14;

		// Token: 0x0400867B RID: 34427
		private int roleId_;

		// Token: 0x0400867C RID: 34428
		public const int QuestTypeFieldNumber = 7;

		// Token: 0x0400867D RID: 34429
		private FavorQuestType questType_;
	}
}
