using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000509 RID: 1289
	public sealed class ExploreSkillRoulette : IMessage<ExploreSkillRoulette>, IMessage, IEquatable<ExploreSkillRoulette>, IDeepCloneable<ExploreSkillRoulette>, IBufferMessage
	{
		// Token: 0x06007953 RID: 31059 RVA: 0x00126E98 File Offset: 0x00125098
		[NullableContext(1)]
		public static ExploreSkillRoulette Create()
		{
			return new ExploreSkillRoulette();
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x00126E9F File Offset: 0x0012509F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExploreSkillRoulette> Parser
		{
			get
			{
				return ExploreSkillRoulette._parser;
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x00126EA6 File Offset: 0x001250A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06007956 RID: 31062 RVA: 0x00126EA9 File Offset: 0x001250A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRoulette.Descriptor;
			}
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00126EB0 File Offset: 0x001250B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette()
		{
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00126EC4 File Offset: 0x001250C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette(ExploreSkillRoulette other) : this()
		{
			this.skillIds_ = other.skillIds_.Clone();
			this.extraItemId_ = other.extraItemId_;
			this.exploreSkill_ = other.exploreSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00126F11 File Offset: 0x00125111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette Clone()
		{
			return new ExploreSkillRoulette(this);
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x00126F19 File Offset: 0x00125119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillIds
		{
			get
			{
				return this.skillIds_;
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x0600795B RID: 31067 RVA: 0x00126F21 File Offset: 0x00125121
		// (set) Token: 0x0600795C RID: 31068 RVA: 0x00126F29 File Offset: 0x00125129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraItemId
		{
			get
			{
				return this.extraItemId_;
			}
			set
			{
				this.extraItemId_ = value;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x0600795D RID: 31069 RVA: 0x00126F32 File Offset: 0x00125132
		// (set) Token: 0x0600795E RID: 31070 RVA: 0x00126F3A File Offset: 0x0012513A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreSkill
		{
			get
			{
				return this.exploreSkill_;
			}
			set
			{
				this.exploreSkill_ = value;
			}
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x00126F43 File Offset: 0x00125143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRoulette);
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00126F54 File Offset: 0x00125154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRoulette other)
		{
			return other != null && (other == this || (this.skillIds_.Equals(other.skillIds_) && this.ExtraItemId == other.ExtraItemId && this.ExploreSkill == other.ExploreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00126FB4 File Offset: 0x001251B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillIds_.GetHashCode();
			if (this.ExtraItemId != 0)
			{
				num ^= this.ExtraItemId.GetHashCode();
			}
			if (this.ExploreSkill != 0)
			{
				num ^= this.ExploreSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x0012701A File Offset: 0x0012521A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x00127027 File Offset: 0x00125227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x00127030 File Offset: 0x00125230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillIds_.WriteTo(ref output, ExploreSkillRoulette._repeated_skillIds_codec);
			if (this.ExtraItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExtraItemId);
			}
			if (this.ExploreSkill != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x0012709C File Offset: 0x0012529C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillIds_.CalculateSize(ExploreSkillRoulette._repeated_skillIds_codec);
			if (this.ExtraItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraItemId);
			}
			if (this.ExploreSkill != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00127108 File Offset: 0x00125308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillRoulette other)
		{
			if (other == null)
			{
				return;
			}
			this.skillIds_.Add(other.skillIds_);
			if (other.ExtraItemId != 0)
			{
				this.ExtraItemId = other.ExtraItemId;
			}
			if (other.ExploreSkill != 0)
			{
				this.ExploreSkill = other.ExploreSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x00127169 File Offset: 0x00125369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00127174 File Offset: 0x00125374
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.skillIds_.AddEntriesFrom(ref input, ExploreSkillRoulette._repeated_skillIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.ExtraItemId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ExploreSkill = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003E98 RID: 16024
		private static readonly MessageParser<ExploreSkillRoulette> _parser = new MessageParser<ExploreSkillRoulette>(() => new ExploreSkillRoulette());

		// Token: 0x04003E99 RID: 16025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E9A RID: 16026
		public const int SkillIdsFieldNumber = 1;

		// Token: 0x04003E9B RID: 16027
		private static readonly FieldCodec<int> _repeated_skillIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003E9C RID: 16028
		private readonly RepeatedField<int> skillIds_ = new RepeatedField<int>();

		// Token: 0x04003E9D RID: 16029
		public const int ExtraItemIdFieldNumber = 2;

		// Token: 0x04003E9E RID: 16030
		private int extraItemId_;

		// Token: 0x04003E9F RID: 16031
		public const int ExploreSkillFieldNumber = 3;

		// Token: 0x04003EA0 RID: 16032
		private int exploreSkill_;
	}
}
