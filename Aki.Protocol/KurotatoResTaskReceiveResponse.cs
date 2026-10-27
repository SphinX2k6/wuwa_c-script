using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B3 RID: 2227
	[NetMessage(EMessageId.KurotatoResTaskReceiveResponse)]
	public sealed class KurotatoResTaskReceiveResponse : IMessage<KurotatoResTaskReceiveResponse>, IMessage, IEquatable<KurotatoResTaskReceiveResponse>, IDeepCloneable<KurotatoResTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C5A1 RID: 50593 RVA: 0x001D40F9 File Offset: 0x001D22F9
		[NullableContext(1)]
		public static KurotatoResTaskReceiveResponse Create()
		{
			return new KurotatoResTaskReceiveResponse();
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x001D4100 File Offset: 0x001D2300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600C5A3 RID: 50595 RVA: 0x001D4103 File Offset: 0x001D2303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x001D410A File Offset: 0x001D230A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse()
		{
		}

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x001D4112 File Offset: 0x001D2312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse(KurotatoResTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5A6 RID: 50598 RVA: 0x001D4137 File Offset: 0x001D2337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse Clone()
		{
			return new KurotatoResTaskReceiveResponse(this);
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600C5A7 RID: 50599 RVA: 0x001D413F File Offset: 0x001D233F
		// (set) Token: 0x0600C5A8 RID: 50600 RVA: 0x001D4147 File Offset: 0x001D2347
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

		// Token: 0x0600C5A9 RID: 50601 RVA: 0x001D4150 File Offset: 0x001D2350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskReceiveResponse);
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x001D415E File Offset: 0x001D235E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x001D418C File Offset: 0x001D238C
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

		// Token: 0x0600C5AC RID: 50604 RVA: 0x001D41D1 File Offset: 0x001D23D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x001D41DE File Offset: 0x001D23DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x001D41E7 File Offset: 0x001D23E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x001D421C File Offset: 0x001D241C
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

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x001D425A File Offset: 0x001D245A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoResTaskReceiveResponse other)
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

		// Token: 0x0600C5B1 RID: 50609 RVA: 0x001D428B File Offset: 0x001D248B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5B2 RID: 50610 RVA: 0x001D4294 File Offset: 0x001D2494
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005501 RID: 21761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005502 RID: 21762
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005503 RID: 21763
		private ErrorCode errorCode_;
	}
}
