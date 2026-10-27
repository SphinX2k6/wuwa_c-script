using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001203 RID: 4611
	[NetMessage(EMessageId.ShortMessageInfoResponse)]
	public sealed class ShortMessageInfoResponse : IMessage<ShortMessageInfoResponse>, IMessage, IEquatable<ShortMessageInfoResponse>, IDeepCloneable<ShortMessageInfoResponse>, IBufferMessage
	{
		// Token: 0x06018944 RID: 100676 RVA: 0x00392F0E File Offset: 0x0039110E
		[NullableContext(1)]
		public static ShortMessageInfoResponse Create()
		{
			return new ShortMessageInfoResponse();
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x06018945 RID: 100677 RVA: 0x00392F15 File Offset: 0x00391115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x06018946 RID: 100678 RVA: 0x00392F18 File Offset: 0x00391118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018947 RID: 100679 RVA: 0x00392F20 File Offset: 0x00391120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoResponse()
		{
		}

		// Token: 0x06018948 RID: 100680 RVA: 0x00392F78 File Offset: 0x00391178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoResponse(ShortMessageInfoResponse other) : this()
		{
			this.shortMessageInfos_ = other.shortMessageInfos_.Clone();
			this.bubbleIds_ = other.bubbleIds_.Clone();
			this.bubbleId_ = other.bubbleId_;
			this.chatBgIds_ = other.chatBgIds_.Clone();
			this.chatBgId_ = other.chatBgId_;
			this.errCode_ = other.errCode_;
			this.partnerChange_ = other.partnerChange_.Clone();
			this.chatThemeId_ = other.chatThemeId_;
			this.chatThemeIds_ = other.chatThemeIds_.Clone();
			this.chatCharmId_ = other.chatCharmId_;
			this.chatCharmIds_ = other.chatCharmIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018949 RID: 100681 RVA: 0x0039303E File Offset: 0x0039123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoResponse Clone()
		{
			return new ShortMessageInfoResponse(this);
		}

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x0601894A RID: 100682 RVA: 0x00393046 File Offset: 0x00391246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShortMessageInfo> ShortMessageInfos
		{
			get
			{
				return this.shortMessageInfos_;
			}
		}

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x0601894B RID: 100683 RVA: 0x0039304E File Offset: 0x0039124E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BubbleIds
		{
			get
			{
				return this.bubbleIds_;
			}
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x0601894C RID: 100684 RVA: 0x00393056 File Offset: 0x00391256
		// (set) Token: 0x0601894D RID: 100685 RVA: 0x0039305E File Offset: 0x0039125E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BubbleId
		{
			get
			{
				return this.bubbleId_;
			}
			set
			{
				this.bubbleId_ = value;
			}
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x0601894E RID: 100686 RVA: 0x00393067 File Offset: 0x00391267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatBgIds
		{
			get
			{
				return this.chatBgIds_;
			}
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x0601894F RID: 100687 RVA: 0x0039306F File Offset: 0x0039126F
		// (set) Token: 0x06018950 RID: 100688 RVA: 0x00393077 File Offset: 0x00391277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatBgId
		{
			get
			{
				return this.chatBgId_;
			}
			set
			{
				this.chatBgId_ = value;
			}
		}

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06018951 RID: 100689 RVA: 0x00393080 File Offset: 0x00391280
		// (set) Token: 0x06018952 RID: 100690 RVA: 0x00393088 File Offset: 0x00391288
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

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x06018953 RID: 100691 RVA: 0x00393091 File Offset: 0x00391291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PartnerChange
		{
			get
			{
				return this.partnerChange_;
			}
		}

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x06018954 RID: 100692 RVA: 0x00393099 File Offset: 0x00391299
		// (set) Token: 0x06018955 RID: 100693 RVA: 0x003930A1 File Offset: 0x003912A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatThemeId
		{
			get
			{
				return this.chatThemeId_;
			}
			set
			{
				this.chatThemeId_ = value;
			}
		}

		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x06018956 RID: 100694 RVA: 0x003930AA File Offset: 0x003912AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatThemeIds
		{
			get
			{
				return this.chatThemeIds_;
			}
		}

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x06018957 RID: 100695 RVA: 0x003930B2 File Offset: 0x003912B2
		// (set) Token: 0x06018958 RID: 100696 RVA: 0x003930BA File Offset: 0x003912BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatCharmId
		{
			get
			{
				return this.chatCharmId_;
			}
			set
			{
				this.chatCharmId_ = value;
			}
		}

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x06018959 RID: 100697 RVA: 0x003930C3 File Offset: 0x003912C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatCharmIds
		{
			get
			{
				return this.chatCharmIds_;
			}
		}

		// Token: 0x0601895A RID: 100698 RVA: 0x003930CB File Offset: 0x003912CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfoResponse);
		}

		// Token: 0x0601895B RID: 100699 RVA: 0x003930DC File Offset: 0x003912DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfoResponse other)
		{
			return other != null && (other == this || (this.shortMessageInfos_.Equals(other.shortMessageInfos_) && this.bubbleIds_.Equals(other.bubbleIds_) && this.BubbleId == other.BubbleId && this.chatBgIds_.Equals(other.chatBgIds_) && this.ChatBgId == other.ChatBgId && this.ErrCode == other.ErrCode && this.partnerChange_.Equals(other.partnerChange_) && this.ChatThemeId == other.ChatThemeId && this.chatThemeIds_.Equals(other.chatThemeIds_) && this.ChatCharmId == other.ChatCharmId && this.chatCharmIds_.Equals(other.chatCharmIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601895C RID: 100700 RVA: 0x003931D4 File Offset: 0x003913D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shortMessageInfos_.GetHashCode();
			num ^= this.bubbleIds_.GetHashCode();
			if (this.BubbleId != 0)
			{
				num ^= this.BubbleId.GetHashCode();
			}
			num ^= this.chatBgIds_.GetHashCode();
			if (this.ChatBgId != 0)
			{
				num ^= this.ChatBgId.GetHashCode();
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.partnerChange_.GetHashCode();
			if (this.ChatThemeId != 0)
			{
				num ^= this.ChatThemeId.GetHashCode();
			}
			num ^= this.chatThemeIds_.GetHashCode();
			if (this.ChatCharmId != 0)
			{
				num ^= this.ChatCharmId.GetHashCode();
			}
			num ^= this.chatCharmIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601895D RID: 100701 RVA: 0x003932D1 File Offset: 0x003914D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601895E RID: 100702 RVA: 0x003932DE File Offset: 0x003914DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601895F RID: 100703 RVA: 0x003932E8 File Offset: 0x003914E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BubbleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BubbleId);
			}
			this.shortMessageInfos_.WriteTo(ref output, ShortMessageInfoResponse._repeated_shortMessageInfos_codec);
			this.bubbleIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_bubbleIds_codec);
			this.chatCharmIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatCharmIds_codec);
			if (this.ChatBgId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChatBgId);
			}
			this.partnerChange_.WriteTo(ref output, ShortMessageInfoResponse._repeated_partnerChange_codec);
			if (this.ChatThemeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChatThemeId);
			}
			this.chatBgIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatBgIds_codec);
			if (this.ChatCharmId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ChatCharmId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			this.chatThemeIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatThemeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018960 RID: 100704 RVA: 0x003933FC File Offset: 0x003915FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shortMessageInfos_.CalculateSize(ShortMessageInfoResponse._repeated_shortMessageInfos_codec);
			num += this.bubbleIds_.CalculateSize(ShortMessageInfoResponse._repeated_bubbleIds_codec);
			if (this.BubbleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BubbleId);
			}
			num += this.chatBgIds_.CalculateSize(ShortMessageInfoResponse._repeated_chatBgIds_codec);
			if (this.ChatBgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatBgId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.partnerChange_.CalculateSize(ShortMessageInfoResponse._repeated_partnerChange_codec);
			if (this.ChatThemeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatThemeId);
			}
			num += this.chatThemeIds_.CalculateSize(ShortMessageInfoResponse._repeated_chatThemeIds_codec);
			if (this.ChatCharmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatCharmId);
			}
			num += this.chatCharmIds_.CalculateSize(ShortMessageInfoResponse._repeated_chatCharmIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018961 RID: 100705 RVA: 0x0039350C File Offset: 0x0039170C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.shortMessageInfos_.Add(other.shortMessageInfos_);
			this.bubbleIds_.Add(other.bubbleIds_);
			if (other.BubbleId != 0)
			{
				this.BubbleId = other.BubbleId;
			}
			this.chatBgIds_.Add(other.chatBgIds_);
			if (other.ChatBgId != 0)
			{
				this.ChatBgId = other.ChatBgId;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.partnerChange_.Add(other.partnerChange_);
			if (other.ChatThemeId != 0)
			{
				this.ChatThemeId = other.ChatThemeId;
			}
			this.chatThemeIds_.Add(other.chatThemeIds_);
			if (other.ChatCharmId != 0)
			{
				this.ChatCharmId = other.ChatCharmId;
			}
			this.chatCharmIds_.Add(other.chatCharmIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018962 RID: 100706 RVA: 0x003935FE File Offset: 0x003917FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018963 RID: 100707 RVA: 0x00393608 File Offset: 0x00391808
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
				if (num <= 48U)
				{
					if (num <= 26U)
					{
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.BubbleId = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								this.shortMessageInfos_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_shortMessageInfos_codec);
								continue;
							}
						}
						else if (num == 24U || num == 26U)
						{
							this.bubbleIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_bubbleIds_codec);
							continue;
						}
					}
					else if (num <= 34U)
					{
						if (num == 32U || num == 34U)
						{
							this.chatCharmIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatCharmIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.ChatBgId = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							goto IL_134;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num <= 72U)
					{
						if (num == 50U)
						{
							goto IL_134;
						}
						if (num == 72U)
						{
							this.ChatThemeId = input.ReadInt32();
							continue;
						}
					}
					else if (num == 80U || num == 82U)
					{
						this.chatBgIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatBgIds_codec);
						continue;
					}
				}
				else if (num <= 112U)
				{
					if (num == 104U)
					{
						this.ChatCharmId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.chatThemeIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatThemeIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_134:
				this.partnerChange_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_partnerChange_codec);
			}
		}

		// Token: 0x04009138 RID: 37176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009139 RID: 37177
		public const int ShortMessageInfosFieldNumber = 2;

		// Token: 0x0400913A RID: 37178
		private static readonly FieldCodec<ShortMessageInfo> _repeated_shortMessageInfos_codec = FieldCodec.ForMessage<ShortMessageInfo>(18U, ShortMessageInfo.Parser);

		// Token: 0x0400913B RID: 37179
		private readonly RepeatedField<ShortMessageInfo> shortMessageInfos_ = new RepeatedField<ShortMessageInfo>();

		// Token: 0x0400913C RID: 37180
		public const int BubbleIdsFieldNumber = 3;

		// Token: 0x0400913D RID: 37181
		private static readonly FieldCodec<int> _repeated_bubbleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400913E RID: 37182
		private readonly RepeatedField<int> bubbleIds_ = new RepeatedField<int>();

		// Token: 0x0400913F RID: 37183
		public const int BubbleIdFieldNumber = 1;

		// Token: 0x04009140 RID: 37184
		private int bubbleId_;

		// Token: 0x04009141 RID: 37185
		public const int ChatBgIdsFieldNumber = 10;

		// Token: 0x04009142 RID: 37186
		private static readonly FieldCodec<int> _repeated_chatBgIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009143 RID: 37187
		private readonly RepeatedField<int> chatBgIds_ = new RepeatedField<int>();

		// Token: 0x04009144 RID: 37188
		public const int ChatBgIdFieldNumber = 5;

		// Token: 0x04009145 RID: 37189
		private int chatBgId_;

		// Token: 0x04009146 RID: 37190
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04009147 RID: 37191
		private ErrorCode errCode_;

		// Token: 0x04009148 RID: 37192
		public const int PartnerChangeFieldNumber = 6;

		// Token: 0x04009149 RID: 37193
		private static readonly FieldCodec<int> _repeated_partnerChange_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400914A RID: 37194
		private readonly RepeatedField<int> partnerChange_ = new RepeatedField<int>();

		// Token: 0x0400914B RID: 37195
		public const int ChatThemeIdFieldNumber = 9;

		// Token: 0x0400914C RID: 37196
		private int chatThemeId_;

		// Token: 0x0400914D RID: 37197
		public const int ChatThemeIdsFieldNumber = 15;

		// Token: 0x0400914E RID: 37198
		private static readonly FieldCodec<int> _repeated_chatThemeIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400914F RID: 37199
		private readonly RepeatedField<int> chatThemeIds_ = new RepeatedField<int>();

		// Token: 0x04009150 RID: 37200
		public const int ChatCharmIdFieldNumber = 13;

		// Token: 0x04009151 RID: 37201
		private int chatCharmId_;

		// Token: 0x04009152 RID: 37202
		public const int ChatCharmIdsFieldNumber = 4;

		// Token: 0x04009153 RID: 37203
		private static readonly FieldCodec<int> _repeated_chatCharmIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009154 RID: 37204
		private readonly RepeatedField<int> chatCharmIds_ = new RepeatedField<int>();
	}
}
