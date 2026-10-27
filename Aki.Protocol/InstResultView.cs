using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082A RID: 2090
	public sealed class InstResultView : IMessage<InstResultView>, IMessage, IEquatable<InstResultView>, IDeepCloneable<InstResultView>, IBufferMessage
	{
		// Token: 0x0600BAC1 RID: 47809 RVA: 0x001BCAD0 File Offset: 0x001BACD0
		[NullableContext(1)]
		public static InstResultView Create()
		{
			return new InstResultView();
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x001BCAD7 File Offset: 0x001BACD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x0600BAC3 RID: 47811 RVA: 0x001BCADA File Offset: 0x001BACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstResultView.Descriptor;
			}
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x001BCAE1 File Offset: 0x001BACE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView()
		{
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x001BCB0C File Offset: 0x001BAD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView(InstResultView other) : this()
		{
			this.instId_ = other.instId_;
			this.isSucc_ = other.isSucc_;
			this.score_ = other.score_;
			this.eventCount_ = other.eventCount_;
			this.sumMoodConsume_ = other.sumMoodConsume_;
			this.sumGoldAdd_ = other.sumGoldAdd_;
			this.eventInfos_ = other.eventInfos_.Clone();
			this.teamLevel_ = other.teamLevel_;
			this.roles_ = other.roles_.Clone();
			this.roleBondInfos_ = other.roleBondInfos_.Clone();
			this.shopItemCount_ = other.shopItemCount_;
			this.shopItemMax_ = other.shopItemMax_;
			this.skillPoint_ = other.skillPoint_;
			this.skillPointMax_ = other.skillPointMax_;
			this.newIllustrationCount_ = other.newIllustrationCount_;
			this.illustrationMax_ = other.illustrationMax_;
			this.endingId_ = other.endingId_;
			this.useTime_ = other.useTime_;
			this.isNewRecord_ = other.isNewRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAC6 RID: 47814 RVA: 0x001BCC23 File Offset: 0x001BAE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView Clone()
		{
			return new InstResultView(this);
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x0600BAC7 RID: 47815 RVA: 0x001BCC2B File Offset: 0x001BAE2B
		// (set) Token: 0x0600BAC8 RID: 47816 RVA: 0x001BCC33 File Offset: 0x001BAE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x0600BAC9 RID: 47817 RVA: 0x001BCC3C File Offset: 0x001BAE3C
		// (set) Token: 0x0600BACA RID: 47818 RVA: 0x001BCC44 File Offset: 0x001BAE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSucc
		{
			get
			{
				return this.isSucc_;
			}
			set
			{
				this.isSucc_ = value;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600BACB RID: 47819 RVA: 0x001BCC4D File Offset: 0x001BAE4D
		// (set) Token: 0x0600BACC RID: 47820 RVA: 0x001BCC55 File Offset: 0x001BAE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600BACD RID: 47821 RVA: 0x001BCC5E File Offset: 0x001BAE5E
		// (set) Token: 0x0600BACE RID: 47822 RVA: 0x001BCC66 File Offset: 0x001BAE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventCount
		{
			get
			{
				return this.eventCount_;
			}
			set
			{
				this.eventCount_ = value;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600BACF RID: 47823 RVA: 0x001BCC6F File Offset: 0x001BAE6F
		// (set) Token: 0x0600BAD0 RID: 47824 RVA: 0x001BCC77 File Offset: 0x001BAE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SumMoodConsume
		{
			get
			{
				return this.sumMoodConsume_;
			}
			set
			{
				this.sumMoodConsume_ = value;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x001BCC80 File Offset: 0x001BAE80
		// (set) Token: 0x0600BAD2 RID: 47826 RVA: 0x001BCC88 File Offset: 0x001BAE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SumGoldAdd
		{
			get
			{
				return this.sumGoldAdd_;
			}
			set
			{
				this.sumGoldAdd_ = value;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x001BCC91 File Offset: 0x001BAE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventInfo> EventInfos
		{
			get
			{
				return this.eventInfos_;
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x0600BAD4 RID: 47828 RVA: 0x001BCC99 File Offset: 0x001BAE99
		// (set) Token: 0x0600BAD5 RID: 47829 RVA: 0x001BCCA1 File Offset: 0x001BAEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamLevel
		{
			get
			{
				return this.teamLevel_;
			}
			set
			{
				this.teamLevel_ = value;
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x0600BAD6 RID: 47830 RVA: 0x001BCCAA File Offset: 0x001BAEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x0600BAD7 RID: 47831 RVA: 0x001BCCB2 File Offset: 0x001BAEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x0600BAD8 RID: 47832 RVA: 0x001BCCBA File Offset: 0x001BAEBA
		// (set) Token: 0x0600BAD9 RID: 47833 RVA: 0x001BCCC2 File Offset: 0x001BAEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopItemCount
		{
			get
			{
				return this.shopItemCount_;
			}
			set
			{
				this.shopItemCount_ = value;
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x0600BADA RID: 47834 RVA: 0x001BCCCB File Offset: 0x001BAECB
		// (set) Token: 0x0600BADB RID: 47835 RVA: 0x001BCCD3 File Offset: 0x001BAED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShopItemMax
		{
			get
			{
				return this.shopItemMax_;
			}
			set
			{
				this.shopItemMax_ = value;
			}
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x0600BADC RID: 47836 RVA: 0x001BCCDC File Offset: 0x001BAEDC
		// (set) Token: 0x0600BADD RID: 47837 RVA: 0x001BCCE4 File Offset: 0x001BAEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillPoint
		{
			get
			{
				return this.skillPoint_;
			}
			set
			{
				this.skillPoint_ = value;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x001BCCED File Offset: 0x001BAEED
		// (set) Token: 0x0600BADF RID: 47839 RVA: 0x001BCCF5 File Offset: 0x001BAEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SkillPointMax
		{
			get
			{
				return this.skillPointMax_;
			}
			set
			{
				this.skillPointMax_ = value;
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x001BCCFE File Offset: 0x001BAEFE
		// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x001BCD06 File Offset: 0x001BAF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewIllustrationCount
		{
			get
			{
				return this.newIllustrationCount_;
			}
			set
			{
				this.newIllustrationCount_ = value;
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x001BCD0F File Offset: 0x001BAF0F
		// (set) Token: 0x0600BAE3 RID: 47843 RVA: 0x001BCD17 File Offset: 0x001BAF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IllustrationMax
		{
			get
			{
				return this.illustrationMax_;
			}
			set
			{
				this.illustrationMax_ = value;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x001BCD20 File Offset: 0x001BAF20
		// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x001BCD28 File Offset: 0x001BAF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndingId
		{
			get
			{
				return this.endingId_;
			}
			set
			{
				this.endingId_ = value;
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x001BCD31 File Offset: 0x001BAF31
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x001BCD39 File Offset: 0x001BAF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x001BCD42 File Offset: 0x001BAF42
		// (set) Token: 0x0600BAE9 RID: 47849 RVA: 0x001BCD4A File Offset: 0x001BAF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x001BCD53 File Offset: 0x001BAF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstResultView);
		}

		// Token: 0x0600BAEB RID: 47851 RVA: 0x001BCD64 File Offset: 0x001BAF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstResultView other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsSucc == other.IsSucc && this.Score == other.Score && this.EventCount == other.EventCount && this.SumMoodConsume == other.SumMoodConsume && this.SumGoldAdd == other.SumGoldAdd && this.eventInfos_.Equals(other.eventInfos_) && this.TeamLevel == other.TeamLevel && this.roles_.Equals(other.roles_) && this.roleBondInfos_.Equals(other.roleBondInfos_) && this.ShopItemCount == other.ShopItemCount && this.ShopItemMax == other.ShopItemMax && this.SkillPoint == other.SkillPoint && this.SkillPointMax == other.SkillPointMax && this.NewIllustrationCount == other.NewIllustrationCount && this.IllustrationMax == other.IllustrationMax && this.EndingId == other.EndingId && this.UseTime == other.UseTime && this.IsNewRecord == other.IsNewRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x001BCECC File Offset: 0x001BB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsSucc)
			{
				num ^= this.IsSucc.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.EventCount != 0)
			{
				num ^= this.EventCount.GetHashCode();
			}
			if (this.SumMoodConsume != 0)
			{
				num ^= this.SumMoodConsume.GetHashCode();
			}
			if (this.SumGoldAdd != 0)
			{
				num ^= this.SumGoldAdd.GetHashCode();
			}
			num ^= this.eventInfos_.GetHashCode();
			if (this.TeamLevel != 0)
			{
				num ^= this.TeamLevel.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			num ^= this.roleBondInfos_.GetHashCode();
			if (this.ShopItemCount != 0)
			{
				num ^= this.ShopItemCount.GetHashCode();
			}
			if (this.ShopItemMax)
			{
				num ^= this.ShopItemMax.GetHashCode();
			}
			if (this.SkillPoint != 0)
			{
				num ^= this.SkillPoint.GetHashCode();
			}
			if (this.SkillPointMax)
			{
				num ^= this.SkillPointMax.GetHashCode();
			}
			if (this.NewIllustrationCount != 0)
			{
				num ^= this.NewIllustrationCount.GetHashCode();
			}
			if (this.IllustrationMax)
			{
				num ^= this.IllustrationMax.GetHashCode();
			}
			if (this.EndingId != 0)
			{
				num ^= this.EndingId.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAED RID: 47853 RVA: 0x001BD0AC File Offset: 0x001BB2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BAEE RID: 47854 RVA: 0x001BD0B9 File Offset: 0x001BB2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x001BD0C4 File Offset: 0x001BB2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.IsSucc)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSucc);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this.EventCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EventCount);
			}
			if (this.SumMoodConsume != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SumMoodConsume);
			}
			if (this.SumGoldAdd != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SumGoldAdd);
			}
			this.eventInfos_.WriteTo(ref output, InstResultView._repeated_eventInfos_codec);
			if (this.TeamLevel != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TeamLevel);
			}
			this.roles_.WriteTo(ref output, InstResultView._repeated_roles_codec);
			this.roleBondInfos_.WriteTo(ref output, InstResultView._repeated_roleBondInfos_codec);
			if (this.ShopItemCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ShopItemCount);
			}
			if (this.ShopItemMax)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ShopItemMax);
			}
			if (this.SkillPoint != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillPoint);
			}
			if (this.SkillPointMax)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.SkillPointMax);
			}
			if (this.NewIllustrationCount != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.NewIllustrationCount);
			}
			if (this.IllustrationMax)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.IllustrationMax);
			}
			if (this.EndingId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.EndingId);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.UseTime);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(160, 1);
				output.WriteBool(this.IsNewRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x001BD2EC File Offset: 0x001BB4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsSucc)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.EventCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventCount);
			}
			if (this.SumMoodConsume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SumMoodConsume);
			}
			if (this.SumGoldAdd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SumGoldAdd);
			}
			num += this.eventInfos_.CalculateSize(InstResultView._repeated_eventInfos_codec);
			if (this.TeamLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeamLevel);
			}
			num += this.roles_.CalculateSize(InstResultView._repeated_roles_codec);
			num += this.roleBondInfos_.CalculateSize(InstResultView._repeated_roleBondInfos_codec);
			if (this.ShopItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopItemCount);
			}
			if (this.ShopItemMax)
			{
				num += 2;
			}
			if (this.SkillPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillPoint);
			}
			if (this.SkillPointMax)
			{
				num += 2;
			}
			if (this.NewIllustrationCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NewIllustrationCount);
			}
			if (this.IllustrationMax)
			{
				num += 3;
			}
			if (this.EndingId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.EndingId);
			}
			if (this.UseTime != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this.IsNewRecord)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x001BD490 File Offset: 0x001BB690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstResultView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsSucc)
			{
				this.IsSucc = other.IsSucc;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.EventCount != 0)
			{
				this.EventCount = other.EventCount;
			}
			if (other.SumMoodConsume != 0)
			{
				this.SumMoodConsume = other.SumMoodConsume;
			}
			if (other.SumGoldAdd != 0)
			{
				this.SumGoldAdd = other.SumGoldAdd;
			}
			this.eventInfos_.Add(other.eventInfos_);
			if (other.TeamLevel != 0)
			{
				this.TeamLevel = other.TeamLevel;
			}
			this.roles_.Add(other.roles_);
			this.roleBondInfos_.Add(other.roleBondInfos_);
			if (other.ShopItemCount != 0)
			{
				this.ShopItemCount = other.ShopItemCount;
			}
			if (other.ShopItemMax)
			{
				this.ShopItemMax = other.ShopItemMax;
			}
			if (other.SkillPoint != 0)
			{
				this.SkillPoint = other.SkillPoint;
			}
			if (other.SkillPointMax)
			{
				this.SkillPointMax = other.SkillPointMax;
			}
			if (other.NewIllustrationCount != 0)
			{
				this.NewIllustrationCount = other.NewIllustrationCount;
			}
			if (other.IllustrationMax)
			{
				this.IllustrationMax = other.IllustrationMax;
			}
			if (other.EndingId != 0)
			{
				this.EndingId = other.EndingId;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x001BD62B File Offset: 0x001BB82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x001BD634 File Offset: 0x001BB834
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
				if (num <= 82U)
				{
					if (num <= 40U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.InstId = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.IsSucc = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 32U)
							{
								this.Score = input.ReadInt32();
								continue;
							}
							if (num == 40U)
							{
								this.EventCount = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 56U)
					{
						if (num == 48U)
						{
							this.SumMoodConsume = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.SumGoldAdd = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 66U)
						{
							this.eventInfos_.AddEntriesFrom(ref input, InstResultView._repeated_eventInfos_codec);
							continue;
						}
						if (num == 72U)
						{
							this.TeamLevel = input.ReadInt32();
							continue;
						}
						if (num == 82U)
						{
							this.roles_.AddEntriesFrom(ref input, InstResultView._repeated_roles_codec);
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num <= 96U)
					{
						if (num == 90U)
						{
							this.roleBondInfos_.AddEntriesFrom(ref input, InstResultView._repeated_roleBondInfos_codec);
							continue;
						}
						if (num == 96U)
						{
							this.ShopItemCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 104U)
						{
							this.ShopItemMax = input.ReadBool();
							continue;
						}
						if (num == 112U)
						{
							this.SkillPoint = input.ReadInt32();
							continue;
						}
						if (num == 120U)
						{
							this.SkillPointMax = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 136U)
				{
					if (num == 128U)
					{
						this.NewIllustrationCount = input.ReadInt32();
						continue;
					}
					if (num == 136U)
					{
						this.IllustrationMax = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 144U)
					{
						this.EndingId = input.ReadInt32();
						continue;
					}
					if (num == 152U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
					if (num == 160U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051FD RID: 20989
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051FE RID: 20990
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051FF RID: 20991
		private int instId_;

		// Token: 0x04005200 RID: 20992
		public const int IsSuccFieldNumber = 2;

		// Token: 0x04005201 RID: 20993
		private bool isSucc_;

		// Token: 0x04005202 RID: 20994
		public const int ScoreFieldNumber = 4;

		// Token: 0x04005203 RID: 20995
		private int score_;

		// Token: 0x04005204 RID: 20996
		public const int EventCountFieldNumber = 5;

		// Token: 0x04005205 RID: 20997
		private int eventCount_;

		// Token: 0x04005206 RID: 20998
		public const int SumMoodConsumeFieldNumber = 6;

		// Token: 0x04005207 RID: 20999
		private int sumMoodConsume_;

		// Token: 0x04005208 RID: 21000
		public const int SumGoldAddFieldNumber = 7;

		// Token: 0x04005209 RID: 21001
		private int sumGoldAdd_;

		// Token: 0x0400520A RID: 21002
		public const int EventInfosFieldNumber = 8;

		// Token: 0x0400520B RID: 21003
		private static readonly FieldCodec<EventInfo> _repeated_eventInfos_codec = FieldCodec.ForMessage<EventInfo>(66U, EventInfo.Parser);

		// Token: 0x0400520C RID: 21004
		private readonly RepeatedField<EventInfo> eventInfos_ = new RepeatedField<EventInfo>();

		// Token: 0x0400520D RID: 21005
		public const int TeamLevelFieldNumber = 9;

		// Token: 0x0400520E RID: 21006
		private int teamLevel_;

		// Token: 0x0400520F RID: 21007
		public const int RolesFieldNumber = 10;

		// Token: 0x04005210 RID: 21008
		private static readonly FieldCodec<RogueResGainData> _repeated_roles_codec = FieldCodec.ForMessage<RogueResGainData>(82U, RogueResGainData.Parser);

		// Token: 0x04005211 RID: 21009
		private readonly RepeatedField<RogueResGainData> roles_ = new RepeatedField<RogueResGainData>();

		// Token: 0x04005212 RID: 21010
		public const int RoleBondInfosFieldNumber = 11;

		// Token: 0x04005213 RID: 21011
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(90U, RoleBondInfo.Parser);

		// Token: 0x04005214 RID: 21012
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();

		// Token: 0x04005215 RID: 21013
		public const int ShopItemCountFieldNumber = 12;

		// Token: 0x04005216 RID: 21014
		private int shopItemCount_;

		// Token: 0x04005217 RID: 21015
		public const int ShopItemMaxFieldNumber = 13;

		// Token: 0x04005218 RID: 21016
		private bool shopItemMax_;

		// Token: 0x04005219 RID: 21017
		public const int SkillPointFieldNumber = 14;

		// Token: 0x0400521A RID: 21018
		private int skillPoint_;

		// Token: 0x0400521B RID: 21019
		public const int SkillPointMaxFieldNumber = 15;

		// Token: 0x0400521C RID: 21020
		private bool skillPointMax_;

		// Token: 0x0400521D RID: 21021
		public const int NewIllustrationCountFieldNumber = 16;

		// Token: 0x0400521E RID: 21022
		private int newIllustrationCount_;

		// Token: 0x0400521F RID: 21023
		public const int IllustrationMaxFieldNumber = 17;

		// Token: 0x04005220 RID: 21024
		private bool illustrationMax_;

		// Token: 0x04005221 RID: 21025
		public const int EndingIdFieldNumber = 18;

		// Token: 0x04005222 RID: 21026
		private int endingId_;

		// Token: 0x04005223 RID: 21027
		public const int UseTimeFieldNumber = 19;

		// Token: 0x04005224 RID: 21028
		private int useTime_;

		// Token: 0x04005225 RID: 21029
		public const int IsNewRecordFieldNumber = 20;

		// Token: 0x04005226 RID: 21030
		private bool isNewRecord_;
	}
}
