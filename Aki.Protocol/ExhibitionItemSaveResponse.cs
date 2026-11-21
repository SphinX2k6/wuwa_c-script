using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D4 RID: 1236
	[NetMessage(EMessageId.ExhibitionItemSaveResponse)]
	public sealed class ExhibitionItemSaveResponse : IMessage<ExhibitionItemSaveResponse>, IMessage, IEquatable<ExhibitionItemSaveResponse>, IDeepCloneable<ExhibitionItemSaveResponse>, IBufferMessage
	{
		// Token: 0x06007597 RID: 30103 RVA: 0x0011FEF5 File Offset: 0x0011E0F5
		[NullableContext(1)]
		public static ExhibitionItemSaveResponse Create()
		{
			return new ExhibitionItemSaveResponse();
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06007598 RID: 30104 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06007599 RID: 30105 RVA: 0x0011FEFF File Offset: 0x0011E0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionItemSaveResponse.Descriptor;
			}
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x0011FF06 File Offset: 0x0011E106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse()
		{
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x0011FF0E File Offset: 0x0011E10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse(ExhibitionItemSaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x0011FF33 File Offset: 0x0011E133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse Clone()
		{
			return new ExhibitionItemSaveResponse(this);
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x0011FF3B File Offset: 0x0011E13B
		// (set) Token: 0x0600759E RID: 30110 RVA: 0x0011FF43 File Offset: 0x0011E143
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

		// Token: 0x0600759F RID: 30111 RVA: 0x0011FF4C File Offset: 0x0011E14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionItemSaveResponse);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x0011FF5A File Offset: 0x0011E15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionItemSaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x0011FF88 File Offset: 0x0011E188
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

		// Token: 0x060075A2 RID: 30114 RVA: 0x0011FFCD File Offset: 0x0011E1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x0011FFDA File Offset: 0x0011E1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x0011FFE3 File Offset: 0x0011E1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00120018 File Offset: 0x0011E218
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

		// Token: 0x060075A6 RID: 30118 RVA: 0x00120056 File Offset: 0x0011E256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExhibitionItemSaveResponse other)
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

		// Token: 0x060075A7 RID: 30119 RVA: 0x00120087 File Offset: 0x0011E287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00120090 File Offset: 0x0011E290
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E10 RID: 15888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E11 RID: 15889
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x04003E12 RID: 15890
		private ErrorCode errCode_;
	}
}
