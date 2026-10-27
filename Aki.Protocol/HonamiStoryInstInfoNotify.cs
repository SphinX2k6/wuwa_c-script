using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000779 RID: 1913
	[NetMessage(EMessageId.HonamiStoryInstInfoNotify)]
	public sealed class HonamiStoryInstInfoNotify : IMessage<HonamiStoryInstInfoNotify>, IMessage, IEquatable<HonamiStoryInstInfoNotify>, IDeepCloneable<HonamiStoryInstInfoNotify>, IBufferMessage
	{
		// Token: 0x0600ACDA RID: 44250 RVA: 0x0019F74A File Offset: 0x0019D94A
		[NullableContext(1)]
		public static HonamiStoryInstInfoNotify Create()
		{
			return new HonamiStoryInstInfoNotify();
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600ACDB RID: 44251 RVA: 0x0019F751 File Offset: 0x0019D951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x0019F754 File Offset: 0x0019D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x0019F75B File Offset: 0x0019D95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstInfoNotify()
		{
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x0019F770 File Offset: 0x0019D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstInfoNotify(HonamiStoryInstInfoNotify other) : this()
		{
			this.honamiStoryBagInfos_ = other.honamiStoryBagInfos_.Clone();
			this.honamiStoryAreaId_ = other.honamiStoryAreaId_;
			this.dangerLevelId_ = other.dangerLevelId_;
			this.pollutionLevel_ = other.pollutionLevel_;
			this.pollutionStartTime_ = other.pollutionStartTime_;
			this.activityId_ = other.activityId_;
			this.pollutionGroup_ = other.pollutionGroup_;
			this.canSafeLeave_ = other.canSafeLeave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x0019F7F9 File Offset: 0x0019D9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstInfoNotify Clone()
		{
			return new HonamiStoryInstInfoNotify(this);
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600ACE0 RID: 44256 RVA: 0x0019F801 File Offset: 0x0019DA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagInfo> HonamiStoryBagInfos
		{
			get
			{
				return this.honamiStoryBagInfos_;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600ACE1 RID: 44257 RVA: 0x0019F809 File Offset: 0x0019DA09
		// (set) Token: 0x0600ACE2 RID: 44258 RVA: 0x0019F811 File Offset: 0x0019DA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryAreaId
		{
			get
			{
				return this.honamiStoryAreaId_;
			}
			set
			{
				this.honamiStoryAreaId_ = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0600ACE3 RID: 44259 RVA: 0x0019F81A File Offset: 0x0019DA1A
		// (set) Token: 0x0600ACE4 RID: 44260 RVA: 0x0019F822 File Offset: 0x0019DA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangerLevelId
		{
			get
			{
				return this.dangerLevelId_;
			}
			set
			{
				this.dangerLevelId_ = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600ACE5 RID: 44261 RVA: 0x0019F82B File Offset: 0x0019DA2B
		// (set) Token: 0x0600ACE6 RID: 44262 RVA: 0x0019F833 File Offset: 0x0019DA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PollutionLevel
		{
			get
			{
				return this.pollutionLevel_;
			}
			set
			{
				this.pollutionLevel_ = value;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x0600ACE7 RID: 44263 RVA: 0x0019F83C File Offset: 0x0019DA3C
		// (set) Token: 0x0600ACE8 RID: 44264 RVA: 0x0019F844 File Offset: 0x0019DA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PollutionStartTime
		{
			get
			{
				return this.pollutionStartTime_;
			}
			set
			{
				this.pollutionStartTime_ = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x0600ACE9 RID: 44265 RVA: 0x0019F84D File Offset: 0x0019DA4D
		// (set) Token: 0x0600ACEA RID: 44266 RVA: 0x0019F855 File Offset: 0x0019DA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x0600ACEB RID: 44267 RVA: 0x0019F85E File Offset: 0x0019DA5E
		// (set) Token: 0x0600ACEC RID: 44268 RVA: 0x0019F866 File Offset: 0x0019DA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PollutionGroup
		{
			get
			{
				return this.pollutionGroup_;
			}
			set
			{
				this.pollutionGroup_ = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600ACED RID: 44269 RVA: 0x0019F86F File Offset: 0x0019DA6F
		// (set) Token: 0x0600ACEE RID: 44270 RVA: 0x0019F877 File Offset: 0x0019DA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanSafeLeave
		{
			get
			{
				return this.canSafeLeave_;
			}
			set
			{
				this.canSafeLeave_ = value;
			}
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x0019F880 File Offset: 0x0019DA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstInfoNotify);
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x0019F890 File Offset: 0x0019DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstInfoNotify other)
		{
			return other != null && (other == this || (this.honamiStoryBagInfos_.Equals(other.honamiStoryBagInfos_) && this.HonamiStoryAreaId == other.HonamiStoryAreaId && this.DangerLevelId == other.DangerLevelId && this.PollutionLevel == other.PollutionLevel && this.PollutionStartTime == other.PollutionStartTime && this.ActivityId == other.ActivityId && this.PollutionGroup == other.PollutionGroup && this.CanSafeLeave == other.CanSafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x0019F940 File Offset: 0x0019DB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryBagInfos_.GetHashCode();
			if (this.HonamiStoryAreaId != 0)
			{
				num ^= this.HonamiStoryAreaId.GetHashCode();
			}
			if (this.DangerLevelId != 0)
			{
				num ^= this.DangerLevelId.GetHashCode();
			}
			if (this.PollutionLevel != 0)
			{
				num ^= this.PollutionLevel.GetHashCode();
			}
			if (this.PollutionStartTime != 0L)
			{
				num ^= this.PollutionStartTime.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.PollutionGroup != 0)
			{
				num ^= this.PollutionGroup.GetHashCode();
			}
			if (this.CanSafeLeave)
			{
				num ^= this.CanSafeLeave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x0019FA23 File Offset: 0x0019DC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x0019FA30 File Offset: 0x0019DC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x0019FA3C File Offset: 0x0019DC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryAreaId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HonamiStoryAreaId);
			}
			if (this.DangerLevelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DangerLevelId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.PollutionLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PollutionLevel);
			}
			this.honamiStoryBagInfos_.WriteTo(ref output, HonamiStoryInstInfoNotify._repeated_honamiStoryBagInfos_codec);
			if (this.PollutionStartTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.PollutionStartTime);
			}
			if (this.CanSafeLeave)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.CanSafeLeave);
			}
			if (this.PollutionGroup != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PollutionGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x0019FB34 File Offset: 0x0019DD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryBagInfos_.CalculateSize(HonamiStoryInstInfoNotify._repeated_honamiStoryBagInfos_codec);
			if (this.HonamiStoryAreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryAreaId);
			}
			if (this.DangerLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangerLevelId);
			}
			if (this.PollutionLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PollutionLevel);
			}
			if (this.PollutionStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PollutionStartTime);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.PollutionGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PollutionGroup);
			}
			if (this.CanSafeLeave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x0019FC0C File Offset: 0x0019DE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryBagInfos_.Add(other.honamiStoryBagInfos_);
			if (other.HonamiStoryAreaId != 0)
			{
				this.HonamiStoryAreaId = other.HonamiStoryAreaId;
			}
			if (other.DangerLevelId != 0)
			{
				this.DangerLevelId = other.DangerLevelId;
			}
			if (other.PollutionLevel != 0)
			{
				this.PollutionLevel = other.PollutionLevel;
			}
			if (other.PollutionStartTime != 0L)
			{
				this.PollutionStartTime = other.PollutionStartTime;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.PollutionGroup != 0)
			{
				this.PollutionGroup = other.PollutionGroup;
			}
			if (other.CanSafeLeave)
			{
				this.CanSafeLeave = other.CanSafeLeave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x0019FCD1 File Offset: 0x0019DED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x0019FCDC File Offset: 0x0019DEDC
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
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.HonamiStoryAreaId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.DangerLevelId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.PollutionLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 58U)
					{
						this.honamiStoryBagInfos_.AddEntriesFrom(ref input, HonamiStoryInstInfoNotify._repeated_honamiStoryBagInfos_codec);
						continue;
					}
					if (num == 72U)
					{
						this.PollutionStartTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.CanSafeLeave = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.PollutionGroup = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E39 RID: 20025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E3A RID: 20026
		public const int HonamiStoryBagInfosFieldNumber = 7;

		// Token: 0x04004E3B RID: 20027
		private static readonly FieldCodec<HonamiStoryBagInfo> _repeated_honamiStoryBagInfos_codec = FieldCodec.ForMessage<HonamiStoryBagInfo>(58U, HonamiStoryBagInfo.Parser);

		// Token: 0x04004E3C RID: 20028
		private readonly RepeatedField<HonamiStoryBagInfo> honamiStoryBagInfos_ = new RepeatedField<HonamiStoryBagInfo>();

		// Token: 0x04004E3D RID: 20029
		public const int HonamiStoryAreaIdFieldNumber = 2;

		// Token: 0x04004E3E RID: 20030
		private int honamiStoryAreaId_;

		// Token: 0x04004E3F RID: 20031
		public const int DangerLevelIdFieldNumber = 3;

		// Token: 0x04004E40 RID: 20032
		private int dangerLevelId_;

		// Token: 0x04004E41 RID: 20033
		public const int PollutionLevelFieldNumber = 5;

		// Token: 0x04004E42 RID: 20034
		private int pollutionLevel_;

		// Token: 0x04004E43 RID: 20035
		public const int PollutionStartTimeFieldNumber = 9;

		// Token: 0x04004E44 RID: 20036
		private long pollutionStartTime_;

		// Token: 0x04004E45 RID: 20037
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004E46 RID: 20038
		private int activityId_;

		// Token: 0x04004E47 RID: 20039
		public const int PollutionGroupFieldNumber = 12;

		// Token: 0x04004E48 RID: 20040
		private int pollutionGroup_;

		// Token: 0x04004E49 RID: 20041
		public const int CanSafeLeaveFieldNumber = 11;

		// Token: 0x04004E4A RID: 20042
		private bool canSafeLeave_;
	}
}
