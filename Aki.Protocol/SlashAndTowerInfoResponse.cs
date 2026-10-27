using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001249 RID: 4681
	[NetMessage(EMessageId.SlashAndTowerInfoResponse)]
	public sealed class SlashAndTowerInfoResponse : IMessage<SlashAndTowerInfoResponse>, IMessage, IEquatable<SlashAndTowerInfoResponse>, IDeepCloneable<SlashAndTowerInfoResponse>, IBufferMessage
	{
		// Token: 0x06018F17 RID: 102167 RVA: 0x003A125A File Offset: 0x0039F45A
		[NullableContext(1)]
		public static SlashAndTowerInfoResponse Create()
		{
			return new SlashAndTowerInfoResponse();
		}

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06018F18 RID: 102168 RVA: 0x003A1261 File Offset: 0x0039F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x06018F19 RID: 102169 RVA: 0x003A1264 File Offset: 0x0039F464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018F1A RID: 102170 RVA: 0x003A126B File Offset: 0x0039F46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoResponse()
		{
		}

		// Token: 0x06018F1B RID: 102171 RVA: 0x003A1294 File Offset: 0x0039F494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoResponse(SlashAndTowerInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.slashLevelPlayInfos_ = other.slashLevelPlayInfos_.Clone();
			this.receivedAward_ = other.receivedAward_.Clone();
			this.seasonEndTime_ = other.seasonEndTime_;
			this.updateSeason_ = other.updateSeason_;
			this.existEndlessRecord_ = other.existEndlessRecord_;
			this.buffCache_ = other.buffCache_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F1C RID: 102172 RVA: 0x003A131B File Offset: 0x0039F51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoResponse Clone()
		{
			return new SlashAndTowerInfoResponse(this);
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x06018F1D RID: 102173 RVA: 0x003A1323 File Offset: 0x0039F523
		// (set) Token: 0x06018F1E RID: 102174 RVA: 0x003A132B File Offset: 0x0039F52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06018F1F RID: 102175 RVA: 0x003A1334 File Offset: 0x0039F534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelPlayInfo> SlashLevelPlayInfos
		{
			get
			{
				return this.slashLevelPlayInfos_;
			}
		}

		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06018F20 RID: 102176 RVA: 0x003A133C File Offset: 0x0039F53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceivedAward
		{
			get
			{
				return this.receivedAward_;
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06018F21 RID: 102177 RVA: 0x003A1344 File Offset: 0x0039F544
		// (set) Token: 0x06018F22 RID: 102178 RVA: 0x003A134C File Offset: 0x0039F54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SeasonEndTime
		{
			get
			{
				return this.seasonEndTime_;
			}
			set
			{
				this.seasonEndTime_ = value;
			}
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x06018F23 RID: 102179 RVA: 0x003A1355 File Offset: 0x0039F555
		// (set) Token: 0x06018F24 RID: 102180 RVA: 0x003A135D File Offset: 0x0039F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UpdateSeason
		{
			get
			{
				return this.updateSeason_;
			}
			set
			{
				this.updateSeason_ = value;
			}
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x06018F25 RID: 102181 RVA: 0x003A1366 File Offset: 0x0039F566
		// (set) Token: 0x06018F26 RID: 102182 RVA: 0x003A136E File Offset: 0x0039F56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ExistEndlessRecord
		{
			get
			{
				return this.existEndlessRecord_;
			}
			set
			{
				this.existEndlessRecord_ = value;
			}
		}

		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x06018F27 RID: 102183 RVA: 0x003A1377 File Offset: 0x0039F577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffCache
		{
			get
			{
				return this.buffCache_;
			}
		}

		// Token: 0x06018F28 RID: 102184 RVA: 0x003A137F File Offset: 0x0039F57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerInfoResponse);
		}

		// Token: 0x06018F29 RID: 102185 RVA: 0x003A1390 File Offset: 0x0039F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.slashLevelPlayInfos_.Equals(other.slashLevelPlayInfos_) && this.receivedAward_.Equals(other.receivedAward_) && this.SeasonEndTime == other.SeasonEndTime && this.UpdateSeason == other.UpdateSeason && this.ExistEndlessRecord == other.ExistEndlessRecord && this.buffCache_.Equals(other.buffCache_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F2A RID: 102186 RVA: 0x003A1438 File Offset: 0x0039F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.slashLevelPlayInfos_.GetHashCode();
			num ^= this.receivedAward_.GetHashCode();
			if (this.SeasonEndTime != 0L)
			{
				num ^= this.SeasonEndTime.GetHashCode();
			}
			if (this.UpdateSeason)
			{
				num ^= this.UpdateSeason.GetHashCode();
			}
			if (this.ExistEndlessRecord)
			{
				num ^= this.ExistEndlessRecord.GetHashCode();
			}
			num ^= this.buffCache_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F2B RID: 102187 RVA: 0x003A14F2 File Offset: 0x0039F6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F2C RID: 102188 RVA: 0x003A14FF File Offset: 0x0039F6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F2D RID: 102189 RVA: 0x003A1508 File Offset: 0x0039F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slashLevelPlayInfos_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_slashLevelPlayInfos_codec);
			this.receivedAward_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_receivedAward_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.buffCache_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_buffCache_codec);
			if (this.ExistEndlessRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ExistEndlessRecord);
			}
			if (this.SeasonEndTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SeasonEndTime);
			}
			if (this.UpdateSeason)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.UpdateSeason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F2E RID: 102190 RVA: 0x003A15CC File Offset: 0x0039F7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.slashLevelPlayInfos_.CalculateSize(SlashAndTowerInfoResponse._repeated_slashLevelPlayInfos_codec);
			num += this.receivedAward_.CalculateSize(SlashAndTowerInfoResponse._repeated_receivedAward_codec);
			if (this.SeasonEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SeasonEndTime);
			}
			if (this.UpdateSeason)
			{
				num += 2;
			}
			if (this.ExistEndlessRecord)
			{
				num += 2;
			}
			num += this.buffCache_.CalculateSize(SlashAndTowerInfoResponse._repeated_buffCache_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F2F RID: 102191 RVA: 0x003A1674 File Offset: 0x0039F874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.slashLevelPlayInfos_.Add(other.slashLevelPlayInfos_);
			this.receivedAward_.Add(other.receivedAward_);
			if (other.SeasonEndTime != 0L)
			{
				this.SeasonEndTime = other.SeasonEndTime;
			}
			if (other.UpdateSeason)
			{
				this.UpdateSeason = other.UpdateSeason;
			}
			if (other.ExistEndlessRecord)
			{
				this.ExistEndlessRecord = other.ExistEndlessRecord;
			}
			this.buffCache_.Add(other.buffCache_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F30 RID: 102192 RVA: 0x003A171F File Offset: 0x0039F91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F31 RID: 102193 RVA: 0x003A1728 File Offset: 0x0039F928
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
					if (num <= 56U)
					{
						if (num == 34U)
						{
							this.slashLevelPlayInfos_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_slashLevelPlayInfos_codec);
							continue;
						}
						if (num != 56U)
						{
							goto IL_4E;
						}
					}
					else if (num != 58U)
					{
						if (num != 64U)
						{
							goto IL_4E;
						}
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					this.receivedAward_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_receivedAward_codec);
					continue;
				}
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.buffCache_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_buffCache_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ExistEndlessRecord = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.SeasonEndTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.UpdateSeason = input.ReadBool();
						continue;
					}
				}
				IL_4E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400930E RID: 37646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400930F RID: 37647
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009310 RID: 37648
		private ErrorCode errorCode_;

		// Token: 0x04009311 RID: 37649
		public const int SlashLevelPlayInfosFieldNumber = 4;

		// Token: 0x04009312 RID: 37650
		private static readonly FieldCodec<SlashLevelPlayInfo> _repeated_slashLevelPlayInfos_codec = FieldCodec.ForMessage<SlashLevelPlayInfo>(34U, SlashLevelPlayInfo.Parser);

		// Token: 0x04009313 RID: 37651
		private readonly RepeatedField<SlashLevelPlayInfo> slashLevelPlayInfos_ = new RepeatedField<SlashLevelPlayInfo>();

		// Token: 0x04009314 RID: 37652
		public const int ReceivedAwardFieldNumber = 7;

		// Token: 0x04009315 RID: 37653
		private static readonly FieldCodec<int> _repeated_receivedAward_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04009316 RID: 37654
		private readonly RepeatedField<int> receivedAward_ = new RepeatedField<int>();

		// Token: 0x04009317 RID: 37655
		public const int SeasonEndTimeFieldNumber = 14;

		// Token: 0x04009318 RID: 37656
		private long seasonEndTime_;

		// Token: 0x04009319 RID: 37657
		public const int UpdateSeasonFieldNumber = 15;

		// Token: 0x0400931A RID: 37658
		private bool updateSeason_;

		// Token: 0x0400931B RID: 37659
		public const int ExistEndlessRecordFieldNumber = 13;

		// Token: 0x0400931C RID: 37660
		private bool existEndlessRecord_;

		// Token: 0x0400931D RID: 37661
		public const int BuffCacheFieldNumber = 10;

		// Token: 0x0400931E RID: 37662
		private static readonly FieldCodec<int> _repeated_buffCache_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400931F RID: 37663
		private readonly RepeatedField<int> buffCache_ = new RepeatedField<int>();
	}
}
