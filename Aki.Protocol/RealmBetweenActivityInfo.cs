using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8A RID: 3722
	public sealed class RealmBetweenActivityInfo : IMessage<RealmBetweenActivityInfo>, IMessage, IEquatable<RealmBetweenActivityInfo>, IDeepCloneable<RealmBetweenActivityInfo>, IBufferMessage
	{
		// Token: 0x0601402D RID: 81965 RVA: 0x002EA5FD File Offset: 0x002E87FD
		[NullableContext(1)]
		public static RealmBetweenActivityInfo Create()
		{
			return new RealmBetweenActivityInfo();
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0601402E RID: 81966 RVA: 0x002EA604 File Offset: 0x002E8804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0601402F RID: 81967 RVA: 0x002EA607 File Offset: 0x002E8807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenActivityInfo.Descriptor;
			}
		}

		// Token: 0x06014030 RID: 81968 RVA: 0x002EA60E File Offset: 0x002E880E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo()
		{
		}

		// Token: 0x06014031 RID: 81969 RVA: 0x002EA644 File Offset: 0x002E8844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo(RealmBetweenActivityInfo other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this.monsterGain_ = other.monsterGain_.Clone();
			this.getFullReward_ = other.getFullReward_;
			this.realmBetweenLevel_ = other.realmBetweenLevel_;
			this.unLockAreas_ = other.unLockAreas_.Clone();
			this.soarLevels_ = other.soarLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014032 RID: 81970 RVA: 0x002EA6C4 File Offset: 0x002E88C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo Clone()
		{
			return new RealmBetweenActivityInfo(this);
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x06014033 RID: 81971 RVA: 0x002EA6CC File Offset: 0x002E88CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x06014034 RID: 81972 RVA: 0x002EA6D4 File Offset: 0x002E88D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x06014035 RID: 81973 RVA: 0x002EA6DC File Offset: 0x002E88DC
		// (set) Token: 0x06014036 RID: 81974 RVA: 0x002EA6E4 File Offset: 0x002E88E4
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

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x06014037 RID: 81975 RVA: 0x002EA6ED File Offset: 0x002E88ED
		// (set) Token: 0x06014038 RID: 81976 RVA: 0x002EA6F5 File Offset: 0x002E88F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RealmBetweenLevel
		{
			get
			{
				return this.realmBetweenLevel_;
			}
			set
			{
				this.realmBetweenLevel_ = value;
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x06014039 RID: 81977 RVA: 0x002EA6FE File Offset: 0x002E88FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0601403A RID: 81978 RVA: 0x002EA706 File Offset: 0x002E8906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RealmBetweenMotorcycleInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x0601403B RID: 81979 RVA: 0x002EA70E File Offset: 0x002E890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenActivityInfo);
		}

		// Token: 0x0601403C RID: 81980 RVA: 0x002EA71C File Offset: 0x002E891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.RealmBetweenLevel == other.RealmBetweenLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601403D RID: 81981 RVA: 0x002EA7BC File Offset: 0x002E89BC
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
			if (this.RealmBetweenLevel != 0)
			{
				num ^= this.RealmBetweenLevel.GetHashCode();
			}
			num ^= this.unLockAreas_.GetHashCode();
			num ^= this.soarLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601403E RID: 81982 RVA: 0x002EA84C File Offset: 0x002E8A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601403F RID: 81983 RVA: 0x002EA859 File Offset: 0x002E8A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014040 RID: 81984 RVA: 0x002EA864 File Offset: 0x002E8A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, RealmBetweenActivityInfo._repeated_activityTasks_codec);
			this.monsterGain_.WriteTo(ref output, RealmBetweenActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GetFullReward);
			}
			if (this.RealmBetweenLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RealmBetweenLevel);
			}
			this.unLockAreas_.WriteTo(ref output, RealmBetweenActivityInfo._repeated_unLockAreas_codec);
			this.soarLevels_.WriteTo(ref output, RealmBetweenActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014041 RID: 81985 RVA: 0x002EA904 File Offset: 0x002E8B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(RealmBetweenActivityInfo._repeated_activityTasks_codec);
			num += this.monsterGain_.CalculateSize(RealmBetweenActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				num += 2;
			}
			if (this.RealmBetweenLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RealmBetweenLevel);
			}
			num += this.unLockAreas_.CalculateSize(RealmBetweenActivityInfo._repeated_unLockAreas_codec);
			num += this.soarLevels_.CalculateSize(RealmBetweenActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014042 RID: 81986 RVA: 0x002EA99C File Offset: 0x002E8B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenActivityInfo other)
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
			if (other.RealmBetweenLevel != 0)
			{
				this.RealmBetweenLevel = other.RealmBetweenLevel;
			}
			this.unLockAreas_.Add(other.unLockAreas_);
			this.soarLevels_.Add(other.soarLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014043 RID: 81987 RVA: 0x002EAA30 File Offset: 0x002E8C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014044 RID: 81988 RVA: 0x002EAA3C File Offset: 0x002E8C3C
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
							this.activityTasks_.AddEntriesFrom(ref input, RealmBetweenActivityInfo._repeated_activityTasks_codec);
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
					this.monsterGain_.AddEntriesFrom(ref input, RealmBetweenActivityInfo._repeated_monsterGain_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.RealmBetweenLevel = input.ReadInt32();
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
					this.soarLevels_.AddEntriesFrom(ref input, RealmBetweenActivityInfo._repeated_soarLevels_codec);
					continue;
				}
				this.unLockAreas_.AddEntriesFrom(ref input, RealmBetweenActivityInfo._repeated_unLockAreas_codec);
				continue;
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A8A RID: 31370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A8B RID: 31371
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007A8C RID: 31372
		private static readonly FieldCodec<ConditionTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04007A8D RID: 31373
		private readonly RepeatedField<ConditionTask> activityTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04007A8E RID: 31374
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04007A8F RID: 31375
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007A90 RID: 31376
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04007A91 RID: 31377
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04007A92 RID: 31378
		private bool getFullReward_;

		// Token: 0x04007A93 RID: 31379
		public const int RealmBetweenLevelFieldNumber = 4;

		// Token: 0x04007A94 RID: 31380
		private int realmBetweenLevel_;

		// Token: 0x04007A95 RID: 31381
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04007A96 RID: 31382
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007A97 RID: 31383
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04007A98 RID: 31384
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04007A99 RID: 31385
		private static readonly FieldCodec<RealmBetweenMotorcycleInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<RealmBetweenMotorcycleInfo>(50U, RealmBetweenMotorcycleInfo.Parser);

		// Token: 0x04007A9A RID: 31386
		private readonly RepeatedField<RealmBetweenMotorcycleInfo> soarLevels_ = new RepeatedField<RealmBetweenMotorcycleInfo>();
	}
}
