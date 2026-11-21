using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D9 RID: 4313
	public sealed class RoleTowerRankRangeTable : IMessage<RoleTowerRankRangeTable>, IMessage, IEquatable<RoleTowerRankRangeTable>, IDeepCloneable<RoleTowerRankRangeTable>, IBufferMessage
	{
		// Token: 0x060170FA RID: 94458 RVA: 0x0035B279 File Offset: 0x00359479
		[NullableContext(1)]
		public static RoleTowerRankRangeTable Create()
		{
			return new RoleTowerRankRangeTable();
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x060170FB RID: 94459 RVA: 0x0035B280 File Offset: 0x00359480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x060170FC RID: 94460 RVA: 0x0035B283 File Offset: 0x00359483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankRangeTable.Descriptor;
			}
		}

		// Token: 0x060170FD RID: 94461 RVA: 0x0035B28A File Offset: 0x0035948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRangeTable()
		{
		}

		// Token: 0x060170FE RID: 94462 RVA: 0x0035B2A0 File Offset: 0x003594A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRangeTable(RoleTowerRankRangeTable other) : this()
		{
			this.levelId_ = other.levelId_;
			this.totalCount_ = other.totalCount_;
			this.buildUnixTime_ = other.buildUnixTime_;
			this.maxPercentCode_ = other.maxPercentCode_;
			this.ranges_ = other.ranges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170FF RID: 94463 RVA: 0x0035B305 File Offset: 0x00359505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRangeTable Clone()
		{
			return new RoleTowerRankRangeTable(this);
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06017100 RID: 94464 RVA: 0x0035B30D File Offset: 0x0035950D
		// (set) Token: 0x06017101 RID: 94465 RVA: 0x0035B315 File Offset: 0x00359515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x06017102 RID: 94466 RVA: 0x0035B31E File Offset: 0x0035951E
		// (set) Token: 0x06017103 RID: 94467 RVA: 0x0035B326 File Offset: 0x00359526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x06017104 RID: 94468 RVA: 0x0035B32F File Offset: 0x0035952F
		// (set) Token: 0x06017105 RID: 94469 RVA: 0x0035B337 File Offset: 0x00359537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuildUnixTime
		{
			get
			{
				return this.buildUnixTime_;
			}
			set
			{
				this.buildUnixTime_ = value;
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x06017106 RID: 94470 RVA: 0x0035B340 File Offset: 0x00359540
		// (set) Token: 0x06017107 RID: 94471 RVA: 0x0035B348 File Offset: 0x00359548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxPercentCode
		{
			get
			{
				return this.maxPercentCode_;
			}
			set
			{
				this.maxPercentCode_ = value;
			}
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x06017108 RID: 94472 RVA: 0x0035B351 File Offset: 0x00359551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRankScoreRange> Ranges
		{
			get
			{
				return this.ranges_;
			}
		}

		// Token: 0x06017109 RID: 94473 RVA: 0x0035B359 File Offset: 0x00359559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankRangeTable);
		}

		// Token: 0x0601710A RID: 94474 RVA: 0x0035B368 File Offset: 0x00359568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankRangeTable other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.TotalCount == other.TotalCount && this.BuildUnixTime == other.BuildUnixTime && this.MaxPercentCode == other.MaxPercentCode && this.ranges_.Equals(other.ranges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601710B RID: 94475 RVA: 0x0035B3E8 File Offset: 0x003595E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.TotalCount != 0L)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.BuildUnixTime != 0L)
			{
				num ^= this.BuildUnixTime.GetHashCode();
			}
			if (this.MaxPercentCode != 0U)
			{
				num ^= this.MaxPercentCode.GetHashCode();
			}
			num ^= this.ranges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601710C RID: 94476 RVA: 0x0035B480 File Offset: 0x00359680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601710D RID: 94477 RVA: 0x0035B48D File Offset: 0x0035968D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601710E RID: 94478 RVA: 0x0035B498 File Offset: 0x00359698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.TotalCount != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TotalCount);
			}
			if (this.BuildUnixTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BuildUnixTime);
			}
			if (this.MaxPercentCode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MaxPercentCode);
			}
			this.ranges_.WriteTo(ref output, RoleTowerRankRangeTable._repeated_ranges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601710F RID: 94479 RVA: 0x0035B53C File Offset: 0x0035973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.TotalCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCount);
			}
			if (this.BuildUnixTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuildUnixTime);
			}
			if (this.MaxPercentCode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPercentCode);
			}
			num += this.ranges_.CalculateSize(RoleTowerRankRangeTable._repeated_ranges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017110 RID: 94480 RVA: 0x0035B5D8 File Offset: 0x003597D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankRangeTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.TotalCount != 0L)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.BuildUnixTime != 0L)
			{
				this.BuildUnixTime = other.BuildUnixTime;
			}
			if (other.MaxPercentCode != 0U)
			{
				this.MaxPercentCode = other.MaxPercentCode;
			}
			this.ranges_.Add(other.ranges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017111 RID: 94481 RVA: 0x0035B661 File Offset: 0x00359861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017112 RID: 94482 RVA: 0x0035B66C File Offset: 0x0035986C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCount = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BuildUnixTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.MaxPercentCode = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.ranges_.AddEntriesFrom(ref input, RoleTowerRankRangeTable._repeated_ranges_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A19 RID: 35353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A1A RID: 35354
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04008A1B RID: 35355
		private int levelId_;

		// Token: 0x04008A1C RID: 35356
		public const int TotalCountFieldNumber = 2;

		// Token: 0x04008A1D RID: 35357
		private long totalCount_;

		// Token: 0x04008A1E RID: 35358
		public const int BuildUnixTimeFieldNumber = 3;

		// Token: 0x04008A1F RID: 35359
		private long buildUnixTime_;

		// Token: 0x04008A20 RID: 35360
		public const int MaxPercentCodeFieldNumber = 4;

		// Token: 0x04008A21 RID: 35361
		private uint maxPercentCode_;

		// Token: 0x04008A22 RID: 35362
		public const int RangesFieldNumber = 5;

		// Token: 0x04008A23 RID: 35363
		private static readonly FieldCodec<RoleTowerRankScoreRange> _repeated_ranges_codec = FieldCodec.ForMessage<RoleTowerRankScoreRange>(42U, RoleTowerRankScoreRange.Parser);

		// Token: 0x04008A24 RID: 35364
		private readonly RepeatedField<RoleTowerRankScoreRange> ranges_ = new RepeatedField<RoleTowerRankScoreRange>();
	}
}
