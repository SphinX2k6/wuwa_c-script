using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F97 RID: 3991
	[NetMessage(EMessageId.RoguelikePopularEntriesInfoRequest)]
	public sealed class RoguelikePopularEntriesInfoRequest : IMessage<RoguelikePopularEntriesInfoRequest>, IMessage, IEquatable<RoguelikePopularEntriesInfoRequest>, IDeepCloneable<RoguelikePopularEntriesInfoRequest>, IBufferMessage
	{
		// Token: 0x060155F2 RID: 87538 RVA: 0x0031AC81 File Offset: 0x00318E81
		[NullableContext(1)]
		public static RoguelikePopularEntriesInfoRequest Create()
		{
			return new RoguelikePopularEntriesInfoRequest();
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x060155F3 RID: 87539 RVA: 0x0031AC88 File Offset: 0x00318E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x060155F4 RID: 87540 RVA: 0x0031AC8B File Offset: 0x00318E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesInfoRequest.Descriptor;
			}
		}

		// Token: 0x060155F5 RID: 87541 RVA: 0x0031AC92 File Offset: 0x00318E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest()
		{
		}

		// Token: 0x060155F6 RID: 87542 RVA: 0x0031AC9A File Offset: 0x00318E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest(RoguelikePopularEntriesInfoRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155F7 RID: 87543 RVA: 0x0031ACCB File Offset: 0x00318ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesInfoRequest Clone()
		{
			return new RoguelikePopularEntriesInfoRequest(this);
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x060155F8 RID: 87544 RVA: 0x0031ACD3 File Offset: 0x00318ED3
		// (set) Token: 0x060155F9 RID: 87545 RVA: 0x0031ACDB File Offset: 0x00318EDB
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

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x060155FA RID: 87546 RVA: 0x0031ACE4 File Offset: 0x00318EE4
		// (set) Token: 0x060155FB RID: 87547 RVA: 0x0031ACEC File Offset: 0x00318EEC
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

		// Token: 0x060155FC RID: 87548 RVA: 0x0031ACF5 File Offset: 0x00318EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesInfoRequest);
		}

		// Token: 0x060155FD RID: 87549 RVA: 0x0031AD03 File Offset: 0x00318F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesInfoRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155FE RID: 87550 RVA: 0x0031AD44 File Offset: 0x00318F44
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

		// Token: 0x060155FF RID: 87551 RVA: 0x0031AD9C File Offset: 0x00318F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015600 RID: 87552 RVA: 0x0031ADA9 File Offset: 0x00318FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015601 RID: 87553 RVA: 0x0031ADB4 File Offset: 0x00318FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SeasonId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015602 RID: 87554 RVA: 0x0031AE10 File Offset: 0x00319010
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

		// Token: 0x06015603 RID: 87555 RVA: 0x0031AE68 File Offset: 0x00319068
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

		// Token: 0x06015604 RID: 87556 RVA: 0x0031AEB8 File Offset: 0x003190B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015605 RID: 87557 RVA: 0x0031AEC4 File Offset: 0x003190C4
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
				if (num != 32U)
				{
					if (num != 56U)
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

		// Token: 0x0400810E RID: 33038
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400810F RID: 33039
		public const int InstIdFieldNumber = 7;

		// Token: 0x04008110 RID: 33040
		private int instId_;

		// Token: 0x04008111 RID: 33041
		public const int SeasonIdFieldNumber = 4;

		// Token: 0x04008112 RID: 33042
		private int seasonId_;
	}
}
