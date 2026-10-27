using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED0 RID: 3792
	[NetMessage(EMessageId.ReceiveRechallengeResponse)]
	public sealed class ReceiveRechallengeResponse : IMessage<ReceiveRechallengeResponse>, IMessage, IEquatable<ReceiveRechallengeResponse>, IDeepCloneable<ReceiveRechallengeResponse>, IBufferMessage
	{
		// Token: 0x06014536 RID: 83254 RVA: 0x002F40C9 File Offset: 0x002F22C9
		[NullableContext(1)]
		public static ReceiveRechallengeResponse Create()
		{
			return new ReceiveRechallengeResponse();
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x06014537 RID: 83255 RVA: 0x002F40D0 File Offset: 0x002F22D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x06014538 RID: 83256 RVA: 0x002F40D3 File Offset: 0x002F22D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x06014539 RID: 83257 RVA: 0x002F40DA File Offset: 0x002F22DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse()
		{
		}

		// Token: 0x0601453A RID: 83258 RVA: 0x002F40E2 File Offset: 0x002F22E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse(ReceiveRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601453B RID: 83259 RVA: 0x002F4107 File Offset: 0x002F2307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeResponse Clone()
		{
			return new ReceiveRechallengeResponse(this);
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x0601453C RID: 83260 RVA: 0x002F410F File Offset: 0x002F230F
		// (set) Token: 0x0601453D RID: 83261 RVA: 0x002F4117 File Offset: 0x002F2317
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

		// Token: 0x0601453E RID: 83262 RVA: 0x002F4120 File Offset: 0x002F2320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeResponse);
		}

		// Token: 0x0601453F RID: 83263 RVA: 0x002F412E File Offset: 0x002F232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014540 RID: 83264 RVA: 0x002F415C File Offset: 0x002F235C
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

		// Token: 0x06014541 RID: 83265 RVA: 0x002F41A1 File Offset: 0x002F23A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014542 RID: 83266 RVA: 0x002F41AE File Offset: 0x002F23AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014543 RID: 83267 RVA: 0x002F41B7 File Offset: 0x002F23B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014544 RID: 83268 RVA: 0x002F41EC File Offset: 0x002F23EC
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

		// Token: 0x06014545 RID: 83269 RVA: 0x002F422A File Offset: 0x002F242A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceiveRechallengeResponse other)
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

		// Token: 0x06014546 RID: 83270 RVA: 0x002F425B File Offset: 0x002F245B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014547 RID: 83271 RVA: 0x002F4264 File Offset: 0x002F2464
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B6A RID: 31594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B6B RID: 31595
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007B6C RID: 31596
		private ErrorCode errorCode_;
	}
}
