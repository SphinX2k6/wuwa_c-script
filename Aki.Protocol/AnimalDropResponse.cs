using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E8 RID: 232
	[NetMessage(EMessageId.AnimalDropResponse)]
	public sealed class AnimalDropResponse : IMessage<AnimalDropResponse>, IMessage, IEquatable<AnimalDropResponse>, IDeepCloneable<AnimalDropResponse>, IBufferMessage
	{
		// Token: 0x060021D4 RID: 8660 RVA: 0x0005A461 File Offset: 0x00058661
		[NullableContext(1)]
		public static AnimalDropResponse Create()
		{
			return new AnimalDropResponse();
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0005A468 File Offset: 0x00058668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0005A46B File Offset: 0x0005866B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDropResponse.Descriptor;
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0005A472 File Offset: 0x00058672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse()
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0005A47A File Offset: 0x0005867A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse(AnimalDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0005A49F File Offset: 0x0005869F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse Clone()
		{
			return new AnimalDropResponse(this);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x0005A4A7 File Offset: 0x000586A7
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x0005A4AF File Offset: 0x000586AF
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

		// Token: 0x060021DC RID: 8668 RVA: 0x0005A4B8 File Offset: 0x000586B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDropResponse);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0005A4C6 File Offset: 0x000586C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0005A4F4 File Offset: 0x000586F4
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

		// Token: 0x060021DF RID: 8671 RVA: 0x0005A539 File Offset: 0x00058739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0005A546 File Offset: 0x00058746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0005A54F File Offset: 0x0005874F
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

		// Token: 0x060021E2 RID: 8674 RVA: 0x0005A584 File Offset: 0x00058784
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

		// Token: 0x060021E3 RID: 8675 RVA: 0x0005A5C2 File Offset: 0x000587C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDropResponse other)
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

		// Token: 0x060021E4 RID: 8676 RVA: 0x0005A5F3 File Offset: 0x000587F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0005A5FC File Offset: 0x000587FC
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

		// Token: 0x04002451 RID: 9297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002452 RID: 9298
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002453 RID: 9299
		private ErrorCode errorCode_;
	}
}
