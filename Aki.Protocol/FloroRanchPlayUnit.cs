using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D5 RID: 1493
	public sealed class FloroRanchPlayUnit : IMessage<FloroRanchPlayUnit>, IMessage, IEquatable<FloroRanchPlayUnit>, IDeepCloneable<FloroRanchPlayUnit>, IBufferMessage
	{
		// Token: 0x06008A18 RID: 35352 RVA: 0x0014D9EB File Offset: 0x0014BBEB
		[NullableContext(1)]
		public static FloroRanchPlayUnit Create()
		{
			return new FloroRanchPlayUnit();
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06008A19 RID: 35353 RVA: 0x0014D9F2 File Offset: 0x0014BBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchPlayUnit> Parser
		{
			get
			{
				return FloroRanchPlayUnit._parser;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06008A1A RID: 35354 RVA: 0x0014D9F9 File Offset: 0x0014BBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x0014D9FC File Offset: 0x0014BBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnit.Descriptor;
			}
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x0014DA03 File Offset: 0x0014BC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit()
		{
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x0014DA18 File Offset: 0x0014BC18
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

		// Token: 0x06008A1E RID: 35358 RVA: 0x0014DB31 File Offset: 0x0014BD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Clone()
		{
			return new FloroRanchPlayUnit(this);
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0014DB39 File Offset: 0x0014BD39
		// (set) Token: 0x06008A20 RID: 35360 RVA: 0x0014DB41 File Offset: 0x0014BD41
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06008A21 RID: 35361 RVA: 0x0014DB4A File Offset: 0x0014BD4A
		// (set) Token: 0x06008A22 RID: 35362 RVA: 0x0014DB52 File Offset: 0x0014BD52
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

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x0014DB5B File Offset: 0x0014BD5B
		// (set) Token: 0x06008A24 RID: 35364 RVA: 0x0014DB63 File Offset: 0x0014BD63
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

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x0014DB6C File Offset: 0x0014BD6C
		// (set) Token: 0x06008A26 RID: 35366 RVA: 0x0014DB74 File Offset: 0x0014BD74
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x0014DB7D File Offset: 0x0014BD7D
		// (set) Token: 0x06008A28 RID: 35368 RVA: 0x0014DB85 File Offset: 0x0014BD85
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06008A29 RID: 35369 RVA: 0x0014DB8E File Offset: 0x0014BD8E
		// (set) Token: 0x06008A2A RID: 35370 RVA: 0x0014DB96 File Offset: 0x0014BD96
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

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06008A2B RID: 35371 RVA: 0x0014DB9F File Offset: 0x0014BD9F
		// (set) Token: 0x06008A2C RID: 35372 RVA: 0x0014DBA7 File Offset: 0x0014BDA7
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x0014DBB0 File Offset: 0x0014BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayBuff> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06008A2E RID: 35374 RVA: 0x0014DBB8 File Offset: 0x0014BDB8
		// (set) Token: 0x06008A2F RID: 35375 RVA: 0x0014DBC0 File Offset: 0x0014BDC0
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06008A30 RID: 35376 RVA: 0x0014DBC9 File Offset: 0x0014BDC9
		// (set) Token: 0x06008A31 RID: 35377 RVA: 0x0014DBD1 File Offset: 0x0014BDD1
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06008A32 RID: 35378 RVA: 0x0014DBDA File Offset: 0x0014BDDA
		// (set) Token: 0x06008A33 RID: 35379 RVA: 0x0014DBE2 File Offset: 0x0014BDE2
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x0014DBEB File Offset: 0x0014BDEB
		// (set) Token: 0x06008A35 RID: 35381 RVA: 0x0014DBF3 File Offset: 0x0014BDF3
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06008A36 RID: 35382 RVA: 0x0014DBFC File Offset: 0x0014BDFC
		// (set) Token: 0x06008A37 RID: 35383 RVA: 0x0014DC04 File Offset: 0x0014BE04
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06008A38 RID: 35384 RVA: 0x0014DC0D File Offset: 0x0014BE0D
		// (set) Token: 0x06008A39 RID: 35385 RVA: 0x0014DC15 File Offset: 0x0014BE15
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06008A3A RID: 35386 RVA: 0x0014DC1E File Offset: 0x0014BE1E
		// (set) Token: 0x06008A3B RID: 35387 RVA: 0x0014DC26 File Offset: 0x0014BE26
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

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x0014DC2F File Offset: 0x0014BE2F
		// (set) Token: 0x06008A3D RID: 35389 RVA: 0x0014DC37 File Offset: 0x0014BE37
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

		// Token: 0x06008A3E RID: 35390 RVA: 0x0014DC40 File Offset: 0x0014BE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnit);
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x0014DC50 File Offset: 0x0014BE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnit other)
		{
			return other != null && (other == this || (this.PlayIncId == other.PlayIncId && this.Type == other.Type && this.Id == other.Id && this.Point == other.Point && this.StartStage == other.StartStage && this.StartDay == other.StartDay && this.TagId == other.TagId && this.buffList_.Equals(other.buffList_) && this.Num == other.Num && this.ExtraSalary == other.ExtraSalary && this.RemoveCost == other.RemoveCost && object.Equals(this.EvolveData, other.EvolveData) && object.Equals(this.SKillData, other.SKillData) && this.Salary == other.Salary && this.ToyLv == other.ToyLv && object.Equals(this.SelfDefineValue, other.SelfDefineValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x0014DD90 File Offset: 0x0014BF90
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

		// Token: 0x06008A41 RID: 35393 RVA: 0x0014DF38 File Offset: 0x0014C138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x0014DF45 File Offset: 0x0014C145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x0014DF50 File Offset: 0x0014C150
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

		// Token: 0x06008A44 RID: 35396 RVA: 0x0014E12C File Offset: 0x0014C32C
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

		// Token: 0x06008A45 RID: 35397 RVA: 0x0014E2D0 File Offset: 0x0014C4D0
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

		// Token: 0x06008A46 RID: 35398 RVA: 0x0014E47D File Offset: 0x0014C67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x0014E488 File Offset: 0x0014C688
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

		// Token: 0x040043D5 RID: 17365
		private static readonly MessageParser<FloroRanchPlayUnit> _parser = new MessageParser<FloroRanchPlayUnit>(() => new FloroRanchPlayUnit());

		// Token: 0x040043D6 RID: 17366
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043D7 RID: 17367
		public const int PlayIncIdFieldNumber = 1;

		// Token: 0x040043D8 RID: 17368
		private int playIncId_;

		// Token: 0x040043D9 RID: 17369
		public const int TypeFieldNumber = 2;

		// Token: 0x040043DA RID: 17370
		private FloroRanchActionUnitType type_;

		// Token: 0x040043DB RID: 17371
		public const int IdFieldNumber = 3;

		// Token: 0x040043DC RID: 17372
		private int id_;

		// Token: 0x040043DD RID: 17373
		public const int PointFieldNumber = 4;

		// Token: 0x040043DE RID: 17374
		private int point_;

		// Token: 0x040043DF RID: 17375
		public const int StartStageFieldNumber = 5;

		// Token: 0x040043E0 RID: 17376
		private int startStage_;

		// Token: 0x040043E1 RID: 17377
		public const int StartDayFieldNumber = 6;

		// Token: 0x040043E2 RID: 17378
		private int startDay_;

		// Token: 0x040043E3 RID: 17379
		public const int TagIdFieldNumber = 7;

		// Token: 0x040043E4 RID: 17380
		private int tagId_;

		// Token: 0x040043E5 RID: 17381
		public const int BuffListFieldNumber = 8;

		// Token: 0x040043E6 RID: 17382
		private static readonly FieldCodec<FloroRanchPlayBuff> _repeated_buffList_codec = FieldCodec.ForMessage<FloroRanchPlayBuff>(66U, FloroRanchPlayBuff.Parser);

		// Token: 0x040043E7 RID: 17383
		private readonly RepeatedField<FloroRanchPlayBuff> buffList_ = new RepeatedField<FloroRanchPlayBuff>();

		// Token: 0x040043E8 RID: 17384
		public const int NumFieldNumber = 9;

		// Token: 0x040043E9 RID: 17385
		private int num_;

		// Token: 0x040043EA RID: 17386
		public const int ExtraSalaryFieldNumber = 10;

		// Token: 0x040043EB RID: 17387
		private long extraSalary_;

		// Token: 0x040043EC RID: 17388
		public const int RemoveCostFieldNumber = 11;

		// Token: 0x040043ED RID: 17389
		private int removeCost_;

		// Token: 0x040043EE RID: 17390
		public const int EvolveDataFieldNumber = 12;

		// Token: 0x040043EF RID: 17391
		private FREvolveData evolveData_;

		// Token: 0x040043F0 RID: 17392
		public const int SKillDataFieldNumber = 13;

		// Token: 0x040043F1 RID: 17393
		private FRSkillData sKillData_;

		// Token: 0x040043F2 RID: 17394
		public const int SalaryFieldNumber = 14;

		// Token: 0x040043F3 RID: 17395
		private long salary_;

		// Token: 0x040043F4 RID: 17396
		public const int ToyLvFieldNumber = 15;

		// Token: 0x040043F5 RID: 17397
		private long toyLv_;

		// Token: 0x040043F6 RID: 17398
		public const int SelfDefineValueFieldNumber = 16;

		// Token: 0x040043F7 RID: 17399
		private FRActionSelfDefineValue selfDefineValue_;
	}
}
