using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9A RID: 3738
	public sealed class RealmBetweenActivityInfo : IMessage<RealmBetweenActivityInfo>, IMessage, IEquatable<RealmBetweenActivityInfo>, IDeepCloneable<RealmBetweenActivityInfo>, IBufferMessage
	{
		// Token: 0x06014112 RID: 82194 RVA: 0x002EBCB4 File Offset: 0x002E9EB4
		[NullableContext(1)]
		public static RealmBetweenActivityInfo Create()
		{
			return new RealmBetweenActivityInfo();
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x06014113 RID: 82195 RVA: 0x002EBCBB File Offset: 0x002E9EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x06014114 RID: 82196 RVA: 0x002EBCBE File Offset: 0x002E9EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenActivityInfo.Descriptor;
			}
		}

		// Token: 0x06014115 RID: 82197 RVA: 0x002EBCC5 File Offset: 0x002E9EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo()
		{
		}

		// Token: 0x06014116 RID: 82198 RVA: 0x002EBCFC File Offset: 0x002E9EFC
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

		// Token: 0x06014117 RID: 82199 RVA: 0x002EBD7C File Offset: 0x002E9F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenActivityInfo Clone()
		{
			return new RealmBetweenActivityInfo(this);
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x06014118 RID: 82200 RVA: 0x002EBD84 File Offset: 0x002E9F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x06014119 RID: 82201 RVA: 0x002EBD8C File Offset: 0x002E9F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0601411A RID: 82202 RVA: 0x002EBD94 File Offset: 0x002E9F94
		// (set) Token: 0x0601411B RID: 82203 RVA: 0x002EBD9C File Offset: 0x002E9F9C
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

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0601411C RID: 82204 RVA: 0x002EBDA5 File Offset: 0x002E9FA5
		// (set) Token: 0x0601411D RID: 82205 RVA: 0x002EBDAD File Offset: 0x002E9FAD
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

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0601411E RID: 82206 RVA: 0x002EBDB6 File Offset: 0x002E9FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0601411F RID: 82207 RVA: 0x002EBDBE File Offset: 0x002E9FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RealmBetweenMotorcycleInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x06014120 RID: 82208 RVA: 0x002EBDC6 File Offset: 0x002E9FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenActivityInfo);
		}

		// Token: 0x06014121 RID: 82209 RVA: 0x002EBDD4 File Offset: 0x002E9FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.RealmBetweenLevel == other.RealmBetweenLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014122 RID: 82210 RVA: 0x002EBE74 File Offset: 0x002EA074
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

		// Token: 0x06014123 RID: 82211 RVA: 0x002EBF04 File Offset: 0x002EA104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014124 RID: 82212 RVA: 0x002EBF11 File Offset: 0x002EA111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014125 RID: 82213 RVA: 0x002EBF1C File Offset: 0x002EA11C
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

		// Token: 0x06014126 RID: 82214 RVA: 0x002EBFBC File Offset: 0x002EA1BC
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

		// Token: 0x06014127 RID: 82215 RVA: 0x002EC054 File Offset: 0x002EA254
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

		// Token: 0x06014128 RID: 82216 RVA: 0x002EC0E8 File Offset: 0x002EA2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014129 RID: 82217 RVA: 0x002EC0F4 File Offset: 0x002EA2F4
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

		// Token: 0x04007A60 RID: 31328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A61 RID: 31329
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007A62 RID: 31330
		private static readonly FieldCodec<ConditionTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04007A63 RID: 31331
		private readonly RepeatedField<ConditionTask> activityTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04007A64 RID: 31332
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04007A65 RID: 31333
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007A66 RID: 31334
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04007A67 RID: 31335
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04007A68 RID: 31336
		private bool getFullReward_;

		// Token: 0x04007A69 RID: 31337
		public const int RealmBetweenLevelFieldNumber = 4;

		// Token: 0x04007A6A RID: 31338
		private int realmBetweenLevel_;

		// Token: 0x04007A6B RID: 31339
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04007A6C RID: 31340
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007A6D RID: 31341
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04007A6E RID: 31342
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04007A6F RID: 31343
		private static readonly FieldCodec<RealmBetweenMotorcycleInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<RealmBetweenMotorcycleInfo>(50U, RealmBetweenMotorcycleInfo.Parser);

		// Token: 0x04007A70 RID: 31344
		private readonly RepeatedField<RealmBetweenMotorcycleInfo> soarLevels_ = new RepeatedField<RealmBetweenMotorcycleInfo>();
	}
}
