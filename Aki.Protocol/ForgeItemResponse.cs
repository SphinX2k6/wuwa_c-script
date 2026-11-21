using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060F RID: 1551
	[NetMessage(EMessageId.ForgeItemResponse)]
	public sealed class ForgeItemResponse : IMessage<ForgeItemResponse>, IMessage, IEquatable<ForgeItemResponse>, IDeepCloneable<ForgeItemResponse>, IBufferMessage
	{
		// Token: 0x06008F94 RID: 36756 RVA: 0x0015C0C1 File Offset: 0x0015A2C1
		[NullableContext(1)]
		public static ForgeItemResponse Create()
		{
			return new ForgeItemResponse();
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06008F95 RID: 36757 RVA: 0x0015C0C8 File Offset: 0x0015A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0015C0CB File Offset: 0x0015A2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemResponse.Descriptor;
			}
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0015C0D2 File Offset: 0x0015A2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemResponse()
		{
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0015C0F0 File Offset: 0x0015A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemResponse(ForgeItemResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this.activeSkillType_ = other.activeSkillType_;
			this.extraItemInfos_ = other.extraItemInfos_.Clone();
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x0015C166 File Offset: 0x0015A366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemResponse Clone()
		{
			return new ForgeItemResponse(this);
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x0015C16E File Offset: 0x0015A36E
		// (set) Token: 0x06008F9B RID: 36763 RVA: 0x0015C176 File Offset: 0x0015A376
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

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06008F9C RID: 36764 RVA: 0x0015C17F File Offset: 0x0015A37F
		// (set) Token: 0x06008F9D RID: 36765 RVA: 0x0015C187 File Offset: 0x0015A387
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

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06008F9E RID: 36766 RVA: 0x0015C190 File Offset: 0x0015A390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x0015C198 File Offset: 0x0015A398
		// (set) Token: 0x06008FA0 RID: 36768 RVA: 0x0015C1A0 File Offset: 0x0015A3A0
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

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06008FA1 RID: 36769 RVA: 0x0015C1A9 File Offset: 0x0015A3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06008FA2 RID: 36770 RVA: 0x0015C1B1 File Offset: 0x0015A3B1
		// (set) Token: 0x06008FA3 RID: 36771 RVA: 0x0015C1B9 File Offset: 0x0015A3B9
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

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0015C1C2 File Offset: 0x0015A3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemResponse);
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x0015C1D0 File Offset: 0x0015A3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0015C264 File Offset: 0x0015A464
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

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0015C310 File Offset: 0x0015A510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FA8 RID: 36776 RVA: 0x0015C31D File Offset: 0x0015A51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x0015C328 File Offset: 0x0015A528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraItemInfos_.WriteTo(ref output, ForgeItemResponse._repeated_extraItemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActiveSkillType);
			}
			this.itemInfos_.WriteTo(ref output, ForgeItemResponse._repeated_itemInfos_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FAA RID: 36778 RVA: 0x0015C3DC File Offset: 0x0015A5DC
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
			num += this.itemInfos_.CalculateSize(ForgeItemResponse._repeated_itemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveSkillType);
			}
			num += this.extraItemInfos_.CalculateSize(ForgeItemResponse._repeated_extraItemInfos_codec);
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

		// Token: 0x06008FAB RID: 36779 RVA: 0x0015C488 File Offset: 0x0015A688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeItemResponse other)
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

		// Token: 0x06008FAC RID: 36780 RVA: 0x0015C522 File Offset: 0x0015A722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x0015C52C File Offset: 0x0015A72C
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
				if (num <= 34U)
				{
					if (num == 10U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, ForgeItemResponse._repeated_extraItemInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						this.ActiveSkillType = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, ForgeItemResponse._repeated_itemInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400460A RID: 17930
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400460B RID: 17931
		public const int CodeFieldNumber = 11;

		// Token: 0x0400460C RID: 17932
		private ErrorCode code_;

		// Token: 0x0400460D RID: 17933
		public const int IdFieldNumber = 14;

		// Token: 0x0400460E RID: 17934
		private int id_;

		// Token: 0x0400460F RID: 17935
		public const int ItemInfosFieldNumber = 4;

		// Token: 0x04004610 RID: 17936
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(34U, SingleItemInfo.Parser);

		// Token: 0x04004611 RID: 17937
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04004612 RID: 17938
		public const int ActiveSkillTypeFieldNumber = 2;

		// Token: 0x04004613 RID: 17939
		private int activeSkillType_;

		// Token: 0x04004614 RID: 17940
		public const int ExtraItemInfosFieldNumber = 1;

		// Token: 0x04004615 RID: 17941
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(10U, SingleItemInfo.Parser);

		// Token: 0x04004616 RID: 17942
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04004617 RID: 17943
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04004618 RID: 17944
		private int roleId_;
	}
}
