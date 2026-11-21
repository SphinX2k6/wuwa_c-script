using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DA RID: 4826
	[NetMessage(EMessageId.SpecialItemUnEquipResponse)]
	public sealed class SpecialItemUnEquipResponse : IMessage<SpecialItemUnEquipResponse>, IMessage, IEquatable<SpecialItemUnEquipResponse>, IDeepCloneable<SpecialItemUnEquipResponse>, IBufferMessage
	{
		// Token: 0x06019C10 RID: 105488 RVA: 0x003C1AB6 File Offset: 0x003BFCB6
		[NullableContext(1)]
		public static SpecialItemUnEquipResponse Create()
		{
			return new SpecialItemUnEquipResponse();
		}

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x06019C11 RID: 105489 RVA: 0x003C1ABD File Offset: 0x003BFCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x06019C12 RID: 105490 RVA: 0x003C1AC0 File Offset: 0x003BFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemUnEquipResponse.Descriptor;
			}
		}

		// Token: 0x06019C13 RID: 105491 RVA: 0x003C1AC7 File Offset: 0x003BFCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse()
		{
		}

		// Token: 0x06019C14 RID: 105492 RVA: 0x003C1ACF File Offset: 0x003BFCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse(SpecialItemUnEquipResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C15 RID: 105493 RVA: 0x003C1AF4 File Offset: 0x003BFCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipResponse Clone()
		{
			return new SpecialItemUnEquipResponse(this);
		}

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x06019C16 RID: 105494 RVA: 0x003C1AFC File Offset: 0x003BFCFC
		// (set) Token: 0x06019C17 RID: 105495 RVA: 0x003C1B04 File Offset: 0x003BFD04
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

		// Token: 0x06019C18 RID: 105496 RVA: 0x003C1B0D File Offset: 0x003BFD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemUnEquipResponse);
		}

		// Token: 0x06019C19 RID: 105497 RVA: 0x003C1B1B File Offset: 0x003BFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemUnEquipResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C1A RID: 105498 RVA: 0x003C1B4C File Offset: 0x003BFD4C
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

		// Token: 0x06019C1B RID: 105499 RVA: 0x003C1B91 File Offset: 0x003BFD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C1C RID: 105500 RVA: 0x003C1B9E File Offset: 0x003BFD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C1D RID: 105501 RVA: 0x003C1BA7 File Offset: 0x003BFDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C1E RID: 105502 RVA: 0x003C1BDC File Offset: 0x003BFDDC
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

		// Token: 0x06019C1F RID: 105503 RVA: 0x003C1C1A File Offset: 0x003BFE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemUnEquipResponse other)
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

		// Token: 0x06019C20 RID: 105504 RVA: 0x003C1C4B File Offset: 0x003BFE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C21 RID: 105505 RVA: 0x003C1C54 File Offset: 0x003BFE54
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009803 RID: 38915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009804 RID: 38916
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009805 RID: 38917
		private ErrorCode errorCode_;
	}
}
