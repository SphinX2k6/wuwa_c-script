using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000265 RID: 613
	[NetMessage(EMessageId.ChangeSummonEntityStateResponse)]
	public sealed class ChangeSummonEntityStateResponse : IMessage<ChangeSummonEntityStateResponse>, IMessage, IEquatable<ChangeSummonEntityStateResponse>, IDeepCloneable<ChangeSummonEntityStateResponse>, IBufferMessage
	{
		// Token: 0x060040C5 RID: 16581 RVA: 0x0009EF90 File Offset: 0x0009D190
		[NullableContext(1)]
		public static ChangeSummonEntityStateResponse Create()
		{
			return new ChangeSummonEntityStateResponse();
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0009EF97 File Offset: 0x0009D197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x0009EF9A File Offset: 0x0009D19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSummonEntityStateResponse.Descriptor;
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0009EFA1 File Offset: 0x0009D1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse()
		{
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0009EFA9 File Offset: 0x0009D1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse(ChangeSummonEntityStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x0009EFCE File Offset: 0x0009D1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateResponse Clone()
		{
			return new ChangeSummonEntityStateResponse(this);
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x0009EFD6 File Offset: 0x0009D1D6
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x0009EFDE File Offset: 0x0009D1DE
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

		// Token: 0x060040CD RID: 16589 RVA: 0x0009EFE7 File Offset: 0x0009D1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSummonEntityStateResponse);
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0009EFF5 File Offset: 0x0009D1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSummonEntityStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x0009F024 File Offset: 0x0009D224
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

		// Token: 0x060040D0 RID: 16592 RVA: 0x0009F069 File Offset: 0x0009D269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x0009F076 File Offset: 0x0009D276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0009F07F File Offset: 0x0009D27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x0009F0B4 File Offset: 0x0009D2B4
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

		// Token: 0x060040D4 RID: 16596 RVA: 0x0009F0F2 File Offset: 0x0009D2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSummonEntityStateResponse other)
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

		// Token: 0x060040D5 RID: 16597 RVA: 0x0009F123 File Offset: 0x0009D323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0009F12C File Offset: 0x0009D32C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D7A RID: 11642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D7B RID: 11643
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002D7C RID: 11644
		private ErrorCode errorCode_;
	}
}
