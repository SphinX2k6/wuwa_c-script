using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000020 RID: 32
	[NetMessage(EMessageId.AbyssChallengeSubLevelNotify)]
	public sealed class AbyssChallengeSubLevelNotify : IMessage<AbyssChallengeSubLevelNotify>, IMessage, IEquatable<AbyssChallengeSubLevelNotify>, IDeepCloneable<AbyssChallengeSubLevelNotify>, IBufferMessage
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x0002FF22 File Offset: 0x0002E122
		[NullableContext(1)]
		public static AbyssChallengeSubLevelNotify Create()
		{
			return new AbyssChallengeSubLevelNotify();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0002FF29 File Offset: 0x0002E129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0002FF2C File Offset: 0x0002E12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0002FF33 File Offset: 0x0002E133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeSubLevelNotify()
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0002FF54 File Offset: 0x0002E154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeSubLevelNotify(AbyssChallengeSubLevelNotify other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0002FFD6 File Offset: 0x0002E1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeSubLevelNotify Clone()
		{
			return new AbyssChallengeSubLevelNotify(this);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0002FFDE File Offset: 0x0002E1DE
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0002FFE6 File Offset: 0x0002E1E6
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0002FFEF File Offset: 0x0002E1EF
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0002FFF7 File Offset: 0x0002E1F7
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x00030000 File Offset: 0x0002E200
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x00030008 File Offset: 0x0002E208
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x00030011 File Offset: 0x0002E211
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x00030019 File Offset: 0x0002E219
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00030022 File Offset: 0x0002E222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0003002A File Offset: 0x0002E22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00030032 File Offset: 0x0002E232
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0003003A File Offset: 0x0002E23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00030043 File Offset: 0x0002E243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeSubLevelNotify);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00030054 File Offset: 0x0002E254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeSubLevelNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00030120 File Offset: 0x0002E320
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
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000301FB File Offset: 0x0002E3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00030208 File Offset: 0x0002E408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00030214 File Offset: 0x0002E414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.X);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.A);
			}
			this.unLoadSubLevels_.WriteTo(ref output, AbyssChallengeSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.Z != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Z);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoomId);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.Y);
			}
			this.loadSubLevels_.WriteTo(ref output, AbyssChallengeSubLevelNotify._repeated_loadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x000302F8 File Offset: 0x0002E4F8
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
			num += this.loadSubLevels_.CalculateSize(AbyssChallengeSubLevelNotify._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(AbyssChallengeSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000303A0 File Offset: 0x0002E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeSubLevelNotify other)
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
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00030462 File Offset: 0x0002E662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0003046C File Offset: 0x0002E66C
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
				if (num <= 26U)
				{
					if (num == 13U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 21U)
					{
						this.A = input.ReadFloat();
						continue;
					}
					if (num == 26U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, AbyssChallengeSubLevelNotify._repeated_unLoadSubLevels_codec);
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 61U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 80U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 93U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
					if (num == 114U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, AbyssChallengeSubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FAA RID: 8106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FAB RID: 8107
		public const int XFieldNumber = 1;

		// Token: 0x04001FAC RID: 8108
		private float x_;

		// Token: 0x04001FAD RID: 8109
		public const int YFieldNumber = 11;

		// Token: 0x04001FAE RID: 8110
		private float y_;

		// Token: 0x04001FAF RID: 8111
		public const int ZFieldNumber = 7;

		// Token: 0x04001FB0 RID: 8112
		private float z_;

		// Token: 0x04001FB1 RID: 8113
		public const int AFieldNumber = 2;

		// Token: 0x04001FB2 RID: 8114
		private float a_;

		// Token: 0x04001FB3 RID: 8115
		public const int LoadSubLevelsFieldNumber = 14;

		// Token: 0x04001FB4 RID: 8116
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(114U);

		// Token: 0x04001FB5 RID: 8117
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04001FB6 RID: 8118
		public const int UnLoadSubLevelsFieldNumber = 3;

		// Token: 0x04001FB7 RID: 8119
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(26U);

		// Token: 0x04001FB8 RID: 8120
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04001FB9 RID: 8121
		public const int RoomIdFieldNumber = 10;

		// Token: 0x04001FBA RID: 8122
		private int roomId_;
	}
}
