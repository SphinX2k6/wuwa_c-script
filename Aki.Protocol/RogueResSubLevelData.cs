using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001007 RID: 4103
	public sealed class RogueResSubLevelData : IMessage<RogueResSubLevelData>, IMessage, IEquatable<RogueResSubLevelData>, IDeepCloneable<RogueResSubLevelData>, IBufferMessage
	{
		// Token: 0x06015F16 RID: 89878 RVA: 0x00330D60 File Offset: 0x0032EF60
		[NullableContext(1)]
		public static RogueResSubLevelData Create()
		{
			return new RogueResSubLevelData();
		}

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x06015F17 RID: 89879 RVA: 0x00330D67 File Offset: 0x0032EF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x06015F18 RID: 89880 RVA: 0x00330D6A File Offset: 0x0032EF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSubLevelData.Descriptor;
			}
		}

		// Token: 0x06015F19 RID: 89881 RVA: 0x00330D71 File Offset: 0x0032EF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData()
		{
		}

		// Token: 0x06015F1A RID: 89882 RVA: 0x00330D90 File Offset: 0x0032EF90
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

		// Token: 0x06015F1B RID: 89883 RVA: 0x00330E06 File Offset: 0x0032F006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData Clone()
		{
			return new RogueResSubLevelData(this);
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x06015F1C RID: 89884 RVA: 0x00330E0E File Offset: 0x0032F00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06015F1D RID: 89885 RVA: 0x00330E16 File Offset: 0x0032F016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06015F1E RID: 89886 RVA: 0x00330E1E File Offset: 0x0032F01E
		// (set) Token: 0x06015F1F RID: 89887 RVA: 0x00330E26 File Offset: 0x0032F026
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

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06015F20 RID: 89888 RVA: 0x00330E2F File Offset: 0x0032F02F
		// (set) Token: 0x06015F21 RID: 89889 RVA: 0x00330E37 File Offset: 0x0032F037
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

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x06015F22 RID: 89890 RVA: 0x00330E40 File Offset: 0x0032F040
		// (set) Token: 0x06015F23 RID: 89891 RVA: 0x00330E48 File Offset: 0x0032F048
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

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x06015F24 RID: 89892 RVA: 0x00330E51 File Offset: 0x0032F051
		// (set) Token: 0x06015F25 RID: 89893 RVA: 0x00330E59 File Offset: 0x0032F059
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

		// Token: 0x06015F26 RID: 89894 RVA: 0x00330E62 File Offset: 0x0032F062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSubLevelData);
		}

		// Token: 0x06015F27 RID: 89895 RVA: 0x00330E70 File Offset: 0x0032F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSubLevelData other)
		{
			return other != null && (other == this || (this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F28 RID: 89896 RVA: 0x00330F2C File Offset: 0x0032F12C
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

		// Token: 0x06015F29 RID: 89897 RVA: 0x00330FEE File Offset: 0x0032F1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F2A RID: 89898 RVA: 0x00330FFB File Offset: 0x0032F1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F2B RID: 89899 RVA: 0x00331004 File Offset: 0x0032F204
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

		// Token: 0x06015F2C RID: 89900 RVA: 0x003310CC File Offset: 0x0032F2CC
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

		// Token: 0x06015F2D RID: 89901 RVA: 0x0033115C File Offset: 0x0032F35C
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

		// Token: 0x06015F2E RID: 89902 RVA: 0x0033120A File Offset: 0x0032F40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F2F RID: 89903 RVA: 0x00331214 File Offset: 0x0032F414
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

		// Token: 0x040083B6 RID: 33718
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083B7 RID: 33719
		public const int LoadSubLevelsFieldNumber = 1;

		// Token: 0x040083B8 RID: 33720
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(10U);

		// Token: 0x040083B9 RID: 33721
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x040083BA RID: 33722
		public const int UnLoadSubLevelsFieldNumber = 2;

		// Token: 0x040083BB RID: 33723
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(18U);

		// Token: 0x040083BC RID: 33724
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x040083BD RID: 33725
		public const int XFieldNumber = 3;

		// Token: 0x040083BE RID: 33726
		private float x_;

		// Token: 0x040083BF RID: 33727
		public const int YFieldNumber = 4;

		// Token: 0x040083C0 RID: 33728
		private float y_;

		// Token: 0x040083C1 RID: 33729
		public const int ZFieldNumber = 5;

		// Token: 0x040083C2 RID: 33730
		private float z_;

		// Token: 0x040083C3 RID: 33731
		public const int AFieldNumber = 6;

		// Token: 0x040083C4 RID: 33732
		private float a_;
	}
}
