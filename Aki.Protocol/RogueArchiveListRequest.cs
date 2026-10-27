using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7C RID: 3964
	[NetMessage(EMessageId.RogueArchiveListRequest)]
	public sealed class RogueArchiveListRequest : IMessage<RogueArchiveListRequest>, IMessage, IEquatable<RogueArchiveListRequest>, IDeepCloneable<RogueArchiveListRequest>, IBufferMessage
	{
		// Token: 0x06015318 RID: 86808 RVA: 0x00312B86 File Offset: 0x00310D86
		[NullableContext(1)]
		public static RogueArchiveListRequest Create()
		{
			return new RogueArchiveListRequest();
		}

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x06015319 RID: 86809 RVA: 0x00312B8D File Offset: 0x00310D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x0601531A RID: 86810 RVA: 0x00312B90 File Offset: 0x00310D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveListRequest.Descriptor;
			}
		}

		// Token: 0x0601531B RID: 86811 RVA: 0x00312B97 File Offset: 0x00310D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest()
		{
		}

		// Token: 0x0601531C RID: 86812 RVA: 0x00312B9F File Offset: 0x00310D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest(RogueArchiveListRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601531D RID: 86813 RVA: 0x00312BC4 File Offset: 0x00310DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListRequest Clone()
		{
			return new RogueArchiveListRequest(this);
		}

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x0601531E RID: 86814 RVA: 0x00312BCC File Offset: 0x00310DCC
		// (set) Token: 0x0601531F RID: 86815 RVA: 0x00312BD4 File Offset: 0x00310DD4
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

		// Token: 0x06015320 RID: 86816 RVA: 0x00312BDD File Offset: 0x00310DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveListRequest);
		}

		// Token: 0x06015321 RID: 86817 RVA: 0x00312BEB File Offset: 0x00310DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveListRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015322 RID: 86818 RVA: 0x00312C1C File Offset: 0x00310E1C
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

		// Token: 0x06015323 RID: 86819 RVA: 0x00312C5B File Offset: 0x00310E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015324 RID: 86820 RVA: 0x00312C68 File Offset: 0x00310E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015325 RID: 86821 RVA: 0x00312C71 File Offset: 0x00310E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015326 RID: 86822 RVA: 0x00312CA4 File Offset: 0x00310EA4
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

		// Token: 0x06015327 RID: 86823 RVA: 0x00312CE2 File Offset: 0x00310EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveListRequest other)
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

		// Token: 0x06015328 RID: 86824 RVA: 0x00312D13 File Offset: 0x00310F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015329 RID: 86825 RVA: 0x00312D1C File Offset: 0x00310F1C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F78 RID: 32632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F79 RID: 32633
		public const int SeasonIdFieldNumber = 8;

		// Token: 0x04007F7A RID: 32634
		private int seasonId_;
	}
}
