using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000200 RID: 512
	[NetMessage(EMessageId.BuffEffectResponse)]
	public sealed class BuffEffectResponse : IMessage<BuffEffectResponse>, IMessage, IEquatable<BuffEffectResponse>, IDeepCloneable<BuffEffectResponse>, IBufferMessage
	{
		// Token: 0x060038B6 RID: 14518 RVA: 0x0008D99C File Offset: 0x0008BB9C
		[NullableContext(1)]
		public static BuffEffectResponse Create()
		{
			return new BuffEffectResponse();
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x0008D9A3 File Offset: 0x0008BBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x0008D9A6 File Offset: 0x0008BBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectResponse.Descriptor;
			}
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x0008D9AD File Offset: 0x0008BBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse()
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0008D9B5 File Offset: 0x0008BBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse(BuffEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0008D9DA File Offset: 0x0008BBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse Clone()
		{
			return new BuffEffectResponse(this);
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x0008D9E2 File Offset: 0x0008BBE2
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x0008D9EA File Offset: 0x0008BBEA
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

		// Token: 0x060038BE RID: 14526 RVA: 0x0008D9F3 File Offset: 0x0008BBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectResponse);
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0008DA01 File Offset: 0x0008BC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0008DA30 File Offset: 0x0008BC30
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

		// Token: 0x060038C1 RID: 14529 RVA: 0x0008DA75 File Offset: 0x0008BC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0008DA82 File Offset: 0x0008BC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0008DA8B File Offset: 0x0008BC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0008DAC0 File Offset: 0x0008BCC0
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

		// Token: 0x060038C5 RID: 14533 RVA: 0x0008DAFE File Offset: 0x0008BCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectResponse other)
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

		// Token: 0x060038C6 RID: 14534 RVA: 0x0008DB2F File Offset: 0x0008BD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0008DB38 File Offset: 0x0008BD38
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B47 RID: 11079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B48 RID: 11080
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04002B49 RID: 11081
		private ErrorCode errCode_;
	}
}
