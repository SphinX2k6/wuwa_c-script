using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000388 RID: 904
	public sealed class DangoMonopolyActivityPbData : IMessage<DangoMonopolyActivityPbData>, IMessage, IEquatable<DangoMonopolyActivityPbData>, IDeepCloneable<DangoMonopolyActivityPbData>, IBufferMessage
	{
		// Token: 0x060059B1 RID: 22961 RVA: 0x000DAA4A File Offset: 0x000D8C4A
		[NullableContext(1)]
		public static DangoMonopolyActivityPbData Create()
		{
			return new DangoMonopolyActivityPbData();
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060059B2 RID: 22962 RVA: 0x000DAA51 File Offset: 0x000D8C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060059B3 RID: 22963 RVA: 0x000DAA54 File Offset: 0x000D8C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyActivityPbData.Descriptor;
			}
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x000DAA5B File Offset: 0x000D8C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData()
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x000DAA90 File Offset: 0x000D8C90
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

		// Token: 0x060059B6 RID: 22966 RVA: 0x000DAB28 File Offset: 0x000D8D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyActivityPbData Clone()
		{
			return new DangoMonopolyActivityPbData(this);
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x000DAB30 File Offset: 0x000D8D30
		// (set) Token: 0x060059B8 RID: 22968 RVA: 0x000DAB38 File Offset: 0x000D8D38
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060059B9 RID: 22969 RVA: 0x000DAB41 File Offset: 0x000D8D41
		// (set) Token: 0x060059BA RID: 22970 RVA: 0x000DAB49 File Offset: 0x000D8D49
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

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060059BB RID: 22971 RVA: 0x000DAB52 File Offset: 0x000D8D52
		// (set) Token: 0x060059BC RID: 22972 RVA: 0x000DAB5A File Offset: 0x000D8D5A
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

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x000DAB63 File Offset: 0x000D8D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBoardIds
		{
			get
			{
				return this.rewardedBoardIds_;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060059BE RID: 22974 RVA: 0x000DAB6B File Offset: 0x000D8D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060059BF RID: 22975 RVA: 0x000DAB73 File Offset: 0x000D8D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> TaskRefreshTime
		{
			get
			{
				return this.taskRefreshTime_;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x000DAB7B File Offset: 0x000D8D7B
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x000DAB83 File Offset: 0x000D8D83
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

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x000DAB8C File Offset: 0x000D8D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, DangoMonopolyBoardRecordPb> BoardRecords
		{
			get
			{
				return this.boardRecords_;
			}
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x000DAB94 File Offset: 0x000D8D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyActivityPbData);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x000DABA4 File Offset: 0x000D8DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyActivityPbData other)
		{
			return other != null && (other == this || (this.BoardId == other.BoardId && this.GridId == other.GridId && this.RewardedGridId == other.RewardedGridId && this.rewardedBoardIds_.Equals(other.rewardedBoardIds_) && this.taskDatas_.Equals(other.taskDatas_) && this.TaskRefreshTime.Equals(other.TaskRefreshTime) && this.BoardUnlockTime == other.BoardUnlockTime && this.BoardRecords.Equals(other.BoardRecords) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x000DAC64 File Offset: 0x000D8E64
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

		// Token: 0x060059C6 RID: 22982 RVA: 0x000DAD26 File Offset: 0x000D8F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x000DAD33 File Offset: 0x000D8F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x000DAD3C File Offset: 0x000D8F3C
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

		// Token: 0x060059C9 RID: 22985 RVA: 0x000DAE10 File Offset: 0x000D9010
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

		// Token: 0x060059CA RID: 22986 RVA: 0x000DAEE4 File Offset: 0x000D90E4
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

		// Token: 0x060059CB RID: 22987 RVA: 0x000DAFA0 File Offset: 0x000D91A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x000DAFAC File Offset: 0x000D91AC
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

		// Token: 0x040035C3 RID: 13763
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C4 RID: 13764
		public const int BoardIdFieldNumber = 1;

		// Token: 0x040035C5 RID: 13765
		private int boardId_;

		// Token: 0x040035C6 RID: 13766
		public const int GridIdFieldNumber = 2;

		// Token: 0x040035C7 RID: 13767
		private int gridId_;

		// Token: 0x040035C8 RID: 13768
		public const int RewardedGridIdFieldNumber = 3;

		// Token: 0x040035C9 RID: 13769
		private int rewardedGridId_;

		// Token: 0x040035CA RID: 13770
		public const int RewardedBoardIdsFieldNumber = 4;

		// Token: 0x040035CB RID: 13771
		private static readonly FieldCodec<int> _repeated_rewardedBoardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040035CC RID: 13772
		private readonly RepeatedField<int> rewardedBoardIds_ = new RepeatedField<int>();

		// Token: 0x040035CD RID: 13773
		public const int TaskDatasFieldNumber = 5;

		// Token: 0x040035CE RID: 13774
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(42U, DangoMonopolyTaskData.Parser);

		// Token: 0x040035CF RID: 13775
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();

		// Token: 0x040035D0 RID: 13776
		public const int TaskRefreshTimeFieldNumber = 6;

		// Token: 0x040035D1 RID: 13777
		private static readonly MapField<int, long>.Codec _map_taskRefreshTime_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 50U);

		// Token: 0x040035D2 RID: 13778
		private readonly MapField<int, long> taskRefreshTime_ = new MapField<int, long>();

		// Token: 0x040035D3 RID: 13779
		public const int BoardUnlockTimeFieldNumber = 7;

		// Token: 0x040035D4 RID: 13780
		private long boardUnlockTime_;

		// Token: 0x040035D5 RID: 13781
		public const int BoardRecordsFieldNumber = 8;

		// Token: 0x040035D6 RID: 13782
		private static readonly MapField<int, DangoMonopolyBoardRecordPb>.Codec _map_boardRecords_codec = new MapField<int, DangoMonopolyBoardRecordPb>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<DangoMonopolyBoardRecordPb>(18U, DangoMonopolyBoardRecordPb.Parser), 66U);

		// Token: 0x040035D7 RID: 13783
		private readonly MapField<int, DangoMonopolyBoardRecordPb> boardRecords_ = new MapField<int, DangoMonopolyBoardRecordPb>();
	}
}
