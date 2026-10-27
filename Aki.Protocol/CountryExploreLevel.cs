using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030C RID: 780
	public sealed class CountryExploreLevel : IMessage<CountryExploreLevel>, IMessage, IEquatable<CountryExploreLevel>, IDeepCloneable<CountryExploreLevel>, IBufferMessage
	{
		// Token: 0x06004E97 RID: 20119 RVA: 0x000BEC26 File Offset: 0x000BCE26
		[NullableContext(1)]
		public static CountryExploreLevel Create()
		{
			return new CountryExploreLevel();
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x000BEC2D File Offset: 0x000BCE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CountryExploreLevel> Parser
		{
			get
			{
				return CountryExploreLevel._parser;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x000BEC34 File Offset: 0x000BCE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x000BEC37 File Offset: 0x000BCE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CountryExploreLevel.Descriptor;
			}
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x000BEC3E File Offset: 0x000BCE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel()
		{
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x000BEC46 File Offset: 0x000BCE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel(CountryExploreLevel other) : this()
		{
			this.countryId_ = other.countryId_;
			this.exploreLevel_ = other.exploreLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x000BEC77 File Offset: 0x000BCE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CountryExploreLevel Clone()
		{
			return new CountryExploreLevel(this);
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004E9E RID: 20126 RVA: 0x000BEC7F File Offset: 0x000BCE7F
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x000BEC87 File Offset: 0x000BCE87
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

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x000BEC90 File Offset: 0x000BCE90
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x000BEC98 File Offset: 0x000BCE98
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

		// Token: 0x06004EA2 RID: 20130 RVA: 0x000BECA1 File Offset: 0x000BCEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CountryExploreLevel);
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x000BECAF File Offset: 0x000BCEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CountryExploreLevel other)
		{
			return other != null && (other == this || (this.CountryId == other.CountryId && this.ExploreLevel == other.ExploreLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x000BECF0 File Offset: 0x000BCEF0
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

		// Token: 0x06004EA5 RID: 20133 RVA: 0x000BED48 File Offset: 0x000BCF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x000BED55 File Offset: 0x000BCF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x000BED60 File Offset: 0x000BCF60
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

		// Token: 0x06004EA8 RID: 20136 RVA: 0x000BEDB8 File Offset: 0x000BCFB8
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

		// Token: 0x06004EA9 RID: 20137 RVA: 0x000BEE10 File Offset: 0x000BD010
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

		// Token: 0x06004EAA RID: 20138 RVA: 0x000BEE60 File Offset: 0x000BD060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x000BEE6C File Offset: 0x000BD06C
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

		// Token: 0x040031A3 RID: 12707
		private static readonly MessageParser<CountryExploreLevel> _parser = new MessageParser<CountryExploreLevel>(() => new CountryExploreLevel());

		// Token: 0x040031A4 RID: 12708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031A5 RID: 12709
		public const int CountryIdFieldNumber = 1;

		// Token: 0x040031A6 RID: 12710
		private int countryId_;

		// Token: 0x040031A7 RID: 12711
		public const int ExploreLevelFieldNumber = 2;

		// Token: 0x040031A8 RID: 12712
		private int exploreLevel_;
	}
}
