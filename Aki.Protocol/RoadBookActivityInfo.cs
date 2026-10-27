using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6A RID: 3946
	public sealed class RoadBookActivityInfo : IMessage<RoadBookActivityInfo>, IMessage, IEquatable<RoadBookActivityInfo>, IDeepCloneable<RoadBookActivityInfo>, IBufferMessage
	{
		// Token: 0x06015190 RID: 86416 RVA: 0x0030F0D5 File Offset: 0x0030D2D5
		[NullableContext(1)]
		public static RoadBookActivityInfo Create()
		{
			return new RoadBookActivityInfo();
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06015191 RID: 86417 RVA: 0x0030F0DC File Offset: 0x0030D2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06015192 RID: 86418 RVA: 0x0030F0DF File Offset: 0x0030D2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookActivityInfo.Descriptor;
			}
		}

		// Token: 0x06015193 RID: 86419 RVA: 0x0030F0E6 File Offset: 0x0030D2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo()
		{
		}

		// Token: 0x06015194 RID: 86420 RVA: 0x0030F11C File Offset: 0x0030D31C
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

		// Token: 0x06015195 RID: 86421 RVA: 0x0030F19C File Offset: 0x0030D39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookActivityInfo Clone()
		{
			return new RoadBookActivityInfo(this);
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x06015196 RID: 86422 RVA: 0x0030F1A4 File Offset: 0x0030D3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x06015197 RID: 86423 RVA: 0x0030F1AC File Offset: 0x0030D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x06015198 RID: 86424 RVA: 0x0030F1B4 File Offset: 0x0030D3B4
		// (set) Token: 0x06015199 RID: 86425 RVA: 0x0030F1BC File Offset: 0x0030D3BC
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

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x0601519A RID: 86426 RVA: 0x0030F1C5 File Offset: 0x0030D3C5
		// (set) Token: 0x0601519B RID: 86427 RVA: 0x0030F1CD File Offset: 0x0030D3CD
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

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x0601519C RID: 86428 RVA: 0x0030F1D6 File Offset: 0x0030D3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x0601519D RID: 86429 RVA: 0x0030F1DE File Offset: 0x0030D3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoadBookMotorcycleInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x0601519E RID: 86430 RVA: 0x0030F1E6 File Offset: 0x0030D3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookActivityInfo);
		}

		// Token: 0x0601519F RID: 86431 RVA: 0x0030F1F4 File Offset: 0x0030D3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.RoadBookLevel == other.RoadBookLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060151A0 RID: 86432 RVA: 0x0030F294 File Offset: 0x0030D494
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

		// Token: 0x060151A1 RID: 86433 RVA: 0x0030F324 File Offset: 0x0030D524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151A2 RID: 86434 RVA: 0x0030F331 File Offset: 0x0030D531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151A3 RID: 86435 RVA: 0x0030F33C File Offset: 0x0030D53C
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

		// Token: 0x060151A4 RID: 86436 RVA: 0x0030F3DC File Offset: 0x0030D5DC
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

		// Token: 0x060151A5 RID: 86437 RVA: 0x0030F474 File Offset: 0x0030D674
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

		// Token: 0x060151A6 RID: 86438 RVA: 0x0030F508 File Offset: 0x0030D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151A7 RID: 86439 RVA: 0x0030F514 File Offset: 0x0030D714
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

		// Token: 0x04007EFA RID: 32506
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EFB RID: 32507
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007EFC RID: 32508
		private static readonly FieldCodec<ConditionTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04007EFD RID: 32509
		private readonly RepeatedField<ConditionTask> activityTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04007EFE RID: 32510
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04007EFF RID: 32511
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007F00 RID: 32512
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04007F01 RID: 32513
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04007F02 RID: 32514
		private bool getFullReward_;

		// Token: 0x04007F03 RID: 32515
		public const int RoadBookLevelFieldNumber = 4;

		// Token: 0x04007F04 RID: 32516
		private int roadBookLevel_;

		// Token: 0x04007F05 RID: 32517
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04007F06 RID: 32518
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007F07 RID: 32519
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04007F08 RID: 32520
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04007F09 RID: 32521
		private static readonly FieldCodec<RoadBookMotorcycleInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<RoadBookMotorcycleInfo>(50U, RoadBookMotorcycleInfo.Parser);

		// Token: 0x04007F0A RID: 32522
		private readonly RepeatedField<RoadBookMotorcycleInfo> soarLevels_ = new RepeatedField<RoadBookMotorcycleInfo>();
	}
}
