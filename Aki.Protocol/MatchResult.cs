using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BD RID: 2493
	public sealed class MatchResult : IMessage<MatchResult>, IMessage, IEquatable<MatchResult>, IDeepCloneable<MatchResult>, IBufferMessage
	{
		// Token: 0x0600DAB6 RID: 55990 RVA: 0x00201C23 File Offset: 0x001FFE23
		[NullableContext(1)]
		public static MatchResult Create()
		{
			return new MatchResult();
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x00201C2A File Offset: 0x001FFE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x00201C2D File Offset: 0x001FFE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchResult.Descriptor;
			}
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x00201C34 File Offset: 0x001FFE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult()
		{
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x00201C48 File Offset: 0x001FFE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult(MatchResult other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoRank_ = other.dangoRank_.Clone();
			this.promoteNum_ = other.promoteNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00201CA1 File Offset: 0x001FFEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Clone()
		{
			return new MatchResult(this);
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600DABC RID: 55996 RVA: 0x00201CA9 File Offset: 0x001FFEA9
		// (set) Token: 0x0600DABD RID: 55997 RVA: 0x00201CB1 File Offset: 0x001FFEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0600DABE RID: 55998 RVA: 0x00201CBA File Offset: 0x001FFEBA
		// (set) Token: 0x0600DABF RID: 55999 RVA: 0x00201CC2 File Offset: 0x001FFEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0600DAC0 RID: 56000 RVA: 0x00201CCB File Offset: 0x001FFECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x00201CD3 File Offset: 0x001FFED3
		// (set) Token: 0x0600DAC2 RID: 56002 RVA: 0x00201CDB File Offset: 0x001FFEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PromoteNum
		{
			get
			{
				return this.promoteNum_;
			}
			set
			{
				this.promoteNum_ = value;
			}
		}

		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00201CE4 File Offset: 0x001FFEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchResult);
		}

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x00201CF4 File Offset: 0x001FFEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchResult other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoRank_.Equals(other.dangoRank_) && this.PromoteNum == other.PromoteNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAC5 RID: 56005 RVA: 0x00201D64 File Offset: 0x001FFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			num ^= this.dangoRank_.GetHashCode();
			if (this.PromoteNum != 0)
			{
				num ^= this.PromoteNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x00201DE3 File Offset: 0x001FFFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00201DF0 File Offset: 0x001FFFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x00201DFC File Offset: 0x001FFFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LegMatchId);
			}
			this.dangoRank_.WriteTo(ref output, MatchResult._repeated_dangoRank_codec);
			if (this.PromoteNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PromoteNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x00201E84 File Offset: 0x00200084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			num += this.dangoRank_.CalculateSize(MatchResult._repeated_dangoRank_codec);
			if (this.PromoteNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PromoteNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DACA RID: 56010 RVA: 0x00201F08 File Offset: 0x00200108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this.dangoRank_.Add(other.dangoRank_);
			if (other.PromoteNum != 0)
			{
				this.PromoteNum = other.PromoteNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DACB RID: 56011 RVA: 0x00201F7D File Offset: 0x0020017D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DACC RID: 56012 RVA: 0x00201F88 File Offset: 0x00200188
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
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.dangoRank_.AddEntriesFrom(ref input, MatchResult._repeated_dangoRank_codec);
						continue;
					}
					if (num == 32U)
					{
						this.PromoteNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005ACD RID: 23245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ACE RID: 23246
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04005ACF RID: 23247
		private int activityId_;

		// Token: 0x04005AD0 RID: 23248
		public const int LegMatchIdFieldNumber = 2;

		// Token: 0x04005AD1 RID: 23249
		private int legMatchId_;

		// Token: 0x04005AD2 RID: 23250
		public const int DangoRankFieldNumber = 3;

		// Token: 0x04005AD3 RID: 23251
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005AD4 RID: 23252
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x04005AD5 RID: 23253
		public const int PromoteNumFieldNumber = 4;

		// Token: 0x04005AD6 RID: 23254
		private int promoteNum_;
	}
}
