using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098C RID: 2444
	public sealed class MapTravelActivityInfo : IMessage<MapTravelActivityInfo>, IMessage, IEquatable<MapTravelActivityInfo>, IDeepCloneable<MapTravelActivityInfo>, IBufferMessage
	{
		// Token: 0x0600D70C RID: 55052 RVA: 0x001FA1C0 File Offset: 0x001F83C0
		[NullableContext(1)]
		public static MapTravelActivityInfo Create()
		{
			return new MapTravelActivityInfo();
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600D70D RID: 55053 RVA: 0x001FA1C7 File Offset: 0x001F83C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600D70E RID: 55054 RVA: 0x001FA1CA File Offset: 0x001F83CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600D70F RID: 55055 RVA: 0x001FA1D1 File Offset: 0x001F83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo()
		{
		}

		// Token: 0x0600D710 RID: 55056 RVA: 0x001FA208 File Offset: 0x001F8408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo(MapTravelActivityInfo other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this.monsterGain_ = other.monsterGain_.Clone();
			this.getFullReward_ = other.getFullReward_;
			this.mapTravelLevel_ = other.mapTravelLevel_;
			this.unLockAreas_ = other.unLockAreas_.Clone();
			this.soarLevels_ = other.soarLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x001FA288 File Offset: 0x001F8488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo Clone()
		{
			return new MapTravelActivityInfo(this);
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600D712 RID: 55058 RVA: 0x001FA290 File Offset: 0x001F8490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600D713 RID: 55059 RVA: 0x001FA298 File Offset: 0x001F8498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600D714 RID: 55060 RVA: 0x001FA2A0 File Offset: 0x001F84A0
		// (set) Token: 0x0600D715 RID: 55061 RVA: 0x001FA2A8 File Offset: 0x001F84A8
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

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600D716 RID: 55062 RVA: 0x001FA2B1 File Offset: 0x001F84B1
		// (set) Token: 0x0600D717 RID: 55063 RVA: 0x001FA2B9 File Offset: 0x001F84B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapTravelLevel
		{
			get
			{
				return this.mapTravelLevel_;
			}
			set
			{
				this.mapTravelLevel_ = value;
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600D718 RID: 55064 RVA: 0x001FA2C2 File Offset: 0x001F84C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x001FA2CA File Offset: 0x001F84CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SoarLevelPlayInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x0600D71A RID: 55066 RVA: 0x001FA2D2 File Offset: 0x001F84D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelActivityInfo);
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x001FA2E0 File Offset: 0x001F84E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.MapTravelLevel == other.MapTravelLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x001FA380 File Offset: 0x001F8580
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
			if (this.MapTravelLevel != 0)
			{
				num ^= this.MapTravelLevel.GetHashCode();
			}
			num ^= this.unLockAreas_.GetHashCode();
			num ^= this.soarLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x001FA410 File Offset: 0x001F8610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x001FA41D File Offset: 0x001F861D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D71F RID: 55071 RVA: 0x001FA428 File Offset: 0x001F8628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, MapTravelActivityInfo._repeated_activityTasks_codec);
			this.monsterGain_.WriteTo(ref output, MapTravelActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GetFullReward);
			}
			if (this.MapTravelLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MapTravelLevel);
			}
			this.unLockAreas_.WriteTo(ref output, MapTravelActivityInfo._repeated_unLockAreas_codec);
			this.soarLevels_.WriteTo(ref output, MapTravelActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x001FA4C8 File Offset: 0x001F86C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(MapTravelActivityInfo._repeated_activityTasks_codec);
			num += this.monsterGain_.CalculateSize(MapTravelActivityInfo._repeated_monsterGain_codec);
			if (this.GetFullReward)
			{
				num += 2;
			}
			if (this.MapTravelLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapTravelLevel);
			}
			num += this.unLockAreas_.CalculateSize(MapTravelActivityInfo._repeated_unLockAreas_codec);
			num += this.soarLevels_.CalculateSize(MapTravelActivityInfo._repeated_soarLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D721 RID: 55073 RVA: 0x001FA560 File Offset: 0x001F8760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelActivityInfo other)
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
			if (other.MapTravelLevel != 0)
			{
				this.MapTravelLevel = other.MapTravelLevel;
			}
			this.unLockAreas_.Add(other.unLockAreas_);
			this.soarLevels_.Add(other.soarLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x001FA5F4 File Offset: 0x001F87F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x001FA600 File Offset: 0x001F8800
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
							this.activityTasks_.AddEntriesFrom(ref input, MapTravelActivityInfo._repeated_activityTasks_codec);
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
					this.monsterGain_.AddEntriesFrom(ref input, MapTravelActivityInfo._repeated_monsterGain_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.MapTravelLevel = input.ReadInt32();
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
					this.soarLevels_.AddEntriesFrom(ref input, MapTravelActivityInfo._repeated_soarLevels_codec);
					continue;
				}
				this.unLockAreas_.AddEntriesFrom(ref input, MapTravelActivityInfo._repeated_unLockAreas_codec);
				continue;
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A21 RID: 23073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A22 RID: 23074
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04005A23 RID: 23075
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04005A24 RID: 23076
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04005A25 RID: 23077
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04005A26 RID: 23078
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005A27 RID: 23079
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04005A28 RID: 23080
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04005A29 RID: 23081
		private bool getFullReward_;

		// Token: 0x04005A2A RID: 23082
		public const int MapTravelLevelFieldNumber = 4;

		// Token: 0x04005A2B RID: 23083
		private int mapTravelLevel_;

		// Token: 0x04005A2C RID: 23084
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04005A2D RID: 23085
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005A2E RID: 23086
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04005A2F RID: 23087
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04005A30 RID: 23088
		private static readonly FieldCodec<SoarLevelPlayInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<SoarLevelPlayInfo>(50U, SoarLevelPlayInfo.Parser);

		// Token: 0x04005A31 RID: 23089
		private readonly RepeatedField<SoarLevelPlayInfo> soarLevels_ = new RepeatedField<SoarLevelPlayInfo>();
	}
}
