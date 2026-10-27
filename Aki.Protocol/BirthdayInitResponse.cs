using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019C RID: 412
	[NetMessage(EMessageId.BirthdayInitResponse)]
	public sealed class BirthdayInitResponse : IMessage<BirthdayInitResponse>, IMessage, IEquatable<BirthdayInitResponse>, IDeepCloneable<BirthdayInitResponse>, IBufferMessage
	{
		// Token: 0x060030AF RID: 12463 RVA: 0x0007C1ED File Offset: 0x0007A3ED
		[NullableContext(1)]
		public static BirthdayInitResponse Create()
		{
			return new BirthdayInitResponse();
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0007C1F7 File Offset: 0x0007A3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayInitResponse.Descriptor;
			}
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0007C1FE File Offset: 0x0007A3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse()
		{
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0007C206 File Offset: 0x0007A406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse(BirthdayInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0007C22B File Offset: 0x0007A42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitResponse Clone()
		{
			return new BirthdayInitResponse(this);
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x0007C233 File Offset: 0x0007A433
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x0007C23B File Offset: 0x0007A43B
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

		// Token: 0x060030B7 RID: 12471 RVA: 0x0007C244 File Offset: 0x0007A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayInitResponse);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0007C252 File Offset: 0x0007A452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0007C280 File Offset: 0x0007A480
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

		// Token: 0x060030BA RID: 12474 RVA: 0x0007C2C5 File Offset: 0x0007A4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0007C2D2 File Offset: 0x0007A4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0007C2DB File Offset: 0x0007A4DB
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

		// Token: 0x060030BD RID: 12477 RVA: 0x0007C310 File Offset: 0x0007A510
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

		// Token: 0x060030BE RID: 12478 RVA: 0x0007C34E File Offset: 0x0007A54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayInitResponse other)
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

		// Token: 0x060030BF RID: 12479 RVA: 0x0007C37F File Offset: 0x0007A57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x0007C388 File Offset: 0x0007A588
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

		// Token: 0x04002903 RID: 10499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002904 RID: 10500
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002905 RID: 10501
		private ErrorCode errorCode_;
	}
}
