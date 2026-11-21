using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134F RID: 4943
	public sealed class SurvivorsRole : IMessage<SurvivorsRole>, IMessage, IEquatable<SurvivorsRole>, IDeepCloneable<SurvivorsRole>, IBufferMessage
	{
		// Token: 0x0601A571 RID: 107889 RVA: 0x003D6E4A File Offset: 0x003D504A
		[NullableContext(1)]
		public static SurvivorsRole Create()
		{
			return new SurvivorsRole();
		}

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x0601A572 RID: 107890 RVA: 0x003D6E51 File Offset: 0x003D5051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x0601A573 RID: 107891 RVA: 0x003D6E54 File Offset: 0x003D5054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRole.Descriptor;
			}
		}

		// Token: 0x0601A574 RID: 107892 RVA: 0x003D6E5B File Offset: 0x003D505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole()
		{
		}

		// Token: 0x0601A575 RID: 107893 RVA: 0x003D6E7C File Offset: 0x003D507C
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

		// Token: 0x0601A576 RID: 107894 RVA: 0x003D6EDA File Offset: 0x003D50DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole Clone()
		{
			return new SurvivorsRole(this);
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x0601A577 RID: 107895 RVA: 0x003D6EE2 File Offset: 0x003D50E2
		// (set) Token: 0x0601A578 RID: 107896 RVA: 0x003D6EEA File Offset: 0x003D50EA
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

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x0601A579 RID: 107897 RVA: 0x003D6EF3 File Offset: 0x003D50F3
		// (set) Token: 0x0601A57A RID: 107898 RVA: 0x003D6EFB File Offset: 0x003D50FB
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

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x0601A57B RID: 107899 RVA: 0x003D6F04 File Offset: 0x003D5104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affixs
		{
			get
			{
				return this.affixs_;
			}
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x0601A57C RID: 107900 RVA: 0x003D6F0C File Offset: 0x003D510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Evolves
		{
			get
			{
				return this.evolves_;
			}
		}

		// Token: 0x0601A57D RID: 107901 RVA: 0x003D6F14 File Offset: 0x003D5114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRole);
		}

		// Token: 0x0601A57E RID: 107902 RVA: 0x003D6F24 File Offset: 0x003D5124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRole other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MaxLevel == other.MaxLevel && this.affixs_.Equals(other.affixs_) && this.evolves_.Equals(other.evolves_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A57F RID: 107903 RVA: 0x003D6F98 File Offset: 0x003D5198
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

		// Token: 0x0601A580 RID: 107904 RVA: 0x003D700C File Offset: 0x003D520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x003D7019 File Offset: 0x003D5219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x003D7024 File Offset: 0x003D5224
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

		// Token: 0x0601A583 RID: 107907 RVA: 0x003D70A0 File Offset: 0x003D52A0
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

		// Token: 0x0601A584 RID: 107908 RVA: 0x003D711C File Offset: 0x003D531C
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

		// Token: 0x0601A585 RID: 107909 RVA: 0x003D718E File Offset: 0x003D538E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A586 RID: 107910 RVA: 0x003D7198 File Offset: 0x003D5398
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

		// Token: 0x04009AC4 RID: 39620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AC5 RID: 39621
		public const int LevelFieldNumber = 1;

		// Token: 0x04009AC6 RID: 39622
		private int level_;

		// Token: 0x04009AC7 RID: 39623
		public const int MaxLevelFieldNumber = 2;

		// Token: 0x04009AC8 RID: 39624
		private int maxLevel_;

		// Token: 0x04009AC9 RID: 39625
		public const int AffixsFieldNumber = 3;

		// Token: 0x04009ACA RID: 39626
		private static readonly FieldCodec<int> _repeated_affixs_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009ACB RID: 39627
		private readonly RepeatedField<int> affixs_ = new RepeatedField<int>();

		// Token: 0x04009ACC RID: 39628
		public const int EvolvesFieldNumber = 4;

		// Token: 0x04009ACD RID: 39629
		private static readonly FieldCodec<int> _repeated_evolves_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009ACE RID: 39630
		private readonly RepeatedField<int> evolves_ = new RepeatedField<int>();
	}
}
