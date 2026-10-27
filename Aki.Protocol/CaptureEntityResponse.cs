using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000238 RID: 568
	[NetMessage(EMessageId.CaptureEntityResponse)]
	public sealed class CaptureEntityResponse : IMessage<CaptureEntityResponse>, IMessage, IEquatable<CaptureEntityResponse>, IDeepCloneable<CaptureEntityResponse>, IBufferMessage
	{
		// Token: 0x06003D49 RID: 15689 RVA: 0x00097CA5 File Offset: 0x00095EA5
		[NullableContext(1)]
		public static CaptureEntityResponse Create()
		{
			return new CaptureEntityResponse();
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00097CAC File Offset: 0x00095EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00097CAF File Offset: 0x00095EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureEntityResponse.Descriptor;
			}
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00097CB6 File Offset: 0x00095EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse()
		{
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00097CBE File Offset: 0x00095EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse(CaptureEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00097CEF File Offset: 0x00095EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse Clone()
		{
			return new CaptureEntityResponse(this);
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x00097CF7 File Offset: 0x00095EF7
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x00097CFF File Offset: 0x00095EFF
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

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x00097D08 File Offset: 0x00095F08
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00097D10 File Offset: 0x00095F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00097D19 File Offset: 0x00095F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureEntityResponse);
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00097D27 File Offset: 0x00095F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00097D68 File Offset: 0x00095F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00097DC6 File Offset: 0x00095FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00097DD3 File Offset: 0x00095FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00097DDC File Offset: 0x00095FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00097E38 File Offset: 0x00096038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00097E90 File Offset: 0x00096090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureEntityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00097EE0 File Offset: 0x000960E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00097EEC File Offset: 0x000960EC
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002C9F RID: 11423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CA0 RID: 11424
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04002CA1 RID: 11425
		private ErrorCode errCode_;

		// Token: 0x04002CA2 RID: 11426
		public const int IdFieldNumber = 7;

		// Token: 0x04002CA3 RID: 11427
		private long id_;
	}
}
