using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F95 RID: 3989
	[NetMessage(EMessageId.RoguelikePopularEntriesChangeRequest)]
	public sealed class RoguelikePopularEntriesChangeRequest : IMessage<RoguelikePopularEntriesChangeRequest>, IMessage, IEquatable<RoguelikePopularEntriesChangeRequest>, IDeepCloneable<RoguelikePopularEntriesChangeRequest>, IBufferMessage
	{
		// Token: 0x060155CA RID: 87498 RVA: 0x0031A73E File Offset: 0x0031893E
		[NullableContext(1)]
		public static RoguelikePopularEntriesChangeRequest Create()
		{
			return new RoguelikePopularEntriesChangeRequest();
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x060155CB RID: 87499 RVA: 0x0031A745 File Offset: 0x00318945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x060155CC RID: 87500 RVA: 0x0031A748 File Offset: 0x00318948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesChangeRequest.Descriptor;
			}
		}

		// Token: 0x060155CD RID: 87501 RVA: 0x0031A74F File Offset: 0x0031894F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest()
		{
		}

		// Token: 0x060155CE RID: 87502 RVA: 0x0031A764 File Offset: 0x00318964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest(RoguelikePopularEntriesChangeRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entries_ = other.entries_.Clone();
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155CF RID: 87503 RVA: 0x0031A7B1 File Offset: 0x003189B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeRequest Clone()
		{
			return new RoguelikePopularEntriesChangeRequest(this);
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x060155D0 RID: 87504 RVA: 0x0031A7B9 File Offset: 0x003189B9
		// (set) Token: 0x060155D1 RID: 87505 RVA: 0x0031A7C1 File Offset: 0x003189C1
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

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x060155D2 RID: 87506 RVA: 0x0031A7CA File Offset: 0x003189CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x060155D3 RID: 87507 RVA: 0x0031A7D2 File Offset: 0x003189D2
		// (set) Token: 0x060155D4 RID: 87508 RVA: 0x0031A7DA File Offset: 0x003189DA
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

		// Token: 0x060155D5 RID: 87509 RVA: 0x0031A7E3 File Offset: 0x003189E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesChangeRequest);
		}

		// Token: 0x060155D6 RID: 87510 RVA: 0x0031A7F4 File Offset: 0x003189F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesChangeRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.entries_.Equals(other.entries_) && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155D7 RID: 87511 RVA: 0x0031A854 File Offset: 0x00318A54
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

		// Token: 0x060155D8 RID: 87512 RVA: 0x0031A8BA File Offset: 0x00318ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155D9 RID: 87513 RVA: 0x0031A8C7 File Offset: 0x00318AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155DA RID: 87514 RVA: 0x0031A8D0 File Offset: 0x00318AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entries_.WriteTo(ref output, RoguelikePopularEntriesChangeRequest._repeated_entries_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155DB RID: 87515 RVA: 0x0031A93C File Offset: 0x00318B3C
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

		// Token: 0x060155DC RID: 87516 RVA: 0x0031A9A8 File Offset: 0x00318BA8
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

		// Token: 0x060155DD RID: 87517 RVA: 0x0031AA09 File Offset: 0x00318C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155DE RID: 87518 RVA: 0x0031AA14 File Offset: 0x00318C14
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.entries_.AddEntriesFrom(ref input, RoguelikePopularEntriesChangeRequest._repeated_entries_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008103 RID: 33027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008104 RID: 33028
		public const int InstIdFieldNumber = 8;

		// Token: 0x04008105 RID: 33029
		private int instId_;

		// Token: 0x04008106 RID: 33030
		public const int EntriesFieldNumber = 3;

		// Token: 0x04008107 RID: 33031
		private static readonly FieldCodec<int> _repeated_entries_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008108 RID: 33032
		private readonly RepeatedField<int> entries_ = new RepeatedField<int>();

		// Token: 0x04008109 RID: 33033
		public const int SeasonIdFieldNumber = 10;

		// Token: 0x0400810A RID: 33034
		private int seasonId_;
	}
}
