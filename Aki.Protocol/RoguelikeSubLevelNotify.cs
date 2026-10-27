using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBD RID: 4029
	[NetMessage(EMessageId.RoguelikeSubLevelNotify)]
	public sealed class RoguelikeSubLevelNotify : IMessage<RoguelikeSubLevelNotify>, IMessage, IEquatable<RoguelikeSubLevelNotify>, IDeepCloneable<RoguelikeSubLevelNotify>, IBufferMessage
	{
		// Token: 0x060158A7 RID: 88231 RVA: 0x003206C1 File Offset: 0x0031E8C1
		[NullableContext(1)]
		public static RoguelikeSubLevelNotify Create()
		{
			return new RoguelikeSubLevelNotify();
		}

		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x060158A8 RID: 88232 RVA: 0x003206C8 File Offset: 0x0031E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x060158A9 RID: 88233 RVA: 0x003206CB File Offset: 0x0031E8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x060158AA RID: 88234 RVA: 0x003206D2 File Offset: 0x0031E8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSubLevelNotify()
		{
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x00320708 File Offset: 0x0031E908
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

		// Token: 0x060158AC RID: 88236 RVA: 0x00320796 File Offset: 0x0031E996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSubLevelNotify Clone()
		{
			return new RoguelikeSubLevelNotify(this);
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x060158AD RID: 88237 RVA: 0x0032079E File Offset: 0x0031E99E
		// (set) Token: 0x060158AE RID: 88238 RVA: 0x003207A6 File Offset: 0x0031E9A6
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

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x060158AF RID: 88239 RVA: 0x003207B9 File Offset: 0x0031E9B9
		// (set) Token: 0x060158B0 RID: 88240 RVA: 0x003207C1 File Offset: 0x0031E9C1
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

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x060158B1 RID: 88241 RVA: 0x003207D4 File Offset: 0x0031E9D4
		// (set) Token: 0x060158B2 RID: 88242 RVA: 0x003207DC File Offset: 0x0031E9DC
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

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x060158B3 RID: 88243 RVA: 0x003207E5 File Offset: 0x0031E9E5
		// (set) Token: 0x060158B4 RID: 88244 RVA: 0x003207ED File Offset: 0x0031E9ED
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

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x060158B5 RID: 88245 RVA: 0x003207F6 File Offset: 0x0031E9F6
		// (set) Token: 0x060158B6 RID: 88246 RVA: 0x003207FE File Offset: 0x0031E9FE
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

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x060158B7 RID: 88247 RVA: 0x00320807 File Offset: 0x0031EA07
		// (set) Token: 0x060158B8 RID: 88248 RVA: 0x0032080F File Offset: 0x0031EA0F
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

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x060158B9 RID: 88249 RVA: 0x00320818 File Offset: 0x0031EA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x060158BA RID: 88250 RVA: 0x00320820 File Offset: 0x0031EA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x060158BB RID: 88251 RVA: 0x00320828 File Offset: 0x0031EA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSubLevelNotify);
		}

		// Token: 0x060158BC RID: 88252 RVA: 0x00320838 File Offset: 0x0031EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSubLevelNotify other)
		{
			return other != null && (other == this || (!(this.LoadSubLevel != other.LoadSubLevel) && !(this.UnLoadSubLevel != other.UnLoadSubLevel) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158BD RID: 88253 RVA: 0x00320920 File Offset: 0x0031EB20
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

		// Token: 0x060158BE RID: 88254 RVA: 0x00320A18 File Offset: 0x0031EC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158BF RID: 88255 RVA: 0x00320A25 File Offset: 0x0031EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158C0 RID: 88256 RVA: 0x00320A30 File Offset: 0x0031EC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loadSubLevels_.WriteTo(ref output, RoguelikeSubLevelNotify._repeated_loadSubLevels_codec);
			if (this.Z != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Z);
			}
			if (this.UnLoadSubLevel.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.UnLoadSubLevel);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Y);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.X);
			}
			if (this.LoadSubLevel.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.LoadSubLevel);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RoguelikeSubLevelNotify._repeated_unLoadSubLevels_codec);
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

		// Token: 0x060158C1 RID: 88257 RVA: 0x00320B3C File Offset: 0x0031ED3C
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

		// Token: 0x060158C2 RID: 88258 RVA: 0x00320C08 File Offset: 0x0031EE08
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

		// Token: 0x060158C3 RID: 88259 RVA: 0x00320CE8 File Offset: 0x0031EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158C4 RID: 88260 RVA: 0x00320CF4 File Offset: 0x0031EEF4
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
				if (num <= 61U)
				{
					if (num <= 21U)
					{
						if (num == 10U)
						{
							this.loadSubLevels_.AddEntriesFrom(ref input, RoguelikeSubLevelNotify._repeated_loadSubLevels_codec);
							continue;
						}
						if (num == 21U)
						{
							this.Z = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.UnLoadSubLevel = input.ReadString();
							continue;
						}
						if (num == 61U)
						{
							this.Y = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 85U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 90U)
					{
						this.LoadSubLevel = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RoguelikeSubLevelNotify._repeated_unLoadSubLevels_codec);
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

		// Token: 0x04008170 RID: 33136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008171 RID: 33137
		public const int LoadSubLevelFieldNumber = 11;

		// Token: 0x04008172 RID: 33138
		private string loadSubLevel_ = "";

		// Token: 0x04008173 RID: 33139
		public const int UnLoadSubLevelFieldNumber = 4;

		// Token: 0x04008174 RID: 33140
		private string unLoadSubLevel_ = "";

		// Token: 0x04008175 RID: 33141
		public const int XFieldNumber = 10;

		// Token: 0x04008176 RID: 33142
		private float x_;

		// Token: 0x04008177 RID: 33143
		public const int YFieldNumber = 7;

		// Token: 0x04008178 RID: 33144
		private float y_;

		// Token: 0x04008179 RID: 33145
		public const int ZFieldNumber = 2;

		// Token: 0x0400817A RID: 33146
		private float z_;

		// Token: 0x0400817B RID: 33147
		public const int AFieldNumber = 15;

		// Token: 0x0400817C RID: 33148
		private float a_;

		// Token: 0x0400817D RID: 33149
		public const int LoadSubLevelsFieldNumber = 1;

		// Token: 0x0400817E RID: 33150
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(10U);

		// Token: 0x0400817F RID: 33151
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008180 RID: 33152
		public const int UnLoadSubLevelsFieldNumber = 12;

		// Token: 0x04008181 RID: 33153
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(98U);

		// Token: 0x04008182 RID: 33154
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();
	}
}
