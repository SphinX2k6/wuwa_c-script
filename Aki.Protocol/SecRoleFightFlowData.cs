using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B3 RID: 4531
	public sealed class SecRoleFightFlowData : IMessage<SecRoleFightFlowData>, IMessage, IEquatable<SecRoleFightFlowData>, IDeepCloneable<SecRoleFightFlowData>, IBufferMessage
	{
		// Token: 0x0601827F RID: 98943 RVA: 0x00382E1E File Offset: 0x0038101E
		[NullableContext(1)]
		public static SecRoleFightFlowData Create()
		{
			return new SecRoleFightFlowData();
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x06018280 RID: 98944 RVA: 0x00382E25 File Offset: 0x00381025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SecRoleFightFlowData> Parser
		{
			get
			{
				return SecRoleFightFlowData._parser;
			}
		}

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x06018281 RID: 98945 RVA: 0x00382E2C File Offset: 0x0038102C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x06018282 RID: 98946 RVA: 0x00382E2F File Offset: 0x0038102F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowData.Descriptor;
			}
		}

		// Token: 0x06018283 RID: 98947 RVA: 0x00382E36 File Offset: 0x00381036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowData()
		{
		}

		// Token: 0x06018284 RID: 98948 RVA: 0x00382E4C File Offset: 0x0038104C
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

		// Token: 0x06018285 RID: 98949 RVA: 0x00382F5D File Offset: 0x0038115D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowData Clone()
		{
			return new SecRoleFightFlowData(this);
		}

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x06018286 RID: 98950 RVA: 0x00382F65 File Offset: 0x00381165
		// (set) Token: 0x06018287 RID: 98951 RVA: 0x00382F6D File Offset: 0x0038116D
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

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x06018288 RID: 98952 RVA: 0x00382F76 File Offset: 0x00381176
		// (set) Token: 0x06018289 RID: 98953 RVA: 0x00382F7E File Offset: 0x0038117E
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

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x0601828A RID: 98954 RVA: 0x00382F87 File Offset: 0x00381187
		// (set) Token: 0x0601828B RID: 98955 RVA: 0x00382F8F File Offset: 0x0038118F
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

		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x0601828C RID: 98956 RVA: 0x00382F98 File Offset: 0x00381198
		// (set) Token: 0x0601828D RID: 98957 RVA: 0x00382FA0 File Offset: 0x003811A0
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

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x0601828E RID: 98958 RVA: 0x00382FA9 File Offset: 0x003811A9
		// (set) Token: 0x0601828F RID: 98959 RVA: 0x00382FB1 File Offset: 0x003811B1
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

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x06018290 RID: 98960 RVA: 0x00382FBA File Offset: 0x003811BA
		// (set) Token: 0x06018291 RID: 98961 RVA: 0x00382FC2 File Offset: 0x003811C2
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

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x06018292 RID: 98962 RVA: 0x00382FCB File Offset: 0x003811CB
		// (set) Token: 0x06018293 RID: 98963 RVA: 0x00382FD3 File Offset: 0x003811D3
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

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x06018294 RID: 98964 RVA: 0x00382FDC File Offset: 0x003811DC
		// (set) Token: 0x06018295 RID: 98965 RVA: 0x00382FE4 File Offset: 0x003811E4
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

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x06018296 RID: 98966 RVA: 0x00382FED File Offset: 0x003811ED
		// (set) Token: 0x06018297 RID: 98967 RVA: 0x00382FF5 File Offset: 0x003811F5
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

		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x06018298 RID: 98968 RVA: 0x00382FFE File Offset: 0x003811FE
		// (set) Token: 0x06018299 RID: 98969 RVA: 0x00383006 File Offset: 0x00381206
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

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x0601829A RID: 98970 RVA: 0x0038300F File Offset: 0x0038120F
		// (set) Token: 0x0601829B RID: 98971 RVA: 0x00383017 File Offset: 0x00381217
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

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x0601829C RID: 98972 RVA: 0x00383020 File Offset: 0x00381220
		// (set) Token: 0x0601829D RID: 98973 RVA: 0x00383028 File Offset: 0x00381228
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

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x0601829E RID: 98974 RVA: 0x00383031 File Offset: 0x00381231
		// (set) Token: 0x0601829F RID: 98975 RVA: 0x00383039 File Offset: 0x00381239
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

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x060182A0 RID: 98976 RVA: 0x00383042 File Offset: 0x00381242
		// (set) Token: 0x060182A1 RID: 98977 RVA: 0x0038304A File Offset: 0x0038124A
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

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x060182A2 RID: 98978 RVA: 0x00383053 File Offset: 0x00381253
		// (set) Token: 0x060182A3 RID: 98979 RVA: 0x0038305B File Offset: 0x0038125B
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

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x060182A4 RID: 98980 RVA: 0x00383064 File Offset: 0x00381264
		// (set) Token: 0x060182A5 RID: 98981 RVA: 0x0038306C File Offset: 0x0038126C
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

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x060182A6 RID: 98982 RVA: 0x00383075 File Offset: 0x00381275
		// (set) Token: 0x060182A7 RID: 98983 RVA: 0x0038307D File Offset: 0x0038127D
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

		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x060182A8 RID: 98984 RVA: 0x00383086 File Offset: 0x00381286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x060182A9 RID: 98985 RVA: 0x0038308E File Offset: 0x0038128E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowData);
		}

		// Token: 0x060182AA RID: 98986 RVA: 0x0038309C File Offset: 0x0038129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowData other)
		{
			return other != null && (other == this || (this.SrvFighterID == other.SrvFighterID && object.Equals(this.FighterInfoMax, other.FighterInfoMax) && this.ResidentTimeTotal == other.ResidentTimeTotal && this.RoundFighterDpsTotal == other.RoundFighterDpsTotal && this.RoundFighterDpsCount == other.RoundFighterDpsCount && this.RoundFighterAtkMissTotal == other.RoundFighterAtkMissTotal && this.RoundFighterDamage1Max == other.RoundFighterDamage1Max && this.RoundFighterDamage1Min == other.RoundFighterDamage1Min && this.RoundFighterPlayerCritCount == other.RoundFighterPlayerCritCount && this.RoundFighterDamage2Max == other.RoundFighterDamage2Max && this.RoundFighterDamage2Min == other.RoundFighterDamage2Min && this.RoundFighterButtonClickCountATK == other.RoundFighterButtonClickCountATK && this.RoundFighterButtonClickCount1 == other.RoundFighterButtonClickCount1 && this.RoundFighterButtonClickCount2 == other.RoundFighterButtonClickCount2 && this.RoundFighterButtonClickCount3 == other.RoundFighterButtonClickCount3 && this.RoundFighterButtonClickCountJump == other.RoundFighterButtonClickCountJump && this.RoundFighterButtonClickCountDodge == other.RoundFighterButtonClickCountDodge && this.posList_.Equals(other.posList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182AB RID: 98987 RVA: 0x003831F0 File Offset: 0x003813F0
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

		// Token: 0x060182AC RID: 98988 RVA: 0x003833CA File Offset: 0x003815CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182AD RID: 98989 RVA: 0x003833D7 File Offset: 0x003815D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182AE RID: 98990 RVA: 0x003833E0 File Offset: 0x003815E0
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

		// Token: 0x060182AF RID: 98991 RVA: 0x003835F8 File Offset: 0x003817F8
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

		// Token: 0x060182B0 RID: 98992 RVA: 0x003837CC File Offset: 0x003819CC
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

		// Token: 0x060182B1 RID: 98993 RVA: 0x00383971 File Offset: 0x00381B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182B2 RID: 98994 RVA: 0x0038397C File Offset: 0x00381B7C
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

		// Token: 0x04008F0F RID: 36623
		private static readonly MessageParser<SecRoleFightFlowData> _parser = new MessageParser<SecRoleFightFlowData>(() => new SecRoleFightFlowData());

		// Token: 0x04008F10 RID: 36624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F11 RID: 36625
		public const int SrvFighterIDFieldNumber = 1;

		// Token: 0x04008F12 RID: 36626
		private int srvFighterID_;

		// Token: 0x04008F13 RID: 36627
		public const int FighterInfoMaxFieldNumber = 2;

		// Token: 0x04008F14 RID: 36628
		private SrvFighterInfo fighterInfoMax_;

		// Token: 0x04008F15 RID: 36629
		public const int ResidentTimeTotalFieldNumber = 3;

		// Token: 0x04008F16 RID: 36630
		private long residentTimeTotal_;

		// Token: 0x04008F17 RID: 36631
		public const int RoundFighterDpsTotalFieldNumber = 4;

		// Token: 0x04008F18 RID: 36632
		private long roundFighterDpsTotal_;

		// Token: 0x04008F19 RID: 36633
		public const int RoundFighterDpsCountFieldNumber = 5;

		// Token: 0x04008F1A RID: 36634
		private int roundFighterDpsCount_;

		// Token: 0x04008F1B RID: 36635
		public const int RoundFighterAtkMissTotalFieldNumber = 6;

		// Token: 0x04008F1C RID: 36636
		private int roundFighterAtkMissTotal_;

		// Token: 0x04008F1D RID: 36637
		public const int RoundFighterDamage1MaxFieldNumber = 7;

		// Token: 0x04008F1E RID: 36638
		private int roundFighterDamage1Max_;

		// Token: 0x04008F1F RID: 36639
		public const int RoundFighterDamage1MinFieldNumber = 8;

		// Token: 0x04008F20 RID: 36640
		private int roundFighterDamage1Min_;

		// Token: 0x04008F21 RID: 36641
		public const int RoundFighterPlayerCritCountFieldNumber = 9;

		// Token: 0x04008F22 RID: 36642
		private int roundFighterPlayerCritCount_;

		// Token: 0x04008F23 RID: 36643
		public const int RoundFighterDamage2MaxFieldNumber = 10;

		// Token: 0x04008F24 RID: 36644
		private int roundFighterDamage2Max_;

		// Token: 0x04008F25 RID: 36645
		public const int RoundFighterDamage2MinFieldNumber = 11;

		// Token: 0x04008F26 RID: 36646
		private int roundFighterDamage2Min_;

		// Token: 0x04008F27 RID: 36647
		public const int RoundFighterButtonClickCountATKFieldNumber = 12;

		// Token: 0x04008F28 RID: 36648
		private int roundFighterButtonClickCountATK_;

		// Token: 0x04008F29 RID: 36649
		public const int RoundFighterButtonClickCount1FieldNumber = 13;

		// Token: 0x04008F2A RID: 36650
		private int roundFighterButtonClickCount1_;

		// Token: 0x04008F2B RID: 36651
		public const int RoundFighterButtonClickCount2FieldNumber = 14;

		// Token: 0x04008F2C RID: 36652
		private int roundFighterButtonClickCount2_;

		// Token: 0x04008F2D RID: 36653
		public const int RoundFighterButtonClickCount3FieldNumber = 15;

		// Token: 0x04008F2E RID: 36654
		private int roundFighterButtonClickCount3_;

		// Token: 0x04008F2F RID: 36655
		public const int RoundFighterButtonClickCountJumpFieldNumber = 16;

		// Token: 0x04008F30 RID: 36656
		private int roundFighterButtonClickCountJump_;

		// Token: 0x04008F31 RID: 36657
		public const int RoundFighterButtonClickCountDodgeFieldNumber = 17;

		// Token: 0x04008F32 RID: 36658
		private int roundFighterButtonClickCountDodge_;

		// Token: 0x04008F33 RID: 36659
		public const int PosListFieldNumber = 18;

		// Token: 0x04008F34 RID: 36660
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(146U, Vector.Parser);

		// Token: 0x04008F35 RID: 36661
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();
	}
}
