using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C0 RID: 1472
	public sealed class FloroRanchPlayUnit : IMessage<FloroRanchPlayUnit>, IMessage, IEquatable<FloroRanchPlayUnit>, IDeepCloneable<FloroRanchPlayUnit>, IBufferMessage
	{
		// Token: 0x060088B0 RID: 34992 RVA: 0x0014ADCE File Offset: 0x00148FCE
		[NullableContext(1)]
		public static FloroRanchPlayUnit Create()
		{
			return new FloroRanchPlayUnit();
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060088B1 RID: 34993 RVA: 0x0014ADD5 File Offset: 0x00148FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayUnit> Parser
		{
			get
			{
				return FloroRanchPlayUnit._parser;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060088B2 RID: 34994 RVA: 0x0014ADDC File Offset: 0x00148FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x0014ADDF File Offset: 0x00148FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnit.Descriptor;
			}
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x0014ADE6 File Offset: 0x00148FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit()
		{
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x0014ADFC File Offset: 0x00148FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit(FloroRanchPlayUnit other) : this()
		{
			this.playIncId_ = other.playIncId_;
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.point_ = other.point_;
			this.startStage_ = other.startStage_;
			this.startDay_ = other.startDay_;
			this.tagId_ = other.tagId_;
			this.buffList_ = other.buffList_.Clone();
			this.num_ = other.num_;
			this.extraSalary_ = other.extraSalary_;
			this.removeCost_ = other.removeCost_;
			this.evolveData_ = ((other.evolveData_ != null) ? other.evolveData_.Clone() : null);
			this.sKillData_ = ((other.sKillData_ != null) ? other.sKillData_.Clone() : null);
			this.salary_ = other.salary_;
			this.toyLv_ = other.toyLv_;
			this.selfDefineValue_ = ((other.selfDefineValue_ != null) ? other.selfDefineValue_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x0014AF15 File Offset: 0x00149115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Clone()
		{
			return new FloroRanchPlayUnit(this);
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x0014AF1D File Offset: 0x0014911D
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x0014AF25 File Offset: 0x00149125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayIncId
		{
			get
			{
				return this.playIncId_;
			}
			set
			{
				this.playIncId_ = value;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x0014AF2E File Offset: 0x0014912E
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x0014AF36 File Offset: 0x00149136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchActionUnitType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x0014AF3F File Offset: 0x0014913F
		// (set) Token: 0x060088BC RID: 35004 RVA: 0x0014AF47 File Offset: 0x00149147
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x0014AF50 File Offset: 0x00149150
		// (set) Token: 0x060088BE RID: 35006 RVA: 0x0014AF58 File Offset: 0x00149158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x0014AF61 File Offset: 0x00149161
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x0014AF69 File Offset: 0x00149169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartStage
		{
			get
			{
				return this.startStage_;
			}
			set
			{
				this.startStage_ = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x0014AF72 File Offset: 0x00149172
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x0014AF7A File Offset: 0x0014917A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartDay
		{
			get
			{
				return this.startDay_;
			}
			set
			{
				this.startDay_ = value;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x0014AF83 File Offset: 0x00149183
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x0014AF8B File Offset: 0x0014918B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x0014AF94 File Offset: 0x00149194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060088C6 RID: 35014 RVA: 0x0014AF9C File Offset: 0x0014919C
		// (set) Token: 0x060088C7 RID: 35015 RVA: 0x0014AFA4 File Offset: 0x001491A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060088C8 RID: 35016 RVA: 0x0014AFAD File Offset: 0x001491AD
		// (set) Token: 0x060088C9 RID: 35017 RVA: 0x0014AFB5 File Offset: 0x001491B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExtraSalary
		{
			get
			{
				return this.extraSalary_;
			}
			set
			{
				this.extraSalary_ = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060088CA RID: 35018 RVA: 0x0014AFBE File Offset: 0x001491BE
		// (set) Token: 0x060088CB RID: 35019 RVA: 0x0014AFC6 File Offset: 0x001491C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemoveCost
		{
			get
			{
				return this.removeCost_;
			}
			set
			{
				this.removeCost_ = value;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060088CC RID: 35020 RVA: 0x0014AFCF File Offset: 0x001491CF
		// (set) Token: 0x060088CD RID: 35021 RVA: 0x0014AFD7 File Offset: 0x001491D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData EvolveData
		{
			get
			{
				return this.evolveData_;
			}
			set
			{
				this.evolveData_ = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060088CE RID: 35022 RVA: 0x0014AFE0 File Offset: 0x001491E0
		// (set) Token: 0x060088CF RID: 35023 RVA: 0x0014AFE8 File Offset: 0x001491E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData SKillData
		{
			get
			{
				return this.sKillData_;
			}
			set
			{
				this.sKillData_ = value;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060088D0 RID: 35024 RVA: 0x0014AFF1 File Offset: 0x001491F1
		// (set) Token: 0x060088D1 RID: 35025 RVA: 0x0014AFF9 File Offset: 0x001491F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Salary
		{
			get
			{
				return this.salary_;
			}
			set
			{
				this.salary_ = value;
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060088D2 RID: 35026 RVA: 0x0014B002 File Offset: 0x00149202
		// (set) Token: 0x060088D3 RID: 35027 RVA: 0x0014B00A File Offset: 0x0014920A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ToyLv
		{
			get
			{
				return this.toyLv_;
			}
			set
			{
				this.toyLv_ = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060088D4 RID: 35028 RVA: 0x0014B013 File Offset: 0x00149213
		// (set) Token: 0x060088D5 RID: 35029 RVA: 0x0014B01B File Offset: 0x0014921B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionSelfDefineValue SelfDefineValue
		{
			get
			{
				return this.selfDefineValue_;
			}
			set
			{
				this.selfDefineValue_ = value;
			}
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x0014B024 File Offset: 0x00149224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnit);
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x0014B034 File Offset: 0x00149234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnit other)
		{
			return other != null && (other == this || (this.PlayIncId == other.PlayIncId && this.Type == other.Type && this.Id == other.Id && this.Point == other.Point && this.StartStage == other.StartStage && this.StartDay == other.StartDay && this.TagId == other.TagId && this.buffList_.Equals(other.buffList_) && this.Num == other.Num && this.ExtraSalary == other.ExtraSalary && this.RemoveCost == other.RemoveCost && object.Equals(this.EvolveData, other.EvolveData) && object.Equals(this.SKillData, other.SKillData) && this.Salary == other.Salary && this.ToyLv == other.ToyLv && object.Equals(this.SelfDefineValue, other.SelfDefineValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x0014B174 File Offset: 0x00149374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayIncId != 0)
			{
				num ^= this.PlayIncId.GetHashCode();
			}
			if (this.Type != FloroRanchActionUnitType.Terrain)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.StartStage != 0)
			{
				num ^= this.StartStage.GetHashCode();
			}
			if (this.StartDay != 0)
			{
				num ^= this.StartDay.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.ExtraSalary != 0L)
			{
				num ^= this.ExtraSalary.GetHashCode();
			}
			if (this.RemoveCost != 0)
			{
				num ^= this.RemoveCost.GetHashCode();
			}
			if (this.evolveData_ != null)
			{
				num ^= this.EvolveData.GetHashCode();
			}
			if (this.sKillData_ != null)
			{
				num ^= this.SKillData.GetHashCode();
			}
			if (this.Salary != 0L)
			{
				num ^= this.Salary.GetHashCode();
			}
			if (this.ToyLv != 0L)
			{
				num ^= this.ToyLv.GetHashCode();
			}
			if (this.selfDefineValue_ != null)
			{
				num ^= this.SelfDefineValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0014B31C File Offset: 0x0014951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x0014B329 File Offset: 0x00149529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x0014B334 File Offset: 0x00149534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayIncId);
			}
			if (this.Type != FloroRanchActionUnitType.Terrain)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Point);
			}
			if (this.StartStage != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.StartStage);
			}
			if (this.StartDay != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StartDay);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TagId);
			}
			this.buffList_.WriteTo(ref output, FloroRanchPlayUnit._repeated_buffList_codec);
			if (this.Num != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Num);
			}
			if (this.ExtraSalary != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.ExtraSalary);
			}
			if (this.RemoveCost != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RemoveCost);
			}
			if (this.evolveData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EvolveData);
			}
			if (this.sKillData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SKillData);
			}
			if (this.Salary != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Salary);
			}
			if (this.ToyLv != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ToyLv);
			}
			if (this.selfDefineValue_ != null)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.SelfDefineValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x0014B510 File Offset: 0x00149710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayIncId);
			}
			if (this.Type != FloroRanchActionUnitType.Terrain)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.StartStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartStage);
			}
			if (this.StartDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartDay);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			num += this.buffList_.CalculateSize(FloroRanchPlayUnit._repeated_buffList_codec);
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.ExtraSalary != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExtraSalary);
			}
			if (this.RemoveCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemoveCost);
			}
			if (this.evolveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EvolveData);
			}
			if (this.sKillData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SKillData);
			}
			if (this.Salary != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Salary);
			}
			if (this.ToyLv != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ToyLv);
			}
			if (this.selfDefineValue_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SelfDefineValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0014B6B4 File Offset: 0x001498B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayUnit other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayIncId != 0)
			{
				this.PlayIncId = other.PlayIncId;
			}
			if (other.Type != FloroRanchActionUnitType.Terrain)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.StartStage != 0)
			{
				this.StartStage = other.StartStage;
			}
			if (other.StartDay != 0)
			{
				this.StartDay = other.StartDay;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			this.buffList_.Add(other.buffList_);
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.ExtraSalary != 0L)
			{
				this.ExtraSalary = other.ExtraSalary;
			}
			if (other.RemoveCost != 0)
			{
				this.RemoveCost = other.RemoveCost;
			}
			if (other.evolveData_ != null)
			{
				if (this.evolveData_ == null)
				{
					this.EvolveData = new FREvolveData();
				}
				this.EvolveData.MergeFrom(other.EvolveData);
			}
			if (other.sKillData_ != null)
			{
				if (this.sKillData_ == null)
				{
					this.SKillData = new FRSkillData();
				}
				this.SKillData.MergeFrom(other.SKillData);
			}
			if (other.Salary != 0L)
			{
				this.Salary = other.Salary;
			}
			if (other.ToyLv != 0L)
			{
				this.ToyLv = other.ToyLv;
			}
			if (other.selfDefineValue_ != null)
			{
				if (this.selfDefineValue_ == null)
				{
					this.SelfDefineValue = new FRActionSelfDefineValue();
				}
				this.SelfDefineValue.MergeFrom(other.SelfDefineValue);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0014B861 File Offset: 0x00149A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x0014B86C File Offset: 0x00149A6C
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.PlayIncId = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.Type = (FloroRanchActionUnitType)input.ReadEnum();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.Point = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.StartStage = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.StartDay = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.TagId = input.ReadInt32();
							continue;
						}
						if (num == 66U)
						{
							this.buffList_.AddEntriesFrom(ref input, FloroRanchPlayUnit._repeated_buffList_codec);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 80U)
					{
						if (num == 72U)
						{
							this.Num = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.ExtraSalary = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.RemoveCost = input.ReadInt32();
							continue;
						}
						if (num == 98U)
						{
							if (this.evolveData_ == null)
							{
								this.EvolveData = new FREvolveData();
							}
							input.ReadMessage(this.EvolveData);
							continue;
						}
					}
				}
				else if (num <= 112U)
				{
					if (num == 106U)
					{
						if (this.sKillData_ == null)
						{
							this.SKillData = new FRSkillData();
						}
						input.ReadMessage(this.SKillData);
						continue;
					}
					if (num == 112U)
					{
						this.Salary = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.ToyLv = input.ReadInt64();
						continue;
					}
					if (num == 130U)
					{
						if (this.selfDefineValue_ == null)
						{
							this.SelfDefineValue = new FRActionSelfDefineValue();
						}
						input.ReadMessage(this.SelfDefineValue);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043CB RID: 17355
		private static readonly MessageParser<FloroRanchPlayUnit> _parser = new MessageParser<FloroRanchPlayUnit>(() => new FloroRanchPlayUnit());

		// Token: 0x040043CC RID: 17356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043CD RID: 17357
		public const int PlayIncIdFieldNumber = 1;

		// Token: 0x040043CE RID: 17358
		private int playIncId_;

		// Token: 0x040043CF RID: 17359
		public const int TypeFieldNumber = 2;

		// Token: 0x040043D0 RID: 17360
		private FloroRanchActionUnitType type_;

		// Token: 0x040043D1 RID: 17361
		public const int IdFieldNumber = 3;

		// Token: 0x040043D2 RID: 17362
		private int id_;

		// Token: 0x040043D3 RID: 17363
		public const int PointFieldNumber = 4;

		// Token: 0x040043D4 RID: 17364
		private int point_;

		// Token: 0x040043D5 RID: 17365
		public const int StartStageFieldNumber = 5;

		// Token: 0x040043D6 RID: 17366
		private int startStage_;

		// Token: 0x040043D7 RID: 17367
		public const int StartDayFieldNumber = 6;

		// Token: 0x040043D8 RID: 17368
		private int startDay_;

		// Token: 0x040043D9 RID: 17369
		public const int TagIdFieldNumber = 7;

		// Token: 0x040043DA RID: 17370
		private int tagId_;

		// Token: 0x040043DB RID: 17371
		public const int BuffListFieldNumber = 8;

		// Token: 0x040043DC RID: 17372
		private static readonly FieldCodec<FloroRanchPlayBuff> _repeated_buffList_codec = FieldCodec.ForMessage<FloroRanchPlayBuff>(66U, FloroRanchPlayBuff.Parser);

		// Token: 0x040043DD RID: 17373
		private readonly RepeatedField<FloroRanchPlayBuff> buffList_ = new RepeatedField<FloroRanchPlayBuff>();

		// Token: 0x040043DE RID: 17374
		public const int NumFieldNumber = 9;

		// Token: 0x040043DF RID: 17375
		private int num_;

		// Token: 0x040043E0 RID: 17376
		public const int ExtraSalaryFieldNumber = 10;

		// Token: 0x040043E1 RID: 17377
		private long extraSalary_;

		// Token: 0x040043E2 RID: 17378
		public const int RemoveCostFieldNumber = 11;

		// Token: 0x040043E3 RID: 17379
		private int removeCost_;

		// Token: 0x040043E4 RID: 17380
		public const int EvolveDataFieldNumber = 12;

		// Token: 0x040043E5 RID: 17381
		private FREvolveData evolveData_;

		// Token: 0x040043E6 RID: 17382
		public const int SKillDataFieldNumber = 13;

		// Token: 0x040043E7 RID: 17383
		private FRSkillData sKillData_;

		// Token: 0x040043E8 RID: 17384
		public const int SalaryFieldNumber = 14;

		// Token: 0x040043E9 RID: 17385
		private long salary_;

		// Token: 0x040043EA RID: 17386
		public const int ToyLvFieldNumber = 15;

		// Token: 0x040043EB RID: 17387
		private long toyLv_;

		// Token: 0x040043EC RID: 17388
		public const int SelfDefineValueFieldNumber = 16;

		// Token: 0x040043ED RID: 17389
		private FRActionSelfDefineValue selfDefineValue_;
	}
}
