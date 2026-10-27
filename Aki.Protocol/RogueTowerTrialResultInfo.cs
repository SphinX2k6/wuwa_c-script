using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101E RID: 4126
	public sealed class RogueTowerTrialResultInfo : IMessage<RogueTowerTrialResultInfo>, IMessage, IEquatable<RogueTowerTrialResultInfo>, IDeepCloneable<RogueTowerTrialResultInfo>, IBufferMessage
	{
		// Token: 0x060160E8 RID: 90344 RVA: 0x00334935 File Offset: 0x00332B35
		[NullableContext(1)]
		public static RogueTowerTrialResultInfo Create()
		{
			return new RogueTowerTrialResultInfo();
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x060160E9 RID: 90345 RVA: 0x0033493C File Offset: 0x00332B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x060160EA RID: 90346 RVA: 0x0033493F File Offset: 0x00332B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultInfo.Descriptor;
			}
		}

		// Token: 0x060160EB RID: 90347 RVA: 0x00334946 File Offset: 0x00332B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo()
		{
		}

		// Token: 0x060160EC RID: 90348 RVA: 0x0033495C File Offset: 0x00332B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo(RogueTowerTrialResultInfo other) : this()
		{
			this.isNewRecord_ = other.isNewRecord_;
			this.totalCostTime_ = other.totalCostTime_;
			this.ids_ = other.ids_.Clone();
			this.challengingBossId_ = other.challengingBossId_;
			this.maxCount_ = other.maxCount_;
			this.slotId_ = other.slotId_;
			this.historyMaxKills_ = other.historyMaxKills_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160ED RID: 90349 RVA: 0x003349D9 File Offset: 0x00332BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo Clone()
		{
			return new RogueTowerTrialResultInfo(this);
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x060160EE RID: 90350 RVA: 0x003349E1 File Offset: 0x00332BE1
		// (set) Token: 0x060160EF RID: 90351 RVA: 0x003349E9 File Offset: 0x00332BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x060160F0 RID: 90352 RVA: 0x003349F2 File Offset: 0x00332BF2
		// (set) Token: 0x060160F1 RID: 90353 RVA: 0x003349FA File Offset: 0x00332BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCostTime
		{
			get
			{
				return this.totalCostTime_;
			}
			set
			{
				this.totalCostTime_ = value;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x060160F2 RID: 90354 RVA: 0x00334A03 File Offset: 0x00332C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x060160F3 RID: 90355 RVA: 0x00334A0B File Offset: 0x00332C0B
		// (set) Token: 0x060160F4 RID: 90356 RVA: 0x00334A13 File Offset: 0x00332C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengingBossId
		{
			get
			{
				return this.challengingBossId_;
			}
			set
			{
				this.challengingBossId_ = value;
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x060160F5 RID: 90357 RVA: 0x00334A1C File Offset: 0x00332C1C
		// (set) Token: 0x060160F6 RID: 90358 RVA: 0x00334A24 File Offset: 0x00332C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxCount
		{
			get
			{
				return this.maxCount_;
			}
			set
			{
				this.maxCount_ = value;
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x060160F7 RID: 90359 RVA: 0x00334A2D File Offset: 0x00332C2D
		// (set) Token: 0x060160F8 RID: 90360 RVA: 0x00334A35 File Offset: 0x00332C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x060160F9 RID: 90361 RVA: 0x00334A3E File Offset: 0x00332C3E
		// (set) Token: 0x060160FA RID: 90362 RVA: 0x00334A46 File Offset: 0x00332C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryMaxKills
		{
			get
			{
				return this.historyMaxKills_;
			}
			set
			{
				this.historyMaxKills_ = value;
			}
		}

		// Token: 0x060160FB RID: 90363 RVA: 0x00334A4F File Offset: 0x00332C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultInfo);
		}

		// Token: 0x060160FC RID: 90364 RVA: 0x00334A60 File Offset: 0x00332C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultInfo other)
		{
			return other != null && (other == this || (this.IsNewRecord == other.IsNewRecord && this.TotalCostTime == other.TotalCostTime && this.ids_.Equals(other.ids_) && this.ChallengingBossId == other.ChallengingBossId && this.MaxCount == other.MaxCount && this.SlotId == other.SlotId && this.HistoryMaxKills == other.HistoryMaxKills && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160FD RID: 90365 RVA: 0x00334B00 File Offset: 0x00332D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.TotalCostTime != 0)
			{
				num ^= this.TotalCostTime.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this.ChallengingBossId != 0)
			{
				num ^= this.ChallengingBossId.GetHashCode();
			}
			if (this.MaxCount != 0)
			{
				num ^= this.MaxCount.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.HistoryMaxKills != 0)
			{
				num ^= this.HistoryMaxKills.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060160FE RID: 90366 RVA: 0x00334BCA File Offset: 0x00332DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160FF RID: 90367 RVA: 0x00334BD7 File Offset: 0x00332DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016100 RID: 90368 RVA: 0x00334BE0 File Offset: 0x00332DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNewRecord)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNewRecord);
			}
			this.ids_.WriteTo(ref output, RogueTowerTrialResultInfo._repeated_ids_codec);
			if (this.ChallengingBossId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChallengingBossId);
			}
			if (this.MaxCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxCount);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SlotId);
			}
			if (this.HistoryMaxKills != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.HistoryMaxKills);
			}
			if (this.TotalCostTime != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TotalCostTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016101 RID: 90369 RVA: 0x00334CBC File Offset: 0x00332EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.TotalCostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCostTime);
			}
			num += this.ids_.CalculateSize(RogueTowerTrialResultInfo._repeated_ids_codec);
			if (this.ChallengingBossId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengingBossId);
			}
			if (this.MaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxCount);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.HistoryMaxKills != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryMaxKills);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016102 RID: 90370 RVA: 0x00334D7C File Offset: 0x00332F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.TotalCostTime != 0)
			{
				this.TotalCostTime = other.TotalCostTime;
			}
			this.ids_.Add(other.ids_);
			if (other.ChallengingBossId != 0)
			{
				this.ChallengingBossId = other.ChallengingBossId;
			}
			if (other.MaxCount != 0)
			{
				this.MaxCount = other.MaxCount;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.HistoryMaxKills != 0)
			{
				this.HistoryMaxKills = other.HistoryMaxKills;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016103 RID: 90371 RVA: 0x00334E2D File Offset: 0x0033302D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016104 RID: 90372 RVA: 0x00334E38 File Offset: 0x00333038
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
				if (num <= 24U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.IsNewRecord = input.ReadBool();
							continue;
						}
						if (num != 16U)
						{
							goto IL_48;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_48;
						}
						this.ChallengingBossId = input.ReadInt32();
						continue;
					}
					this.ids_.AddEntriesFrom(ref input, RogueTowerTrialResultInfo._repeated_ids_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.MaxCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.SlotId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.HistoryMaxKills = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TotalCostTime = input.ReadInt32();
						continue;
					}
				}
				IL_48:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008433 RID: 33843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008434 RID: 33844
		public const int IsNewRecordFieldNumber = 1;

		// Token: 0x04008435 RID: 33845
		private bool isNewRecord_;

		// Token: 0x04008436 RID: 33846
		public const int TotalCostTimeFieldNumber = 13;

		// Token: 0x04008437 RID: 33847
		private int totalCostTime_;

		// Token: 0x04008438 RID: 33848
		public const int IdsFieldNumber = 2;

		// Token: 0x04008439 RID: 33849
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400843A RID: 33850
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x0400843B RID: 33851
		public const int ChallengingBossIdFieldNumber = 3;

		// Token: 0x0400843C RID: 33852
		private int challengingBossId_;

		// Token: 0x0400843D RID: 33853
		public const int MaxCountFieldNumber = 4;

		// Token: 0x0400843E RID: 33854
		private int maxCount_;

		// Token: 0x0400843F RID: 33855
		public const int SlotIdFieldNumber = 5;

		// Token: 0x04008440 RID: 33856
		private int slotId_;

		// Token: 0x04008441 RID: 33857
		public const int HistoryMaxKillsFieldNumber = 6;

		// Token: 0x04008442 RID: 33858
		private int historyMaxKills_;
	}
}
