using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D4 RID: 212
	[NetMessage(EMessageId.AdviceVoteResponse)]
	public sealed class AdviceVoteResponse : IMessage<AdviceVoteResponse>, IMessage, IEquatable<AdviceVoteResponse>, IDeepCloneable<AdviceVoteResponse>, IBufferMessage
	{
		// Token: 0x0600204A RID: 8266 RVA: 0x00057278 File Offset: 0x00055478
		[NullableContext(1)]
		public static AdviceVoteResponse Create()
		{
			return new AdviceVoteResponse();
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0005727F File Offset: 0x0005547F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x00057282 File Offset: 0x00055482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteResponse.Descriptor;
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00057289 File Offset: 0x00055489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse()
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00057291 File Offset: 0x00055491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse(AdviceVoteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000572B6 File Offset: 0x000554B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteResponse Clone()
		{
			return new AdviceVoteResponse(this);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x000572BE File Offset: 0x000554BE
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x000572C6 File Offset: 0x000554C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000572CF File Offset: 0x000554CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteResponse);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000572DD File Offset: 0x000554DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0005730C File Offset: 0x0005550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00057351 File Offset: 0x00055551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0005735E File Offset: 0x0005555E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00057367 File Offset: 0x00055567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0005739C File Offset: 0x0005559C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000573DA File Offset: 0x000555DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceVoteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0005740B File Offset: 0x0005560B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00057414 File Offset: 0x00055614
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023ED RID: 9197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023EE RID: 9198
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040023EF RID: 9199
		private ErrorCode errorCode_;
	}
}
