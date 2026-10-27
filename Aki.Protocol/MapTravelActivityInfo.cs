using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099D RID: 2461
	public sealed class MapTravelActivityInfo : IMessage<MapTravelActivityInfo>, IMessage, IEquatable<MapTravelActivityInfo>, IDeepCloneable<MapTravelActivityInfo>, IBufferMessage
	{
		// Token: 0x0600D826 RID: 55334 RVA: 0x001FC3B0 File Offset: 0x001FA5B0
		[NullableContext(1)]
		public static MapTravelActivityInfo Create()
		{
			return new MapTravelActivityInfo();
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600D827 RID: 55335 RVA: 0x001FC3B7 File Offset: 0x001FA5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600D828 RID: 55336 RVA: 0x001FC3BA File Offset: 0x001FA5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x001FC3C1 File Offset: 0x001FA5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo()
		{
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x001FC3F8 File Offset: 0x001FA5F8
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

		// Token: 0x0600D82B RID: 55339 RVA: 0x001FC478 File Offset: 0x001FA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelActivityInfo Clone()
		{
			return new MapTravelActivityInfo(this);
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x001FC480 File Offset: 0x001FA680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0600D82D RID: 55341 RVA: 0x001FC488 File Offset: 0x001FA688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterGain
		{
			get
			{
				return this.monsterGain_;
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0600D82E RID: 55342 RVA: 0x001FC490 File Offset: 0x001FA690
		// (set) Token: 0x0600D82F RID: 55343 RVA: 0x001FC498 File Offset: 0x001FA698
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

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0600D830 RID: 55344 RVA: 0x001FC4A1 File Offset: 0x001FA6A1
		// (set) Token: 0x0600D831 RID: 55345 RVA: 0x001FC4A9 File Offset: 0x001FA6A9
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

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600D832 RID: 55346 RVA: 0x001FC4B2 File Offset: 0x001FA6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockAreas
		{
			get
			{
				return this.unLockAreas_;
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600D833 RID: 55347 RVA: 0x001FC4BA File Offset: 0x001FA6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SoarLevelPlayInfo> SoarLevels
		{
			get
			{
				return this.soarLevels_;
			}
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x001FC4C2 File Offset: 0x001FA6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelActivityInfo);
		}

		// Token: 0x0600D835 RID: 55349 RVA: 0x001FC4D0 File Offset: 0x001FA6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelActivityInfo other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.monsterGain_.Equals(other.monsterGain_) && this.GetFullReward == other.GetFullReward && this.MapTravelLevel == other.MapTravelLevel && this.unLockAreas_.Equals(other.unLockAreas_) && this.soarLevels_.Equals(other.soarLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D836 RID: 55350 RVA: 0x001FC570 File Offset: 0x001FA770
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

		// Token: 0x0600D837 RID: 55351 RVA: 0x001FC600 File Offset: 0x001FA800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D838 RID: 55352 RVA: 0x001FC60D File Offset: 0x001FA80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D839 RID: 55353 RVA: 0x001FC618 File Offset: 0x001FA818
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

		// Token: 0x0600D83A RID: 55354 RVA: 0x001FC6B8 File Offset: 0x001FA8B8
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

		// Token: 0x0600D83B RID: 55355 RVA: 0x001FC750 File Offset: 0x001FA950
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

		// Token: 0x0600D83C RID: 55356 RVA: 0x001FC7E4 File Offset: 0x001FA9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D83D RID: 55357 RVA: 0x001FC7F0 File Offset: 0x001FA9F0
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

		// Token: 0x04005A18 RID: 23064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A19 RID: 23065
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04005A1A RID: 23066
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04005A1B RID: 23067
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04005A1C RID: 23068
		public const int MonsterGainFieldNumber = 2;

		// Token: 0x04005A1D RID: 23069
		private static readonly FieldCodec<int> _repeated_monsterGain_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005A1E RID: 23070
		private readonly RepeatedField<int> monsterGain_ = new RepeatedField<int>();

		// Token: 0x04005A1F RID: 23071
		public const int GetFullRewardFieldNumber = 3;

		// Token: 0x04005A20 RID: 23072
		private bool getFullReward_;

		// Token: 0x04005A21 RID: 23073
		public const int MapTravelLevelFieldNumber = 4;

		// Token: 0x04005A22 RID: 23074
		private int mapTravelLevel_;

		// Token: 0x04005A23 RID: 23075
		public const int UnLockAreasFieldNumber = 5;

		// Token: 0x04005A24 RID: 23076
		private static readonly FieldCodec<int> _repeated_unLockAreas_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005A25 RID: 23077
		private readonly RepeatedField<int> unLockAreas_ = new RepeatedField<int>();

		// Token: 0x04005A26 RID: 23078
		public const int SoarLevelsFieldNumber = 6;

		// Token: 0x04005A27 RID: 23079
		private static readonly FieldCodec<SoarLevelPlayInfo> _repeated_soarLevels_codec = FieldCodec.ForMessage<SoarLevelPlayInfo>(50U, SoarLevelPlayInfo.Parser);

		// Token: 0x04005A28 RID: 23080
		private readonly RepeatedField<SoarLevelPlayInfo> soarLevels_ = new RepeatedField<SoarLevelPlayInfo>();
	}
}
