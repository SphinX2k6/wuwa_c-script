using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000319 RID: 793
	[NetMessage(EMessageId.CreatureDetailResponse)]
	public sealed class CreatureDetailResponse : IMessage<CreatureDetailResponse>, IMessage, IEquatable<CreatureDetailResponse>, IDeepCloneable<CreatureDetailResponse>, IBufferMessage
	{
		// Token: 0x06004FEB RID: 20459 RVA: 0x000C2E31 File Offset: 0x000C1031
		[NullableContext(1)]
		public static CreatureDetailResponse Create()
		{
			return new CreatureDetailResponse();
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x000C2E38 File Offset: 0x000C1038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x000C2E3B File Offset: 0x000C103B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatureDetailResponse.Descriptor;
			}
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x000C2E42 File Offset: 0x000C1042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailResponse()
		{
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x000C2E58 File Offset: 0x000C1058
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

		// Token: 0x06004FF0 RID: 20464 RVA: 0x000C2EED File Offset: 0x000C10ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailResponse Clone()
		{
			return new CreatureDetailResponse(this);
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x000C2EF5 File Offset: 0x000C10F5
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x000C2EFD File Offset: 0x000C10FD
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

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x000C2F06 File Offset: 0x000C1106
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x000C2F0E File Offset: 0x000C110E
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x000C2F17 File Offset: 0x000C1117
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x000C2F1F File Offset: 0x000C111F
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

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x000C2F28 File Offset: 0x000C1128
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x000C2F30 File Offset: 0x000C1130
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x000C2F39 File Offset: 0x000C1139
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x000C2F41 File Offset: 0x000C1141
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x000C2F4A File Offset: 0x000C114A
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x000C2F52 File Offset: 0x000C1152
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x000C2F5B File Offset: 0x000C115B
		// (set) Token: 0x06004FFE RID: 20478 RVA: 0x000C2F63 File Offset: 0x000C1163
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

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x000C2F6C File Offset: 0x000C116C
		// (set) Token: 0x06005000 RID: 20480 RVA: 0x000C2F74 File Offset: 0x000C1174
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

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x000C2F7D File Offset: 0x000C117D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> AliveEntities
		{
			get
			{
				return this.aliveEntities_;
			}
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x000C2F85 File Offset: 0x000C1185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatureDetailResponse);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x000C2F94 File Offset: 0x000C1194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatureDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && this.CurCount == other.CurCount && this.NextRefreshTime == other.NextRefreshTime && this.ConfigIndex == other.ConfigIndex && this.AreaIndex == other.AreaIndex && this.ExistCount == other.ExistCount && this.ConditionSatisfy == other.ConditionSatisfy && this.aliveEntities_.Equals(other.aliveEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x000C3054 File Offset: 0x000C1254
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

		// Token: 0x06005005 RID: 20485 RVA: 0x000C3157 File Offset: 0x000C1357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x000C3164 File Offset: 0x000C1364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x000C3170 File Offset: 0x000C1370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExistCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExistCount);
			}
			if (this.ConfigIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigIndex);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CurCount);
			}
			if (this.NextRefreshTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.NextRefreshTime);
			}
			if (this.AreaIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AreaIndex);
			}
			if (this.ConditionSatisfy)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.ConditionSatisfy);
			}
			this.aliveEntities_.WriteTo(ref output, CreatureDetailResponse._repeated_aliveEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x000C3284 File Offset: 0x000C1484
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

		// Token: 0x06005009 RID: 20489 RVA: 0x000C3374 File Offset: 0x000C1574
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

		// Token: 0x0600500A RID: 20490 RVA: 0x000C344D File Offset: 0x000C164D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x000C3458 File Offset: 0x000C1658
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ExistCount = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ConfigIndex = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.CurCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.NextRefreshTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.AreaIndex = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ConditionSatisfy = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.aliveEntities_.AddEntriesFrom(ref input, CreatureDetailResponse._repeated_aliveEntities_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003234 RID: 12852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003235 RID: 12853
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003236 RID: 12854
		private ErrorCode errorCode_;

		// Token: 0x04003237 RID: 12855
		public const int IdFieldNumber = 3;

		// Token: 0x04003238 RID: 12856
		private long id_;

		// Token: 0x04003239 RID: 12857
		public const int CurCountFieldNumber = 9;

		// Token: 0x0400323A RID: 12858
		private int curCount_;

		// Token: 0x0400323B RID: 12859
		public const int NextRefreshTimeFieldNumber = 10;

		// Token: 0x0400323C RID: 12860
		private long nextRefreshTime_;

		// Token: 0x0400323D RID: 12861
		public const int ConfigIndexFieldNumber = 2;

		// Token: 0x0400323E RID: 12862
		private int configIndex_;

		// Token: 0x0400323F RID: 12863
		public const int AreaIndexFieldNumber = 12;

		// Token: 0x04003240 RID: 12864
		private int areaIndex_;

		// Token: 0x04003241 RID: 12865
		public const int ExistCountFieldNumber = 1;

		// Token: 0x04003242 RID: 12866
		private int existCount_;

		// Token: 0x04003243 RID: 12867
		public const int ConditionSatisfyFieldNumber = 14;

		// Token: 0x04003244 RID: 12868
		private bool conditionSatisfy_;

		// Token: 0x04003245 RID: 12869
		public const int AliveEntitiesFieldNumber = 15;

		// Token: 0x04003246 RID: 12870
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_aliveEntities_codec = FieldCodec.ForMessage<DynamicEntityInformation>(122U, DynamicEntityInformation.Parser);

		// Token: 0x04003247 RID: 12871
		private readonly RepeatedField<DynamicEntityInformation> aliveEntities_ = new RepeatedField<DynamicEntityInformation>();
	}
}
