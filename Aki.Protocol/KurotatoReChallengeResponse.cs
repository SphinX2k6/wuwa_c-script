using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AE RID: 2222
	[NetMessage(EMessageId.KurotatoReChallengeResponse)]
	public sealed class KurotatoReChallengeResponse : IMessage<KurotatoReChallengeResponse>, IMessage, IEquatable<KurotatoReChallengeResponse>, IDeepCloneable<KurotatoReChallengeResponse>, IBufferMessage
	{
		// Token: 0x0600C543 RID: 50499 RVA: 0x001D35BD File Offset: 0x001D17BD
		[NullableContext(1)]
		public static KurotatoReChallengeResponse Create()
		{
			return new KurotatoReChallengeResponse();
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600C544 RID: 50500 RVA: 0x001D35C4 File Offset: 0x001D17C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x001D35C7 File Offset: 0x001D17C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x001D35CE File Offset: 0x001D17CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse()
		{
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x001D35D6 File Offset: 0x001D17D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse(KurotatoReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x001D35FB File Offset: 0x001D17FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse Clone()
		{
			return new KurotatoReChallengeResponse(this);
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600C549 RID: 50505 RVA: 0x001D3603 File Offset: 0x001D1803
		// (set) Token: 0x0600C54A RID: 50506 RVA: 0x001D360B File Offset: 0x001D180B
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

		// Token: 0x0600C54B RID: 50507 RVA: 0x001D3614 File Offset: 0x001D1814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeResponse);
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x001D3622 File Offset: 0x001D1822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x001D3650 File Offset: 0x001D1850
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

		// Token: 0x0600C54E RID: 50510 RVA: 0x001D3695 File Offset: 0x001D1895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x001D36A2 File Offset: 0x001D18A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x001D36AB File Offset: 0x001D18AB
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

		// Token: 0x0600C551 RID: 50513 RVA: 0x001D36E0 File Offset: 0x001D18E0
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

		// Token: 0x0600C552 RID: 50514 RVA: 0x001D371E File Offset: 0x001D191E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoReChallengeResponse other)
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

		// Token: 0x0600C553 RID: 50515 RVA: 0x001D374F File Offset: 0x001D194F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x001D3758 File Offset: 0x001D1958
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

		// Token: 0x040054EC RID: 21740
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054ED RID: 21741
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040054EE RID: 21742
		private ErrorCode errorCode_;
	}
}
