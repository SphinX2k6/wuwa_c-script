using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AC RID: 2476
	public sealed class MatchResult : IMessage<MatchResult>, IMessage, IEquatable<MatchResult>, IDeepCloneable<MatchResult>, IBufferMessage
	{
		// Token: 0x0600D99C RID: 55708 RVA: 0x001FFA2F File Offset: 0x001FDC2F
		[NullableContext(1)]
		public static MatchResult Create()
		{
			return new MatchResult();
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600D99D RID: 55709 RVA: 0x001FFA36 File Offset: 0x001FDC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600D99E RID: 55710 RVA: 0x001FFA39 File Offset: 0x001FDC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchResult.Descriptor;
			}
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x001FFA40 File Offset: 0x001FDC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult()
		{
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x001FFA54 File Offset: 0x001FDC54
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

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x001FFAAD File Offset: 0x001FDCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Clone()
		{
			return new MatchResult(this);
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0600D9A2 RID: 55714 RVA: 0x001FFAB5 File Offset: 0x001FDCB5
		// (set) Token: 0x0600D9A3 RID: 55715 RVA: 0x001FFABD File Offset: 0x001FDCBD
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

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x001FFAC6 File Offset: 0x001FDCC6
		// (set) Token: 0x0600D9A5 RID: 55717 RVA: 0x001FFACE File Offset: 0x001FDCCE
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

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x001FFAD7 File Offset: 0x001FDCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x001FFADF File Offset: 0x001FDCDF
		// (set) Token: 0x0600D9A8 RID: 55720 RVA: 0x001FFAE7 File Offset: 0x001FDCE7
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

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x001FFAF0 File Offset: 0x001FDCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchResult);
		}

		// Token: 0x0600D9AA RID: 55722 RVA: 0x001FFB00 File Offset: 0x001FDD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchResult other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoRank_.Equals(other.dangoRank_) && this.PromoteNum == other.PromoteNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x001FFB70 File Offset: 0x001FDD70
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

		// Token: 0x0600D9AC RID: 55724 RVA: 0x001FFBEF File Offset: 0x001FDDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x001FFBFC File Offset: 0x001FDDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9AE RID: 55726 RVA: 0x001FFC08 File Offset: 0x001FDE08
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

		// Token: 0x0600D9AF RID: 55727 RVA: 0x001FFC90 File Offset: 0x001FDE90
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

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x001FFD14 File Offset: 0x001FDF14
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

		// Token: 0x0600D9B1 RID: 55729 RVA: 0x001FFD89 File Offset: 0x001FDF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9B2 RID: 55730 RVA: 0x001FFD94 File Offset: 0x001FDF94
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

		// Token: 0x04005AD6 RID: 23254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AD7 RID: 23255
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04005AD8 RID: 23256
		private int activityId_;

		// Token: 0x04005AD9 RID: 23257
		public const int LegMatchIdFieldNumber = 2;

		// Token: 0x04005ADA RID: 23258
		private int legMatchId_;

		// Token: 0x04005ADB RID: 23259
		public const int DangoRankFieldNumber = 3;

		// Token: 0x04005ADC RID: 23260
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005ADD RID: 23261
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x04005ADE RID: 23262
		public const int PromoteNumFieldNumber = 4;

		// Token: 0x04005ADF RID: 23263
		private int promoteNum_;
	}
}
