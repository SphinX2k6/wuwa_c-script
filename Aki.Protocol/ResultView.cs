using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2E RID: 3886
	public sealed class ResultView : IMessage<ResultView>, IMessage, IEquatable<ResultView>, IDeepCloneable<ResultView>, IBufferMessage
	{
		// Token: 0x06014CAC RID: 85164 RVA: 0x00304252 File Offset: 0x00302452
		[NullableContext(1)]
		public static ResultView Create()
		{
			return new ResultView();
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x06014CAD RID: 85165 RVA: 0x00304259 File Offset: 0x00302459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x06014CAE RID: 85166 RVA: 0x0030425C File Offset: 0x0030245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResultView.Descriptor;
			}
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x00304263 File Offset: 0x00302463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView()
		{
		}

		// Token: 0x06014CB0 RID: 85168 RVA: 0x00304278 File Offset: 0x00302478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView(ResultView other) : this()
		{
			this.survivorsGainDatas_ = other.survivorsGainDatas_.Clone();
			this.costTime_ = other.costTime_;
			this.weaponMaxCount_ = other.weaponMaxCount_;
			this.waveId_ = other.waveId_;
			this.levelId_ = other.levelId_;
			this.infiniteMode_ = other.infiniteMode_;
			this.pointSkill_ = other.pointSkill_;
			this.isFinishCond_ = other.isFinishCond_;
			this.killMonsterCount_ = other.killMonsterCount_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CB1 RID: 85169 RVA: 0x00304319 File Offset: 0x00302519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView Clone()
		{
			return new ResultView(this);
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x06014CB2 RID: 85170 RVA: 0x00304321 File Offset: 0x00302521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x06014CB3 RID: 85171 RVA: 0x00304329 File Offset: 0x00302529
		// (set) Token: 0x06014CB4 RID: 85172 RVA: 0x00304331 File Offset: 0x00302531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x06014CB5 RID: 85173 RVA: 0x0030433A File Offset: 0x0030253A
		// (set) Token: 0x06014CB6 RID: 85174 RVA: 0x00304342 File Offset: 0x00302542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponMaxCount
		{
			get
			{
				return this.weaponMaxCount_;
			}
			set
			{
				this.weaponMaxCount_ = value;
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x06014CB7 RID: 85175 RVA: 0x0030434B File Offset: 0x0030254B
		// (set) Token: 0x06014CB8 RID: 85176 RVA: 0x00304353 File Offset: 0x00302553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x06014CB9 RID: 85177 RVA: 0x0030435C File Offset: 0x0030255C
		// (set) Token: 0x06014CBA RID: 85178 RVA: 0x00304364 File Offset: 0x00302564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x06014CBB RID: 85179 RVA: 0x0030436D File Offset: 0x0030256D
		// (set) Token: 0x06014CBC RID: 85180 RVA: 0x00304375 File Offset: 0x00302575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InfiniteMode
		{
			get
			{
				return this.infiniteMode_;
			}
			set
			{
				this.infiniteMode_ = value;
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x06014CBD RID: 85181 RVA: 0x0030437E File Offset: 0x0030257E
		// (set) Token: 0x06014CBE RID: 85182 RVA: 0x00304386 File Offset: 0x00302586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PointSkill
		{
			get
			{
				return this.pointSkill_;
			}
			set
			{
				this.pointSkill_ = value;
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x06014CBF RID: 85183 RVA: 0x0030438F File Offset: 0x0030258F
		// (set) Token: 0x06014CC0 RID: 85184 RVA: 0x00304397 File Offset: 0x00302597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinishCond
		{
			get
			{
				return this.isFinishCond_;
			}
			set
			{
				this.isFinishCond_ = value;
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x06014CC1 RID: 85185 RVA: 0x003043A0 File Offset: 0x003025A0
		// (set) Token: 0x06014CC2 RID: 85186 RVA: 0x003043A8 File Offset: 0x003025A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillMonsterCount
		{
			get
			{
				return this.killMonsterCount_;
			}
			set
			{
				this.killMonsterCount_ = value;
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x06014CC3 RID: 85187 RVA: 0x003043B1 File Offset: 0x003025B1
		// (set) Token: 0x06014CC4 RID: 85188 RVA: 0x003043B9 File Offset: 0x003025B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06014CC5 RID: 85189 RVA: 0x003043C2 File Offset: 0x003025C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResultView);
		}

		// Token: 0x06014CC6 RID: 85190 RVA: 0x003043D0 File Offset: 0x003025D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResultView other)
		{
			return other != null && (other == this || (this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && this.CostTime == other.CostTime && this.WeaponMaxCount == other.WeaponMaxCount && this.WaveId == other.WaveId && this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.PointSkill == other.PointSkill && this.IsFinishCond == other.IsFinishCond && this.KillMonsterCount == other.KillMonsterCount && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CC7 RID: 85191 RVA: 0x003044A0 File Offset: 0x003026A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.survivorsGainDatas_.GetHashCode();
			if (this.CostTime != 0L)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.WeaponMaxCount != 0)
			{
				num ^= this.WeaponMaxCount.GetHashCode();
			}
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.InfiniteMode)
			{
				num ^= this.InfiniteMode.GetHashCode();
			}
			if (this.PointSkill != 0)
			{
				num ^= this.PointSkill.GetHashCode();
			}
			if (this.IsFinishCond)
			{
				num ^= this.IsFinishCond.GetHashCode();
			}
			if (this.KillMonsterCount != 0)
			{
				num ^= this.KillMonsterCount.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014CC8 RID: 85192 RVA: 0x003045B5 File Offset: 0x003027B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CC9 RID: 85193 RVA: 0x003045C2 File Offset: 0x003027C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CCA RID: 85194 RVA: 0x003045CC File Offset: 0x003027CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.survivorsGainDatas_.WriteTo(ref output, ResultView._repeated_survivorsGainDatas_codec);
			if (this.CostTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CostTime);
			}
			if (this.WeaponMaxCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponMaxCount);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WaveId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.InfiniteMode);
			}
			if (this.PointSkill != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PointSkill);
			}
			if (this.IsFinishCond)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsFinishCond);
			}
			if (this.KillMonsterCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.KillMonsterCount);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CCB RID: 85195 RVA: 0x003046FC File Offset: 0x003028FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.survivorsGainDatas_.CalculateSize(ResultView._repeated_survivorsGainDatas_codec);
			if (this.CostTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTime);
			}
			if (this.WeaponMaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponMaxCount);
			}
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				num += 2;
			}
			if (this.PointSkill != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PointSkill);
			}
			if (this.IsFinishCond)
			{
				num += 2;
			}
			if (this.KillMonsterCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillMonsterCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014CCC RID: 85196 RVA: 0x003047F8 File Offset: 0x003029F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResultView other)
		{
			if (other == null)
			{
				return;
			}
			this.survivorsGainDatas_.Add(other.survivorsGainDatas_);
			if (other.CostTime != 0L)
			{
				this.CostTime = other.CostTime;
			}
			if (other.WeaponMaxCount != 0)
			{
				this.WeaponMaxCount = other.WeaponMaxCount;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.InfiniteMode)
			{
				this.InfiniteMode = other.InfiniteMode;
			}
			if (other.PointSkill != 0)
			{
				this.PointSkill = other.PointSkill;
			}
			if (other.IsFinishCond)
			{
				this.IsFinishCond = other.IsFinishCond;
			}
			if (other.KillMonsterCount != 0)
			{
				this.KillMonsterCount = other.KillMonsterCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014CCD RID: 85197 RVA: 0x003048E5 File Offset: 0x00302AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CCE RID: 85198 RVA: 0x003048F0 File Offset: 0x00302AF0
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.survivorsGainDatas_.AddEntriesFrom(ref input, ResultView._repeated_survivorsGainDatas_codec);
							continue;
						}
						if (num == 16U)
						{
							this.CostTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.WeaponMaxCount = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.WaveId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.InfiniteMode = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.PointSkill = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsFinishCond = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.KillMonsterCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D79 RID: 32121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D7A RID: 32122
		public const int SurvivorsGainDatasFieldNumber = 1;

		// Token: 0x04007D7B RID: 32123
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(10U, SurvivorsGainData.Parser);

		// Token: 0x04007D7C RID: 32124
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04007D7D RID: 32125
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04007D7E RID: 32126
		private long costTime_;

		// Token: 0x04007D7F RID: 32127
		public const int WeaponMaxCountFieldNumber = 3;

		// Token: 0x04007D80 RID: 32128
		private int weaponMaxCount_;

		// Token: 0x04007D81 RID: 32129
		public const int WaveIdFieldNumber = 4;

		// Token: 0x04007D82 RID: 32130
		private int waveId_;

		// Token: 0x04007D83 RID: 32131
		public const int LevelIdFieldNumber = 5;

		// Token: 0x04007D84 RID: 32132
		private int levelId_;

		// Token: 0x04007D85 RID: 32133
		public const int InfiniteModeFieldNumber = 6;

		// Token: 0x04007D86 RID: 32134
		private bool infiniteMode_;

		// Token: 0x04007D87 RID: 32135
		public const int PointSkillFieldNumber = 7;

		// Token: 0x04007D88 RID: 32136
		private int pointSkill_;

		// Token: 0x04007D89 RID: 32137
		public const int IsFinishCondFieldNumber = 8;

		// Token: 0x04007D8A RID: 32138
		private bool isFinishCond_;

		// Token: 0x04007D8B RID: 32139
		public const int KillMonsterCountFieldNumber = 9;

		// Token: 0x04007D8C RID: 32140
		private int killMonsterCount_;

		// Token: 0x04007D8D RID: 32141
		public const int ReasonFieldNumber = 10;

		// Token: 0x04007D8E RID: 32142
		private int reason_;
	}
}
