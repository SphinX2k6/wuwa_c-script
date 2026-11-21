using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5A RID: 3930
	public sealed class RoadBookActivityInfo : IMessage<RoadBookActivityInfo>, IMessage, IEquatable<RoadBookActivityInfo>, IDeepCloneable<RoadBookActivityInfo>, IBufferMessage
	{
		// Token: 0x060150AB RID: 86187 RVA: 0x0030DA25 File Offset: 0x0030BC25
		[NullableContext(1)]
		public static RoadBookActivityInfo Create()
		{
			return new RoadBookActivityInfo();
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x060150AC RID: 86188 RVA: 0x0030DA2C File Offset: 0x0030BC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x060150AD RID: 86189 RVA: 0x0030DA2F File Offset: 0x0030BC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookActivityInfo.Descriptor;
			}
		}

		// Token: 0x060150AE RID: 86190 RVA: 0x0030DA36 File Offset: 0x0030BC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo()
		{
		}

		// Token: 0x060150AF RID: 86191 RVA: 0x0030DA6C File Offset: 0x0030BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo(RoadBookActivityInfo other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this.monsterGain_ = other.monsterGain_.Clone();
			this.getFullReward_ = other.getFullReward_;
			this.roadBookLevel_ = other.roadBookLevel_;
			this.unLockAreas_ = other.unLockAreas_.Clone();
			this.soarLevels_ = other.soarLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150B0 RID: 86192 RVA: 0x0030DAEC File Offset: 0x0030BCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo Clone()
		{
			return new RoadBookActivityInfo(this);
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x060150B1 RID: 86193 RVA: 0x0030DAF4 File Offset: 0x0030BCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x060150B2 RID: 86194 RVA: 0x0030DAFC File Offset: 0x0030BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x060150B3 RID: 86195 RVA: 0x0030DB04 File Offset: 0x0030BD04
		// (set) Token: 0x060150B4 RID: 86196 RVA: 0x0030DB0C File Offset: 0x0030BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GetFullReward
		{
			get
			{
				return this.getFullReward_;
			}
			set
			{
				this.getFullReward_ = value;
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x060150B5 RID: 86197 RVA: 0x0030DB15 File Offset: 0x0030BD15
		// (set) Token: 0x060150B6 RID: 86198 RVA: 0x0030DB1D File Offset: 0x0030BD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadBookLevel
		{
			get
			{
				return this.roadBookLevel_;
			}
			set
			{
				this.roadBookLevel_ = value;
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x060150B7 RID: 86199 RVA: 0x0030DB26 File Offset: 0x0030BD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x060150B8 RID: 86200 RVA: 0x0030DB2E File Offset: 0x0030BD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoadBookMotorcycleInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x060150B9 RID: 86201 RVA: 0x0030DB36 File Offset: 0x0030BD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookActivityInfo);
		}

		// Token: 0x060150BA RID: 86202 RVA: 0x0030DB44 File Offset: 0x0030BD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.RoadBookLevel == other.RoadBookLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150BB RID: 86203 RVA: 0x0030DBE4 File Offset: 0x0030BDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			num ^= this.monsterGain_.GetHashCode();
			if (this.GetFullReward)
			{
				num ^= this.GetFullReward.GetHashCode();
			}
			if (this.RoadBookLevel != 0)
			{
				num ^= this.RoadBookLevel.GetHashCode();
			}
			num ^= this.unLockAreas_.GetHashCode();
			num ^= this.soarLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060150BC RID: 86204 RVA: 0x0030DC74 File Offset: 0x0030BE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150BD RID: 86205 RVA: 0x0030DC81 File Offset: 0x0030BE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150BE RID: 86206 RVA: 0x0030DC8C File Offset: 0x0030BE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, RoadBookActivityInfo._repeated_activityTasks_codec);
			this.monsterGain_.WriteTo(ref output, RoadBookActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GetFullReward);
			}
			if (this.RoadBookLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoadBookLevel);
			}
			this.unLockAreas_.WriteTo(ref output, RoadBookActivityInfo._repeated_unLockAreas_codec);
			this.soarLevels_.WriteTo(ref output, RoadBookActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060150BF RID: 86207 RVA: 0x0030DD2C File Offset: 0x0030BF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(RoadBookActivityInfo._repeated_activityTasks_codec);
			num += this.monsterGain_.CalculateSize(RoadBookActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				num += 2;
			}
			if (this.RoadBookLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadBookLevel);
			}
			num += this.unLockAreas_.CalculateSize(RoadBookActivityInfo._repeated_unLockAreas_codec);
			num += this.soarLevels_.CalculateSize(RoadBookActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060150C0 RID: 86208 RVA: 0x0030DDC4 File Offset: 0x0030BFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this.monsterGain_.Add(other.monsterGain_);
			if (other.GetFullReward)
			{
				this.GetFullReward = other.GetFullReward;
			}
			if (other.RoadBookLevel != 0)
			{
				this.RoadBookLevel = other.RoadBookLevel;
			}
			this.unLockAreas_.Add(other.unLockAreas_);
			this.soarLevels_.Add(other.soarLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060150C1 RID: 86209 RVA: 0x0030DE58 File Offset: 0x0030C058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150C2 RID: 86210 RVA: 0x0030DE64 File Offset: 0x0030C064
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
						if (num == 10U)
						{
							this.activityTasks_.AddEntriesFrom(ref input, RoadBookActivityInfo._repeated_activityTasks_codec);
							continue;
						}
						if (num != 16U)
						{
							goto IL_49;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_49;
						}
						this.GetFullReward = input.ReadBool();
						continue;
					}
					this.monsterGain_.AddEntriesFrom(ref input, RoadBookActivityInfo._repeated_monsterGain_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.RoadBookLevel = input.ReadInt32();
						continue;
					}
					if (num != 40U)
					{
						goto IL_49;
					}
				}
				else if (num != 42U)
				{
					if (num != 50U)
					{
						goto IL_49;
					}
					this.soarLevels_.AddEntriesFrom(ref input, RoadBookActivityInfo._repeated_soarLevels_codec);
					continue;
				}
				this.unLockAreas_.AddEntriesFrom(ref input, RoadBookActivityInfo._repeated_unLockAreas_codec);
				continue;
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F24 RID: 32548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F25 RID: 32549
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007F26 RID: 32550
		private static readonly FieldCodec<ConditionTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04007F27 RID: 32551
		private readonly RepeatedField<ConditionTask> activityTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04007F28 RID: 32552
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04007F29 RID: 32553
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007F2A RID: 32554
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04007F2B RID: 32555
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04007F2C RID: 32556
		private bool getFullReward_;

		// Token: 0x04007F2D RID: 32557
		public const int RoadBookLevelFieldNumber = 4;

		// Token: 0x04007F2E RID: 32558
		private int roadBookLevel_;

		// Token: 0x04007F2F RID: 32559
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04007F30 RID: 32560
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007F31 RID: 32561
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04007F32 RID: 32562
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04007F33 RID: 32563
		private static readonly FieldCodec<RoadBookMotorcycleInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<RoadBookMotorcycleInfo>(50U, RoadBookMotorcycleInfo.Parser);

		// Token: 0x04007F34 RID: 32564
		private readonly RepeatedField<RoadBookMotorcycleInfo> soarLevels_ = new RepeatedField<RoadBookMotorcycleInfo>();
	}
}
