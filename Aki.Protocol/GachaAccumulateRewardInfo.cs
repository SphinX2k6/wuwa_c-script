using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068B RID: 1675
	public sealed class GachaAccumulateRewardInfo : IMessage<GachaAccumulateRewardInfo>, IMessage, IEquatable<GachaAccumulateRewardInfo>, IDeepCloneable<GachaAccumulateRewardInfo>, IBufferMessage
	{
		// Token: 0x06009947 RID: 39239 RVA: 0x0017120B File Offset: 0x0016F40B
		[NullableContext(1)]
		public static GachaAccumulateRewardInfo Create()
		{
			return new GachaAccumulateRewardInfo();
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x00171212 File Offset: 0x0016F412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaAccumulateRewardInfo> Parser
		{
			get
			{
				return GachaAccumulateRewardInfo._parser;
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06009949 RID: 39241 RVA: 0x00171219 File Offset: 0x0016F419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x0017121C File Offset: 0x0016F41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00171223 File Offset: 0x0016F423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardInfo()
		{
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00171238 File Offset: 0x0016F438
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

		// Token: 0x0600994D RID: 39245 RVA: 0x001712CD File Offset: 0x0016F4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardInfo Clone()
		{
			return new GachaAccumulateRewardInfo(this);
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600994E RID: 39246 RVA: 0x001712D5 File Offset: 0x0016F4D5
		// (set) Token: 0x0600994F RID: 39247 RVA: 0x001712DD File Offset: 0x0016F4DD
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

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x001712E6 File Offset: 0x0016F4E6
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x001712EE File Offset: 0x0016F4EE
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

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x001712F7 File Offset: 0x0016F4F7
		// (set) Token: 0x06009953 RID: 39251 RVA: 0x001712FF File Offset: 0x0016F4FF
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

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x00171308 File Offset: 0x0016F508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06009955 RID: 39253 RVA: 0x00171310 File Offset: 0x0016F510
		// (set) Token: 0x06009956 RID: 39254 RVA: 0x00171318 File Offset: 0x0016F518
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

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06009957 RID: 39255 RVA: 0x00171321 File Offset: 0x0016F521
		// (set) Token: 0x06009958 RID: 39256 RVA: 0x00171329 File Offset: 0x0016F529
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

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06009959 RID: 39257 RVA: 0x00171332 File Offset: 0x0016F532
		// (set) Token: 0x0600995A RID: 39258 RVA: 0x0017133A File Offset: 0x0016F53A
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

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600995B RID: 39259 RVA: 0x00171343 File Offset: 0x0016F543
		// (set) Token: 0x0600995C RID: 39260 RVA: 0x0017134B File Offset: 0x0016F54B
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

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600995D RID: 39261 RVA: 0x00171354 File Offset: 0x0016F554
		// (set) Token: 0x0600995E RID: 39262 RVA: 0x0017135C File Offset: 0x0016F55C
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

		// Token: 0x0600995F RID: 39263 RVA: 0x00171365 File Offset: 0x0016F565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardInfo);
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x00171374 File Offset: 0x0016F574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GroupId == other.GroupId && this.GachaNum == other.GachaNum && this.RewardContent.Equals(other.RewardContent) && this.Status == other.Status && this.IsBigReward == other.IsBigReward && this.CycleCount == other.CycleCount && this.CycleRewardedTimes == other.CycleRewardedTimes && this.IsPreView == other.IsPreView && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009961 RID: 39265 RVA: 0x00171434 File Offset: 0x0016F634
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

		// Token: 0x06009962 RID: 39266 RVA: 0x00171530 File Offset: 0x0016F730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x0017153D File Offset: 0x0016F73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00171548 File Offset: 0x0016F748
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

		// Token: 0x06009965 RID: 39269 RVA: 0x0017165C File Offset: 0x0016F85C
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

		// Token: 0x06009966 RID: 39270 RVA: 0x00171740 File Offset: 0x0016F940
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

		// Token: 0x06009967 RID: 39271 RVA: 0x00171819 File Offset: 0x0016FA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00171824 File Offset: 0x0016FA24
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

		// Token: 0x0400487F RID: 18559
		private static readonly MessageParser<GachaAccumulateRewardInfo> _parser = new MessageParser<GachaAccumulateRewardInfo>(() => new GachaAccumulateRewardInfo());

		// Token: 0x04004880 RID: 18560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004881 RID: 18561
		public const int IdFieldNumber = 1;

		// Token: 0x04004882 RID: 18562
		private int id_;

		// Token: 0x04004883 RID: 18563
		public const int GroupIdFieldNumber = 2;

		// Token: 0x04004884 RID: 18564
		private int groupId_;

		// Token: 0x04004885 RID: 18565
		public const int GachaNumFieldNumber = 3;

		// Token: 0x04004886 RID: 18566
		private int gachaNum_;

		// Token: 0x04004887 RID: 18567
		public const int RewardContentFieldNumber = 4;

		// Token: 0x04004888 RID: 18568
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04004889 RID: 18569
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x0400488A RID: 18570
		public const int StatusFieldNumber = 5;

		// Token: 0x0400488B RID: 18571
		private int status_;

		// Token: 0x0400488C RID: 18572
		public const int IsBigRewardFieldNumber = 6;

		// Token: 0x0400488D RID: 18573
		private bool isBigReward_;

		// Token: 0x0400488E RID: 18574
		public const int CycleCountFieldNumber = 7;

		// Token: 0x0400488F RID: 18575
		private int cycleCount_;

		// Token: 0x04004890 RID: 18576
		public const int CycleRewardedTimesFieldNumber = 8;

		// Token: 0x04004891 RID: 18577
		private int cycleRewardedTimes_;

		// Token: 0x04004892 RID: 18578
		public const int IsPreViewFieldNumber = 9;

		// Token: 0x04004893 RID: 18579
		private bool isPreView_;
	}
}
