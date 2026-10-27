using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018B RID: 395
	[NetMessage(EMessageId.BeControlledPosInFoundationNotify)]
	public sealed class BeControlledPosInFoundationNotify : IMessage<BeControlledPosInFoundationNotify>, IMessage, IEquatable<BeControlledPosInFoundationNotify>, IDeepCloneable<BeControlledPosInFoundationNotify>, IBufferMessage
	{
		// Token: 0x06002F59 RID: 12121 RVA: 0x00079537 File Offset: 0x00077737
		[NullableContext(1)]
		public static BeControlledPosInFoundationNotify Create()
		{
			return new BeControlledPosInFoundationNotify();
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x0007953E File Offset: 0x0007773E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00079541 File Offset: 0x00077741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledPosInFoundationNotify.Descriptor;
			}
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00079548 File Offset: 0x00077748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledPosInFoundationNotify()
		{
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00079550 File Offset: 0x00077750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledPosInFoundationNotify(BeControlledPosInFoundationNotify other) : this()
		{
			this.foundationEntityId_ = other.foundationEntityId_;
			this.beControlledEntityId_ = other.beControlledEntityId_;
			this.instId_ = other.instId_;
			this.matchIndex_ = other.matchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000795A4 File Offset: 0x000777A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledPosInFoundationNotify Clone()
		{
			return new BeControlledPosInFoundationNotify(this);
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000795AC File Offset: 0x000777AC
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x000795B4 File Offset: 0x000777B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FoundationEntityId
		{
			get
			{
				return this.foundationEntityId_;
			}
			set
			{
				this.foundationEntityId_ = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000795BD File Offset: 0x000777BD
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x000795C5 File Offset: 0x000777C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeControlledEntityId
		{
			get
			{
				return this.beControlledEntityId_;
			}
			set
			{
				this.beControlledEntityId_ = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x000795CE File Offset: 0x000777CE
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x000795D6 File Offset: 0x000777D6
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

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000795DF File Offset: 0x000777DF
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x000795E7 File Offset: 0x000777E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchIndex
		{
			get
			{
				return this.matchIndex_;
			}
			set
			{
				this.matchIndex_ = value;
			}
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000795F0 File Offset: 0x000777F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledPosInFoundationNotify);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00079600 File Offset: 0x00077800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledPosInFoundationNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.BeControlledEntityId == other.BeControlledEntityId && this.InstId == other.InstId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x0007966C File Offset: 0x0007786C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityId != 0L)
			{
				num ^= this.FoundationEntityId.GetHashCode();
			}
			if (this.BeControlledEntityId != 0L)
			{
				num ^= this.BeControlledEntityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000796F6 File Offset: 0x000778F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00079703 File Offset: 0x00077903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x0007970C File Offset: 0x0007790C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this.BeControlledEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.BeControlledEntityId);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.FoundationEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.FoundationEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000797A0 File Offset: 0x000779A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FoundationEntityId);
			}
			if (this.BeControlledEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeControlledEntityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00079828 File Offset: 0x00077A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledPosInFoundationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityId != 0L)
			{
				this.FoundationEntityId = other.FoundationEntityId;
			}
			if (other.BeControlledEntityId != 0L)
			{
				this.BeControlledEntityId = other.BeControlledEntityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000798A0 File Offset: 0x00077AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000798AC File Offset: 0x00077AAC
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.BeControlledEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.FoundationEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028A9 RID: 10409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028AA RID: 10410
		public const int FoundationEntityIdFieldNumber = 13;

		// Token: 0x040028AB RID: 10411
		private long foundationEntityId_;

		// Token: 0x040028AC RID: 10412
		public const int BeControlledEntityIdFieldNumber = 6;

		// Token: 0x040028AD RID: 10413
		private long beControlledEntityId_;

		// Token: 0x040028AE RID: 10414
		public const int InstIdFieldNumber = 2;

		// Token: 0x040028AF RID: 10415
		private int instId_;

		// Token: 0x040028B0 RID: 10416
		public const int MatchIndexFieldNumber = 9;

		// Token: 0x040028B1 RID: 10417
		private int matchIndex_;
	}
}
