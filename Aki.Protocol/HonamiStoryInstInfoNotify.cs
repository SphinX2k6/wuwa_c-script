using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000765 RID: 1893
	[NetMessage(EMessageId.HonamiStoryInstInfoNotify)]
	public sealed class HonamiStoryInstInfoNotify : IMessage<HonamiStoryInstInfoNotify>, IMessage, IEquatable<HonamiStoryInstInfoNotify>, IDeepCloneable<HonamiStoryInstInfoNotify>, IBufferMessage
	{
		// Token: 0x0600AB84 RID: 43908 RVA: 0x0019CD22 File Offset: 0x0019AF22
		[NullableContext(1)]
		public static HonamiStoryInstInfoNotify Create()
		{
			return new HonamiStoryInstInfoNotify();
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600AB85 RID: 43909 RVA: 0x0019CD29 File Offset: 0x0019AF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x0019CD2C File Offset: 0x0019AF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x0019CD33 File Offset: 0x0019AF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstInfoNotify()
		{
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x0019CD48 File Offset: 0x0019AF48
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

		// Token: 0x0600AB89 RID: 43913 RVA: 0x0019CDD1 File Offset: 0x0019AFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstInfoNotify Clone()
		{
			return new HonamiStoryInstInfoNotify(this);
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x0019CDD9 File Offset: 0x0019AFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagInfo> HonamiStoryBagInfos
		{
			get
			{
				return this.honamiStoryBagInfos_;
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600AB8B RID: 43915 RVA: 0x0019CDE1 File Offset: 0x0019AFE1
		// (set) Token: 0x0600AB8C RID: 43916 RVA: 0x0019CDE9 File Offset: 0x0019AFE9
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

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600AB8D RID: 43917 RVA: 0x0019CDF2 File Offset: 0x0019AFF2
		// (set) Token: 0x0600AB8E RID: 43918 RVA: 0x0019CDFA File Offset: 0x0019AFFA
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

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x0600AB8F RID: 43919 RVA: 0x0019CE03 File Offset: 0x0019B003
		// (set) Token: 0x0600AB90 RID: 43920 RVA: 0x0019CE0B File Offset: 0x0019B00B
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

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x0600AB91 RID: 43921 RVA: 0x0019CE14 File Offset: 0x0019B014
		// (set) Token: 0x0600AB92 RID: 43922 RVA: 0x0019CE1C File Offset: 0x0019B01C
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

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x0019CE25 File Offset: 0x0019B025
		// (set) Token: 0x0600AB94 RID: 43924 RVA: 0x0019CE2D File Offset: 0x0019B02D
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

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600AB95 RID: 43925 RVA: 0x0019CE36 File Offset: 0x0019B036
		// (set) Token: 0x0600AB96 RID: 43926 RVA: 0x0019CE3E File Offset: 0x0019B03E
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

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600AB97 RID: 43927 RVA: 0x0019CE47 File Offset: 0x0019B047
		// (set) Token: 0x0600AB98 RID: 43928 RVA: 0x0019CE4F File Offset: 0x0019B04F
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

		// Token: 0x0600AB99 RID: 43929 RVA: 0x0019CE58 File Offset: 0x0019B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstInfoNotify);
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x0019CE68 File Offset: 0x0019B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstInfoNotify other)
		{
			return other != null && (other == this || (this.honamiStoryBagInfos_.Equals(other.honamiStoryBagInfos_) && this.HonamiStoryAreaId == other.HonamiStoryAreaId && this.DangerLevelId == other.DangerLevelId && this.PollutionLevel == other.PollutionLevel && this.PollutionStartTime == other.PollutionStartTime && this.ActivityId == other.ActivityId && this.PollutionGroup == other.PollutionGroup && this.CanSafeLeave == other.CanSafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x0019CF18 File Offset: 0x0019B118
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

		// Token: 0x0600AB9C RID: 43932 RVA: 0x0019CFFB File Offset: 0x0019B1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x0019D008 File Offset: 0x0019B208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x0019D014 File Offset: 0x0019B214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangerLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DangerLevelId);
			}
			if (this.CanSafeLeave)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CanSafeLeave);
			}
			if (this.PollutionGroup != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PollutionGroup);
			}
			if (this.PollutionLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PollutionLevel);
			}
			this.honamiStoryBagInfos_.WriteTo(ref output, HonamiStoryInstInfoNotify._repeated_honamiStoryBagInfos_codec);
			if (this.PollutionStartTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.PollutionStartTime);
			}
			if (this.HonamiStoryAreaId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HonamiStoryAreaId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x0019D10C File Offset: 0x0019B30C
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

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x0019D1E4 File Offset: 0x0019B3E4
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

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x0019D2A9 File Offset: 0x0019B4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x0019D2B4 File Offset: 0x0019B4B4
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
				if (num <= 64U)
				{
					if (num <= 40U)
					{
						if (num == 16U)
						{
							this.DangerLevelId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.CanSafeLeave = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.PollutionGroup = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.PollutionLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						this.honamiStoryBagInfos_.AddEntriesFrom(ref input, HonamiStoryInstInfoNotify._repeated_honamiStoryBagInfos_codec);
						continue;
					}
					if (num == 80U)
					{
						this.PollutionStartTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HonamiStoryAreaId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E32 RID: 20018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E33 RID: 20019
		public const int HonamiStoryBagInfosFieldNumber = 9;

		// Token: 0x04004E34 RID: 20020
		private static readonly FieldCodec<HonamiStoryBagInfo> _repeated_honamiStoryBagInfos_codec = FieldCodec.ForMessage<HonamiStoryBagInfo>(74U, HonamiStoryBagInfo.Parser);

		// Token: 0x04004E35 RID: 20021
		private readonly RepeatedField<HonamiStoryBagInfo> honamiStoryBagInfos_ = new RepeatedField<HonamiStoryBagInfo>();

		// Token: 0x04004E36 RID: 20022
		public const int HonamiStoryAreaIdFieldNumber = 11;

		// Token: 0x04004E37 RID: 20023
		private int honamiStoryAreaId_;

		// Token: 0x04004E38 RID: 20024
		public const int DangerLevelIdFieldNumber = 2;

		// Token: 0x04004E39 RID: 20025
		private int dangerLevelId_;

		// Token: 0x04004E3A RID: 20026
		public const int PollutionLevelFieldNumber = 8;

		// Token: 0x04004E3B RID: 20027
		private int pollutionLevel_;

		// Token: 0x04004E3C RID: 20028
		public const int PollutionStartTimeFieldNumber = 10;

		// Token: 0x04004E3D RID: 20029
		private long pollutionStartTime_;

		// Token: 0x04004E3E RID: 20030
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04004E3F RID: 20031
		private int activityId_;

		// Token: 0x04004E40 RID: 20032
		public const int PollutionGroupFieldNumber = 7;

		// Token: 0x04004E41 RID: 20033
		private int pollutionGroup_;

		// Token: 0x04004E42 RID: 20034
		public const int CanSafeLeaveFieldNumber = 5;

		// Token: 0x04004E43 RID: 20035
		private bool canSafeLeave_;
	}
}
