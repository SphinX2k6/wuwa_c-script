using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6D RID: 3437
	[NetMessage(EMessageId.PinballWeaponDegradeResponse)]
	public sealed class PinballWeaponDegradeResponse : IMessage<PinballWeaponDegradeResponse>, IMessage, IEquatable<PinballWeaponDegradeResponse>, IDeepCloneable<PinballWeaponDegradeResponse>, IBufferMessage
	{
		// Token: 0x06012880 RID: 75904 RVA: 0x002B4129 File Offset: 0x002B2329
		[NullableContext(1)]
		public static PinballWeaponDegradeResponse Create()
		{
			return new PinballWeaponDegradeResponse();
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x06012881 RID: 75905 RVA: 0x002B4130 File Offset: 0x002B2330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x06012882 RID: 75906 RVA: 0x002B4133 File Offset: 0x002B2333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponDegradeResponse.Descriptor;
			}
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x002B413A File Offset: 0x002B233A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse()
		{
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x002B4142 File Offset: 0x002B2342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse(PinballWeaponDegradeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x002B4167 File Offset: 0x002B2367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeResponse Clone()
		{
			return new PinballWeaponDegradeResponse(this);
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x06012886 RID: 75910 RVA: 0x002B416F File Offset: 0x002B236F
		// (set) Token: 0x06012887 RID: 75911 RVA: 0x002B4177 File Offset: 0x002B2377
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

		// Token: 0x06012888 RID: 75912 RVA: 0x002B4180 File Offset: 0x002B2380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponDegradeResponse);
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x002B418E File Offset: 0x002B238E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponDegradeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x002B41BC File Offset: 0x002B23BC
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

		// Token: 0x0601288B RID: 75915 RVA: 0x002B4201 File Offset: 0x002B2401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x002B420E File Offset: 0x002B240E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601288D RID: 75917 RVA: 0x002B4217 File Offset: 0x002B2417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x002B424C File Offset: 0x002B244C
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

		// Token: 0x0601288F RID: 75919 RVA: 0x002B428A File Offset: 0x002B248A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponDegradeResponse other)
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

		// Token: 0x06012890 RID: 75920 RVA: 0x002B42BB File Offset: 0x002B24BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x002B42C4 File Offset: 0x002B24C4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007323 RID: 29475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007324 RID: 29476
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04007325 RID: 29477
		private ErrorCode errorCode_;
	}
}
