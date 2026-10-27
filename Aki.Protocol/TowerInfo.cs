using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C0 RID: 5056
	public sealed class TowerInfo : IMessage<TowerInfo>, IMessage, IEquatable<TowerInfo>, IDeepCloneable<TowerInfo>, IBufferMessage
	{
		// Token: 0x0601AD18 RID: 109848 RVA: 0x003E3595 File Offset: 0x003E1795
		[NullableContext(1)]
		public static TowerInfo Create()
		{
			return new TowerInfo();
		}

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x0601AD19 RID: 109849 RVA: 0x003E359C File Offset: 0x003E179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x0601AD1A RID: 109850 RVA: 0x003E359F File Offset: 0x003E179F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerInfo.Descriptor;
			}
		}

		// Token: 0x0601AD1B RID: 109851 RVA: 0x003E35A6 File Offset: 0x003E17A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo()
		{
		}

		// Token: 0x0601AD1C RID: 109852 RVA: 0x003E35BC File Offset: 0x003E17BC
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

		// Token: 0x0601AD1D RID: 109853 RVA: 0x003E3639 File Offset: 0x003E1839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo Clone()
		{
			return new TowerInfo(this);
		}

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x0601AD1E RID: 109854 RVA: 0x003E3641 File Offset: 0x003E1841
		// (set) Token: 0x0601AD1F RID: 109855 RVA: 0x003E3649 File Offset: 0x003E1849
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

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x0601AD20 RID: 109856 RVA: 0x003E3652 File Offset: 0x003E1852
		// (set) Token: 0x0601AD21 RID: 109857 RVA: 0x003E365A File Offset: 0x003E185A
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

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x0601AD22 RID: 109858 RVA: 0x003E3663 File Offset: 0x003E1863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDifficultyPb> TowerDifficulties
		{
			get
			{
				return this.towerDifficulties_;
			}
		}

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x0601AD23 RID: 109859 RVA: 0x003E366B File Offset: 0x003E186B
		// (set) Token: 0x0601AD24 RID: 109860 RVA: 0x003E3673 File Offset: 0x003E1873
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

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x0601AD25 RID: 109861 RVA: 0x003E367C File Offset: 0x003E187C
		// (set) Token: 0x0601AD26 RID: 109862 RVA: 0x003E3684 File Offset: 0x003E1884
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

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x0601AD27 RID: 109863 RVA: 0x003E368D File Offset: 0x003E188D
		// (set) Token: 0x0601AD28 RID: 109864 RVA: 0x003E3695 File Offset: 0x003E1895
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

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x0601AD29 RID: 109865 RVA: 0x003E369E File Offset: 0x003E189E
		// (set) Token: 0x0601AD2A RID: 109866 RVA: 0x003E36A6 File Offset: 0x003E18A6
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

		// Token: 0x0601AD2B RID: 109867 RVA: 0x003E36AF File Offset: 0x003E18AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerInfo);
		}

		// Token: 0x0601AD2C RID: 109868 RVA: 0x003E36C0 File Offset: 0x003E18C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerInfo other)
		{
			return other != null && (other == this || (this.CurrentSeason == other.CurrentSeason && this.DataSeason == other.DataSeason && this.towerDifficulties_.Equals(other.towerDifficulties_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.MaxUnlockDifficulty == other.MaxUnlockDifficulty && this.QuickPassId == other.QuickPassId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD2D RID: 109869 RVA: 0x003E3760 File Offset: 0x003E1960
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

		// Token: 0x0601AD2E RID: 109870 RVA: 0x003E382A File Offset: 0x003E1A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD2F RID: 109871 RVA: 0x003E3837 File Offset: 0x003E1A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD30 RID: 109872 RVA: 0x003E3840 File Offset: 0x003E1A40
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

		// Token: 0x0601AD31 RID: 109873 RVA: 0x003E391C File Offset: 0x003E1B1C
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

		// Token: 0x0601AD32 RID: 109874 RVA: 0x003E39E8 File Offset: 0x003E1BE8
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

		// Token: 0x0601AD33 RID: 109875 RVA: 0x003E3A99 File Offset: 0x003E1C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD34 RID: 109876 RVA: 0x003E3AA4 File Offset: 0x003E1CA4
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

		// Token: 0x04009BA3 RID: 39843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BA4 RID: 39844
		public const int CurrentSeasonFieldNumber = 1;

		// Token: 0x04009BA5 RID: 39845
		private int currentSeason_;

		// Token: 0x04009BA6 RID: 39846
		public const int DataSeasonFieldNumber = 2;

		// Token: 0x04009BA7 RID: 39847
		private int dataSeason_;

		// Token: 0x04009BA8 RID: 39848
		public const int TowerDifficultiesFieldNumber = 3;

		// Token: 0x04009BA9 RID: 39849
		private static readonly FieldCodec<TowerDifficultyPb> _repeated_towerDifficulties_codec = FieldCodec.ForMessage<TowerDifficultyPb>(26U, TowerDifficultyPb.Parser);

		// Token: 0x04009BAA RID: 39850
		private readonly RepeatedField<TowerDifficultyPb> towerDifficulties_ = new RepeatedField<TowerDifficultyPb>();

		// Token: 0x04009BAB RID: 39851
		public const int BeginTimeFieldNumber = 4;

		// Token: 0x04009BAC RID: 39852
		private long beginTime_;

		// Token: 0x04009BAD RID: 39853
		public const int EndTimeFieldNumber = 5;

		// Token: 0x04009BAE RID: 39854
		private long endTime_;

		// Token: 0x04009BAF RID: 39855
		public const int MaxUnlockDifficultyFieldNumber = 6;

		// Token: 0x04009BB0 RID: 39856
		private int maxUnlockDifficulty_;

		// Token: 0x04009BB1 RID: 39857
		public const int QuickPassIdFieldNumber = 7;

		// Token: 0x04009BB2 RID: 39858
		private int quickPassId_;
	}
}
