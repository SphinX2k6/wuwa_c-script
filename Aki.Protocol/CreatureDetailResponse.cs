using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000320 RID: 800
	[NetMessage(EMessageId.CreatureDetailResponse)]
	public sealed class CreatureDetailResponse : IMessage<CreatureDetailResponse>, IMessage, IEquatable<CreatureDetailResponse>, IDeepCloneable<CreatureDetailResponse>, IBufferMessage
	{
		// Token: 0x060050C4 RID: 20676 RVA: 0x000C521D File Offset: 0x000C341D
		[NullableContext(1)]
		public static CreatureDetailResponse Create()
		{
			return new CreatureDetailResponse();
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x000C5224 File Offset: 0x000C3424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x000C5227 File Offset: 0x000C3427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatureDetailResponse.Descriptor;
			}
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x000C522E File Offset: 0x000C342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailResponse()
		{
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x000C5244 File Offset: 0x000C3444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailResponse(CreatureDetailResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.id_ = other.id_;
			this.curCount_ = other.curCount_;
			this.nextRefreshTime_ = other.nextRefreshTime_;
			this.configIndex_ = other.configIndex_;
			this.areaIndex_ = other.areaIndex_;
			this.existCount_ = other.existCount_;
			this.conditionSatisfy_ = other.conditionSatisfy_;
			this.aliveEntities_ = other.aliveEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x000C52D9 File Offset: 0x000C34D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailResponse Clone()
		{
			return new CreatureDetailResponse(this);
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x000C52E1 File Offset: 0x000C34E1
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x000C52E9 File Offset: 0x000C34E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x000C52F2 File Offset: 0x000C34F2
		// (set) Token: 0x060050CD RID: 20685 RVA: 0x000C52FA File Offset: 0x000C34FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x000C5303 File Offset: 0x000C3503
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x000C530B File Offset: 0x000C350B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCount
		{
			get
			{
				return this.curCount_;
			}
			set
			{
				this.curCount_ = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x000C5314 File Offset: 0x000C3514
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x000C531C File Offset: 0x000C351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRefreshTime
		{
			get
			{
				return this.nextRefreshTime_;
			}
			set
			{
				this.nextRefreshTime_ = value;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x000C5325 File Offset: 0x000C3525
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x000C532D File Offset: 0x000C352D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigIndex
		{
			get
			{
				return this.configIndex_;
			}
			set
			{
				this.configIndex_ = value;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x000C5336 File Offset: 0x000C3536
		// (set) Token: 0x060050D5 RID: 20693 RVA: 0x000C533E File Offset: 0x000C353E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaIndex
		{
			get
			{
				return this.areaIndex_;
			}
			set
			{
				this.areaIndex_ = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x000C5347 File Offset: 0x000C3547
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x000C534F File Offset: 0x000C354F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExistCount
		{
			get
			{
				return this.existCount_;
			}
			set
			{
				this.existCount_ = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x000C5358 File Offset: 0x000C3558
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x000C5360 File Offset: 0x000C3560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ConditionSatisfy
		{
			get
			{
				return this.conditionSatisfy_;
			}
			set
			{
				this.conditionSatisfy_ = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x000C5369 File Offset: 0x000C3569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> AliveEntities
		{
			get
			{
				return this.aliveEntities_;
			}
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x000C5371 File Offset: 0x000C3571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatureDetailResponse);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x000C5380 File Offset: 0x000C3580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatureDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && this.CurCount == other.CurCount && this.NextRefreshTime == other.NextRefreshTime && this.ConfigIndex == other.ConfigIndex && this.AreaIndex == other.AreaIndex && this.ExistCount == other.ExistCount && this.ConditionSatisfy == other.ConditionSatisfy && this.aliveEntities_.Equals(other.aliveEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x000C5440 File Offset: 0x000C3640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CurCount != 0)
			{
				num ^= this.CurCount.GetHashCode();
			}
			if (this.NextRefreshTime != 0L)
			{
				num ^= this.NextRefreshTime.GetHashCode();
			}
			if (this.ConfigIndex != 0)
			{
				num ^= this.ConfigIndex.GetHashCode();
			}
			if (this.AreaIndex != 0)
			{
				num ^= this.AreaIndex.GetHashCode();
			}
			if (this.ExistCount != 0)
			{
				num ^= this.ExistCount.GetHashCode();
			}
			if (this.ConditionSatisfy)
			{
				num ^= this.ConditionSatisfy.GetHashCode();
			}
			num ^= this.aliveEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x000C5543 File Offset: 0x000C3743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x000C5550 File Offset: 0x000C3750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x000C555C File Offset: 0x000C375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ConfigIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ConfigIndex);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			this.aliveEntities_.WriteTo(ref output, CreatureDetailResponse._repeated_aliveEntities_codec);
			if (this.CurCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurCount);
			}
			if (this.ConditionSatisfy)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.ConditionSatisfy);
			}
			if (this.ExistCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ExistCount);
			}
			if (this.AreaIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AreaIndex);
			}
			if (this.NextRefreshTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x000C5670 File Offset: 0x000C3870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.CurCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCount);
			}
			if (this.NextRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRefreshTime);
			}
			if (this.ConfigIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigIndex);
			}
			if (this.AreaIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaIndex);
			}
			if (this.ExistCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExistCount);
			}
			if (this.ConditionSatisfy)
			{
				num += 2;
			}
			num += this.aliveEntities_.CalculateSize(CreatureDetailResponse._repeated_aliveEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x000C5760 File Offset: 0x000C3960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatureDetailResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.CurCount != 0)
			{
				this.CurCount = other.CurCount;
			}
			if (other.NextRefreshTime != 0L)
			{
				this.NextRefreshTime = other.NextRefreshTime;
			}
			if (other.ConfigIndex != 0)
			{
				this.ConfigIndex = other.ConfigIndex;
			}
			if (other.AreaIndex != 0)
			{
				this.AreaIndex = other.AreaIndex;
			}
			if (other.ExistCount != 0)
			{
				this.ExistCount = other.ExistCount;
			}
			if (other.ConditionSatisfy)
			{
				this.ConditionSatisfy = other.ConditionSatisfy;
			}
			this.aliveEntities_.Add(other.aliveEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x000C5839 File Offset: 0x000C3A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x000C5844 File Offset: 0x000C3A44
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
				if (num <= 58U)
				{
					if (num <= 40U)
					{
						if (num == 8U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 40U)
						{
							this.ConfigIndex = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 58U)
						{
							this.aliveEntities_.AddEntriesFrom(ref input, CreatureDetailResponse._repeated_aliveEntities_codec);
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.CurCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ConditionSatisfy = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ExistCount = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.AreaIndex = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.NextRefreshTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032CB RID: 13003
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032CC RID: 13004
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040032CD RID: 13005
		private ErrorCode errorCode_;

		// Token: 0x040032CE RID: 13006
		public const int IdFieldNumber = 6;

		// Token: 0x040032CF RID: 13007
		private long id_;

		// Token: 0x040032D0 RID: 13008
		public const int CurCountFieldNumber = 8;

		// Token: 0x040032D1 RID: 13009
		private int curCount_;

		// Token: 0x040032D2 RID: 13010
		public const int NextRefreshTimeFieldNumber = 14;

		// Token: 0x040032D3 RID: 13011
		private long nextRefreshTime_;

		// Token: 0x040032D4 RID: 13012
		public const int ConfigIndexFieldNumber = 5;

		// Token: 0x040032D5 RID: 13013
		private int configIndex_;

		// Token: 0x040032D6 RID: 13014
		public const int AreaIndexFieldNumber = 12;

		// Token: 0x040032D7 RID: 13015
		private int areaIndex_;

		// Token: 0x040032D8 RID: 13016
		public const int ExistCountFieldNumber = 11;

		// Token: 0x040032D9 RID: 13017
		private int existCount_;

		// Token: 0x040032DA RID: 13018
		public const int ConditionSatisfyFieldNumber = 10;

		// Token: 0x040032DB RID: 13019
		private bool conditionSatisfy_;

		// Token: 0x040032DC RID: 13020
		public const int AliveEntitiesFieldNumber = 7;

		// Token: 0x040032DD RID: 13021
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_aliveEntities_codec = FieldCodec.ForMessage<DynamicEntityInformation>(58U, DynamicEntityInformation.Parser);

		// Token: 0x040032DE RID: 13022
		private readonly RepeatedField<DynamicEntityInformation> aliveEntities_ = new RepeatedField<DynamicEntityInformation>();
	}
}
