using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDB RID: 4059
	[NetMessage(EMessageId.RogueResInstGlobalDataNotify)]
	public sealed class RogueResInstGlobalDataNotify : IMessage<RogueResInstGlobalDataNotify>, IMessage, IEquatable<RogueResInstGlobalDataNotify>, IDeepCloneable<RogueResInstGlobalDataNotify>, IBufferMessage
	{
		// Token: 0x06015B98 RID: 88984 RVA: 0x003282B3 File Offset: 0x003264B3
		[NullableContext(1)]
		public static RogueResInstGlobalDataNotify Create()
		{
			return new RogueResInstGlobalDataNotify();
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06015B99 RID: 88985 RVA: 0x003282BA File Offset: 0x003264BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06015B9A RID: 88986 RVA: 0x003282BD File Offset: 0x003264BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstGlobalDataNotify.Descriptor;
			}
		}

		// Token: 0x06015B9B RID: 88987 RVA: 0x003282C4 File Offset: 0x003264C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify()
		{
		}

		// Token: 0x06015B9C RID: 88988 RVA: 0x003282E4 File Offset: 0x003264E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify(RogueResInstGlobalDataNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.randomSeedId_ = other.randomSeedId_;
			this.rogueResGridDatas_ = other.rogueResGridDatas_.Clone();
			this.index_ = other.index_;
			this.inBattle_ = other.inBattle_;
			this.fov_ = other.fov_;
			this.mood_ = other.mood_;
			this.moodRuleId_ = other.moodRuleId_;
			this.roleMaxStar_ = other.roleMaxStar_;
			this.roleLevel_ = other.roleLevel_;
			this.goldItem_ = other.goldItem_;
			this.columns_ = other.columns_;
			this.rows_ = other.rows_;
			this.showType_ = other.showType_;
			this.maxMood_ = other.maxMood_;
			this.minMood_ = other.minMood_;
			this.teamLevel_ = other.teamLevel_;
			this.rogueResFormations_ = other.rogueResFormations_.Clone();
			this.rogueResOpDataNotify_ = ((other.rogueResOpDataNotify_ != null) ? other.rogueResOpDataNotify_.Clone() : null);
			this.rogueResInstOptionsNotify_ = ((other.rogueResInstOptionsNotify_ != null) ? other.rogueResInstOptionsNotify_.Clone() : null);
			this.rogueResGainDataTotalNotify_ = ((other.rogueResGainDataTotalNotify_ != null) ? other.rogueResGainDataTotalNotify_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B9D RID: 88989 RVA: 0x0032843E File Offset: 0x0032663E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify Clone()
		{
			return new RogueResInstGlobalDataNotify(this);
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06015B9E RID: 88990 RVA: 0x00328446 File Offset: 0x00326646
		// (set) Token: 0x06015B9F RID: 88991 RVA: 0x0032844E File Offset: 0x0032664E
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

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06015BA0 RID: 88992 RVA: 0x00328457 File Offset: 0x00326657
		// (set) Token: 0x06015BA1 RID: 88993 RVA: 0x0032845F File Offset: 0x0032665F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomSeedId
		{
			get
			{
				return this.randomSeedId_;
			}
			set
			{
				this.randomSeedId_ = value;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06015BA2 RID: 88994 RVA: 0x00328468 File Offset: 0x00326668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGridData> RogueResGridDatas
		{
			get
			{
				return this.rogueResGridDatas_;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06015BA3 RID: 88995 RVA: 0x00328470 File Offset: 0x00326670
		// (set) Token: 0x06015BA4 RID: 88996 RVA: 0x00328478 File Offset: 0x00326678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06015BA5 RID: 88997 RVA: 0x00328481 File Offset: 0x00326681
		// (set) Token: 0x06015BA6 RID: 88998 RVA: 0x00328489 File Offset: 0x00326689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InBattle
		{
			get
			{
				return this.inBattle_;
			}
			set
			{
				this.inBattle_ = value;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06015BA7 RID: 88999 RVA: 0x00328492 File Offset: 0x00326692
		// (set) Token: 0x06015BA8 RID: 89000 RVA: 0x0032849A File Offset: 0x0032669A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Fov
		{
			get
			{
				return this.fov_;
			}
			set
			{
				this.fov_ = value;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06015BA9 RID: 89001 RVA: 0x003284A3 File Offset: 0x003266A3
		// (set) Token: 0x06015BAA RID: 89002 RVA: 0x003284AB File Offset: 0x003266AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Mood
		{
			get
			{
				return this.mood_;
			}
			set
			{
				this.mood_ = value;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06015BAB RID: 89003 RVA: 0x003284B4 File Offset: 0x003266B4
		// (set) Token: 0x06015BAC RID: 89004 RVA: 0x003284BC File Offset: 0x003266BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoodRuleId
		{
			get
			{
				return this.moodRuleId_;
			}
			set
			{
				this.moodRuleId_ = value;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06015BAD RID: 89005 RVA: 0x003284C5 File Offset: 0x003266C5
		// (set) Token: 0x06015BAE RID: 89006 RVA: 0x003284CD File Offset: 0x003266CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleMaxStar
		{
			get
			{
				return this.roleMaxStar_;
			}
			set
			{
				this.roleMaxStar_ = value;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06015BAF RID: 89007 RVA: 0x003284D6 File Offset: 0x003266D6
		// (set) Token: 0x06015BB0 RID: 89008 RVA: 0x003284DE File Offset: 0x003266DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06015BB1 RID: 89009 RVA: 0x003284E7 File Offset: 0x003266E7
		// (set) Token: 0x06015BB2 RID: 89010 RVA: 0x003284EF File Offset: 0x003266EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldItem
		{
			get
			{
				return this.goldItem_;
			}
			set
			{
				this.goldItem_ = value;
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06015BB3 RID: 89011 RVA: 0x003284F8 File Offset: 0x003266F8
		// (set) Token: 0x06015BB4 RID: 89012 RVA: 0x00328500 File Offset: 0x00326700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Columns
		{
			get
			{
				return this.columns_;
			}
			set
			{
				this.columns_ = value;
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06015BB5 RID: 89013 RVA: 0x00328509 File Offset: 0x00326709
		// (set) Token: 0x06015BB6 RID: 89014 RVA: 0x00328511 File Offset: 0x00326711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rows
		{
			get
			{
				return this.rows_;
			}
			set
			{
				this.rows_ = value;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06015BB7 RID: 89015 RVA: 0x0032851A File Offset: 0x0032671A
		// (set) Token: 0x06015BB8 RID: 89016 RVA: 0x00328522 File Offset: 0x00326722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowType
		{
			get
			{
				return this.showType_;
			}
			set
			{
				this.showType_ = value;
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06015BB9 RID: 89017 RVA: 0x0032852B File Offset: 0x0032672B
		// (set) Token: 0x06015BBA RID: 89018 RVA: 0x00328533 File Offset: 0x00326733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxMood
		{
			get
			{
				return this.maxMood_;
			}
			set
			{
				this.maxMood_ = value;
			}
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06015BBB RID: 89019 RVA: 0x0032853C File Offset: 0x0032673C
		// (set) Token: 0x06015BBC RID: 89020 RVA: 0x00328544 File Offset: 0x00326744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinMood
		{
			get
			{
				return this.minMood_;
			}
			set
			{
				this.minMood_ = value;
			}
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06015BBD RID: 89021 RVA: 0x0032854D File Offset: 0x0032674D
		// (set) Token: 0x06015BBE RID: 89022 RVA: 0x00328555 File Offset: 0x00326755
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

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06015BBF RID: 89023 RVA: 0x0032855E File Offset: 0x0032675E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResFormation> RogueResFormations
		{
			get
			{
				return this.rogueResFormations_;
			}
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06015BC0 RID: 89024 RVA: 0x00328566 File Offset: 0x00326766
		// (set) Token: 0x06015BC1 RID: 89025 RVA: 0x0032856E File Offset: 0x0032676E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify RogueResOpDataNotify
		{
			get
			{
				return this.rogueResOpDataNotify_;
			}
			set
			{
				this.rogueResOpDataNotify_ = value;
			}
		}

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06015BC2 RID: 89026 RVA: 0x00328577 File Offset: 0x00326777
		// (set) Token: 0x06015BC3 RID: 89027 RVA: 0x0032857F File Offset: 0x0032677F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify RogueResInstOptionsNotify
		{
			get
			{
				return this.rogueResInstOptionsNotify_;
			}
			set
			{
				this.rogueResInstOptionsNotify_ = value;
			}
		}

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06015BC4 RID: 89028 RVA: 0x00328588 File Offset: 0x00326788
		// (set) Token: 0x06015BC5 RID: 89029 RVA: 0x00328590 File Offset: 0x00326790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify RogueResGainDataTotalNotify
		{
			get
			{
				return this.rogueResGainDataTotalNotify_;
			}
			set
			{
				this.rogueResGainDataTotalNotify_ = value;
			}
		}

		// Token: 0x06015BC6 RID: 89030 RVA: 0x00328599 File Offset: 0x00326799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstGlobalDataNotify);
		}

		// Token: 0x06015BC7 RID: 89031 RVA: 0x003285A8 File Offset: 0x003267A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstGlobalDataNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.RandomSeedId == other.RandomSeedId && this.rogueResGridDatas_.Equals(other.rogueResGridDatas_) && this.Index == other.Index && this.InBattle == other.InBattle && this.Fov == other.Fov && this.Mood == other.Mood && this.MoodRuleId == other.MoodRuleId && this.RoleMaxStar == other.RoleMaxStar && this.RoleLevel == other.RoleLevel && this.GoldItem == other.GoldItem && this.Columns == other.Columns && this.Rows == other.Rows && this.ShowType == other.ShowType && this.MaxMood == other.MaxMood && this.MinMood == other.MinMood && this.TeamLevel == other.TeamLevel && this.rogueResFormations_.Equals(other.rogueResFormations_) && object.Equals(this.RogueResOpDataNotify, other.RogueResOpDataNotify) && object.Equals(this.RogueResInstOptionsNotify, other.RogueResInstOptionsNotify) && object.Equals(this.RogueResGainDataTotalNotify, other.RogueResGainDataTotalNotify) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BC8 RID: 89032 RVA: 0x0032873C File Offset: 0x0032693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.RandomSeedId != 0)
			{
				num ^= this.RandomSeedId.GetHashCode();
			}
			num ^= this.rogueResGridDatas_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.InBattle)
			{
				num ^= this.InBattle.GetHashCode();
			}
			if (this.Fov != 0)
			{
				num ^= this.Fov.GetHashCode();
			}
			if (this.Mood != 0)
			{
				num ^= this.Mood.GetHashCode();
			}
			if (this.MoodRuleId != 0)
			{
				num ^= this.MoodRuleId.GetHashCode();
			}
			if (this.RoleMaxStar != 0)
			{
				num ^= this.RoleMaxStar.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.GoldItem != 0)
			{
				num ^= this.GoldItem.GetHashCode();
			}
			if (this.Columns != 0)
			{
				num ^= this.Columns.GetHashCode();
			}
			if (this.Rows != 0)
			{
				num ^= this.Rows.GetHashCode();
			}
			if (this.ShowType != 0)
			{
				num ^= this.ShowType.GetHashCode();
			}
			if (this.MaxMood != 0)
			{
				num ^= this.MaxMood.GetHashCode();
			}
			if (this.MinMood != 0)
			{
				num ^= this.MinMood.GetHashCode();
			}
			if (this.TeamLevel != 0)
			{
				num ^= this.TeamLevel.GetHashCode();
			}
			num ^= this.rogueResFormations_.GetHashCode();
			if (this.rogueResOpDataNotify_ != null)
			{
				num ^= this.RogueResOpDataNotify.GetHashCode();
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				num ^= this.RogueResInstOptionsNotify.GetHashCode();
			}
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				num ^= this.RogueResGainDataTotalNotify.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015BC9 RID: 89033 RVA: 0x00328950 File Offset: 0x00326B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BCA RID: 89034 RVA: 0x0032895D File Offset: 0x00326B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BCB RID: 89035 RVA: 0x00328968 File Offset: 0x00326B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Fov != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Fov);
			}
			if (this.MinMood != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MinMood);
			}
			if (this.Rows != 0)
			{
				output.WriteRawTag(152, 3);
				output.WriteInt32(this.Rows);
			}
			this.rogueResGridDatas_.WriteTo(ref output, RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
			if (this.InBattle)
			{
				output.WriteRawTag(192, 3);
				output.WriteBool(this.InBattle);
			}
			if (this.GoldItem != 0)
			{
				output.WriteRawTag(216, 3);
				output.WriteInt32(this.GoldItem);
			}
			if (this.MaxMood != 0)
			{
				output.WriteRawTag(208, 5);
				output.WriteInt32(this.MaxMood);
			}
			if (this.ShowType != 0)
			{
				output.WriteRawTag(232, 5);
				output.WriteInt32(this.ShowType);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(248, 5);
				output.WriteInt32(this.Index);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(128, 6);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.Columns != 0)
			{
				output.WriteRawTag(224, 6);
				output.WriteInt32(this.Columns);
			}
			if (this.RandomSeedId != 0)
			{
				output.WriteRawTag(216, 7);
				output.WriteInt32(this.RandomSeedId);
			}
			if (this.Mood != 0)
			{
				output.WriteRawTag(240, 7);
				output.WriteInt32(this.Mood);
			}
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				output.WriteRawTag(138, 8);
				output.WriteMessage(this.RogueResGainDataTotalNotify);
			}
			if (this.MoodRuleId != 0)
			{
				output.WriteRawTag(168, 9);
				output.WriteInt32(this.MoodRuleId);
			}
			if (this.RoleMaxStar != 0)
			{
				output.WriteRawTag(192, 10);
				output.WriteInt32(this.RoleMaxStar);
			}
			if (this.TeamLevel != 0)
			{
				output.WriteRawTag(200, 11);
				output.WriteInt32(this.TeamLevel);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(168, 12);
				output.WriteInt32(this.InstId);
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				output.WriteRawTag(226, 12);
				output.WriteMessage(this.RogueResInstOptionsNotify);
			}
			if (this.rogueResOpDataNotify_ != null)
			{
				output.WriteRawTag(138, 13);
				output.WriteMessage(this.RogueResOpDataNotify);
			}
			this.rogueResFormations_.WriteTo(ref output, RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015BCC RID: 89036 RVA: 0x00328C0C File Offset: 0x00326E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.RandomSeedId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RandomSeedId);
			}
			num += this.rogueResGridDatas_.CalculateSize(RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
			if (this.Index != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.InBattle)
			{
				num += 3;
			}
			if (this.Fov != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Fov);
			}
			if (this.Mood != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Mood);
			}
			if (this.MoodRuleId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MoodRuleId);
			}
			if (this.RoleMaxStar != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleMaxStar);
			}
			if (this.RoleLevel != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.GoldItem != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GoldItem);
			}
			if (this.Columns != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Columns);
			}
			if (this.Rows != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Rows);
			}
			if (this.ShowType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShowType);
			}
			if (this.MaxMood != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxMood);
			}
			if (this.MinMood != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinMood);
			}
			if (this.TeamLevel != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TeamLevel);
			}
			num += this.rogueResFormations_.CalculateSize(RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
			if (this.rogueResOpDataNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResOpDataNotify);
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResInstOptionsNotify);
			}
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResGainDataTotalNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015BCD RID: 89037 RVA: 0x00328E14 File Offset: 0x00327014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstGlobalDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.RandomSeedId != 0)
			{
				this.RandomSeedId = other.RandomSeedId;
			}
			this.rogueResGridDatas_.Add(other.rogueResGridDatas_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.InBattle)
			{
				this.InBattle = other.InBattle;
			}
			if (other.Fov != 0)
			{
				this.Fov = other.Fov;
			}
			if (other.Mood != 0)
			{
				this.Mood = other.Mood;
			}
			if (other.MoodRuleId != 0)
			{
				this.MoodRuleId = other.MoodRuleId;
			}
			if (other.RoleMaxStar != 0)
			{
				this.RoleMaxStar = other.RoleMaxStar;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.GoldItem != 0)
			{
				this.GoldItem = other.GoldItem;
			}
			if (other.Columns != 0)
			{
				this.Columns = other.Columns;
			}
			if (other.Rows != 0)
			{
				this.Rows = other.Rows;
			}
			if (other.ShowType != 0)
			{
				this.ShowType = other.ShowType;
			}
			if (other.MaxMood != 0)
			{
				this.MaxMood = other.MaxMood;
			}
			if (other.MinMood != 0)
			{
				this.MinMood = other.MinMood;
			}
			if (other.TeamLevel != 0)
			{
				this.TeamLevel = other.TeamLevel;
			}
			this.rogueResFormations_.Add(other.rogueResFormations_);
			if (other.rogueResOpDataNotify_ != null)
			{
				if (this.rogueResOpDataNotify_ == null)
				{
					this.RogueResOpDataNotify = new RogueResOpDataNotify();
				}
				this.RogueResOpDataNotify.MergeFrom(other.RogueResOpDataNotify);
			}
			if (other.rogueResInstOptionsNotify_ != null)
			{
				if (this.rogueResInstOptionsNotify_ == null)
				{
					this.RogueResInstOptionsNotify = new RogueResInstOptionsNotify();
				}
				this.RogueResInstOptionsNotify.MergeFrom(other.RogueResInstOptionsNotify);
			}
			if (other.rogueResGainDataTotalNotify_ != null)
			{
				if (this.rogueResGainDataTotalNotify_ == null)
				{
					this.RogueResGainDataTotalNotify = new RogueResGainDataTotalNotify();
				}
				this.RogueResGainDataTotalNotify.MergeFrom(other.RogueResGainDataTotalNotify);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015BCE RID: 89038 RVA: 0x00329022 File Offset: 0x00327222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BCF RID: 89039 RVA: 0x0032902C File Offset: 0x0032722C
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
				if (num <= 768U)
				{
					if (num <= 448U)
					{
						if (num <= 80U)
						{
							if (num == 16U)
							{
								this.Fov = input.ReadInt32();
								continue;
							}
							if (num == 80U)
							{
								this.MinMood = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 408U)
							{
								this.Rows = input.ReadInt32();
								continue;
							}
							if (num == 426U)
							{
								this.rogueResGridDatas_.AddEntriesFrom(ref input, RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
								continue;
							}
							if (num == 448U)
							{
								this.InBattle = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 720U)
					{
						if (num == 472U)
						{
							this.GoldItem = input.ReadInt32();
							continue;
						}
						if (num == 720U)
						{
							this.MaxMood = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 744U)
						{
							this.ShowType = input.ReadInt32();
							continue;
						}
						if (num == 760U)
						{
							this.Index = input.ReadInt32();
							continue;
						}
						if (num == 768U)
						{
							this.RoleLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1192U)
				{
					if (num <= 984U)
					{
						if (num == 864U)
						{
							this.Columns = input.ReadInt32();
							continue;
						}
						if (num == 984U)
						{
							this.RandomSeedId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1008U)
						{
							this.Mood = input.ReadInt32();
							continue;
						}
						if (num == 1034U)
						{
							if (this.rogueResGainDataTotalNotify_ == null)
							{
								this.RogueResGainDataTotalNotify = new RogueResGainDataTotalNotify();
							}
							input.ReadMessage(this.RogueResGainDataTotalNotify);
							continue;
						}
						if (num == 1192U)
						{
							this.MoodRuleId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1576U)
				{
					if (num == 1344U)
					{
						this.RoleMaxStar = input.ReadInt32();
						continue;
					}
					if (num == 1480U)
					{
						this.TeamLevel = input.ReadInt32();
						continue;
					}
					if (num == 1576U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1634U)
					{
						if (this.rogueResInstOptionsNotify_ == null)
						{
							this.RogueResInstOptionsNotify = new RogueResInstOptionsNotify();
						}
						input.ReadMessage(this.RogueResInstOptionsNotify);
						continue;
					}
					if (num == 1674U)
					{
						if (this.rogueResOpDataNotify_ == null)
						{
							this.RogueResOpDataNotify = new RogueResOpDataNotify();
						}
						input.ReadMessage(this.RogueResOpDataNotify);
						continue;
					}
					if (num == 1890U)
					{
						this.rogueResFormations_.AddEntriesFrom(ref input, RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040082D8 RID: 33496
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082D9 RID: 33497
		public const int InstIdFieldNumber = 197;

		// Token: 0x040082DA RID: 33498
		private int instId_;

		// Token: 0x040082DB RID: 33499
		public const int RandomSeedIdFieldNumber = 123;

		// Token: 0x040082DC RID: 33500
		private int randomSeedId_;

		// Token: 0x040082DD RID: 33501
		public const int RogueResGridDatasFieldNumber = 53;

		// Token: 0x040082DE RID: 33502
		private static readonly FieldCodec<RogueResGridData> _repeated_rogueResGridDatas_codec = FieldCodec.ForMessage<RogueResGridData>(426U, RogueResGridData.Parser);

		// Token: 0x040082DF RID: 33503
		private readonly RepeatedField<RogueResGridData> rogueResGridDatas_ = new RepeatedField<RogueResGridData>();

		// Token: 0x040082E0 RID: 33504
		public const int IndexFieldNumber = 95;

		// Token: 0x040082E1 RID: 33505
		private int index_;

		// Token: 0x040082E2 RID: 33506
		public const int InBattleFieldNumber = 56;

		// Token: 0x040082E3 RID: 33507
		private bool inBattle_;

		// Token: 0x040082E4 RID: 33508
		public const int FovFieldNumber = 2;

		// Token: 0x040082E5 RID: 33509
		private int fov_;

		// Token: 0x040082E6 RID: 33510
		public const int MoodFieldNumber = 126;

		// Token: 0x040082E7 RID: 33511
		private int mood_;

		// Token: 0x040082E8 RID: 33512
		public const int MoodRuleIdFieldNumber = 149;

		// Token: 0x040082E9 RID: 33513
		private int moodRuleId_;

		// Token: 0x040082EA RID: 33514
		public const int RoleMaxStarFieldNumber = 168;

		// Token: 0x040082EB RID: 33515
		private int roleMaxStar_;

		// Token: 0x040082EC RID: 33516
		public const int RoleLevelFieldNumber = 96;

		// Token: 0x040082ED RID: 33517
		private int roleLevel_;

		// Token: 0x040082EE RID: 33518
		public const int GoldItemFieldNumber = 59;

		// Token: 0x040082EF RID: 33519
		private int goldItem_;

		// Token: 0x040082F0 RID: 33520
		public const int ColumnsFieldNumber = 108;

		// Token: 0x040082F1 RID: 33521
		private int columns_;

		// Token: 0x040082F2 RID: 33522
		public const int RowsFieldNumber = 51;

		// Token: 0x040082F3 RID: 33523
		private int rows_;

		// Token: 0x040082F4 RID: 33524
		public const int ShowTypeFieldNumber = 93;

		// Token: 0x040082F5 RID: 33525
		private int showType_;

		// Token: 0x040082F6 RID: 33526
		public const int MaxMoodFieldNumber = 90;

		// Token: 0x040082F7 RID: 33527
		private int maxMood_;

		// Token: 0x040082F8 RID: 33528
		public const int MinMoodFieldNumber = 10;

		// Token: 0x040082F9 RID: 33529
		private int minMood_;

		// Token: 0x040082FA RID: 33530
		public const int TeamLevelFieldNumber = 185;

		// Token: 0x040082FB RID: 33531
		private int teamLevel_;

		// Token: 0x040082FC RID: 33532
		public const int RogueResFormationsFieldNumber = 236;

		// Token: 0x040082FD RID: 33533
		private static readonly FieldCodec<RogueResFormation> _repeated_rogueResFormations_codec = FieldCodec.ForMessage<RogueResFormation>(1890U, RogueResFormation.Parser);

		// Token: 0x040082FE RID: 33534
		private readonly RepeatedField<RogueResFormation> rogueResFormations_ = new RepeatedField<RogueResFormation>();

		// Token: 0x040082FF RID: 33535
		public const int RogueResOpDataNotifyFieldNumber = 209;

		// Token: 0x04008300 RID: 33536
		private RogueResOpDataNotify rogueResOpDataNotify_;

		// Token: 0x04008301 RID: 33537
		public const int RogueResInstOptionsNotifyFieldNumber = 204;

		// Token: 0x04008302 RID: 33538
		private RogueResInstOptionsNotify rogueResInstOptionsNotify_;

		// Token: 0x04008303 RID: 33539
		public const int RogueResGainDataTotalNotifyFieldNumber = 129;

		// Token: 0x04008304 RID: 33540
		private RogueResGainDataTotalNotify rogueResGainDataTotalNotify_;
	}
}
