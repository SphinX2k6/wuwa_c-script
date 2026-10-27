using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000623 RID: 1571
	[NetMessage(EMessageId.ForgeItemResponse)]
	public sealed class ForgeItemResponse : IMessage<ForgeItemResponse>, IMessage, IEquatable<ForgeItemResponse>, IDeepCloneable<ForgeItemResponse>, IBufferMessage
	{
		// Token: 0x060090EA RID: 37098 RVA: 0x0015EAF0 File Offset: 0x0015CCF0
		[NullableContext(1)]
		public static ForgeItemResponse Create()
		{
			return new ForgeItemResponse();
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060090EB RID: 37099 RVA: 0x0015EAF7 File Offset: 0x0015CCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x0015EAFA File Offset: 0x0015CCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemResponse.Descriptor;
			}
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x0015EB01 File Offset: 0x0015CD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemResponse()
		{
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x0015EB20 File Offset: 0x0015CD20
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

		// Token: 0x060090EF RID: 37103 RVA: 0x0015EB96 File Offset: 0x0015CD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemResponse Clone()
		{
			return new ForgeItemResponse(this);
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x0015EB9E File Offset: 0x0015CD9E
		// (set) Token: 0x060090F1 RID: 37105 RVA: 0x0015EBA6 File Offset: 0x0015CDA6
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

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x060090F2 RID: 37106 RVA: 0x0015EBAF File Offset: 0x0015CDAF
		// (set) Token: 0x060090F3 RID: 37107 RVA: 0x0015EBB7 File Offset: 0x0015CDB7
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

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x0015EBC0 File Offset: 0x0015CDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x060090F5 RID: 37109 RVA: 0x0015EBC8 File Offset: 0x0015CDC8
		// (set) Token: 0x060090F6 RID: 37110 RVA: 0x0015EBD0 File Offset: 0x0015CDD0
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

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x060090F7 RID: 37111 RVA: 0x0015EBD9 File Offset: 0x0015CDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x0015EBE1 File Offset: 0x0015CDE1
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x0015EBE9 File Offset: 0x0015CDE9
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

		// Token: 0x060090FA RID: 37114 RVA: 0x0015EBF2 File Offset: 0x0015CDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemResponse);
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0015EC00 File Offset: 0x0015CE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x0015EC94 File Offset: 0x0015CE94
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

		// Token: 0x060090FD RID: 37117 RVA: 0x0015ED40 File Offset: 0x0015CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x0015ED4D File Offset: 0x0015CF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x0015ED58 File Offset: 0x0015CF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraItemInfos_.WriteTo(ref output, ForgeItemResponse._repeated_extraItemInfos_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			this.itemInfos_.WriteTo(ref output, ForgeItemResponse._repeated_itemInfos_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActiveSkillType);
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

		// Token: 0x06009100 RID: 37120 RVA: 0x0015EE0C File Offset: 0x0015D00C
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

		// Token: 0x06009101 RID: 37121 RVA: 0x0015EEB8 File Offset: 0x0015D0B8
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

		// Token: 0x06009102 RID: 37122 RVA: 0x0015EF52 File Offset: 0x0015D152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0015EF5C File Offset: 0x0015D15C
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, ForgeItemResponse._repeated_extraItemInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, ForgeItemResponse._repeated_itemInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.ActiveSkillType = input.ReadInt32();
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

		// Token: 0x04004611 RID: 17937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004612 RID: 17938
		public const int CodeFieldNumber = 4;

		// Token: 0x04004613 RID: 17939
		private ErrorCode code_;

		// Token: 0x04004614 RID: 17940
		public const int IdFieldNumber = 2;

		// Token: 0x04004615 RID: 17941
		private int id_;

		// Token: 0x04004616 RID: 17942
		public const int ItemInfosFieldNumber = 3;

		// Token: 0x04004617 RID: 17943
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(26U, SingleItemInfo.Parser);

		// Token: 0x04004618 RID: 17944
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04004619 RID: 17945
		public const int ActiveSkillTypeFieldNumber = 7;

		// Token: 0x0400461A RID: 17946
		private int activeSkillType_;

		// Token: 0x0400461B RID: 17947
		public const int ExtraItemInfosFieldNumber = 1;

		// Token: 0x0400461C RID: 17948
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(10U, SingleItemInfo.Parser);

		// Token: 0x0400461D RID: 17949
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x0400461E RID: 17950
		public const int RoleIdFieldNumber = 15;

		// Token: 0x0400461F RID: 17951
		private int roleId_;
	}
}
