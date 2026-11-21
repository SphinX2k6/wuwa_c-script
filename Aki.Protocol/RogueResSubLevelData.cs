using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF7 RID: 4087
	public sealed class RogueResSubLevelData : IMessage<RogueResSubLevelData>, IMessage, IEquatable<RogueResSubLevelData>, IDeepCloneable<RogueResSubLevelData>, IBufferMessage
	{
		// Token: 0x06015E31 RID: 89649 RVA: 0x0032F6A4 File Offset: 0x0032D8A4
		[NullableContext(1)]
		public static RogueResSubLevelData Create()
		{
			return new RogueResSubLevelData();
		}

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06015E32 RID: 89650 RVA: 0x0032F6AB File Offset: 0x0032D8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06015E33 RID: 89651 RVA: 0x0032F6AE File Offset: 0x0032D8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSubLevelData.Descriptor;
			}
		}

		// Token: 0x06015E34 RID: 89652 RVA: 0x0032F6B5 File Offset: 0x0032D8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData()
		{
		}

		// Token: 0x06015E35 RID: 89653 RVA: 0x0032F6D4 File Offset: 0x0032D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData(RogueResSubLevelData other) : this()
		{
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E36 RID: 89654 RVA: 0x0032F74A File Offset: 0x0032D94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData Clone()
		{
			return new RogueResSubLevelData(this);
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x06015E37 RID: 89655 RVA: 0x0032F752 File Offset: 0x0032D952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x06015E38 RID: 89656 RVA: 0x0032F75A File Offset: 0x0032D95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x06015E39 RID: 89657 RVA: 0x0032F762 File Offset: 0x0032D962
		// (set) Token: 0x06015E3A RID: 89658 RVA: 0x0032F76A File Offset: 0x0032D96A
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

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x06015E3B RID: 89659 RVA: 0x0032F773 File Offset: 0x0032D973
		// (set) Token: 0x06015E3C RID: 89660 RVA: 0x0032F77B File Offset: 0x0032D97B
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

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x06015E3D RID: 89661 RVA: 0x0032F784 File Offset: 0x0032D984
		// (set) Token: 0x06015E3E RID: 89662 RVA: 0x0032F78C File Offset: 0x0032D98C
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

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06015E3F RID: 89663 RVA: 0x0032F795 File Offset: 0x0032D995
		// (set) Token: 0x06015E40 RID: 89664 RVA: 0x0032F79D File Offset: 0x0032D99D
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

		// Token: 0x06015E41 RID: 89665 RVA: 0x0032F7A6 File Offset: 0x0032D9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSubLevelData);
		}

		// Token: 0x06015E42 RID: 89666 RVA: 0x0032F7B4 File Offset: 0x0032D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSubLevelData other)
		{
			return other != null && (other == this || (this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E43 RID: 89667 RVA: 0x0032F870 File Offset: 0x0032DA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.loadSubLevels_.GetHashCode();
			num ^= this.unLoadSubLevels_.GetHashCode();
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E44 RID: 89668 RVA: 0x0032F932 File Offset: 0x0032DB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E45 RID: 89669 RVA: 0x0032F93F File Offset: 0x0032DB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E46 RID: 89670 RVA: 0x0032F948 File Offset: 0x0032DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loadSubLevels_.WriteTo(ref output, RogueResSubLevelData._repeated_loadSubLevels_codec);
			this.unLoadSubLevels_.WriteTo(ref output, RogueResSubLevelData._repeated_unLoadSubLevels_codec);
			if (this.X != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Y);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Z);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.A);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E47 RID: 89671 RVA: 0x0032FA10 File Offset: 0x0032DC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.loadSubLevels_.CalculateSize(RogueResSubLevelData._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(RogueResSubLevelData._repeated_unLoadSubLevels_codec);
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E48 RID: 89672 RVA: 0x0032FAA0 File Offset: 0x0032DCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSubLevelData other)
		{
			if (other == null)
			{
				return;
			}
			this.loadSubLevels_.Add(other.loadSubLevels_);
			this.unLoadSubLevels_.Add(other.unLoadSubLevels_);
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E49 RID: 89673 RVA: 0x0032FB4E File Offset: 0x0032DD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E4A RID: 89674 RVA: 0x0032FB58 File Offset: 0x0032DD58
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
				if (num <= 29U)
				{
					if (num == 10U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RogueResSubLevelData._repeated_loadSubLevels_codec);
						continue;
					}
					if (num == 18U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RogueResSubLevelData._repeated_unLoadSubLevels_codec);
						continue;
					}
					if (num == 29U)
					{
						this.X = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
					if (num == 45U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 53U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040083E0 RID: 33760
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083E1 RID: 33761
		public const int LoadSubLevelsFieldNumber = 1;

		// Token: 0x040083E2 RID: 33762
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(10U);

		// Token: 0x040083E3 RID: 33763
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x040083E4 RID: 33764
		public const int UnLoadSubLevelsFieldNumber = 2;

		// Token: 0x040083E5 RID: 33765
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(18U);

		// Token: 0x040083E6 RID: 33766
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x040083E7 RID: 33767
		public const int XFieldNumber = 3;

		// Token: 0x040083E8 RID: 33768
		private float x_;

		// Token: 0x040083E9 RID: 33769
		public const int YFieldNumber = 4;

		// Token: 0x040083EA RID: 33770
		private float y_;

		// Token: 0x040083EB RID: 33771
		public const int ZFieldNumber = 5;

		// Token: 0x040083EC RID: 33772
		private float z_;

		// Token: 0x040083ED RID: 33773
		public const int AFieldNumber = 6;

		// Token: 0x040083EE RID: 33774
		private float a_;
	}
}
