using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001588 RID: 5512
	[NetMessage(EMessageId.WellStreamingFinisResponse)]
	public sealed class WellStreamingFinisResponse : IMessage<WellStreamingFinisResponse>, IMessage, IEquatable<WellStreamingFinisResponse>, IDeepCloneable<WellStreamingFinisResponse>, IBufferMessage
	{
		// Token: 0x0601D2E2 RID: 119522 RVA: 0x004399E5 File Offset: 0x00437BE5
		[NullableContext(1)]
		public static WellStreamingFinisResponse Create()
		{
			return new WellStreamingFinisResponse();
		}

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x0601D2E3 RID: 119523 RVA: 0x004399EC File Offset: 0x00437BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x0601D2E4 RID: 119524 RVA: 0x004399EF File Offset: 0x00437BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WellStreamingFinisResponse.Descriptor;
			}
		}

		// Token: 0x0601D2E5 RID: 119525 RVA: 0x004399F6 File Offset: 0x00437BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse()
		{
		}

		// Token: 0x0601D2E6 RID: 119526 RVA: 0x004399FE File Offset: 0x00437BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse(WellStreamingFinisResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D2E7 RID: 119527 RVA: 0x00439A23 File Offset: 0x00437C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisResponse Clone()
		{
			return new WellStreamingFinisResponse(this);
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x0601D2E8 RID: 119528 RVA: 0x00439A2B File Offset: 0x00437C2B
		// (set) Token: 0x0601D2E9 RID: 119529 RVA: 0x00439A33 File Offset: 0x00437C33
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

		// Token: 0x0601D2EA RID: 119530 RVA: 0x00439A3C File Offset: 0x00437C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WellStreamingFinisResponse);
		}

		// Token: 0x0601D2EB RID: 119531 RVA: 0x00439A4A File Offset: 0x00437C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WellStreamingFinisResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D2EC RID: 119532 RVA: 0x00439A78 File Offset: 0x00437C78
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

		// Token: 0x0601D2ED RID: 119533 RVA: 0x00439ABD File Offset: 0x00437CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D2EE RID: 119534 RVA: 0x00439ACA File Offset: 0x00437CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D2EF RID: 119535 RVA: 0x00439AD3 File Offset: 0x00437CD3
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

		// Token: 0x0601D2F0 RID: 119536 RVA: 0x00439B08 File Offset: 0x00437D08
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

		// Token: 0x0601D2F1 RID: 119537 RVA: 0x00439B46 File Offset: 0x00437D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WellStreamingFinisResponse other)
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

		// Token: 0x0601D2F2 RID: 119538 RVA: 0x00439B77 File Offset: 0x00437D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D2F3 RID: 119539 RVA: 0x00439B80 File Offset: 0x00437D80
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

		// Token: 0x0400A775 RID: 42869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A776 RID: 42870
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A777 RID: 42871
		private ErrorCode errorCode_;
	}
}
