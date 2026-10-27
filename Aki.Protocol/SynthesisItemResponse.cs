using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001310 RID: 4880
	[NetMessage(EMessageId.SynthesisItemResponse)]
	public sealed class SynthesisItemResponse : IMessage<SynthesisItemResponse>, IMessage, IEquatable<SynthesisItemResponse>, IDeepCloneable<SynthesisItemResponse>, IBufferMessage
	{
		// Token: 0x06019EF6 RID: 106230 RVA: 0x003C49AD File Offset: 0x003C2BAD
		[NullableContext(1)]
		public static SynthesisItemResponse Create()
		{
			return new SynthesisItemResponse();
		}

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x06019EF7 RID: 106231 RVA: 0x003C49B4 File Offset: 0x003C2BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x06019EF8 RID: 106232 RVA: 0x003C49B7 File Offset: 0x003C2BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisItemResponse.Descriptor;
			}
		}

		// Token: 0x06019EF9 RID: 106233 RVA: 0x003C49BE File Offset: 0x003C2BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemResponse()
		{
		}

		// Token: 0x06019EFA RID: 106234 RVA: 0x003C49DC File Offset: 0x003C2BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemResponse(SynthesisItemResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this.activeSkillType_ = other.activeSkillType_;
			this.extraItemInfos_ = other.extraItemInfos_.Clone();
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EFB RID: 106235 RVA: 0x003C4A52 File Offset: 0x003C2C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemResponse Clone()
		{
			return new SynthesisItemResponse(this);
		}

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x06019EFC RID: 106236 RVA: 0x003C4A5A File Offset: 0x003C2C5A
		// (set) Token: 0x06019EFD RID: 106237 RVA: 0x003C4A62 File Offset: 0x003C2C62
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

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x06019EFE RID: 106238 RVA: 0x003C4A6B File Offset: 0x003C2C6B
		// (set) Token: 0x06019EFF RID: 106239 RVA: 0x003C4A73 File Offset: 0x003C2C73
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

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x06019F00 RID: 106240 RVA: 0x003C4A7C File Offset: 0x003C2C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x06019F01 RID: 106241 RVA: 0x003C4A84 File Offset: 0x003C2C84
		// (set) Token: 0x06019F02 RID: 106242 RVA: 0x003C4A8C File Offset: 0x003C2C8C
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

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x06019F03 RID: 106243 RVA: 0x003C4A95 File Offset: 0x003C2C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x06019F04 RID: 106244 RVA: 0x003C4A9D File Offset: 0x003C2C9D
		// (set) Token: 0x06019F05 RID: 106245 RVA: 0x003C4AA5 File Offset: 0x003C2CA5
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

		// Token: 0x06019F06 RID: 106246 RVA: 0x003C4AAE File Offset: 0x003C2CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisItemResponse);
		}

		// Token: 0x06019F07 RID: 106247 RVA: 0x003C4ABC File Offset: 0x003C2CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F08 RID: 106248 RVA: 0x003C4B50 File Offset: 0x003C2D50
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

		// Token: 0x06019F09 RID: 106249 RVA: 0x003C4BFC File Offset: 0x003C2DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F0A RID: 106250 RVA: 0x003C4C09 File Offset: 0x003C2E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F0B RID: 106251 RVA: 0x003C4C14 File Offset: 0x003C2E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemInfos_.WriteTo(ref output, SynthesisItemResponse._repeated_itemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActiveSkillType);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			this.extraItemInfos_.WriteTo(ref output, SynthesisItemResponse._repeated_extraItemInfos_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F0C RID: 106252 RVA: 0x003C4CC8 File Offset: 0x003C2EC8
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
			num += this.itemInfos_.CalculateSize(SynthesisItemResponse._repeated_itemInfos_codec);
			if (this.ActiveSkillType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveSkillType);
			}
			num += this.extraItemInfos_.CalculateSize(SynthesisItemResponse._repeated_extraItemInfos_codec);
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

		// Token: 0x06019F0D RID: 106253 RVA: 0x003C4D74 File Offset: 0x003C2F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisItemResponse other)
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

		// Token: 0x06019F0E RID: 106254 RVA: 0x003C4E0E File Offset: 0x003C300E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F0F RID: 106255 RVA: 0x003C4E18 File Offset: 0x003C3018
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, SynthesisItemResponse._repeated_itemInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						this.ActiveSkillType = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, SynthesisItemResponse._repeated_extraItemInfos_codec);
						continue;
					}
					if (num == 96U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009790 RID: 38800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009791 RID: 38801
		public const int CodeFieldNumber = 4;

		// Token: 0x04009792 RID: 38802
		private ErrorCode code_;

		// Token: 0x04009793 RID: 38803
		public const int IdFieldNumber = 15;

		// Token: 0x04009794 RID: 38804
		private int id_;

		// Token: 0x04009795 RID: 38805
		public const int ItemInfosFieldNumber = 1;

		// Token: 0x04009796 RID: 38806
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(10U, SingleItemInfo.Parser);

		// Token: 0x04009797 RID: 38807
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04009798 RID: 38808
		public const int ActiveSkillTypeFieldNumber = 2;

		// Token: 0x04009799 RID: 38809
		private int activeSkillType_;

		// Token: 0x0400979A RID: 38810
		public const int ExtraItemInfosFieldNumber = 6;

		// Token: 0x0400979B RID: 38811
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(50U, SingleItemInfo.Parser);

		// Token: 0x0400979C RID: 38812
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x0400979D RID: 38813
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400979E RID: 38814
		private int roleId_;
	}
}
