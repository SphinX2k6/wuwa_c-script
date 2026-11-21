using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011ED RID: 4589
	public sealed class SecRoleFightFlowData : IMessage<SecRoleFightFlowData>, IMessage, IEquatable<SecRoleFightFlowData>, IDeepCloneable<SecRoleFightFlowData>, IBufferMessage
	{
		// Token: 0x06018820 RID: 100384 RVA: 0x00392186 File Offset: 0x00390386
		[NullableContext(1)]
		public static SecRoleFightFlowData Create()
		{
			return new SecRoleFightFlowData();
		}

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x06018821 RID: 100385 RVA: 0x0039218D File Offset: 0x0039038D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SecRoleFightFlowData> Parser
		{
			get
			{
				return SecRoleFightFlowData._parser;
			}
		}

		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x06018822 RID: 100386 RVA: 0x00392194 File Offset: 0x00390394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x06018823 RID: 100387 RVA: 0x00392197 File Offset: 0x00390397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowData.Descriptor;
			}
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x0039219E File Offset: 0x0039039E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowData()
		{
		}

		// Token: 0x06018825 RID: 100389 RVA: 0x003921B4 File Offset: 0x003903B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowData(SecRoleFightFlowData other) : this()
		{
			this.srvFighterID_ = other.srvFighterID_;
			this.fighterInfoMax_ = ((other.fighterInfoMax_ != null) ? other.fighterInfoMax_.Clone() : null);
			this.residentTimeTotal_ = other.residentTimeTotal_;
			this.roundFighterDpsTotal_ = other.roundFighterDpsTotal_;
			this.roundFighterDpsCount_ = other.roundFighterDpsCount_;
			this.roundFighterAtkMissTotal_ = other.roundFighterAtkMissTotal_;
			this.roundFighterDamage1Max_ = other.roundFighterDamage1Max_;
			this.roundFighterDamage1Min_ = other.roundFighterDamage1Min_;
			this.roundFighterPlayerCritCount_ = other.roundFighterPlayerCritCount_;
			this.roundFighterDamage2Max_ = other.roundFighterDamage2Max_;
			this.roundFighterDamage2Min_ = other.roundFighterDamage2Min_;
			this.roundFighterButtonClickCountATK_ = other.roundFighterButtonClickCountATK_;
			this.roundFighterButtonClickCount1_ = other.roundFighterButtonClickCount1_;
			this.roundFighterButtonClickCount2_ = other.roundFighterButtonClickCount2_;
			this.roundFighterButtonClickCount3_ = other.roundFighterButtonClickCount3_;
			this.roundFighterButtonClickCountJump_ = other.roundFighterButtonClickCountJump_;
			this.roundFighterButtonClickCountDodge_ = other.roundFighterButtonClickCountDodge_;
			this.posList_ = other.posList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018826 RID: 100390 RVA: 0x003922C5 File Offset: 0x003904C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowData Clone()
		{
			return new SecRoleFightFlowData(this);
		}

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x06018827 RID: 100391 RVA: 0x003922CD File Offset: 0x003904CD
		// (set) Token: 0x06018828 RID: 100392 RVA: 0x003922D5 File Offset: 0x003904D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SrvFighterID
		{
			get
			{
				return this.srvFighterID_;
			}
			set
			{
				this.srvFighterID_ = value;
			}
		}

		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x06018829 RID: 100393 RVA: 0x003922DE File Offset: 0x003904DE
		// (set) Token: 0x0601882A RID: 100394 RVA: 0x003922E6 File Offset: 0x003904E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo FighterInfoMax
		{
			get
			{
				return this.fighterInfoMax_;
			}
			set
			{
				this.fighterInfoMax_ = value;
			}
		}

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x0601882B RID: 100395 RVA: 0x003922EF File Offset: 0x003904EF
		// (set) Token: 0x0601882C RID: 100396 RVA: 0x003922F7 File Offset: 0x003904F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResidentTimeTotal
		{
			get
			{
				return this.residentTimeTotal_;
			}
			set
			{
				this.residentTimeTotal_ = value;
			}
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x0601882D RID: 100397 RVA: 0x00392300 File Offset: 0x00390500
		// (set) Token: 0x0601882E RID: 100398 RVA: 0x00392308 File Offset: 0x00390508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoundFighterDpsTotal
		{
			get
			{
				return this.roundFighterDpsTotal_;
			}
			set
			{
				this.roundFighterDpsTotal_ = value;
			}
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x0601882F RID: 100399 RVA: 0x00392311 File Offset: 0x00390511
		// (set) Token: 0x06018830 RID: 100400 RVA: 0x00392319 File Offset: 0x00390519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterDpsCount
		{
			get
			{
				return this.roundFighterDpsCount_;
			}
			set
			{
				this.roundFighterDpsCount_ = value;
			}
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x06018831 RID: 100401 RVA: 0x00392322 File Offset: 0x00390522
		// (set) Token: 0x06018832 RID: 100402 RVA: 0x0039232A File Offset: 0x0039052A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterAtkMissTotal
		{
			get
			{
				return this.roundFighterAtkMissTotal_;
			}
			set
			{
				this.roundFighterAtkMissTotal_ = value;
			}
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x06018833 RID: 100403 RVA: 0x00392333 File Offset: 0x00390533
		// (set) Token: 0x06018834 RID: 100404 RVA: 0x0039233B File Offset: 0x0039053B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterDamage1Max
		{
			get
			{
				return this.roundFighterDamage1Max_;
			}
			set
			{
				this.roundFighterDamage1Max_ = value;
			}
		}

		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x06018835 RID: 100405 RVA: 0x00392344 File Offset: 0x00390544
		// (set) Token: 0x06018836 RID: 100406 RVA: 0x0039234C File Offset: 0x0039054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterDamage1Min
		{
			get
			{
				return this.roundFighterDamage1Min_;
			}
			set
			{
				this.roundFighterDamage1Min_ = value;
			}
		}

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x06018837 RID: 100407 RVA: 0x00392355 File Offset: 0x00390555
		// (set) Token: 0x06018838 RID: 100408 RVA: 0x0039235D File Offset: 0x0039055D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterPlayerCritCount
		{
			get
			{
				return this.roundFighterPlayerCritCount_;
			}
			set
			{
				this.roundFighterPlayerCritCount_ = value;
			}
		}

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x06018839 RID: 100409 RVA: 0x00392366 File Offset: 0x00390566
		// (set) Token: 0x0601883A RID: 100410 RVA: 0x0039236E File Offset: 0x0039056E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterDamage2Max
		{
			get
			{
				return this.roundFighterDamage2Max_;
			}
			set
			{
				this.roundFighterDamage2Max_ = value;
			}
		}

		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x0601883B RID: 100411 RVA: 0x00392377 File Offset: 0x00390577
		// (set) Token: 0x0601883C RID: 100412 RVA: 0x0039237F File Offset: 0x0039057F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterDamage2Min
		{
			get
			{
				return this.roundFighterDamage2Min_;
			}
			set
			{
				this.roundFighterDamage2Min_ = value;
			}
		}

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x0601883D RID: 100413 RVA: 0x00392388 File Offset: 0x00390588
		// (set) Token: 0x0601883E RID: 100414 RVA: 0x00392390 File Offset: 0x00390590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCountATK
		{
			get
			{
				return this.roundFighterButtonClickCountATK_;
			}
			set
			{
				this.roundFighterButtonClickCountATK_ = value;
			}
		}

		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x0601883F RID: 100415 RVA: 0x00392399 File Offset: 0x00390599
		// (set) Token: 0x06018840 RID: 100416 RVA: 0x003923A1 File Offset: 0x003905A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCount1
		{
			get
			{
				return this.roundFighterButtonClickCount1_;
			}
			set
			{
				this.roundFighterButtonClickCount1_ = value;
			}
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06018841 RID: 100417 RVA: 0x003923AA File Offset: 0x003905AA
		// (set) Token: 0x06018842 RID: 100418 RVA: 0x003923B2 File Offset: 0x003905B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCount2
		{
			get
			{
				return this.roundFighterButtonClickCount2_;
			}
			set
			{
				this.roundFighterButtonClickCount2_ = value;
			}
		}

		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x06018843 RID: 100419 RVA: 0x003923BB File Offset: 0x003905BB
		// (set) Token: 0x06018844 RID: 100420 RVA: 0x003923C3 File Offset: 0x003905C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCount3
		{
			get
			{
				return this.roundFighterButtonClickCount3_;
			}
			set
			{
				this.roundFighterButtonClickCount3_ = value;
			}
		}

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x06018845 RID: 100421 RVA: 0x003923CC File Offset: 0x003905CC
		// (set) Token: 0x06018846 RID: 100422 RVA: 0x003923D4 File Offset: 0x003905D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCountJump
		{
			get
			{
				return this.roundFighterButtonClickCountJump_;
			}
			set
			{
				this.roundFighterButtonClickCountJump_ = value;
			}
		}

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x06018847 RID: 100423 RVA: 0x003923DD File Offset: 0x003905DD
		// (set) Token: 0x06018848 RID: 100424 RVA: 0x003923E5 File Offset: 0x003905E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundFighterButtonClickCountDodge
		{
			get
			{
				return this.roundFighterButtonClickCountDodge_;
			}
			set
			{
				this.roundFighterButtonClickCountDodge_ = value;
			}
		}

		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x06018849 RID: 100425 RVA: 0x003923EE File Offset: 0x003905EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x0601884A RID: 100426 RVA: 0x003923F6 File Offset: 0x003905F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowData);
		}

		// Token: 0x0601884B RID: 100427 RVA: 0x00392404 File Offset: 0x00390604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowData other)
		{
			return other != null && (other == this || (this.SrvFighterID == other.SrvFighterID && object.Equals(this.FighterInfoMax, other.FighterInfoMax) && this.ResidentTimeTotal == other.ResidentTimeTotal && this.RoundFighterDpsTotal == other.RoundFighterDpsTotal && this.RoundFighterDpsCount == other.RoundFighterDpsCount && this.RoundFighterAtkMissTotal == other.RoundFighterAtkMissTotal && this.RoundFighterDamage1Max == other.RoundFighterDamage1Max && this.RoundFighterDamage1Min == other.RoundFighterDamage1Min && this.RoundFighterPlayerCritCount == other.RoundFighterPlayerCritCount && this.RoundFighterDamage2Max == other.RoundFighterDamage2Max && this.RoundFighterDamage2Min == other.RoundFighterDamage2Min && this.RoundFighterButtonClickCountATK == other.RoundFighterButtonClickCountATK && this.RoundFighterButtonClickCount1 == other.RoundFighterButtonClickCount1 && this.RoundFighterButtonClickCount2 == other.RoundFighterButtonClickCount2 && this.RoundFighterButtonClickCount3 == other.RoundFighterButtonClickCount3 && this.RoundFighterButtonClickCountJump == other.RoundFighterButtonClickCountJump && this.RoundFighterButtonClickCountDodge == other.RoundFighterButtonClickCountDodge && this.posList_.Equals(other.posList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601884C RID: 100428 RVA: 0x00392558 File Offset: 0x00390758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SrvFighterID != 0)
			{
				num ^= this.SrvFighterID.GetHashCode();
			}
			if (this.fighterInfoMax_ != null)
			{
				num ^= this.FighterInfoMax.GetHashCode();
			}
			if (this.ResidentTimeTotal != 0L)
			{
				num ^= this.ResidentTimeTotal.GetHashCode();
			}
			if (this.RoundFighterDpsTotal != 0L)
			{
				num ^= this.RoundFighterDpsTotal.GetHashCode();
			}
			if (this.RoundFighterDpsCount != 0)
			{
				num ^= this.RoundFighterDpsCount.GetHashCode();
			}
			if (this.RoundFighterAtkMissTotal != 0)
			{
				num ^= this.RoundFighterAtkMissTotal.GetHashCode();
			}
			if (this.RoundFighterDamage1Max != 0)
			{
				num ^= this.RoundFighterDamage1Max.GetHashCode();
			}
			if (this.RoundFighterDamage1Min != 0)
			{
				num ^= this.RoundFighterDamage1Min.GetHashCode();
			}
			if (this.RoundFighterPlayerCritCount != 0)
			{
				num ^= this.RoundFighterPlayerCritCount.GetHashCode();
			}
			if (this.RoundFighterDamage2Max != 0)
			{
				num ^= this.RoundFighterDamage2Max.GetHashCode();
			}
			if (this.RoundFighterDamage2Min != 0)
			{
				num ^= this.RoundFighterDamage2Min.GetHashCode();
			}
			if (this.RoundFighterButtonClickCountATK != 0)
			{
				num ^= this.RoundFighterButtonClickCountATK.GetHashCode();
			}
			if (this.RoundFighterButtonClickCount1 != 0)
			{
				num ^= this.RoundFighterButtonClickCount1.GetHashCode();
			}
			if (this.RoundFighterButtonClickCount2 != 0)
			{
				num ^= this.RoundFighterButtonClickCount2.GetHashCode();
			}
			if (this.RoundFighterButtonClickCount3 != 0)
			{
				num ^= this.RoundFighterButtonClickCount3.GetHashCode();
			}
			if (this.RoundFighterButtonClickCountJump != 0)
			{
				num ^= this.RoundFighterButtonClickCountJump.GetHashCode();
			}
			if (this.RoundFighterButtonClickCountDodge != 0)
			{
				num ^= this.RoundFighterButtonClickCountDodge.GetHashCode();
			}
			num ^= this.posList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601884D RID: 100429 RVA: 0x00392732 File Offset: 0x00390932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601884E RID: 100430 RVA: 0x0039273F File Offset: 0x0039093F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601884F RID: 100431 RVA: 0x00392748 File Offset: 0x00390948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SrvFighterID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SrvFighterID);
			}
			if (this.fighterInfoMax_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FighterInfoMax);
			}
			if (this.ResidentTimeTotal != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ResidentTimeTotal);
			}
			if (this.RoundFighterDpsTotal != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RoundFighterDpsTotal);
			}
			if (this.RoundFighterDpsCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoundFighterDpsCount);
			}
			if (this.RoundFighterAtkMissTotal != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoundFighterAtkMissTotal);
			}
			if (this.RoundFighterDamage1Max != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoundFighterDamage1Max);
			}
			if (this.RoundFighterDamage1Min != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoundFighterDamage1Min);
			}
			if (this.RoundFighterPlayerCritCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoundFighterPlayerCritCount);
			}
			if (this.RoundFighterDamage2Max != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoundFighterDamage2Max);
			}
			if (this.RoundFighterDamage2Min != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoundFighterDamage2Min);
			}
			if (this.RoundFighterButtonClickCountATK != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoundFighterButtonClickCountATK);
			}
			if (this.RoundFighterButtonClickCount1 != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoundFighterButtonClickCount1);
			}
			if (this.RoundFighterButtonClickCount2 != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoundFighterButtonClickCount2);
			}
			if (this.RoundFighterButtonClickCount3 != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoundFighterButtonClickCount3);
			}
			if (this.RoundFighterButtonClickCountJump != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.RoundFighterButtonClickCountJump);
			}
			if (this.RoundFighterButtonClickCountDodge != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.RoundFighterButtonClickCountDodge);
			}
			this.posList_.WriteTo(ref output, SecRoleFightFlowData._repeated_posList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018850 RID: 100432 RVA: 0x00392960 File Offset: 0x00390B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SrvFighterID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SrvFighterID);
			}
			if (this.fighterInfoMax_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FighterInfoMax);
			}
			if (this.ResidentTimeTotal != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResidentTimeTotal);
			}
			if (this.RoundFighterDpsTotal != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RoundFighterDpsTotal);
			}
			if (this.RoundFighterDpsCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterDpsCount);
			}
			if (this.RoundFighterAtkMissTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterAtkMissTotal);
			}
			if (this.RoundFighterDamage1Max != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterDamage1Max);
			}
			if (this.RoundFighterDamage1Min != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterDamage1Min);
			}
			if (this.RoundFighterPlayerCritCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterPlayerCritCount);
			}
			if (this.RoundFighterDamage2Max != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterDamage2Max);
			}
			if (this.RoundFighterDamage2Min != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterDamage2Min);
			}
			if (this.RoundFighterButtonClickCountATK != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCountATK);
			}
			if (this.RoundFighterButtonClickCount1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCount1);
			}
			if (this.RoundFighterButtonClickCount2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCount2);
			}
			if (this.RoundFighterButtonClickCount3 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCount3);
			}
			if (this.RoundFighterButtonClickCountJump != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCountJump);
			}
			if (this.RoundFighterButtonClickCountDodge != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoundFighterButtonClickCountDodge);
			}
			num += this.posList_.CalculateSize(SecRoleFightFlowData._repeated_posList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018851 RID: 100433 RVA: 0x00392B34 File Offset: 0x00390D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecRoleFightFlowData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SrvFighterID != 0)
			{
				this.SrvFighterID = other.SrvFighterID;
			}
			if (other.fighterInfoMax_ != null)
			{
				if (this.fighterInfoMax_ == null)
				{
					this.FighterInfoMax = new SrvFighterInfo();
				}
				this.FighterInfoMax.MergeFrom(other.FighterInfoMax);
			}
			if (other.ResidentTimeTotal != 0L)
			{
				this.ResidentTimeTotal = other.ResidentTimeTotal;
			}
			if (other.RoundFighterDpsTotal != 0L)
			{
				this.RoundFighterDpsTotal = other.RoundFighterDpsTotal;
			}
			if (other.RoundFighterDpsCount != 0)
			{
				this.RoundFighterDpsCount = other.RoundFighterDpsCount;
			}
			if (other.RoundFighterAtkMissTotal != 0)
			{
				this.RoundFighterAtkMissTotal = other.RoundFighterAtkMissTotal;
			}
			if (other.RoundFighterDamage1Max != 0)
			{
				this.RoundFighterDamage1Max = other.RoundFighterDamage1Max;
			}
			if (other.RoundFighterDamage1Min != 0)
			{
				this.RoundFighterDamage1Min = other.RoundFighterDamage1Min;
			}
			if (other.RoundFighterPlayerCritCount != 0)
			{
				this.RoundFighterPlayerCritCount = other.RoundFighterPlayerCritCount;
			}
			if (other.RoundFighterDamage2Max != 0)
			{
				this.RoundFighterDamage2Max = other.RoundFighterDamage2Max;
			}
			if (other.RoundFighterDamage2Min != 0)
			{
				this.RoundFighterDamage2Min = other.RoundFighterDamage2Min;
			}
			if (other.RoundFighterButtonClickCountATK != 0)
			{
				this.RoundFighterButtonClickCountATK = other.RoundFighterButtonClickCountATK;
			}
			if (other.RoundFighterButtonClickCount1 != 0)
			{
				this.RoundFighterButtonClickCount1 = other.RoundFighterButtonClickCount1;
			}
			if (other.RoundFighterButtonClickCount2 != 0)
			{
				this.RoundFighterButtonClickCount2 = other.RoundFighterButtonClickCount2;
			}
			if (other.RoundFighterButtonClickCount3 != 0)
			{
				this.RoundFighterButtonClickCount3 = other.RoundFighterButtonClickCount3;
			}
			if (other.RoundFighterButtonClickCountJump != 0)
			{
				this.RoundFighterButtonClickCountJump = other.RoundFighterButtonClickCountJump;
			}
			if (other.RoundFighterButtonClickCountDodge != 0)
			{
				this.RoundFighterButtonClickCountDodge = other.RoundFighterButtonClickCountDodge;
			}
			this.posList_.Add(other.posList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018852 RID: 100434 RVA: 0x00392CD9 File Offset: 0x00390ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018853 RID: 100435 RVA: 0x00392CE4 File Offset: 0x00390EE4
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
				if (num <= 72U)
				{
					if (num <= 32U)
					{
						if (num <= 18U)
						{
							if (num == 8U)
							{
								this.SrvFighterID = input.ReadInt32();
								continue;
							}
							if (num == 18U)
							{
								if (this.fighterInfoMax_ == null)
								{
									this.FighterInfoMax = new SrvFighterInfo();
								}
								input.ReadMessage(this.FighterInfoMax);
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.ResidentTimeTotal = input.ReadInt64();
								continue;
							}
							if (num == 32U)
							{
								this.RoundFighterDpsTotal = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.RoundFighterDpsCount = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.RoundFighterAtkMissTotal = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.RoundFighterDamage1Max = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.RoundFighterDamage1Min = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.RoundFighterPlayerCritCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num <= 88U)
					{
						if (num == 80U)
						{
							this.RoundFighterDamage2Max = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.RoundFighterDamage2Min = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.RoundFighterButtonClickCountATK = input.ReadInt32();
							continue;
						}
						if (num == 104U)
						{
							this.RoundFighterButtonClickCount1 = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 112U)
					{
						this.RoundFighterButtonClickCount2 = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RoundFighterButtonClickCount3 = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 128U)
					{
						this.RoundFighterButtonClickCountJump = input.ReadInt32();
						continue;
					}
					if (num == 136U)
					{
						this.RoundFighterButtonClickCountDodge = input.ReadInt32();
						continue;
					}
					if (num == 146U)
					{
						this.posList_.AddEntriesFrom(ref input, SecRoleFightFlowData._repeated_posList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040091A2 RID: 37282
		private static readonly MessageParser<SecRoleFightFlowData> _parser = new MessageParser<SecRoleFightFlowData>(() => new SecRoleFightFlowData());

		// Token: 0x040091A3 RID: 37283
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091A4 RID: 37284
		public const int SrvFighterIDFieldNumber = 1;

		// Token: 0x040091A5 RID: 37285
		private int srvFighterID_;

		// Token: 0x040091A6 RID: 37286
		public const int FighterInfoMaxFieldNumber = 2;

		// Token: 0x040091A7 RID: 37287
		private SrvFighterInfo fighterInfoMax_;

		// Token: 0x040091A8 RID: 37288
		public const int ResidentTimeTotalFieldNumber = 3;

		// Token: 0x040091A9 RID: 37289
		private long residentTimeTotal_;

		// Token: 0x040091AA RID: 37290
		public const int RoundFighterDpsTotalFieldNumber = 4;

		// Token: 0x040091AB RID: 37291
		private long roundFighterDpsTotal_;

		// Token: 0x040091AC RID: 37292
		public const int RoundFighterDpsCountFieldNumber = 5;

		// Token: 0x040091AD RID: 37293
		private int roundFighterDpsCount_;

		// Token: 0x040091AE RID: 37294
		public const int RoundFighterAtkMissTotalFieldNumber = 6;

		// Token: 0x040091AF RID: 37295
		private int roundFighterAtkMissTotal_;

		// Token: 0x040091B0 RID: 37296
		public const int RoundFighterDamage1MaxFieldNumber = 7;

		// Token: 0x040091B1 RID: 37297
		private int roundFighterDamage1Max_;

		// Token: 0x040091B2 RID: 37298
		public const int RoundFighterDamage1MinFieldNumber = 8;

		// Token: 0x040091B3 RID: 37299
		private int roundFighterDamage1Min_;

		// Token: 0x040091B4 RID: 37300
		public const int RoundFighterPlayerCritCountFieldNumber = 9;

		// Token: 0x040091B5 RID: 37301
		private int roundFighterPlayerCritCount_;

		// Token: 0x040091B6 RID: 37302
		public const int RoundFighterDamage2MaxFieldNumber = 10;

		// Token: 0x040091B7 RID: 37303
		private int roundFighterDamage2Max_;

		// Token: 0x040091B8 RID: 37304
		public const int RoundFighterDamage2MinFieldNumber = 11;

		// Token: 0x040091B9 RID: 37305
		private int roundFighterDamage2Min_;

		// Token: 0x040091BA RID: 37306
		public const int RoundFighterButtonClickCountATKFieldNumber = 12;

		// Token: 0x040091BB RID: 37307
		private int roundFighterButtonClickCountATK_;

		// Token: 0x040091BC RID: 37308
		public const int RoundFighterButtonClickCount1FieldNumber = 13;

		// Token: 0x040091BD RID: 37309
		private int roundFighterButtonClickCount1_;

		// Token: 0x040091BE RID: 37310
		public const int RoundFighterButtonClickCount2FieldNumber = 14;

		// Token: 0x040091BF RID: 37311
		private int roundFighterButtonClickCount2_;

		// Token: 0x040091C0 RID: 37312
		public const int RoundFighterButtonClickCount3FieldNumber = 15;

		// Token: 0x040091C1 RID: 37313
		private int roundFighterButtonClickCount3_;

		// Token: 0x040091C2 RID: 37314
		public const int RoundFighterButtonClickCountJumpFieldNumber = 16;

		// Token: 0x040091C3 RID: 37315
		private int roundFighterButtonClickCountJump_;

		// Token: 0x040091C4 RID: 37316
		public const int RoundFighterButtonClickCountDodgeFieldNumber = 17;

		// Token: 0x040091C5 RID: 37317
		private int roundFighterButtonClickCountDodge_;

		// Token: 0x040091C6 RID: 37318
		public const int PosListFieldNumber = 18;

		// Token: 0x040091C7 RID: 37319
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(146U, Vector.Parser);

		// Token: 0x040091C8 RID: 37320
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();
	}
}
