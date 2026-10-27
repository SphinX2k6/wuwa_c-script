using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA5 RID: 4005
	[NetMessage(EMessageId.RoguelikePopularEntriesChangeRequest)]
	public sealed class RoguelikePopularEntriesChangeRequest : IMessage<RoguelikePopularEntriesChangeRequest>, IMessage, IEquatable<RoguelikePopularEntriesChangeRequest>, IDeepCloneable<RoguelikePopularEntriesChangeRequest>, IBufferMessage
	{
		// Token: 0x060156AF RID: 87727 RVA: 0x0031BDEA File Offset: 0x00319FEA
		[NullableContext(1)]
		public static RoguelikePopularEntriesChangeRequest Create()
		{
			return new RoguelikePopularEntriesChangeRequest();
		}

		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x060156B0 RID: 87728 RVA: 0x0031BDF1 File Offset: 0x00319FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x060156B1 RID: 87729 RVA: 0x0031BDF4 File Offset: 0x00319FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesChangeRequest.Descriptor;
			}
		}

		// Token: 0x060156B2 RID: 87730 RVA: 0x0031BDFB File Offset: 0x00319FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest()
		{
		}

		// Token: 0x060156B3 RID: 87731 RVA: 0x0031BE10 File Offset: 0x0031A010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest(RoguelikePopularEntriesChangeRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entries_ = other.entries_.Clone();
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156B4 RID: 87732 RVA: 0x0031BE5D File Offset: 0x0031A05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest Clone()
		{
			return new RoguelikePopularEntriesChangeRequest(this);
		}

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x060156B5 RID: 87733 RVA: 0x0031BE65 File Offset: 0x0031A065
		// (set) Token: 0x060156B6 RID: 87734 RVA: 0x0031BE6D File Offset: 0x0031A06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x060156B7 RID: 87735 RVA: 0x0031BE76 File Offset: 0x0031A076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x1700476A RID: 18282
		// (get) Token: 0x060156B8 RID: 87736 RVA: 0x0031BE7E File Offset: 0x0031A07E
		// (set) Token: 0x060156B9 RID: 87737 RVA: 0x0031BE86 File Offset: 0x0031A086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x060156BA RID: 87738 RVA: 0x0031BE8F File Offset: 0x0031A08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesChangeRequest);
		}

		// Token: 0x060156BB RID: 87739 RVA: 0x0031BEA0 File Offset: 0x0031A0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesChangeRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entries_.Equals(other.entries_) && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156BC RID: 87740 RVA: 0x0031BF00 File Offset: 0x0031A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.entries_.GetHashCode();
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156BD RID: 87741 RVA: 0x0031BF66 File Offset: 0x0031A166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x0031BF73 File Offset: 0x0031A173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x0031BF7C File Offset: 0x0031A17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entries_.WriteTo(ref output, RoguelikePopularEntriesChangeRequest._repeated_entries_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156C0 RID: 87744 RVA: 0x0031BFE8 File Offset: 0x0031A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.entries_.CalculateSize(RoguelikePopularEntriesChangeRequest._repeated_entries_codec);
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156C1 RID: 87745 RVA: 0x0031C054 File Offset: 0x0031A254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikePopularEntriesChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.entries_.Add(other.entries_);
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156C2 RID: 87746 RVA: 0x0031C0B5 File Offset: 0x0031A2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156C3 RID: 87747 RVA: 0x0031C0C0 File Offset: 0x0031A2C0
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.entries_.AddEntriesFrom(ref input, RoguelikePopularEntriesChangeRequest._repeated_entries_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080D9 RID: 32985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080DA RID: 32986
		public const int InstIdFieldNumber = 14;

		// Token: 0x040080DB RID: 32987
		private int instId_;

		// Token: 0x040080DC RID: 32988
		public const int EntriesFieldNumber = 7;

		// Token: 0x040080DD RID: 32989
		private static readonly FieldCodec<int> _repeated_entries_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040080DE RID: 32990
		private readonly RepeatedField<int> entries_ = new RepeatedField<int>();

		// Token: 0x040080DF RID: 32991
		public const int SeasonIdFieldNumber = 15;

		// Token: 0x040080E0 RID: 32992
		private int seasonId_;
	}
}
