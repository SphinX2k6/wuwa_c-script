using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137D RID: 4989
	[NetMessage(EMessageId.SynthesisItemResponse)]
	public sealed class SynthesisItemResponse : IMessage<SynthesisItemResponse>, IMessage, IEquatable<SynthesisItemResponse>, IDeepCloneable<SynthesisItemResponse>, IBufferMessage
	{
		// Token: 0x0601A906 RID: 108806 RVA: 0x003DEC69 File Offset: 0x003DCE69
		[NullableContext(1)]
		public static SynthesisItemResponse Create()
		{
			return new SynthesisItemResponse();
		}

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x0601A907 RID: 108807 RVA: 0x003DEC70 File Offset: 0x003DCE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x0601A908 RID: 108808 RVA: 0x003DEC73 File Offset: 0x003DCE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisItemResponse.Descriptor;
			}
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x003DEC7A File Offset: 0x003DCE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemResponse()
		{
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x003DEC98 File Offset: 0x003DCE98
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

		// Token: 0x0601A90B RID: 108811 RVA: 0x003DED0E File Offset: 0x003DCF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemResponse Clone()
		{
			return new SynthesisItemResponse(this);
		}

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x0601A90C RID: 108812 RVA: 0x003DED16 File Offset: 0x003DCF16
		// (set) Token: 0x0601A90D RID: 108813 RVA: 0x003DED1E File Offset: 0x003DCF1E
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

		// Token: 0x170059F1 RID: 23025
		// (get) Token: 0x0601A90E RID: 108814 RVA: 0x003DED27 File Offset: 0x003DCF27
		// (set) Token: 0x0601A90F RID: 108815 RVA: 0x003DED2F File Offset: 0x003DCF2F
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

		// Token: 0x170059F2 RID: 23026
		// (get) Token: 0x0601A910 RID: 108816 RVA: 0x003DED38 File Offset: 0x003DCF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x170059F3 RID: 23027
		// (get) Token: 0x0601A911 RID: 108817 RVA: 0x003DED40 File Offset: 0x003DCF40
		// (set) Token: 0x0601A912 RID: 108818 RVA: 0x003DED48 File Offset: 0x003DCF48
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

		// Token: 0x170059F4 RID: 23028
		// (get) Token: 0x0601A913 RID: 108819 RVA: 0x003DED51 File Offset: 0x003DCF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> ExtraItemInfos
		{
			get
			{
				return this.extraItemInfos_;
			}
		}

		// Token: 0x170059F5 RID: 23029
		// (get) Token: 0x0601A914 RID: 108820 RVA: 0x003DED59 File Offset: 0x003DCF59
		// (set) Token: 0x0601A915 RID: 108821 RVA: 0x003DED61 File Offset: 0x003DCF61
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

		// Token: 0x0601A916 RID: 108822 RVA: 0x003DED6A File Offset: 0x003DCF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisItemResponse);
		}

		// Token: 0x0601A917 RID: 108823 RVA: 0x003DED78 File Offset: 0x003DCF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.itemInfos_.Equals(other.itemInfos_) && this.ActiveSkillType == other.ActiveSkillType && this.extraItemInfos_.Equals(other.extraItemInfos_) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A918 RID: 108824 RVA: 0x003DEE0C File Offset: 0x003DD00C
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

		// Token: 0x0601A919 RID: 108825 RVA: 0x003DEEB8 File Offset: 0x003DD0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A91A RID: 108826 RVA: 0x003DEEC5 File Offset: 0x003DD0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A91B RID: 108827 RVA: 0x003DEED0 File Offset: 0x003DD0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActiveSkillType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActiveSkillType);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			this.extraItemInfos_.WriteTo(ref output, SynthesisItemResponse._repeated_extraItemInfos_codec);
			this.itemInfos_.WriteTo(ref output, SynthesisItemResponse._repeated_itemInfos_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A91C RID: 108828 RVA: 0x003DEF84 File Offset: 0x003DD184
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

		// Token: 0x0601A91D RID: 108829 RVA: 0x003DF030 File Offset: 0x003DD230
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

		// Token: 0x0601A91E RID: 108830 RVA: 0x003DF0CA File Offset: 0x003DD2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A91F RID: 108831 RVA: 0x003DF0D4 File Offset: 0x003DD2D4
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
				if (num <= 66U)
				{
					if (num == 8U)
					{
						this.ActiveSkillType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						this.extraItemInfos_.AddEntriesFrom(ref input, SynthesisItemResponse._repeated_extraItemInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.itemInfos_.AddEntriesFrom(ref input, SynthesisItemResponse._repeated_itemInfos_codec);
						continue;
					}
					if (num == 88U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009BB2 RID: 39858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BB3 RID: 39859
		public const int CodeFieldNumber = 14;

		// Token: 0x04009BB4 RID: 39860
		private ErrorCode code_;

		// Token: 0x04009BB5 RID: 39861
		public const int IdFieldNumber = 11;

		// Token: 0x04009BB6 RID: 39862
		private int id_;

		// Token: 0x04009BB7 RID: 39863
		public const int ItemInfosFieldNumber = 10;

		// Token: 0x04009BB8 RID: 39864
		private static readonly FieldCodec<SingleItemInfo> _repeated_itemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(82U, SingleItemInfo.Parser);

		// Token: 0x04009BB9 RID: 39865
		private readonly RepeatedField<SingleItemInfo> itemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04009BBA RID: 39866
		public const int ActiveSkillTypeFieldNumber = 1;

		// Token: 0x04009BBB RID: 39867
		private int activeSkillType_;

		// Token: 0x04009BBC RID: 39868
		public const int ExtraItemInfosFieldNumber = 8;

		// Token: 0x04009BBD RID: 39869
		private static readonly FieldCodec<SingleItemInfo> _repeated_extraItemInfos_codec = FieldCodec.ForMessage<SingleItemInfo>(66U, SingleItemInfo.Parser);

		// Token: 0x04009BBE RID: 39870
		private readonly RepeatedField<SingleItemInfo> extraItemInfos_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x04009BBF RID: 39871
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04009BC0 RID: 39872
		private int roleId_;
	}
}
