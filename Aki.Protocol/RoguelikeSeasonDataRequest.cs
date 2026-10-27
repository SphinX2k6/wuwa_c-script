using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB7 RID: 4023
	[NetMessage(EMessageId.RoguelikeSeasonDataRequest)]
	public sealed class RoguelikeSeasonDataRequest : IMessage<RoguelikeSeasonDataRequest>, IMessage, IEquatable<RoguelikeSeasonDataRequest>, IDeepCloneable<RoguelikeSeasonDataRequest>, IBufferMessage
	{
		// Token: 0x0601582D RID: 88109 RVA: 0x0031F60A File Offset: 0x0031D80A
		[NullableContext(1)]
		public static RoguelikeSeasonDataRequest Create()
		{
			return new RoguelikeSeasonDataRequest();
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x0601582E RID: 88110 RVA: 0x0031F611 File Offset: 0x0031D811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x0601582F RID: 88111 RVA: 0x0031F614 File Offset: 0x0031D814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonDataRequest.Descriptor;
			}
		}

		// Token: 0x06015830 RID: 88112 RVA: 0x0031F61B File Offset: 0x0031D81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest()
		{
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x0031F623 File Offset: 0x0031D823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest(RoguelikeSeasonDataRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x0031F648 File Offset: 0x0031D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest Clone()
		{
			return new RoguelikeSeasonDataRequest(this);
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x06015833 RID: 88115 RVA: 0x0031F650 File Offset: 0x0031D850
		// (set) Token: 0x06015834 RID: 88116 RVA: 0x0031F658 File Offset: 0x0031D858
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

		// Token: 0x06015835 RID: 88117 RVA: 0x0031F661 File Offset: 0x0031D861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonDataRequest);
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x0031F66F File Offset: 0x0031D86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonDataRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015837 RID: 88119 RVA: 0x0031F6A0 File Offset: 0x0031D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06015838 RID: 88120 RVA: 0x0031F6DF File Offset: 0x0031D8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x0031F6EC File Offset: 0x0031D8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601583A RID: 88122 RVA: 0x0031F6F5 File Offset: 0x0031D8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601583B RID: 88123 RVA: 0x0031F728 File Offset: 0x0031D928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601583C RID: 88124 RVA: 0x0031F766 File Offset: 0x0031D966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSeasonDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601583D RID: 88125 RVA: 0x0031F797 File Offset: 0x0031D997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601583E RID: 88126 RVA: 0x0031F7A0 File Offset: 0x0031D9A0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400814D RID: 33101
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400814E RID: 33102
		public const int SeasonIdFieldNumber = 4;

		// Token: 0x0400814F RID: 33103
		private int seasonId_;
	}
}
