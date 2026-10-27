using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D55 RID: 3413
	public sealed class PinballRankData : IMessage<PinballRankData>, IMessage, IEquatable<PinballRankData>, IDeepCloneable<PinballRankData>, IBufferMessage
	{
		// Token: 0x06012688 RID: 75400 RVA: 0x002AFA11 File Offset: 0x002ADC11
		[NullableContext(1)]
		public static PinballRankData Create()
		{
			return new PinballRankData();
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x06012689 RID: 75401 RVA: 0x002AFA18 File Offset: 0x002ADC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballRankData> Parser
		{
			get
			{
				return PinballRankData._parser;
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0601268A RID: 75402 RVA: 0x002AFA1F File Offset: 0x002ADC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0601268B RID: 75403 RVA: 0x002AFA22 File Offset: 0x002ADC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRankData.Descriptor;
			}
		}

		// Token: 0x0601268C RID: 75404 RVA: 0x002AFA29 File Offset: 0x002ADC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData()
		{
		}

		// Token: 0x0601268D RID: 75405 RVA: 0x002AFA48 File Offset: 0x002ADC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData(PinballRankData other) : this()
		{
			this.name_ = other.name_;
			this.towerLevel_ = other.towerLevel_;
			this.costTime_ = other.costTime_;
			this.formation_ = other.formation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601268E RID: 75406 RVA: 0x002AFAA1 File Offset: 0x002ADCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData Clone()
		{
			return new PinballRankData(this);
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0601268F RID: 75407 RVA: 0x002AFAA9 File Offset: 0x002ADCA9
		// (set) Token: 0x06012690 RID: 75408 RVA: 0x002AFAB1 File Offset: 0x002ADCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x06012691 RID: 75409 RVA: 0x002AFAC4 File Offset: 0x002ADCC4
		// (set) Token: 0x06012692 RID: 75410 RVA: 0x002AFACC File Offset: 0x002ADCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerLevel
		{
			get
			{
				return this.towerLevel_;
			}
			set
			{
				this.towerLevel_ = value;
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x06012693 RID: 75411 RVA: 0x002AFAD5 File Offset: 0x002ADCD5
		// (set) Token: 0x06012694 RID: 75412 RVA: 0x002AFADD File Offset: 0x002ADCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x06012695 RID: 75413 RVA: 0x002AFAE6 File Offset: 0x002ADCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRoleData> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x06012696 RID: 75414 RVA: 0x002AFAEE File Offset: 0x002ADCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRankData);
		}

		// Token: 0x06012697 RID: 75415 RVA: 0x002AFAFC File Offset: 0x002ADCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRankData other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.TowerLevel == other.TowerLevel && this.CostTime == other.CostTime && this.formation_.Equals(other.formation_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012698 RID: 75416 RVA: 0x002AFB70 File Offset: 0x002ADD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.TowerLevel != 0)
			{
				num ^= this.TowerLevel.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			num ^= this.formation_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012699 RID: 75417 RVA: 0x002AFBF1 File Offset: 0x002ADDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601269A RID: 75418 RVA: 0x002AFBFE File Offset: 0x002ADDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601269B RID: 75419 RVA: 0x002AFC08 File Offset: 0x002ADE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.TowerLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TowerLevel);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CostTime);
			}
			this.formation_.WriteTo(ref output, PinballRankData._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601269C RID: 75420 RVA: 0x002AFC94 File Offset: 0x002ADE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.TowerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerLevel);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			num += this.formation_.CalculateSize(PinballRankData._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601269D RID: 75421 RVA: 0x002AFD1C File Offset: 0x002ADF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRankData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.TowerLevel != 0)
			{
				this.TowerLevel = other.TowerLevel;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			this.formation_.Add(other.formation_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601269E RID: 75422 RVA: 0x002AFD96 File Offset: 0x002ADF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601269F RID: 75423 RVA: 0x002AFDA0 File Offset: 0x002ADFA0
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.TowerLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CostTime = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.formation_.AddEntriesFrom(ref input, PinballRankData._repeated_formation_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007293 RID: 29331
		private static readonly MessageParser<PinballRankData> _parser = new MessageParser<PinballRankData>(() => new PinballRankData());

		// Token: 0x04007294 RID: 29332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007295 RID: 29333
		public const int NameFieldNumber = 1;

		// Token: 0x04007296 RID: 29334
		private string name_ = "";

		// Token: 0x04007297 RID: 29335
		public const int TowerLevelFieldNumber = 2;

		// Token: 0x04007298 RID: 29336
		private int towerLevel_;

		// Token: 0x04007299 RID: 29337
		public const int CostTimeFieldNumber = 3;

		// Token: 0x0400729A RID: 29338
		private int costTime_;

		// Token: 0x0400729B RID: 29339
		public const int FormationFieldNumber = 4;

		// Token: 0x0400729C RID: 29340
		private static readonly FieldCodec<PinballRoleData> _repeated_formation_codec = FieldCodec.ForMessage<PinballRoleData>(34U, PinballRoleData.Parser);

		// Token: 0x0400729D RID: 29341
		private readonly RepeatedField<PinballRoleData> formation_ = new RepeatedField<PinballRoleData>();
	}
}
