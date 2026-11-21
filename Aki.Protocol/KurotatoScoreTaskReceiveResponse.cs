using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AB RID: 2219
	[NetMessage(EMessageId.KurotatoScoreTaskReceiveResponse)]
	public sealed class KurotatoScoreTaskReceiveResponse : IMessage<KurotatoScoreTaskReceiveResponse>, IMessage, IEquatable<KurotatoScoreTaskReceiveResponse>, IDeepCloneable<KurotatoScoreTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C531 RID: 50481 RVA: 0x001D3231 File Offset: 0x001D1431
		[NullableContext(1)]
		public static KurotatoScoreTaskReceiveResponse Create()
		{
			return new KurotatoScoreTaskReceiveResponse();
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x001D3238 File Offset: 0x001D1438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x0600C533 RID: 50483 RVA: 0x001D323B File Offset: 0x001D143B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoScoreTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x001D3242 File Offset: 0x001D1442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse()
		{
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x001D324A File Offset: 0x001D144A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse(KurotatoScoreTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x001D326F File Offset: 0x001D146F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse Clone()
		{
			return new KurotatoScoreTaskReceiveResponse(this);
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600C537 RID: 50487 RVA: 0x001D3277 File Offset: 0x001D1477
		// (set) Token: 0x0600C538 RID: 50488 RVA: 0x001D327F File Offset: 0x001D147F
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

		// Token: 0x0600C539 RID: 50489 RVA: 0x001D3288 File Offset: 0x001D1488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoScoreTaskReceiveResponse);
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x001D3296 File Offset: 0x001D1496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoScoreTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x001D32C4 File Offset: 0x001D14C4
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

		// Token: 0x0600C53C RID: 50492 RVA: 0x001D3309 File Offset: 0x001D1509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x001D3316 File Offset: 0x001D1516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x001D331F File Offset: 0x001D151F
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

		// Token: 0x0600C53F RID: 50495 RVA: 0x001D3354 File Offset: 0x001D1554
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

		// Token: 0x0600C540 RID: 50496 RVA: 0x001D3392 File Offset: 0x001D1592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoScoreTaskReceiveResponse other)
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

		// Token: 0x0600C541 RID: 50497 RVA: 0x001D33C3 File Offset: 0x001D15C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x001D33CC File Offset: 0x001D15CC
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

		// Token: 0x04005530 RID: 21808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005531 RID: 21809
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005532 RID: 21810
		private ErrorCode errorCode_;
	}
}
