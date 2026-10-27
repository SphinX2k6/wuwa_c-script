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
		// Token: 0x06001108 RID: 4360 RVA: 0x0002F96E File Offset: 0x0002DB6E
		[NullableContext(1)]
		public static AbyssChallengeSubLevelNotify Create()
		{
			return new AbyssChallengeSubLevelNotify();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0002F975 File Offset: 0x0002DB75
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
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0002F978 File Offset: 0x0002DB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0002F97F File Offset: 0x0002DB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeSubLevelNotify()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0002F9A0 File Offset: 0x0002DBA0
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

		// Token: 0x0600110D RID: 4365 RVA: 0x0002FA22 File Offset: 0x0002DC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeSubLevelNotify Clone()
		{
			return new AbyssChallengeSubLevelNotify(this);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0002FA2A File Offset: 0x0002DC2A
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0002FA32 File Offset: 0x0002DC32
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
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0002FA3B File Offset: 0x0002DC3B
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x0002FA43 File Offset: 0x0002DC43
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
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x0002FA54 File Offset: 0x0002DC54
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
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0002FA5D File Offset: 0x0002DC5D
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x0002FA65 File Offset: 0x0002DC65
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
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0002FA6E File Offset: 0x0002DC6E
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
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0002FA76 File Offset: 0x0002DC76
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
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0002FA7E File Offset: 0x0002DC7E
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x0002FA86 File Offset: 0x0002DC86
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

		// Token: 0x0600111A RID: 4378 RVA: 0x0002FA8F File Offset: 0x0002DC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeSubLevelNotify);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeSubLevelNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0002FB6C File Offset: 0x0002DD6C
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

		// Token: 0x0600111D RID: 4381 RVA: 0x0002FC47 File Offset: 0x0002DE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0002FC54 File Offset: 0x0002DE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0002FC60 File Offset: 0x0002DE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Z != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Z);
			}
			this.unLoadSubLevels_.WriteTo(ref output, AbyssChallengeSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.A != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.A);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.X);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoomId);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Y);
			}
			this.loadSubLevels_.WriteTo(ref output, AbyssChallengeSubLevelNotify._repeated_loadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0002FD44 File Offset: 0x0002DF44
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

		// Token: 0x06001121 RID: 4385 RVA: 0x0002FDEC File Offset: 0x0002DFEC
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

		// Token: 0x06001122 RID: 4386 RVA: 0x0002FEAE File Offset: 0x0002E0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
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
				if (num <= 45U)
				{
					if (num == 13U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 18U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, AbyssChallengeSubLevelNotify._repeated_unLoadSubLevels_codec);
						continue;
					}
					if (num == 45U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 61U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 72U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 109U)
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

		// Token: 0x04001F54 RID: 8020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F55 RID: 8021
		public const int XFieldNumber = 7;

		// Token: 0x04001F56 RID: 8022
		private float x_;

		// Token: 0x04001F57 RID: 8023
		public const int YFieldNumber = 13;

		// Token: 0x04001F58 RID: 8024
		private float y_;

		// Token: 0x04001F59 RID: 8025
		public const int ZFieldNumber = 1;

		// Token: 0x04001F5A RID: 8026
		private float z_;

		// Token: 0x04001F5B RID: 8027
		public const int AFieldNumber = 5;

		// Token: 0x04001F5C RID: 8028
		private float a_;

		// Token: 0x04001F5D RID: 8029
		public const int LoadSubLevelsFieldNumber = 14;

		// Token: 0x04001F5E RID: 8030
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(114U);

		// Token: 0x04001F5F RID: 8031
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04001F60 RID: 8032
		public const int UnLoadSubLevelsFieldNumber = 2;

		// Token: 0x04001F61 RID: 8033
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(18U);

		// Token: 0x04001F62 RID: 8034
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04001F63 RID: 8035
		public const int RoomIdFieldNumber = 9;

		// Token: 0x04001F64 RID: 8036
		private int roomId_;
	}
}
