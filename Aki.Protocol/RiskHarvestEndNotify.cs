using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4C RID: 3916
	[NetMessage(EMessageId.RiskHarvestEndNotify)]
	public sealed class RiskHarvestEndNotify : IMessage<RiskHarvestEndNotify>, IMessage, IEquatable<RiskHarvestEndNotify>, IDeepCloneable<RiskHarvestEndNotify>, IBufferMessage
	{
		// Token: 0x06014F8C RID: 85900 RVA: 0x0030B54D File Offset: 0x0030974D
		[NullableContext(1)]
		public static RiskHarvestEndNotify Create()
		{
			return new RiskHarvestEndNotify();
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x06014F8D RID: 85901 RVA: 0x0030B554 File Offset: 0x00309754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x06014F8E RID: 85902 RVA: 0x0030B557 File Offset: 0x00309757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestEndNotify.Descriptor;
			}
		}

		// Token: 0x06014F8F RID: 85903 RVA: 0x0030B55E File Offset: 0x0030975E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestEndNotify()
		{
		}

		// Token: 0x06014F90 RID: 85904 RVA: 0x0030B568 File Offset: 0x00309768
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

		// Token: 0x06014F91 RID: 85905 RVA: 0x0030B5D4 File Offset: 0x003097D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestEndNotify Clone()
		{
			return new RiskHarvestEndNotify(this);
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x06014F92 RID: 85906 RVA: 0x0030B5DC File Offset: 0x003097DC
		// (set) Token: 0x06014F93 RID: 85907 RVA: 0x0030B5E4 File Offset: 0x003097E4
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

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x06014F94 RID: 85908 RVA: 0x0030B5ED File Offset: 0x003097ED
		// (set) Token: 0x06014F95 RID: 85909 RVA: 0x0030B5F5 File Offset: 0x003097F5
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

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x06014F96 RID: 85910 RVA: 0x0030B5FE File Offset: 0x003097FE
		// (set) Token: 0x06014F97 RID: 85911 RVA: 0x0030B606 File Offset: 0x00309806
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

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x06014F98 RID: 85912 RVA: 0x0030B60F File Offset: 0x0030980F
		// (set) Token: 0x06014F99 RID: 85913 RVA: 0x0030B617 File Offset: 0x00309817
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

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x06014F9A RID: 85914 RVA: 0x0030B620 File Offset: 0x00309820
		// (set) Token: 0x06014F9B RID: 85915 RVA: 0x0030B628 File Offset: 0x00309828
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

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x06014F9C RID: 85916 RVA: 0x0030B631 File Offset: 0x00309831
		// (set) Token: 0x06014F9D RID: 85917 RVA: 0x0030B639 File Offset: 0x00309839
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

		// Token: 0x06014F9E RID: 85918 RVA: 0x0030B642 File Offset: 0x00309842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestEndNotify);
		}

		// Token: 0x06014F9F RID: 85919 RVA: 0x0030B650 File Offset: 0x00309850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestEndNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TotalScore == other.TotalScore && this.TimeScore == other.TimeScore && this.MonsterScore == other.MonsterScore && this.Pass == other.Pass && this.InstScore == other.InstScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FA0 RID: 85920 RVA: 0x0030B6DC File Offset: 0x003098DC
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

		// Token: 0x06014FA1 RID: 85921 RVA: 0x0030B798 File Offset: 0x00309998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FA2 RID: 85922 RVA: 0x0030B7A5 File Offset: 0x003099A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FA3 RID: 85923 RVA: 0x0030B7B0 File Offset: 0x003099B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MonsterScore);
			}
			if (this.Pass)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Pass);
			}
			if (this.TimeScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TimeScore);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TotalScore);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
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

		// Token: 0x06014FA4 RID: 85924 RVA: 0x0030B87C File Offset: 0x00309A7C
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

		// Token: 0x06014FA5 RID: 85925 RVA: 0x0030B928 File Offset: 0x00309B28
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

		// Token: 0x06014FA6 RID: 85926 RVA: 0x0030B9C8 File Offset: 0x00309BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FA7 RID: 85927 RVA: 0x0030B9D4 File Offset: 0x00309BD4
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.MonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Pass = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.TimeScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Id = input.ReadInt32();
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

		// Token: 0x04007ED6 RID: 32470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ED7 RID: 32471
		public const int IdFieldNumber = 12;

		// Token: 0x04007ED8 RID: 32472
		private int id_;

		// Token: 0x04007ED9 RID: 32473
		public const int TotalScoreFieldNumber = 10;

		// Token: 0x04007EDA RID: 32474
		private int totalScore_;

		// Token: 0x04007EDB RID: 32475
		public const int TimeScoreFieldNumber = 7;

		// Token: 0x04007EDC RID: 32476
		private int timeScore_;

		// Token: 0x04007EDD RID: 32477
		public const int MonsterScoreFieldNumber = 2;

		// Token: 0x04007EDE RID: 32478
		private int monsterScore_;

		// Token: 0x04007EDF RID: 32479
		public const int PassFieldNumber = 5;

		// Token: 0x04007EE0 RID: 32480
		private bool pass_;

		// Token: 0x04007EE1 RID: 32481
		public const int InstScoreFieldNumber = 15;

		// Token: 0x04007EE2 RID: 32482
		private int instScore_;
	}
}
