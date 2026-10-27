using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA7 RID: 4007
	[NetMessage(EMessageId.RoguelikePopularEntriesInfoRequest)]
	public sealed class RoguelikePopularEntriesInfoRequest : IMessage<RoguelikePopularEntriesInfoRequest>, IMessage, IEquatable<RoguelikePopularEntriesInfoRequest>, IDeepCloneable<RoguelikePopularEntriesInfoRequest>, IBufferMessage
	{
		// Token: 0x060156D7 RID: 87767 RVA: 0x0031C32D File Offset: 0x0031A52D
		[NullableContext(1)]
		public static RoguelikePopularEntriesInfoRequest Create()
		{
			return new RoguelikePopularEntriesInfoRequest();
		}

		// Token: 0x1700476E RID: 18286
		// (get) Token: 0x060156D8 RID: 87768 RVA: 0x0031C334 File Offset: 0x0031A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700476F RID: 18287
		// (get) Token: 0x060156D9 RID: 87769 RVA: 0x0031C337 File Offset: 0x0031A537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesInfoRequest.Descriptor;
			}
		}

		// Token: 0x060156DA RID: 87770 RVA: 0x0031C33E File Offset: 0x0031A53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest()
		{
		}

		// Token: 0x060156DB RID: 87771 RVA: 0x0031C346 File Offset: 0x0031A546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest(RoguelikePopularEntriesInfoRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156DC RID: 87772 RVA: 0x0031C377 File Offset: 0x0031A577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest Clone()
		{
			return new RoguelikePopularEntriesInfoRequest(this);
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x060156DD RID: 87773 RVA: 0x0031C37F File Offset: 0x0031A57F
		// (set) Token: 0x060156DE RID: 87774 RVA: 0x0031C387 File Offset: 0x0031A587
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

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x060156DF RID: 87775 RVA: 0x0031C390 File Offset: 0x0031A590
		// (set) Token: 0x060156E0 RID: 87776 RVA: 0x0031C398 File Offset: 0x0031A598
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

		// Token: 0x060156E1 RID: 87777 RVA: 0x0031C3A1 File Offset: 0x0031A5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesInfoRequest);
		}

		// Token: 0x060156E2 RID: 87778 RVA: 0x0031C3AF File Offset: 0x0031A5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesInfoRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156E3 RID: 87779 RVA: 0x0031C3F0 File Offset: 0x0031A5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
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

		// Token: 0x060156E4 RID: 87780 RVA: 0x0031C448 File Offset: 0x0031A648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156E5 RID: 87781 RVA: 0x0031C455 File Offset: 0x0031A655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156E6 RID: 87782 RVA: 0x0031C460 File Offset: 0x0031A660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeasonId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156E7 RID: 87783 RVA: 0x0031C4BC File Offset: 0x0031A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
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

		// Token: 0x060156E8 RID: 87784 RVA: 0x0031C514 File Offset: 0x0031A714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikePopularEntriesInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156E9 RID: 87785 RVA: 0x0031C564 File Offset: 0x0031A764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156EA RID: 87786 RVA: 0x0031C570 File Offset: 0x0031A770
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
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040080E4 RID: 32996
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080E5 RID: 32997
		public const int InstIdFieldNumber = 8;

		// Token: 0x040080E6 RID: 32998
		private int instId_;

		// Token: 0x040080E7 RID: 32999
		public const int SeasonIdFieldNumber = 2;

		// Token: 0x040080E8 RID: 33000
		private int seasonId_;
	}
}
