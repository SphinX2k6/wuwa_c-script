using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089D RID: 2205
	[NetMessage(EMessageId.KurotatoReChallengeResponse)]
	public sealed class KurotatoReChallengeResponse : IMessage<KurotatoReChallengeResponse>, IMessage, IEquatable<KurotatoReChallengeResponse>, IDeepCloneable<KurotatoReChallengeResponse>, IBufferMessage
	{
		// Token: 0x0600C427 RID: 50215 RVA: 0x001D12DD File Offset: 0x001CF4DD
		[NullableContext(1)]
		public static KurotatoReChallengeResponse Create()
		{
			return new KurotatoReChallengeResponse();
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600C428 RID: 50216 RVA: 0x001D12E4 File Offset: 0x001CF4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x0600C429 RID: 50217 RVA: 0x001D12E7 File Offset: 0x001CF4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x001D12EE File Offset: 0x001CF4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse()
		{
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x001D12F6 File Offset: 0x001CF4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse(KurotatoReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C42C RID: 50220 RVA: 0x001D131B File Offset: 0x001CF51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeResponse Clone()
		{
			return new KurotatoReChallengeResponse(this);
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x0600C42D RID: 50221 RVA: 0x001D1323 File Offset: 0x001CF523
		// (set) Token: 0x0600C42E RID: 50222 RVA: 0x001D132B File Offset: 0x001CF52B
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

		// Token: 0x0600C42F RID: 50223 RVA: 0x001D1334 File Offset: 0x001CF534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeResponse);
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x001D1342 File Offset: 0x001CF542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x001D1370 File Offset: 0x001CF570
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

		// Token: 0x0600C432 RID: 50226 RVA: 0x001D13B5 File Offset: 0x001CF5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x001D13C2 File Offset: 0x001CF5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x001D13CB File Offset: 0x001CF5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x001D13FC File Offset: 0x001CF5FC
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

		// Token: 0x0600C436 RID: 50230 RVA: 0x001D143A File Offset: 0x001CF63A
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

		// Token: 0x0600C437 RID: 50231 RVA: 0x001D146B File Offset: 0x001CF66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C438 RID: 50232 RVA: 0x001D1474 File Offset: 0x001CF674
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054F3 RID: 21747
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F4 RID: 21748
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040054F5 RID: 21749
		private ErrorCode errorCode_;
	}
}
