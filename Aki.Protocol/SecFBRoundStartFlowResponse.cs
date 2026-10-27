using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AF RID: 4527
	[NetMessage(EMessageId.SecFBRoundStartFlowResponse)]
	public sealed class SecFBRoundStartFlowResponse : IMessage<SecFBRoundStartFlowResponse>, IMessage, IEquatable<SecFBRoundStartFlowResponse>, IDeepCloneable<SecFBRoundStartFlowResponse>, IBufferMessage
	{
		// Token: 0x06018219 RID: 98841 RVA: 0x00381BE3 File Offset: 0x0037FDE3
		[NullableContext(1)]
		public static SecFBRoundStartFlowResponse Create()
		{
			return new SecFBRoundStartFlowResponse();
		}

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x0601821A RID: 98842 RVA: 0x00381BEA File Offset: 0x0037FDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x0601821B RID: 98843 RVA: 0x00381BED File Offset: 0x0037FDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundStartFlowResponse.Descriptor;
			}
		}

		// Token: 0x0601821C RID: 98844 RVA: 0x00381BF4 File Offset: 0x0037FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse()
		{
		}

		// Token: 0x0601821D RID: 98845 RVA: 0x00381BFC File Offset: 0x0037FDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse(SecFBRoundStartFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601821E RID: 98846 RVA: 0x00381C2D File Offset: 0x0037FE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse Clone()
		{
			return new SecFBRoundStartFlowResponse(this);
		}

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x0601821F RID: 98847 RVA: 0x00381C35 File Offset: 0x0037FE35
		// (set) Token: 0x06018220 RID: 98848 RVA: 0x00381C3D File Offset: 0x0037FE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x06018221 RID: 98849 RVA: 0x00381C46 File Offset: 0x0037FE46
		// (set) Token: 0x06018222 RID: 98850 RVA: 0x00381C4E File Offset: 0x0037FE4E
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

		// Token: 0x06018223 RID: 98851 RVA: 0x00381C57 File Offset: 0x0037FE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundStartFlowResponse);
		}

		// Token: 0x06018224 RID: 98852 RVA: 0x00381C65 File Offset: 0x0037FE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundStartFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018225 RID: 98853 RVA: 0x00381CA4 File Offset: 0x0037FEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
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

		// Token: 0x06018226 RID: 98854 RVA: 0x00381D02 File Offset: 0x0037FF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018227 RID: 98855 RVA: 0x00381D0F File Offset: 0x0037FF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018228 RID: 98856 RVA: 0x00381D18 File Offset: 0x0037FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.LogId);
			}
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

		// Token: 0x06018229 RID: 98857 RVA: 0x00381D70 File Offset: 0x0037FF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
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

		// Token: 0x0601822A RID: 98858 RVA: 0x00381DC8 File Offset: 0x0037FFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecFBRoundStartFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601822B RID: 98859 RVA: 0x00381E18 File Offset: 0x00380018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601822C RID: 98860 RVA: 0x00381E24 File Offset: 0x00380024
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.LogId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008EE5 RID: 36581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EE6 RID: 36582
		public const int LogIdFieldNumber = 1;

		// Token: 0x04008EE7 RID: 36583
		private long logId_;

		// Token: 0x04008EE8 RID: 36584
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008EE9 RID: 36585
		private ErrorCode errorCode_;
	}
}
