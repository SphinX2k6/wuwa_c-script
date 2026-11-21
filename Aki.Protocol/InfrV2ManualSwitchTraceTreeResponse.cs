using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007ED RID: 2029
	[NetMessage(EMessageId.InfrV2ManualSwitchTraceTreeResponse)]
	public sealed class InfrV2ManualSwitchTraceTreeResponse : IMessage<InfrV2ManualSwitchTraceTreeResponse>, IMessage, IEquatable<InfrV2ManualSwitchTraceTreeResponse>, IDeepCloneable<InfrV2ManualSwitchTraceTreeResponse>, IBufferMessage
	{
		// Token: 0x0600B61A RID: 46618 RVA: 0x001B2A45 File Offset: 0x001B0C45
		[NullableContext(1)]
		public static InfrV2ManualSwitchTraceTreeResponse Create()
		{
			return new InfrV2ManualSwitchTraceTreeResponse();
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x0600B61B RID: 46619 RVA: 0x001B2A4C File Offset: 0x001B0C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x0600B61C RID: 46620 RVA: 0x001B2A4F File Offset: 0x001B0C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualSwitchTraceTreeResponse.Descriptor;
			}
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x001B2A56 File Offset: 0x001B0C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse()
		{
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x001B2A5E File Offset: 0x001B0C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse(InfrV2ManualSwitchTraceTreeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x001B2A83 File Offset: 0x001B0C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse Clone()
		{
			return new InfrV2ManualSwitchTraceTreeResponse(this);
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x0600B620 RID: 46624 RVA: 0x001B2A8B File Offset: 0x001B0C8B
		// (set) Token: 0x0600B621 RID: 46625 RVA: 0x001B2A93 File Offset: 0x001B0C93
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

		// Token: 0x0600B622 RID: 46626 RVA: 0x001B2A9C File Offset: 0x001B0C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualSwitchTraceTreeResponse);
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x001B2AAA File Offset: 0x001B0CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualSwitchTraceTreeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B624 RID: 46628 RVA: 0x001B2AD8 File Offset: 0x001B0CD8
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

		// Token: 0x0600B625 RID: 46629 RVA: 0x001B2B1D File Offset: 0x001B0D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x001B2B2A File Offset: 0x001B0D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x001B2B33 File Offset: 0x001B0D33
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

		// Token: 0x0600B628 RID: 46632 RVA: 0x001B2B68 File Offset: 0x001B0D68
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

		// Token: 0x0600B629 RID: 46633 RVA: 0x001B2BA6 File Offset: 0x001B0DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualSwitchTraceTreeResponse other)
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

		// Token: 0x0600B62A RID: 46634 RVA: 0x001B2BD7 File Offset: 0x001B0DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x001B2BE0 File Offset: 0x001B0DE0
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

		// Token: 0x040050F3 RID: 20723
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F4 RID: 20724
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040050F5 RID: 20725
		private ErrorCode errorCode_;
	}
}
