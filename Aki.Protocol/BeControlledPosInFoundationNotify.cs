using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018E RID: 398
	[NetMessage(EMessageId.BeControlledPosInFoundationNotify)]
	public sealed class BeControlledPosInFoundationNotify : IMessage<BeControlledPosInFoundationNotify>, IMessage, IEquatable<BeControlledPosInFoundationNotify>, IDeepCloneable<BeControlledPosInFoundationNotify>, IBufferMessage
	{
		// Token: 0x06002FD0 RID: 12240 RVA: 0x0007A96B File Offset: 0x00078B6B
		[NullableContext(1)]
		public static BeControlledPosInFoundationNotify Create()
		{
			return new BeControlledPosInFoundationNotify();
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x0007A972 File Offset: 0x00078B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x0007A975 File Offset: 0x00078B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledPosInFoundationNotify.Descriptor;
			}
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x0007A97C File Offset: 0x00078B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledPosInFoundationNotify()
		{
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0007A984 File Offset: 0x00078B84
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

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0007A9D8 File Offset: 0x00078BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledPosInFoundationNotify Clone()
		{
			return new BeControlledPosInFoundationNotify(this);
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x0007A9E0 File Offset: 0x00078BE0
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x0007A9E8 File Offset: 0x00078BE8
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x0007A9F1 File Offset: 0x00078BF1
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x0007A9F9 File Offset: 0x00078BF9
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

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x0007AA02 File Offset: 0x00078C02
		// (set) Token: 0x06002FDB RID: 12251 RVA: 0x0007AA0A File Offset: 0x00078C0A
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

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x0007AA13 File Offset: 0x00078C13
		// (set) Token: 0x06002FDD RID: 12253 RVA: 0x0007AA1B File Offset: 0x00078C1B
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

		// Token: 0x06002FDE RID: 12254 RVA: 0x0007AA24 File Offset: 0x00078C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledPosInFoundationNotify);
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0007AA34 File Offset: 0x00078C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledPosInFoundationNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.BeControlledEntityId == other.BeControlledEntityId && this.InstId == other.InstId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0007AAA0 File Offset: 0x00078CA0
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

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0007AB2A File Offset: 0x00078D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0007AB37 File Offset: 0x00078D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0007AB40 File Offset: 0x00078D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FoundationEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.FoundationEntityId);
			}
			if (this.BeControlledEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BeControlledEntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InstId);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0007ABD4 File Offset: 0x00078DD4
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

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0007AC5C File Offset: 0x00078E5C
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

		// Token: 0x06002FE6 RID: 12262 RVA: 0x0007ACD4 File Offset: 0x00078ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0007ACE0 File Offset: 0x00078EE0
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.FoundationEntityId = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.BeControlledEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400291D RID: 10525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400291E RID: 10526
		public const int FoundationEntityIdFieldNumber = 6;

		// Token: 0x0400291F RID: 10527
		private long foundationEntityId_;

		// Token: 0x04002920 RID: 10528
		public const int BeControlledEntityIdFieldNumber = 7;

		// Token: 0x04002921 RID: 10529
		private long beControlledEntityId_;

		// Token: 0x04002922 RID: 10530
		public const int InstIdFieldNumber = 9;

		// Token: 0x04002923 RID: 10531
		private int instId_;

		// Token: 0x04002924 RID: 10532
		public const int MatchIndexFieldNumber = 14;

		// Token: 0x04002925 RID: 10533
		private int matchIndex_;
	}
}
