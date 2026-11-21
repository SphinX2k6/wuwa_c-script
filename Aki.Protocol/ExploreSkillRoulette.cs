using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F3 RID: 1267
	public sealed class ExploreSkillRoulette : IMessage<ExploreSkillRoulette>, IMessage, IEquatable<ExploreSkillRoulette>, IDeepCloneable<ExploreSkillRoulette>, IBufferMessage
	{
		// Token: 0x060077D7 RID: 30679 RVA: 0x00124004 File Offset: 0x00122204
		[NullableContext(1)]
		public static ExploreSkillRoulette Create()
		{
			return new ExploreSkillRoulette();
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x0012400B File Offset: 0x0012220B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExploreSkillRoulette> Parser
		{
			get
			{
				return ExploreSkillRoulette._parser;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x00124012 File Offset: 0x00122212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x00124015 File Offset: 0x00122215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRoulette.Descriptor;
			}
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x0012401C File Offset: 0x0012221C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette()
		{
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00124030 File Offset: 0x00122230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette(ExploreSkillRoulette other) : this()
		{
			this.skillIds_ = other.skillIds_.Clone();
			this.extraItemId_ = other.extraItemId_;
			this.exploreSkill_ = other.exploreSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x0012407D File Offset: 0x0012227D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette Clone()
		{
			return new ExploreSkillRoulette(this);
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x00124085 File Offset: 0x00122285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillIds
		{
			get
			{
				return this.skillIds_;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x0012408D File Offset: 0x0012228D
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x00124095 File Offset: 0x00122295
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

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060077E1 RID: 30689 RVA: 0x0012409E File Offset: 0x0012229E
		// (set) Token: 0x060077E2 RID: 30690 RVA: 0x001240A6 File Offset: 0x001222A6
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

		// Token: 0x060077E3 RID: 30691 RVA: 0x001240AF File Offset: 0x001222AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRoulette);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x001240C0 File Offset: 0x001222C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRoulette other)
		{
			return other != null && (other == this || (this.skillIds_.Equals(other.skillIds_) && this.ExtraItemId == other.ExtraItemId && this.ExploreSkill == other.ExploreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00124120 File Offset: 0x00122320
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

		// Token: 0x060077E6 RID: 30694 RVA: 0x00124186 File Offset: 0x00122386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00124193 File Offset: 0x00122393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0012419C File Offset: 0x0012239C
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

		// Token: 0x060077E9 RID: 30697 RVA: 0x00124208 File Offset: 0x00122408
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

		// Token: 0x060077EA RID: 30698 RVA: 0x00124274 File Offset: 0x00122474
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

		// Token: 0x060077EB RID: 30699 RVA: 0x001242D5 File Offset: 0x001224D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x001242E0 File Offset: 0x001224E0
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

		// Token: 0x04003E89 RID: 16009
		private static readonly MessageParser<ExploreSkillRoulette> _parser = new MessageParser<ExploreSkillRoulette>(() => new ExploreSkillRoulette());

		// Token: 0x04003E8A RID: 16010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E8B RID: 16011
		public const int SkillIdsFieldNumber = 1;

		// Token: 0x04003E8C RID: 16012
		private static readonly FieldCodec<int> _repeated_skillIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003E8D RID: 16013
		private readonly RepeatedField<int> skillIds_ = new RepeatedField<int>();

		// Token: 0x04003E8E RID: 16014
		public const int ExtraItemIdFieldNumber = 2;

		// Token: 0x04003E8F RID: 16015
		private int extraItemId_;

		// Token: 0x04003E90 RID: 16016
		public const int ExploreSkillFieldNumber = 3;

		// Token: 0x04003E91 RID: 16017
		private int exploreSkill_;
	}
}
