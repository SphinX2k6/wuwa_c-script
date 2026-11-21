using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000677 RID: 1655
	public sealed class GachaAccumulateRewardInfo : IMessage<GachaAccumulateRewardInfo>, IMessage, IEquatable<GachaAccumulateRewardInfo>, IDeepCloneable<GachaAccumulateRewardInfo>, IBufferMessage
	{
		// Token: 0x060097F1 RID: 38897 RVA: 0x0016E7D7 File Offset: 0x0016C9D7
		[NullableContext(1)]
		public static GachaAccumulateRewardInfo Create()
		{
			return new GachaAccumulateRewardInfo();
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x060097F2 RID: 38898 RVA: 0x0016E7DE File Offset: 0x0016C9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaAccumulateRewardInfo> Parser
		{
			get
			{
				return GachaAccumulateRewardInfo._parser;
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x060097F3 RID: 38899 RVA: 0x0016E7E5 File Offset: 0x0016C9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x060097F4 RID: 38900 RVA: 0x0016E7E8 File Offset: 0x0016C9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardInfo.Descriptor;
			}
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x0016E7EF File Offset: 0x0016C9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardInfo()
		{
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x0016E804 File Offset: 0x0016CA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardInfo(GachaAccumulateRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.groupId_ = other.groupId_;
			this.gachaNum_ = other.gachaNum_;
			this.rewardContent_ = other.rewardContent_.Clone();
			this.status_ = other.status_;
			this.isBigReward_ = other.isBigReward_;
			this.cycleCount_ = other.cycleCount_;
			this.cycleRewardedTimes_ = other.cycleRewardedTimes_;
			this.isPreView_ = other.isPreView_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x0016E899 File Offset: 0x0016CA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardInfo Clone()
		{
			return new GachaAccumulateRewardInfo(this);
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x060097F8 RID: 38904 RVA: 0x0016E8A1 File Offset: 0x0016CAA1
		// (set) Token: 0x060097F9 RID: 38905 RVA: 0x0016E8A9 File Offset: 0x0016CAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x060097FA RID: 38906 RVA: 0x0016E8B2 File Offset: 0x0016CAB2
		// (set) Token: 0x060097FB RID: 38907 RVA: 0x0016E8BA File Offset: 0x0016CABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x060097FC RID: 38908 RVA: 0x0016E8C3 File Offset: 0x0016CAC3
		// (set) Token: 0x060097FD RID: 38909 RVA: 0x0016E8CB File Offset: 0x0016CACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaNum
		{
			get
			{
				return this.gachaNum_;
			}
			set
			{
				this.gachaNum_ = value;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x060097FE RID: 38910 RVA: 0x0016E8D4 File Offset: 0x0016CAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x060097FF RID: 38911 RVA: 0x0016E8DC File Offset: 0x0016CADC
		// (set) Token: 0x06009800 RID: 38912 RVA: 0x0016E8E4 File Offset: 0x0016CAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06009801 RID: 38913 RVA: 0x0016E8ED File Offset: 0x0016CAED
		// (set) Token: 0x06009802 RID: 38914 RVA: 0x0016E8F5 File Offset: 0x0016CAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBigReward
		{
			get
			{
				return this.isBigReward_;
			}
			set
			{
				this.isBigReward_ = value;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x0016E8FE File Offset: 0x0016CAFE
		// (set) Token: 0x06009804 RID: 38916 RVA: 0x0016E906 File Offset: 0x0016CB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleCount
		{
			get
			{
				return this.cycleCount_;
			}
			set
			{
				this.cycleCount_ = value;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x0016E90F File Offset: 0x0016CB0F
		// (set) Token: 0x06009806 RID: 38918 RVA: 0x0016E917 File Offset: 0x0016CB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleRewardedTimes
		{
			get
			{
				return this.cycleRewardedTimes_;
			}
			set
			{
				this.cycleRewardedTimes_ = value;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06009807 RID: 38919 RVA: 0x0016E920 File Offset: 0x0016CB20
		// (set) Token: 0x06009808 RID: 38920 RVA: 0x0016E928 File Offset: 0x0016CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPreView
		{
			get
			{
				return this.isPreView_;
			}
			set
			{
				this.isPreView_ = value;
			}
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x0016E931 File Offset: 0x0016CB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardInfo);
		}

		// Token: 0x0600980A RID: 38922 RVA: 0x0016E940 File Offset: 0x0016CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GroupId == other.GroupId && this.GachaNum == other.GachaNum && this.RewardContent.Equals(other.RewardContent) && this.Status == other.Status && this.IsBigReward == other.IsBigReward && this.CycleCount == other.CycleCount && this.CycleRewardedTimes == other.CycleRewardedTimes && this.IsPreView == other.IsPreView && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x0016EA00 File Offset: 0x0016CC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.GachaNum != 0)
			{
				num ^= this.GachaNum.GetHashCode();
			}
			num ^= this.RewardContent.GetHashCode();
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.IsBigReward)
			{
				num ^= this.IsBigReward.GetHashCode();
			}
			if (this.CycleCount != 0)
			{
				num ^= this.CycleCount.GetHashCode();
			}
			if (this.CycleRewardedTimes != 0)
			{
				num ^= this.CycleRewardedTimes.GetHashCode();
			}
			if (this.IsPreView)
			{
				num ^= this.IsPreView.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600980C RID: 38924 RVA: 0x0016EAFC File Offset: 0x0016CCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x0016EB09 File Offset: 0x0016CD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x0016EB14 File Offset: 0x0016CD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.GachaNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GachaNum);
			}
			this.rewardContent_.WriteTo(ref output, GachaAccumulateRewardInfo._map_rewardContent_codec);
			if (this.Status != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Status);
			}
			if (this.IsBigReward)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsBigReward);
			}
			if (this.CycleCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CycleCount);
			}
			if (this.CycleRewardedTimes != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CycleRewardedTimes);
			}
			if (this.IsPreView)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsPreView);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x0016EC28 File Offset: 0x0016CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.GachaNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaNum);
			}
			num += this.rewardContent_.CalculateSize(GachaAccumulateRewardInfo._map_rewardContent_codec);
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.IsBigReward)
			{
				num += 2;
			}
			if (this.CycleCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleCount);
			}
			if (this.CycleRewardedTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleRewardedTimes);
			}
			if (this.IsPreView)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x0016ED0C File Offset: 0x0016CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.GachaNum != 0)
			{
				this.GachaNum = other.GachaNum;
			}
			this.rewardContent_.MergeFrom(other.rewardContent_);
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.IsBigReward)
			{
				this.IsBigReward = other.IsBigReward;
			}
			if (other.CycleCount != 0)
			{
				this.CycleCount = other.CycleCount;
			}
			if (other.CycleRewardedTimes != 0)
			{
				this.CycleRewardedTimes = other.CycleRewardedTimes;
			}
			if (other.IsPreView)
			{
				this.IsPreView = other.IsPreView;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x0016EDE5 File Offset: 0x0016CFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x0016EDF0 File Offset: 0x0016CFF0
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.GroupId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.GachaNum = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							this.rewardContent_.AddEntriesFrom(ref input, GachaAccumulateRewardInfo._map_rewardContent_codec);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Status = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsBigReward = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.CycleCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CycleRewardedTimes = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IsPreView = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004878 RID: 18552
		private static readonly MessageParser<GachaAccumulateRewardInfo> _parser = new MessageParser<GachaAccumulateRewardInfo>(() => new GachaAccumulateRewardInfo());

		// Token: 0x04004879 RID: 18553
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400487A RID: 18554
		public const int IdFieldNumber = 1;

		// Token: 0x0400487B RID: 18555
		private int id_;

		// Token: 0x0400487C RID: 18556
		public const int GroupIdFieldNumber = 2;

		// Token: 0x0400487D RID: 18557
		private int groupId_;

		// Token: 0x0400487E RID: 18558
		public const int GachaNumFieldNumber = 3;

		// Token: 0x0400487F RID: 18559
		private int gachaNum_;

		// Token: 0x04004880 RID: 18560
		public const int RewardContentFieldNumber = 4;

		// Token: 0x04004881 RID: 18561
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04004882 RID: 18562
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x04004883 RID: 18563
		public const int StatusFieldNumber = 5;

		// Token: 0x04004884 RID: 18564
		private int status_;

		// Token: 0x04004885 RID: 18565
		public const int IsBigRewardFieldNumber = 6;

		// Token: 0x04004886 RID: 18566
		private bool isBigReward_;

		// Token: 0x04004887 RID: 18567
		public const int CycleCountFieldNumber = 7;

		// Token: 0x04004888 RID: 18568
		private int cycleCount_;

		// Token: 0x04004889 RID: 18569
		public const int CycleRewardedTimesFieldNumber = 8;

		// Token: 0x0400488A RID: 18570
		private int cycleRewardedTimes_;

		// Token: 0x0400488B RID: 18571
		public const int IsPreViewFieldNumber = 9;

		// Token: 0x0400488C RID: 18572
		private bool isPreView_;
	}
}
