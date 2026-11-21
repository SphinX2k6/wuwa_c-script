using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DE RID: 4318
	public sealed class RoleTowerRankScoreRange : IMessage<RoleTowerRankScoreRange>, IMessage, IEquatable<RoleTowerRankScoreRange>, IDeepCloneable<RoleTowerRankScoreRange>, IBufferMessage
	{
		// Token: 0x0601715E RID: 94558 RVA: 0x0035BF6D File Offset: 0x0035A16D
		[NullableContext(1)]
		public static RoleTowerRankScoreRange Create()
		{
			return new RoleTowerRankScoreRange();
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x0601715F RID: 94559 RVA: 0x0035BF74 File Offset: 0x0035A174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRankScoreRange> Parser
		{
			get
			{
				return RoleTowerRankScoreRange._parser;
			}
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06017160 RID: 94560 RVA: 0x0035BF7B File Offset: 0x0035A17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x06017161 RID: 94561 RVA: 0x0035BF7E File Offset: 0x0035A17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankScoreRange.Descriptor;
			}
		}

		// Token: 0x06017162 RID: 94562 RVA: 0x0035BF85 File Offset: 0x0035A185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankScoreRange()
		{
		}

		// Token: 0x06017163 RID: 94563 RVA: 0x0035BF90 File Offset: 0x0035A190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankScoreRange(RoleTowerRankScoreRange other) : this()
		{
			this.percentCode_ = other.percentCode_;
			this.maxScore_ = other.maxScore_;
			this.minScore_ = other.minScore_;
			this.hasScore_ = other.hasScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017164 RID: 94564 RVA: 0x0035BFE4 File Offset: 0x0035A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankScoreRange Clone()
		{
			return new RoleTowerRankScoreRange(this);
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x06017165 RID: 94565 RVA: 0x0035BFEC File Offset: 0x0035A1EC
		// (set) Token: 0x06017166 RID: 94566 RVA: 0x0035BFF4 File Offset: 0x0035A1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PercentCode
		{
			get
			{
				return this.percentCode_;
			}
			set
			{
				this.percentCode_ = value;
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x06017167 RID: 94567 RVA: 0x0035BFFD File Offset: 0x0035A1FD
		// (set) Token: 0x06017168 RID: 94568 RVA: 0x0035C005 File Offset: 0x0035A205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x06017169 RID: 94569 RVA: 0x0035C00E File Offset: 0x0035A20E
		// (set) Token: 0x0601716A RID: 94570 RVA: 0x0035C016 File Offset: 0x0035A216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong MinScore
		{
			get
			{
				return this.minScore_;
			}
			set
			{
				this.minScore_ = value;
			}
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x0601716B RID: 94571 RVA: 0x0035C01F File Offset: 0x0035A21F
		// (set) Token: 0x0601716C RID: 94572 RVA: 0x0035C027 File Offset: 0x0035A227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasScore
		{
			get
			{
				return this.hasScore_;
			}
			set
			{
				this.hasScore_ = value;
			}
		}

		// Token: 0x0601716D RID: 94573 RVA: 0x0035C030 File Offset: 0x0035A230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankScoreRange);
		}

		// Token: 0x0601716E RID: 94574 RVA: 0x0035C040 File Offset: 0x0035A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankScoreRange other)
		{
			return other != null && (other == this || (this.PercentCode == other.PercentCode && this.MaxScore == other.MaxScore && this.MinScore == other.MinScore && this.HasScore == other.HasScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601716F RID: 94575 RVA: 0x0035C0AC File Offset: 0x0035A2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PercentCode != 0U)
			{
				num ^= this.PercentCode.GetHashCode();
			}
			if (this.MaxScore != 0UL)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.MinScore != 0UL)
			{
				num ^= this.MinScore.GetHashCode();
			}
			if (this.HasScore)
			{
				num ^= this.HasScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017170 RID: 94576 RVA: 0x0035C136 File Offset: 0x0035A336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017171 RID: 94577 RVA: 0x0035C143 File Offset: 0x0035A343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017172 RID: 94578 RVA: 0x0035C14C File Offset: 0x0035A34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PercentCode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PercentCode);
			}
			if (this.MaxScore != 0UL)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(this.MaxScore);
			}
			if (this.MinScore != 0UL)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.MinScore);
			}
			if (this.HasScore)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.HasScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017173 RID: 94579 RVA: 0x0035C1DC File Offset: 0x0035A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PercentCode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PercentCode);
			}
			if (this.MaxScore != 0UL)
			{
				num += 9;
			}
			if (this.MinScore != 0UL)
			{
				num += 9;
			}
			if (this.HasScore)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017174 RID: 94580 RVA: 0x0035C240 File Offset: 0x0035A440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankScoreRange other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PercentCode != 0U)
			{
				this.PercentCode = other.PercentCode;
			}
			if (other.MaxScore != 0UL)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.MinScore != 0UL)
			{
				this.MinScore = other.MinScore;
			}
			if (other.HasScore)
			{
				this.HasScore = other.HasScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017175 RID: 94581 RVA: 0x0035C2B8 File Offset: 0x0035A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017176 RID: 94582 RVA: 0x0035C2C4 File Offset: 0x0035A4C4
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
				if (num <= 17U)
				{
					if (num == 8U)
					{
						this.PercentCode = input.ReadUInt32();
						continue;
					}
					if (num == 17U)
					{
						this.MaxScore = input.ReadFixed64();
						continue;
					}
				}
				else
				{
					if (num == 25U)
					{
						this.MinScore = input.ReadFixed64();
						continue;
					}
					if (num == 32U)
					{
						this.HasScore = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A35 RID: 35381
		private static readonly MessageParser<RoleTowerRankScoreRange> _parser = new MessageParser<RoleTowerRankScoreRange>(() => new RoleTowerRankScoreRange());

		// Token: 0x04008A36 RID: 35382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A37 RID: 35383
		public const int PercentCodeFieldNumber = 1;

		// Token: 0x04008A38 RID: 35384
		private uint percentCode_;

		// Token: 0x04008A39 RID: 35385
		public const int MaxScoreFieldNumber = 2;

		// Token: 0x04008A3A RID: 35386
		private ulong maxScore_;

		// Token: 0x04008A3B RID: 35387
		public const int MinScoreFieldNumber = 3;

		// Token: 0x04008A3C RID: 35388
		private ulong minScore_;

		// Token: 0x04008A3D RID: 35389
		public const int HasScoreFieldNumber = 4;

		// Token: 0x04008A3E RID: 35390
		private bool hasScore_;
	}
}
