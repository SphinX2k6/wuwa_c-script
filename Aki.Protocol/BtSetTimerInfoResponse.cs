using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F3 RID: 499
	[NetMessage(EMessageId.BtSetTimerInfoResponse)]
	public sealed class BtSetTimerInfoResponse : IMessage<BtSetTimerInfoResponse>, IMessage, IEquatable<BtSetTimerInfoResponse>, IDeepCloneable<BtSetTimerInfoResponse>, IBufferMessage
	{
		// Token: 0x060037A5 RID: 14245 RVA: 0x0008B3E4 File Offset: 0x000895E4
		[NullableContext(1)]
		public static BtSetTimerInfoResponse Create()
		{
			return new BtSetTimerInfoResponse();
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x0008B3EB File Offset: 0x000895EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x0008B3EE File Offset: 0x000895EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSetTimerInfoResponse.Descriptor;
			}
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0008B3F5 File Offset: 0x000895F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse()
		{
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0008B3FD File Offset: 0x000895FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse(BtSetTimerInfoResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x0008B422 File Offset: 0x00089622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoResponse Clone()
		{
			return new BtSetTimerInfoResponse(this);
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0008B42A File Offset: 0x0008962A
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x0008B432 File Offset: 0x00089632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0008B43B File Offset: 0x0008963B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSetTimerInfoResponse);
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0008B449 File Offset: 0x00089649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSetTimerInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0008B478 File Offset: 0x00089678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x0008B4BD File Offset: 0x000896BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0008B4CA File Offset: 0x000896CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x0008B4D3 File Offset: 0x000896D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0008B508 File Offset: 0x00089708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0008B546 File Offset: 0x00089746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtSetTimerInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0008B577 File Offset: 0x00089777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x0008B580 File Offset: 0x00089780
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AF9 RID: 11001
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x04002AFA RID: 11002
		private ErrorCode errorId_;
	}
}
