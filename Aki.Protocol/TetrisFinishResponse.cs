using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001354 RID: 4948
	[NetMessage(EMessageId.TetrisFinishResponse)]
	public sealed class TetrisFinishResponse : IMessage<TetrisFinishResponse>, IMessage, IEquatable<TetrisFinishResponse>, IDeepCloneable<TetrisFinishResponse>, IBufferMessage
	{
		// Token: 0x0601A49C RID: 107676 RVA: 0x003D1C1F File Offset: 0x003CFE1F
		[NullableContext(1)]
		public static TetrisFinishResponse Create()
		{
			return new TetrisFinishResponse();
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x0601A49D RID: 107677 RVA: 0x003D1C26 File Offset: 0x003CFE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x0601A49E RID: 107678 RVA: 0x003D1C29 File Offset: 0x003CFE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601A49F RID: 107679 RVA: 0x003D1C30 File Offset: 0x003CFE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse()
		{
		}

		// Token: 0x0601A4A0 RID: 107680 RVA: 0x003D1C38 File Offset: 0x003CFE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse(TetrisFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4A1 RID: 107681 RVA: 0x003D1C5D File Offset: 0x003CFE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse Clone()
		{
			return new TetrisFinishResponse(this);
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x0601A4A2 RID: 107682 RVA: 0x003D1C65 File Offset: 0x003CFE65
		// (set) Token: 0x0601A4A3 RID: 107683 RVA: 0x003D1C6D File Offset: 0x003CFE6D
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

		// Token: 0x0601A4A4 RID: 107684 RVA: 0x003D1C76 File Offset: 0x003CFE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisFinishResponse);
		}

		// Token: 0x0601A4A5 RID: 107685 RVA: 0x003D1C84 File Offset: 0x003CFE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4A6 RID: 107686 RVA: 0x003D1CB4 File Offset: 0x003CFEB4
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

		// Token: 0x0601A4A7 RID: 107687 RVA: 0x003D1CF9 File Offset: 0x003CFEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4A8 RID: 107688 RVA: 0x003D1D06 File Offset: 0x003CFF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4A9 RID: 107689 RVA: 0x003D1D0F File Offset: 0x003CFF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4AA RID: 107690 RVA: 0x003D1D44 File Offset: 0x003CFF44
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

		// Token: 0x0601A4AB RID: 107691 RVA: 0x003D1D82 File Offset: 0x003CFF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisFinishResponse other)
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

		// Token: 0x0601A4AC RID: 107692 RVA: 0x003D1DB3 File Offset: 0x003CFFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4AD RID: 107693 RVA: 0x003D1DBC File Offset: 0x003CFFBC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400994E RID: 39246
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400994F RID: 39247
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009950 RID: 39248
		private ErrorCode errorCode_;
	}
}
