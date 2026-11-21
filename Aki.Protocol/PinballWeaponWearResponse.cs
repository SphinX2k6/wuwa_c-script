using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D60 RID: 3424
	[NetMessage(EMessageId.PinballWeaponWearResponse)]
	public sealed class PinballWeaponWearResponse : IMessage<PinballWeaponWearResponse>, IMessage, IEquatable<PinballWeaponWearResponse>, IDeepCloneable<PinballWeaponWearResponse>, IBufferMessage
	{
		// Token: 0x060127BC RID: 75708 RVA: 0x002B2B67 File Offset: 0x002B0D67
		[NullableContext(1)]
		public static PinballWeaponWearResponse Create()
		{
			return new PinballWeaponWearResponse();
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x060127BD RID: 75709 RVA: 0x002B2B6E File Offset: 0x002B0D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x060127BE RID: 75710 RVA: 0x002B2B71 File Offset: 0x002B0D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponWearResponse.Descriptor;
			}
		}

		// Token: 0x060127BF RID: 75711 RVA: 0x002B2B78 File Offset: 0x002B0D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse()
		{
		}

		// Token: 0x060127C0 RID: 75712 RVA: 0x002B2B80 File Offset: 0x002B0D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse(PinballWeaponWearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127C1 RID: 75713 RVA: 0x002B2BA5 File Offset: 0x002B0DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse Clone()
		{
			return new PinballWeaponWearResponse(this);
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x060127C2 RID: 75714 RVA: 0x002B2BAD File Offset: 0x002B0DAD
		// (set) Token: 0x060127C3 RID: 75715 RVA: 0x002B2BB5 File Offset: 0x002B0DB5
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

		// Token: 0x060127C4 RID: 75716 RVA: 0x002B2BBE File Offset: 0x002B0DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponWearResponse);
		}

		// Token: 0x060127C5 RID: 75717 RVA: 0x002B2BCC File Offset: 0x002B0DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponWearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127C6 RID: 75718 RVA: 0x002B2BFC File Offset: 0x002B0DFC
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

		// Token: 0x060127C7 RID: 75719 RVA: 0x002B2C41 File Offset: 0x002B0E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127C8 RID: 75720 RVA: 0x002B2C4E File Offset: 0x002B0E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x002B2C57 File Offset: 0x002B0E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127CA RID: 75722 RVA: 0x002B2C8C File Offset: 0x002B0E8C
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

		// Token: 0x060127CB RID: 75723 RVA: 0x002B2CCA File Offset: 0x002B0ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponWearResponse other)
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

		// Token: 0x060127CC RID: 75724 RVA: 0x002B2CFB File Offset: 0x002B0EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127CD RID: 75725 RVA: 0x002B2D04 File Offset: 0x002B0F04
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007347 RID: 29511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007348 RID: 29512
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007349 RID: 29513
		private ErrorCode errorCode_;
	}
}
