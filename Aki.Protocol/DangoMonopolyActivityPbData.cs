using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000380 RID: 896
	public sealed class DangoMonopolyActivityPbData : IMessage<DangoMonopolyActivityPbData>, IMessage, IEquatable<DangoMonopolyActivityPbData>, IDeepCloneable<DangoMonopolyActivityPbData>, IBufferMessage
	{
		// Token: 0x060058C4 RID: 22724 RVA: 0x000D83C2 File Offset: 0x000D65C2
		[NullableContext(1)]
		public static DangoMonopolyActivityPbData Create()
		{
			return new DangoMonopolyActivityPbData();
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060058C5 RID: 22725 RVA: 0x000D83C9 File Offset: 0x000D65C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x000D83CC File Offset: 0x000D65CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyActivityPbData.Descriptor;
			}
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x000D83D3 File Offset: 0x000D65D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData()
		{
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x000D8408 File Offset: 0x000D6608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData(DangoMonopolyActivityPbData other) : this()
		{
			this.boardId_ = other.boardId_;
			this.gridId_ = other.gridId_;
			this.rewardedGridId_ = other.rewardedGridId_;
			this.rewardedBoardIds_ = other.rewardedBoardIds_.Clone();
			this.taskDatas_ = other.taskDatas_.Clone();
			this.taskRefreshTime_ = other.taskRefreshTime_.Clone();
			this.boardUnlockTime_ = other.boardUnlockTime_;
			this.boardRecords_ = other.boardRecords_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x000D84A0 File Offset: 0x000D66A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData Clone()
		{
			return new DangoMonopolyActivityPbData(this);
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x000D84A8 File Offset: 0x000D66A8
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x000D84B0 File Offset: 0x000D66B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x000D84B9 File Offset: 0x000D66B9
		// (set) Token: 0x060058CD RID: 22733 RVA: 0x000D84C1 File Offset: 0x000D66C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridId
		{
			get
			{
				return this.gridId_;
			}
			set
			{
				this.gridId_ = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x000D84CA File Offset: 0x000D66CA
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x000D84D2 File Offset: 0x000D66D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedGridId
		{
			get
			{
				return this.rewardedGridId_;
			}
			set
			{
				this.rewardedGridId_ = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x000D84DB File Offset: 0x000D66DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBoardIds
		{
			get
			{
				return this.rewardedBoardIds_;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x000D84E3 File Offset: 0x000D66E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x000D84EB File Offset: 0x000D66EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> TaskRefreshTime
		{
			get
			{
				return this.taskRefreshTime_;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x000D84F3 File Offset: 0x000D66F3
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x000D84FB File Offset: 0x000D66FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardUnlockTime
		{
			get
			{
				return this.boardUnlockTime_;
			}
			set
			{
				this.boardUnlockTime_ = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x000D8504 File Offset: 0x000D6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, DangoMonopolyBoardRecordPb> BoardRecords
		{
			get
			{
				return this.boardRecords_;
			}
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x000D850C File Offset: 0x000D670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyActivityPbData);
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x000D851C File Offset: 0x000D671C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyActivityPbData other)
		{
			return other != null && (other == this || (this.BoardId == other.BoardId && this.GridId == other.GridId && this.RewardedGridId == other.RewardedGridId && this.rewardedBoardIds_.Equals(other.rewardedBoardIds_) && this.taskDatas_.Equals(other.taskDatas_) && this.TaskRefreshTime.Equals(other.TaskRefreshTime) && this.BoardUnlockTime == other.BoardUnlockTime && this.BoardRecords.Equals(other.BoardRecords) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x000D85DC File Offset: 0x000D67DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardId != 0)
			{
				num ^= this.BoardId.GetHashCode();
			}
			if (this.GridId != 0)
			{
				num ^= this.GridId.GetHashCode();
			}
			if (this.RewardedGridId != 0)
			{
				num ^= this.RewardedGridId.GetHashCode();
			}
			num ^= this.rewardedBoardIds_.GetHashCode();
			num ^= this.taskDatas_.GetHashCode();
			num ^= this.TaskRefreshTime.GetHashCode();
			if (this.BoardUnlockTime != 0L)
			{
				num ^= this.BoardUnlockTime.GetHashCode();
			}
			num ^= this.BoardRecords.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x000D869E File Offset: 0x000D689E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x000D86AB File Offset: 0x000D68AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x000D86B4 File Offset: 0x000D68B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BoardId);
			}
			if (this.GridId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GridId);
			}
			if (this.RewardedGridId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardedGridId);
			}
			this.rewardedBoardIds_.WriteTo(ref output, DangoMonopolyActivityPbData._repeated_rewardedBoardIds_codec);
			this.taskDatas_.WriteTo(ref output, DangoMonopolyActivityPbData._repeated_taskDatas_codec);
			this.taskRefreshTime_.WriteTo(ref output, DangoMonopolyActivityPbData._map_taskRefreshTime_codec);
			if (this.BoardUnlockTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BoardUnlockTime);
			}
			this.boardRecords_.WriteTo(ref output, DangoMonopolyActivityPbData._map_boardRecords_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x000D8788 File Offset: 0x000D6988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardId);
			}
			if (this.GridId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridId);
			}
			if (this.RewardedGridId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedGridId);
			}
			num += this.rewardedBoardIds_.CalculateSize(DangoMonopolyActivityPbData._repeated_rewardedBoardIds_codec);
			num += this.taskDatas_.CalculateSize(DangoMonopolyActivityPbData._repeated_taskDatas_codec);
			num += this.taskRefreshTime_.CalculateSize(DangoMonopolyActivityPbData._map_taskRefreshTime_codec);
			if (this.BoardUnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardUnlockTime);
			}
			num += this.boardRecords_.CalculateSize(DangoMonopolyActivityPbData._map_boardRecords_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x000D885C File Offset: 0x000D6A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyActivityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardId != 0)
			{
				this.BoardId = other.BoardId;
			}
			if (other.GridId != 0)
			{
				this.GridId = other.GridId;
			}
			if (other.RewardedGridId != 0)
			{
				this.RewardedGridId = other.RewardedGridId;
			}
			this.rewardedBoardIds_.Add(other.rewardedBoardIds_);
			this.taskDatas_.Add(other.taskDatas_);
			this.taskRefreshTime_.MergeFrom(other.taskRefreshTime_);
			if (other.BoardUnlockTime != 0L)
			{
				this.BoardUnlockTime = other.BoardUnlockTime;
			}
			this.boardRecords_.MergeFrom(other.boardRecords_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x000D8918 File Offset: 0x000D6B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x000D8924 File Offset: 0x000D6B24
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.BoardId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.GridId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.RewardedGridId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							goto IL_94;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						goto IL_94;
					}
					if (num == 42U)
					{
						this.taskDatas_.AddEntriesFrom(ref input, DangoMonopolyActivityPbData._repeated_taskDatas_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.taskRefreshTime_.AddEntriesFrom(ref input, DangoMonopolyActivityPbData._map_taskRefreshTime_codec);
						continue;
					}
					if (num == 56U)
					{
						this.BoardUnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 66U)
					{
						this.boardRecords_.AddEntriesFrom(ref input, DangoMonopolyActivityPbData._map_boardRecords_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_94:
				this.rewardedBoardIds_.AddEntriesFrom(ref input, DangoMonopolyActivityPbData._repeated_rewardedBoardIds_codec);
			}
		}

		// Token: 0x04003527 RID: 13607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003528 RID: 13608
		public const int BoardIdFieldNumber = 1;

		// Token: 0x04003529 RID: 13609
		private int boardId_;

		// Token: 0x0400352A RID: 13610
		public const int GridIdFieldNumber = 2;

		// Token: 0x0400352B RID: 13611
		private int gridId_;

		// Token: 0x0400352C RID: 13612
		public const int RewardedGridIdFieldNumber = 3;

		// Token: 0x0400352D RID: 13613
		private int rewardedGridId_;

		// Token: 0x0400352E RID: 13614
		public const int RewardedBoardIdsFieldNumber = 4;

		// Token: 0x0400352F RID: 13615
		private static readonly FieldCodec<int> _repeated_rewardedBoardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04003530 RID: 13616
		private readonly RepeatedField<int> rewardedBoardIds_ = new RepeatedField<int>();

		// Token: 0x04003531 RID: 13617
		public const int TaskDatasFieldNumber = 5;

		// Token: 0x04003532 RID: 13618
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(42U, DangoMonopolyTaskData.Parser);

		// Token: 0x04003533 RID: 13619
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();

		// Token: 0x04003534 RID: 13620
		public const int TaskRefreshTimeFieldNumber = 6;

		// Token: 0x04003535 RID: 13621
		private static readonly MapField<int, long>.Codec _map_taskRefreshTime_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 50U);

		// Token: 0x04003536 RID: 13622
		private readonly MapField<int, long> taskRefreshTime_ = new MapField<int, long>();

		// Token: 0x04003537 RID: 13623
		public const int BoardUnlockTimeFieldNumber = 7;

		// Token: 0x04003538 RID: 13624
		private long boardUnlockTime_;

		// Token: 0x04003539 RID: 13625
		public const int BoardRecordsFieldNumber = 8;

		// Token: 0x0400353A RID: 13626
		private static readonly MapField<int, DangoMonopolyBoardRecordPb>.Codec _map_boardRecords_codec = new MapField<int, DangoMonopolyBoardRecordPb>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<DangoMonopolyBoardRecordPb>(18U, DangoMonopolyBoardRecordPb.Parser), 66U);

		// Token: 0x0400353B RID: 13627
		private readonly MapField<int, DangoMonopolyBoardRecordPb> boardRecords_ = new MapField<int, DangoMonopolyBoardRecordPb>();
	}
}
