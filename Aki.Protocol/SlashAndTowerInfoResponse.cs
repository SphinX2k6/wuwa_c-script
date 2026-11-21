using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001286 RID: 4742
	[NetMessage(EMessageId.SlashAndTowerInfoResponse)]
	public sealed class SlashAndTowerInfoResponse : IMessage<SlashAndTowerInfoResponse>, IMessage, IEquatable<SlashAndTowerInfoResponse>, IDeepCloneable<SlashAndTowerInfoResponse>, IBufferMessage
	{
		// Token: 0x06019501 RID: 103681 RVA: 0x003B11BA File Offset: 0x003AF3BA
		[NullableContext(1)]
		public static SlashAndTowerInfoResponse Create()
		{
			return new SlashAndTowerInfoResponse();
		}

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x06019502 RID: 103682 RVA: 0x003B11C1 File Offset: 0x003AF3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x06019503 RID: 103683 RVA: 0x003B11C4 File Offset: 0x003AF3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerInfoResponse.Descriptor;
			}
		}

		// Token: 0x06019504 RID: 103684 RVA: 0x003B11CB File Offset: 0x003AF3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoResponse()
		{
		}

		// Token: 0x06019505 RID: 103685 RVA: 0x003B11F4 File Offset: 0x003AF3F4
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

		// Token: 0x06019506 RID: 103686 RVA: 0x003B127B File Offset: 0x003AF47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerInfoResponse Clone()
		{
			return new SlashAndTowerInfoResponse(this);
		}

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x06019507 RID: 103687 RVA: 0x003B1283 File Offset: 0x003AF483
		// (set) Token: 0x06019508 RID: 103688 RVA: 0x003B128B File Offset: 0x003AF48B
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

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x06019509 RID: 103689 RVA: 0x003B1294 File Offset: 0x003AF494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelPlayInfo> SlashLevelPlayInfos
		{
			get
			{
				return this.slashLevelPlayInfos_;
			}
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x0601950A RID: 103690 RVA: 0x003B129C File Offset: 0x003AF49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceivedAward
		{
			get
			{
				return this.receivedAward_;
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x0601950B RID: 103691 RVA: 0x003B12A4 File Offset: 0x003AF4A4
		// (set) Token: 0x0601950C RID: 103692 RVA: 0x003B12AC File Offset: 0x003AF4AC
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

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x0601950D RID: 103693 RVA: 0x003B12B5 File Offset: 0x003AF4B5
		// (set) Token: 0x0601950E RID: 103694 RVA: 0x003B12BD File Offset: 0x003AF4BD
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

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x0601950F RID: 103695 RVA: 0x003B12C6 File Offset: 0x003AF4C6
		// (set) Token: 0x06019510 RID: 103696 RVA: 0x003B12CE File Offset: 0x003AF4CE
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

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x06019511 RID: 103697 RVA: 0x003B12D7 File Offset: 0x003AF4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffCache
		{
			get
			{
				return this.buffCache_;
			}
		}

		// Token: 0x06019512 RID: 103698 RVA: 0x003B12DF File Offset: 0x003AF4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerInfoResponse);
		}

		// Token: 0x06019513 RID: 103699 RVA: 0x003B12F0 File Offset: 0x003AF4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.slashLevelPlayInfos_.Equals(other.slashLevelPlayInfos_) && this.receivedAward_.Equals(other.receivedAward_) && this.SeasonEndTime == other.SeasonEndTime && this.UpdateSeason == other.UpdateSeason && this.ExistEndlessRecord == other.ExistEndlessRecord && this.buffCache_.Equals(other.buffCache_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019514 RID: 103700 RVA: 0x003B1398 File Offset: 0x003AF598
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

		// Token: 0x06019515 RID: 103701 RVA: 0x003B1452 File Offset: 0x003AF652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019516 RID: 103702 RVA: 0x003B145F File Offset: 0x003AF65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019517 RID: 103703 RVA: 0x003B1468 File Offset: 0x003AF668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExistEndlessRecord)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ExistEndlessRecord);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.slashLevelPlayInfos_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_slashLevelPlayInfos_codec);
			this.buffCache_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_buffCache_codec);
			if (this.UpdateSeason)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.UpdateSeason);
			}
			if (this.SeasonEndTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SeasonEndTime);
			}
			this.receivedAward_.WriteTo(ref output, SlashAndTowerInfoResponse._repeated_receivedAward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019518 RID: 103704 RVA: 0x003B152C File Offset: 0x003AF72C
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

		// Token: 0x06019519 RID: 103705 RVA: 0x003B15D4 File Offset: 0x003AF7D4
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

		// Token: 0x0601951A RID: 103706 RVA: 0x003B167F File Offset: 0x003AF87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601951B RID: 103707 RVA: 0x003B1688 File Offset: 0x003AF888
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
				if (num <= 80U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.ExistEndlessRecord = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							this.slashLevelPlayInfos_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_slashLevelPlayInfos_codec);
							continue;
						}
						if (num == 80U)
						{
							goto IL_90;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 82U)
					{
						goto IL_90;
					}
					if (num == 88U)
					{
						this.UpdateSeason = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.SeasonEndTime = input.ReadInt64();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.receivedAward_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_receivedAward_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_90:
				this.buffCache_.AddEntriesFrom(ref input, SlashAndTowerInfoResponse._repeated_buffCache_codec);
			}
		}

		// Token: 0x040095C0 RID: 38336
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095C1 RID: 38337
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040095C2 RID: 38338
		private ErrorCode errorCode_;

		// Token: 0x040095C3 RID: 38339
		public const int SlashLevelPlayInfosFieldNumber = 8;

		// Token: 0x040095C4 RID: 38340
		private static readonly FieldCodec<SlashLevelPlayInfo> _repeated_slashLevelPlayInfos_codec = FieldCodec.ForMessage<SlashLevelPlayInfo>(66U, SlashLevelPlayInfo.Parser);

		// Token: 0x040095C5 RID: 38341
		private readonly RepeatedField<SlashLevelPlayInfo> slashLevelPlayInfos_ = new RepeatedField<SlashLevelPlayInfo>();

		// Token: 0x040095C6 RID: 38342
		public const int ReceivedAwardFieldNumber = 14;

		// Token: 0x040095C7 RID: 38343
		private static readonly FieldCodec<int> _repeated_receivedAward_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040095C8 RID: 38344
		private readonly RepeatedField<int> receivedAward_ = new RepeatedField<int>();

		// Token: 0x040095C9 RID: 38345
		public const int SeasonEndTimeFieldNumber = 12;

		// Token: 0x040095CA RID: 38346
		private long seasonEndTime_;

		// Token: 0x040095CB RID: 38347
		public const int UpdateSeasonFieldNumber = 11;

		// Token: 0x040095CC RID: 38348
		private bool updateSeason_;

		// Token: 0x040095CD RID: 38349
		public const int ExistEndlessRecordFieldNumber = 1;

		// Token: 0x040095CE RID: 38350
		private bool existEndlessRecord_;

		// Token: 0x040095CF RID: 38351
		public const int BuffCacheFieldNumber = 10;

		// Token: 0x040095D0 RID: 38352
		private static readonly FieldCodec<int> _repeated_buffCache_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040095D1 RID: 38353
		private readonly RepeatedField<int> buffCache_ = new RepeatedField<int>();
	}
}
