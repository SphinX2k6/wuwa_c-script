using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3D RID: 3901
	public sealed class RhythmSubLevelPb : IMessage<RhythmSubLevelPb>, IMessage, IEquatable<RhythmSubLevelPb>, IDeepCloneable<RhythmSubLevelPb>, IBufferMessage
	{
		// Token: 0x06014E68 RID: 85608 RVA: 0x00308F5C File Offset: 0x0030715C
		[NullableContext(1)]
		public static RhythmSubLevelPb Create()
		{
			return new RhythmSubLevelPb();
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x06014E69 RID: 85609 RVA: 0x00308F63 File Offset: 0x00307163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmSubLevelPb> Parser
		{
			get
			{
				return RhythmSubLevelPb._parser;
			}
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x06014E6A RID: 85610 RVA: 0x00308F6A File Offset: 0x0030716A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x06014E6B RID: 85611 RVA: 0x00308F6D File Offset: 0x0030716D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSubLevelPb.Descriptor;
			}
		}

		// Token: 0x06014E6C RID: 85612 RVA: 0x00308F74 File Offset: 0x00307174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb()
		{
		}

		// Token: 0x06014E6D RID: 85613 RVA: 0x00308F7C File Offset: 0x0030717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb(RhythmSubLevelPb other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.cleared_ = other.cleared_;
			this.bestScore_ = other.bestScore_;
			this.bestAccuracy_ = other.bestAccuracy_;
			this.bestRank_ = other.bestRank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E6E RID: 85614 RVA: 0x00308FDC File Offset: 0x003071DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb Clone()
		{
			return new RhythmSubLevelPb(this);
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x06014E6F RID: 85615 RVA: 0x00308FE4 File Offset: 0x003071E4
		// (set) Token: 0x06014E70 RID: 85616 RVA: 0x00308FEC File Offset: 0x003071EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x06014E71 RID: 85617 RVA: 0x00308FF5 File Offset: 0x003071F5
		// (set) Token: 0x06014E72 RID: 85618 RVA: 0x00308FFD File Offset: 0x003071FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Cleared
		{
			get
			{
				return this.cleared_;
			}
			set
			{
				this.cleared_ = value;
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06014E73 RID: 85619 RVA: 0x00309006 File Offset: 0x00307206
		// (set) Token: 0x06014E74 RID: 85620 RVA: 0x0030900E File Offset: 0x0030720E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestScore
		{
			get
			{
				return this.bestScore_;
			}
			set
			{
				this.bestScore_ = value;
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x06014E75 RID: 85621 RVA: 0x00309017 File Offset: 0x00307217
		// (set) Token: 0x06014E76 RID: 85622 RVA: 0x0030901F File Offset: 0x0030721F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestAccuracy
		{
			get
			{
				return this.bestAccuracy_;
			}
			set
			{
				this.bestAccuracy_ = value;
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x06014E77 RID: 85623 RVA: 0x00309028 File Offset: 0x00307228
		// (set) Token: 0x06014E78 RID: 85624 RVA: 0x00309030 File Offset: 0x00307230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipRank BestRank
		{
			get
			{
				return this.bestRank_;
			}
			set
			{
				this.bestRank_ = value;
			}
		}

		// Token: 0x06014E79 RID: 85625 RVA: 0x00309039 File Offset: 0x00307239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSubLevelPb);
		}

		// Token: 0x06014E7A RID: 85626 RVA: 0x00309048 File Offset: 0x00307248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSubLevelPb other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.Cleared == other.Cleared && this.BestScore == other.BestScore && this.BestAccuracy == other.BestAccuracy && this.BestRank == other.BestRank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E7B RID: 85627 RVA: 0x003090C4 File Offset: 0x003072C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.Cleared)
			{
				num ^= this.Cleared.GetHashCode();
			}
			if (this.BestScore != 0)
			{
				num ^= this.BestScore.GetHashCode();
			}
			if (this.BestAccuracy != 0)
			{
				num ^= this.BestAccuracy.GetHashCode();
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				num ^= this.BestRank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x0030916D File Offset: 0x0030736D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E7D RID: 85629 RVA: 0x0030917A File Offset: 0x0030737A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E7E RID: 85630 RVA: 0x00309184 File Offset: 0x00307384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.Cleared)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Cleared);
			}
			if (this.BestScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BestScore);
			}
			if (this.BestAccuracy != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BestAccuracy);
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.BestRank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E7F RID: 85631 RVA: 0x00309230 File Offset: 0x00307430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.Cleared)
			{
				num += 2;
			}
			if (this.BestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestScore);
			}
			if (this.BestAccuracy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestAccuracy);
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BestRank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E80 RID: 85632 RVA: 0x003092C4 File Offset: 0x003074C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSubLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.Cleared)
			{
				this.Cleared = other.Cleared;
			}
			if (other.BestScore != 0)
			{
				this.BestScore = other.BestScore;
			}
			if (other.BestAccuracy != 0)
			{
				this.BestAccuracy = other.BestAccuracy;
			}
			if (other.BestRank != RhythmShipRank.Undefined)
			{
				this.BestRank = other.BestRank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E81 RID: 85633 RVA: 0x00309350 File Offset: 0x00307550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E82 RID: 85634 RVA: 0x0030935C File Offset: 0x0030755C
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
					if (num == 8U)
					{
						this.SubLevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Cleared = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BestScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BestAccuracy = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BestRank = (RhythmShipRank)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007E83 RID: 32387
		private static readonly MessageParser<RhythmSubLevelPb> _parser = new MessageParser<RhythmSubLevelPb>(() => new RhythmSubLevelPb());

		// Token: 0x04007E84 RID: 32388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E85 RID: 32389
		public const int SubLevelIdFieldNumber = 1;

		// Token: 0x04007E86 RID: 32390
		private int subLevelId_;

		// Token: 0x04007E87 RID: 32391
		public const int ClearedFieldNumber = 2;

		// Token: 0x04007E88 RID: 32392
		private bool cleared_;

		// Token: 0x04007E89 RID: 32393
		public const int BestScoreFieldNumber = 3;

		// Token: 0x04007E8A RID: 32394
		private int bestScore_;

		// Token: 0x04007E8B RID: 32395
		public const int BestAccuracyFieldNumber = 4;

		// Token: 0x04007E8C RID: 32396
		private int bestAccuracy_;

		// Token: 0x04007E8D RID: 32397
		public const int BestRankFieldNumber = 5;

		// Token: 0x04007E8E RID: 32398
		private RhythmShipRank bestRank_;
	}
}
