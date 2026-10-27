using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D3 RID: 211
	[NetMessage(EMessageId.AdviceVoteRequest)]
	public sealed class AdviceVoteRequest : IMessage<AdviceVoteRequest>, IMessage, IEquatable<AdviceVoteRequest>, IDeepCloneable<AdviceVoteRequest>, IBufferMessage
	{
		// Token: 0x06002036 RID: 8246 RVA: 0x00056FD9 File Offset: 0x000551D9
		[NullableContext(1)]
		public static AdviceVoteRequest Create()
		{
			return new AdviceVoteRequest();
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00056FE0 File Offset: 0x000551E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00056FE3 File Offset: 0x000551E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteRequest.Descriptor;
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00056FEA File Offset: 0x000551EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest()
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00056FF2 File Offset: 0x000551F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest(AdviceVoteRequest other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00057023 File Offset: 0x00055223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest Clone()
		{
			return new AdviceVoteRequest(this);
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0005702B File Offset: 0x0005522B
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x00057033 File Offset: 0x00055233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0005703C File Offset: 0x0005523C
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00057044 File Offset: 0x00055244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceVoteType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0005704D File Offset: 0x0005524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteRequest);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0005705B File Offset: 0x0005525B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0005709C File Offset: 0x0005529C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != PbAdviceVoteType.Up)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000570FA File Offset: 0x000552FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00057107 File Offset: 0x00055307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00057110 File Offset: 0x00055310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != PbAdviceVoteType.Up)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0005716C File Offset: 0x0005536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Type != PbAdviceVoteType.Up)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000571C4 File Offset: 0x000553C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceVoteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Type != PbAdviceVoteType.Up)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00057214 File Offset: 0x00055414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00057220 File Offset: 0x00055420
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
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.Type = (PbAdviceVoteType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023E8 RID: 9192
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023E9 RID: 9193
		public const int IdFieldNumber = 7;

		// Token: 0x040023EA RID: 9194
		private long id_;

		// Token: 0x040023EB RID: 9195
		public const int TypeFieldNumber = 4;

		// Token: 0x040023EC RID: 9196
		private PbAdviceVoteType type_;
	}
}
