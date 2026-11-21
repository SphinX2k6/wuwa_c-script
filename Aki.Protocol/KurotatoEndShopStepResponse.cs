using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000882 RID: 2178
	[NetMessage(EMessageId.KurotatoEndShopStepResponse)]
	public sealed class KurotatoEndShopStepResponse : IMessage<KurotatoEndShopStepResponse>, IMessage, IEquatable<KurotatoEndShopStepResponse>, IDeepCloneable<KurotatoEndShopStepResponse>, IBufferMessage
	{
		// Token: 0x0600C20B RID: 49675 RVA: 0x001CCEC1 File Offset: 0x001CB0C1
		[NullableContext(1)]
		public static KurotatoEndShopStepResponse Create()
		{
			return new KurotatoEndShopStepResponse();
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600C20C RID: 49676 RVA: 0x001CCEC8 File Offset: 0x001CB0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600C20D RID: 49677 RVA: 0x001CCECB File Offset: 0x001CB0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndShopStepResponse.Descriptor;
			}
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x001CCED2 File Offset: 0x001CB0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse()
		{
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x001CCEDA File Offset: 0x001CB0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse(KurotatoEndShopStepResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C210 RID: 49680 RVA: 0x001CCEFF File Offset: 0x001CB0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse Clone()
		{
			return new KurotatoEndShopStepResponse(this);
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600C211 RID: 49681 RVA: 0x001CCF07 File Offset: 0x001CB107
		// (set) Token: 0x0600C212 RID: 49682 RVA: 0x001CCF0F File Offset: 0x001CB10F
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

		// Token: 0x0600C213 RID: 49683 RVA: 0x001CCF18 File Offset: 0x001CB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndShopStepResponse);
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x001CCF26 File Offset: 0x001CB126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndShopStepResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x001CCF54 File Offset: 0x001CB154
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

		// Token: 0x0600C216 RID: 49686 RVA: 0x001CCF99 File Offset: 0x001CB199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x001CCFA6 File Offset: 0x001CB1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x001CCFAF File Offset: 0x001CB1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x001CCFE4 File Offset: 0x001CB1E4
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

		// Token: 0x0600C21A RID: 49690 RVA: 0x001CD022 File Offset: 0x001CB222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndShopStepResponse other)
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

		// Token: 0x0600C21B RID: 49691 RVA: 0x001CD053 File Offset: 0x001CB253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x001CD05C File Offset: 0x001CB25C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005466 RID: 21606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005467 RID: 21607
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005468 RID: 21608
		private ErrorCode errorCode_;
	}
}
