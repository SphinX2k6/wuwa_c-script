using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D4 RID: 1748
	[NetMessage(EMessageId.GetYuXueModeInfoResponse)]
	public sealed class GetYuXueModeInfoResponse : IMessage<GetYuXueModeInfoResponse>, IMessage, IEquatable<GetYuXueModeInfoResponse>, IDeepCloneable<GetYuXueModeInfoResponse>, IBufferMessage
	{
		// Token: 0x06009FAA RID: 40874 RVA: 0x00182D12 File Offset: 0x00180F12
		[NullableContext(1)]
		public static GetYuXueModeInfoResponse Create()
		{
			return new GetYuXueModeInfoResponse();
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x00182D19 File Offset: 0x00180F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06009FAC RID: 40876 RVA: 0x00182D1C File Offset: 0x00180F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetYuXueModeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x00182D23 File Offset: 0x00180F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse()
		{
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x00182D2B File Offset: 0x00180F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse(GetYuXueModeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x00182D50 File Offset: 0x00180F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetYuXueModeInfoResponse Clone()
		{
			return new GetYuXueModeInfoResponse(this);
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06009FB0 RID: 40880 RVA: 0x00182D58 File Offset: 0x00180F58
		// (set) Token: 0x06009FB1 RID: 40881 RVA: 0x00182D60 File Offset: 0x00180F60
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

		// Token: 0x06009FB2 RID: 40882 RVA: 0x00182D69 File Offset: 0x00180F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetYuXueModeInfoResponse);
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x00182D77 File Offset: 0x00180F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetYuXueModeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x00182DA8 File Offset: 0x00180FA8
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

		// Token: 0x06009FB5 RID: 40885 RVA: 0x00182DED File Offset: 0x00180FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x00182DFA File Offset: 0x00180FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x00182E03 File Offset: 0x00181003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x00182E38 File Offset: 0x00181038
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

		// Token: 0x06009FB9 RID: 40889 RVA: 0x00182E76 File Offset: 0x00181076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetYuXueModeInfoResponse other)
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

		// Token: 0x06009FBA RID: 40890 RVA: 0x00182EA7 File Offset: 0x001810A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x00182EB0 File Offset: 0x001810B0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A76 RID: 19062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A77 RID: 19063
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004A78 RID: 19064
		private ErrorCode errorCode_;
	}
}
