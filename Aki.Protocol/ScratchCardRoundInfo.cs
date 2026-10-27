using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A2 RID: 4514
	public sealed class ScratchCardRoundInfo : IMessage<ScratchCardRoundInfo>, IMessage, IEquatable<ScratchCardRoundInfo>, IDeepCloneable<ScratchCardRoundInfo>, IBufferMessage
	{
		// Token: 0x060180D2 RID: 98514 RVA: 0x0037E006 File Offset: 0x0037C206
		[NullableContext(1)]
		public static ScratchCardRoundInfo Create()
		{
			return new ScratchCardRoundInfo();
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x060180D3 RID: 98515 RVA: 0x0037E00D File Offset: 0x0037C20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardRoundInfo> Parser
		{
			get
			{
				return ScratchCardRoundInfo._parser;
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x060180D4 RID: 98516 RVA: 0x0037E014 File Offset: 0x0037C214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x060180D5 RID: 98517 RVA: 0x0037E017 File Offset: 0x0037C217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRoundInfo.Descriptor;
			}
		}

		// Token: 0x060180D6 RID: 98518 RVA: 0x0037E01E File Offset: 0x0037C21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRoundInfo()
		{
		}

		// Token: 0x060180D7 RID: 98519 RVA: 0x0037E03C File Offset: 0x0037C23C
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

		// Token: 0x060180D8 RID: 98520 RVA: 0x0037E09A File Offset: 0x0037C29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRoundInfo Clone()
		{
			return new ScratchCardRoundInfo(this);
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x060180D9 RID: 98521 RVA: 0x0037E0A2 File Offset: 0x0037C2A2
		// (set) Token: 0x060180DA RID: 98522 RVA: 0x0037E0AA File Offset: 0x0037C2AA
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

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x060180DB RID: 98523 RVA: 0x0037E0B3 File Offset: 0x0037C2B3
		// (set) Token: 0x060180DC RID: 98524 RVA: 0x0037E0BB File Offset: 0x0037C2BB
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

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x060180DD RID: 98525 RVA: 0x0037E0C4 File Offset: 0x0037C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ScratchCardRewardData> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x060180DE RID: 98526 RVA: 0x0037E0CC File Offset: 0x0037C2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LeftRewardItem
		{
			get
			{
				return this.leftRewardItem_;
			}
		}

		// Token: 0x060180DF RID: 98527 RVA: 0x0037E0D4 File Offset: 0x0037C2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRoundInfo);
		}

		// Token: 0x060180E0 RID: 98528 RVA: 0x0037E0E4 File Offset: 0x0037C2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRoundInfo other)
		{
			return other != null && (other == this || (this.RoundId == other.RoundId && this.UnlockTime == other.UnlockTime && this.RewardIds.Equals(other.RewardIds) && this.LeftRewardItem.Equals(other.LeftRewardItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180E1 RID: 98529 RVA: 0x0037E158 File Offset: 0x0037C358
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

		// Token: 0x060180E2 RID: 98530 RVA: 0x0037E1CC File Offset: 0x0037C3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180E3 RID: 98531 RVA: 0x0037E1D9 File Offset: 0x0037C3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180E4 RID: 98532 RVA: 0x0037E1E4 File Offset: 0x0037C3E4
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

		// Token: 0x060180E5 RID: 98533 RVA: 0x0037E260 File Offset: 0x0037C460
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

		// Token: 0x060180E6 RID: 98534 RVA: 0x0037E2DC File Offset: 0x0037C4DC
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

		// Token: 0x060180E7 RID: 98535 RVA: 0x0037E34E File Offset: 0x0037C54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180E8 RID: 98536 RVA: 0x0037E358 File Offset: 0x0037C558
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

		// Token: 0x04008E60 RID: 36448
		private static readonly MessageParser<ScratchCardRoundInfo> _parser = new MessageParser<ScratchCardRoundInfo>(() => new ScratchCardRoundInfo());

		// Token: 0x04008E61 RID: 36449
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E62 RID: 36450
		public const int RoundIdFieldNumber = 1;

		// Token: 0x04008E63 RID: 36451
		private int roundId_;

		// Token: 0x04008E64 RID: 36452
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04008E65 RID: 36453
		private long unlockTime_;

		// Token: 0x04008E66 RID: 36454
		public const int RewardIdsFieldNumber = 3;

		// Token: 0x04008E67 RID: 36455
		private static readonly MapField<int, ScratchCardRewardData>.Codec _map_rewardIds_codec = new MapField<int, ScratchCardRewardData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ScratchCardRewardData>(18U, ScratchCardRewardData.Parser), 26U);

		// Token: 0x04008E68 RID: 36456
		private readonly MapField<int, ScratchCardRewardData> rewardIds_ = new MapField<int, ScratchCardRewardData>();

		// Token: 0x04008E69 RID: 36457
		public const int LeftRewardItemFieldNumber = 4;

		// Token: 0x04008E6A RID: 36458
		private static readonly MapField<int, int>.Codec _map_leftRewardItem_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04008E6B RID: 36459
		private readonly MapField<int, int> leftRewardItem_ = new MapField<int, int>();
	}
}
