using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D70 RID: 3440
	[NetMessage(EMessageId.PinballWeaponWearResponse)]
	public sealed class PinballWeaponWearResponse : IMessage<PinballWeaponWearResponse>, IMessage, IEquatable<PinballWeaponWearResponse>, IDeepCloneable<PinballWeaponWearResponse>, IBufferMessage
	{
		// Token: 0x060128B8 RID: 75960 RVA: 0x002B4784 File Offset: 0x002B2984
		[NullableContext(1)]
		public static PinballWeaponWearResponse Create()
		{
			return new PinballWeaponWearResponse();
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x060128B9 RID: 75961 RVA: 0x002B478B File Offset: 0x002B298B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x060128BA RID: 75962 RVA: 0x002B478E File Offset: 0x002B298E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponWearResponse.Descriptor;
			}
		}

		// Token: 0x060128BB RID: 75963 RVA: 0x002B4795 File Offset: 0x002B2995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse()
		{
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x002B479D File Offset: 0x002B299D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse(PinballWeaponWearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x002B47C2 File Offset: 0x002B29C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearResponse Clone()
		{
			return new PinballWeaponWearResponse(this);
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x060128BE RID: 75966 RVA: 0x002B47CA File Offset: 0x002B29CA
		// (set) Token: 0x060128BF RID: 75967 RVA: 0x002B47D2 File Offset: 0x002B29D2
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

		// Token: 0x060128C0 RID: 75968 RVA: 0x002B47DB File Offset: 0x002B29DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponWearResponse);
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x002B47E9 File Offset: 0x002B29E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponWearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x002B4818 File Offset: 0x002B2A18
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

		// Token: 0x060128C3 RID: 75971 RVA: 0x002B485D File Offset: 0x002B2A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128C4 RID: 75972 RVA: 0x002B486A File Offset: 0x002B2A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128C5 RID: 75973 RVA: 0x002B4873 File Offset: 0x002B2A73
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

		// Token: 0x060128C6 RID: 75974 RVA: 0x002B48A8 File Offset: 0x002B2AA8
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

		// Token: 0x060128C7 RID: 75975 RVA: 0x002B48E6 File Offset: 0x002B2AE6
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

		// Token: 0x060128C8 RID: 75976 RVA: 0x002B4917 File Offset: 0x002B2B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128C9 RID: 75977 RVA: 0x002B4920 File Offset: 0x002B2B20
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

		// Token: 0x0400732F RID: 29487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007330 RID: 29488
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007331 RID: 29489
		private ErrorCode errorCode_;
	}
}
