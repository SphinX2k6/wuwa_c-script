using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000313 RID: 787
	public sealed class CountryExploreLevel : IMessage<CountryExploreLevel>, IMessage, IEquatable<CountryExploreLevel>, IDeepCloneable<CountryExploreLevel>, IBufferMessage
	{
		// Token: 0x06004F70 RID: 20336 RVA: 0x000C1012 File Offset: 0x000BF212
		[NullableContext(1)]
		public static CountryExploreLevel Create()
		{
			return new CountryExploreLevel();
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x000C1019 File Offset: 0x000BF219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CountryExploreLevel> Parser
		{
			get
			{
				return CountryExploreLevel._parser;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06004F72 RID: 20338 RVA: 0x000C1020 File Offset: 0x000BF220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x000C1023 File Offset: 0x000BF223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreLevel.Descriptor;
			}
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x000C102A File Offset: 0x000BF22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel()
		{
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x000C1032 File Offset: 0x000BF232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel(CountryExploreLevel other) : this()
		{
			this.countryId_ = other.countryId_;
			this.exploreLevel_ = other.exploreLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x000C1063 File Offset: 0x000BF263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel Clone()
		{
			return new CountryExploreLevel(this);
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x000C106B File Offset: 0x000BF26B
		// (set) Token: 0x06004F78 RID: 20344 RVA: 0x000C1073 File Offset: 0x000BF273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountryId
		{
			get
			{
				return this.countryId_;
			}
			set
			{
				this.countryId_ = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x000C107C File Offset: 0x000BF27C
		// (set) Token: 0x06004F7A RID: 20346 RVA: 0x000C1084 File Offset: 0x000BF284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreLevel
		{
			get
			{
				return this.exploreLevel_;
			}
			set
			{
				this.exploreLevel_ = value;
			}
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x000C108D File Offset: 0x000BF28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreLevel);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x000C109B File Offset: 0x000BF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreLevel other)
		{
			return other != null && (other == this || (this.CountryId == other.CountryId && this.ExploreLevel == other.ExploreLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x000C10DC File Offset: 0x000BF2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CountryId != 0)
			{
				num ^= this.CountryId.GetHashCode();
			}
			if (this.ExploreLevel != 0)
			{
				num ^= this.ExploreLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x000C1134 File Offset: 0x000BF334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x000C1141 File Offset: 0x000BF341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x000C114C File Offset: 0x000BF34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountryId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CountryId);
			}
			if (this.ExploreLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExploreLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x000C11A4 File Offset: 0x000BF3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CountryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountryId);
			}
			if (this.ExploreLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x000C11FC File Offset: 0x000BF3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CountryExploreLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CountryId != 0)
			{
				this.CountryId = other.CountryId;
			}
			if (other.ExploreLevel != 0)
			{
				this.ExploreLevel = other.ExploreLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x000C124C File Offset: 0x000BF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x000C1258 File Offset: 0x000BF458
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExploreLevel = input.ReadInt32();
					}
				}
				else
				{
					this.CountryId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400323A RID: 12858
		private static readonly MessageParser<CountryExploreLevel> _parser = new MessageParser<CountryExploreLevel>(() => new CountryExploreLevel());

		// Token: 0x0400323B RID: 12859
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400323C RID: 12860
		public const int CountryIdFieldNumber = 1;

		// Token: 0x0400323D RID: 12861
		private int countryId_;

		// Token: 0x0400323E RID: 12862
		public const int ExploreLevelFieldNumber = 2;

		// Token: 0x0400323F RID: 12863
		private int exploreLevel_;
	}
}
