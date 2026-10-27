using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F3 RID: 755
	[NetMessage(EMessageId.CookFoodResponse)]
	public sealed class CookFoodResponse : IMessage<CookFoodResponse>, IMessage, IEquatable<CookFoodResponse>, IDeepCloneable<CookFoodResponse>, IBufferMessage
	{
		// Token: 0x06004C89 RID: 19593 RVA: 0x000BA2D8 File Offset: 0x000B84D8
		[NullableContext(1)]
		public static CookFoodResponse Create()
		{
			return new CookFoodResponse();
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x000BA2DF File Offset: 0x000B84DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x000BA2E2 File Offset: 0x000B84E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFoodResponse.Descriptor;
			}
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x000BA2E9 File Offset: 0x000B84E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodResponse()
		{
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000BA308 File Offset: 0x000B8508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodResponse(CookFoodResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this.activeSkillType_ = other.activeSkillType_;
			this.extraItemInfos_ = other.extraItemInfos_.Clone();
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x000BA37E File Offset: 0x000B857E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodResponse Clone()
		{
			return new CookFoodResponse(this);
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x000BA386 File Offset: 0x000B8586
		// (set) Token: 0x06004C90 RID: 19600 RVA: 0x000BA38E File Offset: 0x000B858E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x000BA397 File Offset: 0x000B8597
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x000BA39F File Offset: 0x000B859F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x000BA3A8 File Offset: 0x000B85A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x000BA3B0 File Offset: 0x000B85B0
		// (set) Token: 0x06004C95 RID: 19605 RVA: 0x000BA3B8 File Offset: 0x000B85B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveSkillType
		{
			get
			{
				return this.activeSkillType_;
			}
			set
			{
				this.activeSkillType_ = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x000BA3C1 File Offset: 0x000B85C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x000BA3C9 File Offset: 0x000B85C9
		// (set) Token: 0x06004C98 RID: 19608 RVA: 0x000BA3D1 File Offset: 0x000B85D1
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

		// Token: 0x06004C99 RID: 19609 RVA: 0x000BA3DA File Offset: 0x000B85DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFoodResponse);
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x000BA3E8 File Offset: 0x000B85E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFoodResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x000BA47C File Offset: 0x000B867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.itemInfos_.GetHashCode();
			if (this.ActiveSkillType != 0)
			{
				num ^= this.ActiveSkillType.GetHashCode();
			}
			num ^= this.extraItemInfos_.GetHashCode();
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x000BA528 File Offset: 0x000B8728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x000BA535 File Offset: 0x000B8735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x000BA540 File Offset: 0x000B8740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemInfos_.WriteTo(ref output, CookFoodResponse._repeated_itemInfos_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			this.extraItemInfos_.WriteTo(ref output, CookFoodResponse._repeated_extraItemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActiveSkillType);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x000BA5F4 File Offset: 0x000B87F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.itemInfos_.CalculateSize(CookFoodResponse._repeated_itemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveSkillType);
			}
			num += this.extraItemInfos_.CalculateSize(CookFoodResponse._repeated_extraItemInfos_codec);
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x000BA6A0 File Offset: 0x000B88A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookFoodResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.itemInfos_.Add(other.itemInfos_);
			if (other.ActiveSkillType != 0)
			{
				this.ActiveSkillType = other.ActiveSkillType;
			}
			this.extraItemInfos_.Add(other.extraItemInfos_);
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x000BA73A File Offset: 0x000B893A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x000BA744 File Offset: 0x000B8944
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
				if (num <= 50U)
				{
					if (num == 26U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, CookFoodResponse._repeated_itemInfos_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, CookFoodResponse._repeated_extraItemInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ActiveSkillType = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003102 RID: 12546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003103 RID: 12547
		public const int CodeFieldNumber = 9;

		// Token: 0x04003104 RID: 12548
		private ErrorCode code_;

		// Token: 0x04003105 RID: 12549
		public const int IdFieldNumber = 10;

		// Token: 0x04003106 RID: 12550
		private int id_;

		// Token: 0x04003107 RID: 12551
		public const int ItemInfosFieldNumber = 3;

		// Token: 0x04003108 RID: 12552
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(26U, SingleItemInfo.Parser);

		// Token: 0x04003109 RID: 12553
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x0400310A RID: 12554
		public const int ActiveSkillTypeFieldNumber = 8;

		// Token: 0x0400310B RID: 12555
		private int activeSkillType_;

		// Token: 0x0400310C RID: 12556
		public const int ExtraItemInfosFieldNumber = 6;

		// Token: 0x0400310D RID: 12557
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(50U, SingleItemInfo.Parser);

		// Token: 0x0400310E RID: 12558
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x0400310F RID: 12559
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04003110 RID: 12560
		private int roleId_;
	}
}
