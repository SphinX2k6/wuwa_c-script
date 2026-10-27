using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D41 RID: 3393
	[NetMessage(EMessageId.PinballBonusFullWinResponse)]
	public sealed class PinballBonusFullWinResponse : IMessage<PinballBonusFullWinResponse>, IMessage, IEquatable<PinballBonusFullWinResponse>, IDeepCloneable<PinballBonusFullWinResponse>, IBufferMessage
	{
		// Token: 0x060124EE RID: 74990 RVA: 0x002AC0D8 File Offset: 0x002AA2D8
		[NullableContext(1)]
		public static PinballBonusFullWinResponse Create()
		{
			return new PinballBonusFullWinResponse();
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x060124EF RID: 74991 RVA: 0x002AC0DF File Offset: 0x002AA2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x060124F0 RID: 74992 RVA: 0x002AC0E2 File Offset: 0x002AA2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballBonusFullWinResponse.Descriptor;
			}
		}

		// Token: 0x060124F1 RID: 74993 RVA: 0x002AC0E9 File Offset: 0x002AA2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse()
		{
		}

		// Token: 0x060124F2 RID: 74994 RVA: 0x002AC0F1 File Offset: 0x002AA2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse(PinballBonusFullWinResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124F3 RID: 74995 RVA: 0x002AC116 File Offset: 0x002AA316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse Clone()
		{
			return new PinballBonusFullWinResponse(this);
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x060124F4 RID: 74996 RVA: 0x002AC11E File Offset: 0x002AA31E
		// (set) Token: 0x060124F5 RID: 74997 RVA: 0x002AC126 File Offset: 0x002AA326
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

		// Token: 0x060124F6 RID: 74998 RVA: 0x002AC12F File Offset: 0x002AA32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballBonusFullWinResponse);
		}

		// Token: 0x060124F7 RID: 74999 RVA: 0x002AC13D File Offset: 0x002AA33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballBonusFullWinResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124F8 RID: 75000 RVA: 0x002AC16C File Offset: 0x002AA36C
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

		// Token: 0x060124F9 RID: 75001 RVA: 0x002AC1B1 File Offset: 0x002AA3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124FA RID: 75002 RVA: 0x002AC1BE File Offset: 0x002AA3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124FB RID: 75003 RVA: 0x002AC1C7 File Offset: 0x002AA3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124FC RID: 75004 RVA: 0x002AC1F8 File Offset: 0x002AA3F8
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

		// Token: 0x060124FD RID: 75005 RVA: 0x002AC236 File Offset: 0x002AA436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballBonusFullWinResponse other)
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

		// Token: 0x060124FE RID: 75006 RVA: 0x002AC267 File Offset: 0x002AA467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124FF RID: 75007 RVA: 0x002AC270 File Offset: 0x002AA470
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007222 RID: 29218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007223 RID: 29219
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04007224 RID: 29220
		private ErrorCode errCode_;
	}
}
