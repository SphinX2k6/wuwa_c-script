using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E0 RID: 4832
	public sealed class SurvivorsRole : IMessage<SurvivorsRole>, IMessage, IEquatable<SurvivorsRole>, IDeepCloneable<SurvivorsRole>, IBufferMessage
	{
		// Token: 0x06019B3B RID: 105275 RVA: 0x003BC71A File Offset: 0x003BA91A
		[NullableContext(1)]
		public static SurvivorsRole Create()
		{
			return new SurvivorsRole();
		}

		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x06019B3C RID: 105276 RVA: 0x003BC721 File Offset: 0x003BA921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x06019B3D RID: 105277 RVA: 0x003BC724 File Offset: 0x003BA924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRole.Descriptor;
			}
		}

		// Token: 0x06019B3E RID: 105278 RVA: 0x003BC72B File Offset: 0x003BA92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole()
		{
		}

		// Token: 0x06019B3F RID: 105279 RVA: 0x003BC74C File Offset: 0x003BA94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole(SurvivorsRole other) : this()
		{
			this.level_ = other.level_;
			this.maxLevel_ = other.maxLevel_;
			this.affixs_ = other.affixs_.Clone();
			this.evolves_ = other.evolves_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B40 RID: 105280 RVA: 0x003BC7AA File Offset: 0x003BA9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole Clone()
		{
			return new SurvivorsRole(this);
		}

		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x06019B41 RID: 105281 RVA: 0x003BC7B2 File Offset: 0x003BA9B2
		// (set) Token: 0x06019B42 RID: 105282 RVA: 0x003BC7BA File Offset: 0x003BA9BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x06019B43 RID: 105283 RVA: 0x003BC7C3 File Offset: 0x003BA9C3
		// (set) Token: 0x06019B44 RID: 105284 RVA: 0x003BC7CB File Offset: 0x003BA9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLevel
		{
			get
			{
				return this.maxLevel_;
			}
			set
			{
				this.maxLevel_ = value;
			}
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x06019B45 RID: 105285 RVA: 0x003BC7D4 File Offset: 0x003BA9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affixs
		{
			get
			{
				return this.affixs_;
			}
		}

		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x06019B46 RID: 105286 RVA: 0x003BC7DC File Offset: 0x003BA9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Evolves
		{
			get
			{
				return this.evolves_;
			}
		}

		// Token: 0x06019B47 RID: 105287 RVA: 0x003BC7E4 File Offset: 0x003BA9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRole);
		}

		// Token: 0x06019B48 RID: 105288 RVA: 0x003BC7F4 File Offset: 0x003BA9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRole other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MaxLevel == other.MaxLevel && this.affixs_.Equals(other.affixs_) && this.evolves_.Equals(other.evolves_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B49 RID: 105289 RVA: 0x003BC868 File Offset: 0x003BAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MaxLevel != 0)
			{
				num ^= this.MaxLevel.GetHashCode();
			}
			num ^= this.affixs_.GetHashCode();
			num ^= this.evolves_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B4A RID: 105290 RVA: 0x003BC8DC File Offset: 0x003BAADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B4B RID: 105291 RVA: 0x003BC8E9 File Offset: 0x003BAAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B4C RID: 105292 RVA: 0x003BC8F4 File Offset: 0x003BAAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.MaxLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxLevel);
			}
			this.affixs_.WriteTo(ref output, SurvivorsRole._repeated_affixs_codec);
			this.evolves_.WriteTo(ref output, SurvivorsRole._repeated_evolves_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B4D RID: 105293 RVA: 0x003BC970 File Offset: 0x003BAB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.MaxLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLevel);
			}
			num += this.affixs_.CalculateSize(SurvivorsRole._repeated_affixs_codec);
			num += this.evolves_.CalculateSize(SurvivorsRole._repeated_evolves_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B4E RID: 105294 RVA: 0x003BC9EC File Offset: 0x003BABEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.MaxLevel != 0)
			{
				this.MaxLevel = other.MaxLevel;
			}
			this.affixs_.Add(other.affixs_);
			this.evolves_.Add(other.evolves_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B4F RID: 105295 RVA: 0x003BCA5E File Offset: 0x003BAC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B50 RID: 105296 RVA: 0x003BCA68 File Offset: 0x003BAC68
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MaxLevel = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_5D;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_5D;
					}
					if (num == 32U || num == 34U)
					{
						this.evolves_.AddEntriesFrom(ref input, SurvivorsRole._repeated_evolves_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5D:
				this.affixs_.AddEntriesFrom(ref input, SurvivorsRole._repeated_affixs_codec);
			}
		}

		// Token: 0x0400969A RID: 38554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400969B RID: 38555
		public const int LevelFieldNumber = 1;

		// Token: 0x0400969C RID: 38556
		private int level_;

		// Token: 0x0400969D RID: 38557
		public const int MaxLevelFieldNumber = 2;

		// Token: 0x0400969E RID: 38558
		private int maxLevel_;

		// Token: 0x0400969F RID: 38559
		public const int AffixsFieldNumber = 3;

		// Token: 0x040096A0 RID: 38560
		private static readonly FieldCodec<int> _repeated_affixs_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040096A1 RID: 38561
		private readonly RepeatedField<int> affixs_ = new RepeatedField<int>();

		// Token: 0x040096A2 RID: 38562
		public const int EvolvesFieldNumber = 4;

		// Token: 0x040096A3 RID: 38563
		private static readonly FieldCodec<int> _repeated_evolves_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040096A4 RID: 38564
		private readonly RepeatedField<int> evolves_ = new RepeatedField<int>();
	}
}
