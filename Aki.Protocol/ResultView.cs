using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1E RID: 3870
	public sealed class ResultView : IMessage<ResultView>, IMessage, IEquatable<ResultView>, IDeepCloneable<ResultView>, IBufferMessage
	{
		// Token: 0x06014BC7 RID: 84935 RVA: 0x00302B96 File Offset: 0x00300D96
		[NullableContext(1)]
		public static ResultView Create()
		{
			return new ResultView();
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x06014BC8 RID: 84936 RVA: 0x00302B9D File Offset: 0x00300D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x06014BC9 RID: 84937 RVA: 0x00302BA0 File Offset: 0x00300DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResultView.Descriptor;
			}
		}

		// Token: 0x06014BCA RID: 84938 RVA: 0x00302BA7 File Offset: 0x00300DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView()
		{
		}

		// Token: 0x06014BCB RID: 84939 RVA: 0x00302BBC File Offset: 0x00300DBC
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

		// Token: 0x06014BCC RID: 84940 RVA: 0x00302C5D File Offset: 0x00300E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView Clone()
		{
			return new ResultView(this);
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x06014BCD RID: 84941 RVA: 0x00302C65 File Offset: 0x00300E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x06014BCE RID: 84942 RVA: 0x00302C6D File Offset: 0x00300E6D
		// (set) Token: 0x06014BCF RID: 84943 RVA: 0x00302C75 File Offset: 0x00300E75
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

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x06014BD0 RID: 84944 RVA: 0x00302C7E File Offset: 0x00300E7E
		// (set) Token: 0x06014BD1 RID: 84945 RVA: 0x00302C86 File Offset: 0x00300E86
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

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x06014BD2 RID: 84946 RVA: 0x00302C8F File Offset: 0x00300E8F
		// (set) Token: 0x06014BD3 RID: 84947 RVA: 0x00302C97 File Offset: 0x00300E97
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

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x06014BD4 RID: 84948 RVA: 0x00302CA0 File Offset: 0x00300EA0
		// (set) Token: 0x06014BD5 RID: 84949 RVA: 0x00302CA8 File Offset: 0x00300EA8
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

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x06014BD6 RID: 84950 RVA: 0x00302CB1 File Offset: 0x00300EB1
		// (set) Token: 0x06014BD7 RID: 84951 RVA: 0x00302CB9 File Offset: 0x00300EB9
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

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x06014BD8 RID: 84952 RVA: 0x00302CC2 File Offset: 0x00300EC2
		// (set) Token: 0x06014BD9 RID: 84953 RVA: 0x00302CCA File Offset: 0x00300ECA
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

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x06014BDA RID: 84954 RVA: 0x00302CD3 File Offset: 0x00300ED3
		// (set) Token: 0x06014BDB RID: 84955 RVA: 0x00302CDB File Offset: 0x00300EDB
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

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x06014BDC RID: 84956 RVA: 0x00302CE4 File Offset: 0x00300EE4
		// (set) Token: 0x06014BDD RID: 84957 RVA: 0x00302CEC File Offset: 0x00300EEC
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

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x06014BDE RID: 84958 RVA: 0x00302CF5 File Offset: 0x00300EF5
		// (set) Token: 0x06014BDF RID: 84959 RVA: 0x00302CFD File Offset: 0x00300EFD
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

		// Token: 0x06014BE0 RID: 84960 RVA: 0x00302D06 File Offset: 0x00300F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResultView);
		}

		// Token: 0x06014BE1 RID: 84961 RVA: 0x00302D14 File Offset: 0x00300F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResultView other)
		{
			return other != null && (other == this || (this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && this.CostTime == other.CostTime && this.WeaponMaxCount == other.WeaponMaxCount && this.WaveId == other.WaveId && this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.PointSkill == other.PointSkill && this.IsFinishCond == other.IsFinishCond && this.KillMonsterCount == other.KillMonsterCount && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BE2 RID: 84962 RVA: 0x00302DE4 File Offset: 0x00300FE4
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

		// Token: 0x06014BE3 RID: 84963 RVA: 0x00302EF9 File Offset: 0x003010F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BE4 RID: 84964 RVA: 0x00302F06 File Offset: 0x00301106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BE5 RID: 84965 RVA: 0x00302F10 File Offset: 0x00301110
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

		// Token: 0x06014BE6 RID: 84966 RVA: 0x00303040 File Offset: 0x00301240
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

		// Token: 0x06014BE7 RID: 84967 RVA: 0x0030313C File Offset: 0x0030133C
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

		// Token: 0x06014BE8 RID: 84968 RVA: 0x00303229 File Offset: 0x00301429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BE9 RID: 84969 RVA: 0x00303234 File Offset: 0x00301434
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

		// Token: 0x04007DA3 RID: 32163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DA4 RID: 32164
		public const int SurvivorsGainDatasFieldNumber = 1;

		// Token: 0x04007DA5 RID: 32165
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(10U, SurvivorsGainData.Parser);

		// Token: 0x04007DA6 RID: 32166
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04007DA7 RID: 32167
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04007DA8 RID: 32168
		private long costTime_;

		// Token: 0x04007DA9 RID: 32169
		public const int WeaponMaxCountFieldNumber = 3;

		// Token: 0x04007DAA RID: 32170
		private int weaponMaxCount_;

		// Token: 0x04007DAB RID: 32171
		public const int WaveIdFieldNumber = 4;

		// Token: 0x04007DAC RID: 32172
		private int waveId_;

		// Token: 0x04007DAD RID: 32173
		public const int LevelIdFieldNumber = 5;

		// Token: 0x04007DAE RID: 32174
		private int levelId_;

		// Token: 0x04007DAF RID: 32175
		public const int InfiniteModeFieldNumber = 6;

		// Token: 0x04007DB0 RID: 32176
		private bool infiniteMode_;

		// Token: 0x04007DB1 RID: 32177
		public const int PointSkillFieldNumber = 7;

		// Token: 0x04007DB2 RID: 32178
		private int pointSkill_;

		// Token: 0x04007DB3 RID: 32179
		public const int IsFinishCondFieldNumber = 8;

		// Token: 0x04007DB4 RID: 32180
		private bool isFinishCond_;

		// Token: 0x04007DB5 RID: 32181
		public const int KillMonsterCountFieldNumber = 9;

		// Token: 0x04007DB6 RID: 32182
		private int killMonsterCount_;

		// Token: 0x04007DB7 RID: 32183
		public const int ReasonFieldNumber = 10;

		// Token: 0x04007DB8 RID: 32184
		private int reason_;
	}
}
