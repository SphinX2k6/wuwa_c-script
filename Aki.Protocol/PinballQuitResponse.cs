using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D54 RID: 3412
	[NetMessage(EMessageId.PinballQuitResponse)]
	public sealed class PinballQuitResponse : IMessage<PinballQuitResponse>, IMessage, IEquatable<PinballQuitResponse>, IDeepCloneable<PinballQuitResponse>, IBufferMessage
	{
		// Token: 0x06012676 RID: 75382 RVA: 0x002AF82F File Offset: 0x002ADA2F
		[NullableContext(1)]
		public static PinballQuitResponse Create()
		{
			return new PinballQuitResponse();
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x06012677 RID: 75383 RVA: 0x002AF836 File Offset: 0x002ADA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x06012678 RID: 75384 RVA: 0x002AF839 File Offset: 0x002ADA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballQuitResponse.Descriptor;
			}
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x002AF840 File Offset: 0x002ADA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse()
		{
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x002AF848 File Offset: 0x002ADA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse(PinballQuitResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601267B RID: 75387 RVA: 0x002AF86D File Offset: 0x002ADA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse Clone()
		{
			return new PinballQuitResponse(this);
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0601267C RID: 75388 RVA: 0x002AF875 File Offset: 0x002ADA75
		// (set) Token: 0x0601267D RID: 75389 RVA: 0x002AF87D File Offset: 0x002ADA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x002AF886 File Offset: 0x002ADA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballQuitResponse);
		}

		// Token: 0x0601267F RID: 75391 RVA: 0x002AF894 File Offset: 0x002ADA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballQuitResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012680 RID: 75392 RVA: 0x002AF8C4 File Offset: 0x002ADAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012681 RID: 75393 RVA: 0x002AF909 File Offset: 0x002ADB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012682 RID: 75394 RVA: 0x002AF916 File Offset: 0x002ADB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012683 RID: 75395 RVA: 0x002AF91F File Offset: 0x002ADB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012684 RID: 75396 RVA: 0x002AF954 File Offset: 0x002ADB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012685 RID: 75397 RVA: 0x002AF992 File Offset: 0x002ADB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballQuitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012686 RID: 75398 RVA: 0x002AF9C3 File Offset: 0x002ADBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012687 RID: 75399 RVA: 0x002AF9CC File Offset: 0x002ADBCC
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007290 RID: 29328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007291 RID: 29329
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x04007292 RID: 29330
		private ErrorCode errCode_;
	}
}
