using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F6 RID: 1270
	[NetMessage(EMessageId.ExploreSkillRouletteUpdateNotify)]
	public sealed class ExploreSkillRouletteUpdateNotify : IMessage<ExploreSkillRouletteUpdateNotify>, IMessage, IEquatable<ExploreSkillRouletteUpdateNotify>, IDeepCloneable<ExploreSkillRouletteUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600781C RID: 30748 RVA: 0x00124B6D File Offset: 0x00122D6D
		[NullableContext(1)]
		public static ExploreSkillRouletteUpdateNotify Create()
		{
			return new ExploreSkillRouletteUpdateNotify();
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x00124B74 File Offset: 0x00122D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x00124B77 File Offset: 0x00122D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00124B7E File Offset: 0x00122D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify()
		{
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00124B91 File Offset: 0x00122D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify(ExploreSkillRouletteUpdateNotify other) : this()
		{
			this.rouletteInfo_ = other.rouletteInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00124BBB File Offset: 0x00122DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify Clone()
		{
			return new ExploreSkillRouletteUpdateNotify(this);
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x00124BC3 File Offset: 0x00122DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> RouletteInfo
		{
			get
			{
				return this.rouletteInfo_;
			}
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00124BCB File Offset: 0x00122DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteUpdateNotify);
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00124BD9 File Offset: 0x00122DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteUpdateNotify other)
		{
			return other != null && (other == this || (this.rouletteInfo_.Equals(other.rouletteInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00124C0C File Offset: 0x00122E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rouletteInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00124C40 File Offset: 0x00122E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00124C4D File Offset: 0x00122E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00124C56 File Offset: 0x00122E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rouletteInfo_.WriteTo(ref output, ExploreSkillRouletteUpdateNotify._repeated_rouletteInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00124C80 File Offset: 0x00122E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rouletteInfo_.CalculateSize(ExploreSkillRouletteUpdateNotify._repeated_rouletteInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00124CB9 File Offset: 0x00122EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillRouletteUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rouletteInfo_.Add(other.rouletteInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00124CE7 File Offset: 0x00122EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00124CF0 File Offset: 0x00122EF0
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rouletteInfo_.AddEntriesFrom(ref input, ExploreSkillRouletteUpdateNotify._repeated_rouletteInfo_codec);
				}
			}
		}

		// Token: 0x04003EA4 RID: 16036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EA5 RID: 16037
		public const int RouletteInfoFieldNumber = 5;

		// Token: 0x04003EA6 RID: 16038
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_rouletteInfo_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(42U, ExploreSkillRoulette.Parser);

		// Token: 0x04003EA7 RID: 16039
		private readonly RepeatedField<ExploreSkillRoulette> rouletteInfo_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
