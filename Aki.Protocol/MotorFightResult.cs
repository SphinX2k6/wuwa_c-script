using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5C RID: 2652
	public sealed class MotorFightResult : IMessage<MotorFightResult>, IMessage, IEquatable<MotorFightResult>, IDeepCloneable<MotorFightResult>, IBufferMessage
	{
		// Token: 0x0600E74B RID: 59211 RVA: 0x0021C748 File Offset: 0x0021A948
		[NullableContext(1)]
		public static MotorFightResult Create()
		{
			return new MotorFightResult();
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600E74C RID: 59212 RVA: 0x0021C74F File Offset: 0x0021A94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600E74D RID: 59213 RVA: 0x0021C752 File Offset: 0x0021A952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightResult.Descriptor;
			}
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x0021C759 File Offset: 0x0021A959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult()
		{
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x0021C76C File Offset: 0x0021A96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult(MotorFightResult other) : this()
		{
			this.resultCommon_ = ((other.resultCommon_ != null) ? other.resultCommon_.Clone() : null);
			this.isBestScore_ = other.isBestScore_;
			this.rewardItemMap_ = other.rewardItemMap_.Clone();
			this.isFirstClear_ = other.isFirstClear_;
			this.costTime_ = other.costTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x0021C7E1 File Offset: 0x0021A9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult Clone()
		{
			return new MotorFightResult(this);
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600E751 RID: 59217 RVA: 0x0021C7E9 File Offset: 0x0021A9E9
		// (set) Token: 0x0600E752 RID: 59218 RVA: 0x0021C7F1 File Offset: 0x0021A9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase ResultCommon
		{
			get
			{
				return this.resultCommon_;
			}
			set
			{
				this.resultCommon_ = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600E753 RID: 59219 RVA: 0x0021C7FA File Offset: 0x0021A9FA
		// (set) Token: 0x0600E754 RID: 59220 RVA: 0x0021C802 File Offset: 0x0021AA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBestScore
		{
			get
			{
				return this.isBestScore_;
			}
			set
			{
				this.isBestScore_ = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600E755 RID: 59221 RVA: 0x0021C80B File Offset: 0x0021AA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItemMap
		{
			get
			{
				return this.rewardItemMap_;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600E756 RID: 59222 RVA: 0x0021C813 File Offset: 0x0021AA13
		// (set) Token: 0x0600E757 RID: 59223 RVA: 0x0021C81B File Offset: 0x0021AA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirstClear
		{
			get
			{
				return this.isFirstClear_;
			}
			set
			{
				this.isFirstClear_ = value;
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600E758 RID: 59224 RVA: 0x0021C824 File Offset: 0x0021AA24
		// (set) Token: 0x0600E759 RID: 59225 RVA: 0x0021C82C File Offset: 0x0021AA2C
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

		// Token: 0x0600E75A RID: 59226 RVA: 0x0021C835 File Offset: 0x0021AA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightResult);
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x0021C844 File Offset: 0x0021AA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightResult other)
		{
			return other != null && (other == this || (object.Equals(this.ResultCommon, other.ResultCommon) && this.IsBestScore == other.IsBestScore && this.RewardItemMap.Equals(other.RewardItemMap) && this.IsFirstClear == other.IsFirstClear && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x0021C8C8 File Offset: 0x0021AAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.resultCommon_ != null)
			{
				num ^= this.ResultCommon.GetHashCode();
			}
			if (this.IsBestScore)
			{
				num ^= this.IsBestScore.GetHashCode();
			}
			num ^= this.RewardItemMap.GetHashCode();
			if (this.IsFirstClear)
			{
				num ^= this.IsFirstClear.GetHashCode();
			}
			if (this.CostTime != 0L)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E75D RID: 59229 RVA: 0x0021C95D File Offset: 0x0021AB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E75E RID: 59230 RVA: 0x0021C96A File Offset: 0x0021AB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x0021C974 File Offset: 0x0021AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ResultCommon);
			}
			if (this.IsBestScore)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsBestScore);
			}
			this.rewardItemMap_.WriteTo(ref output, MotorFightResult._map_rewardItemMap_codec);
			if (this.IsFirstClear)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsFirstClear);
			}
			if (this.CostTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E760 RID: 59232 RVA: 0x0021CA18 File Offset: 0x0021AC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.resultCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultCommon);
			}
			if (this.IsBestScore)
			{
				num += 2;
			}
			num += this.rewardItemMap_.CalculateSize(MotorFightResult._map_rewardItemMap_codec);
			if (this.IsFirstClear)
			{
				num += 2;
			}
			if (this.CostTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E761 RID: 59233 RVA: 0x0021CA9C File Offset: 0x0021AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.resultCommon_ != null)
			{
				if (this.resultCommon_ == null)
				{
					this.ResultCommon = new MotorFightResultBase();
				}
				this.ResultCommon.MergeFrom(other.ResultCommon);
			}
			if (other.IsBestScore)
			{
				this.IsBestScore = other.IsBestScore;
			}
			this.rewardItemMap_.MergeFrom(other.rewardItemMap_);
			if (other.IsFirstClear)
			{
				this.IsFirstClear = other.IsFirstClear;
			}
			if (other.CostTime != 0L)
			{
				this.CostTime = other.CostTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E762 RID: 59234 RVA: 0x0021CB3D File Offset: 0x0021AD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E763 RID: 59235 RVA: 0x0021CB48 File Offset: 0x0021AD48
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
					if (num == 10U)
					{
						if (this.resultCommon_ == null)
						{
							this.ResultCommon = new MotorFightResultBase();
						}
						input.ReadMessage(this.ResultCommon);
						continue;
					}
					if (num == 64U)
					{
						this.IsBestScore = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.rewardItemMap_.AddEntriesFrom(ref input, MotorFightResult._map_rewardItemMap_codec);
						continue;
					}
					if (num == 80U)
					{
						this.IsFirstClear = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.CostTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E39 RID: 24121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E3A RID: 24122
		public const int ResultCommonFieldNumber = 1;

		// Token: 0x04005E3B RID: 24123
		private MotorFightResultBase resultCommon_;

		// Token: 0x04005E3C RID: 24124
		public const int IsBestScoreFieldNumber = 8;

		// Token: 0x04005E3D RID: 24125
		private bool isBestScore_;

		// Token: 0x04005E3E RID: 24126
		public const int RewardItemMapFieldNumber = 9;

		// Token: 0x04005E3F RID: 24127
		private static readonly MapField<int, int>.Codec _map_rewardItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04005E40 RID: 24128
		private readonly MapField<int, int> rewardItemMap_ = new MapField<int, int>();

		// Token: 0x04005E41 RID: 24129
		public const int IsFirstClearFieldNumber = 10;

		// Token: 0x04005E42 RID: 24130
		private bool isFirstClear_;

		// Token: 0x04005E43 RID: 24131
		public const int CostTimeFieldNumber = 11;

		// Token: 0x04005E44 RID: 24132
		private long costTime_;
	}
}
