using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4B RID: 2635
	public sealed class MotorFightResult : IMessage<MotorFightResult>, IMessage, IEquatable<MotorFightResult>, IDeepCloneable<MotorFightResult>, IBufferMessage
	{
		// Token: 0x0600E631 RID: 58929 RVA: 0x0021A554 File Offset: 0x00218754
		[NullableContext(1)]
		public static MotorFightResult Create()
		{
			return new MotorFightResult();
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600E632 RID: 58930 RVA: 0x0021A55B File Offset: 0x0021875B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600E633 RID: 58931 RVA: 0x0021A55E File Offset: 0x0021875E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightResult.Descriptor;
			}
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x0021A565 File Offset: 0x00218765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult()
		{
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x0021A578 File Offset: 0x00218778
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

		// Token: 0x0600E636 RID: 58934 RVA: 0x0021A5ED File Offset: 0x002187ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult Clone()
		{
			return new MotorFightResult(this);
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600E637 RID: 58935 RVA: 0x0021A5F5 File Offset: 0x002187F5
		// (set) Token: 0x0600E638 RID: 58936 RVA: 0x0021A5FD File Offset: 0x002187FD
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

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600E639 RID: 58937 RVA: 0x0021A606 File Offset: 0x00218806
		// (set) Token: 0x0600E63A RID: 58938 RVA: 0x0021A60E File Offset: 0x0021880E
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

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600E63B RID: 58939 RVA: 0x0021A617 File Offset: 0x00218817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItemMap
		{
			get
			{
				return this.rewardItemMap_;
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600E63C RID: 58940 RVA: 0x0021A61F File Offset: 0x0021881F
		// (set) Token: 0x0600E63D RID: 58941 RVA: 0x0021A627 File Offset: 0x00218827
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

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600E63E RID: 58942 RVA: 0x0021A630 File Offset: 0x00218830
		// (set) Token: 0x0600E63F RID: 58943 RVA: 0x0021A638 File Offset: 0x00218838
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

		// Token: 0x0600E640 RID: 58944 RVA: 0x0021A641 File Offset: 0x00218841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightResult);
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x0021A650 File Offset: 0x00218850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightResult other)
		{
			return other != null && (other == this || (object.Equals(this.ResultCommon, other.ResultCommon) && this.IsBestScore == other.IsBestScore && this.RewardItemMap.Equals(other.RewardItemMap) && this.IsFirstClear == other.IsFirstClear && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x0021A6D4 File Offset: 0x002188D4
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

		// Token: 0x0600E643 RID: 58947 RVA: 0x0021A769 File Offset: 0x00218969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x0021A776 File Offset: 0x00218976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x0021A780 File Offset: 0x00218980
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

		// Token: 0x0600E646 RID: 58950 RVA: 0x0021A824 File Offset: 0x00218A24
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

		// Token: 0x0600E647 RID: 58951 RVA: 0x0021A8A8 File Offset: 0x00218AA8
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

		// Token: 0x0600E648 RID: 58952 RVA: 0x0021A949 File Offset: 0x00218B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x0021A954 File Offset: 0x00218B54
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

		// Token: 0x04005E42 RID: 24130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E43 RID: 24131
		public const int ResultCommonFieldNumber = 1;

		// Token: 0x04005E44 RID: 24132
		private MotorFightResultBase resultCommon_;

		// Token: 0x04005E45 RID: 24133
		public const int IsBestScoreFieldNumber = 8;

		// Token: 0x04005E46 RID: 24134
		private bool isBestScore_;

		// Token: 0x04005E47 RID: 24135
		public const int RewardItemMapFieldNumber = 9;

		// Token: 0x04005E48 RID: 24136
		private static readonly MapField<int, int>.Codec _map_rewardItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04005E49 RID: 24137
		private readonly MapField<int, int> rewardItemMap_ = new MapField<int, int>();

		// Token: 0x04005E4A RID: 24138
		public const int IsFirstClearFieldNumber = 10;

		// Token: 0x04005E4B RID: 24139
		private bool isFirstClear_;

		// Token: 0x04005E4C RID: 24140
		public const int CostTimeFieldNumber = 11;

		// Token: 0x04005E4D RID: 24141
		private long costTime_;
	}
}
