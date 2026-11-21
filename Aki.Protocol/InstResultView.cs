using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000816 RID: 2070
	public sealed class InstResultView : IMessage<InstResultView>, IMessage, IEquatable<InstResultView>, IDeepCloneable<InstResultView>, IBufferMessage
	{
		// Token: 0x0600B96B RID: 47467 RVA: 0x001BA095 File Offset: 0x001B8295
		[NullableContext(1)]
		public static InstResultView Create()
		{
			return new InstResultView();
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600B96C RID: 47468 RVA: 0x001BA09C File Offset: 0x001B829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x001BA09F File Offset: 0x001B829F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstResultView.Descriptor;
			}
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x001BA0A6 File Offset: 0x001B82A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView()
		{
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x001BA0D0 File Offset: 0x001B82D0
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

		// Token: 0x0600B970 RID: 47472 RVA: 0x001BA1E7 File Offset: 0x001B83E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView Clone()
		{
			return new InstResultView(this);
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x0600B971 RID: 47473 RVA: 0x001BA1EF File Offset: 0x001B83EF
		// (set) Token: 0x0600B972 RID: 47474 RVA: 0x001BA1F7 File Offset: 0x001B83F7
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

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x0600B973 RID: 47475 RVA: 0x001BA200 File Offset: 0x001B8400
		// (set) Token: 0x0600B974 RID: 47476 RVA: 0x001BA208 File Offset: 0x001B8408
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

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x001BA211 File Offset: 0x001B8411
		// (set) Token: 0x0600B976 RID: 47478 RVA: 0x001BA219 File Offset: 0x001B8419
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

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x0600B977 RID: 47479 RVA: 0x001BA222 File Offset: 0x001B8422
		// (set) Token: 0x0600B978 RID: 47480 RVA: 0x001BA22A File Offset: 0x001B842A
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

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x0600B979 RID: 47481 RVA: 0x001BA233 File Offset: 0x001B8433
		// (set) Token: 0x0600B97A RID: 47482 RVA: 0x001BA23B File Offset: 0x001B843B
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

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x001BA244 File Offset: 0x001B8444
		// (set) Token: 0x0600B97C RID: 47484 RVA: 0x001BA24C File Offset: 0x001B844C
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

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x001BA255 File Offset: 0x001B8455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EventInfo> EventInfos
		{
			get
			{
				return this.eventInfos_;
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600B97E RID: 47486 RVA: 0x001BA25D File Offset: 0x001B845D
		// (set) Token: 0x0600B97F RID: 47487 RVA: 0x001BA265 File Offset: 0x001B8465
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

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x001BA26E File Offset: 0x001B846E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x001BA276 File Offset: 0x001B8476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x001BA27E File Offset: 0x001B847E
		// (set) Token: 0x0600B983 RID: 47491 RVA: 0x001BA286 File Offset: 0x001B8486
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

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600B984 RID: 47492 RVA: 0x001BA28F File Offset: 0x001B848F
		// (set) Token: 0x0600B985 RID: 47493 RVA: 0x001BA297 File Offset: 0x001B8497
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

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x001BA2A0 File Offset: 0x001B84A0
		// (set) Token: 0x0600B987 RID: 47495 RVA: 0x001BA2A8 File Offset: 0x001B84A8
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

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x0600B988 RID: 47496 RVA: 0x001BA2B1 File Offset: 0x001B84B1
		// (set) Token: 0x0600B989 RID: 47497 RVA: 0x001BA2B9 File Offset: 0x001B84B9
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

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x0600B98A RID: 47498 RVA: 0x001BA2C2 File Offset: 0x001B84C2
		// (set) Token: 0x0600B98B RID: 47499 RVA: 0x001BA2CA File Offset: 0x001B84CA
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

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x0600B98C RID: 47500 RVA: 0x001BA2D3 File Offset: 0x001B84D3
		// (set) Token: 0x0600B98D RID: 47501 RVA: 0x001BA2DB File Offset: 0x001B84DB
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

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x0600B98E RID: 47502 RVA: 0x001BA2E4 File Offset: 0x001B84E4
		// (set) Token: 0x0600B98F RID: 47503 RVA: 0x001BA2EC File Offset: 0x001B84EC
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

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x0600B990 RID: 47504 RVA: 0x001BA2F5 File Offset: 0x001B84F5
		// (set) Token: 0x0600B991 RID: 47505 RVA: 0x001BA2FD File Offset: 0x001B84FD
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

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600B992 RID: 47506 RVA: 0x001BA306 File Offset: 0x001B8506
		// (set) Token: 0x0600B993 RID: 47507 RVA: 0x001BA30E File Offset: 0x001B850E
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

		// Token: 0x0600B994 RID: 47508 RVA: 0x001BA317 File Offset: 0x001B8517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstResultView);
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x001BA328 File Offset: 0x001B8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstResultView other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsSucc == other.IsSucc && this.Score == other.Score && this.EventCount == other.EventCount && this.SumMoodConsume == other.SumMoodConsume && this.SumGoldAdd == other.SumGoldAdd && this.eventInfos_.Equals(other.eventInfos_) && this.TeamLevel == other.TeamLevel && this.roles_.Equals(other.roles_) && this.roleBondInfos_.Equals(other.roleBondInfos_) && this.ShopItemCount == other.ShopItemCount && this.ShopItemMax == other.ShopItemMax && this.SkillPoint == other.SkillPoint && this.SkillPointMax == other.SkillPointMax && this.NewIllustrationCount == other.NewIllustrationCount && this.IllustrationMax == other.IllustrationMax && this.EndingId == other.EndingId && this.UseTime == other.UseTime && this.IsNewRecord == other.IsNewRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x001BA490 File Offset: 0x001B8690
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

		// Token: 0x0600B997 RID: 47511 RVA: 0x001BA670 File Offset: 0x001B8870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x001BA67D File Offset: 0x001B887D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x001BA688 File Offset: 0x001B8888
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

		// Token: 0x0600B99A RID: 47514 RVA: 0x001BA8B0 File Offset: 0x001B8AB0
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

		// Token: 0x0600B99B RID: 47515 RVA: 0x001BAA54 File Offset: 0x001B8C54
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

		// Token: 0x0600B99C RID: 47516 RVA: 0x001BABEF File Offset: 0x001B8DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x001BABF8 File Offset: 0x001B8DF8
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

		// Token: 0x040051F6 RID: 20982
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051F7 RID: 20983
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051F8 RID: 20984
		private int instId_;

		// Token: 0x040051F9 RID: 20985
		public const int IsSuccFieldNumber = 2;

		// Token: 0x040051FA RID: 20986
		private bool isSucc_;

		// Token: 0x040051FB RID: 20987
		public const int ScoreFieldNumber = 4;

		// Token: 0x040051FC RID: 20988
		private int score_;

		// Token: 0x040051FD RID: 20989
		public const int EventCountFieldNumber = 5;

		// Token: 0x040051FE RID: 20990
		private int eventCount_;

		// Token: 0x040051FF RID: 20991
		public const int SumMoodConsumeFieldNumber = 6;

		// Token: 0x04005200 RID: 20992
		private int sumMoodConsume_;

		// Token: 0x04005201 RID: 20993
		public const int SumGoldAddFieldNumber = 7;

		// Token: 0x04005202 RID: 20994
		private int sumGoldAdd_;

		// Token: 0x04005203 RID: 20995
		public const int EventInfosFieldNumber = 8;

		// Token: 0x04005204 RID: 20996
		private static readonly FieldCodec<EventInfo> _repeated_eventInfos_codec = FieldCodec.ForMessage<EventInfo>(66U, EventInfo.Parser);

		// Token: 0x04005205 RID: 20997
		private readonly RepeatedField<EventInfo> eventInfos_ = new RepeatedField<EventInfo>();

		// Token: 0x04005206 RID: 20998
		public const int TeamLevelFieldNumber = 9;

		// Token: 0x04005207 RID: 20999
		private int teamLevel_;

		// Token: 0x04005208 RID: 21000
		public const int RolesFieldNumber = 10;

		// Token: 0x04005209 RID: 21001
		private static readonly FieldCodec<RogueResGainData> _repeated_roles_codec = FieldCodec.ForMessage<RogueResGainData>(82U, RogueResGainData.Parser);

		// Token: 0x0400520A RID: 21002
		private readonly RepeatedField<RogueResGainData> roles_ = new RepeatedField<RogueResGainData>();

		// Token: 0x0400520B RID: 21003
		public const int RoleBondInfosFieldNumber = 11;

		// Token: 0x0400520C RID: 21004
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(90U, RoleBondInfo.Parser);

		// Token: 0x0400520D RID: 21005
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();

		// Token: 0x0400520E RID: 21006
		public const int ShopItemCountFieldNumber = 12;

		// Token: 0x0400520F RID: 21007
		private int shopItemCount_;

		// Token: 0x04005210 RID: 21008
		public const int ShopItemMaxFieldNumber = 13;

		// Token: 0x04005211 RID: 21009
		private bool shopItemMax_;

		// Token: 0x04005212 RID: 21010
		public const int SkillPointFieldNumber = 14;

		// Token: 0x04005213 RID: 21011
		private int skillPoint_;

		// Token: 0x04005214 RID: 21012
		public const int SkillPointMaxFieldNumber = 15;

		// Token: 0x04005215 RID: 21013
		private bool skillPointMax_;

		// Token: 0x04005216 RID: 21014
		public const int NewIllustrationCountFieldNumber = 16;

		// Token: 0x04005217 RID: 21015
		private int newIllustrationCount_;

		// Token: 0x04005218 RID: 21016
		public const int IllustrationMaxFieldNumber = 17;

		// Token: 0x04005219 RID: 21017
		private bool illustrationMax_;

		// Token: 0x0400521A RID: 21018
		public const int EndingIdFieldNumber = 18;

		// Token: 0x0400521B RID: 21019
		private int endingId_;

		// Token: 0x0400521C RID: 21020
		public const int UseTimeFieldNumber = 19;

		// Token: 0x0400521D RID: 21021
		private int useTime_;

		// Token: 0x0400521E RID: 21022
		public const int IsNewRecordFieldNumber = 20;

		// Token: 0x0400521F RID: 21023
		private bool isNewRecord_;
	}
}
