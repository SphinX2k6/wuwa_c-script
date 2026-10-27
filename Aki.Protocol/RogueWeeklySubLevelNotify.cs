using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104B RID: 4171
	[NetMessage(EMessageId.RogueWeeklySubLevelNotify)]
	public sealed class RogueWeeklySubLevelNotify : IMessage<RogueWeeklySubLevelNotify>, IMessage, IEquatable<RogueWeeklySubLevelNotify>, IDeepCloneable<RogueWeeklySubLevelNotify>, IBufferMessage
	{
		// Token: 0x0601648E RID: 91278 RVA: 0x0033C9FD File Offset: 0x0033ABFD
		[NullableContext(1)]
		public static RogueWeeklySubLevelNotify Create()
		{
			return new RogueWeeklySubLevelNotify();
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0601648F RID: 91279 RVA: 0x0033CA04 File Offset: 0x0033AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x06016490 RID: 91280 RVA: 0x0033CA07 File Offset: 0x0033AC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklySubLevelNotify.Descriptor;
			}
		}

		// Token: 0x06016491 RID: 91281 RVA: 0x0033CA0E File Offset: 0x0033AC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklySubLevelNotify()
		{
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x0033CA2C File Offset: 0x0033AC2C
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

		// Token: 0x06016493 RID: 91283 RVA: 0x0033CAC6 File Offset: 0x0033ACC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklySubLevelNotify Clone()
		{
			return new RogueWeeklySubLevelNotify(this);
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x06016494 RID: 91284 RVA: 0x0033CACE File Offset: 0x0033ACCE
		// (set) Token: 0x06016495 RID: 91285 RVA: 0x0033CAD6 File Offset: 0x0033ACD6
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

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x06016496 RID: 91286 RVA: 0x0033CADF File Offset: 0x0033ACDF
		// (set) Token: 0x06016497 RID: 91287 RVA: 0x0033CAE7 File Offset: 0x0033ACE7
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

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x06016498 RID: 91288 RVA: 0x0033CAF0 File Offset: 0x0033ACF0
		// (set) Token: 0x06016499 RID: 91289 RVA: 0x0033CAF8 File Offset: 0x0033ACF8
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

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x0601649A RID: 91290 RVA: 0x0033CB01 File Offset: 0x0033AD01
		// (set) Token: 0x0601649B RID: 91291 RVA: 0x0033CB09 File Offset: 0x0033AD09
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

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x0601649C RID: 91292 RVA: 0x0033CB12 File Offset: 0x0033AD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0601649D RID: 91293 RVA: 0x0033CB1A File Offset: 0x0033AD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0601649E RID: 91294 RVA: 0x0033CB22 File Offset: 0x0033AD22
		// (set) Token: 0x0601649F RID: 91295 RVA: 0x0033CB2A File Offset: 0x0033AD2A
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

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x060164A0 RID: 91296 RVA: 0x0033CB33 File Offset: 0x0033AD33
		// (set) Token: 0x060164A1 RID: 91297 RVA: 0x0033CB3B File Offset: 0x0033AD3B
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

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x060164A2 RID: 91298 RVA: 0x0033CB44 File Offset: 0x0033AD44
		// (set) Token: 0x060164A3 RID: 91299 RVA: 0x0033CB4C File Offset: 0x0033AD4C
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

		// Token: 0x060164A4 RID: 91300 RVA: 0x0033CB55 File Offset: 0x0033AD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklySubLevelNotify);
		}

		// Token: 0x060164A5 RID: 91301 RVA: 0x0033CB64 File Offset: 0x0033AD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklySubLevelNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && this.IsExtra == other.IsExtra && this.CurScore == other.CurScore && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164A6 RID: 91302 RVA: 0x0033CC50 File Offset: 0x0033AE50
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

		// Token: 0x060164A7 RID: 91303 RVA: 0x0033CD5D File Offset: 0x0033AF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164A8 RID: 91304 RVA: 0x0033CD6A File Offset: 0x0033AF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164A9 RID: 91305 RVA: 0x0033CD74 File Offset: 0x0033AF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Y != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Y);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RogueWeeklySubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.IsExtra)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsExtra);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.Z);
			}
			if (this.CurScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CurScore);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxScore);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.X);
			}
			this.loadSubLevels_.WriteTo(ref output, RogueWeeklySubLevelNotify._repeated_loadSubLevels_codec);
			if (this.A != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.A);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164AA RID: 91306 RVA: 0x0033CE90 File Offset: 0x0033B090
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

		// Token: 0x060164AB RID: 91307 RVA: 0x0033CF5C File Offset: 0x0033B15C
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

		// Token: 0x060164AC RID: 91308 RVA: 0x0033D046 File Offset: 0x0033B246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164AD RID: 91309 RVA: 0x0033D050 File Offset: 0x0033B250
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
				if (num <= 69U)
				{
					if (num <= 26U)
					{
						if (num == 13U)
						{
							this.Y = input.ReadFloat();
							continue;
						}
						if (num == 26U)
						{
							this.unLoadSubLevels_.AddEntriesFrom(ref input, RogueWeeklySubLevelNotify._repeated_unLoadSubLevels_codec);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.IsExtra = input.ReadBool();
							continue;
						}
						if (num == 69U)
						{
							this.Z = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.CurScore = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 101U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 106U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RogueWeeklySubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
					if (num == 125U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008540 RID: 34112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008541 RID: 34113
		public const int XFieldNumber = 12;

		// Token: 0x04008542 RID: 34114
		private float x_;

		// Token: 0x04008543 RID: 34115
		public const int YFieldNumber = 1;

		// Token: 0x04008544 RID: 34116
		private float y_;

		// Token: 0x04008545 RID: 34117
		public const int ZFieldNumber = 8;

		// Token: 0x04008546 RID: 34118
		private float z_;

		// Token: 0x04008547 RID: 34119
		public const int AFieldNumber = 15;

		// Token: 0x04008548 RID: 34120
		private float a_;

		// Token: 0x04008549 RID: 34121
		public const int LoadSubLevelsFieldNumber = 13;

		// Token: 0x0400854A RID: 34122
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(106U);

		// Token: 0x0400854B RID: 34123
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x0400854C RID: 34124
		public const int UnLoadSubLevelsFieldNumber = 3;

		// Token: 0x0400854D RID: 34125
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(26U);

		// Token: 0x0400854E RID: 34126
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x0400854F RID: 34127
		public const int IsExtraFieldNumber = 7;

		// Token: 0x04008550 RID: 34128
		private bool isExtra_;

		// Token: 0x04008551 RID: 34129
		public const int CurScoreFieldNumber = 10;

		// Token: 0x04008552 RID: 34130
		private int curScore_;

		// Token: 0x04008553 RID: 34131
		public const int MaxScoreFieldNumber = 11;

		// Token: 0x04008554 RID: 34132
		private int maxScore_;
	}
}
