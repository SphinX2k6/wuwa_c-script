using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C1 RID: 1473
	public sealed class FloroRanchPlayInfo : IMessage<FloroRanchPlayInfo>, IMessage, IEquatable<FloroRanchPlayInfo>, IDeepCloneable<FloroRanchPlayInfo>, IBufferMessage
	{
		// Token: 0x0600880B RID: 34827 RVA: 0x00147521 File Offset: 0x00145721
		[NullableContext(1)]
		public static FloroRanchPlayInfo Create()
		{
			return new FloroRanchPlayInfo();
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x0600880C RID: 34828 RVA: 0x00147528 File Offset: 0x00145728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x0014752B File Offset: 0x0014572B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayInfo.Descriptor;
			}
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00147532 File Offset: 0x00145732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo()
		{
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x00147568 File Offset: 0x00145768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo(FloroRanchPlayInfo other) : this()
		{
			this.subInsId_ = other.subInsId_;
			this.terrains_ = other.terrains_.Clone();
			this.phantomList_ = other.phantomList_.Clone();
			this.toyList_ = other.toyList_.Clone();
			this.totalCoin_ = other.totalCoin_;
			this.totalDiamond_ = other.totalDiamond_;
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this.skillId_ = other.skillId_;
			this.stage_ = other.stage_;
			this.day_ = other.day_;
			this.stageTributeCount_ = other.stageTributeCount_;
			this.enableToy_ = other.enableToy_;
			this.dungeon_ = ((other.dungeon_ != null) ? other.dungeon_.Clone() : null);
			this.role_ = ((other.role_ != null) ? other.role_.Clone() : null);
			this.isUnLimited_ = other.isUnLimited_;
			this.curStageDayNum_ = other.curStageDayNum_;
			this.totalDay_ = other.totalDay_;
			this.remainDay_ = other.remainDay_;
			this.races_ = other.races_.Clone();
			this.isOver_ = other.isOver_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x001476BC File Offset: 0x001458BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo Clone()
		{
			return new FloroRanchPlayInfo(this);
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x001476C4 File Offset: 0x001458C4
		// (set) Token: 0x06008812 RID: 34834 RVA: 0x001476CC File Offset: 0x001458CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06008813 RID: 34835 RVA: 0x001476D5 File Offset: 0x001458D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> Terrains
		{
			get
			{
				return this.terrains_;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x001476DD File Offset: 0x001458DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> PhantomList
		{
			get
			{
				return this.phantomList_;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06008815 RID: 34837 RVA: 0x001476E5 File Offset: 0x001458E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> ToyList
		{
			get
			{
				return this.toyList_;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x001476ED File Offset: 0x001458ED
		// (set) Token: 0x06008817 RID: 34839 RVA: 0x001476F5 File Offset: 0x001458F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCoin
		{
			get
			{
				return this.totalCoin_;
			}
			set
			{
				this.totalCoin_ = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x001476FE File Offset: 0x001458FE
		// (set) Token: 0x06008819 RID: 34841 RVA: 0x00147706 File Offset: 0x00145906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalDiamond
		{
			get
			{
				return this.totalDiamond_;
			}
			set
			{
				this.totalDiamond_ = value;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600881A RID: 34842 RVA: 0x0014770F File Offset: 0x0014590F
		// (set) Token: 0x0600881B RID: 34843 RVA: 0x00147717 File Offset: 0x00145917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x00147720 File Offset: 0x00145920
		// (set) Token: 0x0600881D RID: 34845 RVA: 0x00147728 File Offset: 0x00145928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurDiamond
		{
			get
			{
				return this.curDiamond_;
			}
			set
			{
				this.curDiamond_ = value;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x00147731 File Offset: 0x00145931
		// (set) Token: 0x0600881F RID: 34847 RVA: 0x00147739 File Offset: 0x00145939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x00147742 File Offset: 0x00145942
		// (set) Token: 0x06008821 RID: 34849 RVA: 0x0014774A File Offset: 0x0014594A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Stage
		{
			get
			{
				return this.stage_;
			}
			set
			{
				this.stage_ = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x00147753 File Offset: 0x00145953
		// (set) Token: 0x06008823 RID: 34851 RVA: 0x0014775B File Offset: 0x0014595B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Day
		{
			get
			{
				return this.day_;
			}
			set
			{
				this.day_ = value;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x00147764 File Offset: 0x00145964
		// (set) Token: 0x06008825 RID: 34853 RVA: 0x0014776C File Offset: 0x0014596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StageTributeCount
		{
			get
			{
				return this.stageTributeCount_;
			}
			set
			{
				this.stageTributeCount_ = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06008826 RID: 34854 RVA: 0x00147775 File Offset: 0x00145975
		// (set) Token: 0x06008827 RID: 34855 RVA: 0x0014777D File Offset: 0x0014597D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnableToy
		{
			get
			{
				return this.enableToy_;
			}
			set
			{
				this.enableToy_ = value;
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06008828 RID: 34856 RVA: 0x00147786 File Offset: 0x00145986
		// (set) Token: 0x06008829 RID: 34857 RVA: 0x0014778E File Offset: 0x0014598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Dungeon
		{
			get
			{
				return this.dungeon_;
			}
			set
			{
				this.dungeon_ = value;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x00147797 File Offset: 0x00145997
		// (set) Token: 0x0600882B RID: 34859 RVA: 0x0014779F File Offset: 0x0014599F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x001477A8 File Offset: 0x001459A8
		// (set) Token: 0x0600882D RID: 34861 RVA: 0x001477B0 File Offset: 0x001459B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnLimited
		{
			get
			{
				return this.isUnLimited_;
			}
			set
			{
				this.isUnLimited_ = value;
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x001477B9 File Offset: 0x001459B9
		// (set) Token: 0x0600882F RID: 34863 RVA: 0x001477C1 File Offset: 0x001459C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStageDayNum
		{
			get
			{
				return this.curStageDayNum_;
			}
			set
			{
				this.curStageDayNum_ = value;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x001477CA File Offset: 0x001459CA
		// (set) Token: 0x06008831 RID: 34865 RVA: 0x001477D2 File Offset: 0x001459D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDay
		{
			get
			{
				return this.totalDay_;
			}
			set
			{
				this.totalDay_ = value;
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x001477DB File Offset: 0x001459DB
		// (set) Token: 0x06008833 RID: 34867 RVA: 0x001477E3 File Offset: 0x001459E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainDay
		{
			get
			{
				return this.remainDay_;
			}
			set
			{
				this.remainDay_ = value;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x001477EC File Offset: 0x001459EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Races
		{
			get
			{
				return this.races_;
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008835 RID: 34869 RVA: 0x001477F4 File Offset: 0x001459F4
		// (set) Token: 0x06008836 RID: 34870 RVA: 0x001477FC File Offset: 0x001459FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOver
		{
			get
			{
				return this.isOver_;
			}
			set
			{
				this.isOver_ = value;
			}
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x00147805 File Offset: 0x00145A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayInfo);
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x00147814 File Offset: 0x00145A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayInfo other)
		{
			return other != null && (other == this || (this.SubInsId == other.SubInsId && this.terrains_.Equals(other.terrains_) && this.phantomList_.Equals(other.phantomList_) && this.toyList_.Equals(other.toyList_) && this.TotalCoin == other.TotalCoin && this.TotalDiamond == other.TotalDiamond && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && this.SkillId == other.SkillId && this.Stage == other.Stage && this.Day == other.Day && this.StageTributeCount == other.StageTributeCount && this.EnableToy == other.EnableToy && object.Equals(this.Dungeon, other.Dungeon) && object.Equals(this.Role, other.Role) && this.IsUnLimited == other.IsUnLimited && this.CurStageDayNum == other.CurStageDayNum && this.TotalDay == other.TotalDay && this.RemainDay == other.RemainDay && this.races_.Equals(other.races_) && this.IsOver == other.IsOver && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x001479AC File Offset: 0x00145BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			num ^= this.terrains_.GetHashCode();
			num ^= this.phantomList_.GetHashCode();
			num ^= this.toyList_.GetHashCode();
			if (this.TotalCoin != 0L)
			{
				num ^= this.TotalCoin.GetHashCode();
			}
			if (this.TotalDiamond != 0L)
			{
				num ^= this.TotalDiamond.GetHashCode();
			}
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Stage != 0)
			{
				num ^= this.Stage.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this.StageTributeCount != 0L)
			{
				num ^= this.StageTributeCount.GetHashCode();
			}
			if (this.EnableToy != 0)
			{
				num ^= this.EnableToy.GetHashCode();
			}
			if (this.dungeon_ != null)
			{
				num ^= this.Dungeon.GetHashCode();
			}
			if (this.role_ != null)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this.IsUnLimited)
			{
				num ^= this.IsUnLimited.GetHashCode();
			}
			if (this.CurStageDayNum != 0)
			{
				num ^= this.CurStageDayNum.GetHashCode();
			}
			if (this.TotalDay != 0)
			{
				num ^= this.TotalDay.GetHashCode();
			}
			if (this.RemainDay != 0)
			{
				num ^= this.RemainDay.GetHashCode();
			}
			num ^= this.races_.GetHashCode();
			if (this.IsOver)
			{
				num ^= this.IsOver.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x00147BAD File Offset: 0x00145DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x00147BBA File Offset: 0x00145DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x00147BC4 File Offset: 0x00145DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			this.terrains_.WriteTo(ref output, FloroRanchPlayInfo._repeated_terrains_codec);
			this.phantomList_.WriteTo(ref output, FloroRanchPlayInfo._repeated_phantomList_codec);
			this.toyList_.WriteTo(ref output, FloroRanchPlayInfo._repeated_toyList_codec);
			if (this.TotalCoin != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TotalCoin);
			}
			if (this.TotalDiamond != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TotalDiamond);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkillId);
			}
			if (this.Stage != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Stage);
			}
			if (this.Day != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Day);
			}
			if (this.StageTributeCount != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.StageTributeCount);
			}
			if (this.EnableToy != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EnableToy);
			}
			if (this.dungeon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Dungeon);
			}
			if (this.role_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Role);
			}
			if (this.IsUnLimited)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.IsUnLimited);
			}
			if (this.CurStageDayNum != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.CurStageDayNum);
			}
			if (this.TotalDay != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.RemainDay);
			}
			this.races_.WriteTo(ref output, FloroRanchPlayInfo._repeated_races_codec);
			if (this.IsOver)
			{
				output.WriteRawTag(168, 1);
				output.WriteBool(this.IsOver);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x00147E18 File Offset: 0x00146018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			num += this.terrains_.CalculateSize(FloroRanchPlayInfo._repeated_terrains_codec);
			num += this.phantomList_.CalculateSize(FloroRanchPlayInfo._repeated_phantomList_codec);
			num += this.toyList_.CalculateSize(FloroRanchPlayInfo._repeated_toyList_codec);
			if (this.TotalCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCoin);
			}
			if (this.TotalDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalDiamond);
			}
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Stage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Stage);
			}
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this.StageTributeCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StageTributeCount);
			}
			if (this.EnableToy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnableToy);
			}
			if (this.dungeon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Dungeon);
			}
			if (this.role_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Role);
			}
			if (this.IsUnLimited)
			{
				num += 3;
			}
			if (this.CurStageDayNum != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CurStageDayNum);
			}
			if (this.TotalDay != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RemainDay);
			}
			num += this.races_.CalculateSize(FloroRanchPlayInfo._repeated_races_codec);
			if (this.IsOver)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x0014800C File Offset: 0x0014620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this.terrains_.Add(other.terrains_);
			this.phantomList_.Add(other.phantomList_);
			this.toyList_.Add(other.toyList_);
			if (other.TotalCoin != 0L)
			{
				this.TotalCoin = other.TotalCoin;
			}
			if (other.TotalDiamond != 0L)
			{
				this.TotalDiamond = other.TotalDiamond;
			}
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Stage != 0)
			{
				this.Stage = other.Stage;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			if (other.StageTributeCount != 0L)
			{
				this.StageTributeCount = other.StageTributeCount;
			}
			if (other.EnableToy != 0)
			{
				this.EnableToy = other.EnableToy;
			}
			if (other.dungeon_ != null)
			{
				if (this.dungeon_ == null)
				{
					this.Dungeon = new FloroRanchPlayUnit();
				}
				this.Dungeon.MergeFrom(other.Dungeon);
			}
			if (other.role_ != null)
			{
				if (this.role_ == null)
				{
					this.Role = new FloroRanchPlayUnit();
				}
				this.Role.MergeFrom(other.Role);
			}
			if (other.IsUnLimited)
			{
				this.IsUnLimited = other.IsUnLimited;
			}
			if (other.CurStageDayNum != 0)
			{
				this.CurStageDayNum = other.CurStageDayNum;
			}
			if (other.TotalDay != 0)
			{
				this.TotalDay = other.TotalDay;
			}
			if (other.RemainDay != 0)
			{
				this.RemainDay = other.RemainDay;
			}
			this.races_.Add(other.races_);
			if (other.IsOver)
			{
				this.IsOver = other.IsOver;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x001481FC File Offset: 0x001463FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00148208 File Offset: 0x00146408
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
				if (num <= 88U)
				{
					if (num <= 40U)
					{
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.SubInsId = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								this.terrains_.AddEntriesFrom(ref input, FloroRanchPlayInfo._repeated_terrains_codec);
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								this.phantomList_.AddEntriesFrom(ref input, FloroRanchPlayInfo._repeated_phantomList_codec);
								continue;
							}
							if (num == 34U)
							{
								this.toyList_.AddEntriesFrom(ref input, FloroRanchPlayInfo._repeated_toyList_codec);
								continue;
							}
							if (num == 40U)
							{
								this.TotalCoin = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 64U)
					{
						if (num == 48U)
						{
							this.TotalDiamond = input.ReadInt64();
							continue;
						}
						if (num == 56U)
						{
							this.CurCoin = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.CurDiamond = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.SkillId = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.Stage = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.Day = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 128U)
				{
					if (num <= 104U)
					{
						if (num == 96U)
						{
							this.StageTributeCount = input.ReadInt64();
							continue;
						}
						if (num == 104U)
						{
							this.EnableToy = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 114U)
						{
							if (this.dungeon_ == null)
							{
								this.Dungeon = new FloroRanchPlayUnit();
							}
							input.ReadMessage(this.Dungeon);
							continue;
						}
						if (num == 122U)
						{
							if (this.role_ == null)
							{
								this.Role = new FloroRanchPlayUnit();
							}
							input.ReadMessage(this.Role);
							continue;
						}
						if (num == 128U)
						{
							this.IsUnLimited = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 152U)
				{
					if (num == 136U)
					{
						this.CurStageDayNum = input.ReadInt32();
						continue;
					}
					if (num == 144U)
					{
						this.TotalDay = input.ReadInt32();
						continue;
					}
					if (num == 152U)
					{
						this.RemainDay = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 160U || num == 162U)
					{
						this.races_.AddEntriesFrom(ref input, FloroRanchPlayInfo._repeated_races_codec);
						continue;
					}
					if (num == 168U)
					{
						this.IsOver = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042F3 RID: 17139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042F4 RID: 17140
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x040042F5 RID: 17141
		private int subInsId_;

		// Token: 0x040042F6 RID: 17142
		public const int TerrainsFieldNumber = 2;

		// Token: 0x040042F7 RID: 17143
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_terrains_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(18U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042F8 RID: 17144
		private readonly RepeatedField<FloroRanchPlayUnit> terrains_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042F9 RID: 17145
		public const int PhantomListFieldNumber = 3;

		// Token: 0x040042FA RID: 17146
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_phantomList_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(26U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042FB RID: 17147
		private readonly RepeatedField<FloroRanchPlayUnit> phantomList_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042FC RID: 17148
		public const int ToyListFieldNumber = 4;

		// Token: 0x040042FD RID: 17149
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_toyList_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(34U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042FE RID: 17150
		private readonly RepeatedField<FloroRanchPlayUnit> toyList_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042FF RID: 17151
		public const int TotalCoinFieldNumber = 5;

		// Token: 0x04004300 RID: 17152
		private long totalCoin_;

		// Token: 0x04004301 RID: 17153
		public const int TotalDiamondFieldNumber = 6;

		// Token: 0x04004302 RID: 17154
		private long totalDiamond_;

		// Token: 0x04004303 RID: 17155
		public const int CurCoinFieldNumber = 7;

		// Token: 0x04004304 RID: 17156
		private long curCoin_;

		// Token: 0x04004305 RID: 17157
		public const int CurDiamondFieldNumber = 8;

		// Token: 0x04004306 RID: 17158
		private long curDiamond_;

		// Token: 0x04004307 RID: 17159
		public const int SkillIdFieldNumber = 9;

		// Token: 0x04004308 RID: 17160
		private int skillId_;

		// Token: 0x04004309 RID: 17161
		public const int StageFieldNumber = 10;

		// Token: 0x0400430A RID: 17162
		private int stage_;

		// Token: 0x0400430B RID: 17163
		public const int DayFieldNumber = 11;

		// Token: 0x0400430C RID: 17164
		private int day_;

		// Token: 0x0400430D RID: 17165
		public const int StageTributeCountFieldNumber = 12;

		// Token: 0x0400430E RID: 17166
		private long stageTributeCount_;

		// Token: 0x0400430F RID: 17167
		public const int EnableToyFieldNumber = 13;

		// Token: 0x04004310 RID: 17168
		private int enableToy_;

		// Token: 0x04004311 RID: 17169
		public const int DungeonFieldNumber = 14;

		// Token: 0x04004312 RID: 17170
		private FloroRanchPlayUnit dungeon_;

		// Token: 0x04004313 RID: 17171
		public const int RoleFieldNumber = 15;

		// Token: 0x04004314 RID: 17172
		private FloroRanchPlayUnit role_;

		// Token: 0x04004315 RID: 17173
		public const int IsUnLimitedFieldNumber = 16;

		// Token: 0x04004316 RID: 17174
		private bool isUnLimited_;

		// Token: 0x04004317 RID: 17175
		public const int CurStageDayNumFieldNumber = 17;

		// Token: 0x04004318 RID: 17176
		private int curStageDayNum_;

		// Token: 0x04004319 RID: 17177
		public const int TotalDayFieldNumber = 18;

		// Token: 0x0400431A RID: 17178
		private int totalDay_;

		// Token: 0x0400431B RID: 17179
		public const int RemainDayFieldNumber = 19;

		// Token: 0x0400431C RID: 17180
		private int remainDay_;

		// Token: 0x0400431D RID: 17181
		public const int RacesFieldNumber = 20;

		// Token: 0x0400431E RID: 17182
		private static readonly FieldCodec<int> _repeated_races_codec = FieldCodec.ForInt32(162U);

		// Token: 0x0400431F RID: 17183
		private readonly RepeatedField<int> races_ = new RepeatedField<int>();

		// Token: 0x04004320 RID: 17184
		public const int IsOverFieldNumber = 21;

		// Token: 0x04004321 RID: 17185
		private bool isOver_;
	}
}
