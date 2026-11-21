using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DC RID: 4572
	public sealed class ScratchCardRoundInfo : IMessage<ScratchCardRoundInfo>, IMessage, IEquatable<ScratchCardRoundInfo>, IDeepCloneable<ScratchCardRoundInfo>, IBufferMessage
	{
		// Token: 0x06018673 RID: 99955 RVA: 0x0038D34A File Offset: 0x0038B54A
		[NullableContext(1)]
		public static ScratchCardRoundInfo Create()
		{
			return new ScratchCardRoundInfo();
		}

		// Token: 0x1700523E RID: 21054
		// (get) Token: 0x06018674 RID: 99956 RVA: 0x0038D351 File Offset: 0x0038B551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardRoundInfo> Parser
		{
			get
			{
				return ScratchCardRoundInfo._parser;
			}
		}

		// Token: 0x1700523F RID: 21055
		// (get) Token: 0x06018675 RID: 99957 RVA: 0x0038D358 File Offset: 0x0038B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x06018676 RID: 99958 RVA: 0x0038D35B File Offset: 0x0038B55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRoundInfo.Descriptor;
			}
		}

		// Token: 0x06018677 RID: 99959 RVA: 0x0038D362 File Offset: 0x0038B562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRoundInfo()
		{
		}

		// Token: 0x06018678 RID: 99960 RVA: 0x0038D380 File Offset: 0x0038B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRoundInfo(ScratchCardRoundInfo other) : this()
		{
			this.roundId_ = other.roundId_;
			this.unlockTime_ = other.unlockTime_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this.leftRewardItem_ = other.leftRewardItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018679 RID: 99961 RVA: 0x0038D3DE File Offset: 0x0038B5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRoundInfo Clone()
		{
			return new ScratchCardRoundInfo(this);
		}

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x0601867A RID: 99962 RVA: 0x0038D3E6 File Offset: 0x0038B5E6
		// (set) Token: 0x0601867B RID: 99963 RVA: 0x0038D3EE File Offset: 0x0038B5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundId
		{
			get
			{
				return this.roundId_;
			}
			set
			{
				this.roundId_ = value;
			}
		}

		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x0601867C RID: 99964 RVA: 0x0038D3F7 File Offset: 0x0038B5F7
		// (set) Token: 0x0601867D RID: 99965 RVA: 0x0038D3FF File Offset: 0x0038B5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x0601867E RID: 99966 RVA: 0x0038D408 File Offset: 0x0038B608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ScratchCardRewardData> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x0601867F RID: 99967 RVA: 0x0038D410 File Offset: 0x0038B610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LeftRewardItem
		{
			get
			{
				return this.leftRewardItem_;
			}
		}

		// Token: 0x06018680 RID: 99968 RVA: 0x0038D418 File Offset: 0x0038B618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRoundInfo);
		}

		// Token: 0x06018681 RID: 99969 RVA: 0x0038D428 File Offset: 0x0038B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRoundInfo other)
		{
			return other != null && (other == this || (this.RoundId == other.RoundId && this.UnlockTime == other.UnlockTime && this.RewardIds.Equals(other.RewardIds) && this.LeftRewardItem.Equals(other.LeftRewardItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018682 RID: 99970 RVA: 0x0038D49C File Offset: 0x0038B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundId != 0)
			{
				num ^= this.RoundId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			num ^= this.RewardIds.GetHashCode();
			num ^= this.LeftRewardItem.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018683 RID: 99971 RVA: 0x0038D510 File Offset: 0x0038B710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018684 RID: 99972 RVA: 0x0038D51D File Offset: 0x0038B71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018685 RID: 99973 RVA: 0x0038D528 File Offset: 0x0038B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoundId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			this.rewardIds_.WriteTo(ref output, ScratchCardRoundInfo._map_rewardIds_codec);
			this.leftRewardItem_.WriteTo(ref output, ScratchCardRoundInfo._map_leftRewardItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018686 RID: 99974 RVA: 0x0038D5A4 File Offset: 0x0038B7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			num += this.rewardIds_.CalculateSize(ScratchCardRoundInfo._map_rewardIds_codec);
			num += this.leftRewardItem_.CalculateSize(ScratchCardRoundInfo._map_leftRewardItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018687 RID: 99975 RVA: 0x0038D620 File Offset: 0x0038B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRoundInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundId != 0)
			{
				this.RoundId = other.RoundId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this.rewardIds_.MergeFrom(other.rewardIds_);
			this.leftRewardItem_.MergeFrom(other.leftRewardItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018688 RID: 99976 RVA: 0x0038D692 File Offset: 0x0038B892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018689 RID: 99977 RVA: 0x0038D69C File Offset: 0x0038B89C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoundId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.rewardIds_.AddEntriesFrom(ref input, ScratchCardRoundInfo._map_rewardIds_codec);
						continue;
					}
					if (num == 34U)
					{
						this.leftRewardItem_.AddEntriesFrom(ref input, ScratchCardRoundInfo._map_leftRewardItem_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040090F3 RID: 37107
		private static readonly MessageParser<ScratchCardRoundInfo> _parser = new MessageParser<ScratchCardRoundInfo>(() => new ScratchCardRoundInfo());

		// Token: 0x040090F4 RID: 37108
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090F5 RID: 37109
		public const int RoundIdFieldNumber = 1;

		// Token: 0x040090F6 RID: 37110
		private int roundId_;

		// Token: 0x040090F7 RID: 37111
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x040090F8 RID: 37112
		private long unlockTime_;

		// Token: 0x040090F9 RID: 37113
		public const int RewardIdsFieldNumber = 3;

		// Token: 0x040090FA RID: 37114
		private static readonly MapField<int, ScratchCardRewardData>.Codec _map_rewardIds_codec = new MapField<int, ScratchCardRewardData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ScratchCardRewardData>(18U, ScratchCardRewardData.Parser), 26U);

		// Token: 0x040090FB RID: 37115
		private readonly MapField<int, ScratchCardRewardData> rewardIds_ = new MapField<int, ScratchCardRewardData>();

		// Token: 0x040090FC RID: 37116
		public const int LeftRewardItemFieldNumber = 4;

		// Token: 0x040090FD RID: 37117
		private static readonly MapField<int, int>.Codec _map_leftRewardItem_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040090FE RID: 37118
		private readonly MapField<int, int> leftRewardItem_ = new MapField<int, int>();
	}
}
