using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001433 RID: 5171
	public sealed class TowerInfo : IMessage<TowerInfo>, IMessage, IEquatable<TowerInfo>, IDeepCloneable<TowerInfo>, IBufferMessage
	{
		// Token: 0x0601B7A3 RID: 112547 RVA: 0x003FE859 File Offset: 0x003FCA59
		[NullableContext(1)]
		public static TowerInfo Create()
		{
			return new TowerInfo();
		}

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x0601B7A4 RID: 112548 RVA: 0x003FE860 File Offset: 0x003FCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x0601B7A5 RID: 112549 RVA: 0x003FE863 File Offset: 0x003FCA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerInfo.Descriptor;
			}
		}

		// Token: 0x0601B7A6 RID: 112550 RVA: 0x003FE86A File Offset: 0x003FCA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo()
		{
		}

		// Token: 0x0601B7A7 RID: 112551 RVA: 0x003FE880 File Offset: 0x003FCA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo(TowerInfo other) : this()
		{
			this.currentSeason_ = other.currentSeason_;
			this.dataSeason_ = other.dataSeason_;
			this.towerDifficulties_ = other.towerDifficulties_.Clone();
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.maxUnlockDifficulty_ = other.maxUnlockDifficulty_;
			this.quickPassId_ = other.quickPassId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7A8 RID: 112552 RVA: 0x003FE8FD File Offset: 0x003FCAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo Clone()
		{
			return new TowerInfo(this);
		}

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x0601B7A9 RID: 112553 RVA: 0x003FE905 File Offset: 0x003FCB05
		// (set) Token: 0x0601B7AA RID: 112554 RVA: 0x003FE90D File Offset: 0x003FCB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentSeason
		{
			get
			{
				return this.currentSeason_;
			}
			set
			{
				this.currentSeason_ = value;
			}
		}

		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x0601B7AB RID: 112555 RVA: 0x003FE916 File Offset: 0x003FCB16
		// (set) Token: 0x0601B7AC RID: 112556 RVA: 0x003FE91E File Offset: 0x003FCB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DataSeason
		{
			get
			{
				return this.dataSeason_;
			}
			set
			{
				this.dataSeason_ = value;
			}
		}

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x0601B7AD RID: 112557 RVA: 0x003FE927 File Offset: 0x003FCB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDifficultyPb> TowerDifficulties
		{
			get
			{
				return this.towerDifficulties_;
			}
		}

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x0601B7AE RID: 112558 RVA: 0x003FE92F File Offset: 0x003FCB2F
		// (set) Token: 0x0601B7AF RID: 112559 RVA: 0x003FE937 File Offset: 0x003FCB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x0601B7B0 RID: 112560 RVA: 0x003FE940 File Offset: 0x003FCB40
		// (set) Token: 0x0601B7B1 RID: 112561 RVA: 0x003FE948 File Offset: 0x003FCB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x0601B7B2 RID: 112562 RVA: 0x003FE951 File Offset: 0x003FCB51
		// (set) Token: 0x0601B7B3 RID: 112563 RVA: 0x003FE959 File Offset: 0x003FCB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxUnlockDifficulty
		{
			get
			{
				return this.maxUnlockDifficulty_;
			}
			set
			{
				this.maxUnlockDifficulty_ = value;
			}
		}

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x0601B7B4 RID: 112564 RVA: 0x003FE962 File Offset: 0x003FCB62
		// (set) Token: 0x0601B7B5 RID: 112565 RVA: 0x003FE96A File Offset: 0x003FCB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuickPassId
		{
			get
			{
				return this.quickPassId_;
			}
			set
			{
				this.quickPassId_ = value;
			}
		}

		// Token: 0x0601B7B6 RID: 112566 RVA: 0x003FE973 File Offset: 0x003FCB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerInfo);
		}

		// Token: 0x0601B7B7 RID: 112567 RVA: 0x003FE984 File Offset: 0x003FCB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerInfo other)
		{
			return other != null && (other == this || (this.CurrentSeason == other.CurrentSeason && this.DataSeason == other.DataSeason && this.towerDifficulties_.Equals(other.towerDifficulties_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.MaxUnlockDifficulty == other.MaxUnlockDifficulty && this.QuickPassId == other.QuickPassId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7B8 RID: 112568 RVA: 0x003FEA24 File Offset: 0x003FCC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrentSeason != 0)
			{
				num ^= this.CurrentSeason.GetHashCode();
			}
			if (this.DataSeason != 0)
			{
				num ^= this.DataSeason.GetHashCode();
			}
			num ^= this.towerDifficulties_.GetHashCode();
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num ^= this.MaxUnlockDifficulty.GetHashCode();
			}
			if (this.QuickPassId != 0)
			{
				num ^= this.QuickPassId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7B9 RID: 112569 RVA: 0x003FEAEE File Offset: 0x003FCCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7BA RID: 112570 RVA: 0x003FEAFB File Offset: 0x003FCCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7BB RID: 112571 RVA: 0x003FEB04 File Offset: 0x003FCD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentSeason != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrentSeason);
			}
			if (this.DataSeason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DataSeason);
			}
			this.towerDifficulties_.WriteTo(ref output, TowerInfo._repeated_towerDifficulties_codec);
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndTime);
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxUnlockDifficulty);
			}
			if (this.QuickPassId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.QuickPassId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7BC RID: 112572 RVA: 0x003FEBE0 File Offset: 0x003FCDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrentSeason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentSeason);
			}
			if (this.DataSeason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DataSeason);
			}
			num += this.towerDifficulties_.CalculateSize(TowerInfo._repeated_towerDifficulties_codec);
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxUnlockDifficulty);
			}
			if (this.QuickPassId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuickPassId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7BD RID: 112573 RVA: 0x003FECAC File Offset: 0x003FCEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrentSeason != 0)
			{
				this.CurrentSeason = other.CurrentSeason;
			}
			if (other.DataSeason != 0)
			{
				this.DataSeason = other.DataSeason;
			}
			this.towerDifficulties_.Add(other.towerDifficulties_);
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.MaxUnlockDifficulty != 0)
			{
				this.MaxUnlockDifficulty = other.MaxUnlockDifficulty;
			}
			if (other.QuickPassId != 0)
			{
				this.QuickPassId = other.QuickPassId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7BE RID: 112574 RVA: 0x003FED5D File Offset: 0x003FCF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7BF RID: 112575 RVA: 0x003FED68 File Offset: 0x003FCF68
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.CurrentSeason = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DataSeason = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.towerDifficulties_.AddEntriesFrom(ref input, TowerInfo._repeated_towerDifficulties_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.MaxUnlockDifficulty = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.QuickPassId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009FEA RID: 40938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FEB RID: 40939
		public const int CurrentSeasonFieldNumber = 1;

		// Token: 0x04009FEC RID: 40940
		private int currentSeason_;

		// Token: 0x04009FED RID: 40941
		public const int DataSeasonFieldNumber = 2;

		// Token: 0x04009FEE RID: 40942
		private int dataSeason_;

		// Token: 0x04009FEF RID: 40943
		public const int TowerDifficultiesFieldNumber = 3;

		// Token: 0x04009FF0 RID: 40944
		private static readonly FieldCodec<TowerDifficultyPb> _repeated_towerDifficulties_codec = FieldCodec.ForMessage<TowerDifficultyPb>(26U, TowerDifficultyPb.Parser);

		// Token: 0x04009FF1 RID: 40945
		private readonly RepeatedField<TowerDifficultyPb> towerDifficulties_ = new RepeatedField<TowerDifficultyPb>();

		// Token: 0x04009FF2 RID: 40946
		public const int BeginTimeFieldNumber = 4;

		// Token: 0x04009FF3 RID: 40947
		private long beginTime_;

		// Token: 0x04009FF4 RID: 40948
		public const int EndTimeFieldNumber = 5;

		// Token: 0x04009FF5 RID: 40949
		private long endTime_;

		// Token: 0x04009FF6 RID: 40950
		public const int MaxUnlockDifficultyFieldNumber = 6;

		// Token: 0x04009FF7 RID: 40951
		private int maxUnlockDifficulty_;

		// Token: 0x04009FF8 RID: 40952
		public const int QuickPassIdFieldNumber = 7;

		// Token: 0x04009FF9 RID: 40953
		private int quickPassId_;
	}
}
