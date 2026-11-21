using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AC RID: 1452
	public sealed class FloroRanchPlayInfo : IMessage<FloroRanchPlayInfo>, IMessage, IEquatable<FloroRanchPlayInfo>, IDeepCloneable<FloroRanchPlayInfo>, IBufferMessage
	{
		// Token: 0x060086A3 RID: 34467 RVA: 0x00144909 File Offset: 0x00142B09
		[NullableContext(1)]
		public static FloroRanchPlayInfo Create()
		{
			return new FloroRanchPlayInfo();
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x060086A4 RID: 34468 RVA: 0x00144910 File Offset: 0x00142B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x060086A5 RID: 34469 RVA: 0x00144913 File Offset: 0x00142B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayInfo.Descriptor;
			}
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x0014491A File Offset: 0x00142B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo()
		{
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x00144950 File Offset: 0x00142B50
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

		// Token: 0x060086A8 RID: 34472 RVA: 0x00144AA4 File Offset: 0x00142CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo Clone()
		{
			return new FloroRanchPlayInfo(this);
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x00144AAC File Offset: 0x00142CAC
		// (set) Token: 0x060086AA RID: 34474 RVA: 0x00144AB4 File Offset: 0x00142CB4
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

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x00144ABD File Offset: 0x00142CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> Terrains
		{
			get
			{
				return this.terrains_;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x060086AC RID: 34476 RVA: 0x00144AC5 File Offset: 0x00142CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> PhantomList
		{
			get
			{
				return this.phantomList_;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x00144ACD File Offset: 0x00142CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> ToyList
		{
			get
			{
				return this.toyList_;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x060086AE RID: 34478 RVA: 0x00144AD5 File Offset: 0x00142CD5
		// (set) Token: 0x060086AF RID: 34479 RVA: 0x00144ADD File Offset: 0x00142CDD
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

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x060086B0 RID: 34480 RVA: 0x00144AE6 File Offset: 0x00142CE6
		// (set) Token: 0x060086B1 RID: 34481 RVA: 0x00144AEE File Offset: 0x00142CEE
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x060086B2 RID: 34482 RVA: 0x00144AF7 File Offset: 0x00142CF7
		// (set) Token: 0x060086B3 RID: 34483 RVA: 0x00144AFF File Offset: 0x00142CFF
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

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x060086B4 RID: 34484 RVA: 0x00144B08 File Offset: 0x00142D08
		// (set) Token: 0x060086B5 RID: 34485 RVA: 0x00144B10 File Offset: 0x00142D10
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

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x060086B6 RID: 34486 RVA: 0x00144B19 File Offset: 0x00142D19
		// (set) Token: 0x060086B7 RID: 34487 RVA: 0x00144B21 File Offset: 0x00142D21
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

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x060086B8 RID: 34488 RVA: 0x00144B2A File Offset: 0x00142D2A
		// (set) Token: 0x060086B9 RID: 34489 RVA: 0x00144B32 File Offset: 0x00142D32
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

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x00144B3B File Offset: 0x00142D3B
		// (set) Token: 0x060086BB RID: 34491 RVA: 0x00144B43 File Offset: 0x00142D43
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

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x060086BC RID: 34492 RVA: 0x00144B4C File Offset: 0x00142D4C
		// (set) Token: 0x060086BD RID: 34493 RVA: 0x00144B54 File Offset: 0x00142D54
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

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x060086BE RID: 34494 RVA: 0x00144B5D File Offset: 0x00142D5D
		// (set) Token: 0x060086BF RID: 34495 RVA: 0x00144B65 File Offset: 0x00142D65
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

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x060086C0 RID: 34496 RVA: 0x00144B6E File Offset: 0x00142D6E
		// (set) Token: 0x060086C1 RID: 34497 RVA: 0x00144B76 File Offset: 0x00142D76
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

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x060086C2 RID: 34498 RVA: 0x00144B7F File Offset: 0x00142D7F
		// (set) Token: 0x060086C3 RID: 34499 RVA: 0x00144B87 File Offset: 0x00142D87
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

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x060086C4 RID: 34500 RVA: 0x00144B90 File Offset: 0x00142D90
		// (set) Token: 0x060086C5 RID: 34501 RVA: 0x00144B98 File Offset: 0x00142D98
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

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x060086C6 RID: 34502 RVA: 0x00144BA1 File Offset: 0x00142DA1
		// (set) Token: 0x060086C7 RID: 34503 RVA: 0x00144BA9 File Offset: 0x00142DA9
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

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x060086C8 RID: 34504 RVA: 0x00144BB2 File Offset: 0x00142DB2
		// (set) Token: 0x060086C9 RID: 34505 RVA: 0x00144BBA File Offset: 0x00142DBA
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

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x00144BC3 File Offset: 0x00142DC3
		// (set) Token: 0x060086CB RID: 34507 RVA: 0x00144BCB File Offset: 0x00142DCB
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

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x00144BD4 File Offset: 0x00142DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Races
		{
			get
			{
				return this.races_;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x00144BDC File Offset: 0x00142DDC
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x00144BE4 File Offset: 0x00142DE4
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

		// Token: 0x060086CF RID: 34511 RVA: 0x00144BED File Offset: 0x00142DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayInfo);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x00144BFC File Offset: 0x00142DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayInfo other)
		{
			return other != null && (other == this || (this.SubInsId == other.SubInsId && this.terrains_.Equals(other.terrains_) && this.phantomList_.Equals(other.phantomList_) && this.toyList_.Equals(other.toyList_) && this.TotalCoin == other.TotalCoin && this.TotalDiamond == other.TotalDiamond && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && this.SkillId == other.SkillId && this.Stage == other.Stage && this.Day == other.Day && this.StageTributeCount == other.StageTributeCount && this.EnableToy == other.EnableToy && object.Equals(this.Dungeon, other.Dungeon) && object.Equals(this.Role, other.Role) && this.IsUnLimited == other.IsUnLimited && this.CurStageDayNum == other.CurStageDayNum && this.TotalDay == other.TotalDay && this.RemainDay == other.RemainDay && this.races_.Equals(other.races_) && this.IsOver == other.IsOver && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x00144D94 File Offset: 0x00142F94
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

		// Token: 0x060086D2 RID: 34514 RVA: 0x00144F95 File Offset: 0x00143195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x00144FA2 File Offset: 0x001431A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x00144FAC File Offset: 0x001431AC
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

		// Token: 0x060086D5 RID: 34517 RVA: 0x00145200 File Offset: 0x00143400
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

		// Token: 0x060086D6 RID: 34518 RVA: 0x001453F4 File Offset: 0x001435F4
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

		// Token: 0x060086D7 RID: 34519 RVA: 0x001455E4 File Offset: 0x001437E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x001455F0 File Offset: 0x001437F0
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

		// Token: 0x040042E9 RID: 17129
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042EA RID: 17130
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x040042EB RID: 17131
		private int subInsId_;

		// Token: 0x040042EC RID: 17132
		public const int TerrainsFieldNumber = 2;

		// Token: 0x040042ED RID: 17133
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_terrains_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(18U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042EE RID: 17134
		private readonly RepeatedField<FloroRanchPlayUnit> terrains_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042EF RID: 17135
		public const int PhantomListFieldNumber = 3;

		// Token: 0x040042F0 RID: 17136
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_phantomList_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(26U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042F1 RID: 17137
		private readonly RepeatedField<FloroRanchPlayUnit> phantomList_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042F2 RID: 17138
		public const int ToyListFieldNumber = 4;

		// Token: 0x040042F3 RID: 17139
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_toyList_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(34U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042F4 RID: 17140
		private readonly RepeatedField<FloroRanchPlayUnit> toyList_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x040042F5 RID: 17141
		public const int TotalCoinFieldNumber = 5;

		// Token: 0x040042F6 RID: 17142
		private long totalCoin_;

		// Token: 0x040042F7 RID: 17143
		public const int TotalDiamondFieldNumber = 6;

		// Token: 0x040042F8 RID: 17144
		private long totalDiamond_;

		// Token: 0x040042F9 RID: 17145
		public const int CurCoinFieldNumber = 7;

		// Token: 0x040042FA RID: 17146
		private long curCoin_;

		// Token: 0x040042FB RID: 17147
		public const int CurDiamondFieldNumber = 8;

		// Token: 0x040042FC RID: 17148
		private long curDiamond_;

		// Token: 0x040042FD RID: 17149
		public const int SkillIdFieldNumber = 9;

		// Token: 0x040042FE RID: 17150
		private int skillId_;

		// Token: 0x040042FF RID: 17151
		public const int StageFieldNumber = 10;

		// Token: 0x04004300 RID: 17152
		private int stage_;

		// Token: 0x04004301 RID: 17153
		public const int DayFieldNumber = 11;

		// Token: 0x04004302 RID: 17154
		private int day_;

		// Token: 0x04004303 RID: 17155
		public const int StageTributeCountFieldNumber = 12;

		// Token: 0x04004304 RID: 17156
		private long stageTributeCount_;

		// Token: 0x04004305 RID: 17157
		public const int EnableToyFieldNumber = 13;

		// Token: 0x04004306 RID: 17158
		private int enableToy_;

		// Token: 0x04004307 RID: 17159
		public const int DungeonFieldNumber = 14;

		// Token: 0x04004308 RID: 17160
		private FloroRanchPlayUnit dungeon_;

		// Token: 0x04004309 RID: 17161
		public const int RoleFieldNumber = 15;

		// Token: 0x0400430A RID: 17162
		private FloroRanchPlayUnit role_;

		// Token: 0x0400430B RID: 17163
		public const int IsUnLimitedFieldNumber = 16;

		// Token: 0x0400430C RID: 17164
		private bool isUnLimited_;

		// Token: 0x0400430D RID: 17165
		public const int CurStageDayNumFieldNumber = 17;

		// Token: 0x0400430E RID: 17166
		private int curStageDayNum_;

		// Token: 0x0400430F RID: 17167
		public const int TotalDayFieldNumber = 18;

		// Token: 0x04004310 RID: 17168
		private int totalDay_;

		// Token: 0x04004311 RID: 17169
		public const int RemainDayFieldNumber = 19;

		// Token: 0x04004312 RID: 17170
		private int remainDay_;

		// Token: 0x04004313 RID: 17171
		public const int RacesFieldNumber = 20;

		// Token: 0x04004314 RID: 17172
		private static readonly FieldCodec<int> _repeated_races_codec = FieldCodec.ForInt32(162U);

		// Token: 0x04004315 RID: 17173
		private readonly RepeatedField<int> races_ = new RepeatedField<int>();

		// Token: 0x04004316 RID: 17174
		public const int IsOverFieldNumber = 21;

		// Token: 0x04004317 RID: 17175
		private bool isOver_;
	}
}
