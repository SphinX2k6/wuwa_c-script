using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001725 RID: 5925
	[NetMessage(EMessageId.AiBlackboardsResponse)]
	public sealed class AiBlackboardsResponse : IMessage<AiBlackboardsResponse>, IMessage, IEquatable<AiBlackboardsResponse>, IDeepCloneable<AiBlackboardsResponse>, IBufferMessage
	{
		// Token: 0x0601DBE2 RID: 121826 RVA: 0x0045CDD9 File Offset: 0x0045AFD9
		[NullableContext(1)]
		public static AiBlackboardsResponse Create()
		{
			return new AiBlackboardsResponse();
		}

		// Token: 0x17006545 RID: 25925
		// (get) Token: 0x0601DBE3 RID: 121827 RVA: 0x0045CDE0 File Offset: 0x0045AFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006546 RID: 25926
		// (get) Token: 0x0601DBE4 RID: 121828 RVA: 0x0045CDE3 File Offset: 0x0045AFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsResponse.Descriptor;
			}
		}

		// Token: 0x0601DBE5 RID: 121829 RVA: 0x0045CDEA File Offset: 0x0045AFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse()
		{
		}

		// Token: 0x0601DBE6 RID: 121830 RVA: 0x0045CDF2 File Offset: 0x0045AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse(AiBlackboardsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DBE7 RID: 121831 RVA: 0x0045CE17 File Offset: 0x0045B017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse Clone()
		{
			return new AiBlackboardsResponse(this);
		}

		// Token: 0x17006547 RID: 25927
		// (get) Token: 0x0601DBE8 RID: 121832 RVA: 0x0045CE1F File Offset: 0x0045B01F
		// (set) Token: 0x0601DBE9 RID: 121833 RVA: 0x0045CE27 File Offset: 0x0045B027
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

		// Token: 0x0601DBEA RID: 121834 RVA: 0x0045CE30 File Offset: 0x0045B030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsResponse);
		}

		// Token: 0x0601DBEB RID: 121835 RVA: 0x0045CE3E File Offset: 0x0045B03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DBEC RID: 121836 RVA: 0x0045CE6C File Offset: 0x0045B06C
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

		// Token: 0x0601DBED RID: 121837 RVA: 0x0045CEB1 File Offset: 0x0045B0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DBEE RID: 121838 RVA: 0x0045CEBE File Offset: 0x0045B0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DBEF RID: 121839 RVA: 0x0045CEC7 File Offset: 0x0045B0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x0045CEFC File Offset: 0x0045B0FC
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

		// Token: 0x0601DBF1 RID: 121841 RVA: 0x0045CF3A File Offset: 0x0045B13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsResponse other)
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

		// Token: 0x0601DBF2 RID: 121842 RVA: 0x0045CF6B File Offset: 0x0045B16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x0045CF74 File Offset: 0x0045B174
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C954 RID: 51540
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C955 RID: 51541
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400C956 RID: 51542
		private ErrorCode errorCode_;
	}
}
