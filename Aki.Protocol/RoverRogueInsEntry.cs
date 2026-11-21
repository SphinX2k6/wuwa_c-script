using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001142 RID: 4418
	public sealed class RoverRogueInsEntry : IMessage<RoverRogueInsEntry>, IMessage, IEquatable<RoverRogueInsEntry>, IDeepCloneable<RoverRogueInsEntry>, IBufferMessage
	{
		// Token: 0x060179B1 RID: 96689 RVA: 0x0036F9E8 File Offset: 0x0036DBE8
		[NullableContext(1)]
		public static RoverRogueInsEntry Create()
		{
			return new RoverRogueInsEntry();
		}

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x060179B2 RID: 96690 RVA: 0x0036F9EF File Offset: 0x0036DBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueInsEntry> Parser
		{
			get
			{
				return RoverRogueInsEntry._parser;
			}
		}

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x060179B3 RID: 96691 RVA: 0x0036F9F6 File Offset: 0x0036DBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x060179B4 RID: 96692 RVA: 0x0036F9F9 File Offset: 0x0036DBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsEntry.Descriptor;
			}
		}

		// Token: 0x060179B5 RID: 96693 RVA: 0x0036FA00 File Offset: 0x0036DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsEntry()
		{
		}

		// Token: 0x060179B6 RID: 96694 RVA: 0x0036FA14 File Offset: 0x0036DC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsEntry(RoverRogueInsEntry other) : this()
		{
			this.instId_ = other.instId_;
			this.difficultyName_ = other.difficultyName_;
			this.level_ = other.level_;
			this.expectedTimeMinSec_ = other.expectedTimeMinSec_;
			this.expectedTimeMaxSec_ = other.expectedTimeMaxSec_;
			this.unlocked_ = other.unlocked_;
			this.bestGrade_ = other.bestGrade_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179B7 RID: 96695 RVA: 0x0036FA8C File Offset: 0x0036DC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsEntry Clone()
		{
			return new RoverRogueInsEntry(this);
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x060179B8 RID: 96696 RVA: 0x0036FA94 File Offset: 0x0036DC94
		// (set) Token: 0x060179B9 RID: 96697 RVA: 0x0036FA9C File Offset: 0x0036DC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x060179BA RID: 96698 RVA: 0x0036FAA5 File Offset: 0x0036DCA5
		// (set) Token: 0x060179BB RID: 96699 RVA: 0x0036FAAD File Offset: 0x0036DCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DifficultyName
		{
			get
			{
				return this.difficultyName_;
			}
			set
			{
				this.difficultyName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x060179BC RID: 96700 RVA: 0x0036FAC0 File Offset: 0x0036DCC0
		// (set) Token: 0x060179BD RID: 96701 RVA: 0x0036FAC8 File Offset: 0x0036DCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x060179BE RID: 96702 RVA: 0x0036FAD1 File Offset: 0x0036DCD1
		// (set) Token: 0x060179BF RID: 96703 RVA: 0x0036FAD9 File Offset: 0x0036DCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpectedTimeMinSec
		{
			get
			{
				return this.expectedTimeMinSec_;
			}
			set
			{
				this.expectedTimeMinSec_ = value;
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x060179C0 RID: 96704 RVA: 0x0036FAE2 File Offset: 0x0036DCE2
		// (set) Token: 0x060179C1 RID: 96705 RVA: 0x0036FAEA File Offset: 0x0036DCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpectedTimeMaxSec
		{
			get
			{
				return this.expectedTimeMaxSec_;
			}
			set
			{
				this.expectedTimeMaxSec_ = value;
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x060179C2 RID: 96706 RVA: 0x0036FAF3 File Offset: 0x0036DCF3
		// (set) Token: 0x060179C3 RID: 96707 RVA: 0x0036FAFB File Offset: 0x0036DCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlocked
		{
			get
			{
				return this.unlocked_;
			}
			set
			{
				this.unlocked_ = value;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x060179C4 RID: 96708 RVA: 0x0036FB04 File Offset: 0x0036DD04
		// (set) Token: 0x060179C5 RID: 96709 RVA: 0x0036FB0C File Offset: 0x0036DD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueGrade BestGrade
		{
			get
			{
				return this.bestGrade_;
			}
			set
			{
				this.bestGrade_ = value;
			}
		}

		// Token: 0x060179C6 RID: 96710 RVA: 0x0036FB15 File Offset: 0x0036DD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsEntry);
		}

		// Token: 0x060179C7 RID: 96711 RVA: 0x0036FB24 File Offset: 0x0036DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsEntry other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && !(this.DifficultyName != other.DifficultyName) && this.Level == other.Level && this.ExpectedTimeMinSec == other.ExpectedTimeMinSec && this.ExpectedTimeMaxSec == other.ExpectedTimeMaxSec && this.Unlocked == other.Unlocked && this.BestGrade == other.BestGrade && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179C8 RID: 96712 RVA: 0x0036FBC4 File Offset: 0x0036DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.DifficultyName.Length != 0)
			{
				num ^= this.DifficultyName.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ExpectedTimeMinSec != 0)
			{
				num ^= this.ExpectedTimeMinSec.GetHashCode();
			}
			if (this.ExpectedTimeMaxSec != 0)
			{
				num ^= this.ExpectedTimeMaxSec.GetHashCode();
			}
			if (this.Unlocked)
			{
				num ^= this.Unlocked.GetHashCode();
			}
			if (this.BestGrade != RoverRogueGrade.B)
			{
				num ^= this.BestGrade.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179C9 RID: 96713 RVA: 0x0036FCA1 File Offset: 0x0036DEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179CA RID: 96714 RVA: 0x0036FCAE File Offset: 0x0036DEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179CB RID: 96715 RVA: 0x0036FCB8 File Offset: 0x0036DEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.DifficultyName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.DifficultyName);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.ExpectedTimeMinSec != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ExpectedTimeMinSec);
			}
			if (this.ExpectedTimeMaxSec != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ExpectedTimeMaxSec);
			}
			if (this.Unlocked)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Unlocked);
			}
			if (this.BestGrade != RoverRogueGrade.B)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.BestGrade);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179CC RID: 96716 RVA: 0x0036FDA4 File Offset: 0x0036DFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.DifficultyName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DifficultyName);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.ExpectedTimeMinSec != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpectedTimeMinSec);
			}
			if (this.ExpectedTimeMaxSec != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpectedTimeMaxSec);
			}
			if (this.Unlocked)
			{
				num += 2;
			}
			if (this.BestGrade != RoverRogueGrade.B)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BestGrade);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179CD RID: 96717 RVA: 0x0036FE6C File Offset: 0x0036E06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.DifficultyName.Length != 0)
			{
				this.DifficultyName = other.DifficultyName;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.ExpectedTimeMinSec != 0)
			{
				this.ExpectedTimeMinSec = other.ExpectedTimeMinSec;
			}
			if (other.ExpectedTimeMaxSec != 0)
			{
				this.ExpectedTimeMaxSec = other.ExpectedTimeMaxSec;
			}
			if (other.Unlocked)
			{
				this.Unlocked = other.Unlocked;
			}
			if (other.BestGrade != RoverRogueGrade.B)
			{
				this.BestGrade = other.BestGrade;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179CE RID: 96718 RVA: 0x0036FF25 File Offset: 0x0036E125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179CF RID: 96719 RVA: 0x0036FF30 File Offset: 0x0036E130
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.DifficultyName = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.ExpectedTimeMinSec = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ExpectedTimeMaxSec = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Unlocked = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.BestGrade = (RoverRogueGrade)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008CEF RID: 36079
		private static readonly MessageParser<RoverRogueInsEntry> _parser = new MessageParser<RoverRogueInsEntry>(() => new RoverRogueInsEntry());

		// Token: 0x04008CF0 RID: 36080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CF1 RID: 36081
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008CF2 RID: 36082
		private int instId_;

		// Token: 0x04008CF3 RID: 36083
		public const int DifficultyNameFieldNumber = 2;

		// Token: 0x04008CF4 RID: 36084
		private string difficultyName_ = "";

		// Token: 0x04008CF5 RID: 36085
		public const int LevelFieldNumber = 3;

		// Token: 0x04008CF6 RID: 36086
		private int level_;

		// Token: 0x04008CF7 RID: 36087
		public const int ExpectedTimeMinSecFieldNumber = 4;

		// Token: 0x04008CF8 RID: 36088
		private int expectedTimeMinSec_;

		// Token: 0x04008CF9 RID: 36089
		public const int ExpectedTimeMaxSecFieldNumber = 5;

		// Token: 0x04008CFA RID: 36090
		private int expectedTimeMaxSec_;

		// Token: 0x04008CFB RID: 36091
		public const int UnlockedFieldNumber = 6;

		// Token: 0x04008CFC RID: 36092
		private bool unlocked_;

		// Token: 0x04008CFD RID: 36093
		public const int BestGradeFieldNumber = 7;

		// Token: 0x04008CFE RID: 36094
		private RoverRogueGrade bestGrade_;
	}
}
