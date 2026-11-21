using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D45 RID: 3397
	public sealed class PinballRankData : IMessage<PinballRankData>, IMessage, IEquatable<PinballRankData>, IDeepCloneable<PinballRankData>, IBufferMessage
	{
		// Token: 0x0601258C RID: 75148 RVA: 0x002ADDF1 File Offset: 0x002ABFF1
		[NullableContext(1)]
		public static PinballRankData Create()
		{
			return new PinballRankData();
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0601258D RID: 75149 RVA: 0x002ADDF8 File Offset: 0x002ABFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballRankData> Parser
		{
			get
			{
				return PinballRankData._parser;
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0601258E RID: 75150 RVA: 0x002ADDFF File Offset: 0x002ABFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0601258F RID: 75151 RVA: 0x002ADE02 File Offset: 0x002AC002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRankData.Descriptor;
			}
		}

		// Token: 0x06012590 RID: 75152 RVA: 0x002ADE09 File Offset: 0x002AC009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData()
		{
		}

		// Token: 0x06012591 RID: 75153 RVA: 0x002ADE28 File Offset: 0x002AC028
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

		// Token: 0x06012592 RID: 75154 RVA: 0x002ADE81 File Offset: 0x002AC081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData Clone()
		{
			return new PinballRankData(this);
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x06012593 RID: 75155 RVA: 0x002ADE89 File Offset: 0x002AC089
		// (set) Token: 0x06012594 RID: 75156 RVA: 0x002ADE91 File Offset: 0x002AC091
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

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x06012595 RID: 75157 RVA: 0x002ADEA4 File Offset: 0x002AC0A4
		// (set) Token: 0x06012596 RID: 75158 RVA: 0x002ADEAC File Offset: 0x002AC0AC
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

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x06012597 RID: 75159 RVA: 0x002ADEB5 File Offset: 0x002AC0B5
		// (set) Token: 0x06012598 RID: 75160 RVA: 0x002ADEBD File Offset: 0x002AC0BD
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

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x06012599 RID: 75161 RVA: 0x002ADEC6 File Offset: 0x002AC0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRoleData> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x002ADECE File Offset: 0x002AC0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRankData);
		}

		// Token: 0x0601259B RID: 75163 RVA: 0x002ADEDC File Offset: 0x002AC0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRankData other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.TowerLevel == other.TowerLevel && this.CostTime == other.CostTime && this.formation_.Equals(other.formation_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601259C RID: 75164 RVA: 0x002ADF50 File Offset: 0x002AC150
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

		// Token: 0x0601259D RID: 75165 RVA: 0x002ADFD1 File Offset: 0x002AC1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601259E RID: 75166 RVA: 0x002ADFDE File Offset: 0x002AC1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601259F RID: 75167 RVA: 0x002ADFE8 File Offset: 0x002AC1E8
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

		// Token: 0x060125A0 RID: 75168 RVA: 0x002AE074 File Offset: 0x002AC274
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

		// Token: 0x060125A1 RID: 75169 RVA: 0x002AE0FC File Offset: 0x002AC2FC
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

		// Token: 0x060125A2 RID: 75170 RVA: 0x002AE176 File Offset: 0x002AC376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125A3 RID: 75171 RVA: 0x002AE180 File Offset: 0x002AC380
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

		// Token: 0x040072AB RID: 29355
		private static readonly MessageParser<PinballRankData> _parser = new MessageParser<PinballRankData>(() => new PinballRankData());

		// Token: 0x040072AC RID: 29356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072AD RID: 29357
		public const int NameFieldNumber = 1;

		// Token: 0x040072AE RID: 29358
		private string name_ = "";

		// Token: 0x040072AF RID: 29359
		public const int TowerLevelFieldNumber = 2;

		// Token: 0x040072B0 RID: 29360
		private int towerLevel_;

		// Token: 0x040072B1 RID: 29361
		public const int CostTimeFieldNumber = 3;

		// Token: 0x040072B2 RID: 29362
		private int costTime_;

		// Token: 0x040072B3 RID: 29363
		public const int FormationFieldNumber = 4;

		// Token: 0x040072B4 RID: 29364
		private static readonly FieldCodec<PinballRoleData> _repeated_formation_codec = FieldCodec.ForMessage<PinballRoleData>(34U, PinballRoleData.Parser);

		// Token: 0x040072B5 RID: 29365
		private readonly RepeatedField<PinballRoleData> formation_ = new RepeatedField<PinballRoleData>();
	}
}
