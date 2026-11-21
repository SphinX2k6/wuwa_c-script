using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EB RID: 2027
	[NetMessage(EMessageId.InfrV2ManualCancelTraceTreeResponse)]
	public sealed class InfrV2ManualCancelTraceTreeResponse : IMessage<InfrV2ManualCancelTraceTreeResponse>, IMessage, IEquatable<InfrV2ManualCancelTraceTreeResponse>, IDeepCloneable<InfrV2ManualCancelTraceTreeResponse>, IBufferMessage
	{
		// Token: 0x0600B5F6 RID: 46582 RVA: 0x001B268E File Offset: 0x001B088E
		[NullableContext(1)]
		public static InfrV2ManualCancelTraceTreeResponse Create()
		{
			return new InfrV2ManualCancelTraceTreeResponse();
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600B5F7 RID: 46583 RVA: 0x001B2695 File Offset: 0x001B0895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600B5F8 RID: 46584 RVA: 0x001B2698 File Offset: 0x001B0898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualCancelTraceTreeResponse.Descriptor;
			}
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001B269F File Offset: 0x001B089F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse()
		{
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x001B26A7 File Offset: 0x001B08A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse(InfrV2ManualCancelTraceTreeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x001B26CC File Offset: 0x001B08CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeResponse Clone()
		{
			return new InfrV2ManualCancelTraceTreeResponse(this);
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x001B26D4 File Offset: 0x001B08D4
		// (set) Token: 0x0600B5FD RID: 46589 RVA: 0x001B26DC File Offset: 0x001B08DC
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

		// Token: 0x0600B5FE RID: 46590 RVA: 0x001B26E5 File Offset: 0x001B08E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualCancelTraceTreeResponse);
		}

		// Token: 0x0600B5FF RID: 46591 RVA: 0x001B26F3 File Offset: 0x001B08F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualCancelTraceTreeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B600 RID: 46592 RVA: 0x001B2724 File Offset: 0x001B0924
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

		// Token: 0x0600B601 RID: 46593 RVA: 0x001B2769 File Offset: 0x001B0969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x001B2776 File Offset: 0x001B0976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x001B277F File Offset: 0x001B097F
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

		// Token: 0x0600B604 RID: 46596 RVA: 0x001B27B0 File Offset: 0x001B09B0
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

		// Token: 0x0600B605 RID: 46597 RVA: 0x001B27EE File Offset: 0x001B09EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualCancelTraceTreeResponse other)
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

		// Token: 0x0600B606 RID: 46598 RVA: 0x001B281F File Offset: 0x001B0A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x001B2828 File Offset: 0x001B0A28
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

		// Token: 0x040050ED RID: 20717
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050EE RID: 20718
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040050EF RID: 20719
		private ErrorCode errorCode_;
	}
}
