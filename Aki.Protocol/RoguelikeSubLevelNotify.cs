using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAD RID: 4013
	[NetMessage(EMessageId.RoguelikeSubLevelNotify)]
	public sealed class RoguelikeSubLevelNotify : IMessage<RoguelikeSubLevelNotify>, IMessage, IEquatable<RoguelikeSubLevelNotify>, IDeepCloneable<RoguelikeSubLevelNotify>, IBufferMessage
	{
		// Token: 0x060157C2 RID: 88002 RVA: 0x0031F011 File Offset: 0x0031D211
		[NullableContext(1)]
		public static RoguelikeSubLevelNotify Create()
		{
			return new RoguelikeSubLevelNotify();
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x060157C3 RID: 88003 RVA: 0x0031F018 File Offset: 0x0031D218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x060157C4 RID: 88004 RVA: 0x0031F01B File Offset: 0x0031D21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x060157C5 RID: 88005 RVA: 0x0031F022 File Offset: 0x0031D222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSubLevelNotify()
		{
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x0031F058 File Offset: 0x0031D258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSubLevelNotify(RoguelikeSubLevelNotify other) : this()
		{
			this.loadSubLevel_ = other.loadSubLevel_;
			this.unLoadSubLevel_ = other.unLoadSubLevel_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157C7 RID: 88007 RVA: 0x0031F0E6 File Offset: 0x0031D2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSubLevelNotify Clone()
		{
			return new RoguelikeSubLevelNotify(this);
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x060157C8 RID: 88008 RVA: 0x0031F0EE File Offset: 0x0031D2EE
		// (set) Token: 0x060157C9 RID: 88009 RVA: 0x0031F0F6 File Offset: 0x0031D2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LoadSubLevel
		{
			get
			{
				return this.loadSubLevel_;
			}
			set
			{
				this.loadSubLevel_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x060157CA RID: 88010 RVA: 0x0031F109 File Offset: 0x0031D309
		// (set) Token: 0x060157CB RID: 88011 RVA: 0x0031F111 File Offset: 0x0031D311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string UnLoadSubLevel
		{
			get
			{
				return this.unLoadSubLevel_;
			}
			set
			{
				this.unLoadSubLevel_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x060157CC RID: 88012 RVA: 0x0031F124 File Offset: 0x0031D324
		// (set) Token: 0x060157CD RID: 88013 RVA: 0x0031F12C File Offset: 0x0031D32C
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

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x060157CE RID: 88014 RVA: 0x0031F135 File Offset: 0x0031D335
		// (set) Token: 0x060157CF RID: 88015 RVA: 0x0031F13D File Offset: 0x0031D33D
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

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x060157D0 RID: 88016 RVA: 0x0031F146 File Offset: 0x0031D346
		// (set) Token: 0x060157D1 RID: 88017 RVA: 0x0031F14E File Offset: 0x0031D34E
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

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x060157D2 RID: 88018 RVA: 0x0031F157 File Offset: 0x0031D357
		// (set) Token: 0x060157D3 RID: 88019 RVA: 0x0031F15F File Offset: 0x0031D35F
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

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x060157D4 RID: 88020 RVA: 0x0031F168 File Offset: 0x0031D368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x060157D5 RID: 88021 RVA: 0x0031F170 File Offset: 0x0031D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x060157D6 RID: 88022 RVA: 0x0031F178 File Offset: 0x0031D378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSubLevelNotify);
		}

		// Token: 0x060157D7 RID: 88023 RVA: 0x0031F188 File Offset: 0x0031D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSubLevelNotify other)
		{
			return other != null && (other == this || (!(this.LoadSubLevel != other.LoadSubLevel) && !(this.UnLoadSubLevel != other.UnLoadSubLevel) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x0031F270 File Offset: 0x0031D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadSubLevel.Length != 0)
			{
				num ^= this.LoadSubLevel.GetHashCode();
			}
			if (this.UnLoadSubLevel.Length != 0)
			{
				num ^= this.UnLoadSubLevel.GetHashCode();
			}
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157D9 RID: 88025 RVA: 0x0031F368 File Offset: 0x0031D568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x0031F375 File Offset: 0x0031D575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x0031F380 File Offset: 0x0031D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.A != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.A);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.X);
			}
			if (this.LoadSubLevel.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.LoadSubLevel);
			}
			if (this.UnLoadSubLevel.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.UnLoadSubLevel);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RoguelikeSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.Y != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Y);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.Z);
			}
			this.loadSubLevels_.WriteTo(ref output, RoguelikeSubLevelNotify._repeated_loadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x0031F48C File Offset: 0x0031D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadSubLevel.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LoadSubLevel);
			}
			if (this.UnLoadSubLevel.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UnLoadSubLevel);
			}
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
			num += this.loadSubLevels_.CalculateSize(RoguelikeSubLevelNotify._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(RoguelikeSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x0031F558 File Offset: 0x0031D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSubLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadSubLevel.Length != 0)
			{
				this.LoadSubLevel = other.LoadSubLevel;
			}
			if (other.UnLoadSubLevel.Length != 0)
			{
				this.UnLoadSubLevel = other.UnLoadSubLevel;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x0031F638 File Offset: 0x0031D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157DF RID: 88031 RVA: 0x0031F644 File Offset: 0x0031D844
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
				if (num <= 82U)
				{
					if (num <= 45U)
					{
						if (num == 21U)
						{
							this.A = input.ReadFloat();
							continue;
						}
						if (num == 45U)
						{
							this.X = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 74U)
						{
							this.LoadSubLevel = input.ReadString();
							continue;
						}
						if (num == 82U)
						{
							this.UnLoadSubLevel = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 101U)
				{
					if (num == 90U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RoguelikeSubLevelNotify._repeated_unLoadSubLevels_codec);
						continue;
					}
					if (num == 101U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 117U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 122U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RoguelikeSubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400819A RID: 33178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400819B RID: 33179
		public const int LoadSubLevelFieldNumber = 9;

		// Token: 0x0400819C RID: 33180
		private string loadSubLevel_ = "";

		// Token: 0x0400819D RID: 33181
		public const int UnLoadSubLevelFieldNumber = 10;

		// Token: 0x0400819E RID: 33182
		private string unLoadSubLevel_ = "";

		// Token: 0x0400819F RID: 33183
		public const int XFieldNumber = 5;

		// Token: 0x040081A0 RID: 33184
		private float x_;

		// Token: 0x040081A1 RID: 33185
		public const int YFieldNumber = 12;

		// Token: 0x040081A2 RID: 33186
		private float y_;

		// Token: 0x040081A3 RID: 33187
		public const int ZFieldNumber = 14;

		// Token: 0x040081A4 RID: 33188
		private float z_;

		// Token: 0x040081A5 RID: 33189
		public const int AFieldNumber = 2;

		// Token: 0x040081A6 RID: 33190
		private float a_;

		// Token: 0x040081A7 RID: 33191
		public const int LoadSubLevelsFieldNumber = 15;

		// Token: 0x040081A8 RID: 33192
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(122U);

		// Token: 0x040081A9 RID: 33193
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x040081AA RID: 33194
		public const int UnLoadSubLevelsFieldNumber = 11;

		// Token: 0x040081AB RID: 33195
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(90U);

		// Token: 0x040081AC RID: 33196
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();
	}
}
