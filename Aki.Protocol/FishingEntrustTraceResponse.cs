using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000557 RID: 1367
	[NetMessage(EMessageId.FishingEntrustTraceResponse)]
	public sealed class FishingEntrustTraceResponse : IMessage<FishingEntrustTraceResponse>, IMessage, IEquatable<FishingEntrustTraceResponse>, IDeepCloneable<FishingEntrustTraceResponse>, IBufferMessage
	{
		// Token: 0x06007F9B RID: 32667 RVA: 0x0013481D File Offset: 0x00132A1D
		[NullableContext(1)]
		public static FishingEntrustTraceResponse Create()
		{
			return new FishingEntrustTraceResponse();
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06007F9C RID: 32668 RVA: 0x00134824 File Offset: 0x00132A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06007F9D RID: 32669 RVA: 0x00134827 File Offset: 0x00132A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustTraceResponse.Descriptor;
			}
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x0013482E File Offset: 0x00132A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse()
		{
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x00134836 File Offset: 0x00132A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse(FishingEntrustTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x0013485B File Offset: 0x00132A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse Clone()
		{
			return new FishingEntrustTraceResponse(this);
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x00134863 File Offset: 0x00132A63
		// (set) Token: 0x06007FA2 RID: 32674 RVA: 0x0013486B File Offset: 0x00132A6B
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

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00134874 File Offset: 0x00132A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustTraceResponse);
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00134882 File Offset: 0x00132A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x001348B0 File Offset: 0x00132AB0
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

		// Token: 0x06007FA6 RID: 32678 RVA: 0x001348F5 File Offset: 0x00132AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x00134902 File Offset: 0x00132B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x0013490B File Offset: 0x00132B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x00134940 File Offset: 0x00132B40
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

		// Token: 0x06007FAA RID: 32682 RVA: 0x0013497E File Offset: 0x00132B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustTraceResponse other)
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

		// Token: 0x06007FAB RID: 32683 RVA: 0x001349AF File Offset: 0x00132BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x001349B8 File Offset: 0x00132BB8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004069 RID: 16489
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400406A RID: 16490
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400406B RID: 16491
		private ErrorCode errorCode_;
	}
}
