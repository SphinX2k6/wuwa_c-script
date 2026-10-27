using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001108 RID: 4360
	public sealed class RoverRogueInsEntry : IMessage<RoverRogueInsEntry>, IMessage, IEquatable<RoverRogueInsEntry>, IDeepCloneable<RoverRogueInsEntry>, IBufferMessage
	{
		// Token: 0x06017410 RID: 95248 RVA: 0x0036069C File Offset: 0x0035E89C
		[NullableContext(1)]
		public static RoverRogueInsEntry Create()
		{
			return new RoverRogueInsEntry();
		}

		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x06017411 RID: 95249 RVA: 0x003606A3 File Offset: 0x0035E8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueInsEntry> Parser
		{
			get
			{
				return RoverRogueInsEntry._parser;
			}
		}

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06017412 RID: 95250 RVA: 0x003606AA File Offset: 0x0035E8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06017413 RID: 95251 RVA: 0x003606AD File Offset: 0x0035E8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsEntry.Descriptor;
			}
		}

		// Token: 0x06017414 RID: 95252 RVA: 0x003606B4 File Offset: 0x0035E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsEntry()
		{
		}

		// Token: 0x06017415 RID: 95253 RVA: 0x003606C8 File Offset: 0x0035E8C8
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

		// Token: 0x06017416 RID: 95254 RVA: 0x00360740 File Offset: 0x0035E940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsEntry Clone()
		{
			return new RoverRogueInsEntry(this);
		}

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x06017417 RID: 95255 RVA: 0x00360748 File Offset: 0x0035E948
		// (set) Token: 0x06017418 RID: 95256 RVA: 0x00360750 File Offset: 0x0035E950
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

		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x06017419 RID: 95257 RVA: 0x00360759 File Offset: 0x0035E959
		// (set) Token: 0x0601741A RID: 95258 RVA: 0x00360761 File Offset: 0x0035E961
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

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x0601741B RID: 95259 RVA: 0x00360774 File Offset: 0x0035E974
		// (set) Token: 0x0601741C RID: 95260 RVA: 0x0036077C File Offset: 0x0035E97C
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

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x0601741D RID: 95261 RVA: 0x00360785 File Offset: 0x0035E985
		// (set) Token: 0x0601741E RID: 95262 RVA: 0x0036078D File Offset: 0x0035E98D
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

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x0601741F RID: 95263 RVA: 0x00360796 File Offset: 0x0035E996
		// (set) Token: 0x06017420 RID: 95264 RVA: 0x0036079E File Offset: 0x0035E99E
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

		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x06017421 RID: 95265 RVA: 0x003607A7 File Offset: 0x0035E9A7
		// (set) Token: 0x06017422 RID: 95266 RVA: 0x003607AF File Offset: 0x0035E9AF
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

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06017423 RID: 95267 RVA: 0x003607B8 File Offset: 0x0035E9B8
		// (set) Token: 0x06017424 RID: 95268 RVA: 0x003607C0 File Offset: 0x0035E9C0
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

		// Token: 0x06017425 RID: 95269 RVA: 0x003607C9 File Offset: 0x0035E9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsEntry);
		}

		// Token: 0x06017426 RID: 95270 RVA: 0x003607D8 File Offset: 0x0035E9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsEntry other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && !(this.DifficultyName != other.DifficultyName) && this.Level == other.Level && this.ExpectedTimeMinSec == other.ExpectedTimeMinSec && this.ExpectedTimeMaxSec == other.ExpectedTimeMaxSec && this.Unlocked == other.Unlocked && this.BestGrade == other.BestGrade && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017427 RID: 95271 RVA: 0x00360878 File Offset: 0x0035EA78
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

		// Token: 0x06017428 RID: 95272 RVA: 0x00360955 File Offset: 0x0035EB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017429 RID: 95273 RVA: 0x00360962 File Offset: 0x0035EB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601742A RID: 95274 RVA: 0x0036096C File Offset: 0x0035EB6C
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

		// Token: 0x0601742B RID: 95275 RVA: 0x00360A58 File Offset: 0x0035EC58
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

		// Token: 0x0601742C RID: 95276 RVA: 0x00360B20 File Offset: 0x0035ED20
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

		// Token: 0x0601742D RID: 95277 RVA: 0x00360BD9 File Offset: 0x0035EDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601742E RID: 95278 RVA: 0x00360BE4 File Offset: 0x0035EDE4
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

		// Token: 0x04008A5C RID: 35420
		private static readonly MessageParser<RoverRogueInsEntry> _parser = new MessageParser<RoverRogueInsEntry>(() => new RoverRogueInsEntry());

		// Token: 0x04008A5D RID: 35421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A5E RID: 35422
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008A5F RID: 35423
		private int instId_;

		// Token: 0x04008A60 RID: 35424
		public const int DifficultyNameFieldNumber = 2;

		// Token: 0x04008A61 RID: 35425
		private string difficultyName_ = "";

		// Token: 0x04008A62 RID: 35426
		public const int LevelFieldNumber = 3;

		// Token: 0x04008A63 RID: 35427
		private int level_;

		// Token: 0x04008A64 RID: 35428
		public const int ExpectedTimeMinSecFieldNumber = 4;

		// Token: 0x04008A65 RID: 35429
		private int expectedTimeMinSec_;

		// Token: 0x04008A66 RID: 35430
		public const int ExpectedTimeMaxSecFieldNumber = 5;

		// Token: 0x04008A67 RID: 35431
		private int expectedTimeMaxSec_;

		// Token: 0x04008A68 RID: 35432
		public const int UnlockedFieldNumber = 6;

		// Token: 0x04008A69 RID: 35433
		private bool unlocked_;

		// Token: 0x04008A6A RID: 35434
		public const int BestGradeFieldNumber = 7;

		// Token: 0x04008A6B RID: 35435
		private RoverRogueGrade bestGrade_;
	}
}
