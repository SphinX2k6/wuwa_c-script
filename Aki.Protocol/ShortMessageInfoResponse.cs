using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123F RID: 4671
	[NetMessage(EMessageId.ShortMessageInfoResponse)]
	public sealed class ShortMessageInfoResponse : IMessage<ShortMessageInfoResponse>, IMessage, IEquatable<ShortMessageInfoResponse>, IDeepCloneable<ShortMessageInfoResponse>, IBufferMessage
	{
		// Token: 0x06018F1E RID: 102174 RVA: 0x003A2DAE File Offset: 0x003A0FAE
		[NullableContext(1)]
		public static ShortMessageInfoResponse Create()
		{
			return new ShortMessageInfoResponse();
		}

		// Token: 0x17005448 RID: 21576
		// (get) Token: 0x06018F1F RID: 102175 RVA: 0x003A2DB5 File Offset: 0x003A0FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x06018F20 RID: 102176 RVA: 0x003A2DB8 File Offset: 0x003A0FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018F21 RID: 102177 RVA: 0x003A2DC0 File Offset: 0x003A0FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoResponse()
		{
		}

		// Token: 0x06018F22 RID: 102178 RVA: 0x003A2E18 File Offset: 0x003A1018
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

		// Token: 0x06018F23 RID: 102179 RVA: 0x003A2EDE File Offset: 0x003A10DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoResponse Clone()
		{
			return new ShortMessageInfoResponse(this);
		}

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x06018F24 RID: 102180 RVA: 0x003A2EE6 File Offset: 0x003A10E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShortMessageInfo> ShortMessageInfos
		{
			get
			{
				return this.shortMessageInfos_;
			}
		}

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x06018F25 RID: 102181 RVA: 0x003A2EEE File Offset: 0x003A10EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BubbleIds
		{
			get
			{
				return this.bubbleIds_;
			}
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x06018F26 RID: 102182 RVA: 0x003A2EF6 File Offset: 0x003A10F6
		// (set) Token: 0x06018F27 RID: 102183 RVA: 0x003A2EFE File Offset: 0x003A10FE
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

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x06018F28 RID: 102184 RVA: 0x003A2F07 File Offset: 0x003A1107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatBgIds
		{
			get
			{
				return this.chatBgIds_;
			}
		}

		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x06018F29 RID: 102185 RVA: 0x003A2F0F File Offset: 0x003A110F
		// (set) Token: 0x06018F2A RID: 102186 RVA: 0x003A2F17 File Offset: 0x003A1117
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

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x06018F2B RID: 102187 RVA: 0x003A2F20 File Offset: 0x003A1120
		// (set) Token: 0x06018F2C RID: 102188 RVA: 0x003A2F28 File Offset: 0x003A1128
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

		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x06018F2D RID: 102189 RVA: 0x003A2F31 File Offset: 0x003A1131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PartnerChange
		{
			get
			{
				return this.partnerChange_;
			}
		}

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x06018F2E RID: 102190 RVA: 0x003A2F39 File Offset: 0x003A1139
		// (set) Token: 0x06018F2F RID: 102191 RVA: 0x003A2F41 File Offset: 0x003A1141
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

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x06018F30 RID: 102192 RVA: 0x003A2F4A File Offset: 0x003A114A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatThemeIds
		{
			get
			{
				return this.chatThemeIds_;
			}
		}

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06018F31 RID: 102193 RVA: 0x003A2F52 File Offset: 0x003A1152
		// (set) Token: 0x06018F32 RID: 102194 RVA: 0x003A2F5A File Offset: 0x003A115A
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

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x06018F33 RID: 102195 RVA: 0x003A2F63 File Offset: 0x003A1163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatCharmIds
		{
			get
			{
				return this.chatCharmIds_;
			}
		}

		// Token: 0x06018F34 RID: 102196 RVA: 0x003A2F6B File Offset: 0x003A116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfoResponse);
		}

		// Token: 0x06018F35 RID: 102197 RVA: 0x003A2F7C File Offset: 0x003A117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfoResponse other)
		{
			return other != null && (other == this || (this.shortMessageInfos_.Equals(other.shortMessageInfos_) && this.bubbleIds_.Equals(other.bubbleIds_) && this.BubbleId == other.BubbleId && this.chatBgIds_.Equals(other.chatBgIds_) && this.ChatBgId == other.ChatBgId && this.ErrCode == other.ErrCode && this.partnerChange_.Equals(other.partnerChange_) && this.ChatThemeId == other.ChatThemeId && this.chatThemeIds_.Equals(other.chatThemeIds_) && this.ChatCharmId == other.ChatCharmId && this.chatCharmIds_.Equals(other.chatCharmIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F36 RID: 102198 RVA: 0x003A3074 File Offset: 0x003A1274
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

		// Token: 0x06018F37 RID: 102199 RVA: 0x003A3171 File Offset: 0x003A1371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x003A317E File Offset: 0x003A137E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F39 RID: 102201 RVA: 0x003A3188 File Offset: 0x003A1388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatBgIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatBgIds_codec);
			if (this.ChatBgId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChatBgId);
			}
			this.partnerChange_.WriteTo(ref output, ShortMessageInfoResponse._repeated_partnerChange_codec);
			if (this.ChatThemeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChatThemeId);
			}
			this.bubbleIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_bubbleIds_codec);
			this.chatThemeIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatThemeIds_codec);
			if (this.ChatCharmId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ChatCharmId);
			}
			if (this.BubbleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BubbleId);
			}
			this.shortMessageInfos_.WriteTo(ref output, ShortMessageInfoResponse._repeated_shortMessageInfos_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			this.chatCharmIds_.WriteTo(ref output, ShortMessageInfoResponse._repeated_chatCharmIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x003A329C File Offset: 0x003A149C
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

		// Token: 0x06018F3B RID: 102203 RVA: 0x003A33AC File Offset: 0x003A15AC
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

		// Token: 0x06018F3C RID: 102204 RVA: 0x003A349E File Offset: 0x003A169E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F3D RID: 102205 RVA: 0x003A34A8 File Offset: 0x003A16A8
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
				if (num <= 74U)
				{
					if (num <= 32U)
					{
						if (num <= 10U)
						{
							if (num != 8U && num != 10U)
							{
								goto IL_BF;
							}
							this.chatBgIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatBgIds_codec);
							continue;
						}
						else
						{
							if (num == 16U)
							{
								this.ChatBgId = input.ReadInt32();
								continue;
							}
							if (num != 32U)
							{
								goto IL_BF;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num != 34U)
						{
							if (num != 48U)
							{
								goto IL_BF;
							}
							this.ChatThemeId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num != 72U && num != 74U)
						{
							goto IL_BF;
						}
						this.bubbleIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_bubbleIds_codec);
						continue;
					}
					this.partnerChange_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_partnerChange_codec);
					continue;
				}
				if (num <= 96U)
				{
					if (num <= 82U)
					{
						if (num == 80U || num == 82U)
						{
							this.chatThemeIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatThemeIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.ChatCharmId = input.ReadInt32();
							continue;
						}
						if (num == 96U)
						{
							this.BubbleId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 106U)
					{
						this.shortMessageInfos_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_shortMessageInfos_codec);
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
					this.chatCharmIds_.AddEntriesFrom(ref input, ShortMessageInfoResponse._repeated_chatCharmIds_codec);
					continue;
				}
				IL_BF:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093E9 RID: 37865
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093EA RID: 37866
		public const int ShortMessageInfosFieldNumber = 13;

		// Token: 0x040093EB RID: 37867
		private static readonly FieldCodec<ShortMessageInfo> _repeated_shortMessageInfos_codec = FieldCodec.ForMessage<ShortMessageInfo>(106U, ShortMessageInfo.Parser);

		// Token: 0x040093EC RID: 37868
		private readonly RepeatedField<ShortMessageInfo> shortMessageInfos_ = new RepeatedField<ShortMessageInfo>();

		// Token: 0x040093ED RID: 37869
		public const int BubbleIdsFieldNumber = 9;

		// Token: 0x040093EE RID: 37870
		private static readonly FieldCodec<int> _repeated_bubbleIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040093EF RID: 37871
		private readonly RepeatedField<int> bubbleIds_ = new RepeatedField<int>();

		// Token: 0x040093F0 RID: 37872
		public const int BubbleIdFieldNumber = 12;

		// Token: 0x040093F1 RID: 37873
		private int bubbleId_;

		// Token: 0x040093F2 RID: 37874
		public const int ChatBgIdsFieldNumber = 1;

		// Token: 0x040093F3 RID: 37875
		private static readonly FieldCodec<int> _repeated_chatBgIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040093F4 RID: 37876
		private readonly RepeatedField<int> chatBgIds_ = new RepeatedField<int>();

		// Token: 0x040093F5 RID: 37877
		public const int ChatBgIdFieldNumber = 2;

		// Token: 0x040093F6 RID: 37878
		private int chatBgId_;

		// Token: 0x040093F7 RID: 37879
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x040093F8 RID: 37880
		private ErrorCode errCode_;

		// Token: 0x040093F9 RID: 37881
		public const int PartnerChangeFieldNumber = 4;

		// Token: 0x040093FA RID: 37882
		private static readonly FieldCodec<int> _repeated_partnerChange_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040093FB RID: 37883
		private readonly RepeatedField<int> partnerChange_ = new RepeatedField<int>();

		// Token: 0x040093FC RID: 37884
		public const int ChatThemeIdFieldNumber = 6;

		// Token: 0x040093FD RID: 37885
		private int chatThemeId_;

		// Token: 0x040093FE RID: 37886
		public const int ChatThemeIdsFieldNumber = 10;

		// Token: 0x040093FF RID: 37887
		private static readonly FieldCodec<int> _repeated_chatThemeIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009400 RID: 37888
		private readonly RepeatedField<int> chatThemeIds_ = new RepeatedField<int>();

		// Token: 0x04009401 RID: 37889
		public const int ChatCharmIdFieldNumber = 11;

		// Token: 0x04009402 RID: 37890
		private int chatCharmId_;

		// Token: 0x04009403 RID: 37891
		public const int ChatCharmIdsFieldNumber = 15;

		// Token: 0x04009404 RID: 37892
		private static readonly FieldCodec<int> _repeated_chatCharmIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04009405 RID: 37893
		private readonly RepeatedField<int> chatCharmIds_ = new RepeatedField<int>();
	}
}
