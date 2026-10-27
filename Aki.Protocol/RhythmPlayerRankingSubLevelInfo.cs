using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3E RID: 3902
	public sealed class RhythmPlayerRankingSubLevelInfo : IMessage<RhythmPlayerRankingSubLevelInfo>, IMessage, IEquatable<RhythmPlayerRankingSubLevelInfo>, IDeepCloneable<RhythmPlayerRankingSubLevelInfo>, IBufferMessage
	{
		// Token: 0x06014E07 RID: 85511 RVA: 0x00307480 File Offset: 0x00305680
		[NullableContext(1)]
		public static RhythmPlayerRankingSubLevelInfo Create()
		{
			return new RhythmPlayerRankingSubLevelInfo();
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x06014E08 RID: 85512 RVA: 0x00307487 File Offset: 0x00305687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmPlayerRankingSubLevelInfo> Parser
		{
			get
			{
				return RhythmPlayerRankingSubLevelInfo._parser;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x06014E09 RID: 85513 RVA: 0x0030748E File Offset: 0x0030568E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x06014E0A RID: 85514 RVA: 0x00307491 File Offset: 0x00305691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmPlayerRankingSubLevelInfo.Descriptor;
			}
		}

		// Token: 0x06014E0B RID: 85515 RVA: 0x00307498 File Offset: 0x00305698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo()
		{
		}

		// Token: 0x06014E0C RID: 85516 RVA: 0x003074A0 File Offset: 0x003056A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo(RhythmPlayerRankingSubLevelInfo other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this.score_ = other.score_;
			this.accuracy_ = other.accuracy_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E0D RID: 85517 RVA: 0x003074F4 File Offset: 0x003056F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo Clone()
		{
			return new RhythmPlayerRankingSubLevelInfo(this);
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x06014E0E RID: 85518 RVA: 0x003074FC File Offset: 0x003056FC
		// (set) Token: 0x06014E0F RID: 85519 RVA: 0x00307504 File Offset: 0x00305704
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

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x06014E10 RID: 85520 RVA: 0x0030750D File Offset: 0x0030570D
		// (set) Token: 0x06014E11 RID: 85521 RVA: 0x00307515 File Offset: 0x00305715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RhythmRoleId
		{
			get
			{
				return this.rhythmRoleId_;
			}
			set
			{
				this.rhythmRoleId_ = value;
			}
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x06014E12 RID: 85522 RVA: 0x0030751E File Offset: 0x0030571E
		// (set) Token: 0x06014E13 RID: 85523 RVA: 0x00307526 File Offset: 0x00305726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x06014E14 RID: 85524 RVA: 0x0030752F File Offset: 0x0030572F
		// (set) Token: 0x06014E15 RID: 85525 RVA: 0x00307537 File Offset: 0x00305737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Accuracy
		{
			get
			{
				return this.accuracy_;
			}
			set
			{
				this.accuracy_ = value;
			}
		}

		// Token: 0x06014E16 RID: 85526 RVA: 0x00307540 File Offset: 0x00305740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmPlayerRankingSubLevelInfo);
		}

		// Token: 0x06014E17 RID: 85527 RVA: 0x00307550 File Offset: 0x00305750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmPlayerRankingSubLevelInfo other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.RhythmRoleId == other.RhythmRoleId && this.Score == other.Score && this.Accuracy == other.Accuracy && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E18 RID: 85528 RVA: 0x003075BC File Offset: 0x003057BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.RhythmRoleId != 0)
			{
				num ^= this.RhythmRoleId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Accuracy != 0)
			{
				num ^= this.Accuracy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E19 RID: 85529 RVA: 0x00307646 File Offset: 0x00305846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E1A RID: 85530 RVA: 0x00307653 File Offset: 0x00305853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E1B RID: 85531 RVA: 0x0030765C File Offset: 0x0030585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RhythmRoleId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this.Accuracy != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Accuracy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E1C RID: 85532 RVA: 0x003076EC File Offset: 0x003058EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RhythmRoleId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Accuracy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Accuracy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E1D RID: 85533 RVA: 0x00307774 File Offset: 0x00305974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmPlayerRankingSubLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.RhythmRoleId != 0)
			{
				this.RhythmRoleId = other.RhythmRoleId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Accuracy != 0)
			{
				this.Accuracy = other.Accuracy;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E1E RID: 85534 RVA: 0x003077EC File Offset: 0x003059EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E1F RID: 85535 RVA: 0x003077F8 File Offset: 0x003059F8
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
						this.RhythmRoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Accuracy = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007DEB RID: 32235
		private static readonly MessageParser<RhythmPlayerRankingSubLevelInfo> _parser = new MessageParser<RhythmPlayerRankingSubLevelInfo>(() => new RhythmPlayerRankingSubLevelInfo());

		// Token: 0x04007DEC RID: 32236
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DED RID: 32237
		public const int SubLevelIdFieldNumber = 1;

		// Token: 0x04007DEE RID: 32238
		private int subLevelId_;

		// Token: 0x04007DEF RID: 32239
		public const int RhythmRoleIdFieldNumber = 2;

		// Token: 0x04007DF0 RID: 32240
		private int rhythmRoleId_;

		// Token: 0x04007DF1 RID: 32241
		public const int ScoreFieldNumber = 3;

		// Token: 0x04007DF2 RID: 32242
		private int score_;

		// Token: 0x04007DF3 RID: 32243
		public const int AccuracyFieldNumber = 4;

		// Token: 0x04007DF4 RID: 32244
		private int accuracy_;
	}
}
