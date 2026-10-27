using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000135 RID: 309
	[NetMessage(EMessageId.AvoidBlockSettlementNotify)]
	public sealed class AvoidBlockSettlementNotify : IMessage<AvoidBlockSettlementNotify>, IMessage, IEquatable<AvoidBlockSettlementNotify>, IDeepCloneable<AvoidBlockSettlementNotify>, IBufferMessage
	{
		// Token: 0x06002891 RID: 10385 RVA: 0x0006AC19 File Offset: 0x00068E19
		[NullableContext(1)]
		public static AvoidBlockSettlementNotify Create()
		{
			return new AvoidBlockSettlementNotify();
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0006AC20 File Offset: 0x00068E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0006AC23 File Offset: 0x00068E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSettlementNotify.Descriptor;
			}
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0006AC2A File Offset: 0x00068E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSettlementNotify()
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0006AC40 File Offset: 0x00068E40
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

		// Token: 0x06002896 RID: 10390 RVA: 0x0006ACA5 File Offset: 0x00068EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSettlementNotify Clone()
		{
			return new AvoidBlockSettlementNotify(this);
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x0006ACAD File Offset: 0x00068EAD
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x0006ACB5 File Offset: 0x00068EB5
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

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0006ACBE File Offset: 0x00068EBE
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x0006ACC6 File Offset: 0x00068EC6
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x0006ACCF File Offset: 0x00068ECF
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x0006ACD7 File Offset: 0x00068ED7
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0006ACE0 File Offset: 0x00068EE0
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x0006ACE8 File Offset: 0x00068EE8
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0006ACF1 File Offset: 0x00068EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItemMap
		{
			get
			{
				return this.rewardItemMap_;
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0006ACF9 File Offset: 0x00068EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSettlementNotify);
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0006AD08 File Offset: 0x00068F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSettlementNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Win == other.Win && this.IsFirstPass == other.IsFirstPass && this.HistoryScore == other.HistoryScore && this.RewardItemMap.Equals(other.RewardItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0006AD88 File Offset: 0x00068F88
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

		// Token: 0x060028A3 RID: 10403 RVA: 0x0006AE20 File Offset: 0x00069020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0006AE2D File Offset: 0x0006902D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0006AE38 File Offset: 0x00069038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Win);
			}
			if (this.IsFirstPass)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFirstPass);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			this.rewardItemMap_.WriteTo(ref output, AvoidBlockSettlementNotify._map_rewardItemMap_codec);
			if (this.HistoryScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HistoryScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0006AEDC File Offset: 0x000690DC
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

		// Token: 0x060028A7 RID: 10407 RVA: 0x0006AF60 File Offset: 0x00069160
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

		// Token: 0x060028A8 RID: 10408 RVA: 0x0006AFE9 File Offset: 0x000691E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0006AFF4 File Offset: 0x000691F4
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Win = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.IsFirstPass = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.rewardItemMap_.AddEntriesFrom(ref input, AvoidBlockSettlementNotify._map_rewardItemMap_codec);
						continue;
					}
					if (num == 112U)
					{
						this.HistoryScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026AE RID: 9902
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026AF RID: 9903
		public const int InstIdFieldNumber = 11;

		// Token: 0x040026B0 RID: 9904
		private int instId_;

		// Token: 0x040026B1 RID: 9905
		public const int WinFieldNumber = 1;

		// Token: 0x040026B2 RID: 9906
		private bool win_;

		// Token: 0x040026B3 RID: 9907
		public const int IsFirstPassFieldNumber = 7;

		// Token: 0x040026B4 RID: 9908
		private bool isFirstPass_;

		// Token: 0x040026B5 RID: 9909
		public const int HistoryScoreFieldNumber = 14;

		// Token: 0x040026B6 RID: 9910
		private int historyScore_;

		// Token: 0x040026B7 RID: 9911
		public const int RewardItemMapFieldNumber = 12;

		// Token: 0x040026B8 RID: 9912
		private static readonly MapField<int, int>.Codec _map_rewardItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x040026B9 RID: 9913
		private readonly MapField<int, int> rewardItemMap_ = new MapField<int, int>();
	}
}
