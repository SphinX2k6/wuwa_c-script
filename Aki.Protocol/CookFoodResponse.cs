using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FA RID: 762
	[NetMessage(EMessageId.CookFoodResponse)]
	public sealed class CookFoodResponse : IMessage<CookFoodResponse>, IMessage, IEquatable<CookFoodResponse>, IDeepCloneable<CookFoodResponse>, IBufferMessage
	{
		// Token: 0x06004D62 RID: 19810 RVA: 0x000BC6C5 File Offset: 0x000BA8C5
		[NullableContext(1)]
		public static CookFoodResponse Create()
		{
			return new CookFoodResponse();
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x000BC6CC File Offset: 0x000BA8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x000BC6CF File Offset: 0x000BA8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFoodResponse.Descriptor;
			}
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x000BC6D6 File Offset: 0x000BA8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodResponse()
		{
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x000BC6F4 File Offset: 0x000BA8F4
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

		// Token: 0x06004D67 RID: 19815 RVA: 0x000BC76A File Offset: 0x000BA96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodResponse Clone()
		{
			return new CookFoodResponse(this);
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x000BC772 File Offset: 0x000BA972
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x000BC77A File Offset: 0x000BA97A
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x000BC783 File Offset: 0x000BA983
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x000BC78B File Offset: 0x000BA98B
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x000BC794 File Offset: 0x000BA994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06004D6D RID: 19821 RVA: 0x000BC79C File Offset: 0x000BA99C
		// (set) Token: 0x06004D6E RID: 19822 RVA: 0x000BC7A4 File Offset: 0x000BA9A4
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

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06004D6F RID: 19823 RVA: 0x000BC7AD File Offset: 0x000BA9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x000BC7B5 File Offset: 0x000BA9B5
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x000BC7BD File Offset: 0x000BA9BD
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

		// Token: 0x06004D72 RID: 19826 RVA: 0x000BC7C6 File Offset: 0x000BA9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFoodResponse);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x000BC7D4 File Offset: 0x000BA9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFoodResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x000BC868 File Offset: 0x000BAA68
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

		// Token: 0x06004D75 RID: 19829 RVA: 0x000BC914 File Offset: 0x000BAB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x000BC921 File Offset: 0x000BAB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x000BC92C File Offset: 0x000BAB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemInfos_.WriteTo(ref output, CookFoodResponse._repeated_itemInfos_codec);
			this.extraItemInfos_.WriteTo(ref output, CookFoodResponse._repeated_extraItemInfos_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActiveSkillType);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x000BC9E0 File Offset: 0x000BABE0
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

		// Token: 0x06004D79 RID: 19833 RVA: 0x000BCA8C File Offset: 0x000BAC8C
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

		// Token: 0x06004D7A RID: 19834 RVA: 0x000BCB26 File Offset: 0x000BAD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x000BCB30 File Offset: 0x000BAD30
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
				if (num <= 40U)
				{
					if (num == 10U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, CookFoodResponse._repeated_itemInfos_codec);
						continue;
					}
					if (num == 34U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, CookFoodResponse._repeated_extraItemInfos_codec);
						continue;
					}
					if (num == 40U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ActiveSkillType = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003199 RID: 12697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400319A RID: 12698
		public const int CodeFieldNumber = 5;

		// Token: 0x0400319B RID: 12699
		private ErrorCode code_;

		// Token: 0x0400319C RID: 12700
		public const int IdFieldNumber = 13;

		// Token: 0x0400319D RID: 12701
		private int id_;

		// Token: 0x0400319E RID: 12702
		public const int ItemInfosFieldNumber = 1;

		// Token: 0x0400319F RID: 12703
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(10U, SingleItemInfo.Parser);

		// Token: 0x040031A0 RID: 12704
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040031A1 RID: 12705
		public const int ActiveSkillTypeFieldNumber = 11;

		// Token: 0x040031A2 RID: 12706
		private int activeSkillType_;

		// Token: 0x040031A3 RID: 12707
		public const int ExtraItemInfosFieldNumber = 4;

		// Token: 0x040031A4 RID: 12708
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(34U, SingleItemInfo.Parser);

		// Token: 0x040031A5 RID: 12709
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040031A6 RID: 12710
		public const int RoleIdFieldNumber = 15;

		// Token: 0x040031A7 RID: 12711
		private int roleId_;
	}
}
