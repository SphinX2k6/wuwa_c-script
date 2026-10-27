using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050C RID: 1292
	[NetMessage(EMessageId.ExploreSkillRouletteUpdateNotify)]
	public sealed class ExploreSkillRouletteUpdateNotify : IMessage<ExploreSkillRouletteUpdateNotify>, IMessage, IEquatable<ExploreSkillRouletteUpdateNotify>, IDeepCloneable<ExploreSkillRouletteUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007998 RID: 31128 RVA: 0x00127A01 File Offset: 0x00125C01
		[NullableContext(1)]
		public static ExploreSkillRouletteUpdateNotify Create()
		{
			return new ExploreSkillRouletteUpdateNotify();
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x00127A08 File Offset: 0x00125C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x00127A0B File Offset: 0x00125C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00127A12 File Offset: 0x00125C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify()
		{
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00127A25 File Offset: 0x00125C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify(ExploreSkillRouletteUpdateNotify other) : this()
		{
			this.rouletteInfo_ = other.rouletteInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00127A4F File Offset: 0x00125C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteUpdateNotify Clone()
		{
			return new ExploreSkillRouletteUpdateNotify(this);
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x00127A57 File Offset: 0x00125C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> RouletteInfo
		{
			get
			{
				return this.rouletteInfo_;
			}
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00127A5F File Offset: 0x00125C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteUpdateNotify);
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00127A6D File Offset: 0x00125C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteUpdateNotify other)
		{
			return other != null && (other == this || (this.rouletteInfo_.Equals(other.rouletteInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00127AA0 File Offset: 0x00125CA0
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

		// Token: 0x060079A2 RID: 31138 RVA: 0x00127AD4 File Offset: 0x00125CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00127AE1 File Offset: 0x00125CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00127AEA File Offset: 0x00125CEA
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

		// Token: 0x060079A5 RID: 31141 RVA: 0x00127B14 File Offset: 0x00125D14
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

		// Token: 0x060079A6 RID: 31142 RVA: 0x00127B4D File Offset: 0x00125D4D
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

		// Token: 0x060079A7 RID: 31143 RVA: 0x00127B7B File Offset: 0x00125D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00127B84 File Offset: 0x00125D84
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rouletteInfo_.AddEntriesFrom(ref input, ExploreSkillRouletteUpdateNotify._repeated_rouletteInfo_codec);
				}
			}
		}

		// Token: 0x04003EB3 RID: 16051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EB4 RID: 16052
		public const int RouletteInfoFieldNumber = 4;

		// Token: 0x04003EB5 RID: 16053
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_rouletteInfo_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(34U, ExploreSkillRoulette.Parser);

		// Token: 0x04003EB6 RID: 16054
		private readonly RepeatedField<ExploreSkillRoulette> rouletteInfo_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
