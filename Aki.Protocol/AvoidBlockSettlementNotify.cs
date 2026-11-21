using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000138 RID: 312
	[NetMessage(EMessageId.AvoidBlockSettlementNotify)]
	public sealed class AvoidBlockSettlementNotify : IMessage<AvoidBlockSettlementNotify>, IMessage, IEquatable<AvoidBlockSettlementNotify>, IDeepCloneable<AvoidBlockSettlementNotify>, IBufferMessage
	{
		// Token: 0x06002908 RID: 10504 RVA: 0x0006C050 File Offset: 0x0006A250
		[NullableContext(1)]
		public static AvoidBlockSettlementNotify Create()
		{
			return new AvoidBlockSettlementNotify();
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0006C057 File Offset: 0x0006A257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x0006C05A File Offset: 0x0006A25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSettlementNotify.Descriptor;
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0006C061 File Offset: 0x0006A261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSettlementNotify()
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0006C074 File Offset: 0x0006A274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSettlementNotify(AvoidBlockSettlementNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.win_ = other.win_;
			this.isFirstPass_ = other.isFirstPass_;
			this.historyScore_ = other.historyScore_;
			this.rewardItemMap_ = other.rewardItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0006C0D9 File Offset: 0x0006A2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSettlementNotify Clone()
		{
			return new AvoidBlockSettlementNotify(this);
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x0006C0E1 File Offset: 0x0006A2E1
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x0006C0E9 File Offset: 0x0006A2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x0006C0F2 File Offset: 0x0006A2F2
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x0006C0FA File Offset: 0x0006A2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x0006C103 File Offset: 0x0006A303
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x0006C10B File Offset: 0x0006A30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirstPass
		{
			get
			{
				return this.isFirstPass_;
			}
			set
			{
				this.isFirstPass_ = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x0006C114 File Offset: 0x0006A314
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x0006C11C File Offset: 0x0006A31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryScore
		{
			get
			{
				return this.historyScore_;
			}
			set
			{
				this.historyScore_ = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x0006C125 File Offset: 0x0006A325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItemMap
		{
			get
			{
				return this.rewardItemMap_;
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0006C12D File Offset: 0x0006A32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSettlementNotify);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0006C13C File Offset: 0x0006A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSettlementNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Win == other.Win && this.IsFirstPass == other.IsFirstPass && this.HistoryScore == other.HistoryScore && this.RewardItemMap.Equals(other.RewardItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0006C1BC File Offset: 0x0006A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.IsFirstPass)
			{
				num ^= this.IsFirstPass.GetHashCode();
			}
			if (this.HistoryScore != 0)
			{
				num ^= this.HistoryScore.GetHashCode();
			}
			num ^= this.RewardItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0006C254 File Offset: 0x0006A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0006C261 File Offset: 0x0006A461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0006C26C File Offset: 0x0006A46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Win);
			}
			this.rewardItemMap_.WriteTo(ref output, AvoidBlockSettlementNotify._map_rewardItemMap_codec);
			if (this.HistoryScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HistoryScore);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this.IsFirstPass)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsFirstPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0006C310 File Offset: 0x0006A510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.IsFirstPass)
			{
				num += 2;
			}
			if (this.HistoryScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryScore);
			}
			num += this.rewardItemMap_.CalculateSize(AvoidBlockSettlementNotify._map_rewardItemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0006C394 File Offset: 0x0006A594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockSettlementNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.IsFirstPass)
			{
				this.IsFirstPass = other.IsFirstPass;
			}
			if (other.HistoryScore != 0)
			{
				this.HistoryScore = other.HistoryScore;
			}
			this.rewardItemMap_.MergeFrom(other.rewardItemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0006C41D File Offset: 0x0006A61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x0006C428 File Offset: 0x0006A628
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
					if (num == 16U)
					{
						this.Win = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.rewardItemMap_.AddEntriesFrom(ref input, AvoidBlockSettlementNotify._map_rewardItemMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HistoryScore = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsFirstPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002722 RID: 10018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002723 RID: 10019
		public const int InstIdFieldNumber = 12;

		// Token: 0x04002724 RID: 10020
		private int instId_;

		// Token: 0x04002725 RID: 10021
		public const int WinFieldNumber = 2;

		// Token: 0x04002726 RID: 10022
		private bool win_;

		// Token: 0x04002727 RID: 10023
		public const int IsFirstPassFieldNumber = 14;

		// Token: 0x04002728 RID: 10024
		private bool isFirstPass_;

		// Token: 0x04002729 RID: 10025
		public const int HistoryScoreFieldNumber = 9;

		// Token: 0x0400272A RID: 10026
		private int historyScore_;

		// Token: 0x0400272B RID: 10027
		public const int RewardItemMapFieldNumber = 8;

		// Token: 0x0400272C RID: 10028
		private static readonly MapField<int, int>.Codec _map_rewardItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x0400272D RID: 10029
		private readonly MapField<int, int> rewardItemMap_ = new MapField<int, int>();
	}
}
