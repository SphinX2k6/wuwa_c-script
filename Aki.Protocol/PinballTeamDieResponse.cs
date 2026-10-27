using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D66 RID: 3430
	[NetMessage(EMessageId.PinballTeamDieResponse)]
	public sealed class PinballTeamDieResponse : IMessage<PinballTeamDieResponse>, IMessage, IEquatable<PinballTeamDieResponse>, IDeepCloneable<PinballTeamDieResponse>, IBufferMessage
	{
		// Token: 0x060127F0 RID: 75760 RVA: 0x002B2CAE File Offset: 0x002B0EAE
		[NullableContext(1)]
		public static PinballTeamDieResponse Create()
		{
			return new PinballTeamDieResponse();
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x060127F1 RID: 75761 RVA: 0x002B2CB5 File Offset: 0x002B0EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x060127F2 RID: 75762 RVA: 0x002B2CB8 File Offset: 0x002B0EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamDieResponse.Descriptor;
			}
		}

		// Token: 0x060127F3 RID: 75763 RVA: 0x002B2CBF File Offset: 0x002B0EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse()
		{
		}

		// Token: 0x060127F4 RID: 75764 RVA: 0x002B2CC7 File Offset: 0x002B0EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse(PinballTeamDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127F5 RID: 75765 RVA: 0x002B2CEC File Offset: 0x002B0EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieResponse Clone()
		{
			return new PinballTeamDieResponse(this);
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x060127F6 RID: 75766 RVA: 0x002B2CF4 File Offset: 0x002B0EF4
		// (set) Token: 0x060127F7 RID: 75767 RVA: 0x002B2CFC File Offset: 0x002B0EFC
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

		// Token: 0x060127F8 RID: 75768 RVA: 0x002B2D05 File Offset: 0x002B0F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamDieResponse);
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x002B2D13 File Offset: 0x002B0F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127FA RID: 75770 RVA: 0x002B2D44 File Offset: 0x002B0F44
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

		// Token: 0x060127FB RID: 75771 RVA: 0x002B2D89 File Offset: 0x002B0F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127FC RID: 75772 RVA: 0x002B2D96 File Offset: 0x002B0F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127FD RID: 75773 RVA: 0x002B2D9F File Offset: 0x002B0F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127FE RID: 75774 RVA: 0x002B2DD4 File Offset: 0x002B0FD4
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

		// Token: 0x060127FF RID: 75775 RVA: 0x002B2E12 File Offset: 0x002B1012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamDieResponse other)
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

		// Token: 0x06012800 RID: 75776 RVA: 0x002B2E43 File Offset: 0x002B1043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012801 RID: 75777 RVA: 0x002B2E4C File Offset: 0x002B104C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007301 RID: 29441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007302 RID: 29442
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007303 RID: 29443
		private ErrorCode errorCode_;
	}
}
