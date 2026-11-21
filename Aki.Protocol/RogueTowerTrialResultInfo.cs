using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100E RID: 4110
	public sealed class RogueTowerTrialResultInfo : IMessage<RogueTowerTrialResultInfo>, IMessage, IEquatable<RogueTowerTrialResultInfo>, IDeepCloneable<RogueTowerTrialResultInfo>, IBufferMessage
	{
		// Token: 0x06016003 RID: 90115 RVA: 0x00333275 File Offset: 0x00331475
		[NullableContext(1)]
		public static RogueTowerTrialResultInfo Create()
		{
			return new RogueTowerTrialResultInfo();
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x06016004 RID: 90116 RVA: 0x0033327C File Offset: 0x0033147C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x06016005 RID: 90117 RVA: 0x0033327F File Offset: 0x0033147F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultInfo.Descriptor;
			}
		}

		// Token: 0x06016006 RID: 90118 RVA: 0x00333286 File Offset: 0x00331486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo()
		{
		}

		// Token: 0x06016007 RID: 90119 RVA: 0x0033329C File Offset: 0x0033149C
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

		// Token: 0x06016008 RID: 90120 RVA: 0x00333319 File Offset: 0x00331519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo Clone()
		{
			return new RogueTowerTrialResultInfo(this);
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x06016009 RID: 90121 RVA: 0x00333321 File Offset: 0x00331521
		// (set) Token: 0x0601600A RID: 90122 RVA: 0x00333329 File Offset: 0x00331529
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

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x0601600B RID: 90123 RVA: 0x00333332 File Offset: 0x00331532
		// (set) Token: 0x0601600C RID: 90124 RVA: 0x0033333A File Offset: 0x0033153A
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

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x0601600D RID: 90125 RVA: 0x00333343 File Offset: 0x00331543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x0601600E RID: 90126 RVA: 0x0033334B File Offset: 0x0033154B
		// (set) Token: 0x0601600F RID: 90127 RVA: 0x00333353 File Offset: 0x00331553
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

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x06016010 RID: 90128 RVA: 0x0033335C File Offset: 0x0033155C
		// (set) Token: 0x06016011 RID: 90129 RVA: 0x00333364 File Offset: 0x00331564
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

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x06016012 RID: 90130 RVA: 0x0033336D File Offset: 0x0033156D
		// (set) Token: 0x06016013 RID: 90131 RVA: 0x00333375 File Offset: 0x00331575
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

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x06016014 RID: 90132 RVA: 0x0033337E File Offset: 0x0033157E
		// (set) Token: 0x06016015 RID: 90133 RVA: 0x00333386 File Offset: 0x00331586
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

		// Token: 0x06016016 RID: 90134 RVA: 0x0033338F File Offset: 0x0033158F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultInfo);
		}

		// Token: 0x06016017 RID: 90135 RVA: 0x003333A0 File Offset: 0x003315A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultInfo other)
		{
			return other != null && (other == this || (this.IsNewRecord == other.IsNewRecord && this.TotalCostTime == other.TotalCostTime && this.ids_.Equals(other.ids_) && this.ChallengingBossId == other.ChallengingBossId && this.MaxCount == other.MaxCount && this.SlotId == other.SlotId && this.HistoryMaxKills == other.HistoryMaxKills && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016018 RID: 90136 RVA: 0x00333440 File Offset: 0x00331640
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

		// Token: 0x06016019 RID: 90137 RVA: 0x0033350A File Offset: 0x0033170A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601601A RID: 90138 RVA: 0x00333517 File Offset: 0x00331717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601601B RID: 90139 RVA: 0x00333520 File Offset: 0x00331720
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

		// Token: 0x0601601C RID: 90140 RVA: 0x003335FC File Offset: 0x003317FC
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

		// Token: 0x0601601D RID: 90141 RVA: 0x003336BC File Offset: 0x003318BC
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

		// Token: 0x0601601E RID: 90142 RVA: 0x0033376D File Offset: 0x0033196D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601601F RID: 90143 RVA: 0x00333778 File Offset: 0x00331978
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

		// Token: 0x0400845D RID: 33885
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400845E RID: 33886
		public const int IsNewRecordFieldNumber = 1;

		// Token: 0x0400845F RID: 33887
		private bool isNewRecord_;

		// Token: 0x04008460 RID: 33888
		public const int TotalCostTimeFieldNumber = 13;

		// Token: 0x04008461 RID: 33889
		private int totalCostTime_;

		// Token: 0x04008462 RID: 33890
		public const int IdsFieldNumber = 2;

		// Token: 0x04008463 RID: 33891
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008464 RID: 33892
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04008465 RID: 33893
		public const int ChallengingBossIdFieldNumber = 3;

		// Token: 0x04008466 RID: 33894
		private int challengingBossId_;

		// Token: 0x04008467 RID: 33895
		public const int MaxCountFieldNumber = 4;

		// Token: 0x04008468 RID: 33896
		private int maxCount_;

		// Token: 0x04008469 RID: 33897
		public const int SlotIdFieldNumber = 5;

		// Token: 0x0400846A RID: 33898
		private int slotId_;

		// Token: 0x0400846B RID: 33899
		public const int HistoryMaxKillsFieldNumber = 6;

		// Token: 0x0400846C RID: 33900
		private int historyMaxKills_;
	}
}
