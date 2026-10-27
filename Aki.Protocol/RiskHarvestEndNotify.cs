using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5C RID: 3932
	[NetMessage(EMessageId.RiskHarvestEndNotify)]
	public sealed class RiskHarvestEndNotify : IMessage<RiskHarvestEndNotify>, IMessage, IEquatable<RiskHarvestEndNotify>, IDeepCloneable<RiskHarvestEndNotify>, IBufferMessage
	{
		// Token: 0x06015071 RID: 86129 RVA: 0x0030CC05 File Offset: 0x0030AE05
		[NullableContext(1)]
		public static RiskHarvestEndNotify Create()
		{
			return new RiskHarvestEndNotify();
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x06015072 RID: 86130 RVA: 0x0030CC0C File Offset: 0x0030AE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x06015073 RID: 86131 RVA: 0x0030CC0F File Offset: 0x0030AE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestEndNotify.Descriptor;
			}
		}

		// Token: 0x06015074 RID: 86132 RVA: 0x0030CC16 File Offset: 0x0030AE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestEndNotify()
		{
		}

		// Token: 0x06015075 RID: 86133 RVA: 0x0030CC20 File Offset: 0x0030AE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestEndNotify(RiskHarvestEndNotify other) : this()
		{
			this.id_ = other.id_;
			this.totalScore_ = other.totalScore_;
			this.timeScore_ = other.timeScore_;
			this.monsterScore_ = other.monsterScore_;
			this.pass_ = other.pass_;
			this.instScore_ = other.instScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015076 RID: 86134 RVA: 0x0030CC8C File Offset: 0x0030AE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestEndNotify Clone()
		{
			return new RiskHarvestEndNotify(this);
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x06015077 RID: 86135 RVA: 0x0030CC94 File Offset: 0x0030AE94
		// (set) Token: 0x06015078 RID: 86136 RVA: 0x0030CC9C File Offset: 0x0030AE9C
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

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x06015079 RID: 86137 RVA: 0x0030CCA5 File Offset: 0x0030AEA5
		// (set) Token: 0x0601507A RID: 86138 RVA: 0x0030CCAD File Offset: 0x0030AEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x0601507B RID: 86139 RVA: 0x0030CCB6 File Offset: 0x0030AEB6
		// (set) Token: 0x0601507C RID: 86140 RVA: 0x0030CCBE File Offset: 0x0030AEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeScore
		{
			get
			{
				return this.timeScore_;
			}
			set
			{
				this.timeScore_ = value;
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x0601507D RID: 86141 RVA: 0x0030CCC7 File Offset: 0x0030AEC7
		// (set) Token: 0x0601507E RID: 86142 RVA: 0x0030CCCF File Offset: 0x0030AECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterScore
		{
			get
			{
				return this.monsterScore_;
			}
			set
			{
				this.monsterScore_ = value;
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x0601507F RID: 86143 RVA: 0x0030CCD8 File Offset: 0x0030AED8
		// (set) Token: 0x06015080 RID: 86144 RVA: 0x0030CCE0 File Offset: 0x0030AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Pass
		{
			get
			{
				return this.pass_;
			}
			set
			{
				this.pass_ = value;
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x06015081 RID: 86145 RVA: 0x0030CCE9 File Offset: 0x0030AEE9
		// (set) Token: 0x06015082 RID: 86146 RVA: 0x0030CCF1 File Offset: 0x0030AEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstScore
		{
			get
			{
				return this.instScore_;
			}
			set
			{
				this.instScore_ = value;
			}
		}

		// Token: 0x06015083 RID: 86147 RVA: 0x0030CCFA File Offset: 0x0030AEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestEndNotify);
		}

		// Token: 0x06015084 RID: 86148 RVA: 0x0030CD08 File Offset: 0x0030AF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestEndNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TotalScore == other.TotalScore && this.TimeScore == other.TimeScore && this.MonsterScore == other.MonsterScore && this.Pass == other.Pass && this.InstScore == other.InstScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015085 RID: 86149 RVA: 0x0030CD94 File Offset: 0x0030AF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this.TimeScore != 0)
			{
				num ^= this.TimeScore.GetHashCode();
			}
			if (this.MonsterScore != 0)
			{
				num ^= this.MonsterScore.GetHashCode();
			}
			if (this.Pass)
			{
				num ^= this.Pass.GetHashCode();
			}
			if (this.InstScore != 0)
			{
				num ^= this.InstScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015086 RID: 86150 RVA: 0x0030CE50 File Offset: 0x0030B050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015087 RID: 86151 RVA: 0x0030CE5D File Offset: 0x0030B05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x0030CE68 File Offset: 0x0030B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterScore);
			}
			if (this.TimeScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TimeScore);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TotalScore);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this.Pass)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Pass);
			}
			if (this.InstScore != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x0030CF30 File Offset: 0x0030B130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this.TimeScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeScore);
			}
			if (this.MonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterScore);
			}
			if (this.Pass)
			{
				num += 2;
			}
			if (this.InstScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x0030CFDC File Offset: 0x0030B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			if (other.TimeScore != 0)
			{
				this.TimeScore = other.TimeScore;
			}
			if (other.MonsterScore != 0)
			{
				this.MonsterScore = other.MonsterScore;
			}
			if (other.Pass)
			{
				this.Pass = other.Pass;
			}
			if (other.InstScore != 0)
			{
				this.InstScore = other.InstScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601508B RID: 86155 RVA: 0x0030D07C File Offset: 0x0030B27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x0030D088 File Offset: 0x0030B288
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.MonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TimeScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Pass = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.InstScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007EAC RID: 32428
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EAD RID: 32429
		public const int IdFieldNumber = 12;

		// Token: 0x04007EAE RID: 32430
		private int id_;

		// Token: 0x04007EAF RID: 32431
		public const int TotalScoreFieldNumber = 5;

		// Token: 0x04007EB0 RID: 32432
		private int totalScore_;

		// Token: 0x04007EB1 RID: 32433
		public const int TimeScoreFieldNumber = 4;

		// Token: 0x04007EB2 RID: 32434
		private int timeScore_;

		// Token: 0x04007EB3 RID: 32435
		public const int MonsterScoreFieldNumber = 1;

		// Token: 0x04007EB4 RID: 32436
		private int monsterScore_;

		// Token: 0x04007EB5 RID: 32437
		public const int PassFieldNumber = 14;

		// Token: 0x04007EB6 RID: 32438
		private bool pass_;

		// Token: 0x04007EB7 RID: 32439
		public const int InstScoreFieldNumber = 15;

		// Token: 0x04007EB8 RID: 32440
		private int instScore_;
	}
}
