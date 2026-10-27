using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5D RID: 3421
	[NetMessage(EMessageId.PinballSetPayloadResponse)]
	public sealed class PinballSetPayloadResponse : IMessage<PinballSetPayloadResponse>, IMessage, IEquatable<PinballSetPayloadResponse>, IDeepCloneable<PinballSetPayloadResponse>, IBufferMessage
	{
		// Token: 0x0601273E RID: 75582 RVA: 0x002B1588 File Offset: 0x002AF788
		[NullableContext(1)]
		public static PinballSetPayloadResponse Create()
		{
			return new PinballSetPayloadResponse();
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0601273F RID: 75583 RVA: 0x002B158F File Offset: 0x002AF78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x06012740 RID: 75584 RVA: 0x002B1592 File Offset: 0x002AF792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSetPayloadResponse.Descriptor;
			}
		}

		// Token: 0x06012741 RID: 75585 RVA: 0x002B1599 File Offset: 0x002AF799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse()
		{
		}

		// Token: 0x06012742 RID: 75586 RVA: 0x002B15A1 File Offset: 0x002AF7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse(PinballSetPayloadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012743 RID: 75587 RVA: 0x002B15C6 File Offset: 0x002AF7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadResponse Clone()
		{
			return new PinballSetPayloadResponse(this);
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x06012744 RID: 75588 RVA: 0x002B15CE File Offset: 0x002AF7CE
		// (set) Token: 0x06012745 RID: 75589 RVA: 0x002B15D6 File Offset: 0x002AF7D6
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

		// Token: 0x06012746 RID: 75590 RVA: 0x002B15DF File Offset: 0x002AF7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSetPayloadResponse);
		}

		// Token: 0x06012747 RID: 75591 RVA: 0x002B15ED File Offset: 0x002AF7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSetPayloadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012748 RID: 75592 RVA: 0x002B161C File Offset: 0x002AF81C
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

		// Token: 0x06012749 RID: 75593 RVA: 0x002B1661 File Offset: 0x002AF861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601274A RID: 75594 RVA: 0x002B166E File Offset: 0x002AF86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601274B RID: 75595 RVA: 0x002B1677 File Offset: 0x002AF877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601274C RID: 75596 RVA: 0x002B16AC File Offset: 0x002AF8AC
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

		// Token: 0x0601274D RID: 75597 RVA: 0x002B16EA File Offset: 0x002AF8EA
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

		// Token: 0x0601274E RID: 75598 RVA: 0x002B171B File Offset: 0x002AF91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601274F RID: 75599 RVA: 0x002B1724 File Offset: 0x002AF924
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040072D4 RID: 29396
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072D5 RID: 29397
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040072D6 RID: 29398
		private ErrorCode errorCode_;
	}
}
