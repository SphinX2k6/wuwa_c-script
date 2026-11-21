using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000237 RID: 567
	[NetMessage(EMessageId.CancelMatchResponse)]
	public sealed class CancelMatchResponse : IMessage<CancelMatchResponse>, IMessage, IEquatable<CancelMatchResponse>, IDeepCloneable<CancelMatchResponse>, IBufferMessage
	{
		// Token: 0x06003D7E RID: 15742 RVA: 0x00098BEE File Offset: 0x00096DEE
		[NullableContext(1)]
		public static CancelMatchResponse Create()
		{
			return new CancelMatchResponse();
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00098BF5 File Offset: 0x00096DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x00098BF8 File Offset: 0x00096DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchResponse.Descriptor;
			}
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00098BFF File Offset: 0x00096DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse()
		{
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00098C07 File Offset: 0x00096E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse(CancelMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00098C2C File Offset: 0x00096E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse Clone()
		{
			return new CancelMatchResponse(this);
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00098C34 File Offset: 0x00096E34
		// (set) Token: 0x06003D85 RID: 15749 RVA: 0x00098C3C File Offset: 0x00096E3C
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

		// Token: 0x06003D86 RID: 15750 RVA: 0x00098C45 File Offset: 0x00096E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchResponse);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00098C53 File Offset: 0x00096E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00098C84 File Offset: 0x00096E84
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

		// Token: 0x06003D89 RID: 15753 RVA: 0x00098CC9 File Offset: 0x00096EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00098CD6 File Offset: 0x00096ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00098CDF File Offset: 0x00096EDF
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

		// Token: 0x06003D8C RID: 15756 RVA: 0x00098D14 File Offset: 0x00096F14
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

		// Token: 0x06003D8D RID: 15757 RVA: 0x00098D52 File Offset: 0x00096F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchResponse other)
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

		// Token: 0x06003D8E RID: 15758 RVA: 0x00098D83 File Offset: 0x00096F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00098D8C File Offset: 0x00096F8C
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

		// Token: 0x04002D09 RID: 11529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D0A RID: 11530
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002D0B RID: 11531
		private ErrorCode errorCode_;
	}
}
