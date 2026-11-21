using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103B RID: 4155
	[NetMessage(EMessageId.RogueWeeklySubLevelNotify)]
	public sealed class RogueWeeklySubLevelNotify : IMessage<RogueWeeklySubLevelNotify>, IMessage, IEquatable<RogueWeeklySubLevelNotify>, IDeepCloneable<RogueWeeklySubLevelNotify>, IBufferMessage
	{
		// Token: 0x060163A9 RID: 91049 RVA: 0x0033B331 File Offset: 0x00339531
		[NullableContext(1)]
		public static RogueWeeklySubLevelNotify Create()
		{
			return new RogueWeeklySubLevelNotify();
		}

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x060163AA RID: 91050 RVA: 0x0033B338 File Offset: 0x00339538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x060163AB RID: 91051 RVA: 0x0033B33B File Offset: 0x0033953B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklySubLevelNotify.Descriptor;
			}
		}

		// Token: 0x060163AC RID: 91052 RVA: 0x0033B342 File Offset: 0x00339542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklySubLevelNotify()
		{
		}

		// Token: 0x060163AD RID: 91053 RVA: 0x0033B360 File Offset: 0x00339560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklySubLevelNotify(RogueWeeklySubLevelNotify other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this.isExtra_ = other.isExtra_;
			this.curScore_ = other.curScore_;
			this.maxScore_ = other.maxScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163AE RID: 91054 RVA: 0x0033B3FA File Offset: 0x003395FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklySubLevelNotify Clone()
		{
			return new RogueWeeklySubLevelNotify(this);
		}

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x060163AF RID: 91055 RVA: 0x0033B402 File Offset: 0x00339602
		// (set) Token: 0x060163B0 RID: 91056 RVA: 0x0033B40A File Offset: 0x0033960A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x060163B1 RID: 91057 RVA: 0x0033B413 File Offset: 0x00339613
		// (set) Token: 0x060163B2 RID: 91058 RVA: 0x0033B41B File Offset: 0x0033961B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x060163B3 RID: 91059 RVA: 0x0033B424 File Offset: 0x00339624
		// (set) Token: 0x060163B4 RID: 91060 RVA: 0x0033B42C File Offset: 0x0033962C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x060163B5 RID: 91061 RVA: 0x0033B435 File Offset: 0x00339635
		// (set) Token: 0x060163B6 RID: 91062 RVA: 0x0033B43D File Offset: 0x0033963D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float A
		{
			get
			{
				return this.a_;
			}
			set
			{
				this.a_ = value;
			}
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x060163B7 RID: 91063 RVA: 0x0033B446 File Offset: 0x00339646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x060163B8 RID: 91064 RVA: 0x0033B44E File Offset: 0x0033964E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x060163B9 RID: 91065 RVA: 0x0033B456 File Offset: 0x00339656
		// (set) Token: 0x060163BA RID: 91066 RVA: 0x0033B45E File Offset: 0x0033965E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExtra
		{
			get
			{
				return this.isExtra_;
			}
			set
			{
				this.isExtra_ = value;
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x060163BB RID: 91067 RVA: 0x0033B467 File Offset: 0x00339667
		// (set) Token: 0x060163BC RID: 91068 RVA: 0x0033B46F File Offset: 0x0033966F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurScore
		{
			get
			{
				return this.curScore_;
			}
			set
			{
				this.curScore_ = value;
			}
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x060163BD RID: 91069 RVA: 0x0033B478 File Offset: 0x00339678
		// (set) Token: 0x060163BE RID: 91070 RVA: 0x0033B480 File Offset: 0x00339680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
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

		// Token: 0x060163BF RID: 91071 RVA: 0x0033B489 File Offset: 0x00339689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklySubLevelNotify);
		}

		// Token: 0x060163C0 RID: 91072 RVA: 0x0033B498 File Offset: 0x00339698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklySubLevelNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && this.IsExtra == other.IsExtra && this.CurScore == other.CurScore && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163C1 RID: 91073 RVA: 0x0033B584 File Offset: 0x00339784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.Z != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			if (this.A != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.A);
			}
			num ^= this.loadSubLevels_.GetHashCode();
			num ^= this.unLoadSubLevels_.GetHashCode();
			if (this.IsExtra)
			{
				num ^= this.IsExtra.GetHashCode();
			}
			if (this.CurScore != 0)
			{
				num ^= this.CurScore.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060163C2 RID: 91074 RVA: 0x0033B691 File Offset: 0x00339891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163C3 RID: 91075 RVA: 0x0033B69E File Offset: 0x0033989E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163C4 RID: 91076 RVA: 0x0033B6A8 File Offset: 0x003398A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Z != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Z);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RogueWeeklySubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.Y != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Y);
			}
			if (this.CurScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurScore);
			}
			if (this.IsExtra)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsExtra);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.A);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.X);
			}
			this.loadSubLevels_.WriteTo(ref output, RogueWeeklySubLevelNotify._repeated_loadSubLevels_codec);
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060163C5 RID: 91077 RVA: 0x0033B7C4 File Offset: 0x003399C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.Z != 0f)
			{
				num += 5;
			}
			if (this.A != 0f)
			{
				num += 5;
			}
			num += this.loadSubLevels_.CalculateSize(RogueWeeklySubLevelNotify._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(RogueWeeklySubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.IsExtra)
			{
				num += 2;
			}
			if (this.CurScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurScore);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060163C6 RID: 91078 RVA: 0x0033B890 File Offset: 0x00339A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklySubLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.Z != 0f)
			{
				this.Z = other.Z;
			}
			if (other.A != 0f)
			{
				this.A = other.A;
			}
			this.loadSubLevels_.Add(other.loadSubLevels_);
			this.unLoadSubLevels_.Add(other.unLoadSubLevels_);
			if (other.IsExtra)
			{
				this.IsExtra = other.IsExtra;
			}
			if (other.CurScore != 0)
			{
				this.CurScore = other.CurScore;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060163C7 RID: 91079 RVA: 0x0033B97A File Offset: 0x00339B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163C8 RID: 91080 RVA: 0x0033B984 File Offset: 0x00339B84
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
				if (num <= 64U)
				{
					if (num <= 18U)
					{
						if (num == 13U)
						{
							this.Z = input.ReadFloat();
							continue;
						}
						if (num == 18U)
						{
							this.unLoadSubLevels_.AddEntriesFrom(ref input, RogueWeeklySubLevelNotify._repeated_unLoadSubLevels_codec);
							continue;
						}
					}
					else
					{
						if (num == 29U)
						{
							this.Y = input.ReadFloat();
							continue;
						}
						if (num == 64U)
						{
							this.CurScore = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 85U)
				{
					if (num == 72U)
					{
						this.IsExtra = input.ReadBool();
						continue;
					}
					if (num == 85U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 93U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 98U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RogueWeeklySubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
					if (num == 112U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400856A RID: 34154
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400856B RID: 34155
		public const int XFieldNumber = 11;

		// Token: 0x0400856C RID: 34156
		private float x_;

		// Token: 0x0400856D RID: 34157
		public const int YFieldNumber = 3;

		// Token: 0x0400856E RID: 34158
		private float y_;

		// Token: 0x0400856F RID: 34159
		public const int ZFieldNumber = 1;

		// Token: 0x04008570 RID: 34160
		private float z_;

		// Token: 0x04008571 RID: 34161
		public const int AFieldNumber = 10;

		// Token: 0x04008572 RID: 34162
		private float a_;

		// Token: 0x04008573 RID: 34163
		public const int LoadSubLevelsFieldNumber = 12;

		// Token: 0x04008574 RID: 34164
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(98U);

		// Token: 0x04008575 RID: 34165
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008576 RID: 34166
		public const int UnLoadSubLevelsFieldNumber = 2;

		// Token: 0x04008577 RID: 34167
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(18U);

		// Token: 0x04008578 RID: 34168
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008579 RID: 34169
		public const int IsExtraFieldNumber = 9;

		// Token: 0x0400857A RID: 34170
		private bool isExtra_;

		// Token: 0x0400857B RID: 34171
		public const int CurScoreFieldNumber = 8;

		// Token: 0x0400857C RID: 34172
		private int curScore_;

		// Token: 0x0400857D RID: 34173
		public const int MaxScoreFieldNumber = 14;

		// Token: 0x0400857E RID: 34174
		private int maxScore_;
	}
}
