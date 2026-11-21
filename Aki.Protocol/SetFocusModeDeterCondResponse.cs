using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120E RID: 4622
	[NetMessage(EMessageId.SetFocusModeDeterCondResponse)]
	public sealed class SetFocusModeDeterCondResponse : IMessage<SetFocusModeDeterCondResponse>, IMessage, IEquatable<SetFocusModeDeterCondResponse>, IDeepCloneable<SetFocusModeDeterCondResponse>, IBufferMessage
	{
		// Token: 0x06018B0F RID: 101135 RVA: 0x00399AFD File Offset: 0x00397CFD
		[NullableContext(1)]
		public static SetFocusModeDeterCondResponse Create()
		{
			return new SetFocusModeDeterCondResponse();
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x06018B10 RID: 101136 RVA: 0x00399B04 File Offset: 0x00397D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x06018B11 RID: 101137 RVA: 0x00399B07 File Offset: 0x00397D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFocusModeDeterCondResponse.Descriptor;
			}
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x00399B0E File Offset: 0x00397D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse()
		{
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x00399B16 File Offset: 0x00397D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse(SetFocusModeDeterCondResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x00399B3B File Offset: 0x00397D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFocusModeDeterCondResponse Clone()
		{
			return new SetFocusModeDeterCondResponse(this);
		}

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x06018B15 RID: 101141 RVA: 0x00399B43 File Offset: 0x00397D43
		// (set) Token: 0x06018B16 RID: 101142 RVA: 0x00399B4B File Offset: 0x00397D4B
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

		// Token: 0x06018B17 RID: 101143 RVA: 0x00399B54 File Offset: 0x00397D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFocusModeDeterCondResponse);
		}

		// Token: 0x06018B18 RID: 101144 RVA: 0x00399B62 File Offset: 0x00397D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFocusModeDeterCondResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B19 RID: 101145 RVA: 0x00399B90 File Offset: 0x00397D90
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

		// Token: 0x06018B1A RID: 101146 RVA: 0x00399BD5 File Offset: 0x00397DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B1B RID: 101147 RVA: 0x00399BE2 File Offset: 0x00397DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B1C RID: 101148 RVA: 0x00399BEB File Offset: 0x00397DEB
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

		// Token: 0x06018B1D RID: 101149 RVA: 0x00399C20 File Offset: 0x00397E20
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

		// Token: 0x06018B1E RID: 101150 RVA: 0x00399C5E File Offset: 0x00397E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFocusModeDeterCondResponse other)
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

		// Token: 0x06018B1F RID: 101151 RVA: 0x00399C8F File Offset: 0x00397E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B20 RID: 101152 RVA: 0x00399C98 File Offset: 0x00397E98
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

		// Token: 0x040092A5 RID: 37541
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A6 RID: 37542
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040092A7 RID: 37543
		private ErrorCode errorCode_;
	}
}
