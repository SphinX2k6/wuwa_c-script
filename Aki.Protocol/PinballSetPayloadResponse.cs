using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4D RID: 3405
	[NetMessage(EMessageId.PinballSetPayloadResponse)]
	public sealed class PinballSetPayloadResponse : IMessage<PinballSetPayloadResponse>, IMessage, IEquatable<PinballSetPayloadResponse>, IDeepCloneable<PinballSetPayloadResponse>, IBufferMessage
	{
		// Token: 0x06012642 RID: 75330 RVA: 0x002AF964 File Offset: 0x002ADB64
		[NullableContext(1)]
		public static PinballSetPayloadResponse Create()
		{
			return new PinballSetPayloadResponse();
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x06012643 RID: 75331 RVA: 0x002AF96B File Offset: 0x002ADB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x06012644 RID: 75332 RVA: 0x002AF96E File Offset: 0x002ADB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSetPayloadResponse.Descriptor;
			}
		}

		// Token: 0x06012645 RID: 75333 RVA: 0x002AF975 File Offset: 0x002ADB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse()
		{
		}

		// Token: 0x06012646 RID: 75334 RVA: 0x002AF97D File Offset: 0x002ADB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse(PinballSetPayloadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012647 RID: 75335 RVA: 0x002AF9A2 File Offset: 0x002ADBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse Clone()
		{
			return new PinballSetPayloadResponse(this);
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x06012648 RID: 75336 RVA: 0x002AF9AA File Offset: 0x002ADBAA
		// (set) Token: 0x06012649 RID: 75337 RVA: 0x002AF9B2 File Offset: 0x002ADBB2
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

		// Token: 0x0601264A RID: 75338 RVA: 0x002AF9BB File Offset: 0x002ADBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSetPayloadResponse);
		}

		// Token: 0x0601264B RID: 75339 RVA: 0x002AF9C9 File Offset: 0x002ADBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSetPayloadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601264C RID: 75340 RVA: 0x002AF9F8 File Offset: 0x002ADBF8
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

		// Token: 0x0601264D RID: 75341 RVA: 0x002AFA3D File Offset: 0x002ADC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601264E RID: 75342 RVA: 0x002AFA4A File Offset: 0x002ADC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601264F RID: 75343 RVA: 0x002AFA53 File Offset: 0x002ADC53
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

		// Token: 0x06012650 RID: 75344 RVA: 0x002AFA88 File Offset: 0x002ADC88
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

		// Token: 0x06012651 RID: 75345 RVA: 0x002AFAC6 File Offset: 0x002ADCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSetPayloadResponse other)
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

		// Token: 0x06012652 RID: 75346 RVA: 0x002AFAF7 File Offset: 0x002ADCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012653 RID: 75347 RVA: 0x002AFB00 File Offset: 0x002ADD00
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

		// Token: 0x040072EC RID: 29420
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072ED RID: 29421
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040072EE RID: 29422
		private ErrorCode errorCode_;
	}
}
