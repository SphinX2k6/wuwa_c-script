using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D54 RID: 3412
	[NetMessage(EMessageId.PinballTaskRewardResponse)]
	public sealed class PinballTaskRewardResponse : IMessage<PinballTaskRewardResponse>, IMessage, IEquatable<PinballTaskRewardResponse>, IDeepCloneable<PinballTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060126D2 RID: 75474 RVA: 0x002B0D71 File Offset: 0x002AEF71
		[NullableContext(1)]
		public static PinballTaskRewardResponse Create()
		{
			return new PinballTaskRewardResponse();
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x060126D3 RID: 75475 RVA: 0x002B0D78 File Offset: 0x002AEF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x060126D4 RID: 75476 RVA: 0x002B0D7B File Offset: 0x002AEF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060126D5 RID: 75477 RVA: 0x002B0D82 File Offset: 0x002AEF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse()
		{
		}

		// Token: 0x060126D6 RID: 75478 RVA: 0x002B0D8A File Offset: 0x002AEF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse(PinballTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x002B0DAF File Offset: 0x002AEFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse Clone()
		{
			return new PinballTaskRewardResponse(this);
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x060126D8 RID: 75480 RVA: 0x002B0DB7 File Offset: 0x002AEFB7
		// (set) Token: 0x060126D9 RID: 75481 RVA: 0x002B0DBF File Offset: 0x002AEFBF
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

		// Token: 0x060126DA RID: 75482 RVA: 0x002B0DC8 File Offset: 0x002AEFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTaskRewardResponse);
		}

		// Token: 0x060126DB RID: 75483 RVA: 0x002B0DD6 File Offset: 0x002AEFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126DC RID: 75484 RVA: 0x002B0E04 File Offset: 0x002AF004
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

		// Token: 0x060126DD RID: 75485 RVA: 0x002B0E49 File Offset: 0x002AF049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126DE RID: 75486 RVA: 0x002B0E56 File Offset: 0x002AF056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126DF RID: 75487 RVA: 0x002B0E5F File Offset: 0x002AF05F
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

		// Token: 0x060126E0 RID: 75488 RVA: 0x002B0E94 File Offset: 0x002AF094
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

		// Token: 0x060126E1 RID: 75489 RVA: 0x002B0ED2 File Offset: 0x002AF0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTaskRewardResponse other)
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

		// Token: 0x060126E2 RID: 75490 RVA: 0x002B0F03 File Offset: 0x002AF103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126E3 RID: 75491 RVA: 0x002B0F0C File Offset: 0x002AF10C
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

		// Token: 0x04007315 RID: 29461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007316 RID: 29462
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007317 RID: 29463
		private ErrorCode errorCode_;
	}
}
